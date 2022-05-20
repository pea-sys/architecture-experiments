using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class BookShelf
    {
        private Book[] books;
        private int last = 0;
        public BookShelf(int maxsize)
        {
            books = new Book[maxsize];
        }
        public Book GetBookAt(int index)
        {
            return books[index];
        }
        public void appendBook(Book book)
        {
            this.books[last] = book; 
            last++;
        }
        public int getLength()
        {
            return last;
        }
        public Iterator iterator()
        {
            return new BookShelfIterator(this);
        }
    }
}
