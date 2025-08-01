-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Dec 24, 2024 at 04:57 AM
-- Server version: 8.0.30
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `facilis`
--

-- --------------------------------------------------------

--
-- Table structure for table `reservations`
--

CREATE TABLE `reservations` (
  `reservation_id` int NOT NULL,
  `username` varchar(20) NOT NULL,
  `room_id` int NOT NULL,
  `check_in` datetime NOT NULL,
  `check_out` datetime NOT NULL,
  `total_price` int NOT NULL,
  `status` varchar(50) NOT NULL,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `reservations`
--

INSERT INTO `reservations` (`reservation_id`, `username`, `room_id`, `check_in`, `check_out`, `total_price`, `status`, `updated_at`) VALUES
(1, 'admin', 1, '2024-12-03 00:00:00', '2024-12-04 00:00:00', 500000, 'Booked', '2024-12-19 01:32:36'),
(2, 'admin', 1, '2024-12-19 08:33:33', '2024-12-20 08:33:33', 200000, 'Booked', '2024-12-19 01:33:33'),
(3, 'admin', 1, '2024-12-19 08:34:20', '2024-12-20 08:34:20', 200000, 'Booked', '2024-12-19 01:34:19'),
(4, 'admin', 2, '2024-12-19 08:35:07', '2024-12-20 08:35:07', 750000, 'Booked', '2024-12-19 01:35:06'),
(5, 'admin', 1, '2024-12-19 08:36:27', '2024-12-21 08:36:27', 400000, 'Booked', '2024-12-19 01:36:27'),
(6, 'admin', 2, '2024-12-19 08:37:09', '2024-12-20 08:37:09', 750000, 'Booked', '2024-12-19 01:37:09'),
(7, 'admin', 1, '2024-12-19 08:41:40', '2024-12-20 08:41:40', 200000, 'Booked', '2024-12-19 01:41:40'),
(8, 'admin', 1, '2024-12-19 08:42:23', '2024-12-24 08:42:23', 1000000, 'Booked', '2024-12-19 01:42:22'),
(9, 'admin', 2, '2024-12-19 08:43:18', '2024-12-20 08:43:18', 750000, 'Booked', '2024-12-19 01:43:17'),
(10, 'admin', 1, '2024-12-19 08:49:37', '2024-12-20 08:49:37', 200000, 'Booked', '2024-12-19 01:49:37'),
(11, 'admin', 1, '2024-12-19 08:51:14', '2024-12-20 08:51:14', 200000, 'Booked', '2024-12-19 01:51:13'),
(12, 'admin', 1, '2024-12-19 08:55:42', '2024-12-20 08:55:42', 200000, 'Booked', '2024-12-19 01:55:41'),
(13, 'admin', 1, '2024-12-19 08:56:19', '2024-12-20 08:56:19', 200000, 'Booked', '2024-12-19 01:56:18'),
(14, 'admin', 1, '2024-12-19 09:01:57', '2024-12-20 09:01:57', 200000, 'Booked', '2024-12-19 02:01:57'),
(15, 'admin', 2, '2024-12-19 09:02:20', '2024-12-20 09:02:20', 750000, 'Booked', '2024-12-19 02:02:20'),
(16, 'admin', 1, '2024-12-19 09:06:07', '2024-12-21 09:06:07', 400000, 'Booked', '2024-12-19 02:06:07'),
(17, 'putra', 1, '2024-12-24 11:55:47', '2024-12-25 11:55:47', 200000, 'Booked', '2024-12-24 04:55:47');

-- --------------------------------------------------------

--
-- Table structure for table `rooms`
--

CREATE TABLE `rooms` (
  `room_id` int NOT NULL,
  `room_number` varchar(20) NOT NULL,
  `room_type` varchar(20) NOT NULL,
  `price` int NOT NULL,
  `description` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `rooms`
--

INSERT INTO `rooms` (`room_id`, `room_number`, `room_type`, `price`, `description`) VALUES
(1, '101', 'single', 200000, 'kamar sendiri'),
(2, '102', 'Double', 750000, 'Kamar Simple Dengan Kasur Besar.'),
(4, '111', 'Test', 600000, 'Kamar Delux'),
(5, '106', 'single', 600000, 'kamar sendiri');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `full_name` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`username`, `password`, `full_name`, `email`) VALUES
('admin', 'admin', 'admin', 'admin@gmail.com'),
('putra', 'putra', 'putra', 'putra@gmail.com'),
('test', 'test', 'test', 'test'),
('tet', 'tet', 'tet', 'tet');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `reservations`
--
ALTER TABLE `reservations`
  ADD PRIMARY KEY (`reservation_id`),
  ADD KEY `username` (`username`),
  ADD KEY `room_id` (`room_id`);

--
-- Indexes for table `rooms`
--
ALTER TABLE `rooms`
  ADD PRIMARY KEY (`room_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`username`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `reservations`
--
ALTER TABLE `reservations`
  ADD CONSTRAINT `reservations_ibfk_1` FOREIGN KEY (`username`) REFERENCES `users` (`username`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `reservations_ibfk_2` FOREIGN KEY (`room_id`) REFERENCES `rooms` (`room_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
