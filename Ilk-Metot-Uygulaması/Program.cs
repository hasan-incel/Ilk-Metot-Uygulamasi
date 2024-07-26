static void Lyrics()  // Değeri geriye döndürmeyen metot
{
    Console.WriteLine("Yüreğimde zincirler kırılıyor duydun mu\r\nNefes nefes bu gece sevdanın son vuruşu\r\nSen hiç böyle sevdin mi\r\nSen hiç böyle oldun mu");
}
Lyrics();// kaydedilen yukarıdaki metodu konsola yazdırıyor.

static int RandomNumber() //Rastgele sayı üretip döndüren method
{
    Random rnd = new Random();
    int number = rnd.Next(1, 100);
    int remainder = number % 2;
    return remainder; // Kalan sayıyı geriye döndürüyor.
}
int result = RandomNumber();
Console.WriteLine("\n2'ye bölümünden kalan: " + result); // kaydedilen yukarıdaki metodu konsola yazdırıyor.

//Çarpma işlemi yapan method
Console.WriteLine("\nLütfen ilk sayıyı giriniz");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen ikinci sayıyı giriniz");
int b = Convert.ToInt32(Console.ReadLine());
static int iki_sayının_carpımı(int a, int b)
{
    return a * b;  // Kalan sayıyı geriye döndürüyor.
}
int result2 = iki_sayının_carpımı(a, b);
Console.WriteLine("\nÇarpım sonucu: " + result2); // kaydedilen yukarıdaki metodu konsola yazdırıyor.

Console.WriteLine("\nLütfen isim giriniz");
string isim = Console.ReadLine();
Console.WriteLine("Lütfen soyisim giriniz");
string soyisim = Console.ReadLine();

//Parametre alıp, geri döndürmeyen isim soyisim metodu.
static void isim_soyisim(string isim, string soyisim)
{
    Console.WriteLine($"\nHoş Geldiniz {isim} {soyisim}");
}
isim_soyisim(isim, soyisim);