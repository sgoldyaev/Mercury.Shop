using System;
using System.Threading;
using System.Threading.Tasks;

namespace Mercury.Shop.Mvp.Presenters
{
    public static class TaskContinuationExtensions
    {
        public static Task ContinueWhenOk<TResult>(this Task<TResult> task, Action<Task<TResult>> continuation, CancellationToken token)
        {
            return task.ContinueWith(continuation, token, TaskContinuationOptions.OnlyOnRanToCompletion, TaskScheduler.FromCurrentSynchronizationContext());
        }

        public static Task ContinueWhenFail<TResult>(this Task<TResult> task, Action<Task<TResult>> continuation, CancellationToken token)
        {
            return task.ContinueWith(continuation, token, TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.FromCurrentSynchronizationContext());
        }

        public static Task ContinueWhenAny<TResult>(this Task<TResult> task, Action<Task<TResult>> continuation, CancellationToken token)
        {
            return task.ContinueWith(continuation, token, TaskContinuationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}