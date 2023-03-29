// See https://aka.ms/new-console-template for more information
using ClassesAndMethods;

Console.WriteLine("Hello, World!");
int control = 0;

do
{
    Console.Clear();
    Console.WriteLine("Online Bankacılık Sistemi");
    Console.WriteLine("1->giriş");
    Console.WriteLine("2->kaydol");
    Console.WriteLine("3->kaydımı sil");
    Console.WriteLine("Lütfen yapmak istediğiniz işlemin numarasını giriniz");
    int secim = int .Parse(Console.ReadLine());

    switch (secim) 
    {
        case 1:
            Console.WriteLine("Hosgeldiniz");
            Musteri musteri = new Musteri();
            Console.WriteLine("e-posta:");
            musteri.mailaddress = Console.ReadLine();
            Console.WriteLine("sifre:");
            musteri.password = Console.ReadLine();
            MusteriManager.Giris(musteri);
            break;
            case 2:
            Console.WriteLine("Kayıt Oluşturun");
            Musteri musteri1 = new Musteri();
            Console.WriteLine("İsim");
            musteri1.name = Console.ReadLine();
            Console.WriteLine("Soyisim");
            musteri1.surname = Console.ReadLine();
            Console.WriteLine("e-posta");
            musteri1.mailaddress = Console.ReadLine();
            Console.WriteLine("sifre");
            musteri1.password = Console.ReadLine();

            MusteriManager.Ekle(musteri1);
            break;
            case 3:
            Console.WriteLine("kaydımı sil");
            Musteri musteri2 = new Musteri();
            Console.WriteLine("e-posta");
            musteri2.mailaddress = Console.ReadLine();
            Console.WriteLine("sifre");
            musteri2.password = Console.ReadLine();

            MusteriManager.Sil(musteri2);
            break;

    }
    Console.WriteLine("Devam etmek için 1'i işlemleri bitirmek için başka bir rakamı tuşlayınız");

    control = int.Parse(Console.ReadLine());


}

