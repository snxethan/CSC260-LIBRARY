using PersistenceDAL.DAL;
using PersistenceDAL.Models;
using System;
using System.Linq;

namespace DataConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string connectionString =
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\projects\NEU\Y2\Q4\CSC260\WidgetPersistence\Persistence\PersistenceDAL\TestDB.mdf;Integrated Security=True";

            var dal = new SqlWidgetDAL(connectionString);

            //  Delete all Widgets 
            Console.WriteLine("\n[1] Deleting all widgets...");
            dal.DeleteAllWidgets();

            //  Insert at least 5 Widgets 
            Console.WriteLine("[2] Inserting 5 widgets...");
            var names = new[] { "Alpha", "Beta", "Gamma", "Delta", "Epsilon" };
            foreach (var n in names) dal.AddWidget(n);

            //  Print all Widgets 
            Console.WriteLine("[3] All widgets after insert:");
            PrintAll(dal);

            //  Update one Widget
            Console.WriteLine("[4] Updating 'Gamma' -> 'Gamma 2.0'...");
            var target = dal.GetWidget("Gamma");
            if (target != null)
            {
                dal.UpdateWidget(target.Id, "Gamma 2.0");
            }
            else
            {
                Console.WriteLine(" - 'Gamma' not found (nothing to update).");
            }

            //  Print just the record updated to prove that it has changed 
            Console.WriteLine("[5] Fetching updated record by name:");
            var updated = dal.GetWidget("Gamma (Updated)");
            if (updated != null)
            {
                Console.WriteLine($"   Updated -> Id={updated.Id}, Name={updated.Name}");
            }
            else
            {
                Console.WriteLine("   Updated record not found.");
            }

            //  show delete-by-id working (not required by rubric)
            // if (updated != null) { dal.DeleteWidget(updated.Id); }

            Console.WriteLine("\nDone.");
        }

        private static void PrintAll(SqlWidgetDAL dal)
        {
            var all = dal.GetWidgets();
            if (all == null || all.Count == 0)
            {
                Console.WriteLine("   (no widgets)");
                return;
            }

            foreach (var w in all)
            {
                Console.WriteLine($"   Id={w.Id}, Name={w.Name}");
            }
        }
    }
}
