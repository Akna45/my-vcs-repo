using System;
using System.Collections;
using System.IO;
using System.Runtime;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Halo, ini adalah koding tertanggal : " + DateTime.Now);
            // input
            ReadFile("a.txt");
            Console.ReadKey();

            //output

        }
        static void ReadFile(string fileName)
        {
            TextReader reader = null;
            try
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
            finally
            {
                reader.Close();
            }
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
    public class Sequence
    {
        // Static field, holding the current sequence value
        private static int currentValue = 0;
        // Intentionally deny instantiation of this class
        private Sequence()
        {
        }
        // Static method for taking the next sequence value
        public static int NextValue()
        {
            currentValue++;
            return currentValue;
        }
    }
}
