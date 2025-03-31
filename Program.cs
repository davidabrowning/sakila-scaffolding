using SakilaScaffolding.Data;
using SakilaScaffolding.Model;

namespace SakilaScaffolding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var dbContext = new SakilaContext();

            List<Actor> actors = dbContext.Actors.ToList();
            foreach (Actor actor in actors)
            {
                Console.WriteLine(actor.FirstName + " " + actor.LastName);
            }
        }
    }
}
