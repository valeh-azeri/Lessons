using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Item:Base
    {
        public string  Brand { get; set; }
        public string  Model { get; set; }

        private string _barcode;
        public string Barcode
        {
            get
            {
                return _barcode;
            }
            set
            {
                bool checkBarcode = VirtualDatabase.IsBarcodeDublicate(value);
                if (!checkBarcode)
                {
                    _barcode = value;
                }
                else
                {
                    Console.WriteLine("Bu  barcode  daha önce sistemə əlavə olunub");
                }
            }
        }

        private decimal _buyPrice;
        public decimal BuyPrice
        {
            get { return _buyPrice; }
            set
            {
                if (value <=0)
                {
                    Console.WriteLine("Alis qiymeti sifirdan kicik ola bilmez");  
                }
                else _buyPrice=value;
            }
        }

        private decimal _sellPrice;
        public decimal SellPrice
        {
            get { return _sellPrice; }
            set
            {
                if (value <_buyPrice)
                {
                    Console.WriteLine("Sati qiymeti alis qiymetinden az ola bilmez");
                }
                else _sellPrice = value;
            }
        }


        private decimal _offerlPrice;
        public decimal OfferPrice
        {
            get { return _offerlPrice; }
            set
            {
                if (value <=0)
                {
                    Console.WriteLine("Kompaniya qiymeti 1  den kicik ola bilmez");
                }
                else _offerlPrice = value;
            }
        }




    }
}
