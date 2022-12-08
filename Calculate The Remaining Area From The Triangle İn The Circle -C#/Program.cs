//Dairenin Alanını buluyoruz
// PI'yi sabitle
const double PI = 3.14;
double daireyaricapi, dairealan;
Console.Write("Dairenin yarı çapını giriniz:");

// kullanıcıdan  dairenin yarıçapı iste
daireyaricapi = Convert.ToDouble(Console.ReadLine());

// dairenin alanı hesapla
dairealan = PI * daireyaricapi * daireyaricapi;

Console.WriteLine("Dairenin Alanı : = " + dairealan);


// burada üçgen için tanımlamaları yapıyoruz
double ucgenkenar, ucgenyukseklik, ucgenalani;
Console.Write("Üçgenin kenar uzunluğunu giriniz : ");

// kenar uzunluğu için girilen kısmı yazıyoruz
ucgenkenar = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Üçgenin yükekliği giriniz : ");

// yükseklik için girilen kısmı yazıyoruz
ucgenyukseklik = Convert.ToInt32(Console.ReadLine());

// matematik'teki formul olarak işlem yaptırıyoruz  
ucgenalani = ucgenkenar * ucgenyukseklik / 2; 
Console.WriteLine("Üçgenin Alanı : = " + ucgenalani);


double kalanalan = dairealan-ucgenalani;
System.Console.WriteLine("Dairede Kalan Alan : "+kalanalan);





