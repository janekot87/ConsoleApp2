using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        public static void Main()
        {
            


                var sel1 = Selection.GetSelection();
                var sel2 = Selection.GetSelection();
                var sel3 = Selection.GetSelection();
                var sel4 = Selection.GetSelection();

                var mrk1 = new Market(3);
                mrk1.Id = 1;
                mrk1.Name = "Market1";
                mrk1.SportId = 1;
                mrk1.LeagueId = 1;
                mrk1.AddSelection(sel1);
                mrk1.AddSelection(sel2);
                mrk1.AddSelection(sel3);
                mrk1.AddSelection(sel4);

            foreach (var i in mrk1.Selections)
            {
                Console.WriteLine(i.Id);
                Console.WriteLine(i.Name);
                Console.WriteLine(i.Title);
                Console.WriteLine(i.IsDisabled);
                Console.WriteLine(i.Status);
                Console.WriteLine();
            }












            















        }
       
        }
    }

