-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Oct 06, 2017 at 06:00 AM
-- Server version: 5.7.19
-- PHP Version: 5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `icamp`
--

-- --------------------------------------------------------

--
-- Table structure for table `camp_activity`
--

DROP TABLE IF EXISTS `camp_activity`;
CREATE TABLE IF NOT EXISTS `camp_activity` (
  `STUDENT_ID` int(11) NOT NULL,
  `SESSION_ACTIVITY_ID` int(11) NOT NULL,
  `ACTIVITY_ID` int(11) NOT NULL AUTO_INCREMENT,
  `SUBJECT_NUMBER` int(11) NOT NULL,
  `ACTIVITY_NAME` varchar(50) NOT NULL,
  `ACTIVITY_DATE` date NOT NULL,
  PRIMARY KEY (`ACTIVITY_ID`),
  KEY `SESSION_ACTIVITY_ID` (`SESSION_ACTIVITY_ID`),
  KEY `STUDENT_ID` (`STUDENT_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `camp_session`
--

DROP TABLE IF EXISTS `camp_session`;
CREATE TABLE IF NOT EXISTS `camp_session` (
  `SESSION_ID` int(11) NOT NULL AUTO_INCREMENT,
  `SESSION_NAME` varchar(50) NOT NULL,
  `SESSION_START_DATE` date NOT NULL,
  `SESSION_END_DATE` date NOT NULL,
  PRIMARY KEY (`SESSION_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `camp_student`
--

DROP TABLE IF EXISTS `camp_student`;
CREATE TABLE IF NOT EXISTS `camp_student` (
  `STUDENT_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) NOT NULL,
  `START_DATE` date NOT NULL,
  `LEAVE_DATE` date NOT NULL,
  `STUDENT_BUNK` varchar(50) NOT NULL,
  `NATIONALITY` varchar(50) NOT NULL,
  `PREFERED_NAME` varchar(50) NOT NULL,
  `AGE` int(11) NOT NULL,
  `RESTRICTION` varchar(100) NOT NULL,
  `MEDICATIONS` varchar(100) NOT NULL,
  `TRANSPORTATION` varchar(100) NOT NULL,
  `PARENT1_NAME` varchar(100) NOT NULL,
  `PARENT1_EMAIL` varchar(100) NOT NULL,
  `PARENT1_PHONE` varchar(100) NOT NULL,
  `PARENT2_NAME` varchar(100) NOT NULL,
  `PARENT2_EMAIL` varchar(100) NOT NULL,
  `PARENT2_PHONE` varchar(100) NOT NULL,
  PRIMARY KEY (`STUDENT_ID`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `camp_student`
--

INSERT INTO `camp_student` (`STUDENT_ID`, `Name`, `START_DATE`, `LEAVE_DATE`, `STUDENT_BUNK`, `NATIONALITY`, `PREFERED_NAME`, `AGE`, `RESTRICTION`, `MEDICATIONS`, `TRANSPORTATION`, `PARENT1_NAME`, `PARENT1_EMAIL`, `PARENT1_PHONE`, `PARENT2_NAME`, `PARENT2_EMAIL`, `PARENT2_PHONE`) VALUES
(2, 'Tafadzwa', '2017-10-06', '2017-10-07', 'Orange', 'Zimbabwe', 'Taf', 21, 'None', 'None', 'Car', 'Dad', 'dad@email.com', '022215487', 'Mom', 'mom@email.com', '011236548');

-- --------------------------------------------------------

--
-- Table structure for table `camp_student_parent1`
--

DROP TABLE IF EXISTS `camp_student_parent1`;
CREATE TABLE IF NOT EXISTS `camp_student_parent1` (
  `STUDENT_ID` int(11) DEFAULT NULL,
  `PARENT1_ID` int(11) NOT NULL AUTO_INCREMENT,
  `PARENT1_NAME` varchar(50) DEFAULT NULL,
  `PARENT1_EMAIL` varchar(50) DEFAULT NULL,
  `PARENT1_PHONE` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`PARENT1_ID`),
  KEY `STUDENT_ID` (`STUDENT_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `camp_student_parent2`
--

DROP TABLE IF EXISTS `camp_student_parent2`;
CREATE TABLE IF NOT EXISTS `camp_student_parent2` (
  `STUDENT_ID` int(11) DEFAULT NULL,
  `PARENT2_ID` int(11) NOT NULL AUTO_INCREMENT,
  `PARENT2_NAME` varchar(50) DEFAULT NULL,
  `PARENT2_EMAIL` varchar(50) DEFAULT NULL,
  `PARENT2_PHONE` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`PARENT2_ID`),
  KEY `STUDENT_ID` (`STUDENT_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
