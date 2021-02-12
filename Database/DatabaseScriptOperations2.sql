USE my_movies2;

SHOW TABLES;

SELECT * FROM movies;

SELECT movies.title, movies.linkIMDB, actors.actorName
FROM movies, actors, actors_has_movies
WHERE movies.idMovie = actors_has_movies.idMovie AND 
	  actors.idActor = actors_has_movies.idActor AND
      actors.actorName = "Scott Adkins";

SELECT LOWER(title) 
FROM movies
WHERE title = "Vanguard";

SELECT LOWER(actorName) 
FROM actors
WHERE actorName = "Scott Adkins";

SELECT * FROM actors;

SELECT actorName, credits, linkIMDB, registerDate
FROM actors
WHERE actorName = "Scott Adkins";

DELETE FROM movies WHERE idMovie = 19;

SELECT * FROM genres
WHERE genre = 'Action'; 

SELECT * FROM actors_has_movies;

DELETE FROM actors_has_movies
WHERE idMovie = 19;

SELECT * FROM genres;

-- **************************************************************************************************
-- Views

-- Actors view
-- This view displays all the actors in the database
CREATE VIEW Actors_in_table
AS SELECT actorName AS Actor, credits AS Credits, linkIMDB AS Link_IMDB, registerDate AS Registered
FROM actors;

select * from Actors_in_table;

-- This view displays all the movies and the actors of each movie
CREATE VIEW movies_by_actor
AS SELECT movies.title, movies.linkIMDB, actors.actorName
FROM movies, actors, actors_has_movies
WHERE movies.idMovie = actors_has_movies.idMovie AND 
	  actors.idActor = actors_has_movies.idActor;

SELECT * FROM movies_by_actor;

SELECT title, linkIMDB FROM movies_by_actor
WHERE actorName = "Jackie Chan";

-- This view displays the movies by selected genre
CREATE VIEW movies_by_genre
AS SELECT movies.idMovie AS Id, movies.title AS Title, 
          movies.originalTitle AS Original_title, movies.linkIMDB AS Link, 
          movies.idGenre AS Id_genre 
FROM movies, genres
WHERE movies.idGenre = genres.idGenre;

DROP VIEW movies_by_genre;

SELECT Title, Original_title, Link FROM movies_by_genre
WHERE Id_genre = 1;

-- This view displays the movies by selected genre and actor
CREATE VIEW movies_by_genre_and_actor
AS SELECT movies.idMovie AS Id, movies.title AS Title, 
          movies.originalTitle AS Original_title, movies.linkIMDB AS Link, 
          movies.idGenre AS Id_genre, actors.actorName AS Actor 
FROM movies, genres, actors, actors_has_movies
WHERE movies.idGenre = genres.idGenre AND movies.idMovie = actors_has_movies.idMovie
      AND actors.idActor = actors_has_movies.idActor;
      
SELECT * FROM movies_by_genre_and_actor;

DROP VIEW movies_by_genre_and_actor;

SELECT Title, Original_title, Link FROM movies_by_genre_and_actor
WHERE Id_genre = 12 AND Actor = 'Jackie Chan';

SELECT * FROM movies
WHERE idGenre = 12;

CREATE VIEW actors_by_movie
AS SELECT actors.actorName AS Actor, actors.linkIMDB AS Link, movies.title AS Title
FROM movies, actors, actors_has_movies
WHERE movies.idMovie = actors_has_movies.idMovie AND actors.idActor = actors_has_movies.idActor;

DROP VIEW actors_by_movie;

SELECT Actor, Link 
FROM actors_by_movie
WHERE Title = 'Undisputed 3: Redemption';