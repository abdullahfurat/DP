using System;
namespace DesingPatter.Singleton_1
{
    public class SingletonClass3
    {
        private SingletonClass3() { }
        public static Object lockObject = new Object();
        private static SingletonClass3 _singleton;

        public SingletonClass3 Singleton
        {
            get
            {
                if (_singleton == null)
                {
                    lock (lockObject)
                    {
                        _singleton = new SingletonClass3();
                    }
                }

                return _singleton;
            }
        }
    }
}
