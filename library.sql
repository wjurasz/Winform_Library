-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:8889
-- Czas generowania: 15 Cze 2024, 11:19
-- Wersja serwera: 5.7.24
-- Wersja PHP: 8.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `library`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `books`
--

CREATE TABLE `books` (
  `BOOKID` int(11) NOT NULL,
  `TITLE` varchar(100) NOT NULL,
  `AUTHOR` varchar(100) NOT NULL,
  `YEAR` int(11) NOT NULL,
  `IsBorrowed` tinyint(1) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Zrzut danych tabeli `books`
--

INSERT INTO `books` (`BOOKID`, `TITLE`, `AUTHOR`, `YEAR`, `IsBorrowed`) VALUES
(1, 'Lalka', 'Bolesław Prus', 1889, 1),
(2, 'Mistrz i Małgorzata', 'Michaił Bułhakow', 1967, 1),
(3, 'Pan Tadeusz', 'Adam Mickiewicz', 1834, 1),
(4, 'Quo Vadis', 'Henryk Sienkiewicz', 1896, 1),
(5, 'Potop', 'Henryk Sienkiewicz', 1886, 1),
(6, 'Krzyżacy', 'Henryk Sienkiewicz', 1900, 1),
(7, 'Chłopi', 'Władysław Reymont', 1904, 1),
(8, 'Faraon', 'Bolesław Prus', 1897, 1),
(9, 'W pustyni i w puszczy', 'Henryk Sienkiewicz', 1911, 1),
(10, 'Kamienie na szaniec', 'Aleksander Kamiński', 1943, 1),
(11, 'Ania z Zielonego Wzgórza', 'Lucy Maud Montgomery', 1908, 1),
(12, 'Dzieci z Bullerbyn', 'Astrid Lindgren', 1947, 0),
(13, 'Harry Potter i Kamień Filozoficzny', 'J.K. Rowling', 1997, 1),
(14, 'Hobbit', 'J.R.R. Tolkien', 1937, 1),
(15, 'Władca Pierścieni', 'J.R.R. Tolkien', 1954, 1),
(16, 'Mały Książę', 'Antoine de Saint-Exupéry', 1943, 0),
(17, 'Moby Dick', 'Herman Melville', 1851, 0),
(18, 'Don Kichot', 'Miguel de Cervantes', 1605, 0),
(19, 'Hamlet', 'William Shakespeare', 1603, 1),
(20, 'Romeo i Julia', 'William Shakespeare', 1597, 0),
(21, 'Makbet', 'William Shakespeare', 1606, 1),
(22, 'Opowieść wigilijna', 'Charles Dickens', 1843, 0),
(23, 'Oliver Twist', 'Charles Dickens', 1837, 1),
(24, 'Wielkie nadzieje', 'Charles Dickens', 1861, 0),
(25, 'David Copperfield', 'Charles Dickens', 1850, 0),
(26, 'Tajemnica Edwina Drooda', 'Charles Dickens', 1870, 0),
(27, 'Duma i uprzedzenie', 'Jane Austen', 1813, 0),
(28, 'Emma', 'Jane Austen', 1815, 1),
(29, 'Rozważna i romantyczna', 'Jane Austen', 1811, 1),
(30, 'Opactwo Northanger', 'Jane Austen', 1817, 1);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `borrowedbooks`
--

CREATE TABLE `borrowedbooks` (
  `BORROWID` int(11) NOT NULL,
  `BORROWDATE` int(11) NOT NULL,
  `RETURNDATE` int(11) NOT NULL,
  `user_ID` int(11) DEFAULT NULL,
  `BOOKID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Zrzut danych tabeli `borrowedbooks`
--

INSERT INTO `borrowedbooks` (`BORROWID`, `BORROWDATE`, `RETURNDATE`, `user_ID`, `BOOKID`) VALUES
(19, 20240615, 20240629, 5, 1),
(20, 20240615, 20240629, 5, 9),
(21, 20240615, 20240629, 5, 14),
(22, 20240615, 20240629, 5, 15),
(23, 20240615, 20240629, 5, 21),
(24, 20240615, 20240629, 5, 23),
(25, 20240615, 20240629, 6, 2),
(27, 20240615, 20240629, 6, 8),
(28, 20240615, 20240629, 6, 19),
(29, 20240615, 20240629, 9, 3),
(30, 20240615, 20240629, 9, 6),
(31, 20240615, 20240629, 9, 29),
(32, 20240615, 20240629, 9, 30),
(33, 20240615, 20240629, 9, 28),
(34, 20240615, 20240629, 8, 4),
(35, 20240615, 20240629, 8, 5),
(36, 20240615, 20240629, 8, 7),
(37, 20240615, 20240629, 8, 13),
(39, 20240615, 20240629, 7, 11),
(40, 20240615, 20240629, 7, 10);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `users`
--

CREATE TABLE `users` (
  `ID` int(11) NOT NULL,
  `USERNAME` varchar(50) NOT NULL,
  `PASSWORD` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Zrzut danych tabeli `users`
--

INSERT INTO `users` (`ID`, `USERNAME`, `PASSWORD`) VALUES
(5, 'Wojciech_Jurasz', 'wj'),
(6, 'Kacper_Zaba', 'kz'),
(7, 'Piotr_Dawidowski', 'pd'),
(8, 'Maksymilian_Lechowicz', 'ml'),
(9, 'Robert_Lewandowski', 'rl'),
(10, 'Iga_Swiatek', 'is');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`BOOKID`);

--
-- Indeksy dla tabeli `borrowedbooks`
--
ALTER TABLE `borrowedbooks`
  ADD PRIMARY KEY (`BORROWID`);

--
-- Indeksy dla tabeli `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT dla zrzuconych tabel
--

--
-- AUTO_INCREMENT dla tabeli `books`
--
ALTER TABLE `books`
  MODIFY `BOOKID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT dla tabeli `borrowedbooks`
--
ALTER TABLE `borrowedbooks`
  MODIFY `BORROWID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;

--
-- AUTO_INCREMENT dla tabeli `users`
--
ALTER TABLE `users`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
