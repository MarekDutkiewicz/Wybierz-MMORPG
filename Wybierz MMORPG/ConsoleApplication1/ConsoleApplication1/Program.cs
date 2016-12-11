using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Gry BnS = new Gry();
            BnS.nazwa = "Blade & Soul";
            BnS.opis = "Gra MMORPG osadzona w realiach azjatyckiego fantasy. Autorzy skoncentrowali się przede wszystkim na stworzeniu rozbudowanego systemu potyczek, opartego na dalekowschodnich sztukach walki. Starcia z wrogami dodatkowo uatrakcyjnia zaawansowany silnik fizyczny. Całość powstała w oparciu o technologię Unreal Engine 3.0.";
            BnS.StrInt = "www.bladeandsoul.com/";
            BnS.dwlp = "NCSoft";
        }
    }
}
