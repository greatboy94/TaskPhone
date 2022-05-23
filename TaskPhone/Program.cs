using System;

namespace TaskPhone 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Phone phone1 = new Phone();
            phone1.Number = 1114554;
            phone1.Model = "Samsung J5";
            phone1.Weight = 300;
            phone1.Print();
            phone1.ReceiveCall("Ashley");
            Console.WriteLine(phone1.GetNumber(1114554));
            phone1.ReceiveCall("Tom",5556685);
            phone1.SendMessage(new int[] {1114554,5556685});
            
            Phone phone2 = new Phone();
            phone2.Number = 2225678;
            phone2.Model = "Samsung Galaxy S10";
            phone2.Weight = 600;
            phone2.Print();
            phone2.ReceiveCall("Andrew");
            Console.WriteLine(phone2.GetNumber(2225678));
            phone2.ReceiveCall("Mark",6542525);
            phone2.SendMessage(new int[] {2225678,6542525});
            
            Phone phone3 = new Phone();
            phone3.Number = 7776565;
            phone3.Model = "One Plus";
            phone3.Weight = 500;
            phone3.Print();
            phone3.ReceiveCall("Tom");
            Console.WriteLine(phone3.GetNumber(7776565));
            phone3.ReceiveCall("Holland",2364578);
            phone3.SendMessage(new int[] {7776565,2364578});







        }
    }
}