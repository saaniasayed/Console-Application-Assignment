using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        struct book
        {
            public string title;
            public string author;
        }

        static void Main(string[] args)
        {
            /* Create a small database, which will be used to store data about books. 
            For a certain book, we want to keep the following information: Title, Author
            The program must be able to store 1000 books, and the user will be allowed to:
            - Add data for one book
            - Display all the entered books (just title and author, in the same line)
            - Search for the book(s) with a certain title
            - Delete a book at a known position (for example, book number 6)
            - Exit the program
            Hint: to delete an item in an array, you must move backwards every item which was placed
            after it, and the decrease the counter. */

            int capacity = 1000, amount = 0;
            book[] books = new book[capacity];
            bool repeat = true, found;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Books database");
                Console.WriteLine();
                Console.WriteLine("1. Add A New Book");
                Console.WriteLine("2. Display Books");
                Console.WriteLine("3. Search A Book");
                Console.WriteLine("4. Delete A Book");
                Console.WriteLine("0. Exit");
                Console.Write("Enter an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    
                    case "1":
                        if (amount < capacity)
                        {
                            Console.WriteLine("Enter Details For Book {0}", amount + 1);
                            Console.Write("Enter Book Name: ");
                            books[amount].title = Console.ReadLine();
                            Console.Write("Enter Book Author: ");
                            books[amount].author = Console.ReadLine();
                            amount++;
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Database Full");
                        }
                        break;

                    case "2":
                        if (amount == 0)
                        {
                            Console.WriteLine("No data available to search");
                        }
                        else
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                Console.WriteLine("{0}: Book Title: {1},  Author: {2}", i + 1, books[i].title, books[i].author);
                            }
                            Console.WriteLine();
                        }
                        break;

                    case "3":
                        Console.WriteLine("Enter Book To Search: ");
                        string search = Console.ReadLine();
                        found = false;
                        for (int i = 0; i < amount; i++)
                        {
                            if (books[i].title.ToUpper().Contains(search.ToUpper()) || books[i].author.ToUpper().Contains(search.ToUpper()))
                            {
                                Console.WriteLine("{0} found in {1}", search, books[i].title);
                                found = true;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("Book Not Found!");
                        }
                        break;

                    case "4":
                        if (amount == 0)
                        {
                            Console.WriteLine("No data to delete");
                        }
                        else
                        {
                            Console.WriteLine("Enter Book Number to Delete (1 to {0}): ", amount);
                            int posToDelete = int.Parse(Console.ReadLine()) - 1;
                            for (int i = posToDelete; i < amount - 1; i++)
                            {
                                books[i] = books[i + 1];
                            }
                            amount--;
                        }
                        break;

                    case "0":
                        repeat = false;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Wrong option. Please re-enter\n");
                        break;
                }

            } while (repeat);
        }
    }
}
