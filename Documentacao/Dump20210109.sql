CREATE DATABASE  IF NOT EXISTS `projeto_mutant` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `projeto_mutant`;
-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: localhost    Database: projeto_mutant
-- ------------------------------------------------------
-- Server version	8.0.22

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `address`
--

DROP TABLE IF EXISTS `address`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `address` (
  `id_usuarios` int DEFAULT NULL,
  `street` varchar(45) DEFAULT NULL,
  `suite` varchar(45) DEFAULT NULL,
  `city` varchar(45) DEFAULT NULL,
  `zipcode` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `address`
--

LOCK TABLES `address` WRITE;
/*!40000 ALTER TABLE `address` DISABLE KEYS */;
INSERT INTO `address` VALUES (1,'Kulas Light','Apt. 556','Gwenborough','92998-3874'),(2,'Victor Plains','Suite 879','Wisokyburgh','90566-7771'),(3,'Douglas Extension','Suite 847','McKenziehaven','59590-4157'),(4,'Hoeger Mall','Apt. 692','South Elvis','53919-4257'),(5,'Skiles Walks','Suite 351','Roscoeview','33263'),(6,'Norberto Crossing','Apt. 950','South Christy','23505-1337'),(7,'Rex Trail','Suite 280','Howemouth','58804-1099'),(8,'Ellsworth Summit','Suite 729','Aliyaview','45169'),(9,'Dayna Park','Suite 449','Bartholomebury','76495-3109'),(10,'Kattie Turnpike','Suite 198','Lebsackbury','31428-2261');
/*!40000 ALTER TABLE `address` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `company`
--

DROP TABLE IF EXISTS `company`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `company` (
  `id_usuarios` int DEFAULT NULL,
  `name` varchar(45) DEFAULT NULL,
  `catchPhrase` varchar(45) DEFAULT NULL,
  `bs` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `company`
--

LOCK TABLES `company` WRITE;
/*!40000 ALTER TABLE `company` DISABLE KEYS */;
INSERT INTO `company` VALUES (1,'Leanne Graham','Multi-layered client-server neural-net','harness real-time e-markets'),(2,'Ervin Howell','Proactive didactic contingency','synergize scalable supply-chains'),(3,'Clementine Bauch','Face to face bifurcated interface','e-enable strategic applications'),(4,'Patricia Lebsack','Multi-tiered zero tolerance productivity','transition cutting-edge web services'),(5,'Chelsey Dietrich','User-centric fault-tolerant solution','revolutionize end-to-end systems'),(6,'Mrs. Dennis Schulist','Synchronised bottom-line interface','e-enable innovative applications'),(7,'Kurtis Weissnat','Configurable multimedia task-force','generate enterprise e-tailers'),(8,'Nicholas Runolfsdottir V','Implemented secondary concept','e-enable extensible e-tailers'),(9,'Glenna Reichert','Switchable contextually-based project','aggregate real-time technologies'),(10,'Clementina DuBuque','Centralized empowering task-force','target end-to-end models');
/*!40000 ALTER TABLE `company` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `geo`
--

DROP TABLE IF EXISTS `geo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `geo` (
  `id_usuarios` int DEFAULT NULL,
  `lat` varchar(45) DEFAULT NULL,
  `lng` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `geo`
--

LOCK TABLES `geo` WRITE;
/*!40000 ALTER TABLE `geo` DISABLE KEYS */;
INSERT INTO `geo` VALUES (1,'-37.3159','81.1496'),(2,'-43.9509','-34.4618'),(3,'-68.6102','-47.0653'),(4,'29.4572','-164.2990'),(5,'-31.8129','62.5342'),(6,'-71.4197','71.7478'),(7,'24.8918','21.8984'),(8,'-14.3990','-120.7677'),(9,'24.6463','-168.8889'),(10,'-38.2386','57.2232');
/*!40000 ALTER TABLE `geo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `log`
--

DROP TABLE IF EXISTS `log`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `log` (
  `id` int NOT NULL AUTO_INCREMENT,
  `descricao` varchar(200) DEFAULT NULL,
  `data` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `log`
--

LOCK TABLES `log` WRITE;
/*!40000 ALTER TABLE `log` DISABLE KEYS */;
INSERT INTO `log` VALUES (1,'Carregou a consulta em tabelas na web.','09/01/2021 14:28:14'),(2,'Carregou a lista JSON na web.','09/01/2021 14:28:33'),(3,'Carregou a consulta de logs em tabelas na web.','09/01/2021 14:28:41'),(4,'Dados de usuários salvos com sucesso!','09/01/2021 14:28:44'),(5,'Carregou a consulta de logs em tabelas na web.','09/01/2021 14:28:48');
/*!40000 ALTER TABLE `log` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `id` int DEFAULT NULL,
  `name` varchar(100) DEFAULT NULL,
  `username` varchar(45) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `phone` varchar(45) DEFAULT NULL,
  `website` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'Leanne Graham','Bret','Sincere@april.biz','1-770-736-8031 x56442','hildegard.org'),(2,'Ervin Howell','Antonette','Shanna@melissa.tv','010-692-6593 x09125','anastasia.net'),(3,'Clementine Bauch','Samantha','Nathan@yesenia.net','1-463-123-4447','ramiro.info'),(4,'Patricia Lebsack','Karianne','Julianne.OConner@kory.org','493-170-9623 x156','kale.biz'),(5,'Chelsey Dietrich','Kamren','Lucio_Hettinger@annie.ca','(254)954-1289','demarco.info'),(6,'Mrs. Dennis Schulist','Leopoldo_Corkery','Karley_Dach@jasper.info','1-477-935-8478 x6430','ola.org'),(7,'Kurtis Weissnat','Elwyn.Skiles','Telly.Hoeger@billy.biz','210.067.6132','elvis.io'),(8,'Nicholas Runolfsdottir V','Maxime_Nienow','Sherwood@rosamond.me','586.493.6943 x140','jacynthe.com'),(9,'Glenna Reichert','Delphine','Chaim_McDermott@dana.io','(775)976-6794 x41206','conrad.com'),(10,'Clementina DuBuque','Moriah.Stanton','Rey.Padberg@karina.biz','024-648-3804','ambrose.net');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'projeto_mutant'
--

--
-- Dumping routines for database 'projeto_mutant'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-01-09 14:31:15
