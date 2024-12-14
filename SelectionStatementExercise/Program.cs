namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
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
            
            //Exercise 2
            //subject selection
            Console.WriteLine("What is your favorite subject?");
            string favSubject = Console.ReadLine();

            switch (favSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is very strict, but fun to learn and solve problems with!");
                    break;
                case "english":
                    Console.WriteLine("English is all about reading and language. Very good for effective writing and" +
                                      " communicating.");
                    break;
                case "history":
                    Console.WriteLine("It's important to learn history to understand the foundation of society, " +
                                      "civilization, socialization, and everything in between");
                    break;
                case "science":
                    Console.WriteLine("Science is fun, and applicable in the engineering world");
                     break;
                case "music":
                    Console.WriteLine("Music is in our everyday lives, and understanding the science behind music is" +
                                      "very interesting. ");
                    break;
                default:
                    Console.WriteLine("Interesting choice! What do you like about it?");
                    string extra = Console.ReadLine();
                    Console.WriteLine("Amazing!");
                    break;
            }
                
            
            
            
        }
    }
}
