using Assignment.Classes;
using Assignment.Constructors;

Fiyat fiyat = new Fiyat(2000000);
Kapi kapi = new Kapi(4);
Kasa kasa = new Kasa("Sedan");
Marka marka = new Marka("BMW");
Model model = new Model("X5");
Pencere pencere = new Pencere(4);
Araba araba = new Araba(fiyat, kapi, kasa, marka, model, pencere);
araba.yazdir();

Matematik matematik = new Matematik();
Console.WriteLine(matematik.topla(1, 2));
Console.WriteLine(matematik.topla(1, 2, 3));
Console.WriteLine(matematik.topla(1.5, 2.5));
Console.WriteLine(matematik.topla(1.5, 2.5, 3.5));
Console.WriteLine(matematik.carp(1, 2));
Console.WriteLine(matematik.carp(1, 2, 3));
Console.WriteLine(matematik.carp(1.5, 2.5));
Console.WriteLine(matematik.carp(1.5, 2.5, 3.5));