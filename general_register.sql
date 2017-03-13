CREATE DATABASE  IF NOT EXISTS `general_register` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `general_register`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: general_register
-- ------------------------------------------------------
-- Server version	5.5.29

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
-- Table structure for table `school_setup`
--

DROP TABLE IF EXISTS `school_setup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `school_setup` (
  `srno` int(11) NOT NULL,
  `orgname` varchar(45) NOT NULL,
  `schoolname` varchar(45) NOT NULL,
  `line1` varchar(80) DEFAULT NULL,
  `line2` varchar(80) DEFAULT NULL,
  `line3` varchar(80) DEFAULT NULL,
  `line4` varchar(80) DEFAULT NULL,
  PRIMARY KEY (`srno`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `student_gen_reg`
--

DROP TABLE IF EXISTS `student_gen_reg`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `student_gen_reg` (
  `registration_no` int(11) NOT NULL,
  `student_name` varchar(100) DEFAULT NULL,
  `student_mother_name` varchar(100) DEFAULT NULL,
  `student_caste_subcast` varchar(45) DEFAULT NULL,
  `student_place_of_birth` varchar(45) DEFAULT NULL,
  `student_category` varchar(45) DEFAULT NULL,
  `student_dob` date NOT NULL,
  `student_last_school_attended` varchar(100) DEFAULT NULL,
  `student_date_of_admission` date NOT NULL,
  `student_class_of_admission` varchar(45) NOT NULL,
  `student_pending_docs` varchar(45) DEFAULT NULL,
  `student_status` varchar(15) NOT NULL,
  `student_progress` varchar(45) DEFAULT NULL,
  `student_conduct` varchar(45) DEFAULT NULL,
  `student_date_of_leaving` date DEFAULT NULL,
  `student_standard_studying` varchar(45) DEFAULT NULL,
  `student_reason_of_leaving` varchar(45) DEFAULT NULL,
  `student_remarks` varchar(45) DEFAULT NULL,
  `LC_generated_on` date DEFAULT NULL,
  `LC_serial_number` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`registration_no`),
  UNIQUE KEY `registration_no_UNIQUE` (`registration_no`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='student data from general register';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbluserlogin`
--

