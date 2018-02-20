using System;


namespace InterfaceEx1
{
    interface ISwitchable // объявление интерфейса 1
    {
        void Switchon();
        void Switchoff();
        void OnScreen();
    }

    interface ISwitchAll // объявление интерфейса 2
    {
        void FlatSwitchOffAll();
    }

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
    
    class InterfaceEx1
    {
        static void Main()
        {
            TV tv1 = new TV(true);
            TV tv2 = new TV(true);
            Computer com = new Computer(true);
            Lamp lp = new Lamp(true);
            
            Console.WriteLine("1- Turn on 1 TV" + "\r\n" + "2- Turn off 1 TV" + "\r\n" + "3- Turn on 2 TV" + "\r\n" + "4- Turn off 2 TV" + "\r\n" + "5- Turn on computer" + "\r\n" + "Turn off computer" + "\r\n" + "7- Turn on lamp" + "\r\n" + "8- Turn off lamp" + "\r\n" + "9- All off in flat" + "\r\n" + "\r\n" + "10-Devices on? Status" + "\r\n");
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
                        tv1.Switchoff();
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
                        tv1.Switchoff();
                        tv2.Switchoff();
                        lp.Switchoff();
                        com.Switchoff();
                        break;
                    }
                    case 10:
                    {
                        tv1.OnScreen();
                        tv2.OnScreen();
                        lp.OnScreen();
                        com.OnScreen();
                        break;
                    }

                }
            }
        }
    }
}
