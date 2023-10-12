// See https://aka.ms/new-console-template for more information
using System;
namespace Pertemuan2 {
    class Program {
        static void Main(string[] args) {
            Car Audi = new Car();
            Audi.details();

            Motor Yamaha = new Motor();
            Yamaha.setMerk("Yamaha");
            Yamaha.getMerk();

            Motor Honda = new Motor();
            Honda.getMerk();

        }
    }
    class Car {
        public string merk = "Merah";
        public int speed = 60;
        public void details() {
            Console.WriteLine("Warna Mobil : " + merk);
            Console.WriteLine("Kecepatan Mobil : " + speed);
        }
    }

    class Motor {
        private string merk = "Honda";
        public void setMerk(string newMerk) {
            this.merk = newMerk;
        }
        private void outputMerk() {
            Console.WriteLine("Merk Motor : " + this.merk);
        }

        public void getMerk() {
            outputMerk();
        }
    }
}