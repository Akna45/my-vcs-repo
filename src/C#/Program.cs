using System;
using System.Collections;
using System.IO;
using System.Runtime;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using ContohObjek;
using Pembelajaran;

namespace C_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Halo, ini adalah koding tertanggal : " + DateTime.Now);
            // playground contoh
            // input
            //output
            int[] array = { 1, 2, 3, 4, 5 };
            // Get array size
            int length = array.Length;
            // Declare and create the reversed array
            int[] reversed = new int[length];
            // Initialize the reversed array
            for (int index = 0; index < length; index++)
            {
                reversed[length - index - 1] = array[index];
            }
            // Print the reversed array
            for (int index = 0; index < length; index++)
            {
                Console.Write(reversed[index] + " ");
            }
            Console.WriteLine("\n" + array.Length);
            // ..

            Console.ReadKey();
        }
    }
}

namespace ContohObjek
{
    // gunakan namespace ini untuk menarugh contoh dari referensi atau
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
        int age;
        int length;
        bool isMale;
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
        public int GetAge()
        {
            return age;
        }
        public void MakeOlder()
        {
            this.age++;
        }
        // Method declaration (non-static)
        private void Bark()
        {
            Console.WriteLine("{0} said: Wow-wow!",
            name ?? "[unnamed Dog]");
        }
    } // Closing bracket of the class body
    public class Kid
    {
        public void CallTheDog(Dog dog)
        {
            Console.WriteLine("Come, " + dog.Name);
        }
        public void WagTheDog(Dog dog)
        {

        }
    }
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
    static class Text
    {
        static void ReadFile(string fileName)
        {
            TextReader reader = new StreamReader(fileName);
            string line = reader.ReadLine();
            Console.WriteLine(line);
            reader.Close();
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
}

namespace Pembelajaran
{
    class Aritmatika
    {
        static int Tambah(int a, int b)
        {
            int c = a + b;
            return c;
        }
    }
    public class Contoh // deklarasi class
    { // bodi class (mulai/bagian pertama dieksekusi)
        private string a = null; // field class
        private string Name { get; set; } // property class (automatic property)
        private string name; // field
        public string Nama   // classic property initialization
        {
            get { return name; }
            set { name = value; }
        }
        readonly int myValue = 3;
        void PrintMyValue() // deklarasi method class (non-static)
        { // method body
            int myValue = 5;
            Console.WriteLine("My value is: " + myValue);
        }
        public int Coba(int a, int b/*parameter*/)
        {
            return a + b;
        }
        public Contoh() // constructor (bagian yang otomatis dieksekusi saat dipanggil berdasarkan parameter tertentu yang sudah diisi)
        {
            this.a = "a";
        }
    } // bodi class (akhir/bagian terakhir dieksekusi)
    public class Percobaan
    {
        private string name = "anjing";
        private void Bark()
        {
            Console.WriteLine("{0} said: Wow-wow!",
            name ?? "[unnamed Dog]");
        }
        static void main()
        {

        }
        public Percobaan()
        {
            Console.WriteLine("this.name mempunyai nilai = " + this.name);
        }
    }
}