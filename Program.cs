namespace Caitlyn_chocolates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Caitlyn Chocolates: ");

            Program p = new Program();
            List<string> chocolatesDispensor = new List<string>();



        }

        void addChocolates(List<string> chocoDispensor,string color,int count)
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
                chocosRemoved[i] = chocoDispensor[chocoDispensor.Count - 1]
                chocoDispensor.Remove(chocoDispensor[chocoDispensor.Count -1]);
                
            }
            return chocosRemoved;
        }
        static string[] dispenseChocolates(List<string> chocoDispensor, int count)
        {
            string[] chocosDispensed = new string[count];
            for (int i = 0; i < count; i++)
            {
                chocoDispensor.Remove(chocosRemoved[i]);

            }
            return chocosDispensed;
        }




    }
}