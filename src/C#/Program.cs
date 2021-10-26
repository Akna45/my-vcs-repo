using System;
using System.Collections;
using System.IO;
using System.Runtime;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Halo, ini adalah koding tertanggal : " + DateTime.Now);
            // input
            bool hasil = (2 < 3 && 1 == 2);
            //output
            Console.WriteLine(hasil);
            Console.ReadKey();

        }
        static string ReverseText(string text)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }
            return sb.ToString();
        }
    }
    // contoh object
    /// <summary>
    /// contoh objek kucing
    /// </summary>
    public class Cat
    {
        // Field name
        private string name;
        // Field color
        private string color;
        public string Name
        {
            // Getter of the property "Name"
            get
            {
                return this.name;
            }
            // Setter of the property "Name"
            set
            {
                this.name = value;
            }
        }
        public string Color
        {
            // Getter of the property "Color"
            get
            {
                return this.color;
            }
            // Setter of the property "Color"
            set
            {
                this.color = value;
            }
        }
        // Default constructor
        public Cat()
        {
            this.name = "Unnamed";
            this.color = "gray";
        }
        // Constructor with parameters
        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        // Method SayMiau

        public void SayMiau()
        {
            Console.WriteLine("Cat {0} said: Miauuuuuu!", name);
        }
    }
    // Class declaration
    public class Dog
    { // Opening bracket of the class body
      // Field declaration
        private string name;
        // Constructor declaration (peremeterless empty constructor)
        public Dog()
        {
        }
        // Another constructor declaration
        public Dog(string name)
        {
            this.name = name;
        }
        // Property declaration
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        // Method declaration (non-static)
        public void Bark()
        {
            Console.WriteLine("{0} said: Wow-wow!",
            name ?? "[unnamed dog]");
        }
    } // Closing bracket of the class body
    class Tes
    {
        // data field
        public string a;
        public int i;
        public bool b;
        // constructor
        public Tes()
        {
            a = "tes";
            i = 0;
        }
        // method
        public bool nyalakanMesin()
        {
            Console.WriteLine("menyalakan mesin...");
            b = true;
            return b;
        }
        public bool matikanMesin()
        {
            Console.WriteLine("mematikan mesin...");
            b = false;
            return b;
        }
    }
    class Mobil
    {
        public string pabrikan;
        public string model;
        public int thnPembuatan;
        // Default Constructor
        /*public Mobil()
        {
            pabrikan = "Toyota";
            model = "Hatchback";
        }*/
        // Parameterized Constructor
        public Mobil(string a, string b, int c)
        {
            pabrikan = a;
            model = b;
            thnPembuatan = c;
        }

    }
}