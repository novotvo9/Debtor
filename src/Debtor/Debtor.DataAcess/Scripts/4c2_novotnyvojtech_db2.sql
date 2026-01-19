-- phpMyAdmin SQL Dump
-- version 5.2.1deb1+deb12u1
-- https://www.phpmyadmin.net/
--
-- Počítač: localhost:3306
-- Vytvořeno: Pon 19. led 2026, 10:35
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
('1f8c9b7e-3a2d-4e6b-9a5c-d7f8e1b2a6c4', 'Veronika Malá', 'debtor', 'veronika.m@email.cz', '777888999', '2026-01-19 11:31:49'),
('4c7e2a6d-9f1b-4e8a-a3c5-d6b9f1e8c2a7', 'Alena Kučerová', 'debtor', 'alena.k@email.cz', '778333444', '2026-01-19 11:31:49'),
('6d4a8f2e-9b1c-4d7a-a5e3-1f9c8b6d2e7a', 'Martin Král', 'testor', 'martin.k@email.cz', '777666777', '2026-01-19 11:31:49'),
('8a5f6d2c-1e9b-4c7a-bd3f-2e8a9c6d4f1b', 'Jakub Němec', 'debtor', 'jakub.n@email.cz', '778555666', '2026-01-19 11:31:49'),
('9d2f7a6c-1b4e-45c8-a0f1-3e6b9d8a2c7f', 'Lucie Dvořáková', 'debtor', 'lucie.d@email.cz', '777333444', '2026-01-19 11:31:49'),
('a8b7e1c3-42f6-4d9a-9c2e-7b1a6f8d5e4c', 'Petr Svoboda', 'testor', 'petr.svoboda@email.cz', '777222333', '2026-01-19 11:31:49'),
('b2e6c4d8-7a1f-4b9e-8c5d-3a9f1e6d2b7c', 'David Veselý', 'debtor', 'david.v@email.cz', '778111222', '2026-01-19 11:31:49'),
('c4e8a1d9-7f6b-4a2e-9c0d-5b3f8e1a6d2c', 'Tomáš Černý', 'debtor', 'tomas.c@email.cz', '777444555', '2026-01-19 11:31:49'),
('e7b3a9d6-2f1c-4e8a-b5d0-9c6f1a3e8d7b', 'Eva Procházková', 'debtor', 'eva.p@email.cz', '777555666', '2026-01-19 11:31:49'),
('f3a1c4b2-9e5d-4f6a-b8a3-21a9f3c1d4e7', 'Jan Novák', 'debtor', 'jan.novak@email.cz', '777111222', '2026-01-19 11:31:49');

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
(53, 'a8b7e1c3-42f6-4d9a-9c2e-7b1a6f8d5e4c', 'payment', -2000.00, 'CZK', '2025-12-01 18:00:00', 'bank'),
(54, 'a8b7e1c3-42f6-4d9a-9c2e-7b1a6f8d5e4c', 'payment', -1500.00, 'CZK', '2026-01-05 17:30:00', 'cash'),
(56, '9d2f7a6c-1b4e-45c8-a0f1-3e6b9d8a2c7f', 'payment', -2000.00, 'CZK', '2025-11-10 14:00:00', 'bank'),
(57, '9d2f7a6c-1b4e-45c8-a0f1-3e6b9d8a2c7f', 'payment', -2000.00, 'CZK', '2025-12-10 14:00:00', 'bank'),
(58, '9d2f7a6c-1b4e-45c8-a0f1-3e6b9d8a2c7f', 'payment', -1500.00, 'CZK', '2026-01-02 16:00:00', 'cash'),
(59, '9d2f7a6c-1b4e-45c8-a0f1-3e6b9d8a2c7f', 'payment', -1000.00, 'CZK', '2026-01-06 16:00:00', 'bank'),
(62, 'c4e8a1d9-7f6b-4a2e-9c0d-5b3f8e1a6d2c', 'payment', -3000.00, 'CZK', '2025-10-01 18:00:00', 'bank'),
(63, 'c4e8a1d9-7f6b-4a2e-9c0d-5b3f8e1a6d2c', 'payment', -3000.00, 'CZK', '2025-11-01 18:00:00', 'bank'),
(64, 'c4e8a1d9-7f6b-4a2e-9c0d-5b3f8e1a6d2c', 'payment', -2500.00, 'CZK', '2025-12-01 18:00:00', 'cash'),
(65, 'c4e8a1d9-7f6b-4a2e-9c0d-5b3f8e1a6d2c', 'payment', -2000.00, 'CZK', '2025-12-20 18:00:00', 'bank'),
(66, 'c4e8a1d9-7f6b-4a2e-9c0d-5b3f8e1a6d2c', 'payment', -1500.00, 'CZK', '2026-01-05 18:00:00', 'bank'),
(67, 'c4e8a1d9-7f6b-4a2e-9c0d-5b3f8e1a6d2c', 'payment', -1200.00, 'CZK', '2026-01-10 18:00:00', 'cash'),
(70, 'e7b3a9d6-2f1c-4e8a-b5d0-9c6f1a3e8d7b', 'payment', -1000.00, 'CZK', '2026-01-05 15:00:00', 'cash'),
(72, '6d4a8f2e-9b1c-4d7a-a5e3-1f9c8b6d2e7a', 'payment', -2000.00, 'CZK', '2025-11-20 18:00:00', 'bank'),
(73, '6d4a8f2e-9b1c-4d7a-a5e3-1f9c8b6d2e7a', 'payment', -2000.00, 'CZK', '2025-12-05 18:00:00', 'bank'),
(74, '6d4a8f2e-9b1c-4d7a-a5e3-1f9c8b6d2e7a', 'payment', -1500.00, 'CZK', '2025-12-20 18:00:00', 'cash'),
(75, '6d4a8f2e-9b1c-4d7a-a5e3-1f9c8b6d2e7a', 'payment', -1000.00, 'CZK', '2026-01-10 18:00:00', 'bank');

--
-- Indexy pro exportované tabulky
--

--
-- Indexy pro tabulku `accounts`
--
ALTER TABLE `accounts`
  ADD PRIMARY KEY (`account_id`),
  ADD KEY `full_name` (`full_name`,`email`,`phone`);

--
-- Indexy pro tabulku `account_transactions`
--
ALTER TABLE `account_transactions`
  ADD PRIMARY KEY (`transaction_id`),
  ADD KEY `FK_account_transactions_accounts` (`account_id`);

--
-- AUTO_INCREMENT pro tabulky
--

--
-- AUTO_INCREMENT pro tabulku `account_transactions`
--
ALTER TABLE `account_transactions`
  MODIFY `transaction_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=76;

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
