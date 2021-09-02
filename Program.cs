using System;
using System.Collections.Generic;
namespace clothing_store
{
    class Program
    {
        static void Main(string[] args)
        {

            User user = new User();
            Console.Write("\nName : {0}", user.name);
            Console.WriteLine(" || Email : {0}", user.email);

            Address address = new Address("131/75 Phutthamonthon Road", "Nakhon Pathom", "10180");
            Console.Write("Delivery address : {0} {1} {2}", address.street, address.city, address.zipCode);
            
            List<T_shirt> t_shirts = new List<T_shirt>();

            T_shirt shirts1 = new T_shirt("L", "Red", 500f, "MDT111");
            T_shirt shirts2 = new T_shirt("M", "black", 750f, "MDT222");
            T_shirt shirts3 = new T_shirt("S", "White", 625f, "MDT333");

            Console.WriteLine();
            t_shirts.Add(shirts1);
            t_shirts.Add(shirts2);
            t_shirts.Add(shirts3);

            foreach (T_shirt t_shirt in t_shirts)
            {
                Console.WriteLine("Size : {0} , Color : {1} , Price {2} , Image {3}", t_shirt.size, t_shirt.color, t_shirt.price, t_shirt.image);                
            }

            ShoppingCart shopping = new ShoppingCart(0);
            
            foreach (T_shirt t_shirt in t_shirts)
            {
                shopping.totalcost += t_shirt.price;
            }

            Console.WriteLine("Total price : {0}", shopping.totalcost);
            /*
            List<ShoppingCart> shoppings = new List<ShoppingCart>();
            ShoppingCart shopp1 = new ShoppingCart(500f);
            ShoppingCart shopp2 = new ShoppingCart(750f);
            ShoppingCart shopp3 = new ShoppingCart(625f);
            shoppings.Add(shopp1);
            shoppings.Add(shopp2);
            shoppings.Add(shopp3);
            foreach (ShoppingCart t_shirt in shoppings)
            {
                totalcost += t_shirt.totalcost;
            }

            Console.WriteLine("Total price : {0}" ,totalcost);
            */

        }
    }



    class T_shirt
    {

        public string size;
        public string color;
        public float price;
        public string image;

        public T_shirt(string valuesize, string valuecolor, float valueprice, string valueimage)
        {

            size = valuesize;
            color = valuecolor;
            price = valueprice;
            image = valueimage;

        }

    }



    class User
    {

        public string name;
        public string email;
        public List<ShoppingCart> shoppingcarts;

        public User()
        {

            name = "Jame Watson";
            email = "jame@gmail.com";

        }
        
    }



    class Address
    {
        public string street;
        public string city;
        public string zipCode;

        public Address(string valuestreet , string valuecity, string valuezipCode)
        {
            street = valuestreet;
            city = valuecity;
            zipCode = valuezipCode;
        }

    }

    class ShoppingCart
    {
        public List<T_shirt> t_shirts;
        public float totalcost;
        private Address address;

        public ShoppingCart(float valuetotalcost)
        {

            totalcost = 0;
            
        }

        

    }






}
