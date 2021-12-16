namespace Ionix.Data.Utils
{
    using System;
    using Collections;

    //it is used bu Nano Services
    public abstract class Singleton
    {
        private static readonly object locker = new object();
        private static readonly ThrowingHashSet<Type> registeredTypes = new ThrowingHashSet<Type>();

        protected Singleton()
        {
            lock (locker)
            {
                registeredTypes.Add(this.GetType());
            }
        }
    }
}