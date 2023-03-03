using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homevorks
{
    class CardClass
    {
        private string _documentSerial;

        public string DocumentSerial {
            get
            {
                return _documentSerial;
            }
            set
            {
                if (value.Length == 2)
                {
                    bool ChekResult = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool badCharackter = !char.IsLetter(value[i]);
                        if (badCharackter)
                        {
                            ChekResult = true;
                            break;
                        }
                    }

                    if (ChekResult)
                    {
                        Console.WriteLine("Vəsiqənin seriası  yalnız  herfden ibaret olmalıdır.");
                    }
                    else this._documentSerial = value;

                }
                else
                {
                    Console.WriteLine("Vəsiqənin serialı 2 hərfdən uzun olmamalıdır");
                }

            }
        }
        private string _documentNumber;
        public string DocumentNumber
        {
            get
            {
                var length = _documentNumber.Length;
                var showFirsNLetter = 3;
                var hiddernFirst = "";

                for (int i = 0; i < length-showFirsNLetter; i++)
                {
                    hiddernFirst += "*";
                }

                return _documentNumber.Substring(0,showFirsNLetter)+hiddernFirst;
            }
            set
            {

                if (value.Length == 8)
                {
                    bool ChekResult = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool badCharackter = !char.IsNumber(value[i]);
                        if (badCharackter)
                        {
                            ChekResult = true;
                            break;
                        }
                    }

                    if (ChekResult)
                    {
                        Console.WriteLine("Vəsiqənin nömrəsinin  yalnız  reqemlerden ibaret olmalıdır.");
                    }
                    else this._documentSerial = value;

                }
                else
                {
                    Console.WriteLine("Vəsiqənin serialı 8 rəqəmdən uzun olmamalıdır");
                }
            }
        }
        public CardClass()
        {
        }
    }
}
