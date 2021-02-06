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

UPDATE actors
SET registerDate = '2021-02-02'
WHERE idActor = 3;

SELECT * FROM actors ORDER BY actorName;

SELECT idActor AS Id, actorName AS Actor, credits AS Credits, linkIMDB AS Link, registerDate AS Registered, lastUpdate AS Updated 
FROM actors;

DESCRIBE actors;

-- Operation with the genres table
INSERT INTO genres (genre, registerDate)
VALUES ('Absurdist/surreal/whimsical', now());

INSERT INTO genres (genre, registerDate)
VALUES ('Action', now()),
        ('Adventure', now()),
        ('Comedy', now()),
        ('Crime', now()),
        ('Drama', now()),
        ('Fantasy', now()),
        ('Historical', now()),
        ('Horror', now()),
        ('Magical realism', now()),
        ('Mistery', now()),
        ('Martial arts', now()),
        ('Paranoid fiction', now()),
        ('Philosophical', now()),
        ('Political', now()),
        ('Romance', now()),
        ('Saga', now()),
        ('Satire', now()),
        ('Science fiction', now()),
        ('Social', now()),
        ('Speculative', now()),
        ('Thriller', now()),
        ('Urban', now()),
        ('Western', now());

SELECT * FROM genres ORDER BY genre;

SELECT * FROM movies;
