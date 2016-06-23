namespace Ex03AnimalsHierarchy
{
    /* 03. 
     * Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.
     * Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface).
     * Kittens and tomcats are cats. All animals are described by age, name and sex.
     * Kittens can be only female and tomcats can be only male. Each animal produces a specific sound. 
     * Create arrays of different kinds of animals and calculate the average age of each kind of animal 
     * using a static method (you may use LINQ).
     */

    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class AnimalsHierarchy
    {
        public static void Main()
        {
            try
            {
                // Test each of the animals and the sound each of them produce (Note Tommy and Kitty are both Cats so they both say meow :D)

                Dog sharo = new Dog("Sharo",3, Sex.Male);
                sharo.ProduceSound();

                Frog java = new Frog("Java", 8, Sex.Female);
                java.ProduceSound();

                Cat garfield = new Cat("Garfield", 7, Sex.Male);
                garfield.ProduceSound();

                Kitten kitty = new Kitten("Kitty", 18);
                kitty.ProduceSound();

                Tomcat tommy = new Tomcat("Tommy", 26);
                tommy.ProduceSound();

                // Create arrays of different kinds of animals  

                Dog[] dogs = { sharo, new Dog("Jack", 7, Sex.Male), new Dog("Gosho", 15, Sex.Male), new Dog("Betty", 9, Sex.Female) };
                Frog[] frogs = { java, new Frog("Pesho", 6, Sex.Male), new Frog("Mariika", 4, Sex.Female), new Frog("Mimi", 5, Sex.Female) };
                Cat[] cats = { garfield, new Cat("Johnny", 9, Sex.Male), new Cat("Peter", 7, Sex.Male), new Cat("Micheto", 16, Sex.Female) };
                Kitten[] kittens = { kitty, new Kitten("Stacey", 18), new Kitten("Joro", 20), new Kitten("Kelly", 17) };
                Tomcat[] tomcats = { tommy, new Tomcat("Jackie", 17), new Tomcat("Gosho", 16), new Tomcat("George", 22) };

                // Calculate the average age of each kind of animal and print it

                Console.WriteLine("Dogs average age: {0}.", CalculateAverageAge(dogs));
                Console.WriteLine("Frogs average age: {0}.", CalculateAverageAge(frogs));
                Console.WriteLine("Cats average age: {0}.", CalculateAverageAge(cats));
                Console.WriteLine("Kittens average age: {0}.", CalculateAverageAge(kittens));
                Console.WriteLine("Tomcats average age: {0}.", CalculateAverageAge(tomcats));

                // Let's have some fun and calculate the average age of all the above animals
              
                var animals = dogs.Concat<Animal>(frogs).Concat(cats).Concat(cats).Concat(kittens).Concat(tomcats);
                Console.WriteLine("The average age of all animals is {0}.", CalculateAverageAge(animals));
            }
            catch (ArgumentException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (InvalidOperationException exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

        private static double CalculateAverageAge(IEnumerable<Animal> animals)
        {
            if (animals.Count() == 0)
            {
                throw new InvalidOperationException("Sequence contains no elements.");
            }

            return animals.Average(a => a.Age);
        }
    }
}