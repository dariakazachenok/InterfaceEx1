using System;


namespace InterfaceEx1
{
    class Lamp : Switchable //реализация наследования
    {
        public int Value;
        public Lamp(bool b)
        {
            Value = b ? 1 : 0;
        }
        public override void Switchon()
        {
            Value = 1;
            Console.WriteLine("Lamp on");
        }

        public override void Switchoff()
        {
            Value = 0;
            Console.WriteLine("Lamp off");
        }
        public override void OnScreen()
        {
            Console.WriteLine(Value == 1 ? "Lamp on" : "Lamp off");
        }
    }
}
