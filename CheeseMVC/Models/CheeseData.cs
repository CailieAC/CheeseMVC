using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class CheeseData
    {
        static private List<Cheese> cheeses = new List<Cheese>();

        //GetAll Method
        public static List<Cheese> GetAll()
        {
            return cheeses;
        }

        //Add Method
        public static void Add(Cheese cheese)
        {
            cheeses.Add(cheese);
        }

        //Remove Method
        public static void Remove(int id)
        {
            cheeses.Remove(GetById(id));
        }

        //GetById Method
        public static Cheese GetById(int id)
        {
            return cheeses.SingleOrDefault(x => x.CheeseId == id);
        }
    }
}
