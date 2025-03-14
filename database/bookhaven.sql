-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 12, 2025 at 08:51 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bookhaven`
--

-- --------------------------------------------------------

--
-- Table structure for table `book`
--

CREATE TABLE `book` (
  `id` int(11) NOT NULL,
  `supplier` varchar(200) NOT NULL,
  `title` varchar(200) NOT NULL,
  `author` varchar(100) NOT NULL,
  `genre` varchar(50) NOT NULL,
  `isbn` varchar(13) NOT NULL,
  `price` decimal(8,2) NOT NULL,
  `quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `book`
--

INSERT INTO `book` (`id`, `supplier`, `title`, `author`, `genre`, `isbn`, `price`, `quantity`) VALUES
(4, 'ABC Publishers', 'The Road From Elephant Pass', 'Nihal De Silva', 'Fiction', '9789558095923', 2500.00, 20),
(5, 'New Era Books', 'Chinaman: The Legend of Pradeep Mathew', 'Shehan Karunatilaka', 'Fiction', '9780143459667', 2800.00, 27),
(6, 'ABC Publishers', 'The English Patient', 'Michael Ondaatje', 'Historical', '9780679745204', 3200.00, 28),
(7, 'XYZ Books Distributors', 'Reef', 'Romesh Gunesekera', 'Fiction', '9781862073235', 2200.00, 23),
(8, 'Read Lanka Ltd.', 'Funny Boy', 'Shyam Selvadurai', 'Coming-of-age', '9780156031709', 2600.00, 28),
(9, 'Read Lanka Ltd.', 'Sam’s Story', 'Elmo Jayawardena', 'Fiction', '9789551723229', 2300.00, 31),
(10, 'New Era Books', 'Wave', 'Sonali Deraniyagala', 'Memoir', '9780345807022', 2900.00, 25),
(11, 'ABC Publishers', 'Island of a Thousand Mirrors', 'Nayomi Munaweera', 'Fiction', '9781250055796', 2700.00, 16),
(12, 'XYZ Books Distributors', 'The Ceaseless Chatter of Demons', 'Ashok Ferrey', 'Fiction', '9789386850052', 2400.00, 22),
(13, 'ABC Publishers', 'The Lament of the Dhobi Woman', 'Karen Roberts', 'Fiction', '9780552149725', 2000.00, 32),
(14, 'Read Lanka Ltd.', 'A Cause Untrue', 'David Blacker', 'Thriller', '9789554500056', 3000.00, 22),
(15, 'Read Lanka Ltd.', 'The Prisoner of Paradise', 'Romesh Gunesekera', 'Historical', '9781408827675', 2800.00, 18),
(16, 'New Era Books', 'Rainbows in Braille', 'Chandani Lokuge', 'Fiction', '9780143102181', 2600.00, 10),
(17, 'New Era Books', 'July', 'Karen Roberts', 'Fiction', '9781841154745', 2500.00, 19),
(18, 'ABC Publishers', 'Once Upon a Tender Time', 'Patrick Fernando', 'Poetry', '9789556650070', 1800.00, 28);

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `id` int(11) NOT NULL,
  `email` varchar(100) DEFAULT NULL,
  `name` varchar(100) NOT NULL,
  `phoneNo` varchar(10) NOT NULL,
  `address` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`id`, `email`, `name`, `phoneNo`, `address`) VALUES
(4, 'sunilp@example.com', 'Sunil Perera', '0771234567', 'Colombo, Sri Lanka'),
(5, 'anushaf@example.com', 'Anusha Fernando', '0712345678', 'Galle, Sri Lanka'),
(6, 'ruwanj@example.com', 'Ruwan Jayasinghe', '0756781234', 'Kandy, Sri Lanka'),
(7, 'malithis@example.com', 'Malithi Senanayake', '0765432178', 'Kurunegala, Sri Lanka'),
(8, 'dilshanr@example.com', 'Dilshan Rathnayake', '0789123456', 'Negombo, Sri Lanka');

-- --------------------------------------------------------

--
-- Table structure for table `customerorder`
--

CREATE TABLE `customerorder` (
  `id` int(11) NOT NULL,
  `customerId` int(11) NOT NULL,
  `userId` int(11) NOT NULL,
  `date` date NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  `discount` int(11) DEFAULT NULL,
  `noOfItems` int(11) NOT NULL,
  `type` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customerorder`
--

INSERT INTO `customerorder` (`id`, `customerId`, `userId`, `date`, `amount`, `discount`, `noOfItems`, `type`) VALUES
(11, 4, 8, '2025-03-12', 8400.00, 0, 3, 'Pick up'),
(12, 8, 8, '2025-03-12', 9500.00, 0, 4, 'Pick up'),
(13, 6, 8, '2025-03-12', 11800.00, 0, 5, 'Pick up'),
(14, 4, 8, '2025-03-12', 5300.00, 0, 2, 'delivery'),
(25, 4, 8, '2025-03-13', 2800.00, 0, 1, 'POS'),
(26, 4, 8, '2025-03-13', 2600.00, 0, 1, 'POS'),
(27, 4, 8, '2025-03-13', 5300.00, 0, 2, 'POS');

-- --------------------------------------------------------

--
-- Table structure for table `custorderdetails`
--

CREATE TABLE `custorderdetails` (
  `custOrderId` int(11) NOT NULL,
  `bookId` int(11) NOT NULL,
  `quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `custorderdetails`
--

INSERT INTO `custorderdetails` (`custOrderId`, `bookId`, `quantity`) VALUES
(11, 5, 1),
(11, 14, 1),
(11, 16, 1),
(12, 5, 1),
(12, 9, 1),
(12, 16, 1),
(12, 18, 1),
(13, 7, 2),
(13, 8, 1),
(13, 14, 1),
(13, 18, 1),
(14, 15, 1),
(14, 17, 1),
(25, 5, 1),
(26, 8, 1),
(27, 17, 1),
(27, 15, 1);

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `phoneNo` varchar(10) NOT NULL,
  `address` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`id`, `name`, `email`, `phoneNo`, `address`) VALUES
