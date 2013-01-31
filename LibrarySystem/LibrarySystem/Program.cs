using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using LibrarySystem.Domain;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // set database initializer
            Database.SetInitializer<LibraryContext>(new LibraryContextInitializer());

            LibraryContext db = new LibraryContext();
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;


            Console.WriteLine("Database contains:");

            var titles = db.Titles.ToList();
            Console.WriteLine(string.Format("{0} Titles", titles.Count()));

            var copies = db.Copies.ToList();
            Console.WriteLine(string.Format("{0} Copies", copies.Count()));

            var members = db.Members.ToList();
            Console.WriteLine(string.Format("{0} Members", members.Count()));

            var loans = db.Loans.ToList();
            Console.WriteLine(string.Format("{0} Loans", loans.Count()));

            var categories = db.Categories.ToList();
            Console.WriteLine(string.Format("{0} Categories", categories.Count()));


             Console.ReadLine();
        }
    }
}
