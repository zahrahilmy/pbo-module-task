using System;

namespace Devices
{
    class Processor
    {
        public string Merk { get; }
        public string Tipe { get; }

        public Processor(string merk, string tipe)
        {
            Merk = merk;
            Tipe = tipe;
        }
    }

    class Intel : Processor
    {
        public Intel(string tipe) : base("Intel", tipe)
        {

        }
    }

    class Corei3 : Intel
    {
        public Corei3() : base("Core i3")
        {

        }
    }

    class Corei5 : Intel
    {
        public Corei5() : base("Core i5")
        {

        }
    }

    class Corei7 : Intel
    {
        public Corei7() : base("Core i7")
        {

        }
    }

    class AMD : Processor
    {
        public AMD(string tipe) : base("AMD", tipe)
        {
        }
    }

    class Ryzen : AMD
    {
        public Ryzen(string tipe) : base("RAYZEN")
        {

        }
    }

    class Athlon : AMD
    {
        public Athlon(string tipe) : base("ATHLON")
        {

        }
    }

    class Vga
    {
        public string Merk { get; }

        public Vga(string merk)
        {
            Merk = merk;
        }
    }

    class Nvidia : Vga
    {
        public Nvidia(string merk) : base("Nvidia")
        {

        }
    }

    class AMDv : Vga
    {
        public AMDv(string merk) : base("AMD")
        {

        }
    }

    class Laptop
    {
        public string Merk { get; }
        public string Tipe { get; }
        public Vga Vga { get; }
        public Processor Processor { get; }

        public Laptop(string merk, string tipe, Vga vga, Processor processor)
        {
            Merk = merk;
            Tipe = tipe;
            Vga = vga;
            Processor = processor;
        }
        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {Merk} {Tipe} menyala.");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {Merk} {Tipe} mati. ");
        }
    }

    class ASUS : Laptop
    {
        public ASUS(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
        }
    }

    class ROG : ASUS
    {
        public ROG(string tipe) : base("ROG", "ROG", new Nvidia("Nvidia"), new Corei7())
        {

        }
    }

    class Vivobook : ASUS
    {
        public Vivobook(string tipe) : base("Vivobook", tipe, new Nvidia("Nvidia"), new Corei5())
        {

        }

        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, Error lagiiiii!!!");
        }
    }

    class ACER : Laptop
    {
        public ACER(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {

        }
    }

    class Swift : ACER
    {
        public Swift(string tipe) : base("Swift", tipe, new Nvidia("Nvidia"), new Ryzen("Ryzen"))
        {

        }
    }
    class Predator : ACER
    {
        public Predator(string tipe) : base("Predator", tipe, new Nvidia("Nvidia"), new Corei7())
        {

        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {Merk} {Tipe} sedang memainkan game.");
        }
    }
    class Lenovo : Laptop
    {
        public Lenovo(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
            merk = "Lenovo";
        }
    }
    class Ideapad : Lenovo
    {
        public Ideapad(string tipe) : base("IdeaPad", tipe, new AMDv("AMD"), new Ryzen("Ryzen"))
        {

        }
    }
    class Legion : Lenovo
    {
        public Legion(string tipe) : base("Legion", tipe, new Nvidia("Nvidia"), new Corei7())
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vga vga1 = new Vga("Vga Nvidia");
            Vga vga2 = new Vga("Vga AMD");

            Intel pro1 = new Intel("Core i5");
            Intel pro2 = new Intel("Core i7");
            AMD pro3 = new AMD("Ryzen");

            Laptop laptop1 = new ASUS("ASUS", "Vivobook", vga1, pro1);
            Laptop laptop2 = new Ideapad("IdeaPad");
            Predator predator = new Predator("Predator");

            laptop1.LaptopDinyalakan();
            laptop1.LaptopDimatikan();
            predator.BermainGame();

            //ACER acer = new Predator(new AMD(), new Corei7());
            //acer.vga = new AMD();
            //acer.Processor = new Corei7();
            //acer.BermainGame();
            
        }
    }
}
