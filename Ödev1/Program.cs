

//örnek 1



Console.WriteLine("lütfen bir sayı giriniz");
int sayı = Convert.ToInt32(Console.ReadLine());
if(sayı==0)
{
    Console.WriteLine("girdiğiniz sayı 0'a eşit");
}
else if(0>sayı)
{
    Console.WriteLine("girdiğiniz sayı negatif");

}
else if (0 < sayı)
{
    Console.WriteLine("girdiğiniz sayı pozitif");

}



//örnek 2

Console.WriteLine("gün belirleme programına hoşgeldiniz");
Console.WriteLine("1=pazartesi");
Console.WriteLine("2=salı");
Console.WriteLine("3=çarşamba");
Console.WriteLine("4=perşembe");
Console.WriteLine("5=cuma");
Console.WriteLine("6=cumartesi");
Console.WriteLine("7=pazar");

Console.WriteLine("lütfen seçmek istediğiniz günü numarasını giriniz");
int gun=Convert.ToInt32(Console.ReadLine());
switch(gun)
{
    case 1:
        Console.WriteLine("seçtiğiniz gün Pazartesi");
        break;
    case 2:
        Console.WriteLine("seçtiğiniz gün Salı");
        break;
    case 3:
        Console.WriteLine("seçtiğiniz gün çarşamba");
        break;
    case 4:
        Console.WriteLine("seçtiğiniz gün perşembe");
        break;
    case 5:
        Console.WriteLine("seçtiğiniz gün cuma");
        break; 
    case 6:
        Console.WriteLine("seçtiğiniz gün cumartesi");
        break;
    case 7:
        Console.WriteLine("seçtiğiniz gün pazar");
        break;
    default:
        Console.WriteLine("lütfen geçerli bir numara giriniz");
        break;
}





//örnek 3

Console.WriteLine("hesap makinası uygulamasına hoşgeldiniz");
Console.WriteLine("lütfen işlem yapmak istediğinz ilk sayıyı giriniz");
double sayi1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("lütfen işlem yapmak istediğiniz ikinci sayıyı giribiz");
double sayi2 = Convert.ToDouble(Console.ReadLine());
double sonuc = 0;

Console.WriteLine("Lütfen yapmak istdiğiniz işlem türünü şu sembollerle gösteriniz =>(+,-,*,/,) ");
string islem=Convert.ToString(Console.ReadLine());
switch (islem)
{
    case "+":
        sonuc=sayi1 + sayi2;
        Console.WriteLine($"Sonuç: {sayi1} + {sayi2}={sonuc}");
        break;
    case "-":
        sonuc = sayi1 - sayi2;
        Console.WriteLine($"sonuç:{sayi1}-{sayi2}={sonuc}");
        break;
    case "*":
        sonuc = sayi1 * sayi2;
        Console.WriteLine($"sonuç:{sayi1}*{sayi2}={sonuc}");
        break;
    case "/":
        sonuc = sayi1 / sayi2;
        Console.WriteLine($"sonuç:{sayi1}/{sayi2}={sonuc}");
        break;
    default :
        Console.WriteLine("geçersiz bir işlem türü seçtiniz");
        break;
   
}


//örnek 4
Console.Write("Birinci sayıyı girin: ");
int sayii1 = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci sayıyı girin: ");
int sayii2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Üçüncü sayıyı girin: ");
int sayii3 = Convert.ToInt32(Console.ReadLine());

int enBuyuk = sayii1;

if (sayi2 > enBuyuk)
{
    enBuyuk = sayii2;
}

if (sayii3 > enBuyuk)
{
    enBuyuk = sayii3;
}

Console.WriteLine($"En büyük sayı: {enBuyuk}");

//örnek 5
Console.WriteLine("şifre güç belirleme programın ahoşgeldiniz");
Console.Write("lütfen bir şifre girinizz ");
string sifre = Console.ReadLine();

if (sifre.Length < 8)
{
    Console.WriteLine(" Şifreniz 8 karakterden az olmamalı");
}
else if (!(sifre.Contains("@") || sifre.Contains("#") || sifre.Contains("$") || sifre.Contains("%")))
{
    Console.WriteLine(" Şifrenizde şu özel karakterlerin olması gerekiyor=> (@, #, $, %)");
}
else
{
    bool buyukHarf = false;

    for (int i = 0; i < sifre.Length; i++)
    {
        if (char.IsUpper(sifre[i]))
        {
            buyukHarf = true;
            break;
        }
    }

    if (!buyukHarf)
    {
        Console.WriteLine(" Şifrenizde büyük harf olmalı");
    }
    else
    {
        Console.WriteLine("tebrikler güçlü bir şifreniz var");
    }
}
    
