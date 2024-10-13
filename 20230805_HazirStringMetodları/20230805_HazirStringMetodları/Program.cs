using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230805_HazirStringMetodları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Microsoft'un  bize sunmuş olduğu hazır string metodlar bulunmaktadır
            //Bu string metodlar sayesinde bir takım işlemlerimizi kolaylaştırabiliriz
            //Bunlardan en sık kullanılanlarını örknekler halinde işleyelim

            string metin = "Merhaba Dünya";

            //Length metodu
            //Bir string değerin karakter uzunluğunu alır
            //Geriye int tipinde değer döndürür
            Console.WriteLine(metin.Length);

            Console.WriteLine("---------------");
            //IndexOf() metodu
            //Bir string değerin içerisinde bir karakter veya kelime aramamızı sağlar
            //Bulduğu ilk değer hangi index numarsı ile başlıyorsa o index numarısını geri döner
            //() içerisinde metinsel veritipi eklenir
            //Eğer bir sonuç bulunuyorsa bulduğu sonucun index numarısını , bulmuyorsa -1 değerini döndürür

            Console.WriteLine(metin.IndexOf('a'));
            Console.WriteLine(metin.IndexOf('M'));
            Console.WriteLine(metin.IndexOf('m'));
            Console.WriteLine(metin.IndexOf('x'));

            Console.WriteLine("------------------");

            //LastIndexOf() metodu
            //Bir string değerin içerisinde bir karakter veya kelime aramamızı sağlar
            //Arama işlemine sondan başlar
            //Bulduğu ilk değer hangi index numarası ile başlıyorsa o index numarasını geri döndürür
            //Eğer bir sonuö buluyorsa index numarasını , bulamıyorsa -1 değerini geri döndürür

            Console.WriteLine(metin.LastIndexOf('a'));
            Console.WriteLine(metin.LastIndexOf('x'));
            int sonuc=metin.LastIndexOf('a');
            if (sonuc==-1)
            {
                Console.WriteLine("Aradığınız değer bulunamadı");
            }
            else
            {
                Console.WriteLine("Aradığınız değer "+ sonuc + " numaralı indextedir");
            }

            Console.WriteLine("----------------");
            //Contains() metodu
            //Bir string değerin içerisinde bir karakter veya kelime aramamızı sağlar.
            // () içerisine metinsel veritipi eklenir
            //Eğer bir sonuç buluyorsa ise true,bulamıyorsa false değerini döndürür.
            bool cevap = metin.Contains("Mer");
            if (cevap)
            {
                Console.WriteLine("Aradığınız değer bulundu");
            }
            else
            {
                Console.WriteLine("Aradığınız değer BULUNAMADI");
            }
            Console.WriteLine("------------------");
            //ToLower() metodu
            //Bir string değerin içerisinde bulunan karakterleri küçük karakterlere çevirir
            Console.WriteLine(metin.ToLower());


            Console.WriteLine("--------------");
            //ToUpper() metodu
            //Bir string değerin içerisinde bulunan karakterleri büyük karakterlere çevirir
            Console.WriteLine(metin.ToUpper());

            Console.WriteLine("------------");

            //Trim() metodu
            //Bir string değerde metinin önün ve sonunda bulunan boşluk karakterlerini siler
            string metin1 = "              Selam          ";
            string metin2 = "       Nasılsın      ";
            Console.WriteLine(metin1+metin2);
            Console.WriteLine(metin1.Trim()+metin2.Trim());

            Console.WriteLine("-----------------");

            //Replace() metod
            //Bir string içerisinde bulunan karakter veya metni ,başka bir karakter veya metin ile değiştirmemizi sağlar
            //() içerisinde sırası ile önce değişecek metin , virgülden sonra ise yeni metin olarak girmemiz gerekmektedir

            Console.WriteLine(metin.Replace("Dünya","Merkür"));

            Console.WriteLine("------------------");

            //Split() Metodu
            //Bir string değeri belirli bir karakter ile bölüp,bölünen değerleri bir dizi olarak kullanmamızı sağlar
            //Geriye string[] döndürülür

            string metinler = "Ahmet,Mehmet,Ali,Ayşe,Fatma";
            var isimler = metinler.Split(',');
            foreach (var item in isimler)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            
        }
    }
}
