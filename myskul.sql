-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Mar 22, 2023 at 12:14 PM
-- Server version: 5.7.36
-- PHP Version: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `myskul`
--
CREATE DATABASE IF NOT EXISTS `myskul` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `myskul`;

-- --------------------------------------------------------

--
-- Table structure for table `academic_year`
--

DROP TABLE IF EXISTS `academic_year`;
CREATE TABLE IF NOT EXISTS `academic_year` (
  `id` int(11) NOT NULL,
  `academic` varchar(200) NOT NULL,
  `term` int(1) NOT NULL,
  `term_starts` date NOT NULL,
  `term_ends` date NOT NULL,
  `next_term` date NOT NULL,
  `status` tinyint(4) NOT NULL DEFAULT '0',
  `sid` varchar(200) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `academic_year`
--

INSERT INTO `academic_year` (`id`, `academic`, `term`, `term_starts`, `term_ends`, `next_term`, `status`, `sid`) VALUES
(4, '2020/2021', 1, '2020-04-28', '2021-01-30', '2021-02-27', 0, 'Kessie123');

-- --------------------------------------------------------

--
-- Table structure for table `account`
--

DROP TABLE IF EXISTS `account`;
CREATE TABLE IF NOT EXISTS `account` (
  `account_id` varchar(200) NOT NULL,
  `username` varchar(200) NOT NULL,
  `password` varchar(200) NOT NULL,
  `access_level` int(1) NOT NULL,
  `staff_id` varchar(200) NOT NULL,
  `sid` varchar(200) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `attendance`
--

DROP TABLE IF EXISTS `attendance`;
CREATE TABLE IF NOT EXISTS `attendance` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Staff_ID` varchar(200) NOT NULL,
  `Name` char(200) NOT NULL,
  `In_Time` time NOT NULL,
  `Out_Time` time NOT NULL,
  `Hours` int(11) NOT NULL,
  `Date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `sid` varchar(200) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `attitude`
--

DROP TABLE IF EXISTS `attitude`;
CREATE TABLE IF NOT EXISTS `attitude` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Attitude` char(60) NOT NULL,
  `sid` varchar(200) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `attitude`
--

INSERT INTO `attitude` (`ID`, `Attitude`, `sid`) VALUES
(3, 'HUMBLE', 'Kessie123');

-- --------------------------------------------------------

--
-- Table structure for table `charges`
--

DROP TABLE IF EXISTS `charges`;
CREATE TABLE IF NOT EXISTS `charges` (
  `charge_id` varchar(200) NOT NULL,
  `name` varchar(200) NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  `term` int(3) NOT NULL,
  `year` varchar(200) NOT NULL,
  `class` text NOT NULL,
  `date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `calculated` tinyint(4) NOT NULL DEFAULT '0',
  `sid` varchar(200) NOT NULL,
  PRIMARY KEY (`charge_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `charges`
--

INSERT INTO `charges` (`charge_id`, `name`, `amount`, `term`, `year`, `class`, `date`, `calculated`, `sid`) VALUES
('2020/2021-1-27', 'Pta', '1.00', 1, '2020/2021', 'All', '2020-11-09 23:12:27', 1, 'Kessie123'),
('2020/2021-1-54', 'Kl', '13.00', 1, '2020/2021', 'All', '2020-11-09 23:21:54', 1, 'Kessie123'),
('2020/2021-1-17', 'Kjj', '100.00', 1, '2020/2021', 'All', '2020-11-09 23:26:17', 1, 'Kessie123');

-- --------------------------------------------------------

--
-- Table structure for table `cheques`
--

DROP TABLE IF EXISTS `cheques`;
CREATE TABLE IF NOT EXISTS `cheques` (
  `Cheque_ID` varchar(200) NOT NULL,
  `Name` char(200) NOT NULL,
  `Account_No` varchar(200) NOT NULL,
  `Amount` decimal(10,2) NOT NULL,
  `Type` char(200) NOT NULL,
  `Cheque_Date` date NOT NULL,
  `Date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `sid` varchar(200) NOT NULL,
  PRIMARY KEY (`Cheque_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `class`
--

DROP TABLE IF EXISTS `class`;
CREATE TABLE IF NOT EXISTS `class` (
  `class_no` int(3) NOT NULL,
  `class_name` char(20) NOT NULL,
  `fees` decimal(10,2) NOT NULL,
  `sid` varchar(200) NOT NULL,
  PRIMARY KEY (`class_no`) USING BTREE
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `class`
--

INSERT INTO `class` (`class_no`, `class_name`, `fees`, `sid`) VALUES
(1, 'One', '500.00', 'Kessie123'),
(2, 'Two', '550.00', 'Kessie123'),
(3, 'Three', '550.00', 'Kessie123');

-- --------------------------------------------------------

--
-- Table structure for table `deletedcheques`
--

DROP TABLE IF EXISTS `deletedcheques`;
CREATE TABLE IF NOT EXISTS `deletedcheques` (
  `Cheque_ID` varchar(200) NOT NULL,
  `Name` varchar(200) NOT NULL,
  `Account_No` varchar(200) NOT NULL,
  `Amount` decimal(10,2) NOT NULL,
  `Type` varchar(200) NOT NULL,
  `Cheque_Date` date NOT NULL,
  `Deleted_by` varchar(200) NOT NULL,
  `Date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `sid` varchar(200) NOT NULL,
  PRIMARY KEY (`Cheque_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `deletedincome`
--

DROP TABLE IF EXISTS `deletedincome`;
CREATE TABLE IF NOT EXISTS `deletedincome` (
  `Income_ID` varchar(200) NOT NULL,
  `Name` varchar(200) NOT NULL,
  `Type` varchar(200) NOT NULL,
  `Amount` decimal(10,2) NOT NULL,
  `Academic` varchar(200) NOT NULL,
  `Term` int(11) NOT NULL,
  `Description` text,
  `Paid_by` varchar(200) NOT NULL,
  `date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Deleted_by` varchar(200) NOT NULL,
  `sid` varchar(200) NOT NULL,
  PRIMARY KEY (`Income_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `d_grade`
--

DROP TABLE IF EXISTS `d_grade`;
CREATE TABLE IF NOT EXISTS `d_grade` (
  `id` varchar(200) NOT NULL,
  `assessment` int(3) NOT NULL,
  `assessment_p` int(2) NOT NULL,
  `exams` int(3) NOT NULL,
  `exams_p` int(2) NOT NULL,
  `cut_off` int(200) NOT NULL,
  `status` tinyint(4) NOT NULL DEFAULT '1',
  `sid` varchar(200) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `d_grade`
--

INSERT INTO `d_grade` (`id`, `assessment`, `assessment_p`, `exams`, `exams_p`, `cut_off`, `status`, `sid`) VALUES
('2020/2021-1', 40, 40, 100, 60, 350, 1, 'Kessie123');

-- --------------------------------------------------------

--
-- Table structure for table `events`
--

DROP TABLE IF EXISTS `events`;
CREATE TABLE IF NOT EXISTS `events` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `eventid` varchar(200) NOT NULL,
  `term` int(1) NOT NULL,
  `academic` varchar(200) NOT NULL,
  `start` date NOT NULL,
  `end` date NOT NULL,
  `ename` varchar(200) NOT NULL,
  `comment` text NOT NULL,
  `sid` varchar(200) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `events`
--

INSERT INTO `events` (`id`, `eventid`, `term`, `academic`, `start`, `end`, `ename`, `comment`, `sid`) VALUES
(3, '2020/2021-1', 1, '2020/2021', '2020-11-08', '2020-11-30', 'Testing Phase', 'fgf gfgfg dghdhf gfg gr egreg egrgr regergr', 'Kessie123');

-- --------------------------------------------------------

--
-- Table structure for table `exams`
--

DROP TABLE IF EXISTS `exams`;
CREATE TABLE IF NOT EXISTS `exams` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `examid` varchar(200) NOT NULL,
  `subject` char(200) NOT NULL,
  `class` int(4) NOT NULL,
  `start` varchar(200) NOT NULL,
  `end` varchar(200) NOT NULL,
  `term` int(1) NOT NULL,
  `academic` varchar(200) NOT NULL,
  `date` date NOT NULL,
  `sid` varchar(200) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `expenses`
--

DROP TABLE IF EXISTS `expenses`;
CREATE TABLE IF NOT EXISTS `expenses` (
  `Expenses_ID` varchar(200) NOT NULL,
  `Date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Record` text NOT NULL,
  `Academic` varchar(200) NOT NULL,
  `Term` int(4) NOT NULL,
  `Total` decimal(10,2) NOT NULL,
  `sid` varchar(200) NOT NULL,
  PRIMARY KEY (`Expenses_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `grade`
--

DROP TABLE IF EXISTS `grade`;
CREATE TABLE IF NOT EXISTS `grade` (
  `ID` int(200) NOT NULL AUTO_INCREMENT,
  `Student_ID` varchar(200) NOT NULL,
  `Student_Name` char(200) NOT NULL,
  `Overall_Marks` double DEFAULT NULL,
  `Overall_Position` double DEFAULT NULL,
  `Academic` varchar(200) NOT NULL,
  `Term` int(1) NOT NULL,
  `Class` varchar(200) NOT NULL,
  `Remark` varchar(200) DEFAULT NULL,
  `sid` varchar(200) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Student_ID` (`Student_ID`)
) ENGINE=MyISAM AUTO_INCREMENT=92 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `grade`
--

INSERT INTO `grade` (`ID`, `Student_ID`, `Student_Name`, `Overall_Marks`, `Overall_Position`, `Academic`, `Term`, `Class`, `Remark`, `sid`) VALUES
(1, 'st123', 'KESSIE.Bismark', 420, 21, '2020/2021', 1, '1A', NULL, 'Kessie123'),
(2, '51800437', 'ABBAS. Abdul-Karim', 504, 12, '2020/2021', 1, '1A', NULL, 'Kessie123'),
(3, '51800438', 'ABDUL GANIYU.Sadick', 504, 13, '2020/2021', 1, '1A', NULL, 'Kessie123'),
(4, 'DIT05170011', 'ABDUL-Malik Firdaus', 511, 9, '2020/2021', 1, '1A', NULL, 'Kessie123'),
(5, '51800439', 'ABUBAKAR.Farouk', 546, 2, '2020/2021', 1, '1A', NULL, 'Kessie123'),
(6, '51800440', 'ADAM.Gadaf', 539, 5, '2020/2021', 1, '1A', NULL, 'Kessie123'),
(7, 'DIT05170007', 'ADARKWAH Emmanuel', 476, 16, '2020/2021', 1, '1A', NULL, 'Kessie123'),
(8, '51800441', 'ADIKU OFORI.Harold', 434, 19, '2020/2021', 1, '1A', NULL, 'Kessie123'),
(9, '51800442', 'ADJEI.Anthony Clifford', 525, 8, '2020/2021', 1, '1A', NULL, 'Kessie123'),
(10, '51800444', 'ADOMAKO.Eric', 434, 20, '2020/2021', 1, '1A', NULL, 'Kessie123'),
(11, '51800443', 'ADOMAKO.Prince', 546, 3, '2020/2021', 1, '1A', NULL, 'Kessie123'),
(12, '51800445', 'AGYAPONG.Alexander', 371, 22, '2020/2021', 1, '1A', NULL, 'Kessie123'),
(13, '51800446', 'AGYEKUM.Ernest Tabi', 567, 1, '2020/2021', 1, '1A', NULL, 'Kessie123'),
(14, 'DIT05170099', 'AHIABLE Victoria', 511, 10, '2020/2021', 1, '1A', NULL, 'Kessie123'),
(15, '51800447', 'AHMED.Saeed', 511, 11, '2020/2021', 1, '1A', NULL, 'Kessie123'),
(16, '51800448', 'AIDOO.Grace', 532, 6, '2020/2021', 1, '1A', NULL, 'Kessie123'),
(17, '51800449', 'ALHASSAN.Faruq', 469, 17, '2020/2021', 1, '1A', NULL, 'Kessie123'),
(18, 'DWD05170001', 'AMOAH Gyamfuaah Ellen', 483, 15, '2020/2021', 1, '1A', NULL, 'Kessie123'),
(19, '51800450', 'ANOKYE.Phinehas Boakye', 546, 4, '2020/2021', 1, '1A', NULL, 'Kessie123'),
(20, '51800451', 'ANSAH.Alfred', 532, 7, '2020/2021', 1, '1A', NULL, 'Kessie123'),
(21, 'DIT05170023', 'ANTWI Boasiako Kwame', 497, 14, '2020/2021', 1, '1A', NULL, 'Kessie123'),
(22, '51800452', 'ANTWI.Addai Dickson', 448, 18, '2020/2021', 1, '1A', NULL, 'Kessie123'),
(23, 'DIT05170036', 'ASARE Philemon', 441, 36, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(24, '51800453', 'ASARE.Clement', 497, 25, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(25, '51800454', 'ASARE.Victor', 441, 37, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(26, '51800455', 'ASOMANI.Williams', 546, 9, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(27, '51800456', 'ATIAH.Peter Ayine', 588, 3, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(28, 'DIT05170039', 'AYILGIA Desmond', 595, 1, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(29, '51800457', 'AZIAH.Daniel', 511, 19, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(30, '51800458', 'BAAH.Desmond', 462, 33, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(31, '51800459', 'BINEY.Kish Daniel', 525, 16, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(32, '51800460', 'BLAY.Goka Simon', 469, 32, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(33, '51800461', 'BOAHENE.Prince', 546, 10, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(34, '51800462', 'BOAKYE AGYEMANG.Jnr Mensah', 399, 39, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(35, 'DHN05170004', 'BOAKYE Joel', 595, 2, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(36, 'DIT05170049', 'BOATENG Asare', 497, 26, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(37, '51800463', 'BOATENG.Bismark', 518, 18, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(38, '51800464', 'BORLABI.Godfred Borketey', 504, 24, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(39, '51800465', 'BREFO.Daniel', 455, 35, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(40, '51800466', 'BRONI.Jephter', 511, 20, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(41, '51800467', 'BUDU.Charles', 539, 14, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(42, '51800468', 'CUDJOE.Joseph', 553, 7, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(43, '51800469', 'DAISSIE.Gladys', 546, 11, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(44, '51800470', 'DAYYAN.Issahaku', 462, 34, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(45, 'DIT05170026', 'ELLIOT Gyamfi Anyankwah', 497, 27, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(46, '51800471', 'FAISAL.Halid Dene', 567, 5, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(47, 'DIT05170058', 'GIBRINE Adiza Adamu', 392, 40, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(48, '51800472', 'GYETUA DANQUAH.Richmond', 588, 4, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(49, '51800473', 'ISSAH.Abubakar Saddick', 483, 28, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(50, 'DIT05170063', 'KARIM Nayiba', 483, 29, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(51, 'DIT05170065', 'KONADU Obed', 525, 17, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(52, 'DIT05170068', 'LARBI Wilson Nana Yaw', 546, 12, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(53, '51800474', 'MENSAH ABRAMPAH.Shadrack', 476, 31, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(54, 'DIT05170067', 'MICHAEL Agyapong Kwarteng', 553, 8, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(55, 'DIT05170013', 'MICHAEL Bota Afrifa', 567, 6, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(56, '51800477', 'MOHAMMED ISHMAIL.Shariff', 511, 21, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(57, 'DIT05170071', 'MOHAMMED Jamal', 483, 30, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(58, '51800476', 'MOHAMMED.Osman', 406, 38, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(59, '51800475', 'MOHAMMED.Yahaya Hafiz', 511, 22, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(60, '51800478', 'MONTEL.Ray Lawson', 546, 13, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(61, '51801905', 'MORNAH.Frank  Atouro', 511, 23, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(62, '51800480', 'NKANSAH.Prince', 532, 15, '2020/2021', 1, '1B', NULL, 'Kessie123'),
(63, '51800482', 'NYANTAKYI.David', 513, 9, '2020/2021', 1, '1C', NULL, 'Kessie123'),
(64, '51800481', 'NYANTAKYI.Gideon', 527, 7, '2020/2021', 1, '1C', NULL, 'Kessie123'),
(65, '51800483', 'OBODAI SAI.Edmund', 471, 20, '2020/2021', 1, '1C', NULL, 'Kessie123'),
(66, '51802181', 'OCRAN Victor', 538, 4, '2020/2021', 1, '1C', NULL, 'Kessie123'),
(67, '51800484', 'ODURO.Charles', 519, 8, '2020/2021', 1, '1C', NULL, 'Kessie123'),
(68, '51800485', 'OFORI  BOYE.Gilbert', 487, 16, '2020/2021', 1, '1C', NULL, 'Kessie123'),
(69, '51800488', 'OPOKU.Emmanuel Junior', 435, 24, '2020/2021', 1, '1C', NULL, 'Kessie123'),
(70, '51800487', 'OPOKU.Evans', 405, 28, '2020/2021', 1, '1C', NULL, 'Kessie123'),
(71, '51800486', 'OPOKU.Gyasi Edward', 501, 13, '2020/2021', 1, '1C', NULL, 'Kessie123'),
(72, '51800489', 'OPPONG.Success Antwiwaa', 506, 11, '2020/2021', 1, '1C', NULL, 'Kessie123'),
(73, '51800490', 'OPUNI AMPEM.Benjamin', 548, 2, '2020/2021', 1, '1C', NULL, 'Kessie123'),
(74, '51800491', 'OSEI.Agyei Samuel', 384, 29, '2020/2021', 1, '1C', NULL, 'Kessie123'),
(75, '51800492', 'OSEI.Dennis', 587, 1, '2020/2021', 1, '1C', NULL, 'Kessie123'),
(76, 'DIT05170087', 'OWUSU Eric', 508, 10, '2020/2021', 1, '1C', NULL, 'Kessie123'),
(77, '51800493', 'OWUSU MANU. Emmanuel', 453, 21, '2020/2021', 1, '1C', NULL, 'Kessie123'),
(78, 'DIT05170083', 'OWUSU Obed', 437, 23, '2020/2021', 1, '1C', NULL, 'Kessie123'),
(79, 'DIT05170084', 'OWUSU Roberto', 423, 25, '2020/2021', 1, '1C', NULL, 'Kessie123'),
(80, 'DIT05170086', 'QUAINOO Arko Joseph', 534, 5, '2020/2021', 1, '1C', NULL, 'Kessie123'),
(81, '51800494', 'RAHMAN.Abdul', 506, 12, '2020/2021', 1, '1C', NULL, 'Kessie123'),
(82, 'DIT05170094', 'SALANI Latifa', 494, 14, '2020/2021', 1, '1C', NULL, 'Kessie123'),
(83, '51800495', 'SARFO KANTANKA. Emmanuel', 447, 22, '2020/2021', 1, '1C', NULL, 'Kessie123'),
(84, 'DIT05170092', 'SARPONG Kwabena', 412, 27, '2020/2021', 1, '1C', NULL, 'Kessie123'),
(85, '51800496', 'SARPONG.Prince', 491, 15, '2020/2021', 1, '1C', NULL, 'Kessie123'),
(86, '51800497', 'TETTEH.Emmanuel', 528, 6, '2020/2021', 1, '1C', NULL, 'Kessie123'),
(87, '51800498', 'TRETU.Eric', 421, 26, '2020/2021', 1, '1C', NULL, 'Kessie123'),
(88, 'DIT05170101', 'YAHAYA Shuraim Muhideen', 546, 3, '2020/2021', 1, '1C', NULL, 'Kessie123'),
(89, '51800499', 'ZOTRA. Derrick', 475, 19, '2020/2021', 1, '1C', NULL, 'Kessie123'),
(90, 'DIT05170025', 'Antwi Vera', 486, 17, '2020/2021', 1, '1C', NULL, 'Kessie123'),
(91, 'DIT05170082', 'DARKWAH.OWUSU GABRIEL', 477, 18, '2020/2021', 1, '1C', NULL, 'Kessie123');

-- --------------------------------------------------------

--
-- Table structure for table `grading`
--

DROP TABLE IF EXISTS `grading`;
CREATE TABLE IF NOT EXISTS `grading` (
  `grade_id` varchar(200) NOT NULL,
  `lower_limit` int(2) NOT NULL,
  `upper_limit` int(3) NOT NULL,
  `letter_grade` varchar(2) NOT NULL,
  `remark` char(20) NOT NULL,
  `sid` varchar(200) NOT NULL,
  PRIMARY KEY (`grade_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `grading`
--

INSERT INTO `grading` (`grade_id`, `lower_limit`, `upper_limit`, `letter_grade`, `remark`, `sid`) VALUES
('10080', 80, 100, 'A1', 'Excellent', 'Kessie123'),
('7970', 70, 79, 'B2', 'Very Good', 'Kessie123'),
('6960', 60, 69, 'B3', 'Good', 'Kessie123'),
('5950', 50, 59, 'C4', 'Pass', 'Kessie123'),
('4940', 40, 49, 'F9', 'Fail', 'Kessie123');

-- --------------------------------------------------------

--
-- Table structure for table `income`
--

DROP TABLE IF EXISTS `income`;
CREATE TABLE IF NOT EXISTS `income` (
  `Income_ID` varchar(200) NOT NULL,
  `Name` varchar(200) NOT NULL,
  `Type` varchar(200) NOT NULL,
  `Amount` decimal(10,2) NOT NULL,
  `Academic` varchar(200) NOT NULL,
  `Term` int(3) NOT NULL,
  `Description` text,
  `Paid_by` char(200) NOT NULL,
  `Date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `recorded` tinyint(4) NOT NULL DEFAULT '0',
  `sid` varchar(200) NOT NULL,
  PRIMARY KEY (`Income_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `income`
--

INSERT INTO `income` (`Income_ID`, `Name`, `Type`, `Amount`, `Academic`, `Term`, `Description`, `Paid_by`, `Date`, `recorded`, `sid`) VALUES
('DES-2020/2021-11-1-19', 'ODURO.Charles', 'Fees', '256.00', '2020/2021', 1, '', 'Father', '2020-11-09 22:55:19', 1, 'Kessie123');

-- --------------------------------------------------------

--
-- Table structure for table `marks`
--

DROP TABLE IF EXISTS `marks`;
CREATE TABLE IF NOT EXISTS `marks` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Student_ID` varchar(200) NOT NULL,
  `Name` char(200) NOT NULL,
  `Subject` varchar(200) NOT NULL,
  `Class_Score` double NOT NULL,
  `Exams_Score` double NOT NULL,
  `Total` double NOT NULL,
  `Remark` char(200) NOT NULL,
  `Academic` varchar(200) NOT NULL,
  `Term` int(1) NOT NULL,
  `Position` int(5) DEFAULT NULL,
  `Class` varchar(200) NOT NULL,
  `Date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `d_grade` varchar(200) NOT NULL,
  `sid` varchar(200) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=983 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `marks`
--

INSERT INTO `marks` (`ID`, `Student_ID`, `Name`, `Subject`, `Class_Score`, `Exams_Score`, `Total`, `Remark`, `Academic`, `Term`, `Position`, `Class`, `Date`, `d_grade`, `sid`) VALUES
(73, 'st123', 'KESSIE.Bismark', 'French', 26, 34, 60, 'Good', '2020/2021', 1, 17, '1A', '2020-11-09 16:15:46', '2020/2021-1', 'Kessie123'),
(74, '51800437', 'ABBAS. Abdul-Karim', 'French', 26, 46, 72, 'Very Good', '2020/2021', 1, 7, '1A', '2020-11-09 16:15:46', '2020/2021-1', 'Kessie123'),
(75, '51800438', 'ABDUL GANIYU.Sadick', 'French', 26, 46, 72, 'Very Good', '2020/2021', 1, 14, '1A', '2020-11-09 16:15:46', '2020/2021-1', 'Kessie123'),
(76, 'DIT05170011', 'ABDUL-Malik Firdaus', 'French', 26, 47, 73, 'Very Good', '2020/2021', 1, 4, '1A', '2020-11-09 16:15:47', '2020/2021-1', 'Kessie123'),
(77, '51800439', 'ABUBAKAR.Farouk', 'French', 26, 52, 78, 'Very Good', '2020/2021', 1, 5, '1A', '2020-11-09 16:15:47', '2020/2021-1', 'Kessie123'),
(78, '51800440', 'ADAM.Gadaf', 'French', 26, 51, 77, 'Very Good', '2020/2021', 1, 1, '1A', '2020-11-09 16:15:47', '2020/2021-1', 'Kessie123'),
(79, 'DIT05170007', 'ADARKWAH Emmanuel', 'French', 28, 40, 68, 'Good', '2020/2021', 1, 18, '1A', '2020-11-09 16:15:47', '2020/2021-1', 'Kessie123'),
(80, '51800441', 'ADIKU OFORI.Harold', 'French', 28, 34, 62, 'Good', '2020/2021', 1, 21, '1A', '2020-11-09 16:15:47', '2020/2021-1', 'Kessie123'),
(81, '51800442', 'ADJEI.Anthony Clifford', 'French', 27, 48, 75, 'Very Good', '2020/2021', 1, 15, '1A', '2020-11-09 16:15:47', '2020/2021-1', 'Kessie123'),
(82, '51800444', 'ADOMAKO.Eric', 'French', 26, 36, 62, 'Good', '2020/2021', 1, 16, '1A', '2020-11-09 16:15:47', '2020/2021-1', 'Kessie123'),
(83, '51800443', 'ADOMAKO.Prince', 'French', 26, 52, 78, 'Very Good', '2020/2021', 1, 3, '1A', '2020-11-09 16:15:47', '2020/2021-1', 'Kessie123'),
(84, '51800445', 'AGYAPONG.Alexander', 'French', 26, 27, 53, 'Pass', '2020/2021', 1, 22, '1A', '2020-11-09 16:15:47', '2020/2021-1', 'Kessie123'),
(85, '51800446', 'AGYEKUM.Ernest Tabi', 'French', 28, 53, 81, 'Excellent', '2020/2021', 1, 2, '1A', '2020-11-09 16:15:47', '2020/2021-1', 'Kessie123'),
(86, 'DIT05170099', 'AHIABLE Victoria', 'French', 29, 44, 73, 'Very Good', '2020/2021', 1, 8, '1A', '2020-11-09 16:15:47', '2020/2021-1', 'Kessie123'),
(87, '51800447', 'AHMED.Saeed', 'French', 27, 46, 73, 'Very Good', '2020/2021', 1, 10, '1A', '2020-11-09 16:15:47', '2020/2021-1', 'Kessie123'),
(88, '51800448', 'AIDOO.Grace', 'French', 31, 45, 76, 'Very Good', '2020/2021', 1, 13, '1A', '2020-11-09 16:15:47', '2020/2021-1', 'Kessie123'),
(89, '51800449', 'ALHASSAN.Faruq', 'French', 26, 41, 67, 'Good', '2020/2021', 1, 20, '1A', '2020-11-09 16:15:47', '2020/2021-1', 'Kessie123'),
(90, 'DWD05170001', 'AMOAH Gyamfuaah Ellen', 'French', 28, 41, 69, 'Good', '2020/2021', 1, 12, '1A', '2020-11-09 16:15:47', '2020/2021-1', 'Kessie123'),
(91, '51800450', 'ANOKYE.Phinehas Boakye', 'French', 29, 49, 78, 'Very Good', '2020/2021', 1, 11, '1A', '2020-11-09 16:15:47', '2020/2021-1', 'Kessie123'),
(92, '51800451', 'ANSAH.Alfred', 'French', 26, 50, 76, 'Very Good', '2020/2021', 1, 6, '1A', '2020-11-09 16:15:48', '2020/2021-1', 'Kessie123'),
(93, 'DIT05170023', 'ANTWI Boasiako Kwame', 'French', 28, 43, 71, 'Very Good', '2020/2021', 1, 9, '1A', '2020-11-09 16:15:48', '2020/2021-1', 'Kessie123'),
(94, '51800452', 'ANTWI.Addai Dickson', 'French', 26, 38, 64, 'Good', '2020/2021', 1, 19, '1A', '2020-11-09 16:15:48', '2020/2021-1', 'Kessie123'),
(95, 'st123', 'KESSIE.Bismark', 'Integrated Science', 26, 34, 60, 'Good', '2020/2021', 1, 1, '1A', '2020-11-09 16:16:19', '2020/2021-1', 'Kessie123'),
(96, '51800437', 'ABBAS. Abdul-Karim', 'Integrated Science', 26, 46, 72, 'Very Good', '2020/2021', 1, 2, '1A', '2020-11-09 16:16:19', '2020/2021-1', 'Kessie123'),
(97, '51800438', 'ABDUL GANIYU.Sadick', 'Integrated Science', 26, 46, 72, 'Very Good', '2020/2021', 1, 9, '1A', '2020-11-09 16:16:19', '2020/2021-1', 'Kessie123'),
(98, 'DIT05170011', 'ABDUL-Malik Firdaus', 'Integrated Science', 26, 47, 73, 'Very Good', '2020/2021', 1, 7, '1A', '2020-11-09 16:16:19', '2020/2021-1', 'Kessie123'),
(99, '51800439', 'ABUBAKAR.Farouk', 'Integrated Science', 26, 52, 78, 'Very Good', '2020/2021', 1, 10, '1A', '2020-11-09 16:16:19', '2020/2021-1', 'Kessie123'),
(100, '51800440', 'ADAM.Gadaf', 'Integrated Science', 26, 51, 77, 'Very Good', '2020/2021', 1, 18, '1A', '2020-11-09 16:16:19', '2020/2021-1', 'Kessie123'),
(101, 'DIT05170007', 'ADARKWAH Emmanuel', 'Integrated Science', 28, 40, 68, 'Good', '2020/2021', 1, 15, '1A', '2020-11-09 16:16:19', '2020/2021-1', 'Kessie123'),
(102, '51800441', 'ADIKU OFORI.Harold', 'Integrated Science', 28, 34, 62, 'Good', '2020/2021', 1, 12, '1A', '2020-11-09 16:16:19', '2020/2021-1', 'Kessie123'),
(103, '51800442', 'ADJEI.Anthony Clifford', 'Integrated Science', 27, 48, 75, 'Very Good', '2020/2021', 1, 13, '1A', '2020-11-09 16:16:19', '2020/2021-1', 'Kessie123'),
(104, '51800444', 'ADOMAKO.Eric', 'Integrated Science', 26, 36, 62, 'Good', '2020/2021', 1, 6, '1A', '2020-11-09 16:16:19', '2020/2021-1', 'Kessie123'),
(105, '51800443', 'ADOMAKO.Prince', 'Integrated Science', 26, 52, 78, 'Very Good', '2020/2021', 1, 5, '1A', '2020-11-09 16:16:19', '2020/2021-1', 'Kessie123'),
(106, '51800445', 'AGYAPONG.Alexander', 'Integrated Science', 26, 27, 53, 'Pass', '2020/2021', 1, 19, '1A', '2020-11-09 16:16:19', '2020/2021-1', 'Kessie123'),
(107, '51800446', 'AGYEKUM.Ernest Tabi', 'Integrated Science', 28, 53, 81, 'Excellent', '2020/2021', 1, 3, '1A', '2020-11-09 16:16:19', '2020/2021-1', 'Kessie123'),
(108, 'DIT05170099', 'AHIABLE Victoria', 'Integrated Science', 29, 44, 73, 'Very Good', '2020/2021', 1, 8, '1A', '2020-11-09 16:16:19', '2020/2021-1', 'Kessie123'),
(109, '51800447', 'AHMED.Saeed', 'Integrated Science', 27, 46, 73, 'Very Good', '2020/2021', 1, 14, '1A', '2020-11-09 16:16:19', '2020/2021-1', 'Kessie123'),
(110, '51800448', 'AIDOO.Grace', 'Integrated Science', 31, 45, 76, 'Very Good', '2020/2021', 1, 20, '1A', '2020-11-09 16:16:19', '2020/2021-1', 'Kessie123'),
(111, '51800449', 'ALHASSAN.Faruq', 'Integrated Science', 26, 41, 67, 'Good', '2020/2021', 1, 16, '1A', '2020-11-09 16:16:19', '2020/2021-1', 'Kessie123'),
(112, 'DWD05170001', 'AMOAH Gyamfuaah Ellen', 'Integrated Science', 28, 41, 69, 'Good', '2020/2021', 1, 4, '1A', '2020-11-09 16:16:19', '2020/2021-1', 'Kessie123'),
(113, '51800450', 'ANOKYE.Phinehas Boakye', 'Integrated Science', 29, 49, 78, 'Very Good', '2020/2021', 1, 11, '1A', '2020-11-09 16:16:19', '2020/2021-1', 'Kessie123'),
(114, '51800451', 'ANSAH.Alfred', 'Integrated Science', 26, 50, 76, 'Very Good', '2020/2021', 1, 17, '1A', '2020-11-09 16:16:19', '2020/2021-1', 'Kessie123'),
(115, 'DIT05170023', 'ANTWI Boasiako Kwame', 'Integrated Science', 28, 43, 71, 'Very Good', '2020/2021', 1, 21, '1A', '2020-11-09 16:16:19', '2020/2021-1', 'Kessie123'),
(116, '51800452', 'ANTWI.Addai Dickson', 'Integrated Science', 26, 38, 64, 'Good', '2020/2021', 1, 22, '1A', '2020-11-09 16:16:19', '2020/2021-1', 'Kessie123'),
(117, 'st123', 'KESSIE.Bismark', 'Math', 26, 34, 60, 'Good', '2020/2021', 1, 3, '1A', '2020-11-09 16:16:50', '2020/2021-1', 'Kessie123'),
(118, '51800437', 'ABBAS. Abdul-Karim', 'Math', 26, 46, 72, 'Very Good', '2020/2021', 1, 1, '1A', '2020-11-09 16:16:50', '2020/2021-1', 'Kessie123'),
(119, '51800438', 'ABDUL GANIYU.Sadick', 'Math', 26, 46, 72, 'Very Good', '2020/2021', 1, 9, '1A', '2020-11-09 16:16:50', '2020/2021-1', 'Kessie123'),
(120, 'DIT05170011', 'ABDUL-Malik Firdaus', 'Math', 26, 47, 73, 'Very Good', '2020/2021', 1, 6, '1A', '2020-11-09 16:16:50', '2020/2021-1', 'Kessie123'),
(121, '51800439', 'ABUBAKAR.Farouk', 'Math', 26, 52, 78, 'Very Good', '2020/2021', 1, 10, '1A', '2020-11-09 16:16:50', '2020/2021-1', 'Kessie123'),
(122, '51800440', 'ADAM.Gadaf', 'Math', 26, 51, 77, 'Very Good', '2020/2021', 1, 16, '1A', '2020-11-09 16:16:50', '2020/2021-1', 'Kessie123'),
(123, 'DIT05170007', 'ADARKWAH Emmanuel', 'Math', 28, 40, 68, 'Good', '2020/2021', 1, 13, '1A', '2020-11-09 16:16:50', '2020/2021-1', 'Kessie123'),
(124, '51800441', 'ADIKU OFORI.Harold', 'Math', 28, 34, 62, 'Good', '2020/2021', 1, 12, '1A', '2020-11-09 16:16:50', '2020/2021-1', 'Kessie123'),
(125, '51800442', 'ADJEI.Anthony Clifford', 'Math', 27, 48, 75, 'Very Good', '2020/2021', 1, 14, '1A', '2020-11-09 16:16:50', '2020/2021-1', 'Kessie123'),
(126, '51800444', 'ADOMAKO.Eric', 'Math', 26, 36, 62, 'Good', '2020/2021', 1, 4, '1A', '2020-11-09 16:16:50', '2020/2021-1', 'Kessie123'),
(127, '51800443', 'ADOMAKO.Prince', 'Math', 26, 52, 78, 'Very Good', '2020/2021', 1, 5, '1A', '2020-11-09 16:16:50', '2020/2021-1', 'Kessie123'),
(128, '51800445', 'AGYAPONG.Alexander', 'Math', 26, 27, 53, 'Pass', '2020/2021', 1, 17, '1A', '2020-11-09 16:16:50', '2020/2021-1', 'Kessie123'),
(129, '51800446', 'AGYEKUM.Ernest Tabi', 'Math', 28, 53, 81, 'Excellent', '2020/2021', 1, 2, '1A', '2020-11-09 16:16:50', '2020/2021-1', 'Kessie123'),
(130, 'DIT05170099', 'AHIABLE Victoria', 'Math', 29, 44, 73, 'Very Good', '2020/2021', 1, 8, '1A', '2020-11-09 16:16:50', '2020/2021-1', 'Kessie123'),
(131, '51800447', 'AHMED.Saeed', 'Math', 27, 46, 73, 'Very Good', '2020/2021', 1, 15, '1A', '2020-11-09 16:16:50', '2020/2021-1', 'Kessie123'),
(132, '51800448', 'AIDOO.Grace', 'Math', 31, 45, 76, 'Very Good', '2020/2021', 1, 22, '1A', '2020-11-09 16:16:50', '2020/2021-1', 'Kessie123'),
(133, '51800449', 'ALHASSAN.Faruq', 'Math', 26, 41, 67, 'Good', '2020/2021', 1, 20, '1A', '2020-11-09 16:16:50', '2020/2021-1', 'Kessie123'),
(134, 'DWD05170001', 'AMOAH Gyamfuaah Ellen', 'Math', 28, 41, 69, 'Good', '2020/2021', 1, 7, '1A', '2020-11-09 16:16:50', '2020/2021-1', 'Kessie123'),
(135, '51800450', 'ANOKYE.Phinehas Boakye', 'Math', 29, 49, 78, 'Very Good', '2020/2021', 1, 11, '1A', '2020-11-09 16:16:50', '2020/2021-1', 'Kessie123'),
(136, '51800451', 'ANSAH.Alfred', 'Math', 26, 50, 76, 'Very Good', '2020/2021', 1, 18, '1A', '2020-11-09 16:16:50', '2020/2021-1', 'Kessie123'),
(137, 'DIT05170023', 'ANTWI Boasiako Kwame', 'Math', 28, 43, 71, 'Very Good', '2020/2021', 1, 21, '1A', '2020-11-09 16:16:51', '2020/2021-1', 'Kessie123'),
(138, '51800452', 'ANTWI.Addai Dickson', 'Math', 26, 38, 64, 'Good', '2020/2021', 1, 19, '1A', '2020-11-09 16:16:51', '2020/2021-1', 'Kessie123'),
(139, 'st123', 'KESSIE.Bismark', 'Social Studies', 26, 34, 60, 'Good', '2020/2021', 1, 4, '1A', '2020-11-09 16:17:21', '2020/2021-1', 'Kessie123'),
(140, '51800437', 'ABBAS. Abdul-Karim', 'Social Studies', 26, 46, 72, 'Very Good', '2020/2021', 1, 1, '1A', '2020-11-09 16:17:21', '2020/2021-1', 'Kessie123'),
(141, '51800438', 'ABDUL GANIYU.Sadick', 'Social Studies', 26, 46, 72, 'Very Good', '2020/2021', 1, 13, '1A', '2020-11-09 16:17:21', '2020/2021-1', 'Kessie123'),
(142, 'DIT05170011', 'ABDUL-Malik Firdaus', 'Social Studies', 26, 47, 73, 'Very Good', '2020/2021', 1, 3, '1A', '2020-11-09 16:17:21', '2020/2021-1', 'Kessie123'),
(143, '51800439', 'ABUBAKAR.Farouk', 'Social Studies', 26, 52, 78, 'Very Good', '2020/2021', 1, 8, '1A', '2020-11-09 16:17:21', '2020/2021-1', 'Kessie123'),
(144, '51800440', 'ADAM.Gadaf', 'Social Studies', 26, 51, 77, 'Very Good', '2020/2021', 1, 17, '1A', '2020-11-09 16:17:21', '2020/2021-1', 'Kessie123'),
(145, 'DIT05170007', 'ADARKWAH Emmanuel', 'Social Studies', 28, 40, 68, 'Good', '2020/2021', 1, 15, '1A', '2020-11-09 16:17:21', '2020/2021-1', 'Kessie123'),
(146, '51800441', 'ADIKU OFORI.Harold', 'Social Studies', 28, 34, 62, 'Good', '2020/2021', 1, 9, '1A', '2020-11-09 16:17:21', '2020/2021-1', 'Kessie123'),
(147, '51800442', 'ADJEI.Anthony Clifford', 'Social Studies', 27, 48, 75, 'Very Good', '2020/2021', 1, 10, '1A', '2020-11-09 16:17:21', '2020/2021-1', 'Kessie123'),
(148, '51800444', 'ADOMAKO.Eric', 'Social Studies', 26, 36, 62, 'Good', '2020/2021', 1, 11, '1A', '2020-11-09 16:17:21', '2020/2021-1', 'Kessie123'),
(149, '51800443', 'ADOMAKO.Prince', 'Social Studies', 26, 52, 78, 'Very Good', '2020/2021', 1, 5, '1A', '2020-11-09 16:17:21', '2020/2021-1', 'Kessie123'),
(150, '51800445', 'AGYAPONG.Alexander', 'Social Studies', 26, 27, 53, 'Pass', '2020/2021', 1, 19, '1A', '2020-11-09 16:17:21', '2020/2021-1', 'Kessie123'),
(151, '51800446', 'AGYEKUM.Ernest Tabi', 'Social Studies', 28, 53, 81, 'Excellent', '2020/2021', 1, 2, '1A', '2020-11-09 16:17:21', '2020/2021-1', 'Kessie123'),
(152, 'DIT05170099', 'AHIABLE Victoria', 'Social Studies', 29, 44, 73, 'Very Good', '2020/2021', 1, 6, '1A', '2020-11-09 16:17:21', '2020/2021-1', 'Kessie123'),
(153, '51800447', 'AHMED.Saeed', 'Social Studies', 27, 46, 73, 'Very Good', '2020/2021', 1, 14, '1A', '2020-11-09 16:17:21', '2020/2021-1', 'Kessie123'),
(154, '51800448', 'AIDOO.Grace', 'Social Studies', 31, 45, 76, 'Very Good', '2020/2021', 1, 16, '1A', '2020-11-09 16:17:21', '2020/2021-1', 'Kessie123'),
(155, '51800449', 'ALHASSAN.Faruq', 'Social Studies', 26, 41, 67, 'Good', '2020/2021', 1, 18, '1A', '2020-11-09 16:17:21', '2020/2021-1', 'Kessie123'),
(156, 'DWD05170001', 'AMOAH Gyamfuaah Ellen', 'Social Studies', 28, 41, 69, 'Good', '2020/2021', 1, 7, '1A', '2020-11-09 16:17:21', '2020/2021-1', 'Kessie123'),
(157, '51800450', 'ANOKYE.Phinehas Boakye', 'Social Studies', 29, 49, 78, 'Very Good', '2020/2021', 1, 12, '1A', '2020-11-09 16:17:21', '2020/2021-1', 'Kessie123'),
(158, '51800451', 'ANSAH.Alfred', 'Social Studies', 26, 50, 76, 'Very Good', '2020/2021', 1, 20, '1A', '2020-11-09 16:17:21', '2020/2021-1', 'Kessie123'),
(159, 'DIT05170023', 'ANTWI Boasiako Kwame', 'Social Studies', 28, 43, 71, 'Very Good', '2020/2021', 1, 21, '1A', '2020-11-09 16:17:21', '2020/2021-1', 'Kessie123'),
(160, '51800452', 'ANTWI.Addai Dickson', 'Social Studies', 26, 38, 64, 'Good', '2020/2021', 1, 22, '1A', '2020-11-09 16:17:21', '2020/2021-1', 'Kessie123'),
(161, 'st123', 'KESSIE.Bismark', 'Twi', 26, 34, 60, 'Good', '2020/2021', 1, 20, '1A', '2020-11-09 16:17:41', '2020/2021-1', 'Kessie123'),
(162, '51800437', 'ABBAS. Abdul-Karim', 'Twi', 26, 46, 72, 'Very Good', '2020/2021', 1, 7, '1A', '2020-11-09 16:17:41', '2020/2021-1', 'Kessie123'),
(163, '51800438', 'ABDUL GANIYU.Sadick', 'Twi', 26, 46, 72, 'Very Good', '2020/2021', 1, 9, '1A', '2020-11-09 16:17:41', '2020/2021-1', 'Kessie123'),
(164, 'DIT05170011', 'ABDUL-Malik Firdaus', 'Twi', 26, 47, 73, 'Very Good', '2020/2021', 1, 4, '1A', '2020-11-09 16:17:41', '2020/2021-1', 'Kessie123'),
(165, '51800439', 'ABUBAKAR.Farouk', 'Twi', 26, 52, 78, 'Very Good', '2020/2021', 1, 5, '1A', '2020-11-09 16:17:41', '2020/2021-1', 'Kessie123'),
(166, '51800440', 'ADAM.Gadaf', 'Twi', 26, 51, 77, 'Very Good', '2020/2021', 1, 3, '1A', '2020-11-09 16:17:41', '2020/2021-1', 'Kessie123'),
(167, 'DIT05170007', 'ADARKWAH Emmanuel', 'Twi', 28, 40, 68, 'Good', '2020/2021', 1, 18, '1A', '2020-11-09 16:17:41', '2020/2021-1', 'Kessie123'),
(168, '51800441', 'ADIKU OFORI.Harold', 'Twi', 28, 34, 62, 'Good', '2020/2021', 1, 21, '1A', '2020-11-09 16:17:41', '2020/2021-1', 'Kessie123'),
(169, '51800442', 'ADJEI.Anthony Clifford', 'Twi', 27, 48, 75, 'Very Good', '2020/2021', 1, 15, '1A', '2020-11-09 16:17:41', '2020/2021-1', 'Kessie123'),
(170, '51800444', 'ADOMAKO.Eric', 'Twi', 26, 36, 62, 'Good', '2020/2021', 1, 19, '1A', '2020-11-09 16:17:41', '2020/2021-1', 'Kessie123'),
(171, '51800443', 'ADOMAKO.Prince', 'Twi', 26, 52, 78, 'Very Good', '2020/2021', 1, 1, '1A', '2020-11-09 16:17:41', '2020/2021-1', 'Kessie123'),
(172, '51800445', 'AGYAPONG.Alexander', 'Twi', 26, 27, 53, 'Pass', '2020/2021', 1, 22, '1A', '2020-11-09 16:17:41', '2020/2021-1', 'Kessie123'),
(173, '51800446', 'AGYEKUM.Ernest Tabi', 'Twi', 28, 53, 81, 'Excellent', '2020/2021', 1, 2, '1A', '2020-11-09 16:17:41', '2020/2021-1', 'Kessie123'),
(174, 'DIT05170099', 'AHIABLE Victoria', 'Twi', 29, 44, 73, 'Very Good', '2020/2021', 1, 10, '1A', '2020-11-09 16:17:41', '2020/2021-1', 'Kessie123'),
(175, '51800447', 'AHMED.Saeed', 'Twi', 27, 46, 73, 'Very Good', '2020/2021', 1, 12, '1A', '2020-11-09 16:17:41', '2020/2021-1', 'Kessie123'),
(176, '51800448', 'AIDOO.Grace', 'Twi', 31, 45, 76, 'Very Good', '2020/2021', 1, 8, '1A', '2020-11-09 16:17:41', '2020/2021-1', 'Kessie123'),
(177, '51800449', 'ALHASSAN.Faruq', 'Twi', 26, 41, 67, 'Good', '2020/2021', 1, 16, '1A', '2020-11-09 16:17:41', '2020/2021-1', 'Kessie123'),
(178, 'DWD05170001', 'AMOAH Gyamfuaah Ellen', 'Twi', 28, 41, 69, 'Good', '2020/2021', 1, 13, '1A', '2020-11-09 16:17:41', '2020/2021-1', 'Kessie123'),
(179, '51800450', 'ANOKYE.Phinehas Boakye', 'Twi', 29, 49, 78, 'Very Good', '2020/2021', 1, 11, '1A', '2020-11-09 16:17:41', '2020/2021-1', 'Kessie123'),
(180, '51800451', 'ANSAH.Alfred', 'Twi', 26, 50, 76, 'Very Good', '2020/2021', 1, 6, '1A', '2020-11-09 16:17:41', '2020/2021-1', 'Kessie123'),
(181, 'DIT05170023', 'ANTWI Boasiako Kwame', 'Twi', 28, 43, 71, 'Very Good', '2020/2021', 1, 14, '1A', '2020-11-09 16:17:41', '2020/2021-1', 'Kessie123'),
(182, '51800452', 'ANTWI.Addai Dickson', 'Twi', 26, 38, 64, 'Good', '2020/2021', 1, 17, '1A', '2020-11-09 16:17:41', '2020/2021-1', 'Kessie123'),
(981, 'DIT05170025', 'Antwi Vera', 'Creative Art', 23, 46, 69, 'Good', '2020/2021', 1, 20, '1C', '2020-11-09 19:25:54', '2020/2021-1', 'Kessie123'),
(980, '51800499', 'ZOTRA. Derrick', 'Creative Art', 25, 44, 69, 'Good', '2020/2021', 1, 21, '1C', '2020-11-09 19:25:54', '2020/2021-1', 'Kessie123'),
(978, '51800498', 'TRETU.Eric', 'Creative Art', 29, 27, 56, 'Pass', '2020/2021', 1, 29, '1C', '2020-11-09 19:25:54', '2020/2021-1', 'Kessie123'),
(977, '51800497', 'TETTEH.Emmanuel', 'Creative Art', 29, 52, 81, 'Excellent', '2020/2021', 1, 5, '1C', '2020-11-09 19:25:54', '2020/2021-1', 'Kessie123'),
(976, '51800496', 'SARPONG.Prince', 'Creative Art', 35, 36, 71, 'Very Good', '2020/2021', 1, 17, '1C', '2020-11-09 19:25:54', '2020/2021-1', 'Kessie123'),
(975, 'DIT05170092', 'SARPONG Kwabena', 'Creative Art', 28, 38, 66, 'Good', '2020/2021', 1, 23, '1C', '2020-11-09 19:25:54', '2020/2021-1', 'Kessie123'),
(974, '51800495', 'SARFO KANTANKA. Emmanuel', 'Creative Art', 35, 43, 78, 'Very Good', '2020/2021', 1, 7, '1C', '2020-11-09 19:25:54', '2020/2021-1', 'Kessie123'),
(973, 'DIT05170094', 'SALANI Latifa', 'Creative Art', 29, 50, 79, 'Very Good', '2020/2021', 1, 6, '1C', '2020-11-09 19:25:54', '2020/2021-1', 'Kessie123'),
(970, 'DIT05170084', 'OWUSU Roberto', 'Creative Art', 24, 41, 65, 'Good', '2020/2021', 1, 25, '1C', '2020-11-09 19:25:54', '2020/2021-1', 'Kessie123'),
(966, '51800492', 'OSEI.Dennis', 'Creative Art', 32, 53, 85, 'Excellent', '2020/2021', 1, 1, '1C', '2020-11-09 19:25:54', '2020/2021-1', 'Kessie123'),
(963, '51800489', 'OPPONG.Success Antwiwaa', 'Creative Art', 31, 36, 67, 'Good', '2020/2021', 1, 22, '1C', '2020-11-09 19:25:54', '2020/2021-1', 'Kessie123'),
(962, '51800486', 'OPOKU.Gyasi Edward', 'Creative Art', 27, 48, 75, 'Very Good', '2020/2021', 1, 11, '1C', '2020-11-09 19:25:54', '2020/2021-1', 'Kessie123'),
(960, '51800488', 'OPOKU.Emmanuel Junior', 'Creative Art', 33, 40, 73, 'Very Good', '2020/2021', 1, 14, '1C', '2020-11-09 19:25:54', '2020/2021-1', 'Kessie123'),
(957, '51802181', 'OCRAN Victor', 'Creative Art', 31, 47, 78, 'Very Good', '2020/2021', 1, 8, '1C', '2020-11-09 19:25:54', '2020/2021-1', 'Kessie123'),
(956, '51800483', 'OBODAI SAI.Edmund', 'Creative Art', 17, 46, 63, 'Good', '2020/2021', 1, 26, '1C', '2020-11-09 19:25:54', '2020/2021-1', 'Kessie123'),
(948, 'DIT05170071', 'MOHAMMED Jamal', 'Creative Art', 31, 38, 69, 'Good', '2020/2021', 1, 28, '1B', '2020-11-09 19:25:42', '2020/2021-1', 'Kessie123'),
(949, '51800476', 'MOHAMMED.Osman', 'Creative Art', 24, 34, 58, 'Pass', '2020/2021', 1, 38, '1B', '2020-11-09 19:25:42', '2020/2021-1', 'Kessie123'),
(950, '51800475', 'MOHAMMED.Yahaya Hafiz', 'Creative Art', 27, 46, 73, 'Very Good', '2020/2021', 1, 19, '1B', '2020-11-09 19:25:42', '2020/2021-1', 'Kessie123'),
(951, '51800478', 'MONTEL.Ray Lawson', 'Creative Art', 32, 46, 78, 'Very Good', '2020/2021', 1, 9, '1B', '2020-11-09 19:25:42', '2020/2021-1', 'Kessie123'),
(952, '51801905', 'MORNAH.Frank  Atouro', 'Creative Art', 26, 47, 73, 'Very Good', '2020/2021', 1, 20, '1B', '2020-11-09 19:25:42', '2020/2021-1', 'Kessie123'),
(953, '51800480', 'NKANSAH.Prince', 'Creative Art', 24, 52, 76, 'Very Good', '2020/2021', 1, 15, '1B', '2020-11-09 19:25:42', '2020/2021-1', 'Kessie123'),
(954, '51800482', 'NYANTAKYI.David', 'Creative Art', 29, 34, 63, 'Good', '2020/2021', 1, 27, '1C', '2020-11-09 19:25:54', '2020/2021-1', 'Kessie123'),
(285, 'DIT05170036', 'ASARE Philemon', 'French', 29, 34, 63, 'Good', '2020/2021', 1, 32, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(286, '51800453', 'ASARE.Clement', 'French', 25, 46, 71, 'Very Good', '2020/2021', 1, 8, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(287, '51800454', 'ASARE.Victor', 'French', 17, 46, 63, 'Good', '2020/2021', 1, 27, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(288, '51800455', 'ASOMANI.Williams', 'French', 31, 47, 78, 'Very Good', '2020/2021', 1, 4, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(289, '51800456', 'ATIAH.Peter Ayine', 'French', 32, 52, 84, 'Excellent', '2020/2021', 1, 6, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(290, 'DIT05170039', 'AYILGIA Desmond', 'French', 34, 51, 85, 'Excellent', '2020/2021', 1, 1, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(291, '51800457', 'AZIAH.Daniel', 'French', 33, 40, 73, 'Very Good', '2020/2021', 1, 33, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(292, '51800458', 'BAAH.Desmond', 'French', 32, 34, 66, 'Good', '2020/2021', 1, 38, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(293, '51800459', 'BINEY.Kish Daniel', 'French', 27, 48, 75, 'Very Good', '2020/2021', 1, 28, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(294, '51800460', 'BLAY.Goka Simon', 'French', 31, 36, 67, 'Good', '2020/2021', 1, 29, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(295, '51800461', 'BOAHENE.Prince', 'French', 26, 52, 78, 'Very Good', '2020/2021', 1, 3, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(296, '51800462', 'BOAKYE AGYEMANG.Jnr Mensah', 'French', 30, 27, 57, 'Pass', '2020/2021', 1, 40, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(297, 'DHN05170004', 'BOAKYE Joel', 'French', 32, 53, 85, 'Excellent', '2020/2021', 1, 2, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(298, 'DIT05170049', 'BOATENG Asare', 'French', 27, 44, 71, 'Very Good', '2020/2021', 1, 9, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(299, '51800463', 'BOATENG.Bismark', 'French', 28, 46, 74, 'Very Good', '2020/2021', 1, 14, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(300, '51800464', 'BORLABI.Godfred Borketey', 'French', 27, 45, 72, 'Very Good', '2020/2021', 1, 23, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(301, '51800465', 'BREFO.Daniel', 'French', 24, 41, 65, 'Good', '2020/2021', 1, 37, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(302, '51800466', 'BRONI.Jephter', 'French', 32, 41, 73, 'Very Good', '2020/2021', 1, 21, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(303, '51800467', 'BUDU.Charles', 'French', 28, 49, 77, 'Very Good', '2020/2021', 1, 15, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(304, '51800468', 'CUDJOE.Joseph', 'French', 29, 50, 79, 'Very Good', '2020/2021', 1, 7, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(305, '51800469', 'DAISSIE.Gladys', 'French', 35, 43, 78, 'Very Good', '2020/2021', 1, 10, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(306, '51800470', 'DAYYAN.Issahaku', 'French', 28, 38, 66, 'Good', '2020/2021', 1, 35, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(307, 'DIT05170026', 'ELLIOT Gyamfi Anyankwah', 'French', 35, 36, 71, 'Very Good', '2020/2021', 1, 25, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(308, '51800471', 'FAISAL.Halid Dene', 'French', 29, 52, 81, 'Excellent', '2020/2021', 1, 17, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(309, 'DIT05170058', 'GIBRINE Adiza Adamu', 'French', 29, 27, 56, 'Pass', '2020/2021', 1, 39, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(310, '51800472', 'GYETUA DANQUAH.Richmond', 'French', 31, 53, 84, 'Excellent', '2020/2021', 1, 11, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(311, '51800473', 'ISSAH.Abubakar Saddick', 'French', 25, 44, 69, 'Good', '2020/2021', 1, 24, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(312, 'DIT05170063', 'KARIM Nayiba', 'French', 23, 46, 69, 'Good', '2020/2021', 1, 30, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(313, 'DIT05170065', 'KONADU Obed', 'French', 30, 45, 75, 'Very Good', '2020/2021', 1, 16, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(314, 'DIT05170068', 'LARBI Wilson Nana Yaw', 'French', 37, 41, 78, 'Very Good', '2020/2021', 1, 18, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(315, '51800474', 'MENSAH ABRAMPAH.Shadrack', 'French', 27, 41, 68, 'Good', '2020/2021', 1, 19, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(316, 'DIT05170067', 'MICHAEL Agyapong Kwarteng', 'French', 30, 49, 79, 'Very Good', '2020/2021', 1, 12, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(317, 'DIT05170013', 'MICHAEL Bota Afrifa', 'French', 31, 50, 81, 'Excellent', '2020/2021', 1, 5, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(318, '51800477', 'MOHAMMED ISHMAIL.Shariff', 'French', 30, 43, 73, 'Very Good', '2020/2021', 1, 31, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(319, 'DIT05170071', 'MOHAMMED Jamal', 'French', 31, 38, 69, 'Good', '2020/2021', 1, 34, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(320, '51800476', 'MOHAMMED.Osman', 'French', 24, 34, 58, 'Pass', '2020/2021', 1, 36, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(321, '51800475', 'MOHAMMED.Yahaya Hafiz', 'French', 27, 46, 73, 'Very Good', '2020/2021', 1, 22, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(322, '51800478', 'MONTEL.Ray Lawson', 'French', 32, 46, 78, 'Very Good', '2020/2021', 1, 20, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(323, '51801905', 'MORNAH.Frank  Atouro', 'French', 26, 47, 73, 'Very Good', '2020/2021', 1, 26, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(324, '51800480', 'NKANSAH.Prince', 'French', 24, 52, 76, 'Very Good', '2020/2021', 1, 13, '1B', '2020-11-09 16:20:34', '2020/2021-1', 'Kessie123'),
(325, 'DIT05170036', 'ASARE Philemon', 'Integrated Science', 29, 34, 63, 'Good', '2020/2021', 1, 1, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(326, '51800453', 'ASARE.Clement', 'Integrated Science', 25, 46, 71, 'Very Good', '2020/2021', 1, 4, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(327, '51800454', 'ASARE.Victor', 'Integrated Science', 17, 46, 63, 'Good', '2020/2021', 1, 15, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(328, '51800455', 'ASOMANI.Williams', 'Integrated Science', 31, 47, 78, 'Very Good', '2020/2021', 1, 9, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(329, '51800456', 'ATIAH.Peter Ayine', 'Integrated Science', 32, 52, 84, 'Excellent', '2020/2021', 1, 21, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(330, 'DIT05170039', 'AYILGIA Desmond', 'Integrated Science', 34, 51, 85, 'Excellent', '2020/2021', 1, 34, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(331, '51800457', 'AZIAH.Daniel', 'Integrated Science', 33, 40, 73, 'Very Good', '2020/2021', 1, 35, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(332, '51800458', 'BAAH.Desmond', 'Integrated Science', 32, 34, 66, 'Good', '2020/2021', 1, 27, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(333, '51800459', 'BINEY.Kish Daniel', 'Integrated Science', 27, 48, 75, 'Very Good', '2020/2021', 1, 22, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(334, '51800460', 'BLAY.Goka Simon', 'Integrated Science', 31, 36, 67, 'Good', '2020/2021', 1, 5, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(335, '51800461', 'BOAHENE.Prince', 'Integrated Science', 26, 52, 78, 'Very Good', '2020/2021', 1, 6, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(336, '51800462', 'BOAKYE AGYEMANG.Jnr Mensah', 'Integrated Science', 30, 27, 57, 'Pass', '2020/2021', 1, 28, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(337, 'DHN05170004', 'BOAKYE Joel', 'Integrated Science', 32, 53, 85, 'Excellent', '2020/2021', 1, 2, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(338, 'DIT05170049', 'BOATENG Asare', 'Integrated Science', 27, 44, 71, 'Very Good', '2020/2021', 1, 10, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(339, '51800463', 'BOATENG.Bismark', 'Integrated Science', 28, 46, 74, 'Very Good', '2020/2021', 1, 31, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(340, '51800464', 'BORLABI.Godfred Borketey', 'Integrated Science', 27, 45, 72, 'Very Good', '2020/2021', 1, 38, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(341, '51800465', 'BREFO.Daniel', 'Integrated Science', 24, 41, 65, 'Good', '2020/2021', 1, 29, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(342, '51800466', 'BRONI.Jephter', 'Integrated Science', 32, 41, 73, 'Very Good', '2020/2021', 1, 3, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(343, '51800467', 'BUDU.Charles', 'Integrated Science', 28, 49, 77, 'Very Good', '2020/2021', 1, 18, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(344, '51800468', 'CUDJOE.Joseph', 'Integrated Science', 29, 50, 79, 'Very Good', '2020/2021', 1, 25, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(345, '51800469', 'DAISSIE.Gladys', 'Integrated Science', 35, 43, 78, 'Very Good', '2020/2021', 1, 39, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(346, '51800470', 'DAYYAN.Issahaku', 'Integrated Science', 28, 38, 66, 'Good', '2020/2021', 1, 40, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(347, 'DIT05170026', 'ELLIOT Gyamfi Anyankwah', 'Integrated Science', 35, 36, 71, 'Very Good', '2020/2021', 1, 20, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(348, '51800471', 'FAISAL.Halid Dene', 'Integrated Science', 29, 52, 81, 'Excellent', '2020/2021', 1, 19, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(349, 'DIT05170058', 'GIBRINE Adiza Adamu', 'Integrated Science', 29, 27, 56, 'Pass', '2020/2021', 1, 17, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(350, '51800472', 'GYETUA DANQUAH.Richmond', 'Integrated Science', 31, 53, 84, 'Excellent', '2020/2021', 1, 11, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(351, '51800473', 'ISSAH.Abubakar Saddick', 'Integrated Science', 25, 44, 69, 'Good', '2020/2021', 1, 30, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(352, 'DIT05170063', 'KARIM Nayiba', 'Integrated Science', 23, 46, 69, 'Good', '2020/2021', 1, 12, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(353, 'DIT05170065', 'KONADU Obed', 'Integrated Science', 30, 45, 75, 'Very Good', '2020/2021', 1, 16, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(354, 'DIT05170068', 'LARBI Wilson Nana Yaw', 'Integrated Science', 37, 41, 78, 'Very Good', '2020/2021', 1, 23, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(355, '51800474', 'MENSAH ABRAMPAH.Shadrack', 'Integrated Science', 27, 41, 68, 'Good', '2020/2021', 1, 32, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(356, 'DIT05170067', 'MICHAEL Agyapong Kwarteng', 'Integrated Science', 30, 49, 79, 'Very Good', '2020/2021', 1, 26, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(357, 'DIT05170013', 'MICHAEL Bota Afrifa', 'Integrated Science', 31, 50, 81, 'Excellent', '2020/2021', 1, 14, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(358, '51800477', 'MOHAMMED ISHMAIL.Shariff', 'Integrated Science', 30, 43, 73, 'Very Good', '2020/2021', 1, 24, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(359, 'DIT05170071', 'MOHAMMED Jamal', 'Integrated Science', 31, 38, 69, 'Good', '2020/2021', 1, 37, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(360, '51800476', 'MOHAMMED.Osman', 'Integrated Science', 24, 34, 58, 'Pass', '2020/2021', 1, 33, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(361, '51800475', 'MOHAMMED.Yahaya Hafiz', 'Integrated Science', 27, 46, 73, 'Very Good', '2020/2021', 1, 36, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(362, '51800478', 'MONTEL.Ray Lawson', 'Integrated Science', 32, 46, 78, 'Very Good', '2020/2021', 1, 7, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(363, '51801905', 'MORNAH.Frank  Atouro', 'Integrated Science', 26, 47, 73, 'Very Good', '2020/2021', 1, 13, '1B', '2020-11-09 16:20:56', '2020/2021-1', 'Kessie123'),
(364, '51800480', 'NKANSAH.Prince', 'Integrated Science', 24, 52, 76, 'Very Good', '2020/2021', 1, 8, '1B', '2020-11-09 16:20:57', '2020/2021-1', 'Kessie123'),
(365, 'DIT05170036', 'ASARE Philemon', 'Math', 29, 34, 63, 'Good', '2020/2021', 1, 1, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(366, '51800453', 'ASARE.Clement', 'Math', 25, 46, 71, 'Very Good', '2020/2021', 1, 4, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(367, '51800454', 'ASARE.Victor', 'Math', 17, 46, 63, 'Good', '2020/2021', 1, 14, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(368, '51800455', 'ASOMANI.Williams', 'Math', 31, 47, 78, 'Very Good', '2020/2021', 1, 9, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(369, '51800456', 'ATIAH.Peter Ayine', 'Math', 32, 52, 84, 'Excellent', '2020/2021', 1, 16, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(370, 'DIT05170039', 'AYILGIA Desmond', 'Math', 34, 51, 85, 'Excellent', '2020/2021', 1, 37, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(371, '51800457', 'AZIAH.Daniel', 'Math', 33, 40, 73, 'Very Good', '2020/2021', 1, 38, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(372, '51800458', 'BAAH.Desmond', 'Math', 32, 34, 66, 'Good', '2020/2021', 1, 32, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(373, '51800459', 'BINEY.Kish Daniel', 'Math', 27, 48, 75, 'Very Good', '2020/2021', 1, 26, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(374, '51800460', 'BLAY.Goka Simon', 'Math', 31, 36, 67, 'Good', '2020/2021', 1, 5, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(375, '51800461', 'BOAHENE.Prince', 'Math', 26, 52, 78, 'Very Good', '2020/2021', 1, 7, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(376, '51800462', 'BOAKYE AGYEMANG.Jnr Mensah', 'Math', 30, 27, 57, 'Pass', '2020/2021', 1, 33, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(377, 'DHN05170004', 'BOAKYE Joel', 'Math', 32, 53, 85, 'Excellent', '2020/2021', 1, 2, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(378, 'DIT05170049', 'BOATENG Asare', 'Math', 27, 44, 71, 'Very Good', '2020/2021', 1, 11, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(379, '51800463', 'BOATENG.Bismark', 'Math', 28, 46, 74, 'Very Good', '2020/2021', 1, 36, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(380, '51800464', 'BORLABI.Godfred Borketey', 'Math', 27, 45, 72, 'Very Good', '2020/2021', 1, 39, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(381, '51800465', 'BREFO.Daniel', 'Math', 24, 41, 65, 'Good', '2020/2021', 1, 34, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(382, '51800466', 'BRONI.Jephter', 'Math', 32, 41, 73, 'Very Good', '2020/2021', 1, 3, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(383, '51800467', 'BUDU.Charles', 'Math', 28, 49, 77, 'Very Good', '2020/2021', 1, 21, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(384, '51800468', 'CUDJOE.Joseph', 'Math', 29, 50, 79, 'Very Good', '2020/2021', 1, 31, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(385, '51800469', 'DAISSIE.Gladys', 'Math', 35, 43, 78, 'Very Good', '2020/2021', 1, 40, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(386, '51800470', 'DAYYAN.Issahaku', 'Math', 28, 38, 66, 'Good', '2020/2021', 1, 17, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(387, 'DIT05170026', 'ELLIOT Gyamfi Anyankwah', 'Math', 35, 36, 71, 'Very Good', '2020/2021', 1, 6, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(388, '51800471', 'FAISAL.Halid Dene', 'Math', 29, 52, 81, 'Excellent', '2020/2021', 1, 18, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(389, 'DIT05170058', 'GIBRINE Adiza Adamu', 'Math', 29, 27, 56, 'Pass', '2020/2021', 1, 8, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(390, '51800472', 'GYETUA DANQUAH.Richmond', 'Math', 31, 53, 84, 'Excellent', '2020/2021', 1, 12, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(391, '51800473', 'ISSAH.Abubakar Saddick', 'Math', 25, 44, 69, 'Good', '2020/2021', 1, 30, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(392, 'DIT05170063', 'KARIM Nayiba', 'Math', 23, 46, 69, 'Good', '2020/2021', 1, 24, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(393, 'DIT05170065', 'KONADU Obed', 'Math', 30, 45, 75, 'Very Good', '2020/2021', 1, 25, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(394, 'DIT05170068', 'LARBI Wilson Nana Yaw', 'Math', 37, 41, 78, 'Very Good', '2020/2021', 1, 13, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(395, '51800474', 'MENSAH ABRAMPAH.Shadrack', 'Math', 27, 41, 68, 'Good', '2020/2021', 1, 27, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(396, 'DIT05170067', 'MICHAEL Agyapong Kwarteng', 'Math', 30, 49, 79, 'Very Good', '2020/2021', 1, 19, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(397, 'DIT05170013', 'MICHAEL Bota Afrifa', 'Math', 31, 50, 81, 'Excellent', '2020/2021', 1, 35, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(398, '51800477', 'MOHAMMED ISHMAIL.Shariff', 'Math', 30, 43, 73, 'Very Good', '2020/2021', 1, 10, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(399, 'DIT05170071', 'MOHAMMED Jamal', 'Math', 31, 38, 69, 'Good', '2020/2021', 1, 22, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(400, '51800476', 'MOHAMMED.Osman', 'Math', 24, 34, 58, 'Pass', '2020/2021', 1, 15, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(401, '51800475', 'MOHAMMED.Yahaya Hafiz', 'Math', 27, 46, 73, 'Very Good', '2020/2021', 1, 23, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(402, '51800478', 'MONTEL.Ray Lawson', 'Math', 32, 46, 78, 'Very Good', '2020/2021', 1, 28, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(403, '51801905', 'MORNAH.Frank  Atouro', 'Math', 26, 47, 73, 'Very Good', '2020/2021', 1, 20, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(404, '51800480', 'NKANSAH.Prince', 'Math', 24, 52, 76, 'Very Good', '2020/2021', 1, 29, '1B', '2020-11-09 16:21:19', '2020/2021-1', 'Kessie123'),
(405, 'DIT05170036', 'ASARE Philemon', 'Social Studies', 29, 34, 63, 'Good', '2020/2021', 1, 2, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(406, '51800453', 'ASARE.Clement', 'Social Studies', 25, 46, 71, 'Very Good', '2020/2021', 1, 3, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(407, '51800454', 'ASARE.Victor', 'Social Studies', 17, 46, 63, 'Good', '2020/2021', 1, 21, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(408, '51800455', 'ASOMANI.Williams', 'Social Studies', 31, 47, 78, 'Very Good', '2020/2021', 1, 6, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(409, '51800456', 'ATIAH.Peter Ayine', 'Social Studies', 32, 52, 84, 'Excellent', '2020/2021', 1, 18, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(410, 'DIT05170039', 'AYILGIA Desmond', 'Social Studies', 34, 51, 85, 'Excellent', '2020/2021', 1, 31, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(411, '51800457', 'AZIAH.Daniel', 'Social Studies', 33, 40, 73, 'Very Good', '2020/2021', 1, 27, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(412, '51800458', 'BAAH.Desmond', 'Social Studies', 32, 34, 66, 'Good', '2020/2021', 1, 23, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(413, '51800459', 'BINEY.Kish Daniel', 'Social Studies', 27, 48, 75, 'Very Good', '2020/2021', 1, 13, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(414, '51800460', 'BLAY.Goka Simon', 'Social Studies', 31, 36, 67, 'Good', '2020/2021', 1, 11, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(415, '51800461', 'BOAHENE.Prince', 'Social Studies', 26, 52, 78, 'Very Good', '2020/2021', 1, 9, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(416, '51800462', 'BOAKYE AGYEMANG.Jnr Mensah', 'Social Studies', 30, 27, 57, 'Pass', '2020/2021', 1, 32, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(417, 'DHN05170004', 'BOAKYE Joel', 'Social Studies', 32, 53, 85, 'Excellent', '2020/2021', 1, 1, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(418, 'DIT05170049', 'BOATENG Asare', 'Social Studies', 27, 44, 71, 'Very Good', '2020/2021', 1, 12, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(419, '51800463', 'BOATENG.Bismark', 'Social Studies', 28, 46, 74, 'Very Good', '2020/2021', 1, 24, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(420, '51800464', 'BORLABI.Godfred Borketey', 'Social Studies', 27, 45, 72, 'Very Good', '2020/2021', 1, 28, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(421, '51800465', 'BREFO.Daniel', 'Social Studies', 24, 41, 65, 'Good', '2020/2021', 1, 29, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(422, '51800466', 'BRONI.Jephter', 'Social Studies', 32, 41, 73, 'Very Good', '2020/2021', 1, 4, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(423, '51800467', 'BUDU.Charles', 'Social Studies', 28, 49, 77, 'Very Good', '2020/2021', 1, 19, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(424, '51800468', 'CUDJOE.Joseph', 'Social Studies', 29, 50, 79, 'Very Good', '2020/2021', 1, 30, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(425, '51800469', 'DAISSIE.Gladys', 'Social Studies', 35, 43, 78, 'Very Good', '2020/2021', 1, 34, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(426, '51800470', 'DAYYAN.Issahaku', 'Social Studies', 28, 38, 66, 'Good', '2020/2021', 1, 39, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(427, 'DIT05170026', 'ELLIOT Gyamfi Anyankwah', 'Social Studies', 35, 36, 71, 'Very Good', '2020/2021', 1, 17, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(428, '51800471', 'FAISAL.Halid Dene', 'Social Studies', 29, 52, 81, 'Excellent', '2020/2021', 1, 10, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(429, 'DIT05170058', 'GIBRINE Adiza Adamu', 'Social Studies', 29, 27, 56, 'Pass', '2020/2021', 1, 33, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(430, '51800472', 'GYETUA DANQUAH.Richmond', 'Social Studies', 31, 53, 84, 'Excellent', '2020/2021', 1, 7, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(431, '51800473', 'ISSAH.Abubakar Saddick', 'Social Studies', 25, 44, 69, 'Good', '2020/2021', 1, 16, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(432, 'DIT05170063', 'KARIM Nayiba', 'Social Studies', 23, 46, 69, 'Good', '2020/2021', 1, 22, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(433, 'DIT05170065', 'KONADU Obed', 'Social Studies', 30, 45, 75, 'Very Good', '2020/2021', 1, 38, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(434, 'DIT05170068', 'LARBI Wilson Nana Yaw', 'Social Studies', 37, 41, 78, 'Very Good', '2020/2021', 1, 35, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(435, '51800474', 'MENSAH ABRAMPAH.Shadrack', 'Social Studies', 27, 41, 68, 'Good', '2020/2021', 1, 20, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(436, 'DIT05170067', 'MICHAEL Agyapong Kwarteng', 'Social Studies', 30, 49, 79, 'Very Good', '2020/2021', 1, 25, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(437, 'DIT05170013', 'MICHAEL Bota Afrifa', 'Social Studies', 31, 50, 81, 'Excellent', '2020/2021', 1, 40, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(438, '51800477', 'MOHAMMED ISHMAIL.Shariff', 'Social Studies', 30, 43, 73, 'Very Good', '2020/2021', 1, 36, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(439, 'DIT05170071', 'MOHAMMED Jamal', 'Social Studies', 31, 38, 69, 'Good', '2020/2021', 1, 37, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(440, '51800476', 'MOHAMMED.Osman', 'Social Studies', 24, 34, 58, 'Pass', '2020/2021', 1, 26, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(441, '51800475', 'MOHAMMED.Yahaya Hafiz', 'Social Studies', 27, 46, 73, 'Very Good', '2020/2021', 1, 14, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(442, '51800478', 'MONTEL.Ray Lawson', 'Social Studies', 32, 46, 78, 'Very Good', '2020/2021', 1, 5, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(443, '51801905', 'MORNAH.Frank  Atouro', 'Social Studies', 26, 47, 73, 'Very Good', '2020/2021', 1, 15, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(444, '51800480', 'NKANSAH.Prince', 'Social Studies', 24, 52, 76, 'Very Good', '2020/2021', 1, 8, '1B', '2020-11-09 16:21:39', '2020/2021-1', 'Kessie123'),
(445, 'DIT05170036', 'ASARE Philemon', 'Twi', 29, 34, 63, 'Good', '2020/2021', 1, 36, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(446, '51800453', 'ASARE.Clement', 'Twi', 25, 46, 71, 'Very Good', '2020/2021', 1, 25, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(447, '51800454', 'ASARE.Victor', 'Twi', 17, 46, 63, 'Good', '2020/2021', 1, 37, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(448, '51800455', 'ASOMANI.Williams', 'Twi', 31, 47, 78, 'Very Good', '2020/2021', 1, 9, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(449, '51800456', 'ATIAH.Peter Ayine', 'Twi', 32, 52, 84, 'Excellent', '2020/2021', 1, 3, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(450, 'DIT05170039', 'AYILGIA Desmond', 'Twi', 34, 51, 85, 'Excellent', '2020/2021', 1, 1, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(451, '51800457', 'AZIAH.Daniel', 'Twi', 33, 40, 73, 'Very Good', '2020/2021', 1, 19, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(452, '51800458', 'BAAH.Desmond', 'Twi', 32, 34, 66, 'Good', '2020/2021', 1, 33, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(453, '51800459', 'BINEY.Kish Daniel', 'Twi', 27, 48, 75, 'Very Good', '2020/2021', 1, 16, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(454, '51800460', 'BLAY.Goka Simon', 'Twi', 31, 36, 67, 'Good', '2020/2021', 1, 32, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(455, '51800461', 'BOAHENE.Prince', 'Twi', 26, 52, 78, 'Very Good', '2020/2021', 1, 10, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(456, '51800462', 'BOAKYE AGYEMANG.Jnr Mensah', 'Twi', 30, 27, 57, 'Pass', '2020/2021', 1, 39, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(457, 'DHN05170004', 'BOAKYE Joel', 'Twi', 32, 53, 85, 'Excellent', '2020/2021', 1, 2, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(458, 'DIT05170049', 'BOATENG Asare', 'Twi', 27, 44, 71, 'Very Good', '2020/2021', 1, 26, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(459, '51800463', 'BOATENG.Bismark', 'Twi', 28, 46, 74, 'Very Good', '2020/2021', 1, 18, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(460, '51800464', 'BORLABI.Godfred Borketey', 'Twi', 27, 45, 72, 'Very Good', '2020/2021', 1, 24, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(461, '51800465', 'BREFO.Daniel', 'Twi', 24, 41, 65, 'Good', '2020/2021', 1, 35, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(462, '51800466', 'BRONI.Jephter', 'Twi', 32, 41, 73, 'Very Good', '2020/2021', 1, 20, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(463, '51800467', 'BUDU.Charles', 'Twi', 28, 49, 77, 'Very Good', '2020/2021', 1, 14, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(464, '51800468', 'CUDJOE.Joseph', 'Twi', 29, 50, 79, 'Very Good', '2020/2021', 1, 7, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(465, '51800469', 'DAISSIE.Gladys', 'Twi', 35, 43, 78, 'Very Good', '2020/2021', 1, 11, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(466, '51800470', 'DAYYAN.Issahaku', 'Twi', 28, 38, 66, 'Good', '2020/2021', 1, 34, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(467, 'DIT05170026', 'ELLIOT Gyamfi Anyankwah', 'Twi', 35, 36, 71, 'Very Good', '2020/2021', 1, 27, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(468, '51800471', 'FAISAL.Halid Dene', 'Twi', 29, 52, 81, 'Excellent', '2020/2021', 1, 5, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(469, 'DIT05170058', 'GIBRINE Adiza Adamu', 'Twi', 29, 27, 56, 'Pass', '2020/2021', 1, 40, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(470, '51800472', 'GYETUA DANQUAH.Richmond', 'Twi', 31, 53, 84, 'Excellent', '2020/2021', 1, 4, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(471, '51800473', 'ISSAH.Abubakar Saddick', 'Twi', 25, 44, 69, 'Good', '2020/2021', 1, 28, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(472, 'DIT05170063', 'KARIM Nayiba', 'Twi', 23, 46, 69, 'Good', '2020/2021', 1, 29, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(473, 'DIT05170065', 'KONADU Obed', 'Twi', 30, 45, 75, 'Very Good', '2020/2021', 1, 17, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(474, 'DIT05170068', 'LARBI Wilson Nana Yaw', 'Twi', 37, 41, 78, 'Very Good', '2020/2021', 1, 12, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(475, '51800474', 'MENSAH ABRAMPAH.Shadrack', 'Twi', 27, 41, 68, 'Good', '2020/2021', 1, 31, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(476, 'DIT05170067', 'MICHAEL Agyapong Kwarteng', 'Twi', 30, 49, 79, 'Very Good', '2020/2021', 1, 8, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(477, 'DIT05170013', 'MICHAEL Bota Afrifa', 'Twi', 31, 50, 81, 'Excellent', '2020/2021', 1, 6, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(478, '51800477', 'MOHAMMED ISHMAIL.Shariff', 'Twi', 30, 43, 73, 'Very Good', '2020/2021', 1, 21, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(479, 'DIT05170071', 'MOHAMMED Jamal', 'Twi', 31, 38, 69, 'Good', '2020/2021', 1, 30, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(480, '51800476', 'MOHAMMED.Osman', 'Twi', 24, 34, 58, 'Pass', '2020/2021', 1, 38, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(481, '51800475', 'MOHAMMED.Yahaya Hafiz', 'Twi', 27, 46, 73, 'Very Good', '2020/2021', 1, 22, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123');
INSERT INTO `marks` (`ID`, `Student_ID`, `Name`, `Subject`, `Class_Score`, `Exams_Score`, `Total`, `Remark`, `Academic`, `Term`, `Position`, `Class`, `Date`, `d_grade`, `sid`) VALUES
(482, '51800478', 'MONTEL.Ray Lawson', 'Twi', 32, 46, 78, 'Very Good', '2020/2021', 1, 13, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(483, '51801905', 'MORNAH.Frank  Atouro', 'Twi', 26, 47, 73, 'Very Good', '2020/2021', 1, 23, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(484, '51800480', 'NKANSAH.Prince', 'Twi', 24, 52, 76, 'Very Good', '2020/2021', 1, 15, '1B', '2020-11-09 16:22:00', '2020/2021-1', 'Kessie123'),
(947, '51800477', 'MOHAMMED ISHMAIL.Shariff', 'Creative Art', 30, 43, 73, 'Very Good', '2020/2021', 1, 21, '1B', '2020-11-09 19:25:42', '2020/2021-1', 'Kessie123'),
(946, 'DIT05170013', 'MICHAEL Bota Afrifa', 'Creative Art', 31, 50, 81, 'Excellent', '2020/2021', 1, 5, '1B', '2020-11-09 19:25:41', '2020/2021-1', 'Kessie123'),
(944, '51800474', 'MENSAH ABRAMPAH.Shadrack', 'Creative Art', 27, 41, 68, 'Good', '2020/2021', 1, 31, '1B', '2020-11-09 19:25:41', '2020/2021-1', 'Kessie123'),
(943, 'DIT05170068', 'LARBI Wilson Nana Yaw', 'Creative Art', 37, 41, 78, 'Very Good', '2020/2021', 1, 10, '1B', '2020-11-09 19:25:41', '2020/2021-1', 'Kessie123'),
(942, 'DIT05170065', 'KONADU Obed', 'Creative Art', 30, 45, 75, 'Very Good', '2020/2021', 1, 16, '1B', '2020-11-09 19:25:41', '2020/2021-1', 'Kessie123'),
(941, 'DIT05170063', 'KARIM Nayiba', 'Creative Art', 23, 46, 69, 'Good', '2020/2021', 1, 29, '1B', '2020-11-09 19:25:41', '2020/2021-1', 'Kessie123'),
(940, '51800473', 'ISSAH.Abubakar Saddick', 'Creative Art', 25, 44, 69, 'Good', '2020/2021', 1, 30, '1B', '2020-11-09 19:25:41', '2020/2021-1', 'Kessie123'),
(939, '51800472', 'GYETUA DANQUAH.Richmond', 'Creative Art', 31, 53, 84, 'Excellent', '2020/2021', 1, 3, '1B', '2020-11-09 19:25:41', '2020/2021-1', 'Kessie123'),
(938, 'DIT05170058', 'GIBRINE Adiza Adamu', 'Creative Art', 29, 27, 56, 'Pass', '2020/2021', 1, 40, '1B', '2020-11-09 19:25:41', '2020/2021-1', 'Kessie123'),
(937, '51800471', 'FAISAL.Halid Dene', 'Creative Art', 29, 52, 81, 'Excellent', '2020/2021', 1, 6, '1B', '2020-11-09 19:25:41', '2020/2021-1', 'Kessie123'),
(936, 'DIT05170026', 'ELLIOT Gyamfi Anyankwah', 'Creative Art', 35, 36, 71, 'Very Good', '2020/2021', 1, 25, '1B', '2020-11-09 19:25:41', '2020/2021-1', 'Kessie123'),
(935, '51800470', 'DAYYAN.Issahaku', 'Creative Art', 28, 38, 66, 'Good', '2020/2021', 1, 33, '1B', '2020-11-09 19:25:41', '2020/2021-1', 'Kessie123'),
(934, '51800469', 'DAISSIE.Gladys', 'Creative Art', 35, 43, 78, 'Very Good', '2020/2021', 1, 11, '1B', '2020-11-09 19:25:40', '2020/2021-1', 'Kessie123'),
(933, '51800468', 'CUDJOE.Joseph', 'Creative Art', 29, 50, 79, 'Very Good', '2020/2021', 1, 7, '1B', '2020-11-09 19:25:40', '2020/2021-1', 'Kessie123'),
(931, '51800466', 'BRONI.Jephter', 'Creative Art', 32, 41, 73, 'Very Good', '2020/2021', 1, 22, '1B', '2020-11-09 19:25:40', '2020/2021-1', 'Kessie123'),
(930, '51800465', 'BREFO.Daniel', 'Creative Art', 24, 41, 65, 'Good', '2020/2021', 1, 35, '1B', '2020-11-09 19:25:40', '2020/2021-1', 'Kessie123'),
(926, 'DHN05170004', 'BOAKYE Joel', 'Creative Art', 32, 53, 85, 'Excellent', '2020/2021', 1, 1, '1B', '2020-11-09 19:25:40', '2020/2021-1', 'Kessie123'),
(925, '51800462', 'BOAKYE AGYEMANG.Jnr Mensah', 'Creative Art', 30, 27, 57, 'Pass', '2020/2021', 1, 39, '1B', '2020-11-09 19:25:40', '2020/2021-1', 'Kessie123'),
(914, 'DIT05170036', 'ASARE Philemon', 'Creative Art', 29, 34, 63, 'Good', '2020/2021', 1, 36, '1B', '2020-11-09 19:25:40', '2020/2021-1', 'Kessie123'),
(915, '51800453', 'ASARE.Clement', 'Creative Art', 25, 46, 71, 'Very Good', '2020/2021', 1, 26, '1B', '2020-11-09 19:25:40', '2020/2021-1', 'Kessie123'),
(916, '51800454', 'ASARE.Victor', 'Creative Art', 17, 46, 63, 'Good', '2020/2021', 1, 37, '1B', '2020-11-09 19:25:40', '2020/2021-1', 'Kessie123'),
(917, '51800455', 'ASOMANI.Williams', 'Creative Art', 31, 47, 78, 'Very Good', '2020/2021', 1, 12, '1B', '2020-11-09 19:25:40', '2020/2021-1', 'Kessie123'),
(918, '51800456', 'ATIAH.Peter Ayine', 'Creative Art', 32, 52, 84, 'Excellent', '2020/2021', 1, 4, '1B', '2020-11-09 19:25:40', '2020/2021-1', 'Kessie123'),
(919, 'DIT05170039', 'AYILGIA Desmond', 'Creative Art', 34, 51, 85, 'Excellent', '2020/2021', 1, 2, '1B', '2020-11-09 19:25:40', '2020/2021-1', 'Kessie123'),
(920, '51800457', 'AZIAH.Daniel', 'Creative Art', 33, 40, 73, 'Very Good', '2020/2021', 1, 23, '1B', '2020-11-09 19:25:40', '2020/2021-1', 'Kessie123'),
(921, '51800458', 'BAAH.Desmond', 'Creative Art', 32, 34, 66, 'Good', '2020/2021', 1, 34, '1B', '2020-11-09 19:25:40', '2020/2021-1', 'Kessie123'),
(891, 'DIT05170082', 'DARKWAH.OWUSU GABRIEL', 'English', 25, 45, 70, 'Very Good', '2020/2021', 1, 19, '1C', '2020-11-09 18:03:05', '2020/2021-1', 'Kessie123'),
(885, '51800496', 'SARPONG.Prince', 'English', 31, 36, 67, 'Good', '2020/2021', 1, 20, '1C', '2020-11-09 18:03:04', '2020/2021-1', 'Kessie123'),
(543, '51800482', 'NYANTAKYI.David', 'French', 34, 34, 68, 'Good', '2020/2021', 1, 23, '1C', '2020-11-09 16:23:10', '2020/2021-1', 'Kessie123'),
(544, '51800481', 'NYANTAKYI.Gideon', 'French', 32, 46, 78, 'Very Good', '2020/2021', 1, 7, '1C', '2020-11-09 16:23:10', '2020/2021-1', 'Kessie123'),
(545, '51800483', 'OBODAI SAI.Edmund', 'French', 24, 46, 70, 'Very Good', '2020/2021', 1, 19, '1C', '2020-11-09 16:23:10', '2020/2021-1', 'Kessie123'),
(546, '51802181', 'OCRAN Victor', 'French', 34, 47, 81, 'Excellent', '2020/2021', 1, 4, '1C', '2020-11-09 16:23:10', '2020/2021-1', 'Kessie123'),
(547, '51800484', 'ODURO.Charles', 'French', 27, 52, 79, 'Very Good', '2020/2021', 1, 5, '1C', '2020-11-09 16:23:10', '2020/2021-1', 'Kessie123'),
(548, '51800485', 'OFORI  BOYE.Gilbert', 'French', 35, 51, 86, 'Excellent', '2020/2021', 1, 1, '1C', '2020-11-09 16:23:10', '2020/2021-1', 'Kessie123'),
(549, '51800488', 'OPOKU.Emmanuel Junior', 'French', 28, 40, 68, 'Good', '2020/2021', 1, 24, '1C', '2020-11-09 16:23:10', '2020/2021-1', 'Kessie123'),
(550, '51800487', 'OPOKU.Evans', 'French', 24, 34, 58, 'Pass', '2020/2021', 1, 27, '1C', '2020-11-09 16:23:10', '2020/2021-1', 'Kessie123'),
(551, '51800486', 'OPOKU.Gyasi Edward', 'French', 22, 48, 70, 'Very Good', '2020/2021', 1, 20, '1C', '2020-11-09 16:23:10', '2020/2021-1', 'Kessie123'),
(552, '51800489', 'OPPONG.Success Antwiwaa', 'French', 34, 36, 70, 'Very Good', '2020/2021', 1, 21, '1C', '2020-11-09 16:23:10', '2020/2021-1', 'Kessie123'),
(553, '51800490', 'OPUNI AMPEM.Benjamin', 'French', 31, 52, 83, 'Excellent', '2020/2021', 1, 3, '1C', '2020-11-09 16:23:10', '2020/2021-1', 'Kessie123'),
(554, '51800491', 'OSEI.Agyei Samuel', 'French', 28, 27, 55, 'Pass', '2020/2021', 1, 29, '1C', '2020-11-09 16:23:10', '2020/2021-1', 'Kessie123'),
(555, '51800492', 'OSEI.Dennis', 'French', 31, 53, 84, 'Excellent', '2020/2021', 1, 2, '1C', '2020-11-09 16:23:10', '2020/2021-1', 'Kessie123'),
(556, 'DIT05170087', 'OWUSU Eric', 'French', 34, 44, 78, 'Very Good', '2020/2021', 1, 8, '1C', '2020-11-09 16:23:10', '2020/2021-1', 'Kessie123'),
(557, '51800493', 'OWUSU MANU. Emmanuel', 'French', 31, 46, 77, 'Very Good', '2020/2021', 1, 11, '1C', '2020-11-09 16:23:10', '2020/2021-1', 'Kessie123'),
(558, 'DIT05170083', 'OWUSU Obed', 'French', 27, 45, 72, 'Very Good', '2020/2021', 1, 16, '1C', '2020-11-09 16:23:10', '2020/2021-1', 'Kessie123'),
(559, 'DIT05170084', 'OWUSU Roberto', 'French', 24, 41, 65, 'Good', '2020/2021', 1, 26, '1C', '2020-11-09 16:23:10', '2020/2021-1', 'Kessie123'),
(560, 'DIT05170086', 'QUAINOO Arko Joseph', 'French', 32, 41, 73, 'Very Good', '2020/2021', 1, 15, '1C', '2020-11-09 16:23:10', '2020/2021-1', 'Kessie123'),
(561, '51800494', 'RAHMAN.Abdul', 'French', 28, 49, 77, 'Very Good', '2020/2021', 1, 12, '1C', '2020-11-09 16:23:10', '2020/2021-1', 'Kessie123'),
(562, 'DIT05170094', 'SALANI Latifa', 'French', 29, 50, 79, 'Very Good', '2020/2021', 1, 6, '1C', '2020-11-09 16:23:10', '2020/2021-1', 'Kessie123'),
(563, '51800495', 'SARFO KANTANKA. Emmanuel', 'French', 35, 43, 78, 'Very Good', '2020/2021', 1, 9, '1C', '2020-11-09 16:23:10', '2020/2021-1', 'Kessie123'),
(564, 'DIT05170092', 'SARPONG Kwabena', 'French', 28, 38, 66, 'Good', '2020/2021', 1, 25, '1C', '2020-11-09 16:23:11', '2020/2021-1', 'Kessie123'),
(565, '51800496', 'SARPONG.Prince', 'French', 35, 36, 71, 'Very Good', '2020/2021', 1, 18, '1C', '2020-11-09 16:23:11', '2020/2021-1', 'Kessie123'),
(566, '51800497', 'TETTEH.Emmanuel', 'French', 23, 52, 75, 'Very Good', '2020/2021', 1, 14, '1C', '2020-11-09 16:23:11', '2020/2021-1', 'Kessie123'),
(567, '51800498', 'TRETU.Eric', 'French', 31, 27, 58, 'Pass', '2020/2021', 1, 28, '1C', '2020-11-09 16:23:11', '2020/2021-1', 'Kessie123'),
(568, 'DIT05170101', 'YAHAYA Shuraim Muhideen', 'French', 25, 53, 78, 'Very Good', '2020/2021', 1, 10, '1C', '2020-11-09 16:23:11', '2020/2021-1', 'Kessie123'),
(569, '51800499', 'ZOTRA. Derrick', 'French', 28, 44, 72, 'Very Good', '2020/2021', 1, 17, '1C', '2020-11-09 16:23:11', '2020/2021-1', 'Kessie123'),
(570, 'DIT05170025', 'Antwi Vera', 'French', 24, 46, 70, 'Very Good', '2020/2021', 1, 22, '1C', '2020-11-09 16:23:11', '2020/2021-1', 'Kessie123'),
(571, 'DIT05170082', 'DARKWAH.OWUSU GABRIEL', 'French', 31, 45, 76, 'Very Good', '2020/2021', 1, 13, '1C', '2020-11-09 16:23:11', '2020/2021-1', 'Kessie123'),
(572, '51800482', 'NYANTAKYI.David', 'Integrated Science', 38, 46, 84, 'Excellent', '2020/2021', 1, 1, '1C', '2020-11-09 16:23:33', '2020/2021-1', 'Kessie123'),
(573, '51800481', 'NYANTAKYI.Gideon', 'Integrated Science', 26, 52, 78, 'Very Good', '2020/2021', 1, 4, '1C', '2020-11-09 16:23:33', '2020/2021-1', 'Kessie123'),
(574, '51800483', 'OBODAI SAI.Edmund', 'Integrated Science', 28, 39, 67, 'Good', '2020/2021', 1, 11, '1C', '2020-11-09 16:23:33', '2020/2021-1', 'Kessie123'),
(575, '51802181', 'OCRAN Victor', 'Integrated Science', 27, 47, 74, 'Very Good', '2020/2021', 1, 7, '1C', '2020-11-09 16:23:33', '2020/2021-1', 'Kessie123'),
(576, '51800484', 'ODURO.Charles', 'Integrated Science', 19, 44, 63, 'Good', '2020/2021', 1, 17, '1C', '2020-11-09 16:23:33', '2020/2021-1', 'Kessie123'),
(577, '51800485', 'OFORI  BOYE.Gilbert', 'Integrated Science', 20, 32, 52, 'Pass', '2020/2021', 1, 25, '1C', '2020-11-09 16:23:33', '2020/2021-1', 'Kessie123'),
(578, '51800488', 'OPOKU.Emmanuel Junior', 'Integrated Science', 18, 34, 52, 'Pass', '2020/2021', 1, 26, '1C', '2020-11-09 16:23:33', '2020/2021-1', 'Kessie123'),
(579, '51800487', 'OPOKU.Evans', 'Integrated Science', 15, 40, 55, 'Pass', '2020/2021', 1, 20, '1C', '2020-11-09 16:23:33', '2020/2021-1', 'Kessie123'),
(580, '51800486', 'OPOKU.Gyasi Edward', 'Integrated Science', 22, 41, 63, 'Good', '2020/2021', 1, 18, '1C', '2020-11-09 16:23:33', '2020/2021-1', 'Kessie123'),
(581, '51800489', 'OPPONG.Success Antwiwaa', 'Integrated Science', 36, 42, 78, 'Very Good', '2020/2021', 1, 5, '1C', '2020-11-09 16:23:33', '2020/2021-1', 'Kessie123'),
(582, '51800490', 'OPUNI AMPEM.Benjamin', 'Integrated Science', 30, 46, 76, 'Very Good', '2020/2021', 1, 6, '1C', '2020-11-09 16:23:33', '2020/2021-1', 'Kessie123'),
(583, '51800491', 'OSEI.Agyei Samuel', 'Integrated Science', 24, 30, 54, 'Pass', '2020/2021', 1, 21, '1C', '2020-11-09 16:23:33', '2020/2021-1', 'Kessie123'),
(584, '51800492', 'OSEI.Dennis', 'Integrated Science', 36, 46, 82, 'Excellent', '2020/2021', 1, 2, '1C', '2020-11-09 16:23:33', '2020/2021-1', 'Kessie123'),
(585, 'DIT05170087', 'OWUSU Eric', 'Integrated Science', 28, 43, 71, 'Very Good', '2020/2021', 1, 8, '1C', '2020-11-09 16:23:33', '2020/2021-1', 'Kessie123'),
(586, '51800493', 'OWUSU MANU. Emmanuel', 'Integrated Science', 16, 37, 53, 'Pass', '2020/2021', 1, 24, '1C', '2020-11-09 16:23:33', '2020/2021-1', 'Kessie123'),
(587, 'DIT05170083', 'OWUSU Obed', 'Integrated Science', 20, 29, 49, 'Fail', '2020/2021', 1, 27, '1C', '2020-11-09 16:23:33', '2020/2021-1', 'Kessie123'),
(588, 'DIT05170084', 'OWUSU Roberto', 'Integrated Science', 22, 32, 54, 'Pass', '2020/2021', 1, 22, '1C', '2020-11-09 16:23:33', '2020/2021-1', 'Kessie123'),
(589, 'DIT05170086', 'QUAINOO Arko Joseph', 'Integrated Science', 36, 44, 80, 'Excellent', '2020/2021', 1, 3, '1C', '2020-11-09 16:23:33', '2020/2021-1', 'Kessie123'),
(590, '51800494', 'RAHMAN.Abdul', 'Integrated Science', 28, 37, 65, 'Good', '2020/2021', 1, 14, '1C', '2020-11-09 16:23:33', '2020/2021-1', 'Kessie123'),
(591, 'DIT05170094', 'SALANI Latifa', 'Integrated Science', 32, 27, 59, 'Pass', '2020/2021', 1, 19, '1C', '2020-11-09 16:23:33', '2020/2021-1', 'Kessie123'),
(592, '51800495', 'SARFO KANTANKA. Emmanuel', 'Integrated Science', 23, 25, 48, 'Fail', '2020/2021', 1, 28, '1C', '2020-11-09 16:23:33', '2020/2021-1', 'Kessie123'),
(593, 'DIT05170092', 'SARPONG Kwabena', 'Integrated Science', 20, 23, 43, 'Fail', '2020/2021', 1, 29, '1C', '2020-11-09 16:23:33', '2020/2021-1', 'Kessie123'),
(594, '51800496', 'SARPONG.Prince', 'Integrated Science', 24, 40, 64, 'Good', '2020/2021', 1, 16, '1C', '2020-11-09 16:23:33', '2020/2021-1', 'Kessie123'),
(595, '51800497', 'TETTEH.Emmanuel', 'Integrated Science', 24, 41, 65, 'Good', '2020/2021', 1, 15, '1C', '2020-11-09 16:23:33', '2020/2021-1', 'Kessie123'),
(596, '51800498', 'TRETU.Eric', 'Integrated Science', 24, 42, 66, 'Good', '2020/2021', 1, 13, '1C', '2020-11-09 16:23:33', '2020/2021-1', 'Kessie123'),
(597, 'DIT05170101', 'YAHAYA Shuraim Muhideen', 'Integrated Science', 24, 46, 70, 'Very Good', '2020/2021', 1, 9, '1C', '2020-11-09 16:23:33', '2020/2021-1', 'Kessie123'),
(598, '51800499', 'ZOTRA. Derrick', 'Integrated Science', 24, 30, 54, 'Pass', '2020/2021', 1, 23, '1C', '2020-11-09 16:23:33', '2020/2021-1', 'Kessie123'),
(599, 'DIT05170025', 'Antwi Vera', 'Integrated Science', 24, 46, 70, 'Very Good', '2020/2021', 1, 10, '1C', '2020-11-09 16:23:33', '2020/2021-1', 'Kessie123'),
(600, 'DIT05170082', 'DARKWAH.OWUSU GABRIEL', 'Integrated Science', 24, 43, 67, 'Good', '2020/2021', 1, 12, '1C', '2020-11-09 16:23:33', '2020/2021-1', 'Kessie123'),
(601, '51800482', 'NYANTAKYI.David', 'Math', 38, 46, 84, 'Excellent', '2020/2021', 1, 1, '1C', '2020-11-09 16:23:53', '2020/2021-1', 'Kessie123'),
(602, '51800481', 'NYANTAKYI.Gideon', 'Math', 26, 52, 78, 'Very Good', '2020/2021', 1, 4, '1C', '2020-11-09 16:23:53', '2020/2021-1', 'Kessie123'),
(603, '51800483', 'OBODAI SAI.Edmund', 'Math', 28, 39, 67, 'Good', '2020/2021', 1, 12, '1C', '2020-11-09 16:23:53', '2020/2021-1', 'Kessie123'),
(604, '51802181', 'OCRAN Victor', 'Math', 27, 47, 74, 'Very Good', '2020/2021', 1, 9, '1C', '2020-11-09 16:23:53', '2020/2021-1', 'Kessie123'),
(605, '51800484', 'ODURO.Charles', 'Math', 22, 44, 66, 'Good', '2020/2021', 1, 13, '1C', '2020-11-09 16:23:53', '2020/2021-1', 'Kessie123'),
(606, '51800485', 'OFORI  BOYE.Gilbert', 'Math', 20, 32, 52, 'Pass', '2020/2021', 1, 26, '1C', '2020-11-09 16:23:53', '2020/2021-1', 'Kessie123'),
(607, '51800488', 'OPOKU.Emmanuel Junior', 'Math', 18, 34, 52, 'Pass', '2020/2021', 1, 27, '1C', '2020-11-09 16:23:53', '2020/2021-1', 'Kessie123'),
(608, '51800487', 'OPOKU.Evans', 'Math', 15, 40, 55, 'Pass', '2020/2021', 1, 22, '1C', '2020-11-09 16:23:53', '2020/2021-1', 'Kessie123'),
(609, '51800486', 'OPOKU.Gyasi Edward', 'Math', 22, 41, 63, 'Good', '2020/2021', 1, 19, '1C', '2020-11-09 16:23:53', '2020/2021-1', 'Kessie123'),
(610, '51800489', 'OPPONG.Success Antwiwaa', 'Math', 36, 42, 78, 'Very Good', '2020/2021', 1, 5, '1C', '2020-11-09 16:23:53', '2020/2021-1', 'Kessie123'),
(611, '51800490', 'OPUNI AMPEM.Benjamin', 'Math', 30, 46, 76, 'Very Good', '2020/2021', 1, 7, '1C', '2020-11-09 16:23:53', '2020/2021-1', 'Kessie123'),
(612, '51800491', 'OSEI.Agyei Samuel', 'Math', 24, 30, 54, 'Pass', '2020/2021', 1, 23, '1C', '2020-11-09 16:23:53', '2020/2021-1', 'Kessie123'),
(613, '51800492', 'OSEI.Dennis', 'Math', 36, 46, 82, 'Excellent', '2020/2021', 1, 2, '1C', '2020-11-09 16:23:53', '2020/2021-1', 'Kessie123'),
(614, 'DIT05170087', 'OWUSU Eric', 'Math', 28, 43, 71, 'Very Good', '2020/2021', 1, 10, '1C', '2020-11-09 16:23:53', '2020/2021-1', 'Kessie123'),
(615, '51800493', 'OWUSU MANU. Emmanuel', 'Math', 16, 37, 53, 'Pass', '2020/2021', 1, 25, '1C', '2020-11-09 16:23:53', '2020/2021-1', 'Kessie123'),
(616, 'DIT05170083', 'OWUSU Obed', 'Math', 20, 29, 49, 'Fail', '2020/2021', 1, 28, '1C', '2020-11-09 16:23:53', '2020/2021-1', 'Kessie123'),
(617, 'DIT05170084', 'OWUSU Roberto', 'Math', 22, 32, 54, 'Pass', '2020/2021', 1, 24, '1C', '2020-11-09 16:23:53', '2020/2021-1', 'Kessie123'),
(618, 'DIT05170086', 'QUAINOO Arko Joseph', 'Math', 36, 44, 80, 'Excellent', '2020/2021', 1, 3, '1C', '2020-11-09 16:23:53', '2020/2021-1', 'Kessie123'),
(619, '51800494', 'RAHMAN.Abdul', 'Math', 28, 37, 65, 'Good', '2020/2021', 1, 16, '1C', '2020-11-09 16:23:53', '2020/2021-1', 'Kessie123'),
(620, 'DIT05170094', 'SALANI Latifa', 'Math', 32, 27, 59, 'Pass', '2020/2021', 1, 21, '1C', '2020-11-09 16:23:53', '2020/2021-1', 'Kessie123'),
(621, '51800495', 'SARFO KANTANKA. Emmanuel', 'Math', 23, 25, 48, 'Fail', '2020/2021', 1, 29, '1C', '2020-11-09 16:23:53', '2020/2021-1', 'Kessie123'),
(622, 'DIT05170092', 'SARPONG Kwabena', 'Math', 20, 46, 66, 'Good', '2020/2021', 1, 14, '1C', '2020-11-09 16:23:53', '2020/2021-1', 'Kessie123'),
(623, '51800496', 'SARPONG.Prince', 'Math', 25, 52, 77, 'Very Good', '2020/2021', 1, 6, '1C', '2020-11-09 16:23:53', '2020/2021-1', 'Kessie123'),
(624, '51800497', 'TETTEH.Emmanuel', 'Math', 27, 39, 66, 'Good', '2020/2021', 1, 15, '1C', '2020-11-09 16:23:53', '2020/2021-1', 'Kessie123'),
(625, '51800498', 'TRETU.Eric', 'Math', 28, 47, 75, 'Very Good', '2020/2021', 1, 8, '1C', '2020-11-09 16:23:53', '2020/2021-1', 'Kessie123'),
(626, 'DIT05170101', 'YAHAYA Shuraim Muhideen', 'Math', 27, 44, 71, 'Very Good', '2020/2021', 1, 11, '1C', '2020-11-09 16:23:53', '2020/2021-1', 'Kessie123'),
(627, '51800499', 'ZOTRA. Derrick', 'Math', 28, 32, 60, 'Good', '2020/2021', 1, 20, '1C', '2020-11-09 16:23:53', '2020/2021-1', 'Kessie123'),
(628, 'DIT05170025', 'Antwi Vera', 'Math', 30, 34, 64, 'Good', '2020/2021', 1, 17, '1C', '2020-11-09 16:23:53', '2020/2021-1', 'Kessie123'),
(629, 'DIT05170082', 'DARKWAH.OWUSU GABRIEL', 'Math', 24, 40, 64, 'Good', '2020/2021', 1, 18, '1C', '2020-11-09 16:23:53', '2020/2021-1', 'Kessie123'),
(630, '51800482', 'NYANTAKYI.David', 'Social Studies', 33, 46, 79, 'Very Good', '2020/2021', 1, 2, '1C', '2020-11-09 16:24:11', '2020/2021-1', 'Kessie123'),
(631, '51800481', 'NYANTAKYI.Gideon', 'Social Studies', 27, 52, 79, 'Very Good', '2020/2021', 1, 3, '1C', '2020-11-09 16:24:11', '2020/2021-1', 'Kessie123'),
(632, '51800483', 'OBODAI SAI.Edmund', 'Social Studies', 28, 39, 67, 'Good', '2020/2021', 1, 16, '1C', '2020-11-09 16:24:11', '2020/2021-1', 'Kessie123'),
(633, '51802181', 'OCRAN Victor', 'Social Studies', 29, 47, 76, 'Very Good', '2020/2021', 1, 5, '1C', '2020-11-09 16:24:11', '2020/2021-1', 'Kessie123'),
(634, '51800484', 'ODURO.Charles', 'Social Studies', 25, 44, 69, 'Good', '2020/2021', 1, 14, '1C', '2020-11-09 16:24:11', '2020/2021-1', 'Kessie123'),
(635, '51800485', 'OFORI  BOYE.Gilbert', 'Social Studies', 24, 32, 56, 'Pass', '2020/2021', 1, 24, '1C', '2020-11-09 16:24:11', '2020/2021-1', 'Kessie123'),
(636, '51800488', 'OPOKU.Emmanuel Junior', 'Social Studies', 25, 34, 59, 'Pass', '2020/2021', 1, 20, '1C', '2020-11-09 16:24:11', '2020/2021-1', 'Kessie123'),
(637, '51800487', 'OPOKU.Evans', 'Social Studies', 21, 40, 61, 'Good', '2020/2021', 1, 18, '1C', '2020-11-09 16:24:11', '2020/2021-1', 'Kessie123'),
(638, '51800486', 'OPOKU.Gyasi Edward', 'Social Studies', 32, 41, 73, 'Very Good', '2020/2021', 1, 11, '1C', '2020-11-09 16:24:11', '2020/2021-1', 'Kessie123'),
(639, '51800489', 'OPPONG.Success Antwiwaa', 'Social Studies', 32, 42, 74, 'Very Good', '2020/2021', 1, 9, '1C', '2020-11-09 16:24:11', '2020/2021-1', 'Kessie123'),
(640, '51800490', 'OPUNI AMPEM.Benjamin', 'Social Studies', 29, 46, 75, 'Very Good', '2020/2021', 1, 7, '1C', '2020-11-09 16:24:11', '2020/2021-1', 'Kessie123'),
(641, '51800491', 'OSEI.Agyei Samuel', 'Social Studies', 26, 30, 56, 'Pass', '2020/2021', 1, 25, '1C', '2020-11-09 16:24:11', '2020/2021-1', 'Kessie123'),
(642, '51800492', 'OSEI.Dennis', 'Social Studies', 34, 46, 80, 'Excellent', '2020/2021', 1, 1, '1C', '2020-11-09 16:24:11', '2020/2021-1', 'Kessie123'),
(643, 'DIT05170087', 'OWUSU Eric', 'Social Studies', 31, 43, 74, 'Very Good', '2020/2021', 1, 10, '1C', '2020-11-09 16:24:11', '2020/2021-1', 'Kessie123'),
(644, '51800493', 'OWUSU MANU. Emmanuel', 'Social Studies', 23, 37, 60, 'Good', '2020/2021', 1, 19, '1C', '2020-11-09 16:24:11', '2020/2021-1', 'Kessie123'),
(645, 'DIT05170083', 'OWUSU Obed', 'Social Studies', 29, 29, 58, 'Pass', '2020/2021', 1, 21, '1C', '2020-11-09 16:24:11', '2020/2021-1', 'Kessie123'),
(646, 'DIT05170084', 'OWUSU Roberto', 'Social Studies', 25, 32, 57, 'Pass', '2020/2021', 1, 22, '1C', '2020-11-09 16:24:11', '2020/2021-1', 'Kessie123'),
(647, 'DIT05170086', 'QUAINOO Arko Joseph', 'Social Studies', 34, 44, 78, 'Very Good', '2020/2021', 1, 4, '1C', '2020-11-09 16:24:11', '2020/2021-1', 'Kessie123'),
(648, '51800494', 'RAHMAN.Abdul', 'Social Studies', 31, 37, 68, 'Good', '2020/2021', 1, 15, '1C', '2020-11-09 16:24:11', '2020/2021-1', 'Kessie123'),
(649, 'DIT05170094', 'SALANI Latifa', 'Social Studies', 30, 27, 57, 'Pass', '2020/2021', 1, 23, '1C', '2020-11-09 16:24:11', '2020/2021-1', 'Kessie123'),
(650, '51800495', 'SARFO KANTANKA. Emmanuel', 'Social Studies', 27, 25, 52, 'Pass', '2020/2021', 1, 27, '1C', '2020-11-09 16:24:11', '2020/2021-1', 'Kessie123'),
(651, 'DIT05170092', 'SARPONG Kwabena', 'Social Studies', 24, 23, 47, 'Fail', '2020/2021', 1, 29, '1C', '2020-11-09 16:24:11', '2020/2021-1', 'Kessie123'),
(652, '51800496', 'SARPONG.Prince', 'Social Studies', 28, 42, 70, 'Very Good', '2020/2021', 1, 13, '1C', '2020-11-09 16:24:11', '2020/2021-1', 'Kessie123'),
(653, '51800497', 'TETTEH.Emmanuel', 'Social Studies', 29, 46, 75, 'Very Good', '2020/2021', 1, 8, '1C', '2020-11-09 16:24:11', '2020/2021-1', 'Kessie123'),
(654, '51800498', 'TRETU.Eric', 'Social Studies', 24, 30, 54, 'Pass', '2020/2021', 1, 26, '1C', '2020-11-09 16:24:11', '2020/2021-1', 'Kessie123'),
(655, 'DIT05170101', 'YAHAYA Shuraim Muhideen', 'Social Studies', 30, 46, 76, 'Very Good', '2020/2021', 1, 6, '1C', '2020-11-09 16:24:11', '2020/2021-1', 'Kessie123'),
(656, '51800499', 'ZOTRA. Derrick', 'Social Studies', 29, 43, 72, 'Very Good', '2020/2021', 1, 12, '1C', '2020-11-09 16:24:11', '2020/2021-1', 'Kessie123'),
(657, 'DIT05170025', 'Antwi Vera', 'Social Studies', 28, 37, 65, 'Good', '2020/2021', 1, 17, '1C', '2020-11-09 16:24:11', '2020/2021-1', 'Kessie123'),
(658, 'DIT05170082', 'DARKWAH.OWUSU GABRIEL', 'Social Studies', 21, 29, 50, 'Pass', '2020/2021', 1, 28, '1C', '2020-11-09 16:24:11', '2020/2021-1', 'Kessie123'),
(659, '51800482', 'NYANTAKYI.David', 'Twi', 29, 34, 63, 'Good', '2020/2021', 1, 26, '1C', '2020-11-09 16:24:30', '2020/2021-1', 'Kessie123'),
(660, '51800481', 'NYANTAKYI.Gideon', 'Twi', 25, 46, 71, 'Very Good', '2020/2021', 1, 17, '1C', '2020-11-09 16:24:30', '2020/2021-1', 'Kessie123'),
(661, '51800483', 'OBODAI SAI.Edmund', 'Twi', 17, 46, 63, 'Good', '2020/2021', 1, 27, '1C', '2020-11-09 16:24:30', '2020/2021-1', 'Kessie123'),
(662, '51802181', 'OCRAN Victor', 'Twi', 31, 47, 78, 'Very Good', '2020/2021', 1, 7, '1C', '2020-11-09 16:24:30', '2020/2021-1', 'Kessie123'),
(663, '51800484', 'ODURO.Charles', 'Twi', 32, 52, 84, 'Excellent', '2020/2021', 1, 3, '1C', '2020-11-09 16:24:30', '2020/2021-1', 'Kessie123'),
(664, '51800485', 'OFORI  BOYE.Gilbert', 'Twi', 34, 51, 85, 'Excellent', '2020/2021', 1, 1, '1C', '2020-11-09 16:24:30', '2020/2021-1', 'Kessie123'),
(665, '51800488', 'OPOKU.Emmanuel Junior', 'Twi', 33, 40, 73, 'Very Good', '2020/2021', 1, 14, '1C', '2020-11-09 16:24:30', '2020/2021-1', 'Kessie123'),
(666, '51800487', 'OPOKU.Evans', 'Twi', 32, 34, 66, 'Good', '2020/2021', 1, 23, '1C', '2020-11-09 16:24:30', '2020/2021-1', 'Kessie123'),
(667, '51800486', 'OPOKU.Gyasi Edward', 'Twi', 27, 48, 75, 'Very Good', '2020/2021', 1, 11, '1C', '2020-11-09 16:24:30', '2020/2021-1', 'Kessie123'),
(668, '51800489', 'OPPONG.Success Antwiwaa', 'Twi', 31, 36, 67, 'Good', '2020/2021', 1, 22, '1C', '2020-11-09 16:24:30', '2020/2021-1', 'Kessie123'),
(669, '51800490', 'OPUNI AMPEM.Benjamin', 'Twi', 26, 52, 78, 'Very Good', '2020/2021', 1, 8, '1C', '2020-11-09 16:24:30', '2020/2021-1', 'Kessie123'),
(670, '51800491', 'OSEI.Agyei Samuel', 'Twi', 30, 27, 57, 'Pass', '2020/2021', 1, 28, '1C', '2020-11-09 16:24:30', '2020/2021-1', 'Kessie123'),
(671, '51800492', 'OSEI.Dennis', 'Twi', 32, 53, 85, 'Excellent', '2020/2021', 1, 2, '1C', '2020-11-09 16:24:30', '2020/2021-1', 'Kessie123'),
(672, 'DIT05170087', 'OWUSU Eric', 'Twi', 27, 44, 71, 'Very Good', '2020/2021', 1, 18, '1C', '2020-11-09 16:24:30', '2020/2021-1', 'Kessie123'),
(673, '51800493', 'OWUSU MANU. Emmanuel', 'Twi', 28, 46, 74, 'Very Good', '2020/2021', 1, 13, '1C', '2020-11-09 16:24:30', '2020/2021-1', 'Kessie123'),
(674, 'DIT05170083', 'OWUSU Obed', 'Twi', 27, 45, 72, 'Very Good', '2020/2021', 1, 16, '1C', '2020-11-09 16:24:30', '2020/2021-1', 'Kessie123'),
(675, 'DIT05170084', 'OWUSU Roberto', 'Twi', 24, 41, 65, 'Good', '2020/2021', 1, 25, '1C', '2020-11-09 16:24:30', '2020/2021-1', 'Kessie123'),
(676, 'DIT05170086', 'QUAINOO Arko Joseph', 'Twi', 32, 41, 73, 'Very Good', '2020/2021', 1, 15, '1C', '2020-11-09 16:24:30', '2020/2021-1', 'Kessie123'),
(677, '51800494', 'RAHMAN.Abdul', 'Twi', 28, 49, 77, 'Very Good', '2020/2021', 1, 10, '1C', '2020-11-09 16:24:30', '2020/2021-1', 'Kessie123'),
(678, 'DIT05170094', 'SALANI Latifa', 'Twi', 29, 50, 79, 'Very Good', '2020/2021', 1, 6, '1C', '2020-11-09 16:24:30', '2020/2021-1', 'Kessie123'),
(679, '51800495', 'SARFO KANTANKA. Emmanuel', 'Twi', 35, 43, 78, 'Very Good', '2020/2021', 1, 9, '1C', '2020-11-09 16:24:30', '2020/2021-1', 'Kessie123'),
(680, 'DIT05170092', 'SARPONG Kwabena', 'Twi', 28, 38, 66, 'Good', '2020/2021', 1, 24, '1C', '2020-11-09 16:24:30', '2020/2021-1', 'Kessie123'),
(681, '51800496', 'SARPONG.Prince', 'Twi', 35, 36, 71, 'Very Good', '2020/2021', 1, 19, '1C', '2020-11-09 16:24:30', '2020/2021-1', 'Kessie123'),
(682, '51800497', 'TETTEH.Emmanuel', 'Twi', 29, 52, 81, 'Excellent', '2020/2021', 1, 5, '1C', '2020-11-09 16:24:30', '2020/2021-1', 'Kessie123'),
(683, '51800498', 'TRETU.Eric', 'Twi', 29, 27, 56, 'Pass', '2020/2021', 1, 29, '1C', '2020-11-09 16:24:30', '2020/2021-1', 'Kessie123'),
(684, 'DIT05170101', 'YAHAYA Shuraim Muhideen', 'Twi', 31, 53, 84, 'Excellent', '2020/2021', 1, 4, '1C', '2020-11-09 16:24:30', '2020/2021-1', 'Kessie123'),
(685, '51800499', 'ZOTRA. Derrick', 'Twi', 25, 44, 69, 'Good', '2020/2021', 1, 20, '1C', '2020-11-09 16:24:30', '2020/2021-1', 'Kessie123'),
(686, 'DIT05170025', 'Antwi Vera', 'Twi', 23, 46, 69, 'Good', '2020/2021', 1, 21, '1C', '2020-11-09 16:24:30', '2020/2021-1', 'Kessie123'),
(687, 'DIT05170082', 'DARKWAH.OWUSU GABRIEL', 'Twi', 30, 45, 75, 'Very Good', '2020/2021', 1, 12, '1C', '2020-11-09 16:24:30', '2020/2021-1', 'Kessie123'),
(890, 'DIT05170025', 'Antwi Vera', 'English', 33, 46, 79, 'Very Good', '2020/2021', 1, 7, '1C', '2020-11-09 18:03:05', '2020/2021-1', 'Kessie123'),
(888, 'DIT05170101', 'YAHAYA Shuraim Muhideen', 'English', 30, 53, 83, 'Excellent', '2020/2021', 1, 3, '1C', '2020-11-09 18:03:05', '2020/2021-1', 'Kessie123'),
(887, '51800498', 'TRETU.Eric', 'English', 29, 27, 56, 'Pass', '2020/2021', 1, 27, '1C', '2020-11-09 18:03:04', '2020/2021-1', 'Kessie123'),
(886, '51800497', 'TETTEH.Emmanuel', 'English', 33, 52, 85, 'Excellent', '2020/2021', 1, 2, '1C', '2020-11-09 18:03:04', '2020/2021-1', 'Kessie123'),
(889, '51800499', 'ZOTRA. Derrick', 'English', 35, 44, 79, 'Very Good', '2020/2021', 1, 8, '1C', '2020-11-09 18:03:05', '2020/2021-1', 'Kessie123'),
(968, '51800493', 'OWUSU MANU. Emmanuel', 'Creative Art', 28, 46, 74, 'Very Good', '2020/2021', 1, 13, '1C', '2020-11-09 19:25:54', '2020/2021-1', 'Kessie123'),
(961, '51800487', 'OPOKU.Evans', 'Creative Art', 32, 34, 66, 'Good', '2020/2021', 1, 24, '1C', '2020-11-09 19:25:54', '2020/2021-1', 'Kessie123'),
(982, 'DIT05170082', 'DARKWAH.OWUSU GABRIEL', 'Creative Art', 30, 45, 75, 'Very Good', '2020/2021', 1, 12, '1C', '2020-11-09 19:25:54', '2020/2021-1', 'Kessie123'),
(964, '51800490', 'OPUNI AMPEM.Benjamin', 'Creative Art', 26, 52, 78, 'Very Good', '2020/2021', 1, 9, '1C', '2020-11-09 19:25:54', '2020/2021-1', 'Kessie123'),
(965, '51800491', 'OSEI.Agyei Samuel', 'Creative Art', 30, 27, 57, 'Pass', '2020/2021', 1, 28, '1C', '2020-11-09 19:25:54', '2020/2021-1', 'Kessie123'),
(955, '51800481', 'NYANTAKYI.Gideon', 'Creative Art', 25, 46, 71, 'Very Good', '2020/2021', 1, 18, '1C', '2020-11-09 19:25:54', '2020/2021-1', 'Kessie123'),
(979, 'DIT05170101', 'YAHAYA Shuraim Muhideen', 'Creative Art', 31, 53, 84, 'Excellent', '2020/2021', 1, 3, '1C', '2020-11-09 19:25:54', '2020/2021-1', 'Kessie123'),
(971, 'DIT05170086', 'QUAINOO Arko Joseph', 'Creative Art', 32, 41, 73, 'Very Good', '2020/2021', 1, 15, '1C', '2020-11-09 19:25:54', '2020/2021-1', 'Kessie123'),
(967, 'DIT05170087', 'OWUSU Eric', 'Creative Art', 27, 44, 71, 'Very Good', '2020/2021', 1, 19, '1C', '2020-11-09 19:25:54', '2020/2021-1', 'Kessie123'),
(959, '51800485', 'OFORI  BOYE.Gilbert', 'Creative Art', 34, 51, 85, 'Excellent', '2020/2021', 1, 2, '1C', '2020-11-09 19:25:54', '2020/2021-1', 'Kessie123'),
(972, '51800494', 'RAHMAN.Abdul', 'Creative Art', 28, 49, 77, 'Very Good', '2020/2021', 1, 10, '1C', '2020-11-09 19:25:54', '2020/2021-1', 'Kessie123'),
(958, '51800484', 'ODURO.Charles', 'Creative Art', 32, 52, 84, 'Excellent', '2020/2021', 1, 4, '1C', '2020-11-09 19:25:54', '2020/2021-1', 'Kessie123'),
(969, 'DIT05170083', 'OWUSU Obed', 'Creative Art', 27, 45, 72, 'Very Good', '2020/2021', 1, 16, '1C', '2020-11-09 19:25:54', '2020/2021-1', 'Kessie123'),
(924, '51800461', 'BOAHENE.Prince', 'Creative Art', 26, 52, 78, 'Very Good', '2020/2021', 1, 13, '1B', '2020-11-09 19:25:40', '2020/2021-1', 'Kessie123'),
(929, '51800464', 'BORLABI.Godfred Borketey', 'Creative Art', 27, 45, 72, 'Very Good', '2020/2021', 1, 24, '1B', '2020-11-09 19:25:40', '2020/2021-1', 'Kessie123'),
(913, '51800452', 'ANTWI.Addai Dickson', 'Creative Art', 26, 38, 64, 'Good', '2020/2021', 1, 18, '1A', '2020-11-09 19:25:26', '2020/2021-1', 'Kessie123'),
(932, '51800467', 'BUDU.Charles', 'Creative Art', 28, 49, 77, 'Very Good', '2020/2021', 1, 14, '1B', '2020-11-09 19:25:40', '2020/2021-1', 'Kessie123'),
(927, 'DIT05170049', 'BOATENG Asare', 'Creative Art', 27, 44, 71, 'Very Good', '2020/2021', 1, 27, '1B', '2020-11-09 19:25:40', '2020/2021-1', 'Kessie123'),
(923, '51800460', 'BLAY.Goka Simon', 'Creative Art', 31, 36, 67, 'Good', '2020/2021', 1, 32, '1B', '2020-11-09 19:25:40', '2020/2021-1', 'Kessie123'),
(922, '51800459', 'BINEY.Kish Daniel', 'Creative Art', 27, 48, 75, 'Very Good', '2020/2021', 1, 17, '1B', '2020-11-09 19:25:40', '2020/2021-1', 'Kessie123'),
(928, '51800463', 'BOATENG.Bismark', 'Creative Art', 28, 46, 74, 'Very Good', '2020/2021', 1, 18, '1B', '2020-11-09 19:25:40', '2020/2021-1', 'Kessie123'),
(945, 'DIT05170067', 'MICHAEL Agyapong Kwarteng', 'Creative Art', 30, 49, 79, 'Very Good', '2020/2021', 1, 8, '1B', '2020-11-09 19:25:41', '2020/2021-1', 'Kessie123'),
(912, 'DIT05170023', 'ANTWI Boasiako Kwame', 'Creative Art', 28, 43, 71, 'Very Good', '2020/2021', 1, 14, '1A', '2020-11-09 19:25:26', '2020/2021-1', 'Kessie123'),
(911, '51800451', 'ANSAH.Alfred', 'Creative Art', 26, 50, 76, 'Very Good', '2020/2021', 1, 6, '1A', '2020-11-09 19:25:26', '2020/2021-1', 'Kessie123'),
(910, '51800450', 'ANOKYE.Phinehas Boakye', 'Creative Art', 29, 49, 78, 'Very Good', '2020/2021', 1, 2, '1A', '2020-11-09 19:25:26', '2020/2021-1', 'Kessie123'),
(909, 'DWD05170001', 'AMOAH Gyamfuaah Ellen', 'Creative Art', 28, 41, 69, 'Good', '2020/2021', 1, 15, '1A', '2020-11-09 19:25:26', '2020/2021-1', 'Kessie123'),
(908, '51800449', 'ALHASSAN.Faruq', 'Creative Art', 26, 41, 67, 'Good', '2020/2021', 1, 17, '1A', '2020-11-09 19:25:26', '2020/2021-1', 'Kessie123'),
(907, '51800448', 'AIDOO.Grace', 'Creative Art', 31, 45, 76, 'Very Good', '2020/2021', 1, 7, '1A', '2020-11-09 19:25:26', '2020/2021-1', 'Kessie123'),
(906, '51800447', 'AHMED.Saeed', 'Creative Art', 27, 46, 73, 'Very Good', '2020/2021', 1, 9, '1A', '2020-11-09 19:25:26', '2020/2021-1', 'Kessie123'),
(905, 'DIT05170099', 'AHIABLE Victoria', 'Creative Art', 29, 44, 73, 'Very Good', '2020/2021', 1, 10, '1A', '2020-11-09 19:25:26', '2020/2021-1', 'Kessie123'),
(897, '51800440', 'ADAM.Gadaf', 'Creative Art', 26, 51, 77, 'Very Good', '2020/2021', 1, 5, '1A', '2020-11-09 19:25:26', '2020/2021-1', 'Kessie123'),
(896, '51800439', 'ABUBAKAR.Farouk', 'Creative Art', 26, 52, 78, 'Very Good', '2020/2021', 1, 3, '1A', '2020-11-09 19:25:26', '2020/2021-1', 'Kessie123'),
(895, 'DIT05170011', 'ABDUL-Malik Firdaus', 'Creative Art', 26, 47, 73, 'Very Good', '2020/2021', 1, 11, '1A', '2020-11-09 19:25:25', '2020/2021-1', 'Kessie123'),
(894, '51800438', 'ABDUL GANIYU.Sadick', 'Creative Art', 26, 46, 72, 'Very Good', '2020/2021', 1, 12, '1A', '2020-11-09 19:25:25', '2020/2021-1', 'Kessie123'),
(884, 'DIT05170092', 'SARPONG Kwabena', 'English', 20, 38, 58, 'Pass', '2020/2021', 1, 25, '1C', '2020-11-09 18:03:04', '2020/2021-1', 'Kessie123'),
(883, '51800495', 'SARFO KANTANKA. Emmanuel', 'English', 22, 43, 65, 'Good', '2020/2021', 1, 21, '1C', '2020-11-09 18:03:04', '2020/2021-1', 'Kessie123'),
(882, 'DIT05170094', 'SALANI Latifa', 'English', 32, 50, 82, 'Excellent', '2020/2021', 1, 4, '1C', '2020-11-09 18:03:04', '2020/2021-1', 'Kessie123'),
(881, '51800494', 'RAHMAN.Abdul', 'English', 28, 49, 77, 'Very Good', '2020/2021', 1, 9, '1C', '2020-11-09 18:03:04', '2020/2021-1', 'Kessie123'),
(880, 'DIT05170086', 'QUAINOO Arko Joseph', 'English', 36, 41, 77, 'Very Good', '2020/2021', 1, 10, '1C', '2020-11-09 18:03:04', '2020/2021-1', 'Kessie123'),
(879, 'DIT05170084', 'OWUSU Roberto', 'English', 22, 41, 63, 'Good', '2020/2021', 1, 23, '1C', '2020-11-09 18:03:04', '2020/2021-1', 'Kessie123'),
(878, 'DIT05170083', 'OWUSU Obed', 'English', 20, 45, 65, 'Good', '2020/2021', 1, 22, '1C', '2020-11-09 18:03:04', '2020/2021-1', 'Kessie123'),
(877, '51800493', 'OWUSU MANU. Emmanuel', 'English', 16, 46, 62, 'Good', '2020/2021', 1, 24, '1C', '2020-11-09 18:03:04', '2020/2021-1', 'Kessie123'),
(876, 'DIT05170087', 'OWUSU Eric', 'English', 28, 44, 72, 'Very Good', '2020/2021', 1, 14, '1C', '2020-11-09 18:03:04', '2020/2021-1', 'Kessie123'),
(875, '51800492', 'OSEI.Dennis', 'English', 36, 53, 89, 'Excellent', '2020/2021', 1, 1, '1C', '2020-11-09 18:03:04', '2020/2021-1', 'Kessie123'),
(874, '51800491', 'OSEI.Agyei Samuel', 'English', 24, 27, 51, 'Pass', '2020/2021', 1, 28, '1C', '2020-11-09 18:03:04', '2020/2021-1', 'Kessie123'),
(873, '51800490', 'OPUNI AMPEM.Benjamin', 'English', 30, 52, 82, 'Excellent', '2020/2021', 1, 5, '1C', '2020-11-09 18:03:04', '2020/2021-1', 'Kessie123'),
(872, '51800489', 'OPPONG.Success Antwiwaa', 'English', 36, 36, 72, 'Very Good', '2020/2021', 1, 15, '1C', '2020-11-09 18:03:04', '2020/2021-1', 'Kessie123'),
(871, '51800486', 'OPOKU.Gyasi Edward', 'English', 34, 48, 82, 'Excellent', '2020/2021', 1, 6, '1C', '2020-11-09 18:03:04', '2020/2021-1', 'Kessie123'),
(870, '51800487', 'OPOKU.Evans', 'English', 10, 34, 44, 'Fail', '2020/2021', 1, 29, '1C', '2020-11-09 18:03:04', '2020/2021-1', 'Kessie123'),
(869, '51800488', 'OPOKU.Emmanuel Junior', 'English', 18, 40, 58, 'Pass', '2020/2021', 1, 26, '1C', '2020-11-09 18:03:04', '2020/2021-1', 'Kessie123'),
(868, '51800485', 'OFORI  BOYE.Gilbert', 'English', 20, 51, 71, 'Very Good', '2020/2021', 1, 18, '1C', '2020-11-09 18:03:04', '2020/2021-1', 'Kessie123'),
(867, '51800484', 'ODURO.Charles', 'English', 22, 52, 74, 'Very Good', '2020/2021', 1, 12, '1C', '2020-11-09 18:03:04', '2020/2021-1', 'Kessie123'),
(864, '51800481', 'NYANTAKYI.Gideon', 'English', 26, 46, 72, 'Very Good', '2020/2021', 1, 16, '1C', '2020-11-09 18:03:04', '2020/2021-1', 'Kessie123'),
(862, '51800480', 'NKANSAH.Prince', 'English', 24, 52, 76, 'Very Good', '2020/2021', 1, 13, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(861, '51801905', 'MORNAH.Frank  Atouro', 'English', 26, 47, 73, 'Very Good', '2020/2021', 1, 16, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(860, '51800478', 'MONTEL.Ray Lawson', 'English', 32, 46, 78, 'Very Good', '2020/2021', 1, 9, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(859, '51800475', 'MOHAMMED.Yahaya Hafiz', 'English', 27, 46, 73, 'Very Good', '2020/2021', 1, 17, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(858, '51800476', 'MOHAMMED.Osman', 'English', 24, 34, 58, 'Pass', '2020/2021', 1, 34, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(857, 'DIT05170071', 'MOHAMMED Jamal', 'English', 31, 38, 69, 'Good', '2020/2021', 1, 25, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(856, '51800477', 'MOHAMMED ISHMAIL.Shariff', 'English', 30, 43, 73, 'Very Good', '2020/2021', 1, 30, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(855, 'DIT05170013', 'MICHAEL Bota Afrifa', 'English', 31, 50, 81, 'Excellent', '2020/2021', 1, 26, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(852, 'DIT05170068', 'LARBI Wilson Nana Yaw', 'English', 37, 41, 78, 'Very Good', '2020/2021', 1, 35, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(851, 'DIT05170065', 'KONADU Obed', 'English', 30, 45, 75, 'Very Good', '2020/2021', 1, 24, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(850, 'DIT05170063', 'KARIM Nayiba', 'English', 23, 46, 69, 'Good', '2020/2021', 1, 7, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(849, '51800473', 'ISSAH.Abubakar Saddick', 'English', 25, 44, 69, 'Good', '2020/2021', 1, 8, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(845, 'DIT05170026', 'ELLIOT Gyamfi Anyankwah', 'English', 35, 36, 71, 'Very Good', '2020/2021', 1, 27, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(843, '51800469', 'DAISSIE.Gladys', 'English', 35, 43, 78, 'Very Good', '2020/2021', 1, 28, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(840, '51800466', 'BRONI.Jephter', 'English', 32, 41, 73, 'Very Good', '2020/2021', 1, 10, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(839, '51800465', 'BREFO.Daniel', 'English', 24, 41, 65, 'Good', '2020/2021', 1, 31, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(827, '51800456', 'ATIAH.Peter Ayine', 'English', 32, 52, 84, 'Excellent', '2020/2021', 1, 14, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(825, '51800454', 'ASARE.Victor', 'English', 17, 46, 63, 'Good', '2020/2021', 1, 15, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(824, '51800453', 'ASARE.Clement', 'English', 25, 46, 71, 'Very Good', '2020/2021', 1, 18, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(823, 'DIT05170036', 'ASARE Philemon', 'English', 29, 34, 63, 'Good', '2020/2021', 1, 19, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(822, '51800452', 'ANTWI.Addai Dickson', 'English', 26, 38, 64, 'Good', '2020/2021', 1, 21, '1A', '2020-11-09 18:02:39', '2020/2021-1', 'Kessie123'),
(821, 'DIT05170023', 'ANTWI Boasiako Kwame', 'English', 28, 43, 71, 'Very Good', '2020/2021', 1, 20, '1A', '2020-11-09 18:02:39', '2020/2021-1', 'Kessie123'),
(820, '51800451', 'ANSAH.Alfred', 'English', 26, 50, 76, 'Very Good', '2020/2021', 1, 22, '1A', '2020-11-09 18:02:39', '2020/2021-1', 'Kessie123'),
(817, '51800449', 'ALHASSAN.Faruq', 'English', 26, 41, 67, 'Good', '2020/2021', 1, 13, '1A', '2020-11-09 18:02:39', '2020/2021-1', 'Kessie123'),
(816, '51800448', 'AIDOO.Grace', 'English', 31, 45, 76, 'Very Good', '2020/2021', 1, 12, '1A', '2020-11-09 18:02:38', '2020/2021-1', 'Kessie123'),
(815, '51800447', 'AHMED.Saeed', 'English', 27, 46, 73, 'Very Good', '2020/2021', 1, 5, '1A', '2020-11-09 18:02:38', '2020/2021-1', 'Kessie123'),
(814, 'DIT05170099', 'AHIABLE Victoria', 'English', 29, 44, 73, 'Very Good', '2020/2021', 1, 6, '1A', '2020-11-09 18:02:38', '2020/2021-1', 'Kessie123'),
(813, '51800446', 'AGYEKUM.Ernest Tabi', 'English', 28, 53, 81, 'Excellent', '2020/2021', 1, 2, '1A', '2020-11-09 18:02:38', '2020/2021-1', 'Kessie123'),
(809, '51800442', 'ADJEI.Anthony Clifford', 'English', 27, 48, 75, 'Very Good', '2020/2021', 1, 7, '1A', '2020-11-09 18:02:38', '2020/2021-1', 'Kessie123'),
(808, '51800441', 'ADIKU OFORI.Harold', 'English', 28, 34, 62, 'Good', '2020/2021', 1, 17, '1A', '2020-11-09 18:02:38', '2020/2021-1', 'Kessie123'),
(807, 'DIT05170007', 'ADARKWAH Emmanuel', 'English', 28, 40, 68, 'Good', '2020/2021', 1, 10, '1A', '2020-11-09 18:02:38', '2020/2021-1', 'Kessie123'),
(806, '51800440', 'ADAM.Gadaf', 'English', 26, 51, 77, 'Very Good', '2020/2021', 1, 9, '1A', '2020-11-09 18:02:38', '2020/2021-1', 'Kessie123'),
(805, '51800439', 'ABUBAKAR.Farouk', 'English', 26, 52, 78, 'Very Good', '2020/2021', 1, 15, '1A', '2020-11-09 18:02:38', '2020/2021-1', 'Kessie123'),
(803, '51800438', 'ABDUL GANIYU.Sadick', 'English', 26, 46, 72, 'Very Good', '2020/2021', 1, 14, '1A', '2020-11-09 18:02:38', '2020/2021-1', 'Kessie123'),
(801, 'st123', 'KESSIE.Bismark', 'English', 26, 34, 60, 'Good', '2020/2021', 1, 1, '1A', '2020-11-09 18:02:38', '2020/2021-1', 'Kessie123'),
(802, '51800437', 'ABBAS. Abdul-Karim', 'English', 26, 46, 72, 'Very Good', '2020/2021', 1, 8, '1A', '2020-11-09 18:02:38', '2020/2021-1', 'Kessie123'),
(866, '51802181', 'OCRAN Victor', 'English', 30, 47, 77, 'Very Good', '2020/2021', 1, 11, '1C', '2020-11-09 18:03:04', '2020/2021-1', 'Kessie123'),
(865, '51800483', 'OBODAI SAI.Edmund', 'English', 28, 46, 74, 'Very Good', '2020/2021', 1, 13, '1C', '2020-11-09 18:03:04', '2020/2021-1', 'Kessie123'),
(854, 'DIT05170067', 'MICHAEL Agyapong Kwarteng', 'English', 30, 49, 79, 'Very Good', '2020/2021', 1, 20, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(844, '51800470', 'DAYYAN.Issahaku', 'English', 28, 38, 66, 'Good', '2020/2021', 1, 36, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(842, '51800468', 'CUDJOE.Joseph', 'English', 29, 50, 79, 'Very Good', '2020/2021', 1, 4, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(848, '51800472', 'GYETUA DANQUAH.Richmond', 'English', 31, 53, 84, 'Excellent', '2020/2021', 1, 3, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(841, '51800467', 'BUDU.Charles', 'English', 28, 49, 77, 'Very Good', '2020/2021', 1, 11, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(830, '51800458', 'BAAH.Desmond', 'English', 32, 34, 66, 'Good', '2020/2021', 1, 40, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(828, 'DIT05170039', 'AYILGIA Desmond', 'English', 34, 51, 85, 'Excellent', '2020/2021', 1, 23, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(831, '51800459', 'BINEY.Kish Daniel', 'English', 27, 48, 75, 'Very Good', '2020/2021', 1, 5, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(829, '51800457', 'AZIAH.Daniel', 'English', 33, 40, 73, 'Very Good', '2020/2021', 1, 37, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(863, '51800482', 'NYANTAKYI.David', 'English', 38, 34, 72, 'Very Good', '2020/2021', 1, 17, '1C', '2020-11-09 18:03:04', '2020/2021-1', 'Kessie123'),
(853, '51800474', 'MENSAH ABRAMPAH.Shadrack', 'English', 27, 41, 68, 'Good', '2020/2021', 1, 33, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(836, 'DIT05170049', 'BOATENG Asare', 'English', 27, 44, 71, 'Very Good', '2020/2021', 1, 21, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(833, '51800461', 'BOAHENE.Prince', 'English', 26, 52, 78, 'Very Good', '2020/2021', 1, 6, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(835, 'DHN05170004', 'BOAKYE Joel', 'English', 32, 53, 85, 'Excellent', '2020/2021', 1, 1, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(847, 'DIT05170058', 'GIBRINE Adiza Adamu', 'English', 29, 27, 56, 'Pass', '2020/2021', 1, 38, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(834, '51800462', 'BOAKYE AGYEMANG.Jnr Mensah', 'English', 30, 27, 57, 'Pass', '2020/2021', 1, 39, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(837, '51800463', 'BOATENG.Bismark', 'English', 28, 46, 74, 'Very Good', '2020/2021', 1, 32, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(832, '51800460', 'BLAY.Goka Simon', 'English', 31, 36, 67, 'Good', '2020/2021', 1, 22, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(846, '51800471', 'FAISAL.Halid Dene', 'English', 29, 52, 81, 'Excellent', '2020/2021', 1, 2, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(838, '51800464', 'BORLABI.Godfred Borketey', 'English', 27, 45, 72, 'Very Good', '2020/2021', 1, 29, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(818, 'DWD05170001', 'AMOAH Gyamfuaah Ellen', 'English', 28, 41, 69, 'Good', '2020/2021', 1, 18, '1A', '2020-11-09 18:02:39', '2020/2021-1', 'Kessie123'),
(810, '51800444', 'ADOMAKO.Eric', 'English', 26, 36, 62, 'Good', '2020/2021', 1, 11, '1A', '2020-11-09 18:02:38', '2020/2021-1', 'Kessie123'),
(804, 'DIT05170011', 'ABDUL-Malik Firdaus', 'English', 26, 47, 73, 'Very Good', '2020/2021', 1, 3, '1A', '2020-11-09 18:02:38', '2020/2021-1', 'Kessie123'),
(812, '51800445', 'AGYAPONG.Alexander', 'English', 26, 27, 53, 'Pass', '2020/2021', 1, 19, '1A', '2020-11-09 18:02:38', '2020/2021-1', 'Kessie123'),
(811, '51800443', 'ADOMAKO.Prince', 'English', 26, 52, 78, 'Very Good', '2020/2021', 1, 4, '1A', '2020-11-09 18:02:38', '2020/2021-1', 'Kessie123'),
(826, '51800455', 'ASOMANI.Williams', 'English', 31, 47, 78, 'Very Good', '2020/2021', 1, 12, '1B', '2020-11-09 18:02:53', '2020/2021-1', 'Kessie123'),
(819, '51800450', 'ANOKYE.Phinehas Boakye', 'English', 29, 49, 78, 'Very Good', '2020/2021', 1, 16, '1A', '2020-11-09 18:02:39', '2020/2021-1', 'Kessie123'),
(901, '51800444', 'ADOMAKO.Eric', 'Creative Art', 26, 36, 62, 'Good', '2020/2021', 1, 19, '1A', '2020-11-09 19:25:26', '2020/2021-1', 'Kessie123'),
(903, '51800445', 'AGYAPONG.Alexander', 'Creative Art', 26, 27, 53, 'Pass', '2020/2021', 1, 22, '1A', '2020-11-09 19:25:26', '2020/2021-1', 'Kessie123'),
(898, 'DIT05170007', 'ADARKWAH Emmanuel', 'Creative Art', 28, 40, 68, 'Good', '2020/2021', 1, 16, '1A', '2020-11-09 19:25:26', '2020/2021-1', 'Kessie123'),
(900, '51800442', 'ADJEI.Anthony Clifford', 'Creative Art', 27, 48, 75, 'Very Good', '2020/2021', 1, 8, '1A', '2020-11-09 19:25:26', '2020/2021-1', 'Kessie123'),
(899, '51800441', 'ADIKU OFORI.Harold', 'Creative Art', 28, 34, 62, 'Good', '2020/2021', 1, 20, '1A', '2020-11-09 19:25:26', '2020/2021-1', 'Kessie123'),
(893, '51800437', 'ABBAS. Abdul-Karim', 'Creative Art', 26, 46, 72, 'Very Good', '2020/2021', 1, 13, '1A', '2020-11-09 19:25:25', '2020/2021-1', 'Kessie123'),
(892, 'st123', 'KESSIE.Bismark', 'Creative Art', 26, 34, 60, 'Good', '2020/2021', 1, 21, '1A', '2020-11-09 19:25:25', '2020/2021-1', 'Kessie123'),
(904, '51800446', 'AGYEKUM.Ernest Tabi', 'Creative Art', 28, 53, 81, 'Excellent', '2020/2021', 1, 1, '1A', '2020-11-09 19:25:26', '2020/2021-1', 'Kessie123'),
(902, '51800443', 'ADOMAKO.Prince', 'Creative Art', 26, 52, 78, 'Very Good', '2020/2021', 1, 4, '1A', '2020-11-09 19:25:26', '2020/2021-1', 'Kessie123');

-- --------------------------------------------------------

--
-- Table structure for table `message_config`
--

DROP TABLE IF EXISTS `message_config`;
CREATE TABLE IF NOT EXISTS `message_config` (
  `sid` varchar(200) NOT NULL,
  `api_key` text NOT NULL,
  `message_url` varchar(200) NOT NULL,
  `sender` varchar(200) NOT NULL,
  PRIMARY KEY (`sid`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `message_config`
--

INSERT INTO `message_config` (`sid`, `api_key`, `message_url`, `sender`) VALUES
('Kessie123', 'rrrtrtwerererewrwerwerewr  erwerwerewrwe', 'egrgrg', 'fgfgfgf');

-- --------------------------------------------------------

--
-- Table structure for table `payroll`
--

DROP TABLE IF EXISTS `payroll`;
CREATE TABLE IF NOT EXISTS `payroll` (
  `ID` varchar(200) NOT NULL,
  `Staff_ID` varchar(200) NOT NULL,
  `Name` char(200) NOT NULL,
  `Working_Days` int(11) DEFAULT NULL,
  `Days_Present` int(11) DEFAULT NULL,
  `Total_Hours` int(11) DEFAULT NULL,
  `Hours_Present` int(11) DEFAULT NULL,
  `Initial_Salary` int(11) DEFAULT NULL,
  `Payment` int(11) DEFAULT NULL,
  `Month` int(11) DEFAULT NULL,
  `Total_Leave_Days` int(11) NOT NULL,
  `Academic` varchar(200) DEFAULT NULL,
  `Date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `sid` varchar(200) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `profit`
--

DROP TABLE IF EXISTS `profit`;
CREATE TABLE IF NOT EXISTS `profit` (
  `Profit_ID` varchar(200) NOT NULL,
  `Academic` varchar(200) NOT NULL,
  `Term` int(4) NOT NULL,
  `Income` decimal(10,2) NOT NULL,
  `Expenses` decimal(10,2) NOT NULL,
  `Profit` decimal(10,2) NOT NULL,
  `Date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `sid` varchar(200) NOT NULL,
  PRIMARY KEY (`Profit_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `profit`
--

INSERT INTO `profit` (`Profit_ID`, `Academic`, `Term`, `Income`, `Expenses`, `Profit`, `Date`, `sid`) VALUES
('NP2020/2021-1', '2020/2021', 1, '256.00', '0.00', '256.00', '2020-11-09 23:33:38', 'Kessie123');

-- --------------------------------------------------------

--
-- Table structure for table `salary`
--

DROP TABLE IF EXISTS `salary`;
CREATE TABLE IF NOT EXISTS `salary` (
  `staff_id` varchar(200) NOT NULL,
  `salary` decimal(10,2) NOT NULL,
  `hours` int(1) NOT NULL,
  `date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `onleave` tinyint(4) NOT NULL DEFAULT '0',
  `leave_type` varchar(200) DEFAULT NULL,
  `Start_Date` date DEFAULT NULL,
  `End_Date` date DEFAULT NULL,
  `academic` varchar(200) NOT NULL,
  `sid` varchar(200) NOT NULL,
  PRIMARY KEY (`staff_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `school_profile`
--

DROP TABLE IF EXISTS `school_profile`;
CREATE TABLE IF NOT EXISTS `school_profile` (
  `sid` varchar(200) NOT NULL,
  `name` varchar(200) NOT NULL,
  `password` varchar(200) NOT NULL,
  `address` text NOT NULL,
  `phone` varchar(14) NOT NULL,
  `momo` varchar(200) DEFAULT NULL,
  `town` varchar(200) NOT NULL,
  `email` varchar(200) NOT NULL,
  `logo` blob,
  `sign_academic` blob,
  `sign_head` blob,
  `sign_finance` blob,
  `website` varchar(100) DEFAULT NULL,
  `active` tinyint(4) NOT NULL DEFAULT '1',
  PRIMARY KEY (`sid`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `school_profile`
--

INSERT INTO `school_profile` (`sid`, `name`, `password`, `address`, `phone`, `momo`, `town`, `email`, `logo`, `sign_academic`, `sign_head`, `sign_finance`, `website`, `active`) VALUES
('Kessie123', 'KESSIE COMPLEX', 'admin', '123', '0542089814', '0542089814', 'Tafo Adompom', 'f@gmail.com', 0xffd8ffe000104a46494600010101006000600000ffe100b24578696600004d4d002a000000080003013b0002000000080000003287690004000000010000003a9c9d0001000000100000009a000000004a552d4e494f5200000490030002000000140000007090040002000000140000008492910002000000033237000092920002000000033237000000000000323032303a30373a30392031383a32373a313000323032303a30373a30392031383a32373a31300000004a0055002d004e0049004f0052000000ffdb00430007050506050407060506080707080a110b0a09090a150f100c1118151a19181518171b1e27211b1d251d1718222e222528292b2c2b1a202f332f2a32272a2b2affdb0043010708080a090a140b0b142a1c181c2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2affc000110800d700ce03012200021101031101ffc4001f0000010501010101010100000000000000000102030405060708090a0bffc400b5100002010303020403050504040000017d01020300041105122131410613516107227114328191a1082342b1c11552d1f02433627282090a161718191a25262728292a3435363738393a434445464748494a535455565758595a636465666768696a737475767778797a838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae1e2e3e4e5e6e7e8e9eaf1f2f3f4f5f6f7f8f9faffc4001f0100030101010101010101010000000000000102030405060708090a0bffc400b51100020102040403040705040400010277000102031104052131061241510761711322328108144291a1b1c109233352f0156272d10a162434e125f11718191a262728292a35363738393a434445464748494a535455565758595a636465666768696a737475767778797a82838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae2e3e4e5e6e7e8e9eaf2f3f4f5f6f7f8f9faffda000c03010002110311003f00fa468a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a00fffd9, 0xffd8ffe000104a46494600010101006000600000ffe100464578696600004d4d002a000000080002013b000200000008000000269c9d0001000000100000002e000000004a552d4e494f52004a0055002d004e0049004f0052000000ffdb00430007050506050407060506080707080a110b0a09090a150f100c1118151a19181518171b1e27211b1d251d1718222e222528292b2c2b1a202f332f2a32272a2b2affdb0043010708080a090a140b0b142a1c181c2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2affc0001108005900d903012200021101031101ffc4001f0000010501010101010100000000000000000102030405060708090a0bffc400b5100002010303020403050504040000017d01020300041105122131410613516107227114328191a1082342b1c11552d1f02433627282090a161718191a25262728292a3435363738393a434445464748494a535455565758595a636465666768696a737475767778797a838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae1e2e3e4e5e6e7e8e9eaf1f2f3f4f5f6f7f8f9faffc4001f0100030101010101010101010000000000000102030405060708090a0bffc400b51100020102040403040705040400010277000102031104052131061241510761711322328108144291a1b1c109233352f0156272d10a162434e125f11718191a262728292a35363738393a434445464748494a535455565758595a636465666768696a737475767778797a82838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae2e3e4e5e6e7e8e9eaf2f3f4f5f6f7f8f9faffda000c03010002110311003f00fa468a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a00fffd9, 0xffd8ffe000104a46494600010101006000600000ffe100464578696600004d4d002a000000080002013b000200000008000000269c9d0001000000100000002e000000004a552d4e494f52004a0055002d004e0049004f0052000000ffdb00430007050506050407060506080707080a110b0a09090a150f100c1118151a19181518171b1e27211b1d251d1718222e222528292b2c2b1a202f332f2a32272a2b2affdb0043010708080a090a140b0b142a1c181c2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2affc0001108005900d903012200021101031101ffc4001f0000010501010101010100000000000000000102030405060708090a0bffc400b5100002010303020403050504040000017d01020300041105122131410613516107227114328191a1082342b1c11552d1f02433627282090a161718191a25262728292a3435363738393a434445464748494a535455565758595a636465666768696a737475767778797a838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae1e2e3e4e5e6e7e8e9eaf1f2f3f4f5f6f7f8f9faffc4001f0100030101010101010101010000000000000102030405060708090a0bffc400b51100020102040403040705040400010277000102031104052131061241510761711322328108144291a1b1c109233352f0156272d10a162434e125f11718191a262728292a35363738393a434445464748494a535455565758595a636465666768696a737475767778797a82838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae2e3e4e5e6e7e8e9eaf2f3f4f5f6f7f8f9faffda000c03010002110311003f00fa468a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a00fffd9, 0xffd8ffe000104a46494600010101006000600000ffe100464578696600004d4d002a000000080002013b000200000008000000269c9d0001000000100000002e000000004a552d4e494f52004a0055002d004e0049004f0052000000ffdb00430007050506050407060506080707080a110b0a09090a150f100c1118151a19181518171b1e27211b1d251d1718222e222528292b2c2b1a202f332f2a32272a2b2affdb0043010708080a090a140b0b142a1c181c2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2affc0001108005900d903012200021101031101ffc4001f0000010501010101010100000000000000000102030405060708090a0bffc400b5100002010303020403050504040000017d01020300041105122131410613516107227114328191a1082342b1c11552d1f02433627282090a161718191a25262728292a3435363738393a434445464748494a535455565758595a636465666768696a737475767778797a838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae1e2e3e4e5e6e7e8e9eaf1f2f3f4f5f6f7f8f9faffc4001f0100030101010101010101010000000000000102030405060708090a0bffc400b51100020102040403040705040400010277000102031104052131061241510761711322328108144291a1b1c109233352f0156272d10a162434e125f11718191a262728292a35363738393a434445464748494a535455565758595a636465666768696a737475767778797a82838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae2e3e4e5e6e7e8e9eaf2f3f4f5f6f7f8f9faffda000c03010002110311003f00fa468a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a00fffd9, 'r.com', 1);

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
CREATE TABLE IF NOT EXISTS `staff` (
  `staff_id` varchar(200) NOT NULL,
  `fullname` char(200) NOT NULL,
  `dob` date DEFAULT NULL,
  `gender` char(10) DEFAULT NULL,
  `phone` varchar(14) DEFAULT NULL,
  `address` text,
  `nextkin` char(200) DEFAULT NULL,
  `kinphone` varchar(20) DEFAULT NULL,
  `email` varchar(200) DEFAULT NULL,
  `classes` text,
  `hired_date` date DEFAULT NULL,
  `qualification` char(200) DEFAULT NULL,
  `accountname` varchar(200) DEFAULT NULL,
  `employment_type` char(200) DEFAULT NULL,
  `accountno` varchar(200) DEFAULT NULL,
  `branch` varchar(200) DEFAULT NULL,
  `image` blob,
  `fingerprint` longblob,
  `sid` varchar(200) NOT NULL,
  PRIMARY KEY (`staff_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`staff_id`, `fullname`, `dob`, `gender`, `phone`, `address`, `nextkin`, `kinphone`, `email`, `classes`, `hired_date`, `qualification`, `accountname`, `employment_type`, `accountno`, `branch`, `image`, `fingerprint`, `sid`) VALUES
('ks1233', 'KESSIE,Bismark', '1992-10-31', 'Male', '024234343', 'fdfsdfdsf', 'Sfdfdf', '3423432434', 'fd@gdd.com', NULL, '2020-10-31', 'HND IT', 'sdff', 'Non Teaching Staff', '2434343423', 'sdfdfd', 0xffd8ffe000104a46494600010101006000600000ffe100b24578696600004d4d002a000000080003013b0002000000080000003287690004000000010000003a9c9d0001000000100000009a000000004a552d4e494f5200000490030002000000140000007090040002000000140000008492910002000000033237000092920002000000033237000000000000323032303a30373a30392031383a32373a313000323032303a30373a30392031383a32373a31300000004a0055002d004e0049004f0052000000ffdb00430007050506050407060506080707080a110b0a09090a150f100c1118151a19181518171b1e27211b1d251d1718222e222528292b2c2b1a202f332f2a32272a2b2affdb0043010708080a090a140b0b142a1c181c2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2a2affc000110800d700ce03012200021101031101ffc4001f0000010501010101010100000000000000000102030405060708090a0bffc400b5100002010303020403050504040000017d01020300041105122131410613516107227114328191a1082342b1c11552d1f02433627282090a161718191a25262728292a3435363738393a434445464748494a535455565758595a636465666768696a737475767778797a838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae1e2e3e4e5e6e7e8e9eaf1f2f3f4f5f6f7f8f9faffc4001f0100030101010101010101010000000000000102030405060708090a0bffc400b51100020102040403040705040400010277000102031104052131061241510761711322328108144291a1b1c109233352f0156272d10a162434e125f11718191a262728292a35363738393a434445464748494a535455565758595a636465666768696a737475767778797a82838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae2e3e4e5e6e7e8e9eaf2f3f4f5f6f7f8f9faffda000c03010002110311003f00fa468a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a00fffd9, NULL, 'Kessie123'),
('g66', 'JUNIOR,Kwaku', '1990-10-31', 'Male', '034342434', 'sdfdsfdfdsf', 'Svs', '34323243434234', 'df@gg.com', '1A', '2020-10-31', 'Diploma', 'sfgdfd', 'Teaching Staff', '3423234324243', 'ssgds', 0xffd8ffe000104a46494600010101006000600000ffe1005a4578696600004d4d002a00000008000503010005000000010000004a03030001000000010000000051100001000000010100000051110004000000010000000051120004000000010000000000000000000186a00000b18fffdb004300080606070605080707070909080a0c140d0c0b0b0c1912130f141d1a1f1e1d1a1c1c20242e2720222c231c1c2837292c30313434341f27393d38323c2e333432ffdb0043010909090c0b0c180d0d1832211c213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232ffc00011080064006403012200021101031101ffc4001f0000010501010101010100000000000000000102030405060708090a0bffc400b5100002010303020403050504040000017d01020300041105122131410613516107227114328191a1082342b1c11552d1f02433627282090a161718191a25262728292a3435363738393a434445464748494a535455565758595a636465666768696a737475767778797a838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae1e2e3e4e5e6e7e8e9eaf1f2f3f4f5f6f7f8f9faffc4001f0100030101010101010101010000000000000102030405060708090a0bffc400b51100020102040403040705040400010277000102031104052131061241510761711322328108144291a1b1c109233352f0156272d10a162434e125f11718191a262728292a35363738393a434445464748494a535455565758595a636465666768696a737475767778797a82838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae2e3e4e5e6e7e8e9eaf2f3f4f5f6f7f8f9faffda000c03010002110311003f00f9fe8a28a0028a28a0028ad9d2f436ba48ee676516ed92155be66c1c7e0339f7e3dc1ae920b582d576c112463001c0e4fd4f7a00e0a8af42ac4d5b443752b5cdb1512301ba32000c40ea31dcf1d7a9c9cd00731453e58a482568a552aea7041a65001451450014514500145145001562c6dbed97b1419c073c9f61c9fc7155eb67c35ff21193feb91fe62803a8550aa15405503000180052d769a1780ffb42ce1bdbbbcd90caa1d5221f360fa93d3f235d8e9fe15d1b4dc18acd24907fcb49be73faf03f0af36be694293715ab3b29606acd5de88f2cb0d0754d4cafd96ca5743ff2d08dabf99e2a5d67c37a8686b13dd2234720e1e324a83e878eb5ecf50ddda417d6b25b5cc6b24320c329ae059c4f9d371f77f13aff00b3a3cbbea7ce3afd92cf64d70aa7cd84672ab9257b8fa0ebf857275ea1e32d1c6893deda249e647e433a13d7041e0fbd797d7bd09c671528eccf2a5171938be8145145592145145001451450015de780fc1f79ace9d79ab5bcd1feed8dbc7011cbb6158f3d070463d79e98e783aefbe1d78e8f87658f489ede26b4babb4633bcbe5f93bb6ab31241040001edd0f3e9cb8c9568d2bd0f8bf4ea6f8754dced5763dbf4047b6f0ed8a4ca6368e101c30c15c75cd4ba6eaf67ab4723d9c85c46db5b2a47f3abdd460d57b4b0b5b0464b48121576dcc106326be4e52526e4f767bf18b8a49162a8586b165a9cd3c56b2ef680e1c6d23f11ea38abf55adac2d2ce495edade389a53b9ca8c6e352b96cee3d6e713e2bf0b5df88f5f9911bc8b636c2369d9720139e00e326bc1afece4d3b52bab19995a5b699e172872a4a920e33db8afa3fc73e2e87c21a65adcbdb2dd4934fe5883cf11b15c125870781c0e9fc42be70bfbc9351d46e6f660a25b995a670a30373124e3db9afa1caea579c7de5ee2492fd4f1f1d1a517eefc5d4af451457ae700514514005145140051451401f4bf803c543c57e1b4b890e2f6d8886e8165cb3e387c0e81b92381c860338cd7535f2bf84e796dfc5fa3c90caf1bfdb225dc8c41c16008fa10483ec6be984bf7030ea1bdfa57c86674a185ad6be92d7d0fa0c0ce75e9ddee8d0a0024800649e805523a80c711f3ee6bcefe2f5edc378461412b2249788ae8a480c36b9c1f51900f3dc0ae3a12856ab1a517b9d1554a9d3736b6386f89de2b5f12788fc8b620d8e9fbe189832b091b3f3c808fe1385c72785078c915c4d1457dbd1a51a50508ec8f9aa93739394ba8514515a10145145001451450015de7847e1bdceb71457fa9bb5ae9f22928a8712c83f848c82029eb93c9c74c1069df0dbc216faddc4baa6a11f99696b2048e2382b2c98c9dddf0015e31839f4041f68af4b0983535cf3d8f1f1f983a6fd952dfab383d73c27a7e876b0dde8f64b0796e4bb8259c646010cc4903b6338e6ba7d17588756b4560c05c28c491f707d47b569ba2c88c8ea195860a91904572b79e0dfdf99b4ebaf24e7211f3f2fd08e6a338c928e654542fcb28ecedf7ab1194e75530351ca5ef27bddfea754cca8a598855032493c0ae175dbbff00848f55874db5025b70db7e65cab9ce4b11dc0c7e9560f85358b8f92eb52568fde477fd0e2ba1d2343b5d2233e565e66186958727d87a0af3f25e188602b7b7ab3e692db4b257fccefcdb88de2e97b1a51e55d75d59cc6b9f0bf46beb591b4c43657b82c843931bb1c1c329ce0751f2e319e8718af23d6746bdd075392c2fe2d92a721872aebd994f707ffac704115f4b562f89bc3365e27d34dadd0d92a64c13a8cb44dfd41ee3bfb1008f6f11828cd5e0accf1f0998ce9cb96a3bc7f147ce7454b756d359ddcd6b709b2686468e45c838607046471d45455e2ec7d2277d505145140051451401f47f85ac974ef0ae976c2168596d91a48db395761b9f39e41dc4f1dab5ebcb3fe1727fd407ff00273ffb0a3fe1727fd407ff00273ffb0af7638cc3c524a5f833e5e597e2a527271dfcd7f99ea7457967fc2e4ffa80ff00e4e7ff006147fc2e4ffa80ff00e4e7ff006155f5da1fcdf8317f66e2bf97f15fe67a9d15e59ff0b93fea03ff00939ffd851ff0b93fea03ff00939ffd851f5da1fcdf830fecdc57f2fe2bfccf53a2bcb3fe1727fd407ff273ff00b0a3fe1727fd407ff273ff00b0a3ebb43f9bf061fd9b8afe5fc57f998bf1574ffb2f8b45daacbb2f20572cc3e5debf290a71d805247bfb8ae1abaaf1978cbfe12dfb17fa07d93ecbbffe5b799bb76dff0064631b7f5ae56bc6c44a32aadc3667d0e12338d18c6a2b341451456274051451400514514005145140051451400514514005145140051451401fffd9, NULL, 'Kessie123');

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

DROP TABLE IF EXISTS `student`;
CREATE TABLE IF NOT EXISTS `student` (
  `student_id` varchar(200) NOT NULL,
  `fullname` char(200) NOT NULL,
  `gender` char(10) DEFAULT NULL,
  `dob` date DEFAULT NULL,
  `father_name` char(200) DEFAULT NULL,
  `mother_name` char(200) DEFAULT NULL,
  `father_contact` varchar(14) DEFAULT NULL,
  `mother_contact` varchar(14) DEFAULT NULL,
  `address` text,
  `class` varchar(5) DEFAULT NULL,
  `nationality` char(200) DEFAULT NULL,
  `disability` text,
  `religion` char(20) DEFAULT NULL,
  `image` longblob,
  `admission_date` date DEFAULT NULL,
  `status` char(9) NOT NULL,
  `academic` varchar(200) NOT NULL,
  `term` int(1) NOT NULL,
  `promoted` varchar(200) DEFAULT NULL,
  `previous_class` varchar(200) DEFAULT NULL,
  `sid` varchar(200) NOT NULL,
  PRIMARY KEY (`student_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`student_id`, `fullname`, `gender`, `dob`, `father_name`, `mother_name`, `father_contact`, `mother_contact`, `address`, `class`, `nationality`, `disability`, `religion`, `image`, `admission_date`, `status`, `academic`, `term`, `promoted`, `previous_class`, `sid`) VALUES
('st123', 'KESSIE.Bismark', 'Male', '2010-11-02', 'Dfd', 'Sdfdfd', '342123232323', '13123232323', 'afaf', '1A', 'Ghana', 'No', 'Christian', 0xffd8ffe000104a46494600010101006000600000ffe1005a4578696600004d4d002a00000008000503010005000000010000004a03030001000000010000000051100001000000010100000051110004000000010000000051120004000000010000000000000000000186a00000b18fffdb004300080606070605080707070909080a0c140d0c0b0b0c1912130f141d1a1f1e1d1a1c1c20242e2720222c231c1c2837292c30313434341f27393d38323c2e333432ffdb0043010909090c0b0c180d0d1832211c213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232ffc00011080064006403012200021101031101ffc4001f0000010501010101010100000000000000000102030405060708090a0bffc400b5100002010303020403050504040000017d01020300041105122131410613516107227114328191a1082342b1c11552d1f02433627282090a161718191a25262728292a3435363738393a434445464748494a535455565758595a636465666768696a737475767778797a838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae1e2e3e4e5e6e7e8e9eaf1f2f3f4f5f6f7f8f9faffc4001f0100030101010101010101010000000000000102030405060708090a0bffc400b51100020102040403040705040400010277000102031104052131061241510761711322328108144291a1b1c109233352f0156272d10a162434e125f11718191a262728292a35363738393a434445464748494a535455565758595a636465666768696a737475767778797a82838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae2e3e4e5e6e7e8e9eaf2f3f4f5f6f7f8f9faffda000c03010002110311003f00f9fe8a28a0028a28a0028ad9d2f436ba48ee676516ed92155be66c1c7e0339f7e3dc1ae920b582d576c112463001c0e4fd4f7a00e0a8af42ac4d5b443752b5cdb1512301ba32000c40ea31dcf1d7a9c9cd00731453e58a482568a552aea7041a65001451450014514500145145001562c6dbed97b1419c073c9f61c9fc7155eb67c35ff21193feb91fe62803a8550aa15405503000180052d769a1780ffb42ce1bdbbbcd90caa1d5221f360fa93d3f235d8e9fe15d1b4dc18acd24907fcb49be73faf03f0af36be694293715ab3b29606acd5de88f2cb0d0754d4cafd96ca5743ff2d08dabf99e2a5d67c37a8686b13dd2234720e1e324a83e878eb5ecf50ddda417d6b25b5cc6b24320c329ae059c4f9d371f77f13aff00b3a3cbbea7ce3afd92cf64d70aa7cd84672ab9257b8fa0ebf857275ea1e32d1c6893deda249e647e433a13d7041e0fbd797d7bd09c671528eccf2a5171938be8145145592145145001451450015de780fc1f79ace9d79ab5bcd1feed8dbc7011cbb6158f3d070463d79e98e783aefbe1d78e8f87658f489ede26b4babb4633bcbe5f93bb6ab31241040001edd0f3e9cb8c9568d2bd0f8bf4ea6f8754dced5763dbf4047b6f0ed8a4ca6368e101c30c15c75cd4ba6eaf67ab4723d9c85c46db5b2a47f3abdd460d57b4b0b5b0464b48121576dcc106326be4e52526e4f767bf18b8a49162a8586b165a9cd3c56b2ef680e1c6d23f11ea38abf55adac2d2ce495edade389a53b9ca8c6e352b96cee3d6e713e2bf0b5df88f5f9911bc8b636c2369d9720139e00e326bc1afece4d3b52bab19995a5b699e172872a4a920e33db8afa3fc73e2e87c21a65adcbdb2dd4934fe5883cf11b15c125870781c0e9fc42be70bfbc9351d46e6f660a25b995a670a30373124e3db9afa1caea579c7de5ee2492fd4f1f1d1a517eefc5d4af451457ae700514514005145140051451401f4bf803c543c57e1b4b890e2f6d8886e8165cb3e387c0e81b92381c860338cd7535f2bf84e796dfc5fa3c90caf1bfdb225dc8c41c16008fa10483ec6be984bf7030ea1bdfa57c86674a185ad6be92d7d0fa0c0ce75e9ddee8d0a0024800649e805523a80c711f3ee6bcefe2f5edc378461412b2249788ae8a480c36b9c1f51900f3dc0ae3a12856ab1a517b9d1554a9d3736b6386f89de2b5f12788fc8b620d8e9fbe189832b091b3f3c808fe1385c72785078c915c4d1457dbd1a51a50508ec8f9aa93739394ba8514515a10145145001451450015de7847e1bdceb71457fa9bb5ae9f22928a8712c83f848c82029eb93c9c74c1069df0dbc216faddc4baa6a11f99696b2048e2382b2c98c9dddf0015e31839f4041f68af4b0983535cf3d8f1f1f983a6fd952dfab383d73c27a7e876b0dde8f64b0796e4bb8259c646010cc4903b6338e6ba7d17588756b4560c05c28c491f707d47b569ba2c88c8ea195860a91904572b79e0dfdf99b4ebaf24e7211f3f2fd08e6a338c928e654542fcb28ecedf7ab1194e75530351ca5ef27bddfea754cca8a598855032493c0ae175dbbff00848f55874db5025b70db7e65cab9ce4b11dc0c7e9560f85358b8f92eb52568fde477fd0e2ba1d2343b5d2233e565e66186958727d87a0af3f25e188602b7b7ab3e692db4b257fccefcdb88de2e97b1a51e55d75d59cc6b9f0bf46beb591b4c43657b82c843931bb1c1c329ce0751f2e319e8718af23d6746bdd075392c2fe2d92a721872aebd994f707ffac704115f4b562f89bc3365e27d34dadd0d92a64c13a8cb44dfd41ee3bfb1008f6f11828cd5e0accf1f0998ce9cb96a3bc7f147ce7454b756d359ddcd6b709b2686468e45c838607046471d45455e2ec7d2277d505145140051451401f47f85ac974ef0ae976c2168596d91a48db395761b9f39e41dc4f1dab5ebcb3fe1727fd407ff00273ffb0a3fe1727fd407ff00273ffb0af7638cc3c524a5f833e5e597e2a527271dfcd7f99ea7457967fc2e4ffa80ff00e4e7ff006147fc2e4ffa80ff00e4e7ff006155f5da1fcdf8317f66e2bf97f15fe67a9d15e59ff0b93fea03ff00939ffd851ff0b93fea03ff00939ffd851f5da1fcdf830fecdc57f2fe2bfccf53a2bcb3fe1727fd407ff273ff00b0a3fe1727fd407ff273ff00b0a3ebb43f9bf061fd9b8afe5fc57f998bf1574ffb2f8b45daacbb2f20572cc3e5debf290a71d805247bfb8ae1abaaf1978cbfe12dfb17fa07d93ecbbffe5b799bb76dff0064631b7f5ae56bc6c44a32aadc3667d0e12338d18c6a2b341451456274051451400514514005145140051451400514514005145140051451401fffd9, '2020-11-02', 'Active', '2020/2021', 1, NULL, NULL, 'Kessie123'),
('51800437', 'ABBAS. Abdul-Karim', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42E+11', '13123232323', ' afaf', '1A', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2022', 1, NULL, NULL, 'Kessie123'),
('51800438', 'ABDUL GANIYU.Sadick', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42E+11', '13123232323', ' afaf', '1A', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2023', 1, NULL, NULL, 'Kessie123'),
('DIT05170011', 'ABDUL-Malik Firdaus', 'Female', NULL, ' Dfd', ' Sdfdfd', '3.42E+11', '13123232323', ' afaf', '1A', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2024', 1, NULL, NULL, 'Kessie123'),
('51800439', 'ABUBAKAR.Farouk', ' Male', '2019-06-29', ' Dfd', ' Sdfdfd', '3.42E+11', '13123232323', ' afaf', '1A', '', '', '', 0xffd8ffe000104a46494600010101006000600000ffe1005a4578696600004d4d002a00000008000503010005000000010000004a03030001000000010000000051100001000000010100000051110004000000010000000051120004000000010000000000000000000186a00000b18fffdb004300080606070605080707070909080a0c140d0c0b0b0c1912130f141d1a1f1e1d1a1c1c20242e2720222c231c1c2837292c30313434341f27393d38323c2e333432ffdb0043010909090c0b0c180d0d1832211c213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232ffc00011080064006403012200021101031101ffc4001f0000010501010101010100000000000000000102030405060708090a0bffc400b5100002010303020403050504040000017d01020300041105122131410613516107227114328191a1082342b1c11552d1f02433627282090a161718191a25262728292a3435363738393a434445464748494a535455565758595a636465666768696a737475767778797a838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae1e2e3e4e5e6e7e8e9eaf1f2f3f4f5f6f7f8f9faffc4001f0100030101010101010101010000000000000102030405060708090a0bffc400b51100020102040403040705040400010277000102031104052131061241510761711322328108144291a1b1c109233352f0156272d10a162434e125f11718191a262728292a35363738393a434445464748494a535455565758595a636465666768696a737475767778797a82838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae2e3e4e5e6e7e8e9eaf2f3f4f5f6f7f8f9faffda000c03010002110311003f00f9fe8a28a0028a28a0028ad9d2f436ba48ee676516ed92155be66c1c7e0339f7e3dc1ae920b582d576c112463001c0e4fd4f7a00e0a8af42ac4d5b443752b5cdb1512301ba32000c40ea31dcf1d7a9c9cd00731453e58a482568a552aea7041a65001451450014514500145145001562c6dbed97b1419c073c9f61c9fc7155eb67c35ff21193feb91fe62803a8550aa15405503000180052d769a1780ffb42ce1bdbbbcd90caa1d5221f360fa93d3f235d8e9fe15d1b4dc18acd24907fcb49be73faf03f0af36be694293715ab3b29606acd5de88f2cb0d0754d4cafd96ca5743ff2d08dabf99e2a5d67c37a8686b13dd2234720e1e324a83e878eb5ecf50ddda417d6b25b5cc6b24320c329ae059c4f9d371f77f13aff00b3a3cbbea7ce3afd92cf64d70aa7cd84672ab9257b8fa0ebf857275ea1e32d1c6893deda249e647e433a13d7041e0fbd797d7bd09c671528eccf2a5171938be8145145592145145001451450015de780fc1f79ace9d79ab5bcd1feed8dbc7011cbb6158f3d070463d79e98e783aefbe1d78e8f87658f489ede26b4babb4633bcbe5f93bb6ab31241040001edd0f3e9cb8c9568d2bd0f8bf4ea6f8754dced5763dbf4047b6f0ed8a4ca6368e101c30c15c75cd4ba6eaf67ab4723d9c85c46db5b2a47f3abdd460d57b4b0b5b0464b48121576dcc106326be4e52526e4f767bf18b8a49162a8586b165a9cd3c56b2ef680e1c6d23f11ea38abf55adac2d2ce495edade389a53b9ca8c6e352b96cee3d6e713e2bf0b5df88f5f9911bc8b636c2369d9720139e00e326bc1afece4d3b52bab19995a5b699e172872a4a920e33db8afa3fc73e2e87c21a65adcbdb2dd4934fe5883cf11b15c125870781c0e9fc42be70bfbc9351d46e6f660a25b995a670a30373124e3db9afa1caea579c7de5ee2492fd4f1f1d1a517eefc5d4af451457ae700514514005145140051451401f4bf803c543c57e1b4b890e2f6d8886e8165cb3e387c0e81b92381c860338cd7535f2bf84e796dfc5fa3c90caf1bfdb225dc8c41c16008fa10483ec6be984bf7030ea1bdfa57c86674a185ad6be92d7d0fa0c0ce75e9ddee8d0a0024800649e805523a80c711f3ee6bcefe2f5edc378461412b2249788ae8a480c36b9c1f51900f3dc0ae3a12856ab1a517b9d1554a9d3736b6386f89de2b5f12788fc8b620d8e9fbe189832b091b3f3c808fe1385c72785078c915c4d1457dbd1a51a50508ec8f9aa93739394ba8514515a10145145001451450015de7847e1bdceb71457fa9bb5ae9f22928a8712c83f848c82029eb93c9c74c1069df0dbc216faddc4baa6a11f99696b2048e2382b2c98c9dddf0015e31839f4041f68af4b0983535cf3d8f1f1f983a6fd952dfab383d73c27a7e876b0dde8f64b0796e4bb8259c646010cc4903b6338e6ba7d17588756b4560c05c28c491f707d47b569ba2c88c8ea195860a91904572b79e0dfdf99b4ebaf24e7211f3f2fd08e6a338c928e654542fcb28ecedf7ab1194e75530351ca5ef27bddfea754cca8a598855032493c0ae175dbbff00848f55874db5025b70db7e65cab9ce4b11dc0c7e9560f85358b8f92eb52568fde477fd0e2ba1d2343b5d2233e565e66186958727d87a0af3f25e188602b7b7ab3e692db4b257fccefcdb88de2e97b1a51e55d75d59cc6b9f0bf46beb591b4c43657b82c843931bb1c1c329ce0751f2e319e8718af23d6746bdd075392c2fe2d92a721872aebd994f707ffac704115f4b562f89bc3365e27d34dadd0d92a64c13a8cb44dfd41ee3bfb1008f6f11828cd5e0accf1f0998ce9cb96a3bc7f147ce7454b756d359ddcd6b709b2686468e45c838607046471d45455e2ec7d2277d505145140051451401f47f85ac974ef0ae976c2168596d91a48db395761b9f39e41dc4f1dab5ebcb3fe1727fd407ff00273ffb0a3fe1727fd407ff00273ffb0af7638cc3c524a5f833e5e597e2a527271dfcd7f99ea7457967fc2e4ffa80ff00e4e7ff006147fc2e4ffa80ff00e4e7ff006155f5da1fcdf8317f66e2bf97f15fe67a9d15e59ff0b93fea03ff00939ffd851ff0b93fea03ff00939ffd851f5da1fcdf830fecdc57f2fe2bfccf53a2bcb3fe1727fd407ff273ff00b0a3fe1727fd407ff273ff00b0a3ebb43f9bf061fd9b8afe5fc57f998bf1574ffb2f8b45daacbb2f20572cc3e5debf290a71d805247bfb8ae1abaaf1978cbfe12dfb17fa07d93ecbbffe5b799bb76dff0064631b7f5ae56bc6c44a32aadc3667d0e12338d18c6a2b341451456274051451400514514005145140051451400514514005145140051451401fffd9, '2019-06-15', 'Active', ' 2020/2025', 1, NULL, NULL, 'Kessie123'),
('51800440', 'ADAM.Gadaf', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42E+11', '13123232323', ' afaf', '1A', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2026', 1, NULL, NULL, 'Kessie123'),
('DIT05170007', 'ADARKWAH Emmanuel', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42E+11', '13123232323', ' afaf', '1A', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2027', 1, NULL, NULL, 'Kessie123'),
('51800441', 'ADIKU OFORI.Harold', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42E+11', '13123232323', ' afaf', '1A', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2028', 1, NULL, NULL, 'Kessie123'),
('51800442', 'ADJEI.Anthony Clifford', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42E+11', '13123232323', ' afaf', '1A', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2029', 1, NULL, NULL, 'Kessie123'),
('51800444', 'ADOMAKO.Eric', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42E+11', '13123232323', ' afaf', '1A', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2030', 1, NULL, NULL, 'Kessie123'),
('51800443', 'ADOMAKO.Prince', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42E+11', '13123232323', ' afaf', '1A', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2031', 1, NULL, NULL, 'Kessie123'),
('51800445', 'AGYAPONG.Alexander', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42E+11', '13123232323', ' afaf', '1A', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2032', 1, NULL, NULL, 'Kessie123'),
('51800446', 'AGYEKUM.Ernest Tabi', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42E+11', '13123232323', ' afaf', '1A', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2033', 1, NULL, NULL, 'Kessie123'),
('DIT05170099', 'AHIABLE Victoria', 'Female', NULL, ' Dfd', ' Sdfdfd', '3.42E+11', '13123232323', ' afaf', '1A', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2034', 1, NULL, NULL, 'Kessie123'),
('51800447', 'AHMED.Saeed', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42E+11', '13123232323', ' afaf', '1A', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2035', 1, NULL, NULL, 'Kessie123'),
('51800448', 'AIDOO.Grace', 'Female', NULL, ' Dfd', ' Sdfdfd', '3.42E+11', '13123232323', ' afaf', '1A', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2036', 1, NULL, NULL, 'Kessie123'),
('51800449', 'ALHASSAN.Faruq', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42E+11', '13123232323', ' afaf', '1A', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2037', 1, NULL, NULL, 'Kessie123'),
('DWD05170001', 'AMOAH Gyamfuaah Ellen', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42E+11', '13123232323', ' afaf', '1A', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2038', 1, NULL, NULL, 'Kessie123'),
('51800450', 'ANOKYE.Phinehas Boakye', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42E+11', '13123232323', ' afaf', '1A', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2039', 1, NULL, NULL, 'Kessie123'),
('51800451', 'ANSAH.Alfred', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42E+11', '13123232323', ' afaf', '1A', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2040', 1, NULL, NULL, 'Kessie123'),
('DIT05170023', 'ANTWI Boasiako Kwame', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42E+11', '13123232323', ' afaf', '1A', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2041', 1, NULL, NULL, 'Kessie123'),
('51800452', 'ANTWI.Addai Dickson', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42E+11', '13123232323', ' afaf', '1A', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2042', 1, NULL, NULL, 'Kessie123'),
('DIT05170036', 'ASARE Philemon', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2043', 1, NULL, NULL, 'Kessie123'),
('51800453', 'ASARE.Clement', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2044', 1, NULL, NULL, 'Kessie123'),
('51800454', 'ASARE.Victor', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2045', 1, NULL, NULL, 'Kessie123'),
('51800455', 'ASOMANI.Williams', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2046', 1, NULL, NULL, 'Kessie123'),
('51800456', 'ATIAH.Peter Ayine', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2047', 1, NULL, NULL, 'Kessie123'),
('DIT05170039', 'AYILGIA Desmond', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2048', 1, NULL, NULL, 'Kessie123'),
('51800457', 'AZIAH.Daniel', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2049', 1, NULL, NULL, 'Kessie123'),
('51800458', 'BAAH.Desmond', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2050', 1, NULL, NULL, 'Kessie123'),
('51800459', 'BINEY.Kish Daniel', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2051', 1, NULL, NULL, 'Kessie123'),
('51800460', 'BLAY.Goka Simon', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2052', 1, NULL, NULL, 'Kessie123'),
('51800461', 'BOAHENE.Prince', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2053', 1, NULL, NULL, 'Kessie123'),
('51800462', 'BOAKYE AGYEMANG.Jnr Mensah', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2054', 1, NULL, NULL, 'Kessie123'),
('DHN05170004', 'BOAKYE Joel', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2055', 1, NULL, NULL, 'Kessie123'),
('DIT05170049', 'BOATENG Asare', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2056', 1, NULL, NULL, 'Kessie123'),
('51800463', 'BOATENG.Bismark', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2057', 1, NULL, NULL, 'Kessie123'),
('51800464', 'BORLABI.Godfred Borketey', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2058', 1, NULL, NULL, 'Kessie123'),
('51800465', 'BREFO.Daniel', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2059', 1, NULL, NULL, 'Kessie123'),
('51800466', 'BRONI.Jephter', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2060', 1, NULL, NULL, 'Kessie123'),
('51800467', 'BUDU.Charles', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2061', 1, NULL, NULL, 'Kessie123'),
('51800468', 'CUDJOE.Joseph', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2062', 1, NULL, NULL, 'Kessie123'),
('51800469', 'DAISSIE.Gladys', 'Female', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2063', 1, NULL, NULL, 'Kessie123'),
('51800470', 'DAYYAN.Issahaku', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2064', 1, NULL, NULL, 'Kessie123'),
('DIT05170026', 'ELLIOT Gyamfi Anyankwah', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2065', 1, NULL, NULL, 'Kessie123'),
('51800471', 'FAISAL.Halid Dene', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2066', 1, NULL, NULL, 'Kessie123'),
('DIT05170058', 'GIBRINE Adiza Adamu', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2067', 1, NULL, NULL, 'Kessie123'),
('51800472', 'GYETUA DANQUAH.Richmond', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2068', 1, NULL, NULL, 'Kessie123'),
('51800473', 'ISSAH.Abubakar Saddick', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2069', 1, NULL, NULL, 'Kessie123'),
('DIT05170063', 'KARIM Nayiba', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2070', 1, NULL, NULL, 'Kessie123'),
('DIT05170065', 'KONADU Obed', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2071', 1, NULL, NULL, 'Kessie123'),
('DIT05170068', 'LARBI Wilson Nana Yaw', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2072', 1, NULL, NULL, 'Kessie123'),
('51800474', 'MENSAH ABRAMPAH.Shadrack', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2073', 1, NULL, NULL, 'Kessie123'),
('DIT05170067', 'MICHAEL Agyapong Kwarteng', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2074', 1, NULL, NULL, 'Kessie123'),
('DIT05170013', 'MICHAEL Bota Afrifa', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2075', 1, NULL, NULL, 'Kessie123'),
('51800477', 'MOHAMMED ISHMAIL.Shariff', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2076', 1, NULL, NULL, 'Kessie123'),
('DIT05170071', 'MOHAMMED Jamal', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2077', 1, NULL, NULL, 'Kessie123'),
('51800476', 'MOHAMMED.Osman', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2078', 1, NULL, NULL, 'Kessie123'),
('51800475', 'MOHAMMED.Yahaya Hafiz', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2079', 1, NULL, NULL, 'Kessie123'),
('51800478', 'MONTEL.Ray Lawson', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2080', 1, NULL, NULL, 'Kessie123'),
('51801905', 'MORNAH.Frank  Atouro', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2081', 1, NULL, NULL, 'Kessie123'),
('51800480', 'NKANSAH.Prince', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1B', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2082', 1, NULL, NULL, 'Kessie123'),
('51800482', 'NYANTAKYI.David', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1C', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2083', 1, NULL, NULL, 'Kessie123'),
('51800481', 'NYANTAKYI.Gideon', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1C', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2084', 1, NULL, NULL, 'Kessie123'),
('51800483', 'OBODAI SAI.Edmund', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1C', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2085', 1, NULL, NULL, 'Kessie123'),
('51802181', 'OCRAN Victor', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1C', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2086', 1, NULL, NULL, 'Kessie123'),
('51800484', 'ODURO.Charles', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1C', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2087', 1, NULL, NULL, 'Kessie123'),
('51800485', 'OFORI  BOYE.Gilbert', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1C', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2088', 1, NULL, NULL, 'Kessie123'),
('51800488', 'OPOKU.Emmanuel Junior', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1C', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2089', 1, NULL, NULL, 'Kessie123'),
('51800487', 'OPOKU.Evans', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1C', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2090', 1, NULL, NULL, 'Kessie123'),
('51800486', 'OPOKU.Gyasi Edward', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1C', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2091', 1, NULL, NULL, 'Kessie123'),
('51800489', 'OPPONG.Success Antwiwaa', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1C', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2092', 1, NULL, NULL, 'Kessie123'),
('51800490', 'OPUNI AMPEM.Benjamin', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1C', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2093', 1, NULL, NULL, 'Kessie123'),
('51800491', 'OSEI.Agyei Samuel', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1C', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2094', 1, NULL, NULL, 'Kessie123'),
('51800492', 'OSEI.Dennis', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1C', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2095', 1, NULL, NULL, 'Kessie123'),
('DIT05170087', 'OWUSU Eric', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1C', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2096', 1, NULL, NULL, 'Kessie123'),
('51800493', 'OWUSU MANU. Emmanuel', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1C', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2097', 1, NULL, NULL, 'Kessie123'),
('DIT05170083', 'OWUSU Obed', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1C', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2098', 1, NULL, NULL, 'Kessie123'),
('DIT05170084', 'OWUSU Roberto', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1C', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2099', 1, NULL, NULL, 'Kessie123'),
('DIT05170086', 'QUAINOO Arko Joseph', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1C', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2100', 1, NULL, NULL, 'Kessie123'),
('51800494', 'RAHMAN.Abdul', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1C', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2101', 1, NULL, NULL, 'Kessie123'),
('DIT05170094', 'SALANI Latifa', 'Female', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1C', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2102', 1, NULL, NULL, 'Kessie123'),
('51800495', 'SARFO KANTANKA. Emmanuel', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1C', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2103', 1, NULL, NULL, 'Kessie123'),
('DIT05170092', 'SARPONG Kwabena', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1C', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2104', 1, NULL, NULL, 'Kessie123'),
('51800496', 'SARPONG.Prince', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1C', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2105', 1, NULL, NULL, 'Kessie123'),
('51800497', 'TETTEH.Emmanuel', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1C', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2106', 1, NULL, NULL, 'Kessie123'),
('51800498', 'TRETU.Eric', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1C', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2107', 1, NULL, NULL, 'Kessie123'),
('DIT05170101', 'YAHAYA Shuraim Muhideen', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1C', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2108', 1, NULL, NULL, 'Kessie123'),
('51800499', 'ZOTRA. Derrick', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1C', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2109', 1, NULL, NULL, 'Kessie123'),
('DIT05170025', 'Antwi Vera', 'Female', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1C', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2110', 1, NULL, NULL, 'Kessie123'),
('DIT05170082', 'DARKWAH.OWUSU GABRIEL', ' Male', NULL, ' Dfd', ' Sdfdfd', '3.42123E+11', '13123232323', ' afaf', '1C', NULL, NULL, NULL, NULL, NULL, 'Active', ' 2020/2111', 1, NULL, NULL, 'Kessie123');

-- --------------------------------------------------------

--
-- Table structure for table `student_debt`
--

DROP TABLE IF EXISTS `student_debt`;
CREATE TABLE IF NOT EXISTS `student_debt` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Student_ID` varchar(200) NOT NULL,
  `Fullname` varchar(200) NOT NULL,
  `Gender` varchar(200) NOT NULL,
  `Class` varchar(200) NOT NULL,
  `Academic` varchar(200) NOT NULL,
  `Term` int(1) NOT NULL,
  `Previous_Debt` double DEFAULT NULL,
  `Current_Debt` double(10,2) NOT NULL,
  `Total_Debt` double(10,2) NOT NULL,
  `new` tinyint(4) NOT NULL DEFAULT '1',
  `sid` varchar(200) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=365 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student_debt`
--

INSERT INTO `student_debt` (`id`, `Student_ID`, `Fullname`, `Gender`, `Class`, `Academic`, `Term`, `Previous_Debt`, `Current_Debt`, `Total_Debt`, `new`, `sid`) VALUES
(165, '51800491', 'OSEI.Agyei Samuel', ' Male', '1C', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(164, '51800490', 'OPUNI AMPEM.Benjamin', ' Male', '1C', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(163, '51800489', 'OPPONG.Success Antwiwaa', ' Male', '1C', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(162, '51800486', 'OPOKU.Gyasi Edward', ' Male', '1C', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(161, '51800487', 'OPOKU.Evans', ' Male', '1C', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(160, '51800488', 'OPOKU.Emmanuel Junior', ' Male', '1C', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(159, '51800485', 'OFORI  BOYE.Gilbert', ' Male', '1C', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(158, '51800484', 'ODURO.Charles', ' Male', '1C', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(157, '51802181', 'OCRAN Victor', ' Male', '1C', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(156, '51800483', 'OBODAI SAI.Edmund', ' Male', '1C', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(155, '51800481', 'NYANTAKYI.Gideon', ' Male', '1C', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(154, '51800482', 'NYANTAKYI.David', ' Male', '1C', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(153, '51800480', 'NKANSAH.Prince', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(152, '51801905', 'MORNAH.Frank  Atouro', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(151, '51800478', 'MONTEL.Ray Lawson', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(150, '51800475', 'MOHAMMED.Yahaya Hafiz', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(149, '51800476', 'MOHAMMED.Osman', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(148, 'DIT05170071', 'MOHAMMED Jamal', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(147, '51800477', 'MOHAMMED ISHMAIL.Shariff', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(146, 'DIT05170013', 'MICHAEL Bota Afrifa', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(145, 'DIT05170067', 'MICHAEL Agyapong Kwarteng', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(144, '51800474', 'MENSAH ABRAMPAH.Shadrack', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(143, 'DIT05170068', 'LARBI Wilson Nana Yaw', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(142, 'DIT05170065', 'KONADU Obed', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(141, 'DIT05170063', 'KARIM Nayiba', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(140, '51800473', 'ISSAH.Abubakar Saddick', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(139, '51800472', 'GYETUA DANQUAH.Richmond', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(138, 'DIT05170058', 'GIBRINE Adiza Adamu', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(137, '51800471', 'FAISAL.Halid Dene', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(136, 'DIT05170026', 'ELLIOT Gyamfi Anyankwah', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(135, '51800470', 'DAYYAN.Issahaku', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(134, '51800469', 'DAISSIE.Gladys', 'Female', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(133, '51800468', 'CUDJOE.Joseph', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(132, '51800467', 'BUDU.Charles', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(131, '51800466', 'BRONI.Jephter', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(130, '51800465', 'BREFO.Daniel', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(129, '51800464', 'BORLABI.Godfred Borketey', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(128, '51800463', 'BOATENG.Bismark', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(127, 'DIT05170049', 'BOATENG Asare', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(126, 'DHN05170004', 'BOAKYE Joel', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(125, '51800462', 'BOAKYE AGYEMANG.Jnr Mensah', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(124, '51800461', 'BOAHENE.Prince', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(123, '51800460', 'BLAY.Goka Simon', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(122, '51800459', 'BINEY.Kish Daniel', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(121, '51800458', 'BAAH.Desmond', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(120, '51800457', 'AZIAH.Daniel', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(119, 'DIT05170039', 'AYILGIA Desmond', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(118, '51800456', 'ATIAH.Peter Ayine', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(117, '51800455', 'ASOMANI.Williams', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(116, '51800454', 'ASARE.Victor', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(115, '51800453', 'ASARE.Clement', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(114, 'DIT05170036', 'ASARE Philemon', ' Male', '1B', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(113, '51800452', 'ANTWI.Addai Dickson', ' Male', '1A', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(112, 'DIT05170023', 'ANTWI Boasiako Kwame', ' Male', '1A', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(111, '51800451', 'ANSAH.Alfred', ' Male', '1A', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(110, '51800450', 'ANOKYE.Phinehas Boakye', ' Male', '1A', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(109, 'DWD05170001', 'AMOAH Gyamfuaah Ellen', ' Male', '1A', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(108, '51800449', 'ALHASSAN.Faruq', ' Male', '1A', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(107, '51800448', 'AIDOO.Grace', 'Female', '1A', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(106, '51800447', 'AHMED.Saeed', ' Male', '1A', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(105, 'DIT05170099', 'AHIABLE Victoria', 'Female', '1A', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(104, '51800446', 'AGYEKUM.Ernest Tabi', ' Male', '1A', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(103, '51800445', 'AGYAPONG.Alexander', ' Male', '1A', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(102, '51800443', 'ADOMAKO.Prince', ' Male', '1A', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(101, '51800444', 'ADOMAKO.Eric', ' Male', '1A', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(100, '51800442', 'ADJEI.Anthony Clifford', ' Male', '1A', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(99, '51800441', 'ADIKU OFORI.Harold', ' Male', '1A', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(98, 'DIT05170007', 'ADARKWAH Emmanuel', ' Male', '1A', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(97, '51800440', 'ADAM.Gadaf', ' Male', '1A', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(96, '51800439', 'ABUBAKAR.Farouk', ' Male', '1A', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(95, 'DIT05170011', 'ABDUL-Malik Firdaus', 'Female', '1A', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(94, '51800438', 'ABDUL GANIYU.Sadick', ' Male', '1A', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(93, '51800437', 'ABBAS. Abdul-Karim', ' Male', '1A', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(92, 'st123', 'KESSIE.Bismark', 'Male', '1A', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(166, '51800492', 'OSEI.Dennis', ' Male', '1C', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(167, 'DIT05170087', 'OWUSU Eric', ' Male', '1C', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(168, '51800493', 'OWUSU MANU. Emmanuel', ' Male', '1C', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(169, 'DIT05170083', 'OWUSU Obed', ' Male', '1C', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(170, 'DIT05170084', 'OWUSU Roberto', ' Male', '1C', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(171, 'DIT05170086', 'QUAINOO Arko Joseph', ' Male', '1C', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(172, '51800494', 'RAHMAN.Abdul', ' Male', '1C', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(173, 'DIT05170094', 'SALANI Latifa', 'Female', '1C', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(174, '51800495', 'SARFO KANTANKA. Emmanuel', ' Male', '1C', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(175, 'DIT05170092', 'SARPONG Kwabena', ' Male', '1C', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(176, '51800496', 'SARPONG.Prince', ' Male', '1C', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(177, '51800497', 'TETTEH.Emmanuel', ' Male', '1C', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(178, '51800498', 'TRETU.Eric', ' Male', '1C', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(179, 'DIT05170101', 'YAHAYA Shuraim Muhideen', ' Male', '1C', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(180, '51800499', 'ZOTRA. Derrick', ' Male', '1C', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(181, 'DIT05170025', 'Antwi Vera', 'Female', '1C', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123'),
(182, 'DIT05170082', 'DARKWAH.OWUSU GABRIEL', ' Male', '1C', '2020/2021', 1, 0, 614.00, 614.00, 1, 'Kessie123');

-- --------------------------------------------------------

--
-- Table structure for table `subclass`
--

DROP TABLE IF EXISTS `subclass`;
CREATE TABLE IF NOT EXISTS `subclass` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `s_class` varchar(10) NOT NULL,
  `class` int(11) NOT NULL,
  `max_students` int(11) NOT NULL,
  `sid` varchar(200) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `s_class` (`s_class`)
) ENGINE=MyISAM AUTO_INCREMENT=22 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `subclass`
--

INSERT INTO `subclass` (`id`, `s_class`, `class`, `max_students`, `sid`) VALUES
(15, '1A', 1, 25, 'Kessie123'),
(16, '1B', 1, 25, 'Kessie123'),
(17, '1C', 1, 25, 'Kessie123'),
(18, '2A', 2, 26, 'Kessie123'),
(19, '2B', 2, 26, 'Kessie123'),
(20, '3A', 3, 30, 'Kessie123'),
(21, '3B', 3, 30, 'Kessie123');

-- --------------------------------------------------------

--
-- Table structure for table `subject_allocation`
--

DROP TABLE IF EXISTS `subject_allocation`;
CREATE TABLE IF NOT EXISTS `subject_allocation` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Staff_ID` varchar(200) NOT NULL,
  `Subject` char(200) NOT NULL,
  `Allocation` text NOT NULL,
  `sid` varchar(200) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=39 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `subject_allocation`
--

INSERT INTO `subject_allocation` (`ID`, `Staff_ID`, `Subject`, `Allocation`, `sid`) VALUES
(20, 'g66', 'English', '1B', 'Kessie123'),
(18, 'g66', 'English', '1C', 'Kessie123'),
(19, 'g66', 'English', '1A', 'Kessie123'),
(23, 'g66', 'Math', '1B', 'Kessie123'),
(22, 'g66', 'Math', '1A', 'Kessie123'),
(21, 'g66', 'Math', '1C', 'Kessie123'),
(24, 'g66', 'Integrated Science', '1C', 'Kessie123'),
(25, 'g66', 'Integrated Science', '1A', 'Kessie123'),
(26, 'g66', 'Integrated Science', '1B', 'Kessie123'),
(27, 'g66', 'Social Studies', '1C', 'Kessie123'),
(28, 'g66', 'Social Studies', '1A', 'Kessie123'),
(29, 'g66', 'Social Studies', '1B', 'Kessie123'),
(30, 'g66', 'Creative Art', '1C', 'Kessie123'),
(31, 'g66', 'Creative Art', '1A', 'Kessie123'),
(32, 'g66', 'Creative Art', '1B', 'Kessie123'),
(33, 'g66', 'Twi', '1C', 'Kessie123'),
(34, 'g66', 'Twi', '1A', 'Kessie123'),
(35, 'g66', 'Twi', '1B', 'Kessie123'),
(36, 'g66', 'French', '1C', 'Kessie123'),
(37, 'g66', 'French', '1A', 'Kessie123'),
(38, 'g66', 'French', '1B', 'Kessie123');

-- --------------------------------------------------------

--
-- Table structure for table `subject_table`
--

DROP TABLE IF EXISTS `subject_table`;
CREATE TABLE IF NOT EXISTS `subject_table` (
  `subject_id` varchar(200) NOT NULL,
  `subject_name` char(200) NOT NULL,
  `abbreviation` varchar(5) NOT NULL,
  `sid` varchar(200) NOT NULL,
  PRIMARY KEY (`subject_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `subject_table`
--

INSERT INTO `subject_table` (`subject_id`, `subject_name`, `abbreviation`, `sid`) VALUES
('eng1', 'English', 'Eng', 'Kessie123'),
('mtq', 'Math', 'Mth', 'Kessie123'),
('sci112', 'Integrated Science', 'Sci', 'Kessie123'),
('soc122', 'Social Studies', 'Soc', 'Kessie123'),
('at1', 'Creative Art', 'Art', 'Kessie123'),
('tw12', 'Twi', 'Twi', 'Kessie123'),
('fn345', 'French', 'Frn', 'Kessie123');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `Staff_ID` varchar(200) NOT NULL,
  `Name` varchar(200) NOT NULL,
  `Username` varchar(200) DEFAULT NULL,
  `password` varchar(200) NOT NULL,
  `pass` int(1) NOT NULL,
  `question` varchar(200) DEFAULT NULL,
  `answer` varchar(200) DEFAULT NULL,
  `reset` tinyint(4) NOT NULL DEFAULT '0',
  `sid` varchar(200) NOT NULL,
  PRIMARY KEY (`Staff_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`Staff_ID`, `Name`, `Username`, `password`, `pass`, `question`, `answer`, `reset`, `sid`) VALUES
('Admin', 'KESSIE,Bismark', 'kesstek', 'kess2020', 0, NULL, NULL, 1, 'kessie123'),
('ks1233', 'KESSIE,Bismark', 'kessie', 'UCDt6wUeJV++DQKNAQccHA==', 1, NULL, NULL, 0, 'Kessie123'),
('g66', 'JUNIOR,Kwaku', 'jn', 'UCDt6wUeJV++DQKNAQccHA==', 5, 'Administrator', 'me', 1, 'Kessie123');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
