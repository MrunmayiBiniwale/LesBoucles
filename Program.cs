namespace LesBoucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] moves = new string[32];
            int i = 0; string str = "";
            Console.WriteLine("Please write your dance steps 1 in each line");
            while (i < moves.Length)
            {
                str = Console.ReadLine();
                if (str.ToLower().Trim() == "done")
                    break;
                moves[i] = str;
                i++;
            }

            Console.WriteLine("Please enter the number of repetetions :");
            int repeat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            for (int j = 0; j < repeat; j++)
            {
                foreach (string m in moves)
                { 
                    if(!string.IsNullOrEmpty(m))
                        Console.WriteLine(m);  
                }
                Console.WriteLine();
            }
           
        }
    }
}
