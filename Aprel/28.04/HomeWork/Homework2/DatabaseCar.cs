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
    }
}
