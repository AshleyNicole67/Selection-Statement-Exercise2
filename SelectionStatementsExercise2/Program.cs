namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FavSubject();
        }
        
        public static void FavSubject()
        
        {
            Console.WriteLine("What is your favorite subject in school?");
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "science":
                    Console.WriteLine("I love science too");
                    break;
                case "music":
                    Console.WriteLine("Music is an awesome subject");
                    break;
                case "math":
                    Console.WriteLine("Math is great,but super difficult for me");
                    break;
                case "history":
                    Console.WriteLine("History is one of the best subjects");
                    break;
                default:
                    Console.WriteLine("I like that too");
                    break;
                
            }
            
        }
    }
}