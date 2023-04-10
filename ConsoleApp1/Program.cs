namespace ConsoleApp1
{
    internal class Program:Program
    {
        static void Main(string[] args)

        {

            Console.Write("Enter product Id: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Enter product Name: ");
            string productName = Console.ReadLine();

            Product product = new Product(productId,productName);

            bool search = true;

            while (search)
            {
                Console.WriteLine("1 - Employee elave et");
                Console.WriteLine("2 - Id ile tap");
                Console.WriteLine("3-productlara bax");
                Console.WriteLine("4 -Menudan Cixis");

                Console.Write("Secimini daxil et: ");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.Write("Product Id: ");
                        int productId = int.Parse(Console.ReadLine());

                        Console.Write(" Name : ");
                        string productName = Console.ReadLine();

                        Console.Write("Price : ");
                        string  productPrice= Console.ReadLine();

                        Product product= new Product { Id = productId, Name = productName, Price=productPrice };    
            

                        product.AddProduct(product);
                        break;

                    case 2:
                        Console.Write("Enter Product Id: ");
                        int producttofind = int.Parse(Console.ReadLine());

                        if (producttofind!)= null
                        {
                            producttofind.SellProduct(producttofind)
                        }
                        else
                        {
                            Console.WriteLine("There is no product in this name");
                        }
                        break;
                    case 3:
                        Console.WriteLine();

                    case 4:
                        search = false;
                        break;

                    default:
                        Console.WriteLine("The operation ended")
                        break;
                }
            }

        }
    }
}