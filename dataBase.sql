-- MySQL dump 10.13  Distrib 8.0.34, for macos13 (arm64)
--
-- Host: sql5.freesqldatabase.com    Database: sql5679201
-- ------------------------------------------------------
-- Server version	5.5.62-0ubuntu0.14.04.1

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
-- Table structure for table `Allergies`
--

DROP TABLE IF EXISTS `Allergies`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Allergies` (
  `Pati_Ssn` char(9) NOT NULL,
  `Allergy_Name` varchar(20) NOT NULL,
  KEY `Pati_Ssn_idx` (`Pati_Ssn`),
  CONSTRAINT `Pati_Ssn` FOREIGN KEY (`Pati_Ssn`) REFERENCES `Patient` (`Ssn`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Allergies`
--

LOCK TABLES `Allergies` WRITE;
/*!40000 ALTER TABLE `Allergies` DISABLE KEYS */;
/*!40000 ALTER TABLE `Allergies` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Appointment`
--

DROP TABLE IF EXISTS `Appointment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Appointment` (
  `Appointment_ID` char(7) NOT NULL,
  `Financial_Report_ID` char(7) NOT NULL,
  `Status` char(1) NOT NULL,
  `Notes` varchar(1000) DEFAULT NULL,
  `Date_Time` datetime NOT NULL,
  PRIMARY KEY (`Appointment_ID`),
  KEY `Financial_Report_ID_idx` (`Financial_Report_ID`),
  CONSTRAINT `Financial_Report_ID` FOREIGN KEY (`Financial_Report_ID`) REFERENCES `Financial_Report` (`Financial_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Appointment`
--

LOCK TABLES `Appointment` WRITE;
/*!40000 ALTER TABLE `Appointment` DISABLE KEYS */;
/*!40000 ALTER TABLE `Appointment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Financial_Report`
--

DROP TABLE IF EXISTS `Financial_Report`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Financial_Report` (
  `Financial_ID` char(7) NOT NULL,
  `Pat_Ssn` char(9) NOT NULL,
  `Date_Of_Service` datetime NOT NULL,
  `Insurance` varchar(20) DEFAULT NULL,
  `Processing_Date` datetime DEFAULT NULL,
  `Due_Date` datetime NOT NULL,
  `Services_Rendered` varchar(1000) NOT NULL,
  `Reporting_Period` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Financial_ID`),
  KEY `Patient_Ssn_idx` (`Pat_Ssn`),
  CONSTRAINT `Pat_Ssn` FOREIGN KEY (`Pat_Ssn`) REFERENCES `Patient` (`Ssn`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Financial_Report`
--

LOCK TABLES `Financial_Report` WRITE;
/*!40000 ALTER TABLE `Financial_Report` DISABLE KEYS */;
/*!40000 ALTER TABLE `Financial_Report` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Ingredients`
--

DROP TABLE IF EXISTS `Ingredients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Ingredients` (
  `Med_ID` char(7) NOT NULL,
  `Ingredient_Name` varchar(20) NOT NULL,
  KEY `Med_ID_idx` (`Med_ID`),
  CONSTRAINT `Med_ID` FOREIGN KEY (`Med_ID`) REFERENCES `Medication` (`Medication_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Ingredients`
--

LOCK TABLES `Ingredients` WRITE;
/*!40000 ALTER TABLE `Ingredients` DISABLE KEYS */;
/*!40000 ALTER TABLE `Ingredients` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Insurance`
--

DROP TABLE IF EXISTS `Insurance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Insurance` (
  `P_Ssn` char(9) NOT NULL,
  `Insurance_Name` varchar(20) NOT NULL,
  `Policy_number` varchar(20) NOT NULL,
  KEY `P_Ssn_idx` (`P_Ssn`),
  CONSTRAINT `P_Ssn` FOREIGN KEY (`P_Ssn`) REFERENCES `Patient` (`Ssn`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Insurance`
--

LOCK TABLES `Insurance` WRITE;
/*!40000 ALTER TABLE `Insurance` DISABLE KEYS */;
/*!40000 ALTER TABLE `Insurance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Medication`
--

DROP TABLE IF EXISTS `Medication`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Medication` (
  `Medication_ID` char(7) NOT NULL,
  `Side_Effects` varchar(1000) NOT NULL,
  `Name` varchar(45) NOT NULL,
  `Price` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`Medication_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Medication`
--

LOCK TABLES `Medication` WRITE;
/*!40000 ALTER TABLE `Medication` DISABLE KEYS */;
/*!40000 ALTER TABLE `Medication` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Patient`
--

DROP TABLE IF EXISTS `Patient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Patient` (
  `Ssn` char(9) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `Dob` datetime NOT NULL,
  `Age` int(11) NOT NULL,
  `Sex` char(1) NOT NULL,
  `First_Name` varchar(20) NOT NULL,
  `Minit` varchar(20) DEFAULT NULL,
  `Last_Name` varchar(20) NOT NULL,
  `Primary_Doctor_ID` char(9) NOT NULL,
  PRIMARY KEY (`Ssn`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Patient`
--

LOCK TABLES `Patient` WRITE;
/*!40000 ALTER TABLE `Patient` DISABLE KEYS */;
/*!40000 ALTER TABLE `Patient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Payment_Card`
--

DROP TABLE IF EXISTS `Payment_Card`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Payment_Card` (
  `Patient_Ssn` char(9) NOT NULL,
  `Name_On_Card` varchar(50) NOT NULL,
  `Card_Type` varchar(20) NOT NULL,
  `Card_Number` varchar(20) NOT NULL,
  `Ccv` char(3) NOT NULL,
  `Expiration_Date` datetime NOT NULL,
  PRIMARY KEY (`Patient_Ssn`),
  CONSTRAINT `Patient_Ssn` FOREIGN KEY (`Patient_Ssn`) REFERENCES `Patient` (`Ssn`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Payment_Card`
--

LOCK TABLES `Payment_Card` WRITE;
/*!40000 ALTER TABLE `Payment_Card` DISABLE KEYS */;
/*!40000 ALTER TABLE `Payment_Card` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Prescription`
--

DROP TABLE IF EXISTS `Prescription`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Prescription` (
  `Prescription_ID` char(7) NOT NULL,
  `Prescribing_Doctor_ID` char(7) NOT NULL,
  `Patien_Ssn` char(9) NOT NULL,
  `Medicat_ID` char(7) NOT NULL,
  `Medication_Quantity` int(11) NOT NULL,
  `Date_Prescribed` datetime NOT NULL,
  `Date_Expired` datetime DEFAULT NULL,
  PRIMARY KEY (`Prescription_ID`),
  KEY `Prescribing_Doctor_ID_idx` (`Prescribing_Doctor_ID`),
  KEY `Patien_Ssn_idx` (`Patien_Ssn`),
  KEY `Medicat_ID_idx` (`Medicat_ID`),
  CONSTRAINT `Prescribing_Doctor_ID` FOREIGN KEY (`Prescribing_Doctor_ID`) REFERENCES `Staff` (`ID_Number`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Patien_Ssn` FOREIGN KEY (`Patien_Ssn`) REFERENCES `Patient` (`Ssn`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Medicat_ID` FOREIGN KEY (`Medicat_ID`) REFERENCES `Medication` (`Medication_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Prescription`
--

LOCK TABLES `Prescription` WRITE;
/*!40000 ALTER TABLE `Prescription` DISABLE KEYS */;
/*!40000 ALTER TABLE `Prescription` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Staff`
--

DROP TABLE IF EXISTS `Staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Staff` (
  `ID_Number` char(7) NOT NULL,
  `Ssn` char(9) NOT NULL,
  `Pin` char(4) NOT NULL,
  `Staff_First_Name` varchar(20) NOT NULL,
  `Staff_Last_name` varchar(20) NOT NULL,
  `Staff_Type` char(1) NOT NULL,
  `Hire_Date` datetime NOT NULL,
  `Years_Practicing` int(11) DEFAULT NULL,
  `Specialty` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID_Number`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Staff`
--

LOCK TABLES `Staff` WRITE;
/*!40000 ALTER TABLE `Staff` DISABLE KEYS */;
/*!40000 ALTER TABLE `Staff` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-03-07 15:09:36
