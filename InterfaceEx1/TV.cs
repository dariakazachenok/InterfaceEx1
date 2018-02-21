using System;


namespace InterfaceEx1
{
    class TV : ISwitchable //реализация интерфейса 1
    
    {
        public int Value;
        public TV(bool b)
        {
            Value = b ? 1 : 0;
        }
        public void Switchon()
        {
            Value = 1;
            Console.WriteLine("TV on");
        }

        public void Switchoff()
        {
            Value = 0;
            Console.WriteLine("TV off");
        }
        public void OnScreen()
        {
            Console.WriteLine(Value == 1 ? "TV on" : "TV off");
        }
    }
}
