using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleApp1
{
    internal class Market : Interface1
    {
        private int _Productlimit;
        public int Productlimit
        {
            get { return _Productlimit; }
            set { _Productlimit=value; }

        }

        private int _Producs;
        public int Producs
        {
            get { return _Producs; }
            set { _Producs=value; }

        }

        private static int _totalincome;
        public static int Totalincome
        {
            get { return _totalincome; }
            set { _totalincome=value; }

        }
        private Product[] _product;
        public Product[] Product
        {  get { return _product; }
        set { _product= value;}
        }
        public void AddProduct(Product product) {
            foreach (var item in _product)
            {
                int  mehsul = 0;
                int static say = 0;
                if (product.Id !=item.Id)
                {
                    mehsul++
                }
                else if (product.Count<=Productlimit)
                {
                    say++
                }
            }
            if (mehsul>0 && say>0)

                Array.Resize(ref Product, Product.Length+1);
                Product[Product.Length-1]=product;
                
        }
        public void SellProduct(Product product) {
            foreach (var item in _product) { 
                int mehsul = _product.Length;
            int static say = _product.Length;
            if (product.Id !=item.Id)
            {
                    mehsul--;
                }
            else if (product.Count<=Productlimit & {
& )
                say--;
                _totalincome--;
                }
        }
            if (mehsul>0 && say>0)

                Array.Resize(ref Product, Product.Length-1);
                Product[Product.Length-1]=product;

    }
}
