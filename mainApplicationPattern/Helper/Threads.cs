using System.Collections.Generic;
using System.Threading;

namespace mainApplicationPattern.Helper
{
    class Threads
    {
        private List<Thread> _threads;

        private int _count = 1;

        public Threads():this(CountThreads: DataConfig.Config.ThreadsCount)
        { }

        public Threads(int CountThreads = 1)
        {
            this._count = CountThreads;
        }

        public void Run(ThreadStart Method)
        {
            _threads = new List<Thread>();

            for (int i = 0; i < _count; i++)
            {
                var thread = new Thread(Method);
                thread.IsBackground = true;

                _threads.Add(thread);
                _threads[i].Start();
            }
        }

        public void Abort()
        {
            for (int i = 0; i < _count; i++)
            {
                _threads[i].Abort();
            }
        }

        public int Alive()
        {
            int count = 0;
            for (int i = 0; i < _count; i++)
            {
                if (_threads[i].IsAlive)
                    count++;
            }
            return count;
        }
    }
}
