using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class DatabaseCar
    {
        public static List<Car> CarsTable = new List<Car> {
        new Car()
        {
            CarID=1,
            CarMark="MBW",
            CarModel="IX37",
            CarYear=new DateTime(1982,10,10),
            SellerCity="Germany",
            Color=EnumColor.Black,
            Engine="Benzin",
            EngineValue="7000" ,
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
            CarYear=new DateTime(2000,10,10),
            SellerCity="Chine",
            Color=EnumColor.Brown,
            Engine="Disel",
            EngineValue="5000" ,
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
            CarYear=new DateTime(2002,10,10),
            SellerCity="Chine",
            Color=EnumColor.Brown,
            Engine="Benzin",
            EngineValue="5000" ,
            EngineForce="250FS",
            Kilometr=280000,
            VelocityBox=EnumVelcityBox.TipTronic,
            Price=75000
        },




        };


    }
}
