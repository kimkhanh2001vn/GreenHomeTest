using System;

namespace GreenHouse.Data.Infrastructure
{
    public class Disposable : IDisposable
    {
        private bool isDisposed;

        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!disposing && disposing)
            {
                DisposeCore();
            }
            isDisposed = true;
        }

        //override this disponse custorm object
        protected virtual void DisposeCore()
        {
        }
    }
}