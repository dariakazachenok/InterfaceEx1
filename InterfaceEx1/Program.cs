using System;

namespace InterfaceEx1
{
    class InterfaceEx1
    {
        static void Main()
        {
            TV tv1 = new TV(true);
            TV tv2 = new TV(true);
            TV tv3 = new TV(true);
            
            Computer com1 = new Computer(true);
            Computer com2 = new Computer(true);
            Computer com3 = new Computer(true);

            Lamp lp1 = new Lamp(true);
            Lamp lp2 = new Lamp(true);
            Lamp lp3 = new Lamp(true);
            Lamp lp4 = new Lamp(true);
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
                        com1.Switchon();
                        break;
                    }
                    case 6:
                    {
                        com1.Switchoff();
                        break;
                    }
                    case 7:
                    {
                        lp1.Switchon();
                        break;
                    }
                    case 8:
                    {
                        lp1.Switchoff();
                        break;
                    }
                    case 9:
                    {
                        tv1.Switchoff();
                        tv2.Switchoff();
                        tv3.Switchoff();
                        lp1.Switchoff();
                        lp2.Switchoff();
                        lp3.Switchoff();
                        lp4.Switchoff();
                        com1.Switchoff();
                        com2.Switchoff();
                        com3.Switchoff();
                        break;
                    }
                    case 10:
                    {
                        tv1.OnScreen();
                        tv2.OnScreen();
                        tv3.OnScreen();
                        lp1.OnScreen();
                        lp2.OnScreen();
                        lp3.OnScreen();
                        lp4.OnScreen();
                        com1.OnScreen();
                        com2.OnScreen();
                        com3.OnScreen();
                        break;
                    }

                }
            }
        }
    }
}
