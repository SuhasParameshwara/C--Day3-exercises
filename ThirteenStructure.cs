using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirteenStructure
{
    struct Student
    {
        public string name;
        public string DateOfBirth;
        public int totalMarks;
    }
    struct Mail
    {
        public string name;
        public string doorNumber;
        public string street;
        public string city;
        public string pincode;
    }
    struct Inventory
    {
        public string itemCode;
        public string itemName;
        public float itemCost;
        public int totalItems;
    }
    struct Book
    {
        public string author;
        public string title;
        public int year;
        public float cost;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student objStudent = new Student();
            objStudent.name = "Suhas";
            objStudent.DateOfBirth = "27.11.1996";
            objStudent.totalMarks = 455;
            Mail objMail = new Mail();
            objMail.name = "Suhas";
            objMail.doorNumber = "No. 7F";
            objMail.street = "Anandha Housing Colony";
            objMail.city = "Coimbatore";
            objMail.pincode = "641-025";
            Inventory objInventory = new Inventory();
            objInventory.itemCode = "14Cs114";
            objInventory.itemCost = 95;
            objInventory.itemName = "Anonymous";
            objInventory.totalItems = 1;
            Book objBook = new Book();
            objBook.author = "Anders Hejlsberg";
            objBook.title = "C# Basics";
            objBook.year = 1996;
            objBook.cost = 1500;
            Console.WriteLine("-----------------------STUDENT INFORMATION------------------------");
            Console.WriteLine("Name: " + objStudent.name);
            Console.WriteLine("Date Of Birth: " + objStudent.DateOfBirth);
            Console.WriteLine("Total Marks: " + objStudent.totalMarks);
            Console.WriteLine("--------------------------MAIL INFORMATION---------------------------");
            Console.WriteLine("Name: " + objMail.name);
            Console.WriteLine("Door Number: " + objMail.doorNumber);
            Console.WriteLine("Street: " + objMail.street);
            Console.WriteLine("City: " + objMail.city);
            Console.WriteLine("Pin Code: " + objMail.pincode);
            Console.WriteLine("----------------------INVENTORY INFORMATION------------------------");
            Console.WriteLine("Item Name: " + objInventory.itemName);
            Console.WriteLine("Item Code: " + objInventory.itemCode);
            Console.WriteLine("Item Cost: " + objInventory.itemCost);
            Console.WriteLine("Total Items: " + objInventory.totalItems);
            Console.WriteLine("-------------------------BOOK INFORMATIOM-----------------------");
            Console.WriteLine("Author Name: " + objBook.author);
            Console.WriteLine("Title Name: " + objBook.title);
            Console.WriteLine("Year: " + objBook.title);
            Console.WriteLine("Cost: Rs. {0}", objBook.cost);
            Console.ReadLine();
        }
    }
}
