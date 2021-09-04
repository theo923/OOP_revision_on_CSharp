using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Developer> developer = new List<Developer>() { new JavascriptDeveloper("Theo", "Tam"), new CSharpDeveloper("Theo", "Tam") };

            foreach (var item in developer)
            {
                ShowItsPosition(item);
            }
        }

        static void ShowItsPosition(Developer developer)
        {
            developer.Code();
        }

    }
}
