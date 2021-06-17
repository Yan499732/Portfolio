-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Май 29 2021 г., 12:48
-- Версия сервера: 10.4.11-MariaDB
-- Версия PHP: 7.4.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `requests`
--

-- --------------------------------------------------------

--
-- Структура таблицы `allrequests`
--

CREATE TABLE `allrequests` (
  `ID` int(100) NOT NULL,
  `YF` varchar(100) NOT NULL,
  `YI` varchar(100) NOT NULL,
  `YO` varchar(100) NOT NULL,
  `DA` varchar(100) NOT NULL,
  `MF` varchar(100) NOT NULL,
  `MI` varchar(100) NOT NULL,
  `MO` varchar(100) NOT NULL,
  `OF` varchar(100) NOT NULL,
  `OI` varchar(100) NOT NULL,
  `OO` varchar(100) NOT NULL,
  `KSR` longblob NOT NULL,
  `SZPPK` longblob NOT NULL,
  `SNILS` longblob NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `allrequests`
--

INSERT INTO `allrequests` (`ID`, `YF`, `YI`, `YO`, `DA`, `MF`, `MI`, `MO`, `OF`, `OI`, `OO`, `KSR`, `SZPPK`, `SNILS`) VALUES

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `allrequests`
--
ALTER TABLE `allrequests`
  ADD UNIQUE KEY `ID` (`ID`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `allrequests`
--
ALTER TABLE `allrequests`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;