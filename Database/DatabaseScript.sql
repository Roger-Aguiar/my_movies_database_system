-- MySQL Script generated by MySQL Workbench
-- Wed Feb  3 06:21:40 2021
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

-- Name: Roger Silva Santos Aguiar
-- Last update: Wed Feb 3

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema my_movies
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema my_movies
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `my_movies` DEFAULT CHARACTER SET utf8 ;
USE `my_movies` ;

-- -----------------------------------------------------
-- Table `my_movies`.`Actors`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `my_movies`.`Actors` (
  `idActor` INT NOT NULL AUTO_INCREMENT,
  `actorName` VARCHAR(100) NOT NULL,
  `credits` INT NULL,
  `linkIMDB` VARCHAR(150) NULL,
  `registerDate` DATE NULL,
  `lastUpdate` DATE NULL,
  PRIMARY KEY (`idActor`))
ENGINE = InnoDB
COMMENT = '				';


-- -----------------------------------------------------
-- Table `my_movies`.`Movies`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `my_movies`.`Movies` (
  `idMovie` INT NOT NULL AUTO_INCREMENT,
  `title` VARCHAR(100) NOT NULL,
  `originalTitle` VARCHAR(100) NULL,
  `year` VARCHAR(4) NULL,
  `registerDate` DATE NULL,
  `lastUpdate` DATE NULL,
  PRIMARY KEY (`idMovie`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `my_movies`.`Genres`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `my_movies`.`Genres` (
  `idGenre` INT NOT NULL AUTO_INCREMENT,
  `genre` VARCHAR(45) NULL,
  `registerDate` DATE NULL,
  PRIMARY KEY (`idGenre`))
ENGINE = InnoDB
COMMENT = '	';


-- -----------------------------------------------------
-- Table `my_movies`.`Actors_has_Movies`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `my_movies`.`Actors_has_Movies` (
  `idActor` INT NOT NULL,
  `idMovie` INT NOT NULL,
  PRIMARY KEY (`idActor`, `idMovie`),
  INDEX `fk_Actors_has_Movies_Movies1_idx` (`idMovie` ASC) VISIBLE,
  INDEX `fk_Actors_has_Movies_Actors_idx` (`idActor` ASC) VISIBLE,
  CONSTRAINT `fk_Actors_has_Movies_Actors`
    FOREIGN KEY (`idActor`)
    REFERENCES `my_movies`.`Actors` (`idActor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Actors_has_Movies_Movies1`
    FOREIGN KEY (`idMovie`)
    REFERENCES `my_movies`.`Movies` (`idMovie`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `my_movies`.`Genres_has_Movies`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `my_movies`.`Genres_has_Movies` (
  `idGenre` INT NOT NULL,
  `idMovie` INT NOT NULL,
  PRIMARY KEY (`idGenre`, `idMovie`),
  INDEX `fk_Genres_has_Movies_Movies1_idx` (`idMovie` ASC) VISIBLE,
  INDEX `fk_Genres_has_Movies_Genres1_idx` (`idGenre` ASC) VISIBLE,
  CONSTRAINT `fk_Genres_has_Movies_Genres1`
    FOREIGN KEY (`idGenre`)
    REFERENCES `my_movies`.`Genres` (`idGenre`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Genres_has_Movies_Movies1`
    FOREIGN KEY (`idMovie`)
    REFERENCES `my_movies`.`Movies` (`idMovie`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;