-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Počítač: 127.0.0.1:3307
-- Vytvořeno: Ned 11. led 2026, 20:01
-- Verze serveru: 10.4.32-MariaDB
-- Verze PHP: 8.2.12

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
('b2d4d86b-ef14-11f0-96d7-e40d36ebf1a8', 'Jan Novák', 'debtor', 'jan.novak@email.cz', '777111222', '2026-01-11 18:41:02'),
('b2d4e10a-ef14-11f0-96d7-e40d36ebf1a8', 'Petr Svoboda', 'debtor', 'petr.svoboda@email.cz', '777333444', '2026-01-11 18:41:02'),
('b2d4e2c5-ef14-11f0-96d7-e40d36ebf1a8', 'Lucie Dvořáková', 'debtor', 'lucie.dvorakova@email.cz', '777555666', '2026-01-11 18:41:02'),
('b2d4e370-ef14-11f0-96d7-e40d36ebf1a8', 'Tomáš Černý', 'debtor', 'tomas.cerny@email.cz', '777777888', '2026-01-11 18:41:02'),
('b2d4e402-ef14-11f0-96d7-e40d36ebf1a8', 'Eva Procházková', 'debtor', 'eva.prochazkova@email.cz', '777999000', '2026-01-11 18:41:02'),
('b2d4e485-ef14-11f0-96d7-e40d36ebf1a8', 'Martin Král', 'debtor', 'martin.kral@email.cz', '776111222', '2026-01-11 18:41:02'),
('b2d4e510-ef14-11f0-96d7-e40d36ebf1a8', 'Veronika Malá', 'debtor', 'veronika.mala@email.cz', '776333444', '2026-01-11 18:41:02'),
('b2d4e599-ef14-11f0-96d7-e40d36ebf1a8', 'David Veselý', 'debtor', 'david.vesely@email.cz', '776555666', '2026-01-11 18:41:02'),
('b2d4e64b-ef14-11f0-96d7-e40d36ebf1a8', 'Alena Kučerová', 'debtor', 'alena.kucerova@email.cz', '776777888', '2026-01-11 18:41:02'),
('b2d4e6d5-ef14-11f0-96d7-e40d36ebf1a8', 'Jakub Němec', 'debtor', 'jakub.nemec@email.cz', '776999000', '2026-01-11 18:41:02'),
('b2d4e75b-ef14-11f0-96d7-e40d36ebf1a8', 'Simona Horáková', 'debtor', 'simona.horakova@email.cz', '775111222', '2026-01-11 18:41:02'),
('b2d4e7e2-ef14-11f0-96d7-e40d36ebf1a8', 'Michal Beneš', 'debtor', 'michal.benes@email.cz', '775333444', '2026-01-11 18:41:02');

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
(2, 'b2d4d86b-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -1500.00, 'CZK', '2025-12-09 18:41:57', 'bank'),
(3, 'b2d4d86b-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -2000.00, 'CZK', '2025-12-17 18:41:57', 'bank'),
(5, 'b2d4d86b-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -1000.00, 'CZK', '2025-12-30 18:41:57', 'cash'),
(7, 'b2d4e10a-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -1000.00, 'CZK', '2025-11-24 18:41:57', 'cash'),
(8, 'b2d4e10a-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -1000.00, 'CZK', '2025-12-01 18:41:57', 'bank'),
(9, 'b2d4e10a-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -1200.00, 'CZK', '2025-12-12 18:41:57', 'bank'),
(11, 'b2d4e10a-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -800.00, 'CZK', '2026-01-05 18:41:57', 'cash'),
(13, 'b2d4e2c5-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -500.00, 'CZK', '2025-12-27 18:41:57', 'bank'),
(14, 'b2d4e2c5-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -700.00, 'CZK', '2026-01-02 18:41:57', 'bank'),
(16, 'b2d4e370-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -3000.00, 'CZK', '2025-10-28 18:41:57', 'bank'),
(17, 'b2d4e370-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -2500.00, 'CZK', '2025-11-12 18:41:57', 'bank'),
(18, 'b2d4e370-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -2000.00, 'CZK', '2025-11-27 18:41:57', 'cash'),
(19, 'b2d4e370-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -2000.00, 'CZK', '2025-12-12 18:41:57', 'bank'),
(21, 'b2d4e402-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -400.00, 'CZK', '2025-12-21 18:41:57', 'cash'),
(22, 'b2d4e402-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -600.00, 'CZK', '2025-12-28 18:41:57', 'bank'),
(23, 'b2d4e402-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -500.00, 'CZK', '2026-01-04 18:41:57', 'bank'),
(25, 'b2d4e485-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -1500.00, 'CZK', '2025-11-09 18:41:57', 'bank'),
(26, 'b2d4e485-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -1500.00, 'CZK', '2025-11-22 18:41:57', 'cash'),
(28, 'b2d4e485-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -1000.00, 'CZK', '2026-01-01 18:41:57', 'bank'),
(30, 'b2d4e510-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -300.00, 'CZK', '2026-01-03 18:41:57', 'cash'),
(32, 'b2d4e599-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -1000.00, 'CZK', '2025-11-14 18:41:57', 'bank'),
(33, 'b2d4e599-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -1000.00, 'CZK', '2025-11-28 18:41:57', 'bank'),
(34, 'b2d4e599-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -1000.00, 'CZK', '2025-12-11 18:41:57', 'cash'),
(35, 'b2d4e599-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -1200.00, 'CZK', '2025-12-25 18:41:57', 'bank'),
(37, 'b2d4e64b-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -800.00, 'CZK', '2025-12-16 18:41:57', 'bank'),
(38, 'b2d4e64b-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -900.00, 'CZK', '2025-12-23 18:41:57', 'cash'),
(39, 'b2d4e64b-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -700.00, 'CZK', '2026-01-06 18:41:57', 'bank'),
(40, 'b2d4e6d5-ef14-11f0-96d7-e40d36ebf1a8', 'debt', 2000.00, 'CZK', '2025-12-30 18:41:57', ''),
(41, 'b2d4e6d5-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -200.00, 'CZK', '2026-01-07 18:41:57', 'cash'),
(42, 'b2d4e75b-ef14-11f0-96d7-e40d36ebf1a8', 'debt', 18000.00, 'CZK', '2025-09-13 18:41:57', ''),
(43, 'b2d4e75b-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -3000.00, 'CZK', '2025-10-13 18:41:57', 'bank'),
(44, 'b2d4e75b-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -2500.00, 'CZK', '2025-11-12 18:41:57', 'bank'),
(45, 'b2d4e75b-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -1500.00, 'CZK', '2025-12-12 18:41:57', 'cash'),
(46, 'b2d4e75b-ef14-11f0-96d7-e40d36ebf1a8', 'debt', 1500.00, 'CZK', '2025-12-22 18:41:57', ''),
(47, 'b2d4e7e2-ef14-11f0-96d7-e40d36ebf1a8', 'debt', 7200.00, 'CZK', '2025-11-20 18:41:57', ''),
(48, 'b2d4e7e2-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -900.00, 'CZK', '2025-12-04 18:41:57', 'bank'),
(49, 'b2d4e7e2-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -900.00, 'CZK', '2025-12-18 18:41:57', 'cash'),
(50, 'b2d4e7e2-ef14-11f0-96d7-e40d36ebf1a8', 'payment', -900.00, 'CZK', '2026-01-01 18:41:57', 'bank');

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
  MODIFY `transaction_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

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
