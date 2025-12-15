# MovieUseCase
This repository showcase a Movie Use case !
In this we have classes->
1->Movie <br>
2->MovieCollection<br>
3->MovieManager<br>

1->Movie class has entitites:-id,title,actor,director,year
It has method->
1. GetInfo-Returns all the info of movie.
2. Parametrized constructor

2->MovieCollection-It has entities language
We have declare our moviedb here which is nested Dictionary Type which has language has key and in it we have id and object !
We have also declare an event here OnMovieAction here
We made movie_db static not because static is good, but because you wanted one shared database across objects.
We will store movies based on language in a dictionary and also the movie object
Methods are-
1.AddMovie-Here we will check if language as key or not.If exist we will perform the addition bases on id otherwise we will create it
2.RemoveMovie-Here we will remove our movie bases on the key
3.CountMovie-Here we will check the count of movies
4.GetAllMovie-In this function we will retreive our movies bases on our key and it's entries!

3->MovieManager-This is the class that calls our Main method
We will get a MovieAck function
We will create our objects
Movie object will be created and will be pass to MovieCollection
MovieCollection, when OnMovieAction happens, also call MovieAck=>moc.OnMovieAction += MovieAck;
The += operator subscribes a method to an event. It registers MovieAck as a callback so that it is automatically invoked when the event is raised.”
+= on an event means “listen when this event occurs
<img width="1920" height="1200" alt="Screenshot 2025-12-15 213923" src="https://github.com/user-attachments/assets/ff427093-550f-4872-9850-4f49336b2567" />

