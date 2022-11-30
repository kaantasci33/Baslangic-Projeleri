using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deger = 15; //deger tipinde 15 sayılı değişken atadık.BELLEKTE 4 BYTE yer kaplar.

            string degisken = null; //yazı isimlendirme gibi degiskenlerde string ifadesi kullanılır.
            //Önemli bilgi aynı kod bloğu içerisinde aynı değişken birden fazla kez tanımlanamaz.
            String ben = "kaan";

            byte a = 2; //byte tanımlaması yaptım a değişkeninde 2 olan byte 0-255 arasında değer alabilir. BELLEKTE 1 BYTE yer kaplar.
            sbyte b = 3;//-128/127 arasında değer alabilir. BELLEKTE 1 BYTE yer kaplar.


            short s = 4; // BELLEKTE 2 BYTE yer kaplar.
            ushort u = 3;//BELLEKTE 2 BYTE yer kaplar. 0-365 arasında değer alır.


            Int16 i16 = 2; //BELLEKTE 2 BYTE yer kaplar.
            Int32 i32 = 3;//BELLEKTE 4 BYTE yer kaplar.
            Int64 i64 = 4;//BELLEKTE 8 BYTE yer kaplar.

            uint u32 = 5;//BELLEKTE 4 BYTE yer kaplar.
            long l = 6;//BELLEKTE 8 BYTE yer kaplar./ büyük tam sayılarda kullanılır genelde.

            //Reel sayılar:
            float f = 7; //reel sayı tutabilir.4 BYTE yer kaplar.
            double d = 8;//BELLEKTE 8 BYTE yer kaplar.
            decimal c = 9;//BELLEKTE 16 BYTE yer kaplar./Reel sayılarda kullanılır.


            char char2 = '2'; //BELLEKTE 2 BYTE yer kaplar./
            string str = "Kaan Mert"; //string sınırsızdır.

            bool b1 = true; // doğru yanlış için kullanılır.
            bool b2 = false;

            DateTime dt1 = DateTime.Now;//bugünkü tarih ve saati dakikayı ve saniyeyi gösterir
            Console.WriteLine(dt1);
            Console.ReadLine();

            object ob1 = "x";
            object ob2 = 'y';//char tutturdum şu an.
            object ob3 = 4; // sayı değeri tutturdum.
            object ob4 = 4.3; //decimal değerinde reel sayı tutuyor yani genellikle istediğimiz şeyleri atayabilip bizim için saklayabiliyor.

            string str1 = string.Empty;
            str1 = "KAAN MERT TAŞCI";
            string ad = "Kaan Mert";
            string soyad = "TAŞCI";
            string tamIsım = ad + " " + soyad;

            //integer tanımlama şeklilleri
            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 + integer2;

            bool bool1 = 10 > 2;//true

            string strS = "20";
            int intS = 20;
            string yeniDeger = strS + intS.ToString();
            Console.WriteLine(yeniDeger);

            int intS2 = intS + Convert.ToInt32(strS);
            Console.WriteLine(intS2);

            int intS3 = intS2 + int.Parse(strS);


            string datetime1 = DateTime.Now.ToString("dd.MMMM.yyyy");
            Console.WriteLine(datetime1);
            string datetime2 = DateTime.Now.ToString("dd/MMMM/yyyy");
            Console.WriteLine(datetime2);
            string datetime = DateTime.Now.ToString("dd.MMMM.yyyy HH:ss");
            Console.WriteLine(datetime);

        }
    }
}
