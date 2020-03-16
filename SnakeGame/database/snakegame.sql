-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 14, 2020 at 10:34 PM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `snakegame`
--
CREATE DATABASE IF NOT EXISTS `snakegame` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `snakegame`;

-- --------------------------------------------------------

--
-- Table structure for table `comment`
--

CREATE TABLE `comment` (
  `id` int(11) NOT NULL,
  `username` varchar(50) DEFAULT '0',
  `comment` varchar(50) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `comment`
--

INSERT INTO `comment` (`id`, `username`, `comment`) VALUES
(1, 'adi', 'Game nya bagus banget'),
(2, 'Kuhaku', 'Game kok begini amat. Tapi semangat deh'),
(3, 'Kuhaku', 'Game nya update lagi dong gan'),
(4, 'Goni', 'game nya sampah gak guna gembel. Develpoer bocah');

-- --------------------------------------------------------

--
-- Table structure for table `highscore`
--

CREATE TABLE `highscore` (
  `id` int(11) NOT NULL,
  `username` varchar(50) DEFAULT '0',
  `score` int(11) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `highscore`
--

INSERT INTO `highscore` (`id`, `username`, `score`) VALUES
(1, 'adi', 0),
(2, 'adi', 6),
(3, 'Kuhaku', 4),
(4, 'adi', 6),
(5, 'adi', 8),
(6, 'goni', 86),
(7, 'adi', 0),
(8, 'adi', 1),
(9, 'adi', 0),
(10, 'adi', 0),
(11, 'adi', 8),
(12, 'Rekt', 0),
(13, 'adi', 12),
(14, 'adi', 2),
(15, 'tetek', 0),
(16, 'tetek', 7),
(17, 'Kuhaku', 2),
(18, 'adi', 10),
(19, 'adi', 4),
(20, 'adi', 17),
(21, 'adi', 1),
(22, '', 0),
(23, '', 0),
(24, '', 0),
(25, '', 0),
(26, '', 0),
(27, '', 0),
(28, '', 0),
(29, '', 0),
(30, '', 0),
(31, '', 0),
(32, '', 0),
(33, '', 0),
(34, '', 0),
(35, '', 0),
(36, '', 0),
(37, '', 0),
(38, '', 0),
(39, '', 0),
(40, '', 0),
(41, '', 0),
(42, '', 0),
(43, '', 0),
(44, '', 0),
(45, '', 0),
(46, '', 0),
(47, '', 0),
(48, '', 0),
(49, '', 0),
(50, '', 0),
(51, '', 0),
(52, '', 0),
(53, '', 0),
(54, '', 0),
(55, '', 0),
(56, '', 0),
(57, '', 0),
(58, '', 0),
(59, '', 0),
(60, '', 0),
(61, '', 0),
(62, '', 0),
(63, '', 0),
(64, '', 0),
(65, '', 0),
(66, '', 0),
(67, '', 0),
(68, '', 0),
(69, '', 0),
(70, '', 0),
(71, 'adi', 13),
(72, '', 0),
(73, '', 0),
(74, '', 0),
(75, '', 0),
(76, '', 0),
(77, '', 0),
(78, '', 0),
(79, '', 0),
(80, '', 0),
(81, '', 0),
(82, '', 0),
(83, '', 0),
(84, '', 0),
(85, '', 0),
(86, '', 0),
(87, '', 0),
(88, '', 0),
(89, '', 0),
(90, '', 0),
(91, '', 0),
(92, '', 0),
(93, '', 0),
(94, '', 0),
(95, '', 0),
(96, '', 0),
(97, '', 0),
(98, '', 0),
(99, '', 0),
(100, '', 0),
(101, '', 0),
(102, '', 0),
(103, '', 0),
(104, '', 0),
(105, '', 0),
(106, '', 0),
(107, '', 0),
(108, '', 0),
(109, '', 0),
(110, '', 0),
(111, '', 0),
(112, '', 0),
(113, '', 0),
(114, '', 0),
(115, '', 0),
(116, '', 0),
(117, '', 0),
(118, '', 0),
(119, '', 0),
(120, '', 0),
(121, 'adi', 0),
(122, 'nevan', 40),
(123, 'cokbun', 0),
(124, 'cokbun', 16),
(125, '', 0),
(126, '', 0),
(127, '', 0),
(128, '', 0),
(129, '', 0),
(130, '', 0),
(131, '', 0),
(132, '', 0),
(133, '', 0),
(134, '', 0),
(135, '', 0),
(136, '', 0),
(137, '', 0),
(138, '', 0),
(139, '', 0),
(140, '', 0),
(141, '', 0),
(142, '', 0),
(143, '', 0),
(144, '', 0),
(145, '', 0),
(146, '', 0),
(147, '', 0),
(148, '', 0),
(149, '', 0),
(150, '', 0),
(151, '', 0),
(152, '', 0),
(153, '', 0),
(154, '', 0),
(155, '', 0),
(156, '', 0),
(157, '', 0),
(158, '', 0),
(159, '', 0),
(160, '', 0),
(161, '', 0),
(162, '', 0),
(163, '', 0),
(164, '', 0),
(165, '', 0),
(166, '', 0),
(167, '', 0),
(168, '', 0),
(169, '', 0),
(170, '', 0),
(171, '', 0),
(172, '', 0),
(173, '', 0),
(174, 'cokbun', 17),
(175, '', 0),
(176, '', 0),
(177, '', 0),
(178, '', 0),
(179, '', 0),
(180, '', 0),
(181, '', 0),
(182, '', 0),
(183, '', 0),
(184, '', 0),
(185, '', 0),
(186, '', 0),
(187, '', 0),
(188, '', 0),
(189, '', 0),
(190, '', 0),
(191, '', 0),
(192, '', 0),
(193, '', 0),
(194, '', 0),
(195, '', 0),
(196, '', 0),
(197, '', 0),
(198, '', 0),
(199, '', 0),
(200, '', 0),
(201, '', 0),
(202, '', 0),
(203, '', 0),
(204, '', 0),
(205, '', 0),
(206, '', 0),
(207, '', 0),
(208, '', 0),
(209, '', 0),
(210, '', 0),
(211, '', 0),
(212, '', 0),
(213, '', 0),
(214, '', 0),
(215, '', 0),
(216, '', 0),
(217, '', 0),
(218, '', 0),
(219, '', 0),
(220, '', 0),
(221, '', 0),
(222, '', 0),
(223, '', 0);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `access` varchar(10) NOT NULL DEFAULT 'player',
  `username` varchar(40) NOT NULL,
  `password` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `access`, `username`, `password`) VALUES
(1, 'player', 'adi', 'adi'),
(2, 'player', 'Kuhaku', 'Kuhaku'),
(3, 'player', 'Kuhaku', 'Kuhaku'),
(4, 'player', 'goni', 'titiw'),
(5, 'player', 'Rekt', 'Rekt'),
(6, 'player', 'tetek', 'ayam'),
(7, 'player', 'Sahrial', '1234\r\n'),
(8, 'player', 'nevan', 'nevan'),
(9, 'player', 'cokbun', '11111111');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `comment`
--
ALTER TABLE `comment`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `highscore`
--
ALTER TABLE `highscore`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `comment`
--
ALTER TABLE `comment`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `highscore`
--
ALTER TABLE `highscore`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=224;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
