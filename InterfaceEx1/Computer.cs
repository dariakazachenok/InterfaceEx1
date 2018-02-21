using System;


namespace InterfaceEx1
{
    class Computer : ISwitchable //реализация интерфейса 1
    {
        public int Value;
        public Computer(bool b)
        {
            Value = b ? 1 : 0;
        }
        public void Switchon()
        {
            Value = 1;
            Console.WriteLine("Computer on");
        }

        public void Switchoff()
        {
            Value = 0;
            Console.WriteLine("Computer off");
        }
        public void OnScreen()
        {
            Console.WriteLine(Value == 1 ? "Computer on" : "Computer off");
        }
    }
}
