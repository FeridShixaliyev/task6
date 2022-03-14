using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            string lengthstr;
            int length;
            do
            {
                Console.WriteLine("Sayi daxil edin: ");
                lengthstr = Console.ReadLine();
                length = Convert.ToInt32(lengthstr);
            } while (length < 0);

            Book[] books = new Book[length];

            for (int i = 0; i < length; i++)
            {
                int no = Getinputint($"{i + 1}.Bookun no-sunu daxil edin:", int.MaxValue,  4);
                string name = Getinputstr($"{i + 1}.Bookun adini daxil edin:", 25, 2);
                double price = Getinputint($"{i + 1}.Bookun qiymetini daxil edin:", int.MaxValue, 4);
                int count = Getinputint($"{i + 1}.Bookun sayini daxil edin:", int.MaxValue, 4);
                string genre = Getinputstr($"{i + 1}.Bookun janrini daxil edin:", 15, 2);

                books[i] = new Book(price, no,genre,name)
                {
                    Genre = genre,
                    


                };
            }


        }
            static int Getinputint(string name,int max,int min)
            {
            int input;
            string inputstr;
            do
            {
                Console.WriteLine(name);
                inputstr = Console.ReadLine();
                input = Convert.ToInt32(inputstr);
            } while (input < min || input > max);
            return input;
            }

        static string Getinputstr(string name,int max,int min)
        {
            string input;
            do
            {
                Console.WriteLine(name);
                input = Console.ReadLine();
             
            } while (input.Length < min || input.Length > max);
            return input;
        }

        static double Getinputdouble(string name, int max, int min)
        {
            double input;
            string inputstr;
            do
            {
                Console.WriteLine(name);
                inputstr = Console.ReadLine();
                input = Convert.ToInt32(inputstr);
            } while (input < min || input > max);
            return input;
        }

        
        class Product
    {
        public Product(int no, string name, int price)
        {
            this.No = no;
            this.Name = name;
            this.Price = price;
        }
        
        public int No;
        public string Name;
        public int Price;
        public int Count;
    }
    class Book : Product
    {
        public Book(string genre,int no, string name, int price) : base(no,name,price)
        {
            this.Genre = genre;
        }

        public string Genre;
    }
}
