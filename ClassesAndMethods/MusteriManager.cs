using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods
{
    public static class MusteriManager
    {
        public static List<Musteri> database = new ();
        private static object temp;

        static MusteriManager() 
        {
            Musteri musteri = new Musteri()
            {
                name = "ali",

                surname= "velioglu",

                MusteriId= 112233,

                age = 28,

                mailaddress = "alivelioglu@gmail.com"

                password= "123456"

            };
            database.Add(musteri);
            

        }
        public static void Giris(Musteri musteri) 
        {
            if (!string.IsNullOrEmpty(musteri.mailaddress) && !string.IsNullOrEmpty(musteri.password))
            {
                foreach(var m in database)
                {
                    Musteri temp = m;
                    if (temp.mailaddress == musteri.mailaddress && temp.password == musteri.password)
                    {
                        Console.WriteLine("GİRİŞ BAŞARILI" + " " + temp.name + " " + temp.surname);

                    }
                    else
                    {
                        Console.WriteLine("KULLANICI BULUNAMADI");
                    }
                }
            }
        }
        public static void Ekle(Musteri musteri)
        {

            if (!string.IsNullOrEmpty(musteri.mailaddress) && !string.IsNullOrEmpty(musteri.password))
            {
                foreach (var m in database)
                {
                    Musteri temp = m;
                    if (temp.mailaddress == musteri.mailaddress && temp.password != musteri.password)
                    {
                        Console.WriteLine("Bu mail adresi ile kayıtlı bir kullanıcı mevcut!");
                    }
                }
            }

            else
            {
                database.Add(musteri);
                Console.WriteLine("Kaydınız başarıyla oluşturuldu");
            }


        }
        
        public static void Sil(Musteri musteri) 
        {
            if (!string.IsNullOrEmpty(musteri.mailaddress) && !string.IsNullOrEmpty(musteri.password)) 
            {
                foreach (var m in database)
                {
                    Musteri temp = m;
                    if (temp.mailaddress == musteri.mailaddress && temp.password != musteri.password)
                    {
                        database.Remove(temp);
                        Console.WriteLine("Kaydınız silindi");

                    }
                    else
                    {
                        Console.WriteLine("Böyle Bir Kullanıcı Mevcut Değil");

                    }
            }




        }
            else { Console.WriteLine("mail adresi ve şifre bçlümleri boş olamaz"); }
            }
            

            }

        }
    }
}
