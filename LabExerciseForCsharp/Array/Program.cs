using System;
using System.Collections;

namespace Array
{
    // Write a program to print a sum of single dim int array.
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine(SumOfArray(arr));

            int[,] arr2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine(SumOfDiagonal(arr2));

            int[][] arr3 = new int[3][];
            arr3[0] = new int[] { 1, 2, 3 };
            arr3[1] = new int[] { 4, 5, 6 };
            arr3[2] = new int[] { 7, 8, 9 };
            Console.WriteLine(SearchElement(arr3, 5));

            int[,] arr4 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[] sum = SumOfEachRow(arr4);
            foreach (int i in sum)
            {
                Console.WriteLine(i);
            }

            Product p1 = new Product(1, "Product1", "Category1");
            Product p2 = new Product(2, "Product2", "Category2");
            Product p3 = new Product(3, "Product3", "Category3");

            List<Product> products = new List<Product>();
            products.Add(p1);
            products.Add(p2);
            products.Add(p3);

            foreach (Product p in products)
            {
                Console.WriteLine(p.ProductCode + " " + p.ProductName + " " + p.Category);
            }

            CountryMobilePrefix();



        }

        //  14 ->Write a program to print a sum of single dim int array.

        public static int SumOfArray(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }

        // 15 -> Write a program to display sum of diagonal elements (bold elements) of given array.
        public static int SumOfDiagonal(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum += arr[i, i];
            }
            return sum;
        }

        // 16 ->  Write a program to search element from jagged array.

        public static bool SearchElement(int[][] arr, int element)
        {
            foreach (int[] i in arr)
            {
                foreach (int j in i)
                {
                    if (j == element)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        //17 -> Write a program to make sum of each row for multi dim array and print them.
        public static int[] SumOfEachRow(int[,] arr)
        {
            int[] sum = new int[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum[i] += arr[i, j];
                }
            }
            return sum;
        }

        // 18 -> Write a program to collect list Product using Generic List<T> class and information of products. (Please follow below instructions to create Product class)
        // a. declares a class with the name [Product].
        // b. Create properties [ProductCode,ProductName,Category].
        // c. Create List<Product> and add products in a list and print them on console.

        public class Product
        {
            public int ProductCode { get; set; }
            public string ProductName { get; set; }
            public string Category { get; set; }

            public Product(int productCode, string productName, string category)
            {
                ProductCode = productCode;
                ProductName = productName;
                Category = category;
            }
        }
        //Write a program to maintain country name and its mobile telephone prefixes using hashtable and print them together.


        public static void CountryMobilePrefix()
        {
            Hashtable countryMobilePrefix = new Hashtable();
            countryMobilePrefix.Add("India", "+91");
            countryMobilePrefix.Add("USA", "+1");
            countryMobilePrefix.Add("UK", "+44");
            countryMobilePrefix.Add("Australia", "+61");

            foreach (DictionaryEntry entry in countryMobilePrefix)
            {
                Console.WriteLine(entry.Key + " " + entry.Value);
            }
        }


    }
}