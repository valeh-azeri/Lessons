using Homework2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public static class DatabaseCar
    {
<<<<<<< HEAD
        public static List<Car> CarsTable = new List<Car> {
        new Car()
        {
            CarID=1,
            CarMark="MBW",
            CarModel="IX37",
            CarYear=2000,
            SellerCity="Germany",
            Color=EnumColor.Black,
            Engine="Benzin",
            EngineValue=60000 ,
            EngineForce="170FS",
            Kilometr=15000,
            VelocityBox=EnumVelcityBox.Avtomtat,
            Price=75000
        },

         new Car()
        {
            CarID=1,
            CarMark="MBW",
            CarModel="IX35",
            CarYear=2011,
            SellerCity="Chine",
            Color=EnumColor.Brown,
            Engine="Disel",
            EngineValue=5000 ,
            EngineForce="150FS",
            Kilometr=150000,
            VelocityBox=EnumVelcityBox.Mecanichal,
            Price=75000
        },
         new Car()
        {
            CarID=1,
            CarMark="Lexus",
            CarModel="GX460",
            CarYear = 2020,
            SellerCity="Chine",
            Color=EnumColor.Brown,
            Engine="Benzin",
            EngineValue=6000 ,
            EngineForce="250FS",
            Kilometr=280000,
            VelocityBox=EnumVelcityBox.TipTronic,
            Price=75000
        },

          new Car()
        {
            CarID=1,
            CarMark="Mercedes",
            CarModel="GX460",
            CarYear=1982,
            SellerCity="Baki",
            Color=EnumColor.Brown,
            Engine="Benzin",
            EngineValue=4000 ,
            EngineForce="250FS",
            Kilometr=280000,
            VelocityBox=EnumVelcityBox.TipTronic,
            Price=75000
        },
=======
        public static List<Car> CarsTable = new List<Car>() {
            new Car()
            {
                CarID=1,
                CarMark="MBW",
                CarModel="IX37",
                CarYear=new DateTime(1982,10,10),
                SellerCity="Germany",
                Color=ColorEnum.Black,
                Engine="Benzin",
                EngineValue="7000" ,
                EngineForce="170FS",
                Kilometr=15000,
                VelocityBox=VelcityBoxEnum.Avtomtat,
                Price=75000
            },

            new Car()
            {
                CarID=1,
                CarMark="MBW",
                CarModel="IX35",
                CarYear=new DateTime(2000,10,10),
                SellerCity="Chine",
                Color=ColorEnum.Brown,
                Engine="Disel",
                EngineValue="5000" ,
                EngineForce="150FS",
                Kilometr=150000,
                VelocityBox=VelcityBoxEnum.Mecanichal,
                Price=75000
            },
>>>>>>> e821d3236604a14711d1ff940f0e31d087120bf5

            new Car()
            {
                CarID=1,
                CarMark="Lexus",
                CarModel="GX460",
                CarYear=new DateTime(2002,10,10),
                SellerCity="Chine",
                Color=ColorEnum.Brown,
                Engine="Benzin",
                EngineValue="5000" ,
                EngineForce="250FS",
                Kilometr=280000,
                VelocityBox=VelcityBoxEnum.TipTronic,
                Price=75000
            }
        };
<<<<<<< HEAD
        //1. Markası Mercedes olub, mühərrik həcmi 4200'dən az olan və ya bərabər olan, Bakıda satılan.
        public static List<Car> GetFiltrByLINQ(string mark, int engineValue, string sellerCity)
        {
            var test1 = CarsTable.Where(m => m.CarMark == mark && m.EngineValue <= engineValue && m.SellerCity == sellerCity);
            return test1.ToList<Car>();
        }


=======
>>>>>>> e821d3236604a14711d1ff940f0e31d087120bf5
    }
}
