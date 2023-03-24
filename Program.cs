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
            foreach (var item in chocolatesDispensor)
            {
                Console.Write(item + "|");
            }
            //removeChocolates(chocolatesDispensor, 5);
            dispenseChocolatesofFavColor(chocolatesDispensor, 3, "green");
            Console.WriteLine();
            foreach (var item in chocolatesDispensor)
            {
                Console.Write(item + "|");
            }
            LED(chocolatesDispensor);


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

        static void LED(List<string> chocoDispensor)
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
            foreach (var item in led)
            {
                Console.Write($"{item.Key} : {item.Value}\n"); 
            }

        }




    }
}