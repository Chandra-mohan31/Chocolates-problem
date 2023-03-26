using System.Numerics;

namespace Caitlyn_chocolates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Caitlyn Chocolates: ");

            Program p = new Program();
            List<string> chocolatesDispensor = new List<string>();
            addChocolates(chocolatesDispensor, "grey", 3);
            addChocolates(chocolatesDispensor, "green", 7);
            addChocolates(chocolatesDispensor, "white", 2);
            addChocolates(chocolatesDispensor, "black", 3);
            addChocolates(chocolatesDispensor, "blue", 1); 

            


            foreach (var item in chocolatesDispensor)
            {
                Console.Write(item + " | ");
            }
            Console.WriteLine();

            //string[] changedResult = changeChocoColorAllOfxCount(chocolatesDispensor, "green", "red");
            //foreach (var item in changedResult)
            //{

            //    Console.Write(item + " , ");
            //}
            //removeChocolates(chocolatesDispensor, 5);
            //dispenseChocolatesofFavColor(chocolatesDispensor, 3, "green");
            //Console.WriteLine();
            //foreach (var item in chocolatesDispensor)
            //{
            //    Console.Write(item + "|");
            //}
            //Dictionary<string, int>  led = LED(chocolatesDispensor);
            //foreach (var item in led)
            //{ 
            //Console.Write($"{item.Key} : {item.Value}\n"); 
            //}
            //Console.WriteLine("\n");
            //sortChocolateBasedOnCount(led);
            //Console.WriteLine(chocolatesDispensor.Count());

            //removeChocolateOfColor("green", chocolatesDispensor);
            //Console.WriteLine(chocolatesDispensor.Count());

        }

        static void addChocolates(List<string> chocoDispensor,string color,int count)
        {
            for(int i = 0;i<count;i++)
            {
                chocoDispensor.Add(color);
            }
        }
        static string[] removeChocolates(List<string> chocoDispensor,int count)
        {
            string[] chocosRemoved = new string[count];
            for(int i = 0; i < count; i++)
            {
                chocosRemoved[i] = chocoDispensor[chocoDispensor.Count - 1];
                chocoDispensor.Remove(chocoDispensor[chocoDispensor.Count -1]);
                
            }
            return chocosRemoved;
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