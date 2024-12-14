namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //number selection
            Random r = new Random();
            int favNum = r.Next(0, 100);
            int guess = 0;
            
            
            while (favNum != guess)
            {
                //userinput for number
                Console.WriteLine("Guess the Number: ");
                guess = Convert.ToInt32(Console.ReadLine());
                
                if (guess > favNum)
                {
                    Console.WriteLine("Too High!");
                }
                else if (guess < favNum)
                {
                    Console.WriteLine("Too Low!");
                }
                else
                {
                    Console.WriteLine("You are correct! Good job.");
                }
                
                
            }
        }
    }
}
