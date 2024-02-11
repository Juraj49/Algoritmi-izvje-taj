using System.ComponentModel.DataAnnotations;
using System;

namespace Hash.Table;

    class Program
    {
        static void Main(string [] args)
        {
            HashTable hashtable=new HashTable(5);
            hashtable.Insert("Iva",5);
            hashtable.Insert("Ivan",5);
            hashtable.Insert("Ive",4);
            hashtable.Insert("Ivana",5);
            hashtable.Insert("Ivanka",5);
            hashtable.Insert("Ivancica",5);
            hashtable.Insert("stipe",5);
            hashtable.Insert("marko",4);
            hashtable.Insert("Mate",4);
            hashtable.Insert("zvone",4);
            hashtable.Display();
            hashtable.Delete("Iva");
            hashtable.Display();
            hashtable.Delete("Ivana");
            hashtable.Display();
            hashtable.Delete("marko");
            hashtable.Delete("Ivancica");
            hashtable.Display();
        }
    }
