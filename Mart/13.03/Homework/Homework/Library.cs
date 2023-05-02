using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Library : IBaseLibrary
    {
        //properties
        public string OuthorId { get; set; }
        public string OuthorName { get; set; }
        public string OuthorSurname { get; set; }
        public string BookId { get; set; }
        public string BookName { get; set; }
        public string BookFace { get; set; }
        public bool IsDeleted { get; set; }

        //Virtual Database
        private static ArrayList VirtualDataLibrary;

        public void AddBook(int OuthhorId)
        {
            throw new NotImplementedException();
        }

        public void CreateOuthor(int OuthorId)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(int bookId)
        {
            throw new NotImplementedException();
        }

        public void SerachBook(string BookName)
        {
            throw new NotImplementedException();
        }

        public void ShowBooks()
        {
            throw new NotImplementedException();
        }

        public void Update(int OuthorId)
        {
            throw new NotImplementedException();
        }
    }
}
