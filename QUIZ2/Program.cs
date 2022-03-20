using System;
using System.Collections.Generic;

namespace QUIZ2
{
    class Program
    {
        public static Dictionary<int, string> EconomyClass = new Dictionary<int, string>();

        public static Dictionary<int, string> BusinessClass = new Dictionary<int, string>();
        public static int choseValue;
        public static Passenger psg;
        static void Main(string[] args)
        {
            EmptySeatList();
            ChoiceClass();  
        }
        static void EmptySeatList()
        {
            EconomyClass.Add(1, "");
            EconomyClass.Add(2, "");
            EconomyClass.Add(3, "");
            EconomyClass.Add(4, "");
            EconomyClass.Add(5, "");
            EconomyClass.Add(6, "");
            EconomyClass.Add(7, "");
            EconomyClass.Add(8, "");
            EconomyClass.Add(9, "");


            BusinessClass.Add(9, "selin");
            BusinessClass.Add(12, "");
            BusinessClass.Add(13, "");
            BusinessClass.Add(19, "sercan");
            BusinessClass.Add(20, "");
            BusinessClass.Add(24, "");
            BusinessClass.Add(27, "");
            BusinessClass.Add(30, "");
            BusinessClass.Add(35, "");
            BusinessClass.Add(40, "");
            BusinessClass.Add(45, "");
            BusinessClass.Add(50, "");
        }
       
        static void ChoiceClass()
        {
            Console.WriteLine("Economy Class için 1'e basın");
            Console.WriteLine("Business Class için 2'e basın");
            psg = new Passenger();
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    psg.anyClass = "1";
                    ControlEmptySeats(EconomyClass, "EconomyClass için boş olan koltuklar:");
                    choseValue = Convert.ToInt32(Console.ReadLine());
                    psg.seatNo = choseValue;
                    Console.WriteLine("Lütfen Ad Soyad giriniz");
                    psg.NameSurname = (Console.ReadLine().ToString());
                    Console.WriteLine(psg.anyClass + " bölümündeki " + psg.seatNo + " numaralı koltuk " + psg.NameSurname + " isimli yolcuya rezerve edilmiştir ");
                    EconomyClass[psg.seatNo] = "bu koltuk " + psg.NameSurname + " tarafından alındı, Lütfen başka bir koltuk seçiniz!";
                    Console.WriteLine("Devam etmek için 0'a basın! ");
                    AddNewPassengers();
                    break;
                case 2:
                    psg.anyClass = "2";
                    ControlEmptySeats(BusinessClass, "BusinessClass için boş olan koltuklar.");
                    psg.seatNo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Lütfen Ad Soyad giriniz;");
                    psg.NameSurname = (Console.ReadLine().ToString());
                    Console.WriteLine(psg.anyClass + " bölümündeki " + psg.seatNo + " numaralı koltuk " + psg.NameSurname + " isimli yolcuya rezerve edilmiştir. ");
                    BusinessClass[psg.seatNo] = "bu koltuk " + psg.NameSurname + " tarafından alındı, Lütfen başka bir koltuk seçiniz!";
                    Console.WriteLine("Devam etmek için 0'a basın! ");
                    AddNewPassengers();
                    break;
            }
        }

        static void AddNewPassengers()
        {
            if (Convert.ToInt32(Console.ReadLine()) == 0)
            {
                ChoiceClass();
            }
        }
        
        static void ControlEmptySeats(Dictionary<int, string> seatList, string name)
        {
            Console.WriteLine(name);
            foreach (var seats in seatList)
            {
                if (seats.Value == "")
                {
                    Console.WriteLine(seats.Key);
                }
                
            }
        }
        
        public static void Failed(int value, string name)
        {
            Console.WriteLine("Seçilen koltuk numarası : " + value);
            Console.WriteLine(value + " numaralı koltuk başka bir yolcuya zaten rezerve edilmiş.  Lütfen başka bir koltuk seçiniz.");
            ChoiceClass();
        }
        public static void FailedValue()
        {
            Console.WriteLine("Böyle bir değer yok");
            ChoiceClass();
        }
    }
}
