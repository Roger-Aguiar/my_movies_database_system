USE my_movies2;

SHOW TABLES;

SELECT * FROM movies;

DELETE FROM movies WHERE idMovie = 14;

SELECT * FROM genres
WHERE genre = 'Action'; 

SELECT * FROM actors_has_movies;

DELETE FROM actors_has_movies
WHERE idActor = 7;