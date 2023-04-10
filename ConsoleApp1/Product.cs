using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Product
    {
        private  int _id;
        public static int Id {
            get { return _id; }
            set { if (value >0)    
                _id = value; }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 5)
                   _name = value;
            }
        }
        private int _price;
        public static int Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                    _price = value;
            }
        }
        private int _count;
        public static int Count
        {
            get { return _count; }
            set
            {
                if (value > 0)
                    _count = value;
            }
        }

    }
}
