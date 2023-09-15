namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string foodName = "Taco";
            int foodAge = 4;
            char firstLetter = 'T';
            bool isTasty = true;
            double foodWeight = 1.2;
            decimal foodPrice = 2.75m;
            Console.WriteLine($"Hi. I am eating a {foodName} and it is {foodAge} months old.");
            Console.WriteLine($"My {foodName}'s first letter starts with a {firstLetter}.");
            Console.WriteLine($"It is {isTasty} how scrumptious this {foodName} tastes right now.");
            Console.WriteLine($"The {foodName} weighs {foodWeight} pounds and only costed me {foodPrice} {foodAge} months ago.");

            Console.WriteLine(":D");
        }
    }
}
