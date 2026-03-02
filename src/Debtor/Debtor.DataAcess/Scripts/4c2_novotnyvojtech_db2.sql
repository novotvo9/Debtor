-- phpMyAdmin SQL Dump
-- version 5.2.1deb1+deb12u1
-- https://www.phpmyadmin.net/
--
-- Počítač: localhost:3306
-- Vytvořeno: Pon 02. bře 2026, 10:15
-- Verze serveru: 10.11.11-MariaDB-0+deb12u1
-- Verze PHP: 8.2.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Databáze: `4c2_novotnyvojtech_db2`
--

-- --------------------------------------------------------

--
-- Struktura tabulky `accounts`
--

CREATE TABLE `accounts` (
  `account_id` char(36) NOT NULL,
  `full_name` varchar(120) NOT NULL,
  `account_type` varchar(16) NOT NULL,
  `email` varchar(254) NOT NULL,
  `phone` varchar(32) NOT NULL,
  `created_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vypisuji data pro tabulku `accounts`
--

INSERT INTO `accounts` (`account_id`, `full_name`, `account_type`, `email`, `phone`, `created_at`) VALUES
('4c7e2a6d-9f1b-4e8a-a3c5-d6b9f1e8c2a7', 'Alena Kučerová', 'debtor', 'alena.k@email.cz', '778333444', '2026-01-19 11:31:49'),
('60645d4d-00e4-4e0c-aeb2-f8f9747c6fdc', 'Jan Nov', 'debtor', 'test@test.cz', '121123123', '2026-02-09 10:28:52'),
('624ed16e-c036-4386-a51c-e05e49681ce8', 'fffff', 'debtor', 'novyucet@email.com', '123456', '2026-03-02 10:41:39'),
('6d4a8f2e-9b1c-4d7a-a5e3-1f9c8b6d2e7a', 'Martin Král', 'testor', 'martin.k@email.cz', '777666777', '2026-01-19 11:31:49'),
('893caec4-87e1-4d9a-85a9-0a396b10dc98', 'testiik', 'debtor', 'test@test.com', '+420123456', '2026-02-16 08:38:30'),
('8a5f6d2c-1e9b-4c7a-bd3f-2e8a9c6d4f1b', 'Jakub Němec', 'debtor', 'jakub.n@email.cz', '778555666', '2026-01-19 11:31:49'),
('a8b7e1c3-42f6-4d9a-9c2e-7b1a6f8d5e4c', 'Petr Svoboda', 'testor', 'petr.svoboda@email.cz', '777222333', '2026-01-19 11:31:49'),
('b2e6c4d8-7a1f-4b9e-8c5d-3a9f1e6d2b7c', 'David Veselý', 'debtor', 'david.v@email.cz', '778111222', '2026-01-19 11:31:49'),
('bb3a7c51-9a7f-4024-bf87-32da9dd0f486', 'testicek testovy', 'testor', 'test2@test2.com', '123456789', '2026-02-16 08:08:03'),
('c4e8a1d9-7f6b-4a2e-9c0d-5b3f8e1a6d2c', 'Tomáš Černý', 'debtor', 'tomas.c@email.cz', '777444555', '2026-01-19 11:31:49'),
('c51d5f62-af6f-4f2b-868c-ef097daf43ff', 'novyyy', 'debtor', 'novyy@email.cz', '123456', '2026-03-02 10:58:50'),
('e7b3a9d6-2f1c-4e8a-b5d0-9c6f1a3e8d7b', 'Eva Procházková', 'debtor', 'eva.p@email.cz', '777555666', '2026-01-19 11:31:49'),
('f3a1c4b2-9e5d-4f6a-b8a3-21a9f3c1d4e7', 'Jan Novák', 'debtor', 'jan.novak@email.cz', '777111222', '2026-01-19 11:31:49'),
('f5e63c83-5ddd-4442-82b1-e18c852f54a4', 'Tyranosaurus Rex', 'debtor', 'rex@dino.com', '123456789', '2026-02-16 10:14:29');

-- --------------------------------------------------------

--
-- Struktura tabulky `account_transactions`
--

CREATE TABLE `account_transactions` (
  `transaction_id` int(11) NOT NULL,
  `account_id` char(36) NOT NULL,
  `transaction_type` varchar(16) NOT NULL,
  `amount` decimal(18,2) NOT NULL,
  `currency` char(3) NOT NULL,
  `transaction_at` datetime NOT NULL,
  `payment_method` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vypisuji data pro tabulku `account_transactions`
--

INSERT INTO `account_transactions` (`transaction_id`, `account_id`, `transaction_type`, `amount`, `currency`, `transaction_at`, `payment_method`) VALUES
(53, 'a8b7e1c3-42f6-4d9a-9c2e-7b1a6f8d5e4c', 'payment', 2000.00, 'CZK', '2025-12-01 18:00:00', 'bank'),
(54, 'a8b7e1c3-42f6-4d9a-9c2e-7b1a6f8d5e4c', 'payment', 1500.00, 'CZK', '2026-01-05 17:30:00', 'cash'),
(62, 'c4e8a1d9-7f6b-4a2e-9c0d-5b3f8e1a6d2c', 'borrow', 3000.00, 'CZK', '2025-10-01 18:00:00', 'bank'),
(63, 'c4e8a1d9-7f6b-4a2e-9c0d-5b3f8e1a6d2c', 'payment', 3000.00, 'CZK', '2025-11-01 18:00:00', 'bank'),
(64, 'c4e8a1d9-7f6b-4a2e-9c0d-5b3f8e1a6d2c', 'payment', 2500.00, 'CZK', '2025-12-01 18:00:00', 'cash'),
(65, 'c4e8a1d9-7f6b-4a2e-9c0d-5b3f8e1a6d2c', 'borrow', 2000.00, 'CZK', '2025-12-20 18:00:00', 'bank'),
(66, 'c4e8a1d9-7f6b-4a2e-9c0d-5b3f8e1a6d2c', 'borrow', 1500.00, 'CZK', '2026-01-05 18:00:00', 'bank'),
(67, 'c4e8a1d9-7f6b-4a2e-9c0d-5b3f8e1a6d2c', 'payment', 1200.00, 'CZK', '2026-01-10 18:00:00', 'cash'),
(70, 'e7b3a9d6-2f1c-4e8a-b5d0-9c6f1a3e8d7b', 'borrow', 1000.00, 'CZK', '2026-01-05 15:00:00', 'cash'),
(72, '6d4a8f2e-9b1c-4d7a-a5e3-1f9c8b6d2e7a', 'payment', 2000.00, 'CZK', '2025-11-20 18:00:00', 'bank'),
(73, '6d4a8f2e-9b1c-4d7a-a5e3-1f9c8b6d2e7a', 'borrow', 2000.00, 'CZK', '2025-12-05 18:00:00', 'bank'),
(74, '6d4a8f2e-9b1c-4d7a-a5e3-1f9c8b6d2e7a', 'borrow', 1500.00, 'CZK', '2025-12-20 18:00:00', 'cash'),
(75, '6d4a8f2e-9b1c-4d7a-a5e3-1f9c8b6d2e7a', 'payment', 1000.00, 'CZK', '2026-01-10 18:00:00', 'bank'),
(81, 'bb3a7c51-9a7f-4024-bf87-32da9dd0f486', 'payment', 500.00, 'CZK', '2026-02-16 08:10:22', 'bank'),
(84, '893caec4-87e1-4d9a-85a9-0a396b10dc98', 'payment', 500.00, 'CZK', '2026-02-16 10:58:03', 'bank'),
(85, '893caec4-87e1-4d9a-85a9-0a396b10dc98', 'borrow', 1000.00, 'CZK', '2026-02-16 10:58:21', 'bank'),
(86, '624ed16e-c036-4386-a51c-e05e49681ce8', 'borrow', 1000.00, 'CZK', '2026-03-02 10:54:01', 'bank'),
(87, 'c51d5f62-af6f-4f2b-868c-ef097daf43ff', 'borrow', 500.00, 'CZK', '2026-03-02 10:59:41', 'cash'),
(88, '4c7e2a6d-9f1b-4e8a-a3c5-d6b9f1e8c2a7', 'payment', 1.00, 'CZK', '2026-03-02 11:00:57', 'bank'),
(89, 'c51d5f62-af6f-4f2b-868c-ef097daf43ff', 'payment', 10.00, 'CZK', '2026-03-02 11:06:42', 'bank'),
(90, 'c51d5f62-af6f-4f2b-868c-ef097daf43ff', 'borrow', 40000.00, 'CZK', '2026-03-02 11:10:49', 'bank');

-- --------------------------------------------------------

--
-- Struktura tabulky `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `email` varchar(254) NOT NULL,
  `password` varchar(254) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vypisuji data pro tabulku `users`
--

INSERT INTO `users` (`user_id`, `email`, `password`) VALUES
(1, 'admin@hostmaster.com', 'admin'),
(2, 'test@test.com', '123456'),
(3, 'test2@test2.com', '123'),
(4, 'novyucet@email.com', '123456'),
(5, 'alena.k@email.cz', '123456'),
(6, 'martin.k@email.cz', '123456'),
(7, 'test@test.cz', '123456'),
(8, 'jakub.n@email.cz', '123456'),
(9, 'petr.svoboda@email.cz', '123456'),
(10, 'david.v@email.cz', '123456'),
(11, 'tomas.c@email.cz', '123456'),
(12, 'eva.p@email.cz', '123456'),
(13, 'jan.novak@email.cz', '123456'),
(14, 'novyy@email.cz', '123456');

--
-- Indexy pro exportované tabulky
--

--
-- Indexy pro tabulku `accounts`
--
ALTER TABLE `accounts`
  ADD PRIMARY KEY (`account_id`),
  ADD UNIQUE KEY `email` (`email`),
  ADD KEY `full_name` (`full_name`,`email`,`phone`);

--
-- Indexy pro tabulku `account_transactions`
--
ALTER TABLE `account_transactions`
  ADD PRIMARY KEY (`transaction_id`),
  ADD KEY `FK_account_transactions_accounts` (`account_id`);

--
-- Indexy pro tabulku `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `email` (`email`);

--
-- AUTO_INCREMENT pro tabulky
--

--
-- AUTO_INCREMENT pro tabulku `account_transactions`
--
ALTER TABLE `account_transactions`
  MODIFY `transaction_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=91;

--
-- AUTO_INCREMENT pro tabulku `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- Omezení pro exportované tabulky
--

--
-- Omezení pro tabulku `account_transactions`
--
ALTER TABLE `account_transactions`
  ADD CONSTRAINT `FK_account_transactions_accounts` FOREIGN KEY (`account_id`) REFERENCES `accounts` (`account_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
