using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public interface IBaseLibrary
    {

        //Methods
        void CreateOuthor(int OuthorId);
        void AddBook(int OuthhorId);
        void SerachBook(string BookName);
        void DeleteBook(int bookId);
        void Update(int OuthorId);
        void ShowBooks();


    }
}
