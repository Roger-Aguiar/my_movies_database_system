USE my_movies2;

SHOW TABLES;

SELECT * FROM movies;

SELECT LOWER(title) 
FROM movies
WHERE title = "Vanguard";

SELECT LOWER(actorName) 
FROM actors
WHERE actorName = "Scott Adkins";

SELECT * FROM actors;

DELETE FROM movies WHERE idMovie = 19;

SELECT * FROM genres
WHERE genre = 'Action'; 

SELECT * FROM actors_has_movies;

DELETE FROM actors_has_movies
WHERE idMovie = 19;

SELECT * FROM genres;