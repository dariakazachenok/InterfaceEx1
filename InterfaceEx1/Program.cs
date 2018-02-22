using System;
using System.Collections.Generic;

namespace InterfaceEx1
{
    class InterfaceEx1
    {
        static void Main()
        {
            var tv1 = new TV(true);
            Computer com1 = new Computer(true);
            Lamp lp1 = new Lamp(true);

            List<ISwitchable> devices = new List<ISwitchable> {tv1, com1, lp1};
            tv1 = (TV) devices[0];
            com1 = (Computer)devices[1];
            lp1 = (Lamp)devices[2];
            
            Console.WriteLine("1- Turn on 1 TV" + "\r\n" + "2- Turn off 1 TV" + "\r\n" + "3- Turn on computer" + "\r\n" + "4-Turn off computer" + "\r\n" + "5- Turn on lamp" + "\r\n" + "6- Turn off lamp" + "\r\n" + "7- All off in flat" + "\r\n" + "\r\n" + "8-Devices on? Status" + "\r\n");
            while (true)
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        tv1.Switchon();
                        break;
                    case 2:
                        tv1.Switchoff();
                        break;
                    case 3:
                        com1.Switchon();
                        break;
                    case 4:
                        com1.Switchoff();
                        break;
                    case 5:
                        lp1.Switchon();
                        break;
                    case 6:
                        lp1.Switchoff();
                        break;
                    case 7:
                        foreach (var d in devices)
                        {
                            d.Switchoff();
                        }
                        break;
                    case 8:
                        tv1.OnScreen();
                        lp1.OnScreen();
                        com1.OnScreen();
                        break;
                }
            }
        }
    }
}



                     
        
        
    

