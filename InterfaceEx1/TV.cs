using System;


namespace InterfaceEx1
{
    class TV : Switchable //реализация наследования
    
    {
        public int Value;
        public TV(bool b)
        {
            Value = b ? 1 : 0;
        }

        public override void Switchon()
        {
            Value = 1;
            Console.WriteLine("TV on");
        }

        public override void Switchoff()
        {
            Value = 0;
            Console.WriteLine("TV off");
        }
        public override void OnScreen()
        {
            Console.WriteLine(Value == 1 ? "TV on" : "TV off");
        }
    }
}
