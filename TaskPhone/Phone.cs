using System;

namespace TaskPhone
{
    public class Phone
    {
        private int number;
        private string model;
        private int weight;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Phone(int number, string model, int weight) : this(number,model)
        {
            this.weight = weight;

        }
        public Phone(int number, string model)
        {
            this.number = number;
            this.model = model;
           
        }
        public Phone()
        {
            
        }
        
        public void Print()
        {
            Console.WriteLine($"Phone Number:{number}, Model:{model}, Weight:{weight}");
        }

        public void ReceiveCall(string name)
        {
            Console.WriteLine($"Calling: {name}");
        }
        public void ReceiveCall(string name, int number)
        {
            Console.WriteLine($"Calling: {name}, Phone Number: {number}");
        }

        public int GetNumber(int number)
        {
            return number;
        }

        public void SendMessage(int[] number)
        {
            foreach (var el in number)
            {
                Console.WriteLine($"Number: {el} sent message");
            }
        }
        
    }
    
    
}

