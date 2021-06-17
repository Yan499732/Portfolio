-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Июн 16 2021 г., 03:57
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
-- База данных: `school`
--

-- --------------------------------------------------------

--
-- Структура таблицы `eventresults`
--

CREATE TABLE `eventresults` (
  `ID` int(100) NOT NULL,
  `ID_type` int(100) NOT NULL,
  `NameMP` varchar(100) NOT NULL,
  `ID_member` int(100) NOT NULL,
  `Year` int(100) NOT NULL,
  `Place` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `eventsmembers`
--

CREATE TABLE `eventsmembers` (
  `ID_member` int(100) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Surname` varchar(100) NOT NULL,
  `Patronymic` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `eventsmembers`
--

INSERT INTO `eventsmembers` (`ID_member`, `Name`, `Surname`, `Patronymic`) VALUES
(1, 'Иван', 'Иванов', 'Иванович'),
(2, 'Пётр', 'Петров', 'Петрович');

-- --------------------------------------------------------

--
-- Структура таблицы `eventtype`
--

CREATE TABLE `eventtype` (
  `ID` int(11) NOT NULL,
  `eventtypename` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `eventtype`
--

INSERT INTO `eventtype` (`ID`, `eventtypename`) VALUES
(1, 'Соревнование'),
(2, 'Олимпиада');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `eventresults`
--
ALTER TABLE `eventresults`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `ID_member` (`ID_member`),
  ADD KEY `TypeMP` (`ID_type`);

--
-- Индексы таблицы `eventsmembers`
--
ALTER TABLE `eventsmembers`
  ADD PRIMARY KEY (`ID_member`),
  ADD KEY `ID` (`ID_member`);

--
-- Индексы таблицы `eventtype`
--
ALTER TABLE `eventtype`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `eventresults`
--
ALTER TABLE `eventresults`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT для таблицы `eventsmembers`
--
ALTER TABLE `eventsmembers`
  MODIFY `ID_member` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблицы `eventtype`
--
ALTER TABLE `eventtype`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `eventresults`
--
ALTER TABLE `eventresults`
  ADD CONSTRAINT `eventresults_ibfk_1` FOREIGN KEY (`ID_member`) REFERENCES `eventsmembers` (`ID_member`) ON UPDATE CASCADE,
  ADD CONSTRAINT `eventresults_ibfk_2` FOREIGN KEY (`ID_type`) REFERENCES `eventtype` (`ID`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
