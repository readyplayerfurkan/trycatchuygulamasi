// See https://aka.ms/new-console-template for more information

try
{
    Console.WriteLine("Bir sayı giriniz : ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Girdiğiniz sayi : " + sayi);
}
catch (Exception ex)
{
    Console.WriteLine("Hata: " + ex.Message);
}
//finally
//{
//    Console.WriteLine("İşlem tamamlandı.");
//}

try
{
    //int a = int.Parse(null);
    //int a = int.Parse("test");
    int a = int.Parse("-2000000000000000");
}
catch (ArgumentException ex)
{
    Console.WriteLine("Boş değer girdiniz.");
    Console.WriteLine(ex);
}
catch (FormatException ex)
{
    Console.WriteLine("Veri tipi uygun değil.");
    Console.WriteLine(ex);
}
catch (OverflowException ex)
{
    Console.WriteLine("Çok büyük veya çok küçük bir değer girdiniz.");
    Console.WriteLine(ex);
}
finally
{
    Console.WriteLine("İşlem tamamlandı.");
}