(3, 'ABC Publishers', 'abc@example.com', '0776543210', 'Colombo, Sri Lanka'),
(4, 'XYZ Books Distributors', 'xyz@example.com', '0712345678', 'Kandy, Sri Lanka'),
(5, 'Read Lanka Ltd.', 'readlanka@example.com', '0769876543', 'Galle, Sri Lanka'),
(6, 'New Era Books', 'newera@example.com', '0754321098', 'Jaffna, Sri Lanka');

-- --------------------------------------------------------

--
-- Table structure for table `supplierorder`
--

CREATE TABLE `supplierorder` (
  `id` int(11) NOT NULL,
  `supplierId` int(11) NOT NULL,
  `userId` int(11) NOT NULL,
  `bookId` int(11) NOT NULL,
  `date` date NOT NULL,
  `quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `supplierorder`
--

INSERT INTO `supplierorder` (`id`, `supplierId`, `userId`, `bookId`, `date`, `quantity`) VALUES
(3, 6, 8, 5, '2025-03-12', 15),
(4, 3, 8, 6, '2025-03-12', 10),
(5, 5, 8, 9, '2025-03-12', 20),
(6, 6, 8, 10, '2025-03-12', 15),
(7, 3, 8, 13, '2025-03-12', 15),
(8, 5, 8, 14, '2025-03-12', 10);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `fullName` varchar(100) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(200) NOT NULL,
  `phoneNo` varchar(10) NOT NULL,
  `type` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `fullName`, `username`, `password`, `phoneNo`, `type`) VALUES
(8, 'admin', 'admin', '$2a$11$HxWtkCt7ZgyGqfys6LPcGOkpcs4T21U4AntbcUBRxsEVLb..wmRjy', '0710453447', 'Admin'),
(9, 'Staff', 'staff', '$2a$11$YsyAWwifGuw2hH5CqXVLQOCox5NRfqZs8HvST4HuHbWuiSvzlAumC', '0751156985', 'Sales Clerk');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `book`
--
ALTER TABLE `book`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `title` (`title`,`author`,`genre`,`isbn`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `phoneNo` (`phoneNo`);

--
-- Indexes for table `customerorder`
--
ALTER TABLE `customerorder`
  ADD PRIMARY KEY (`id`),
  ADD KEY `customerId` (`customerId`),
  ADD KEY `userId` (`userId`);

--
-- Indexes for table `custorderdetails`
--
ALTER TABLE `custorderdetails`
  ADD KEY `custOrderId` (`custOrderId`,`bookId`),
  ADD KEY `bookId` (`bookId`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `name` (`name`),
  ADD UNIQUE KEY `phoneNo` (`phoneNo`);

--
-- Indexes for table `supplierorder`
--
ALTER TABLE `supplierorder`
  ADD PRIMARY KEY (`id`),
  ADD KEY `userId` (`userId`),
  ADD KEY `supplierId` (`supplierId`),
  ADD KEY `bookId` (`bookId`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `book`
--
ALTER TABLE `book`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `customerorder`
--
ALTER TABLE `customerorder`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `supplierorder`
--
ALTER TABLE `supplierorder`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `customerorder`
--
ALTER TABLE `customerorder`
  ADD CONSTRAINT `customerorder_ibfk_1` FOREIGN KEY (`customerId`) REFERENCES `customer` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `customerorder_ibfk_2` FOREIGN KEY (`userId`) REFERENCES `users` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `custorderdetails`
--
ALTER TABLE `custorderdetails`
  ADD CONSTRAINT `custorderdetails_ibfk_1` FOREIGN KEY (`custOrderId`) REFERENCES `customerorder` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `custorderdetails_ibfk_2` FOREIGN KEY (`bookId`) REFERENCES `book` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `supplierorder`
--
ALTER TABLE `supplierorder`
  ADD CONSTRAINT `supplierorder_ibfk_1` FOREIGN KEY (`supplierId`) REFERENCES `supplier` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `supplierorder_ibfk_2` FOREIGN KEY (`userId`) REFERENCES `users` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `supplierorder_ibfk_3` FOREIGN KEY (`bookId`) REFERENCES `book` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `supplierorder_ibfk_4` FOREIGN KEY (`bookId`) REFERENCES `book` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
