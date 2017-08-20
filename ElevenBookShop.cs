using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenBookShop
{
    class Books
    {
        public string author;
        public string title;
        public float price;
        public string publisher;
        public string stockPosition;
        public int numberOfCopies;

        public Books(string author, string title, float price, string publisher, string stockPosition, int numberOfCopies)
        {
            this.author = author;
            this.title = title;
            this.price = price;
            this.publisher = publisher;
            this.stockPosition = stockPosition;
            this.numberOfCopies = numberOfCopies;
        }
        public void Display(string author, string title, float price, string publisher, string stockPosition, int numberOfCopies)
        {
            Console.WriteLine("\nAuthor: " + author);
            Console.WriteLine("\nTitle: " + title);
            Console.WriteLine("\nPrice: " + price);
            Console.WriteLine("\nPublisher: " + publisher);
            Console.WriteLine("\nStock Position: " + stockPosition);
            Console.WriteLine("\nNumber Of Copies: " + numberOfCopies);
            Console.WriteLine("\nEnter the number of copies you required: \n");
            int copies = int.Parse(Console.ReadLine());
            if(copies > numberOfCopies)
            {
                Console.WriteLine("\nInsufficient Stock!");
            }
            else
            {
                Console.WriteLine("\nThe price of the book for {0} are Rs. {1}", copies, copies * price);
            }
        }
    class Program
    {
            static void Main(string[] args)
            {
                string ch = null;
                try
                {
                    Console.WriteLine("\nEnter the number of books to register in OPAC: \n");
                    int size = int.Parse(Console.ReadLine());
                    Books[] obj = new Books[size];
                    for (int i = 0; i < size; i++)
                    {
                        Console.WriteLine("\nEnter the details of Book {0}: \n", i + 1);
                        Console.WriteLine("\nEnter the author of the book: \n");
                        string author = Console.ReadLine();
                        Console.WriteLine("\nEnter the title of the book: \n");
                        string title = Console.ReadLine();
                        Console.WriteLine("\nEnter the price of the book: \n");
                        float price = float.Parse(Console.ReadLine());
                        Console.WriteLine("\nEnter the publisher of the book: \n");
                        string publisher = Console.ReadLine();
                        Console.WriteLine("\nEnter the stock position of the book: \n");
                        string stockPosition = Console.ReadLine();
                        Console.WriteLine("\nEnter the number of copies of the book: \n");
                        int numberOfCopies = int.Parse(Console.ReadLine());
                        obj[i] = new Books(author, title, price, publisher, stockPosition, numberOfCopies);
                        Console.WriteLine("-------------------------------------------------------------");
                    }
                    Console.WriteLine("\n--------------------OPAC DATABASE------------------");
                    do
                    {
                        int index = -1;
                        Console.WriteLine("\nEnter the title of the book: \n");
                        string title = Console.ReadLine();
                        Console.WriteLine("\nEnter the author of the book: \n");
                        string author = Console.ReadLine();
                        for (int i = 0; i < size; i++)
                        {
                            if ((title.Equals(obj[i].title)) && author.Equals(obj[i].author))
                            {
                                index = i;
                            }
                        }
                        if (index == -1)
                        {
                            Console.WriteLine("\nBook Not found !");
                        }
                        else
                        {
                            obj[index].Display(obj[index].author, obj[index].title, obj[index].price, obj[index].publisher, obj[index].stockPosition, obj[index].numberOfCopies);
                        }
                        Console.WriteLine("\nDo you want to continue? (Y/N)");
                        ch = Console.ReadLine();
                    } while (!ch.Equals("NO") && !ch.Equals("no") && !(ch.Equals("n")) && !(ch.Equals("N")));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadLine();
            }
        }
    }
}
