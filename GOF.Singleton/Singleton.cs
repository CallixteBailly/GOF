﻿namespace GOF.Singleton
{
    internal sealed class Singleton
    {
        private Singleton() { }

        private static Singleton s_instance = null!;

        // We now have a lock object that will be used to synchronize threads
        // during first access to the Singleton.
        private static readonly object s_lock = new();

        public static Singleton GetInstance(string value)
        {
            // This conditional is needed to prevent threads stumbling over the
            // lock once the instance is ready.
            if (s_instance == null)
            {
                // Now, imagine that the program has just been launched. Since
                // there's no Singleton instance yet, multiple threads can
                // simultaneously pass the previous conditional and reach this
                // point almost at the same time. The first of them will acquire
                // lock and will proceed further, while the rest will wait here.
                lock (s_lock)
                {
                    // The first thread to acquire the lock, reaches this
                    // conditional, goes inside and creates the Singleton
                    // instance. Once it leaves the lock block, a thread that
                    // might have been waiting for the lock release may then
                    // enter this section. But since the Singleton field is
                    // already initialized, the thread won't create a new
                    // object.
                    s_instance ??= new Singleton
                    {
                        Value = value
                    };
                }
            }
            return s_instance;
        }

        // We'll use this property to prove that our Singleton really works.
        public string Value { get; set; } = null!;
    }
}
