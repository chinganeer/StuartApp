using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Tournament tournament = new Tournament(); //Data
            var menuUi = new UI(); //UI

            menuUi.MenuMain(ref tournament);
            System.Environment.Exit(1);
        }
    }
}
