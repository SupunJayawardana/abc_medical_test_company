-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               8.0.18 - MySQL Community Server - GPL
-- Server OS:                    Win64
-- HeidiSQL Version:             12.8.0.6908
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- Dumping database structure for test1.2
CREATE DATABASE IF NOT EXISTS `test1.2` /*!40100 DEFAULT CHARACTER SET utf8 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `test1.2`;

-- Dumping structure for table test1.2.admin
CREATE TABLE IF NOT EXISTS `admin` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(45) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `password` varchar(45) NOT NULL,
  `email` varchar(50) NOT NULL,
  `mobile` int(10) unsigned zerofill NOT NULL DEFAULT '0000000000',
  `status_id` int(11) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `role` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_admin_status1_idx` (`status_id`),
  CONSTRAINT `fk_admin_status1` FOREIGN KEY (`status_id`) REFERENCES `status` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;

-- Dumping structure for table test1.2.invoice
CREATE TABLE IF NOT EXISTS `invoice` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `patient_nic` varchar(12) NOT NULL,
  `cashier_id` int(11) NOT NULL,
  `doctor_id` int(10) NOT NULL,
  `price` double NOT NULL,
  `Commssion_id` int(11) NOT NULL,
  `tests_test_id` int(11) NOT NULL,
  `issued_date` timestamp NOT NULL,
  `admin_id` int(11) NOT NULL,
  `technologist_id` int(11) NOT NULL,
  `report_status_id` int(11) NOT NULL,
  PRIMARY KEY (`id`,`tests_test_id`) USING BTREE,
  KEY `fk_invoice_patient1_idx` (`patient_nic`),
  KEY `fk_invoice_Commssion1_idx` (`Commssion_id`),
  KEY `fk_invoice_tests1_idx` (`tests_test_id`),
  KEY `fk_invoice_admin1_idx` (`admin_id`),
  KEY `fk_invoice_report_send_status1_idx` (`report_status_id`),
  CONSTRAINT `fk_invoice_Commssion1` FOREIGN KEY (`Commssion_id`) REFERENCES `commssion` (`id`),
  CONSTRAINT `fk_invoice_admin1` FOREIGN KEY (`admin_id`) REFERENCES `admin` (`id`),
  CONSTRAINT `fk_invoice_patient1` FOREIGN KEY (`patient_nic`) REFERENCES `patient` (`nic`),
  CONSTRAINT `fk_invoice_report_send_status1` FOREIGN KEY (`report_status_id`) REFERENCES `report_send_status` (`id`),
  CONSTRAINT `fk_invoice_tests1` FOREIGN KEY (`tests_test_id`) REFERENCES `tests` (`test_id`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;

-- Dumping structure for table test1.2.patient
CREATE TABLE IF NOT EXISTS `patient` (
  `nic` varchar(12) NOT NULL,
  `name` varchar(20) NOT NULL,
  `mobile` int(10) unsigned zerofill NOT NULL DEFAULT '0000000000',
  `email` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `address` varchar(45) NOT NULL,
  `status_id` int(11) NOT NULL,
  PRIMARY KEY (`nic`),
  KEY `fk_patient_status1_idx` (`status_id`),
  CONSTRAINT `fk_patient_status1` FOREIGN KEY (`status_id`) REFERENCES `status` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping structure for table test1.2.report_send_status
CREATE TABLE IF NOT EXISTS `report_send_status` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `status` varchar(10) NOT NULL,
  `invoice_id` int(11) NOT NULL,
  `invoice_tests_test_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_report_send_status_invoice1_idx` (`invoice_id`,`invoice_tests_test_id`),
  CONSTRAINT `fk_report_send_status_invoice1` FOREIGN KEY (`invoice_id`, `invoice_tests_test_id`) REFERENCES `invoice` (`id`, `tests_test_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- Dumping structure for table test1.2.status
CREATE TABLE IF NOT EXISTS `status` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- Dumping structure for table test1.2.tests
CREATE TABLE IF NOT EXISTS `tests` (
  `test_id` int(11) NOT NULL,
  `test_name` varchar(45) NOT NULL,
  `test_price` double NOT NULL,
  `test_description` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`test_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Inserting example data into tables

-- Inserting status data
INSERT INTO `status` (`id`, `name`)
VALUES
(1, 'Active'),
(2, 'Inactive');

-- Inserting tests data
INSERT INTO `tests` (`test_id`, `test_name`, `test_price`, `test_description`)
VALUES
(1, 'Blood Test', 50.00, 'Basic blood test including hemoglobin and glucose levels.'),
(2, 'X-Ray', 100.00, 'X-ray scan of chest and abdomen.');

-- Inserting admin users
INSERT INTO `admin` (`username`, `password`, `email`, `mobile`, `status_id`, `first_name`, `last_name`, `role`)
VALUES
('admin', 'password', 'admin@example.com', '0000000000', 1, 'Admin', 'User', 'Admin'),
('technologist', 'password', 'technologist@example.com', '0000000000', 1, 'Tech', 'User', 'Technologist'),
('cashier', 'password', 'cashier@example.com', '0000000000', 1, 'Cash', 'User', 'Cashier'),
('doctor', 'password', 'doctor@example.com', '0000000000', 1, 'Doc', 'User', 'Doctor');

-- Inserting patient data
INSERT INTO `patient` (`nic`, `name`, `mobile`, `email`, `address`, `status_id`)
VALUES
('123456789012', 'John Doe', '0123456789', 'john.doe@example.com', '123 Main St', 1),
('987654321098', 'Jane Smith', '0987654321', 'jane.smith@example.com', '456 Elm St', 1);

-- Inserting invoice data
INSERT INTO `invoice` (`id`, `patient_nic`, `cashier_id`, `doctor_id`, `price`, `Commssion_id`, `tests_test_id`, `issued_date`, `admin_id`, `technologist_id`, `report_status_id`)
VALUES
(1, '123456789012', 1, 1, 150.00, 1, 1, NOW(), 1, 1, 1),
(2, '987654321098', 1, 1, 200.00, 1, 2, NOW(), 1, 1, 1);

-- Inserting report send status data
INSERT INTO `report_send_status` (`id`, `status`, `invoice_id`, `invoice_tests_test_id`)
VALUES
(1, 'Pending', 1, 1),
(2, 'Completed', 2, 2);

-- Data exporting was unselected.

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
