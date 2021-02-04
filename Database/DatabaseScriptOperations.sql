-- Name:         Roger Silva Santos Aguiar
-- Function:     Scripts for the operations in the database
-- Initial date: February 3, 2021
-- Last update:  February 3, 2021

USE my_movies;
SHOW TABLES;

-- Actors table

INSERT INTO actors (actorName, credits, linkIMDB, registerDate, lastUpdate)
VALUES ("Scott Adkins", 64, "https://www.imdb.com/name/nm0012078/", now(), now());

INSERT INTO actors (actorName, credits, linkIMDB, registerDate, lastUpdate)
VALUES ("Jet Li", 50, "https://www.imdb.com/name/nm0001472/?ref_=fn_al_nm_1", now(), now());

INSERT INTO actors (actorName, credits, linkIMDB, registerDate, lastUpdate)
VALUES ("Jacki Chan", 141, "https://www.imdb.com/name/nm0000329/?ref_=fn_al_nm_1", now(), now());

SELECT * FROM actors;
