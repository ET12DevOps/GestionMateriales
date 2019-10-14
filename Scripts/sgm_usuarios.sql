CREATE DATABASE  IF NOT EXISTS `sgm_usuarios` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `sgm_usuarios`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: sgm_usuarios
-- ------------------------------------------------------
-- Server version	5.7.25-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__efmigrationshistory`
--

LOCK TABLES `__efmigrationshistory` WRITE;
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` VALUES ('20191012204607_AddIdentity','2.2.6-servicing-10079');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetroleclaims`
--

DROP TABLE IF EXISTS `aspnetroleclaims`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetroleclaims` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `RoleId` varchar(767) NOT NULL,
  `ClaimType` text,
  `ClaimValue` text,
  PRIMARY KEY (`Id`),
  KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`),
  CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetroleclaims`
--

LOCK TABLES `aspnetroleclaims` WRITE;
/*!40000 ALTER TABLE `aspnetroleclaims` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetroleclaims` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetroles`
--

DROP TABLE IF EXISTS `aspnetroles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetroles` (
  `Id` varchar(767) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(256) DEFAULT NULL,
  `ConcurrencyStamp` text,
  `Discriminator` text NOT NULL,
  `Area` text,
  `Habilitado` int(11) DEFAULT NULL,
  `CreatedBy` text,
  `CreationDate` datetime DEFAULT NULL,
  `CreationIp` text,
  `LastUpdatedBy` text,
  `LastUpdatedDate` datetime DEFAULT NULL,
  `LastUpdatedIp` text,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `RoleNameIndex` (`NormalizedName`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetroles`
--

LOCK TABLES `aspnetroles` WRITE;
/*!40000 ALTER TABLE `aspnetroles` DISABLE KEYS */;
INSERT INTO `aspnetroles` VALUES ('2bed541d-8bb5-4069-b2c9-21b8bcef2f36','Jefatura de Taller','JEFATURA DE TALLER','d3a36c18-1c60-4ba6-b176-07eef382af87','ApplicationRole','Taller',1,'jonathanvgms@gmail.com','2019-10-12 17:54:28','::1',NULL,'0001-01-01 00:00:00',NULL),('6ab76151-a997-42b8-9c7a-95ac746ca4cf','Oficina Técnica','OFICINA TÉCNICA','634f46b0-e047-47fc-b6bb-af43f849bef6','ApplicationRole','Taller',1,'jonathanvgms@gmail.com','2019-10-12 17:53:11','::1',NULL,'0001-01-01 00:00:00',NULL),('8279ba65-0b53-42be-a4a5-be7ba3654482','Invitado','INVITADO','3416048d-10cb-45bc-99e9-4f3682232201','ApplicationRole','Administrativa',1,'jonathanvgms@gmail.com','2019-10-12 17:55:23','::1',NULL,'0001-01-01 00:00:00',NULL),('9999c5da-5817-4b97-9161-bf6d3f1bae56','Depósito','DEPÓSITO','0d100853-2bd6-4bc4-9d95-67a58c45e288','ApplicationRole','Taller',1,'jonathanvgms@gmail.com','2019-10-12 17:52:50','::1',NULL,'0001-01-01 00:00:00',NULL),('c59f4397-9228-48f8-b412-1d860ce43d05','Administrador','ADMINISTRADOR','ade6d9ea-fec7-469a-9b3c-15ec64e6b49f','ApplicationRole','Computacion',1,'jonathanvgms@gmail.com','2019-10-12 17:52:50','::1',NULL,'0001-01-01 00:00:00',NULL),('f0820477-2846-42ce-b0c5-061038d6b69f','Directivo','DIRECTIVO','825324ed-d1c0-43a1-a233-922c6e85370a','ApplicationRole','Administrativa',1,'jonathanvgms@gmail.com','2019-10-12 17:54:51','::1',NULL,'0001-01-01 00:00:00',NULL);
/*!40000 ALTER TABLE `aspnetroles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserclaims`
--

DROP TABLE IF EXISTS `aspnetuserclaims`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetuserclaims` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UserId` varchar(767) NOT NULL,
  `ClaimType` text,
  `ClaimValue` text,
  PRIMARY KEY (`Id`),
  KEY `IX_AspNetUserClaims_UserId` (`UserId`),
  CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserclaims`
--

LOCK TABLES `aspnetuserclaims` WRITE;
/*!40000 ALTER TABLE `aspnetuserclaims` DISABLE KEYS */;
INSERT INTO `aspnetuserclaims` VALUES (15,'f6036efc-0000-449a-a834-6d650d9c7b24','Borrar Roles','Borrar Roles'),(16,'f6036efc-0000-449a-a834-6d650d9c7b24','Editar Roles','Editar Roles'),(17,'f6036efc-0000-449a-a834-6d650d9c7b24','Crear Roles','Crear Roles'),(18,'f6036efc-0000-449a-a834-6d650d9c7b24','Borrar Usuarios','Borrar Usuarios'),(19,'f6036efc-0000-449a-a834-6d650d9c7b24','Editar Usuarios','Editar Usuarios'),(20,'f6036efc-0000-449a-a834-6d650d9c7b24','Crear Usuarios','Crear Usuarios'),(21,'f6036efc-0000-449a-a834-6d650d9c7b24','Crear Personal','Crear Personal'),(22,'f6036efc-0000-449a-a834-6d650d9c7b24','Editar Personal','Editar Personal'),(23,'f6036efc-0000-449a-a834-6d650d9c7b24','Borrar Personal','Borrar Personal');
/*!40000 ALTER TABLE `aspnetuserclaims` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserlogins`
--

DROP TABLE IF EXISTS `aspnetuserlogins`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(767) NOT NULL,
  `ProviderKey` varchar(767) NOT NULL,
  `ProviderDisplayName` text,
  `UserId` varchar(767) NOT NULL,
  PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  KEY `IX_AspNetUserLogins_UserId` (`UserId`),
  CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserlogins`
--

LOCK TABLES `aspnetuserlogins` WRITE;
/*!40000 ALTER TABLE `aspnetuserlogins` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetuserlogins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserroles`
--

DROP TABLE IF EXISTS `aspnetuserroles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetuserroles` (
  `UserId` varchar(767) NOT NULL,
  `RoleId` varchar(767) NOT NULL,
  PRIMARY KEY (`UserId`,`RoleId`),
  KEY `IX_AspNetUserRoles_RoleId` (`RoleId`),
  CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserroles`
--

LOCK TABLES `aspnetuserroles` WRITE;
/*!40000 ALTER TABLE `aspnetuserroles` DISABLE KEYS */;
INSERT INTO `aspnetuserroles` VALUES ('45bae4ed-98d6-43ca-b903-2a0f334d88a7','6ab76151-a997-42b8-9c7a-95ac746ca4cf'),('b662adbd-c987-4eca-a932-443c1d83bd68','6ab76151-a997-42b8-9c7a-95ac746ca4cf'),('e7d6bead-3122-4730-af53-2cc35f60d413','6ab76151-a997-42b8-9c7a-95ac746ca4cf'),('f6036efc-0000-449a-a834-6d650d9c7b24','c59f4397-9228-48f8-b412-1d860ce43d05');
/*!40000 ALTER TABLE `aspnetuserroles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetusers`
--

DROP TABLE IF EXISTS `aspnetusers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetusers` (
  `Id` varchar(767) NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(256) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(256) DEFAULT NULL,
  `EmailConfirmed` int(11) NOT NULL,
  `PasswordHash` text,
  `SecurityStamp` text,
  `ConcurrencyStamp` text,
  `PhoneNumber` text,
  `PhoneNumberConfirmed` int(11) NOT NULL,
  `TwoFactorEnabled` int(11) NOT NULL,
  `LockoutEnd` timestamp NULL DEFAULT NULL,
  `LockoutEnabled` int(11) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL,
  `Discriminator` text NOT NULL,
  `NombreCompleto` text,
  `Habilitado` int(11) DEFAULT NULL,
  `CreatedBy` text,
  `CreationDate` datetime DEFAULT NULL,
  `CreationIp` text,
  `LastUpdatedBy` text,
  `LastUpdatedDate` datetime DEFAULT NULL,
  `LastUpdatedIp` text,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  KEY `EmailIndex` (`NormalizedEmail`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetusers`
--

LOCK TABLES `aspnetusers` WRITE;
/*!40000 ALTER TABLE `aspnetusers` DISABLE KEYS */;
INSERT INTO `aspnetusers` VALUES ('45bae4ed-98d6-43ca-b903-2a0f334d88a7','cynthia.espinola@gmail.com','CYNTHIA.ESPINOLA@GMAIL.COM','cynthia.espinola@gmail.com','CYNTHIA.ESPINOLA@GMAIL.COM',0,'AQAAAAEAACcQAAAAEJXxaR/JWJCZ+Ru6KFm4x6GluMIDr0ErGH36Kc+iyIRd/qzM94U0dNZLu81O/VemKg==','IJBBS24T7S2YP5TWSIHQ2LO5WDMJATP6','ad5d8c9f-e144-4034-9447-ca23fb785aa0',NULL,0,0,NULL,1,3,'ApplicationUser','Cynthia Espinola',1,'jonathanvgms@gmail.com','2019-10-12 22:31:28','::1','jonathanvgms@gmail.com','0001-01-01 00:00:00','::1'),('b662adbd-c987-4eca-a932-443c1d83bd68','francisco.scagliarini@gmail.com','FRANCISCO.SCAGLIARINI@GMAIL.COM','francisco.scagliarini@gmail.com','FRANCISCO.SCAGLIARINI@GMAIL.COM',0,'AQAAAAEAACcQAAAAEIb3T6PQLO9348thpdk+FxGOy9bfbl3Fwrw5xH8ZXMfbQACRsiJYv9ovVzSDrdGCwA==','AWW3X75M2AZPK6G6SB3YXM44SHUUIK7R','11aaeee4-e31d-41a0-8257-e1a59111bfac',NULL,0,0,NULL,1,0,'ApplicationUser','Francisco Scagliarini',1,'jonathanvgms@gmail.com','2019-10-13 23:31:42','::1','jonathanvgms@gmail.com','2019-10-13 23:35:39','::1'),('e7d6bead-3122-4730-af53-2cc35f60d413','agustin.silva@gmail.com','AGUSTIN.SILVA@GMAIL.COM','agustin.silva@gmail.com','AGUSTIN.SILVA@GMAIL.COM',0,'AQAAAAEAACcQAAAAEL9ne7qJhCJlGldYzgtj2Qqo/pun5wpfbWHk1tR8qhzaeN8gKR7vFmExnC4Jconj2w==','2Y656QFV42XDCLBGFJZNQOZWDJT3QMPL','3c8e93c6-be55-4533-a651-8ed638a3122c',NULL,0,0,NULL,1,0,'ApplicationUser','Agustin Silva',1,'jonathanvgms@gmail.com','2019-10-13 23:36:08','::1','jonathanvgms@gmail.com','0001-01-01 00:00:00','::1'),('f6036efc-0000-449a-a834-6d650d9c7b24','jonathanvgms@gmail.com','JONATHANVGMS@GMAIL.COM','jonathanvgms@gmail.com','JONATHANVGMS@GMAIL.COM',0,'AQAAAAEAACcQAAAAEGZ+PEpm3NLJUD6CVCRIDjoVgf4jL7Y+iGVph7jmtCWdO/Eemci94LfC9xfwKZUkMA==','5DKT66RJRHXLB73ILBY5FDSKJFU33ME7','9b52ff2e-0876-4375-814e-bafd84c1d236',NULL,0,0,NULL,1,0,'ApplicationUser','Jonathan Velazquez',1,'jonathanvgms@gmail.com','2019-10-12 17:48:24','::1','jonathanvgms@gmail.com','0001-01-01 00:00:00','::1');
/*!40000 ALTER TABLE `aspnetusers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetusertokens`
--

DROP TABLE IF EXISTS `aspnetusertokens`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetusertokens` (
  `UserId` varchar(767) NOT NULL,
  `LoginProvider` varchar(767) NOT NULL,
  `Name` varchar(767) NOT NULL,
  `Value` text,
  PRIMARY KEY (`UserId`,`LoginProvider`,`Name`),
  CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetusertokens`
--

LOCK TABLES `aspnetusertokens` WRITE;
/*!40000 ALTER TABLE `aspnetusertokens` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetusertokens` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-10-13 23:47:34
