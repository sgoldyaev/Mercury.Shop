namespace Mercury.Shop.WinClient
{
    partial class ProductsView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label collectionLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label commentLabel;
            System.Windows.Forms.Label createDateLabel;
            System.Windows.Forms.Label materialLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label modifyDateLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label sellDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsView));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.generateButton = new System.Windows.Forms.ToolStripButton();
            this.loadButton = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BestSellers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.besSellersCheckBox = new System.Windows.Forms.CheckBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collectionTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.createDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.materialTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.modifyDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.privateCheckBox = new System.Windows.Forms.CheckBox();
            this.sellDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vIPCheckBox = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.saveButton = new System.Windows.Forms.ToolStripSplitButton();
            this.cancelButton = new System.Windows.Forms.ToolStripSplitButton();
            this.messageLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            collectionLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            createDateLabel = new System.Windows.Forms.Label();
            materialLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            modifyDateLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            sellDateLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // collectionLabel
            // 
            collectionLabel.AutoSize = true;
            collectionLabel.Location = new System.Drawing.Point(17, 127);
            collectionLabel.Name = "collectionLabel";
            collectionLabel.Size = new System.Drawing.Size(56, 13);
            collectionLabel.TabIndex = 2;
            collectionLabel.Text = "Collection:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(17, 75);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(34, 13);
            colorLabel.TabIndex = 4;
            colorLabel.Text = "Color:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(17, 153);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(54, 13);
            commentLabel.TabIndex = 6;
            commentLabel.Text = "Comment:";
            // 
            // createDateLabel
            // 
            createDateLabel.AutoSize = true;
            createDateLabel.Location = new System.Drawing.Point(17, 180);
            createDateLabel.Name = "createDateLabel";
            createDateLabel.Size = new System.Drawing.Size(67, 13);
            createDateLabel.TabIndex = 8;
            createDateLabel.Text = "Create Date:";
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Location = new System.Drawing.Point(17, 49);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new System.Drawing.Size(47, 13);
            materialLabel.TabIndex = 12;
            materialLabel.Text = "Material:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(17, 23);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(39, 13);
            modelLabel.TabIndex = 14;
            modelLabel.Text = "Model:";
            // 
            // modifyDateLabel
            // 
            modifyDateLabel.AutoSize = true;
            modifyDateLabel.Location = new System.Drawing.Point(17, 206);
            modifyDateLabel.Name = "modifyDateLabel";
            modifyDateLabel.Size = new System.Drawing.Size(67, 13);
            modifyDateLabel.TabIndex = 16;
            modifyDateLabel.Text = "Modify Date:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(17, 101);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 18;
            nameLabel.Text = "Name:";
            // 
            // sellDateLabel
            // 
            sellDateLabel.AutoSize = true;
            sellDateLabel.Location = new System.Drawing.Point(17, 232);
            sellDateLabel.Name = "sellDateLabel";
            sellDateLabel.Size = new System.Drawing.Size(53, 13);
            sellDateLabel.TabIndex = 22;
            sellDateLabel.Text = "Sell Date:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateButton,
            this.loadButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1088, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // generateButton
            // 
            this.generateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.generateButton.Image = ((System.Drawing.Image)(resources.GetObject("generateButton.Image")));
            this.generateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(72, 22);
            this.generateButton.Text = "Наполнить";
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.loadButton.Image = ((System.Drawing.Image)(resources.GetObject("loadButton.Image")));
            this.loadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(65, 22);
            this.loadButton.Text = "Загрузить";
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.besSellersCheckBox);
            this.splitContainer1.Panel2.Controls.Add(collectionLabel);
            this.splitContainer1.Panel2.Controls.Add(this.collectionTextBox);
            this.splitContainer1.Panel2.Controls.Add(colorLabel);
            this.splitContainer1.Panel2.Controls.Add(this.colorTextBox);
            this.splitContainer1.Panel2.Controls.Add(commentLabel);
            this.splitContainer1.Panel2.Controls.Add(this.commentTextBox);
            this.splitContainer1.Panel2.Controls.Add(createDateLabel);
            this.splitContainer1.Panel2.Controls.Add(this.createDateDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(materialLabel);
            this.splitContainer1.Panel2.Controls.Add(this.materialTextBox);
            this.splitContainer1.Panel2.Controls.Add(modelLabel);
            this.splitContainer1.Panel2.Controls.Add(this.modelTextBox);
            this.splitContainer1.Panel2.Controls.Add(modifyDateLabel);
            this.splitContainer1.Panel2.Controls.Add(this.modifyDateDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(nameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.nameTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.privateCheckBox);
            this.splitContainer1.Panel2.Controls.Add(sellDateLabel);
            this.splitContainer1.Panel2.Controls.Add(this.sellDateDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.vIPCheckBox);
            this.splitContainer1.Size = new System.Drawing.Size(1088, 386);
            this.splitContainer1.SplitterDistance = 722;
            this.splitContainer1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Model,
            this.Material,
            this.Color,
            this.columnName,
            this.ModifyDate,
            this.BestSellers});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(722, 386);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dataGridView1_CellValueNeeded);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Material
            // 
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Name";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // ModifyDate
            // 
            this.ModifyDate.HeaderText = "ModifyDate";
            this.ModifyDate.Name = "ModifyDate";
            this.ModifyDate.ReadOnly = true;
            // 
            // BestSellers
            // 
            this.BestSellers.HeaderText = "BestSellers";
            this.BestSellers.Name = "BestSellers";
            this.BestSellers.ReadOnly = true;
            // 
            // besSellersCheckBox
            // 
            this.besSellersCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productBindingSource, "BestSellers", true));
            this.besSellersCheckBox.Location = new System.Drawing.Point(20, 254);
            this.besSellersCheckBox.Name = "besSellersCheckBox";
            this.besSellersCheckBox.Size = new System.Drawing.Size(200, 24);
            this.besSellersCheckBox.TabIndex = 1;
            this.besSellersCheckBox.Text = "Best Sellers";
            this.besSellersCheckBox.UseVisualStyleBackColor = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Mercury.Shop.Common.Dto.ProductInfo);
            // 
            // collectionTextBox
            // 
            this.collectionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Collection", true));
            this.collectionTextBox.Location = new System.Drawing.Point(90, 124);
            this.collectionTextBox.Name = "collectionTextBox";
            this.collectionTextBox.Size = new System.Drawing.Size(200, 20);
            this.collectionTextBox.TabIndex = 3;
            // 
            // colorTextBox
            // 
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Color", true));
            this.colorTextBox.Location = new System.Drawing.Point(90, 72);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(200, 20);
            this.colorTextBox.TabIndex = 5;
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(90, 150);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(200, 20);
            this.commentTextBox.TabIndex = 7;
            // 
            // createDateDateTimePicker
            // 
            this.createDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "CreateDate", true));
            this.createDateDateTimePicker.Location = new System.Drawing.Point(90, 176);
            this.createDateDateTimePicker.Name = "createDateDateTimePicker";
            this.createDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.createDateDateTimePicker.TabIndex = 9;
            // 
            // materialTextBox
            // 
            this.materialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Material", true));
            this.materialTextBox.Location = new System.Drawing.Point(90, 46);
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.Size = new System.Drawing.Size(200, 20);
            this.materialTextBox.TabIndex = 13;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(90, 20);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(200, 20);
            this.modelTextBox.TabIndex = 15;
            // 
            // modifyDateDateTimePicker
            // 
            this.modifyDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "ModifyDate", true));
            this.modifyDateDateTimePicker.Location = new System.Drawing.Point(90, 202);
            this.modifyDateDateTimePicker.Name = "modifyDateDateTimePicker";
            this.modifyDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.modifyDateDateTimePicker.TabIndex = 17;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(90, 98);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 19;
            // 
            // privateCheckBox
            // 
            this.privateCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productBindingSource, "Private", true));
            this.privateCheckBox.Location = new System.Drawing.Point(20, 314);
            this.privateCheckBox.Name = "privateCheckBox";
            this.privateCheckBox.Size = new System.Drawing.Size(200, 24);
            this.privateCheckBox.TabIndex = 21;
            this.privateCheckBox.Text = "Private";
            this.privateCheckBox.UseVisualStyleBackColor = true;
            // 
            // sellDateDateTimePicker
            // 
            this.sellDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "SellDate", true));
            this.sellDateDateTimePicker.Location = new System.Drawing.Point(90, 228);
            this.sellDateDateTimePicker.Name = "sellDateDateTimePicker";
            this.sellDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.sellDateDateTimePicker.TabIndex = 23;
            // 
            // vIPCheckBox
            // 
            this.vIPCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productBindingSource, "VIP", true));
            this.vIPCheckBox.Location = new System.Drawing.Point(20, 284);
            this.vIPCheckBox.Name = "vIPCheckBox";
            this.vIPCheckBox.Size = new System.Drawing.Size(200, 24);
            this.vIPCheckBox.TabIndex = 25;
            this.vIPCheckBox.Text = "VIP";
            this.vIPCheckBox.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveButton,
            this.cancelButton,
            this.messageLabel,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 389);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1088, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(81, 20);
            this.saveButton.Text = "Сохранить";
            this.saveButton.ButtonClick += new System.EventHandler(this.saveButton_ButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(77, 20);
            this.cancelButton.Text = "Отменить";
            this.cancelButton.ButtonClick += new System.EventHandler(this.cancelButton_ButtonClick);
            // 
            // messageLabel
            // 
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.MarqueeAnimationSpeed = 0;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // ProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 411);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ProductsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список продуктов";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton generateButton;
        private System.Windows.Forms.ToolStripButton loadButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton saveButton;
        private System.Windows.Forms.ToolStripSplitButton cancelButton;
        private System.Windows.Forms.CheckBox besSellersCheckBox;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox collectionTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.DateTimePicker createDateDateTimePicker;
        private System.Windows.Forms.TextBox materialTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.DateTimePicker modifyDateDateTimePicker;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.CheckBox privateCheckBox;
        private System.Windows.Forms.DateTimePicker sellDateDateTimePicker;
        private System.Windows.Forms.CheckBox vIPCheckBox;
        private System.Windows.Forms.ToolStripStatusLabel messageLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModifyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBestSellers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BestSellers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}

