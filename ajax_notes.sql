-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema ajax_notes
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema ajax_notes
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `ajax_notes` DEFAULT CHARACTER SET utf8 ;
USE `ajax_notes` ;

-- -----------------------------------------------------
-- Table `ajax_notes`.`notes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ajax_notes`.`notes` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `description` VARCHAR(255) NULL,
  `title` VARCHAR(255) NULL,
  `created_at` DATETIME NULL,
  `updated_at` DATETIME NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
