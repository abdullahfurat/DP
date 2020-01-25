namespace DesingPatter.Singleton_1
{
    public class SingletonClass1
    {
        private static SingletonClass1 _singleton = new SingletonClass1();

        // sınıf static olmadan, instance alınmasını istemiyorsanız, sınıf içerisinde constructor oluşuturup private olarak işaretlemeniz yeterlidir.
        private SingletonClass1() { }

        public static SingletonClass1 Singleton { get { return _singleton; } }
        public static SingletonClass1 SingletonInstance()
        {
            return _singleton;
        }

        // bu sınıf içerisinde yer alacak olan değerler.. (metot, prop vs..)
        public int Hesapla(int s1, int s2)
        {
            return s1 + s2;
        }
    }
}