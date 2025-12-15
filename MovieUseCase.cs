using System;
using System.Collections.Generic;


public delegate void MovieNotification(string message);

class Movie
{
 public string id;
public string title;
string actor;
string director;
string year;
public Movie(string Title,string Actor,string Director,string Year)
{
this.id= Guid.NewGuid().ToString();
this.title=Title;
this.actor=Actor;
this.director=Director;
this.year=Year;
}
public void GetInfo()
{
Console.WriteLine($"Your movie is {title}.It has actors such as {actor} , directed by {director} and was made in year {year}.");
}
};

class MovieCollection
{
//It's collection of movies based on language
string language;
Movie ob;
static int movieCount=0;
//it will notify if something happens
public event MovieNotification OnMovieAction;

//We made movie_db static not because static is good, but because you wanted one shared database across objects.
static Dictionary<string, Dictionary<string, Movie>> movie_db 
    = new Dictionary<string, Dictionary<string,Movie >>();

//We will store movies based on language in a dictionary and also the movie object
//Also we have to perform basic CRUD Operations on this!!

public MovieCollection(string Language,Movie obj)
{
this.language=Language;
this.ob=obj;
}

public void AddMovie()
{
if(!movie_db.ContainsKey(language))
{
movie_db[language]=new Dictionary<string,Movie>();
}
if(!movie_db[language].ContainsKey(ob.id))
{
        movie_db[language].Add(ob.id, ob);
        movieCount++;
 OnMovieAction?.Invoke(
            $"Movie '{ob.title}' added successfully in {language}"
        );
}
else
{
  OnMovieAction?.Invoke(
            $"Movie '{ob.title}' already exists in {language}"
        );
}

//acknowledge message bhejenge manager ko ki bhai add hogyi movie!

}

public void RemoveMovie()
{
if (movie_db.ContainsKey(language) &&
        movie_db[language].ContainsKey(ob.id))
    {
        movie_db[language].Remove(ob.id);
        movieCount--;

        OnMovieAction?.Invoke(
            $"Movie '{ob.title}' removed from {language}"
        );
    }


}

public int MovieCnt()
{
Console.WriteLine(movieCount);
return movieCount;
}
public void GetAllMovies()
{
    if (movie_db.Count == 0)
    {
        Console.WriteLine("No movies available.");
        return;
    }

    foreach (var languageEntry in movie_db)
    {
        Console.WriteLine($"Language: {languageEntry.Key}");

        if (languageEntry.Value.Count == 0)
        {
            Console.WriteLine("  No movies for this language.");
            continue;
        }

        foreach (var movieEntry in languageEntry.Value)
        {
            Movie movie = movieEntry.Value;
            movie.GetInfo();
        }

        Console.WriteLine(); // spacing
    }
}

}

class MovieManager
{
//this function matches the signature of delegate
 static void MovieAck(string message)
    {
        Console.WriteLine($"[ACK RECEIVED]: {message}");
    } 
public static void Main()
{
Movie m1=new Movie("Guzarish","Amir Khan","Anand Rai","2007");
m1.GetInfo();
Movie m2=new Movie("KGF","Yash","Mahesh Babu","2025");
m2.GetInfo();
MovieCollection moc=new MovieCollection("Hindi",m1);
MovieCollection moc2=new MovieCollection("Telugu",m2);
 moc.OnMovieAction += MovieAck;
 moc2.OnMovieAction += MovieAck;
moc.AddMovie();
moc2.AddMovie();
moc.GetAllMovies();
moc.MovieCnt();
moc.RemoveMovie();
}
};


/*“Delegates define a callback contract and events allow publishers to notify subscribers without tight coupling. They were necessary here to send acknowledgements from MovieCollection to MovieManager while keeping both classes independent and extensible.”*/

