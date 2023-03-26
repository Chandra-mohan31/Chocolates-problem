using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;

namespace Caitlyn_chocolates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> chocolatesDispensor = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter 0 to exit: ");
                Console.Write("\n 1 : Add Chocolates \n 2 : Remove chocolates \n 3 : Dispense Chcolates \n " +
                    "4 : get a chocolate of your favorite color \n" +
                    " 5 : Show availability of chocolates \n 6 : Show chocolates in order of count \n " +
                    "7 : change the wrappers of chocolates \n 8 : Change color of a particular colored chocolates " +
                    "\n 9 : Remove chocolate of a given color \n");

                

                int v = Convert.ToInt32(Console.ReadLine());

                if(v == 0)
                {
                    break;
                }


                switch (v)
                {
                    case 1:
                        
                        Console.WriteLine("Enter the color of the Chocolate you want to add: ");

                        string color = Console.ReadLine();

                        Console.WriteLine("Enter the count of Chocolates you want to add of the input color: ");

                        int count = Convert.ToInt32((Console.ReadLine()));

                        addChocolates(chocolatesDispensor, color, count);
                        
                        break;
                    case 2:
                        Console.WriteLine("Enter the count of Chocolates you want to remove from top: ");

                        int cnt = Convert.ToInt32((Console.ReadLine()));
                        removeChocolates(chocolatesDispensor, cnt);
                        break;
                    case 3:
                        Console.WriteLine("Enter the count of Chocolates you want: ");
                        int cnt1 = Convert.ToInt32((Console.ReadLine()));
                        string[] dispensedChocos = dispenseChocolates(chocolatesDispensor, cnt1);
                        Console.WriteLine(string.Join(",", dispensedChocos));
                        break;
                    case 4:
                        Console.WriteLine("Enter the count of Chocolates you want: ");
                        int cnt2 = Convert.ToInt32((Console.ReadLine()));
                        Console.WriteLine("Enter the color of chocolate you want: ");
                        string color1 = Console.ReadLine();
                        string[] dispensedChocosFav = dispenseChocolatesofFavColor(chocolatesDispensor, cnt2,color1);
                        Console.WriteLine(string.Join(",", dispensedChocosFav));
                        
                        break;
                    case 5:
                        Dictionary<string, int> led = LED(chocolatesDispensor);
                        foreach(var item in led)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 6:
                        sortChocolateBasedOnCount(LED(chocolatesDispensor));
                        break;
                        
                    case 7:
                        Console.WriteLine("Enter the no of chocolates to change color: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the color to be changed:");
                        string c = Console.ReadLine();
                        Console.WriteLine("Enter the color to be applied:");
                        string tc = Console.ReadLine();

                        changeChocoColor(chocolatesDispensor, n, c, tc);
                        break;
                    case 8:
                        Console.WriteLine("Enter the color to be changed:");
                        string clr = Console.ReadLine();
                        Console.WriteLine("Enter the color to be applied:");
                        string tclr = Console.ReadLine();
                        string[] tarr = changeChocoColorAllOfxCount(chocolatesDispensor, clr, tclr);
                        Console.WriteLine(string.Join(",", tarr));
                        break;
                    case 9:
                        Console.WriteLine("Enter the color to be removed:");
                        string clrR = Console.ReadLine();
                        removeChocolateOfColor(clrR, chocolatesDispensor);
                        break;
                    default:
                        Console.WriteLine("Enter a valid option: ");
                        break;
                }
            }

        }

        static void addChocolates(List<string> chocoDispensor,string color,int count)
        {
            for(int i = 0;i<count;i++)
            {
                chocoDispensor.Add(color);
            }
            
        }
        static void removeChocolates(List<string> chocoDispensor,int count)
        {
            //Console.WriteLine(chocoDispensor.Count);
            if(count < chocoDispensor.Count)
                for(int i = 0; i < count; i++)
                {
                    Console.WriteLine(chocoDispensor[i]);
                    chocoDispensor.Remove(chocoDispensor[i]);
                
                }
            
        }
        static string[] dispenseChocolates(List<string> chocoDispensor, int count)
        {
            string[] chocosDispensed = new string[count];
            for (int i = 0; i < count; i++)
            {
                chocosDispensed[i] = chocoDispensor[chocoDispensor.Count - 1];
                chocoDispensor.Remove(chocoDispensor[chocoDispensor.Count - 1]);

            }
            return chocosDispensed;
        }

        static string[] dispenseChocolatesofFavColor(List<string> chocoDispensor, int count,string favcolor)
        {
            string[] chocosDispensed = new string[count];
            int i = 0;
            for(int j = 0; j < chocoDispensor.Count; j++)
            {
                if(i >= count)
                {
                    break;
                }
                if (chocoDispensor[j] == favcolor)
                {
                    chocosDispensed[i++] = favcolor;
                    chocoDispensor.Remove(chocoDispensor[j]);
                }
            }

          
            return chocosDispensed;
        }

        static Dictionary<string, int> LED(List<string> chocoDispensor)
        {
            Console.WriteLine();
            Dictionary<string,int> led =
                      new Dictionary<string , int>();
            foreach (var item in chocoDispensor)
            {
                if (led.ContainsKey(item))
                {
                    led[item]++;
                }
                else
                {
                    led.Add(item, 1);
                }
            }

            return led;

        }

        static void sortChocolateBasedOnCount(Dictionary<string, int> led)
        {
            var mySortedList = led.OrderBy(x => x.Value).ToList();
            foreach (var item in mySortedList) {
                Console.WriteLine(item);
            }
        }

        static void changeChocoColor(List<string> chocoDispensor, int number,string color,string finalColor)
        {   
              for(int i = 0; i < chocoDispensor.Count; i++)
            {
                if(number <= 0)
                {
                    break;
                }
                if (chocoDispensor[i] == color)
                {
                    chocoDispensor[i] = finalColor;
                    number--;
                }
            }
            Console.WriteLine("After changing the colors to a given color: \n");
            foreach (var item in chocoDispensor)
            {
                Console.Write(item+" | ");   
            }
        }

        static string[] changeChocoColorAllOfxCount(List<string> chocoDispensor, string color, string finalColor)
        {
            int count = 0;
            string[] arr = new string[2];
            for (int i = 0; i < chocoDispensor.Count; i++)
            {
                if (chocoDispensor[i] == color || chocoDispensor[i] == finalColor)
                {
                    chocoDispensor[i] = finalColor;
                    count++;
                    
                }
            }
            arr[0] = count.ToString();
            arr[1] = finalColor;

            return arr;
        }
        static string removeChocolateOfColor(string color, List<string> chocoDispensor)
        {
            string res = "";
            foreach (var item in chocoDispensor)
            {
                if(item == color)
                {
                    res = item;
                    chocoDispensor.Remove(item);
                    break;
                }
            }
            if(res.Length != 0)
            {
                return res;
            }
            else
            {
                return $"chocolate of color {color} not found";
            }

        }

        static int dispenseRainbowChocolates(int number)
        {
            return 1;
        }



    }
}