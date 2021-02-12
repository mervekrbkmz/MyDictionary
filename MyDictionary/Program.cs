using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> myDictionary = new Dictionary<int, string>();
            myDictionary.Add(1,"Merve Karabekmez");
            myDictionary.Add(2, "Mustafa Karabekmez");
            myDictionary.Add(5, "Kemal Sunal");
            myDictionary.Add(6, "Halit Akçatepe");
            myDictionary.Add(12, "Zeki Alasya");
            myDictionary.Add(4, "Tarık Akan");

            myDictionary.List();
        }

        
    }

   
}