DROP TABLE IF EXISTS `tbluserlogin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbluserlogin` (
  `uid` int(11) NOT NULL,
  `username` varchar(15) NOT NULL,
  `password` varchar(45) NOT NULL,
  `role` varchar(45) NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `vpems_gen_reg`
--

DROP TABLE IF EXISTS `vpems_gen_reg`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vpems_gen_reg` (
  `stud_regno` varchar(45) NOT NULL,
  `stud_idno` varchar(45) DEFAULT NULL,
  `stud_uid` varchar(12) DEFAULT NULL,
  `stud_fname` varchar(45) DEFAULT NULL,
  `stud_mname` varchar(45) DEFAULT NULL,
  `stud_lname` varchar(45) DEFAULT NULL,
  `stud_mothers_name` varchar(45) DEFAULT NULL,
  `stud_religion` varchar(45) DEFAULT NULL,
  `stud_caste` varchar(45) DEFAULT NULL,
  `stud_subcaste` varchar(45) DEFAULT NULL,
  `stud_nationality` varchar(45) DEFAULT NULL,
  `stud_mothertongue` varchar(45) DEFAULT NULL,
  `stud_pob_village` varchar(45) DEFAULT NULL,
  `stud_pob_taluka` varchar(45) DEFAULT NULL,
  `stud_pob_dist` varchar(45) DEFAULT NULL,
  `stud_pob_state` varchar(45) DEFAULT NULL,
  `stud_pob_country` varchar(45) DEFAULT NULL,
  `stud_dob` date DEFAULT NULL,
  `stud_last_school` varchar(45) DEFAULT NULL,
  `stud_last_standard` varchar(45) DEFAULT NULL,
  `stud_admission_date` date DEFAULT NULL,
  `stud_admission_standard` varchar(45) DEFAULT NULL,
  `stud_progress` varchar(45) DEFAULT NULL,
  `stud_conduct` varchar(45) DEFAULT NULL,
  `stud_dol` date DEFAULT NULL,
  `stud_standard_studying` varchar(45) DEFAULT NULL,
  `stud_reasonofleaving` varchar(45) DEFAULT NULL,
  `stud_remarks` varchar(45) DEFAULT NULL,
  `stud_lc_serial` varchar(45) DEFAULT NULL,
  `stud_lc_generatedon` varchar(45) DEFAULT NULL,
  `stud_status` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`stud_regno`),
  UNIQUE KEY `stud_regno_UNIQUE` (`stud_regno`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='		';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping events for database 'general_register'
--

--
-- Dumping routines for database 'general_register'
--
/*!50003 DROP PROCEDURE IF EXISTS `Ins_StudentDetails` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50020 DEFINER=`root`@`localhost`*/ /*!50003 PROCEDURE `Ins_StudentDetails`(IN Reg_No int(11),
IN Student_Name varchar(100),
IN Mother_Name varchar(100),
IN CasteSubCaste varchar(45),
IN BirthPlace varchar(45),
IN Category varchar(45),
IN DOB date,
IN PrevSchool varchar(100),
IN AdmissionDate date,
IN Class varchar(45),
IN PendingDocs varchar(45),
IN Status varchar(15),
IN Progress varchar(45),
IN Conduct varchar(45),
IN DOL date,
IN Standard varchar(45),
IN ReasonOfLeaving varchar(45),
IN Remarks varchar(45)
)
BEGIN
  INSERT INTO `general_register`.`student_gen_reg`
(
`registration_no`,
`student_name`,
`student_mother_name`,
`student_caste_subcast`,
`student_place_of_birth`,
`student_category`,
`student_dob`,
`student_last_school_attended`,
`student_date_of_admission`,
`student_class_of_admission`,
`student_pending_docs`,
`student_status`,
`student_progress`,
`student_conduct`,
`student_date_of_leaving`,
`student_standard_studying`,
`student_reason_of_leaving`,
`student_remarks`)
VALUES
(
Reg_No,
Student_Name,
Mother_Name,
CasteSubCaste,
BirthPlace,
Category,
DOB,
PrevSchool,
AdmissionDate,
Class,
PendingDocs,
Status,
Progress,
Conduct,
DOL,
Standard,
ReasonOfLeaving,
Remarks
);
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Ins_StudentDetails_New` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50020 DEFINER=`root`@`localhost`*/ /*!50003 PROCEDURE `Ins_StudentDetails_New`(IN Reg_No int(11),
IN Student_Name varchar(100),
IN Mother_Name varchar(100),
IN CasteSubCaste varchar(45),
IN BirthPlace varchar(45),
IN Category varchar(45),
IN DOB date, 
IN PrevSchool varchar(100),
IN AdmissionDate date,
IN Class varchar(45),
IN PendingDocs varchar(45),
IN stus varchar(15),
IN Progress varchar(45),
IN Conduct varchar(45),
IN DOL date,
IN Standard varchar(45),
IN ReasonOfLeaving varchar(45),
IN Remarks varchar(45)
)
BEGIN

IF ( SELECT EXISTS (SELECT 1 FROM student_gen_reg where registration_no = Reg_No)) 
	THEN 
        
       update `general_register`.`student_gen_reg` 
		set 
		registration_no=Reg_No,
		student_name=Student_Name,
		student_mother_name=Mother_Name,
		student_caste_subcast=CasteSubCaste,
		student_place_of_birth=BirthPlace,
		student_category=Category,
		student_dob=DOB,
		student_last_school_attended=PrevSchool,
		student_date_of_admission=AdmissionDate,
		student_class_of_admission=Class,
		student_pending_docs =PendingDocs,
		student_status=stus,
		student_progress=Progress,
		student_conduct=Conduct,
		student_date_of_leaving=DOL,
		student_standard_studying=Standard,
		student_reason_of_leaving=ReasonOfLeaving,
		student_remarks=Remarks 
		where registration_no = Reg_No;
    ELSE
      INSERT INTO `general_register`.`student_gen_reg`
(
`registration_no`,
`student_name`,
`student_mother_name`,
`student_caste_subcast`,
`student_place_of_birth`,
`student_category`,
`student_dob`,
`student_last_school_attended`,
`student_date_of_admission`,
`student_class_of_admission`,
`student_pending_docs`,
`student_status`,
`student_progress`,
`student_conduct`,
`student_date_of_leaving`,
`student_standard_studying`,
`student_reason_of_leaving`,
`student_remarks`)
VALUES
(
Reg_No,
Student_Name,
Mother_Name,
CasteSubCaste,
BirthPlace,
Category,
DOB,
PrevSchool,
AdmissionDate,
Class,
PendingDocs,
stus,
Progress,
Conduct,
DOL,
Standard,
ReasonOfLeaving,
Remarks
)  ;
    END IF; 
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `school_setup` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50020 DEFINER=`root`@`localhost`*/ /*!50003 PROCEDURE `school_setup`(
IN school_srno int(11),
IN school_orgname varchar(45),
IN school_schoolname varchar(45),
IN school_line1 varchar(80),
IN school_line2 varchar(80),
IN school_line3 varchar(80),
IN school_line4 varchar(80)
)
BEGIN
IF ( SELECT EXISTS (SELECT 1 FROM school_setup where srno = school_srno)) 
	THEN 
        
       update `general_register`.`school_setup` 
		set 
		srno=school_srno,
		orname=school_orgname,
		schoolname=school_schoolname,
		line1=school_line1,
		line2=school_line2,
		line3=school_line3,
		line4=school_line4
		where srno = school_srno;
    ELSE
      INSERT INTO `general_register`.`school_setup`
(`srno`,
`orgname`,
`schoolname`,
`line1`,
`line2`,
`line3`,
`line4`
)
VALUES
(
school_srno ,
school_orgname ,
school_schoolname ,
school_line1,
school_line2,
school_line3,
school_line4 );
 END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Stud_Details` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50020 DEFINER=`root`@`localhost`*/ /*!50003 PROCEDURE `Stud_Details`(IN Reg_No varchar(45),
IN Student_ID varchar(10),
IN Student_UID varchar(12),
IN Student_FName varchar(100),
IN Student_MName varchar(100),
IN Student_LName varchar(100),
IN Student_mothers_name varchar(100),
IN Student_Religion varchar(100),
IN Student_Caste varchar(45),
IN Student_Subcaste varchar(45),
IN Student_Nationality varchar(45),
IN Student_Mothertongue varchar(45),
IN Student_POB_Village varchar(45),
IN Student_POB_Taluka varchar(45),
IN Student_POB_dist varchar(45),
IN Student_POB_state varchar(45),
IN Student_POB_country varchar(45),
IN Student_DOB date,
IN Student_last_School varchar(100),
IN Student_last_Standard varchar(100),
IN Student_admission_date date,
IN Student_admission_Standard varchar(100),
IN Student_progress varchar(45),
IN Student_conduct varchar(45),
IN Student_DOL date,
IN Student_standard_studying varchar(45),
IN Student_reasonofleaving varchar(45),
IN Student_remarks varchar(45),
IN Student_status varchar(45)
)
BEGIN
IF ( SELECT EXISTS (SELECT 1 FROM vpems_gen_reg where stud_regno = Reg_No)) 
	THEN 
        
       update `general_register`.`vpems_gen_reg` 
		set 
		stud_regno=Reg_No,
		stud_idno=Student_ID,
		stud_uid=Student_UID,
		stud_fname=Student_Fname,
		stud_mname=Student_Mname,
		stud_lname=Student_lname,
		stud_mothers_name=Student_mothers_name,
		stud_religion=Student_Religion,
		stud_caste=Student_Caste,
		stud_subcaste=Student_Subcaste,
		stud_nationality=Student_Nationality,
		stud_mothertongue=Student_MotherTongue,
		stud_pob_village=Student_POB_Village,
		stud_pob_taluka=Student_POB_Taluka,
		stud_pob_dist=Student_POB_dist,
		stud_pob_state=Student_POB_state,
		stud_pob_country=Student_POB_country,
		stud_dob=Student_DOB,
		stud_last_school=Student_last_school,
		stud_last_standard=Student_last_standard,
		stud_admission_date=Student_admission_date,
		stud_admission_standard=Student_admission_Standard,
		stud_progress=Student_progress,
		stud_conduct=Student_conduct,
		stud_dol=Student_DOL,
		stud_standard_studying=Student_standard_studying,
		stud_reasonofleaving=Student_reasonofleaving,
		stud_remarks=Student_remarks,
		stud_status=Student_status
		where stud_regno = Reg_No;
    ELSE
      INSERT INTO `general_register`.`vpems_gen_reg`
(`stud_regno`,
`stud_idno`,
`stud_uid`,
`stud_fname`,
`stud_mname`,
`stud_lname`,
`stud_mothers_name`,
`stud_religion`,
`stud_caste`,
`stud_subcaste`,
`stud_nationality`,
`stud_mothertongue`,
`stud_pob_village`,
`stud_pob_taluka`,
`stud_pob_dist`,
`stud_pob_state`,
`stud_pob_country`,
`stud_dob`,
`stud_last_school`,
`stud_last_standard`,
`stud_admission_date`,
`stud_admission_standard`,
`stud_progress`,
`stud_conduct`,
`stud_dol`,
`stud_standard_studying`,
`stud_reasonofleaving`,
`stud_remarks`,
`stud_status`)
VALUES
(
Reg_No ,
Student_ID ,
Student_UID ,
Student_FName ,
Student_MName ,
Student_LName ,
Student_mothers_name ,
Student_Religion ,
Student_Caste ,
Student_Subcaste ,
Student_Nationality ,
Student_Mothertongue ,
Student_POB_Village ,
Student_POB_Taluka ,
Student_POB_dist ,
Student_POB_state,
Student_POB_country ,
Student_DOB ,
Student_last_School,
Student_last_Standard ,
Student_admission_date,
Student_admission_Standard,
Student_progress ,
Student_conduct ,
Student_DOL ,
Student_standard_studying ,
Student_reasonofleaving ,
Student_remarks ,
Student_status );

    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `User_Registration` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50020 DEFINER=`root`@`localhost`*/ /*!50003 PROCEDURE `User_Registration`(
IN user_uid int(11),
IN user_username VARCHAR(45),
IN user_password VARCHAR(45),
IN user_role VARCHAR(45)
)
BEGIN
IF ( SELECT EXISTS (SELECT 1 FROM tbluserlogin where uid = user_uid)) 
	THEN 
        
       update `general_register`.`tbluserlogin` 
		set 
		uid=user_uid,
		username=user_username,
		password=user_password,
		role=user_role
		where uid = user_uid;
    ELSE
      INSERT INTO `general_register`.`tbluserlogin`
(`uid`,
`username`,
`password`,
`role`
)
VALUES
(
user_uid ,
user_username ,
user_password ,
user_role );
 END IF;

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-03-13 20:13:09
