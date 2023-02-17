using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carmagedon
{
    class CarCeller
    {
        public string Brand;
        public string Model;
        public string ProductDate;
        public string Km;
        public string FuelType;
        public string GearBox;
        public int PurchacePrice;
        public int SalePrice;
        public int MaxDiscountAmount;
        private int Price;

        

        public CarCeller(string brand, string model, string productDate, string km, string fullType, string gearBox, int purchacePrice, int salePrice, int maxDiscountAmount)
        {
            Brand = brand;
            Model = model;
            ProductDate = productDate;
            Km = km;
            FuelType = fullType;
            GearBox = gearBox;
            PurchacePrice = purchacePrice;
            SalePrice = salePrice;
            MaxDiscountAmount = maxDiscountAmount;
           

           

            }

        public CarCeller(string brand, string model)
        {
            string Brand = brand;
            string Model = model;
            //Console.WriteLine(Brand + " " + Model);
        }

        public CarCeller(string brand, string model, string productDay)
        {
            string Brand = brand;
            string Model = model;
            string PruductDay = productDay;
            //Console.WriteLine(Brand + " " + Model + " " + PruductDay);
        }

        public CarCeller(string brand, string model, string productDay, string km)
        {
            string Brand = brand;
            string Model = model;
            string ProductDate = productDay;
            string Km = km;
            //Console.WriteLine(Brand + " " + Model + " " + ProductDate + " " + Km);
        }

        public void FullInfo ()
        {
            Console.WriteLine(Brand + " " + Model + "\nBuraxılış ili :" + ProductDate + "\nProbeq :" + Km + "km \nYanacaq Tipi :" + FuelType + "\nKarobka :" + GearBox + "\nAlış Qiyməti :" + PurchacePrice + "\nSatış qiyməti :" + SalePrice + "\nEndirim :" + MaxDiscountAmount);

        }

        public int price(int salePrice, int maxDiscountAmount)
        {
            int price = SalePrice - MaxDiscountAmount;
            Price = price;
            return Price;
        }

    }
}
