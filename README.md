# MovieUseCase
This repository showcase a Movie Use case !<br>
In this we have classes->
<br>
1->Movie <br>
2->MovieCollection<br>
3->MovieManager<br>

<br>
1->Movie class has entitites:-id , title , actor , director , year <br>
It has method-><br>
1. GetInfo-Returns all the info of movie.<br>
2. Parametrized constructor<br>

<br>
2->MovieCollection-It has entities language<br>
We have declare our moviedb here which is nested Dictionary Type which has language has key and in it we have id and object !<br>
We have also declare an event here OnMovieAction here<br>
We made movie_db static not because static is good, but because we wanted one shared database across objects.<br>
We will store movies based on language in a dictionary and also the movie object<br>
Methods are-<br>
1.AddMovie-Here we will check if language as key or not.If exist we will perform the addition bases on id otherwise we will create it<br>
2.RemoveMovie-Here we will remove our movie bases on the key<br>
3.CountMovie-Here we will check the count of movies<br>
4.GetAllMovie-In this function we will retreive our movies bases on our key and it's entries!<br>
<br>
3->MovieManager-This is the class that calls our Main method<br>
We will get a MovieAck function<br>
We will create our objects<br>
Movie object will be created and will be pass to MovieCollection<br>
MovieCollection, when OnMovieAction happens, also call MovieAck=>moc.OnMovieAction += MovieAck;<br>
The += operator subscribes a method to an event. It registers MovieAck as a callback so that it is automatically invoked when the event is raised.”<br>
+= on an event means “listen when this event occurs<br>
<img width="1920" height="1200" alt="Screenshot 2025-12-15 213923" src="https://github.com/user-attachments/assets/ff427093-550f-4872-9850-4f49336b2567" />

