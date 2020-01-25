using System;

namespace DesingPatter.Singleton_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = SingletonClass1.Singleton;
            // sınıf içerisinde private constructor olduğundan. instance alma işlemi yapılmamaktadır.
            //SingletonClass1 s = new SingletonClass1();

            int sonuc1 = s1.Hesapla(10, 10);


            var s2 = SingletonClass1.SingletonInstance();
            int sonuc2 = s2.Hesapla(40, 40);

            // ----------------------

            var s3 = Singletonclass2.Singleton;
            int sonuc3 = s3.Hesapla(10, 10);
             
            string isim = null;

            //if (isim == null)
            //{
            //    isim = "bilge adam";
            //}

            isim = isim ?? "bilge adam";

            // value type değerleri null geçilemez :)
            int? a = null;
            a = a.GetValueOrDefault(10);

            Console.WriteLine(a);

            Console.WriteLine(isim);
            Console.ReadKey();

        }
    }
}
