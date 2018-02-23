using System;


namespace InterfaceEx1
{
    class Computer : Switchable //реализация наследования
    {
        public int Value;
        public Computer(bool b)
        {
            Value = b ? 1 : 0;
        }
        public override void Switchon()
        {
            Value = 1;
            Console.WriteLine("Computer on");
        }

        public override void Switchoff()
        {
            Value = 0;
            Console.WriteLine("Computer off");
        }
        public override void OnScreen()
        {
            Console.WriteLine(Value == 1 ? "Computer on" : "Computer off");
        }
    }
}
