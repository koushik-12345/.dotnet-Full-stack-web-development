
﻿using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp9
{
    class Product
    {
        public int pId { get; set; }
        public string pName { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }
        public string category { get; set; }



        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4}", pId, pName, price,quantity,category);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Object Initializer
            product e1 = new product()
            {
                pId = 1020,
                pName = "vivo",
                price = "8000"
                quantity=4;
                category="mobile"
            };

            product e2 = new product() { pId = 1025, pName = "samsung", price = "34500",quantity=1,category="mobile" };

            product e3 = new product() { pId = 1026, pName = "apple", price = "30000",quantity=1,category="mobile" };
product e4 = new product() { pId = 1027, pName = "oppo", price = "34000",quantity=3,category="mobile" };
product e5 = new product() { pId = 1028, pName = "readme", price = "32500",quantity=9,category="mobile" };

           

            List<product>  pList = new List<product>();   
            pList.Add(e1);
            pList.Add(e2);
            pList.Add(e3);
            pList.Add(e4);
            pList.Add(e5);



            foreach (product item in pList)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}