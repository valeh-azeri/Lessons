using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homwork1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Homework 1:
             5 dənə dəyişəni Implicit Conversion,
             5 dənə dəyişəni Explicit Conversion,
             5 dənə dəyişəni Helper Class Conversion vasitəsilə convert edin. Dəyişən tiplərini və dəyərlərini özünüz seçin.
             
             
             
             */

            #region Homework 1
            // impilicit  Nümunə - 5 ədəd
            byte VarBayte = 200;
            short TakeByte = VarBayte;
            int takeByte = VarBayte;

            byte ByteMaxVar = byte.MaxValue;
            int TakeByteMaxVar = ByteMaxVar;

            short VarShort = 31000;
            int TakeShort = VarShort;

            ////Altda yazdığım xəta verəcək 
            //short VarShortError = 35000;
            //int TakeShortError = VarShort;

            int VarInt = 32000;
            long TakeInt = VarInt;

            int VarIntMax = int.MaxValue;
            long TarIntMax = VarIntMax;

            //Explicit Nümunə 5 ədəd

            long VarLongExp = 999999999;
            int TakeIntExp = (int)VarLongExp;

            int VarIntEcp = 30000;
            short TakeShortExp = (short)VarIntEcp;

            double VarDoubleExp = 1865654.6;
            float TakeFloatExp = (float)VarDoubleExp;

            double VarDoubleExp1 = 18654.6;
            decimal TakeFloatExp1 = (decimal)VarDoubleExp1;

            byte VarbyteExp = 200;
            int TakeByteExp = (int)VarbyteExp;

            //Helper Class Conversion Nümunə
            int varİnt = 1235;
            string takeInt = Convert.ToString(varİnt);

            string Alphabet = "A";
            char TakeChar = Convert.ToChar(Alphabet);

            char varChar = '?';
            string takeChar = Convert.ToString(varChar);

            string boolString = "true";
            bool takeBoolString = Convert.ToBoolean(boolString);

            DateTime newDateTime = new DateTime(1982, 10, 23);
            string takeDateTime = Convert.ToString(newDateTime);


            #endregion
        }
    }
}
