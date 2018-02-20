using System;

namespace InterfaceEx1
{
    interface ISwitchable // объявление интерфейса 1
    {
        void Switchon();
        void Switchoff();
    }
    interface ISwitchAll // объявление интерфейса 2
    {
        void FlatSwitchOffAll();
    }

    class TV : ISwitchable //реализация интерфейса 1
    {
        public void Switchon()
        {
            Console.WriteLine("TV on");
        }

        public void Switchoff()
        {
            Console.WriteLine("TV off");
        }
    }
    class Computer : ISwitchable //реализация интерфейса 2
    {
        public void Switchon()
        {
            Console.WriteLine("Computer on");
        }

        public void Switchoff()
        {
            Console.WriteLine("Computer off");
        }
    }

    class Lamp : ISwitchable //реализация интерфейса 1
    {
        public void Switchon()
        {
            Console.WriteLine("Lamp on");
        }

        public void Switchoff()
        {
            Console.WriteLine("Lamp off");
        }
    }
    class SwitchoffAll : ISwitchAll //реализация интерфейса 2
    {
        public void FlatSwitchOffAll()
        {
            Console.WriteLine("All off");
        }
    }

    class InterfaceEx1
    {
        static void Main()
        {
            TV tv1 = new TV();
            TV tv2 = new TV();
            Computer com = new Computer();
            Lamp lp = new Lamp();
            SwitchoffAll flat = new SwitchoffAll();

            Console.WriteLine("1- включить 1 телевизор" + "\r\n" + "2- выключить 1 телевизор" + "\r\n" + "3- включить 2 телевизор" + "\r\n" + "4- выключить 2 телевизор" + "\r\n" + "5- включить компьютер" + "\r\n" + "6- выключить компьютер" + "\r\n" + "7- включить лампу" + "\r\n" + "8- выключить лампу" + "\r\n" + "9- All off in flat" + "\r\n");
            while (true)
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                    {
                        tv1.Switchon();
                        break;
                    }
                    case 2:
                    {
                        tv2.Switchoff();
                        break;
                    }
                    case 3:
                    {
                        tv2.Switchon();
                        break;
                    }
                    case 4:
                    {
                        tv2.Switchoff();
                        break;
                    }

                    case 5:
                    {
                        com.Switchon();
                        break;
                    }
                    case 6:
                    {
                        com.Switchoff();
                        break;
                    }
                    case 7:
                    {
                        lp.Switchon();
                        break;
                    }
                    case 8:
                    {
                        lp.Switchoff();
                        break;
                    }
                    case 9:
                    {
                        flat.FlatSwitchOffAll();
                        break;
                    }
                }
            }
        }
    }
}
