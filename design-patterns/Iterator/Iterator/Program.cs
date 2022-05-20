using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    /// <summary>
    /// Iteratorパターン・・・集合がスキャン可能なパターン
    /// 
    /// .NETでは出番は無さそう
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // デザインパターン入門に則った実装
            BookShelf bookShelf = new BookShelf(4);
            bookShelf.appendBook(new Book("Around the World in 80 Days*"));
            bookShelf.appendBook(new Book("Bible"));
            bookShelf.appendBook(new Book("Cinderella"));
            bookShelf.appendBook(new Book("Daddy-Long-Legs"));
            Iterator it = bookShelf.iterator();
            while (it.HasNext())
            {
                Book book = (Book)it.Next();
                Console.WriteLine(book.getName());
            }

            // C#チックに実装
            IEnumerable<Book> bookShelfCustom = new Book[] 
            {
                new Book("Around the World in 80 Days*"),
                new Book("Bible"),
                new Book("Cinderella"),
                new Book("Daddy-Long-Legs")
            };

            foreach (var book in bookShelfCustom)
            {
                Console.WriteLine(book.getName());
            }

            Console.ReadLine();
        }
    }
}
