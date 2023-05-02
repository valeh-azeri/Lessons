using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public static class VirtualDatabase
    {
        private static ArrayList _db = new ArrayList();

        public static bool IsBarcodeDublicate(string barcode, int? exceptId=null)
        {
            if (_db!=null && _db.Count>0)
            {
                for (int i = 0; i < _db.Count; i++)
                {
                    Item item =(Item)_db[i];
                    if (item.Barcode==barcode && !item.IsDeleted && item.Id!=exceptId)
                    {
                        return true;
                    }

                }

            }
            return false; 
        }

        public static void NewIetm(Item newItem)
        {
            if (newItem !=null && !string.IsNullOrEmpty(newItem.Barcode))
            {

            }
        }
    }


}
