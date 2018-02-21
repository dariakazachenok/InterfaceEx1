using System;
using System.Collections.Generic;

namespace InterfaceEx1
{
    class InterfaceEx1
    {
        static void Main()
        {
            List<TV> tv = new List<TV> {new TV(true)};
            var tv1 = tv[0];
           
            /* TV tv1 = new TV(true);
             TV tv2 = new TV(true); */

            List<Computer> com = new List<Computer> {new Computer(true)};
            var com1 = com[0];

            List<Lamp> lp = new List<Lamp> {new Lamp(true)};
            var lp1 = lp[0];

            Console.WriteLine("1- Turn on 1 TV" + "\r\n" + "2- Turn off 1 TV" + "\r\n" + "3- Turn on computer" + "\r\n" + "4-Turn off computer" + "\r\n" + "5- Turn on lamp" + "\r\n" + "6- Turn off lamp" + "\r\n" + "7- All off in flat" + "\r\n" + "\r\n" + "8-Devices on? Status" + "\r\n");
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
                        com1.Switchon();
                        break;
                    }
                    case 4:
                    {
                        com1.Switchoff();
                        break;
                    }
                    case 5:
                    {
                        lp1.Switchon();
                        break;
                    }
                    case 6:
                    {
                        lp1.Switchoff();
                        break;
                    }
                    case 7:
                    {
                       foreach (var t in tv)
                       t.Switchoff();

                      foreach (Computer c in com)
                       c.Switchoff();

                       foreach (Lamp l in lp)
                        l.Switchoff();
                       break;
                    }
                    case 8:
                    {
                        tv1.OnScreen();
                        lp1.OnScreen();
                        com1.OnScreen();
                       break;
                    }

                }
            }
        }
    }
}



                     
        
        
    

