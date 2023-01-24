using Movie_Database;

bool runProgram = true;
string category = "";

while (runProgram)
{
    List<Movie> movie = new List<Movie>()
{
    //categories: animated, drama, horror, scifi
    new Movie("Stargate","scifi"),
    new Movie("Castle in the Sky", "animated"),
    new Movie("The Red Shoes", "horror"),
    new Movie("Titanic", "drama"),
    new Movie("Edge of Tomorrow", "scifi"),
    new Movie("Princess Mononoke", "animated"),
    new Movie("The Thing", "horror"),
    new Movie("Logan", "drama"),
    new Movie("Nausicaa of the Valley of the Wind", "animated"),
    new Movie("To KIll a Mockingbird", "drama"),
    new Movie("Tron: Legacy", "scifi"),
    new Movie("28 Days Later", "Horror")
};
    //----------------------------------------------------------------------------------------------------------------------------------------------------

    Console.WriteLine("Welcome to the Movie List Application!");
    Console.WriteLine($"There are {movie.Count} movies in this list. What category are you interested in? ");
    while (true)
    {
        
            Console.WriteLine("We have scifi, animated, horror, and drama ");
            category = Console.ReadLine().ToLower().Trim();
        Console.WriteLine("------------");
        if (category == "scifi"||category=="animated"||category=="horror"||category=="drama")
        {
            foreach (Movie m in movie.Where(s => s.Category.ToLower() == category))
            {
                Console.WriteLine(m.GetDetails());
            }
            break;
        }
        else
        {
            Console.WriteLine("Please enter a valid category.");
        }
    }
    Console.WriteLine("------------");
        runProgram = Movie.GetContinue("\nContinue?");

}

