using System;


namespace InterfaceEx1
{
    class Lamp : ISwitchable //реализация интерфейса 1
    {
        public int Value;
        public Lamp(bool b)
        {
            Value = b ? 1 : 0;
        }
        public void Switchon()
        {
            Value = 1;
            Console.WriteLine("Lamp on");
        }

        public void Switchoff()
        {
            Value = 0;
            Console.WriteLine("Lamp off");
        }
        public void OnScreen()
        {
            Console.WriteLine(Value == 1 ? "Lamp on" : "Lamp off");
        }
    }
}
