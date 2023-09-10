-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 04, 2022 at 03:24 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `queuewrite_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `counter_four`
--

CREATE TABLE `counter_four` (
  `ID` int(11) NOT NULL,
  `PNO` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `counter_four`
--

INSERT INTO `counter_four` (`ID`, `PNO`) VALUES
(1, '01'),
(2, '02'),
(3, '03'),
(4, '04'),
(5, '05');

-- --------------------------------------------------------

--
-- Table structure for table `counter_one`
--

CREATE TABLE `counter_one` (
  `ID` int(11) NOT NULL,
  `PNO` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `counter_one`
--

INSERT INTO `counter_one` (`ID`, `PNO`) VALUES
(1, '01'),
(2, '02'),
(3, '03'),
(4, '04'),
(5, '05');

-- --------------------------------------------------------

--
-- Table structure for table `counter_three`
--

CREATE TABLE `counter_three` (
  `ID` int(11) NOT NULL,
  `PNO` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `counter_three`
--

INSERT INTO `counter_three` (`ID`, `PNO`) VALUES
(1, '01'),
(3, '02'),
(4, '03'),
(5, '04'),
(6, '05'),
(7, '06'),
(8, '01'),
(9, '02'),
(10, '03'),
(11, '04'),
(12, '05'),
(13, '06'),
(14, '01'),
(15, '02'),
(16, '03'),
(17, '04'),
(18, '05'),
(19, '06');

-- --------------------------------------------------------

--
-- Table structure for table `counter_two`
--

CREATE TABLE `counter_two` (
  `ID` int(11) NOT NULL,
  `PNO` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `counter_two`
--

INSERT INTO `counter_two` (`ID`, `PNO`) VALUES
(1, '01'),
(2, '02'),
(3, '03'),
(4, '04'),
(5, '05');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `counter_four`
--
ALTER TABLE `counter_four`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `counter_one`
--
ALTER TABLE `counter_one`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `counter_three`
--
ALTER TABLE `counter_three`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `counter_two`
--
ALTER TABLE `counter_two`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `counter_four`
--
ALTER TABLE `counter_four`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `counter_one`
--
ALTER TABLE `counter_one`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `counter_three`
--
ALTER TABLE `counter_three`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `counter_two`
--
ALTER TABLE `counter_two`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
