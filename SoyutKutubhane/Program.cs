using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiraSizde104
{
    public abstract class Ortak
    {
        public uint SayfaSayisi { get; set; }
        public string Adi { get; set; }
        public ushort BasimYili { get; set; }
        public abstract void Oku();
        
    }
    public class Kitap : Ortak
    {
        public uint Turu { get; set; }
        public override void Oku()
        {
            Console.WriteLine("Kitap okuma metodu gerçekleşti");
        }
    }
    public class Dergi : Ortak
    {
        public uint SayiNo { get; set; }
        public override void Oku()
        {
            Console.WriteLine("Dergi okuma işlemi gerçekleşti");
        }

    }
    public class Ansiklopedi : Ortak
    {
        public string CiltNo { get; set; }
        public override void Oku()
        {
            Console.WriteLine("Ansiklopedi okuma işlemi gerçekleşti");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ansiklopedi ansiklopedi = new Ansiklopedi();
            ansiklopedi.Oku();
            Console.WriteLine("=========================");
            Kitap kitap = new Kitap();
            kitap.Oku();
            Console.WriteLine("=========================");
            Dergi dergi = new Dergi();
            dergi.Oku();
            Console.WriteLine("=========================");
        }
    }
}