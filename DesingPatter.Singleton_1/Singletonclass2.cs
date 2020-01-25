namespace DesingPatter.Singleton_1
{
    public class Singletonclass2
    {
        private Singletonclass2() { }

        // Encapsulation Yöntemi
        private static Singletonclass2 _singleton;
        public static Singletonclass2 Singleton
        {
            get
            {
                if (_singleton == null)
                {
                    // Kullanıcı daha önce instance oluşturmadıysa, yeni bir nesne teslim et
                    _singleton = new Singletonclass2();
                }
                // kullanıcıya var olan nesneyi teslim et.
                return _singleton;
            }
        }
         
        public static Singletonclass2 SingletonInstance()
        {
            if (_singleton == null)
            {
                _singleton = new Singletonclass2();
            }
            return _singleton;
        }
         
        public int Hesapla(int s1, int s2)
        {

            return s1 + s2;
        }
    }
}
