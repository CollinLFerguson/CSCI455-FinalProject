CREATE DATABASE  IF NOT EXISTS `Astra_Care_Digital_Journal` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `Astra_Care_Digital_Journal`;
-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: sql5.freesqldatabase.com    Database: Astra_Care_Digital_Journal
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
-- Table structure for table `Address`
--

DROP TABLE IF EXISTS `Address`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Address` (
  `Ssn` char(9) NOT NULL,
  `Line_1` varchar(100) NOT NULL,
  `Line_2` varchar(50) DEFAULT NULL,
  `City` varchar(100) NOT NULL,
  `State` varchar(2) NOT NULL,
  `Zip` varchar(9) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Address`
--

LOCK TABLES `Address` WRITE;
/*!40000 ALTER TABLE `Address` DISABLE KEYS */;
INSERT INTO `Address` VALUES ('547394093','Owns St 455',NULL,'Owns','OH','41102'),('501234567','290 Hayes Park','Apt 1410','Richmond','VA','10120'),('159357258','1938 Sullivan Place','Apt 610','Metropolis','MN','55654'),('436385611','Jane St 455',NULL,'Owenburg','FL','41102'),('534239459','Jonestown 455 st',NULL,'Billsburrough','MA','54894');
/*!40000 ALTER TABLE `Address` ENABLE KEYS */;
UNLOCK TABLES;

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
INSERT INTO `Allergies` VALUES ('501234567','loratadine'),('501234567','epinephrine');
/*!40000 ALTER TABLE `Allergies` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Appointment`
--

DROP TABLE IF EXISTS `Appointment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Appointment` (
  `Appointment_ID` int(11) NOT NULL AUTO_INCREMENT,
  `The_Patients_Ssn` char(9) NOT NULL,
  `Financial_Report_ID` int(11) DEFAULT NULL,
  `Status` char(1) NOT NULL,
  `Notes` varchar(1000) DEFAULT NULL,
  `Date_Time` datetime NOT NULL,
  PRIMARY KEY (`Appointment_ID`),
  KEY `Financial_Report_ID_idx` (`Financial_Report_ID`),
  KEY `The_Patients_Ssn_idx` (`The_Patients_Ssn`),
  CONSTRAINT `Financial_Report_ID` FOREIGN KEY (`Financial_Report_ID`) REFERENCES `Financial_Report` (`Financial_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `The_Patients_Ssn` FOREIGN KEY (`The_Patients_Ssn`) REFERENCES `Patient` (`Ssn`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Appointment`
--

LOCK TABLES `Appointment` WRITE;
/*!40000 ALTER TABLE `Appointment` DISABLE KEYS */;
INSERT INTO `Appointment` VALUES (7,'501234567',NULL,'M','','2024-05-29 17:40:35'),(8,'501234567',NULL,'F','Routine exam','2024-03-12 17:40:51'),(9,'501234567',NULL,'R','','2024-04-29 21:45:37'),(10,'501234567',NULL,'A','','2024-05-01 07:58:41'),(11,'501234567',NULL,'A','Appointment','2024-04-24 16:16:46'),(12,'534239459',NULL,'A','Headache','2024-05-04 15:41:04');
/*!40000 ALTER TABLE `Appointment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Emergency_Contact`
--

DROP TABLE IF EXISTS `Emergency_Contact`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Emergency_Contact` (
  `Pa_Ssn` char(9) NOT NULL,
  `Contact_name` varchar(50) NOT NULL,
  `Phone_Number` varchar(15) NOT NULL,
  `Relation_to_Patient` varchar(30) DEFAULT NULL,
  KEY `P_Ssn_idx` (`Pa_Ssn`),
  CONSTRAINT `Pa_Ssn` FOREIGN KEY (`Pa_Ssn`) REFERENCES `Patient` (`Ssn`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Emergency_Contact`
--

LOCK TABLES `Emergency_Contact` WRITE;
/*!40000 ALTER TABLE `Emergency_Contact` DISABLE KEYS */;
INSERT INTO `Emergency_Contact` VALUES ('501234567','Patrick Ivons','7013545546','Spouse'),('534239459','Donnie Book','3332221234','Dad');
/*!40000 ALTER TABLE `Emergency_Contact` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Financial_Report`
--

DROP TABLE IF EXISTS `Financial_Report`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Financial_Report` (
  `Financial_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Pat_Ssn` char(9) NOT NULL,
  `Date_Of_Service` datetime NOT NULL,
  `Insurance` varchar(255) DEFAULT NULL,
  `Processing_Date` datetime DEFAULT NULL,
  `Due_Date` datetime NOT NULL,
  `Services_Rendered` varchar(1000) NOT NULL,
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
  `Med_ID` varchar(12) NOT NULL,
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
INSERT INTO `Ingredients` VALUES ('44149306','d-amphetamine'),('44149306','l-amphetamine salts'),('33613','amoxicillin'),('33613','croscarmellose sodiu'),('33613','gelatin'),('33613','magnesium stearate'),('33613','titanium dioxide'),('33613','yellow iron oxide'),('10909430','White Petrolatum'),('10909430','Mineral Oil'),('16682734','bismuth'),('16682734','salicylate'),('3957','loratadine'),('4090634','epinephrine'),('4090634','sodium chloride'),('4090634','sodium metabisulfite'),('4090634','hydrochloric acid'),('4090634','water'),('9294','phenylethanamine'),('841661910','piperidine'),('4372028','fluticasone propiona'),('4372028','microcrystalline cel'),('4372028','carboxymethylcellulo'),('4372028','benzalkonium chlorid'),('4372028','polysorbate 80'),('5849304','gelatin'),('5849304','water'),('5849304','lidocaine');
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
  `Group_Number` varchar(25) DEFAULT NULL,
  `Policy_Holder_Name` varchar(50) NOT NULL,
  KEY `P_Ssn_idx` (`P_Ssn`),
  CONSTRAINT `P_Ssn` FOREIGN KEY (`P_Ssn`) REFERENCES `Patient` (`Ssn`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Insurance`
--

LOCK TABLES `Insurance` WRITE;
/*!40000 ALTER TABLE `Insurance` DISABLE KEYS */;
INSERT INTO `Insurance` VALUES ('501234567','Tranquil Care Insura','59058182523821831206','520393049','Patrick Ivons'),('534239459','Vitality Coverage','47954917420100638933','520393049','Ruthie R. Book');
/*!40000 ALTER TABLE `Insurance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Medication`
--

DROP TABLE IF EXISTS `Medication`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Medication` (
  `Medication_ID` varchar(12) NOT NULL,
  `Side_Effects` varchar(1000) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Price` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`Medication_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Medication`
--

LOCK TABLES `Medication` WRITE;
/*!40000 ALTER TABLE `Medication` DISABLE KEYS */;
INSERT INTO `Medication` VALUES ('10909430','Bacitracin has such a low incidence of allergenicity that for all practical purposes side reactions are practically non-existent.','Bacitracin',2.98),('16682734','nausea, vomiting, hearing loss, diarrhea, constipation, dark colored stools','Pepto Bismol',5.24),('33613','nausea, vomiting, diarrhea, or rash\r ','Amoxicillin',9.80),('3957','fast or uneven heart rate, severe headache, light-headedness, drowsiness, stomach pain, dry mouth, nervousness','Claritin',12.34),('4090634','breathing problems, irregular heartbeats, sweating, nausea, vomiting, dizziness, headache, tremors','EpiPen',124.57),('4372028','nosebleed, sores inside or around nose, cough, headache, sinus pain, vomiting','Flonase',12.55),('44149306','stomach pain, loss of appetite, weight changes, nervousness, fast heart rate, headache, dizziness, insomnia, or dry mouth','Adderall',85.26),('5849304','stomach pain, loss of appetite, weight changes, nervousness, fast heart rate','Holigar',34.99),('841661910','slow heart rate, drowsiness, confusion, swelling, constipation, insomnia','Fentanyl',68.99),('9294','Dizziness, headache, nausia, nervousness, tremor, loss of appetite, restlessness, sleeplessness, stomach irritation','Ephedrine',245.31);
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
  `Dob` date NOT NULL,
  `Sex` char(1) NOT NULL,
  `First_Name` varchar(20) NOT NULL,
  `Minit` char(1) DEFAULT NULL,
  `Last_Name` varchar(20) NOT NULL,
  `Primary_Doctor_ID` char(7) DEFAULT NULL,
  `Phone_Number` char(10) DEFAULT NULL,
  PRIMARY KEY (`Ssn`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Patient`
--

LOCK TABLES `Patient` WRITE;
/*!40000 ALTER TABLE `Patient` DISABLE KEYS */;
INSERT INTO `Patient` VALUES ('159357258','1965-04-11','M','Clark','M','Kent','6151257','7405551234'),('501234567','1999-06-10','F','Sari','K','Ivons','5136671','7013301234'),('534239459','1991-03-27','F','Ruthie','R','Book','5136671','8158641025'),('547394093','1998-02-05','M','Joe','C','Smoe','1234567','6667889898');
/*!40000 ALTER TABLE `Patient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Payment_Card`
--

DROP TABLE IF EXISTS `Payment_Card`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Payment_Card` (
  `Patients_Ssn` char(9) NOT NULL,
  `Name_On_Card` varchar(50) NOT NULL,
  `Card_Type` varchar(20) NOT NULL,
  `Card_Number` varchar(20) NOT NULL,
  `Ccv` char(3) NOT NULL,
  `Expiration_Date` date NOT NULL,
  KEY `Patients_Ssn` (`Patients_Ssn`),
  CONSTRAINT `Patients_Ssn` FOREIGN KEY (`Patients_Ssn`) REFERENCES `Patient` (`Ssn`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Payment_Card`
--

LOCK TABLES `Payment_Card` WRITE;
/*!40000 ALTER TABLE `Payment_Card` DISABLE KEYS */;
INSERT INTO `Payment_Card` VALUES ('501234567','Sari Ivons','mastercard','514729671','288','0000-00-00');
/*!40000 ALTER TABLE `Payment_Card` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Prescription`
--

DROP TABLE IF EXISTS `Prescription`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Prescription` (
  `Prescription_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Prescribing_Doctor_ID` int(11) NOT NULL,
  `Patien_Ssn` char(9) NOT NULL,
  `Medicat_ID` varchar(12) NOT NULL,
  `Medication_Quantity` int(11) NOT NULL,
  `Date_Prescribed` date NOT NULL,
  `Date_Expired` date DEFAULT NULL,
  PRIMARY KEY (`Prescription_ID`),
  KEY `Patien_Ssn_idx` (`Patien_Ssn`),
  KEY `Medicat_ID_idx` (`Medicat_ID`),
  KEY `Prescribing_Doctor_ID_idx` (`Prescribing_Doctor_ID`),
  CONSTRAINT `Perscribing_Doctor_ID` FOREIGN KEY (`Prescribing_Doctor_ID`) REFERENCES `Staff` (`ID_Number`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Medicat_ID` FOREIGN KEY (`Medicat_ID`) REFERENCES `Medication` (`Medication_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Patien_Ssn` FOREIGN KEY (`Patien_Ssn`) REFERENCES `Patient` (`Ssn`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6543233 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Prescription`
--

LOCK TABLES `Prescription` WRITE;
/*!40000 ALTER TABLE `Prescription` DISABLE KEYS */;
INSERT INTO `Prescription` VALUES (6543231,5136671,'501234567','4372028',2,'2024-04-30','2024-05-24'),(6543232,5136671,'534239459','4372028',3,'2024-04-30','2028-06-13');
/*!40000 ALTER TABLE `Prescription` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Staff`
--

DROP TABLE IF EXISTS `Staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Staff` (
  `ID_Number` int(11) NOT NULL AUTO_INCREMENT,
  `Ssn` char(9) NOT NULL,
  `Pin` char(4) NOT NULL,
  `Staff_First_Name` varchar(20) NOT NULL,
  `Staff_Last_name` varchar(20) NOT NULL,
  `Staff_Type` char(1) NOT NULL,
  `Hire_Date` date NOT NULL,
  `Years_Practicing` int(11) DEFAULT NULL,
  `Specialty` varchar(50) DEFAULT NULL,
  `Staff_Middle_Init` char(1) DEFAULT NULL,
  PRIMARY KEY (`ID_Number`,`Ssn`)
) ENGINE=InnoDB AUTO_INCREMENT=7963597 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Staff`
--

LOCK TABLES `Staff` WRITE;
/*!40000 ALTER TABLE `Staff` DISABLE KEYS */;
INSERT INTO `Staff` VALUES (1234567,'123456789','1234','Germ','Mith','D','2024-01-10',12,'Pediatrics','C'),(4161374,'511001113','7597','Barde','Conkie','A','0000-00-00',NULL,NULL,NULL),(4310931,'486612036','3127','Walt','Frascone','N','0000-00-00',NULL,NULL,NULL),(4430812,'420645429','1109','Marve','Cradock','N','0000-00-00',NULL,NULL,NULL),(4752258,'569236170','9616','Damita','Coldrick','A','0000-00-00',NULL,NULL,NULL),(4772099,'557498463','4894','Lorelle','Zanotti','N','0000-00-00',NULL,NULL,NULL),(4936979,'593228093','7100','Ulrikaumeko','Harrington','N','0000-00-00',NULL,NULL,NULL),(5136671,'567864653','1733','Emalee','Slarke','D','2021-02-12',37,'Oncology',NULL),(5548192,'415483349','8569','Lovell','Aggett','D','2021-11-15',12,'Orthopedics',NULL),(5764821,'554324738','9340','Joelie','Leyshon','A','0000-00-00',NULL,NULL,NULL),(6118232,'437354203','4856','Ruttger','Barsby','A','0000-00-00',NULL,NULL,NULL),(7766141,'509971922','5825','Fowler','Riba','N','0000-00-00',NULL,NULL,NULL),(7963581,'518340479','6508','Gale','McCabe','A','0000-00-00',NULL,NULL,NULL),(7963594,'436385611','7558','Andrus','De Bernardis','D','2024-04-11',12,'faf',''),(7963595,'6742315','7777','Johnson','Fergy','D','2011-04-11',8,'Pediatrics','L'),(7963596,'436385611','7558','Andrus','De Bernardis','D','2024-04-11',4,'Pediatrics','');
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

-- Dump completed on 2024-05-07 14:47:34
