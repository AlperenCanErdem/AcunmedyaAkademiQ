using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Constructors
{
    class Araba
    {
        public Fiyat fiyat;
        public Kapi kapi;
        public Kasa kasa;
        public Marka marka;
        public Model model;
        public Pencere pencere;

        public void yazdir() 
        {
            Console.WriteLine("Arabanın markası " +marka.markasi+ ", modeli "+ model.modeli+ ", kapı sayısı "+ kapi.kapiSayisi+ ", pencere sayisi " +pencere.pencereSayisi+ ", kasası "+ kasa.kasasi+ ", fiyatı "+ fiyat.fiyati+ " TL'dir." );
        }
        public Araba(Fiyat fiyat, Kapi kapi, Kasa kasa, Marka marka, Model model, Pencere pencere)
        {
            this.fiyat = fiyat;
            this.kapi = kapi;
            this.kasa = kasa;
            this.marka = marka;
            this.model = model;
            this.pencere = pencere;
        }

       
    }
}
