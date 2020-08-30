using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Mercury.Shop.Common.Dto;
using Mercury.Shop.Mvp.Events;
using Mercury.Shop.Mvp.Presenters;
using Mercury.Shop.Mvp.Views;

namespace Mercury.Shop.WinClient
{
    public partial class ProductsView : Form, IProductsView
    {
        private int PageNo = 0;
        private int PageSize = 500;

        private BindingList<ProductShortInfo> products = new BindingList<ProductShortInfo>();
        private ProductsPresenter presenter;

        public ProductsView()
        {
            InitializeComponent();
            this.Disposed += Form1_Disposed;

            presenter = new ProductsPresenter(this);
        }

        public event EventHandler GenerateProducts;
        public event EventHandler Cancel;
        public event EventHandler<GetProductsEventArgs> GetProducts;
        public event EventHandler<GetProductEventArgs> GetProduct;
        public event EventHandler<UpdateProductEventArgs> UpdateProduct;

        private void FireGetProducts(int pageNo, int pageSize)
        {
            var h = GetProducts;
            if (h != null)
                h(this, new GetProductsEventArgs { PageNo = pageNo, PageSize = pageSize});
        }

        private void Form1_Disposed(object sender, EventArgs e)
        {
            presenter.Dispose();
        }

        public void ClearProductCollection()
        {
            this.products.Clear();
            this.dataGridView1.Rows.Clear();
            this.PageNo = 0;
        }

        public void ClearProductControl()
        {
            this.productBindingSource.Clear();
        }

        public void AddProductsToCollection(IList<ProductShortInfo> prod)
        {
            if (prod.Any())
            {
                Debug.WriteLine("Binding UI. Current thread is " + System.Threading.Thread.CurrentThread.ManagedThreadId);

                foreach (var p in prod)
                    this.products.Add(p);

                this.dataGridView1.RowCount = this.products.Count;

                // NOTE [sg]: eager loading
                FireGetProducts(PageNo++, PageSize);
            }
        }

        public void AddProductToControl(ProductInfo product)
        {
            this.productBindingSource.DataSource = product;
        }

        public void UpdateProductInCollection(ProductInfo product)
        {
            this.productBindingSource.DataSource = product;

            foreach (var p in this.products.Where(x => x.Id == product.Id))
            {
                p.BestSellers = product.BestSellers;
                p.Color = product.Color;
                p.Material = product.Material;
                p.Model = product.Model;
                p.ModifyDate = product.ModifyDate;
                p.Name = product.Name;
            }

            dataGridView1.Refresh();
        }

        public void Error(Exception e)
        {
            this.messageLabel.Text = e.ToString();
        }

        public void Message(string m)
        {
            this.messageLabel.Text = m;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            var h = GenerateProducts;
            if (h != null)
                h(this, EventArgs.Empty);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            ClearProductCollection();

            FireGetProducts(PageNo++, PageSize);
        }

        private void saveButton_ButtonClick(object sender, EventArgs e)
        {
            productBindingSource.EndEdit();

            var h = UpdateProduct;
            if (h != null)
                h(this, new UpdateProductEventArgs {Product = (ProductInfo)productBindingSource.Current});
        }

        private void cancelButton_ButtonClick(object sender, EventArgs e)
        {
            var h = Cancel;
            if (h != null)
                h(this, EventArgs.Empty);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var row = dataGridView1.CurrentRow;
            var id = row.Cells["Id"].Value;
            if (id == null)
                return;

            var h = GetProduct;
            if (h != null)
                h(this, new GetProductEventArgs { ProductId = (int)id });
        }

        private void dataGridView1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            // NOTE [sg]: DataGridView in Virtual Mode
            if (e.RowIndex >= this.dataGridView1.RowCount) return;

            if (e.RowIndex >= this.products.Count) return;

            var prod = this.products[e.RowIndex];
            switch (this.dataGridView1.Columns[e.ColumnIndex].Name)
            {
                case "Id":
                    e.Value = prod.Id;
                    break;

                case "Model":
                    e.Value = prod.Model;
                    break;

                case "Material":
                    e.Value = prod.Material;
                    break;

                case "Color":
                    e.Value = prod.Color;
                    break;

                case "columnName":
                    e.Value = prod.Name;
                    break;

                case "ModifyDate":
                    e.Value = prod.ModifyDate;
                    break;

                case "BestSellers":
                    e.Value = prod.BestSellers;
                    break;
            }
        }

        public void ProgressOn()
        {
            this.toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
            this.toolStripProgressBar1.MarqueeAnimationSpeed = 100 ;
        }

        public void ProgressOff()
        {
            this.toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
            this.toolStripProgressBar1.MarqueeAnimationSpeed = 0;
        }
    }
}
