-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: philtech
-- ------------------------------------------------------
-- Server version	8.0.41

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
-- Table structure for table `account_admin`
--

DROP TABLE IF EXISTS `account_admin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `account_admin` (
  `NAME` varchar(45) NOT NULL,
  `PASSWORD` varchar(45) NOT NULL,
  PRIMARY KEY (`NAME`,`PASSWORD`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `account_admin`
--

LOCK TABLES `account_admin` WRITE;
/*!40000 ALTER TABLE `account_admin` DISABLE KEYS */;
INSERT INTO `account_admin` VALUES ('anapandak123','anacute'),('john','12345');
/*!40000 ALTER TABLE `account_admin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `account_student`
--

DROP TABLE IF EXISTS `account_student`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `account_student` (
  `FULL NAME` varchar(50) NOT NULL,
  `PASSWORD` varchar(45) NOT NULL,
  PRIMARY KEY (`FULL NAME`,`PASSWORD`),
  UNIQUE KEY `FULL NAME_UNIQUE` (`FULL NAME`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `account_student`
--

LOCK TABLES `account_student` WRITE;
/*!40000 ALTER TABLE `account_student` DISABLE KEYS */;
INSERT INTO `account_student` VALUES ('carl','1234'),('erick','erickpogi23'),('hany','hany'),('joshpogi','erickpisot'),('romelpugi','erickcute'),('Sandra','jjpogi23');
/*!40000 ALTER TABLE `account_student` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `students`
--

DROP TABLE IF EXISTS `students`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `students` (
  `REGISTRATION_NUMBER` varchar(45) NOT NULL,
  `TRACK` varchar(45) NOT NULL,
  `SECTION` varchar(45) NOT NULL,
  `STATUS` varchar(45) NOT NULL,
  `SESSION` varchar(45) NOT NULL,
  `NAME` varchar(45) NOT NULL,
  `LRN` varchar(45) NOT NULL,
  `SEMESTER` varchar(45) NOT NULL,
  `STRANDS` varchar(45) NOT NULL,
  PRIMARY KEY (`REGISTRATION_NUMBER`,`TRACK`,`SECTION`,`STATUS`,`NAME`,`LRN`,`SEMESTER`,`STRANDS`,`SESSION`),
  UNIQUE KEY `REGISTRATION_NUMBER_UNIQUE` (`REGISTRATION_NUMBER`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students`
--

LOCK TABLES `students` WRITE;
/*!40000 ALTER TABLE `students` DISABLE KEYS */;
INSERT INTO `students` VALUES ('SH-002','ACADEMIC TRACK','GRADE 11 - ABM1','G-10 COMPLETER PRIVATE','Morning','John Romel A. Lasanas','1234567890','1st Semester','ABM');
/*!40000 ALTER TABLE `students` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ticket`
--

DROP TABLE IF EXISTS `ticket`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ticket` (
  `NAME` varchar(45) NOT NULL,
  `REASON` varchar(50) NOT NULL,
  `METHOD` varchar(45) NOT NULL,
  `AMOUNT` varchar(50) NOT NULL,
  `DATE` varchar(45) NOT NULL,
  `TIME` varchar(45) NOT NULL,
  PRIMARY KEY (`NAME`,`REASON`,`METHOD`,`AMOUNT`,`DATE`,`TIME`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ticket`
--

LOCK TABLES `ticket` WRITE;
/*!40000 ALTER TABLE `ticket` DISABLE KEYS */;
INSERT INTO `ticket` VALUES ('carl joseph','ID PAYMENT','GCASH','100','30-03-2025','04:59'),('john','EDUCATIONAL TOUR - ICT','PAYMAYA','2,200','30-03-2025','07:42'),('romel','GALA NIGHT','CASH','1,500','30-03-2025','08:02'),('winston','EDUCATIONAL TOUR - ICT','PAYMAYA','2,200','30-03-2025','07:42');
/*!40000 ALTER TABLE `ticket` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-03-30 22:00:41
