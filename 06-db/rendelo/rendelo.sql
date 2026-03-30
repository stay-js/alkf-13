DROP DATABASE IF EXISTS `rendelo`;
CREATE DATABASE IF NOT EXISTS `rendelo`;

USE `rendelo`;

CREATE TABLE IF NOT EXISTS `kezeles`(
	`kezeles_id` int(11) NOT NULL AUTO_INCREMENT,
	`paciens_id` int(11) NOT NULL,
	`orvos_id` int(11) NOT NULL,
	`datum` date NOT NULL,
	`kezdesido` int(11) NOT NULL,
	`idotartam` int(11) NOT NULL,
	`megjegyzes` varchar(31) CHARACTER SET utf8 NOT NULL,
 PRIMARY KEY (`kezeles_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci AUTO_INCREMENT=43;

INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (1, 1, 1, CAST('2017-08-17' AS Date), 12, 2, 'Konzultáció szükséges');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (2, 13, 13, CAST('2017-05-20' AS Date), 14, 3, '');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (3, 32, 12, CAST('2017-07-12' AS Date), 15, 1, 'Teljesen felépült');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (4, 3, 3, CAST('2017-05-18' AS Date), 13, 1, 'Műtétet elutasította');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (5, 6, 6, CAST('2017-05-26' AS Date), 12, 4, '');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (6, 8, 18, CAST('2017-09-12' AS Date), 11, 2, 'Teljesen felépült');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (7, 23, 3, CAST('2017-03-12' AS Date), 10, 2, '');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (8, 4, 4, CAST('2017-03-26' AS Date), 9, 3, 'Teljesen felépült');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (9, 5, 15, CAST('2017-03-07' AS Date), 8, 1, '');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (10, 7, 7, CAST('2017-08-02' AS Date), 8, 1, 'Teljesen felépült');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (11, 2, 2, CAST('2017-06-27' AS Date), 12, 4, '');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (12, 11, 1, CAST('2017-08-15' AS Date), 14, 2, '');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (13, 25, 15, CAST('2017-04-10' AS Date), 15, 2, '');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (14, 33, 3, CAST('2017-03-17' AS Date), 13, 3, 'Teljesen felépült');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (15, 27, 17, CAST('2017-06-05' AS Date), 12, 1, '');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (16, 19, 9, CAST('2017-04-26' AS Date), 11, 1, '');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (17, 18, 8, CAST('2017-05-05' AS Date), 10, 4, 'Teljesen felépült');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (18, 21, 1, CAST('2017-03-13' AS Date), 9, 2, '');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (19, 22, 12, CAST('2017-05-22' AS Date), 8, 2, 'Teljesen felépült');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (20, 11, 1, CAST('2017-03-13' AS Date), 8, 3, '');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (21, 13, 13, CAST('2017-07-06' AS Date), 12, 1, 'Teljesen felépült');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (22, 14, 14, CAST('2017-03-02' AS Date), 14, 1, '');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (23, 16, 6, CAST('2017-06-23' AS Date), 15, 4, 'Utógondozást igényel');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (24, 15, 5, CAST('2017-06-12' AS Date), 13, 2, '');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (25, 5, 15, CAST('2017-04-01' AS Date), 12, 2, '');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (26, 7, 7, CAST('2017-03-07' AS Date), 11, 3, 'Teljesen felépült');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (27, 31, 1, CAST('2017-06-01' AS Date), 10, 1, '');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (28, 36, 16, CAST('2018-01-22' AS Date), 9, 1, '');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (29, 35, 5, CAST('2018-01-14' AS Date), 8, 4, '');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (30, 34, 4, CAST('2018-01-25' AS Date), 8, 2, '');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (31, 33, 3, CAST('2018-01-04' AS Date), 12, 2, 'Teljesen felépült');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (32, 12, 12, CAST('2018-01-23' AS Date), 14, 3, '');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (33, 29, 9, CAST('2018-03-14' AS Date), 15, 1, '');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (34, 14, 14, CAST('2018-03-19' AS Date), 13, 1, 'Teljesen felépült');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (35, 11, 1, CAST('2018-03-12' AS Date), 12, 4, '');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (36, 21, 1, CAST('2018-03-23' AS Date), 11, 2, '');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (37, 31, 1, CAST('2018-02-18' AS Date), 10, 2, '');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (38, 34, 14, CAST('2018-02-15' AS Date), 9, 3, '');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (39, 32, 2, CAST('2018-02-05' AS Date), 8, 1, '');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (40, 11, 11, CAST('2018-04-26' AS Date), 8, 1, '');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (41, 14, 4, CAST('2018-04-02' AS Date), 12, 4, '');
INSERT INTO `kezeles` (`kezeles_id`, `paciens_id`, `orvos_id`, `datum`, `kezdesido`, `idotartam`, `megjegyzes`) VALUES (42, 17, 17, CAST('2018-04-18' AS Date), 13, 2, '');

CREATE TABLE IF NOT EXISTS `orvos`(
	`orvos_id` int(11) NOT NULL AUTO_INCREMENT,
	`szakterulet_id` int(11) NOT NULL,
	`nev` varchar(31) CHARACTER SET utf8 NOT NULL,
	`telefon` varchar(21) CHARACTER SET utf8 NOT NULL,
	`oradij` int(11) NOT NULL,
 PRIMARY KEY (`orvos_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci AUTO_INCREMENT=21;

INSERT INTO `orvos` (`orvos_id`, `szakterulet_id`, `nev`, `telefon`, `oradij`) VALUES (1, 1, 'Dr. Szűcs Helga', '(20) 891-20-90', 3000);
INSERT INTO `orvos` (`orvos_id`, `szakterulet_id`, `nev`, `telefon`, `oradij`) VALUES (2, 10, 'Dr. Balogh Bálint', '(20) 278-30-61', 3500);
INSERT INTO `orvos` (`orvos_id`, `szakterulet_id`, `nev`, `telefon`, `oradij`) VALUES (3, 2, 'Dr. Lukács Edina', '(30) 399-86-19', 4500);
INSERT INTO `orvos` (`orvos_id`, `szakterulet_id`, `nev`, `telefon`, `oradij`) VALUES (4, 5, 'Dr. Hun Péter', '(30) 380-37-70', 6000);
INSERT INTO `orvos` (`orvos_id`, `szakterulet_id`, `nev`, `telefon`, `oradij`) VALUES (5, 6, 'Dr. Jászai Szimonetta', '(30) 740-96-29', 4000);
INSERT INTO `orvos` (`orvos_id`, `szakterulet_id`, `nev`, `telefon`, `oradij`) VALUES (6, 3, 'Dr. Andrási Emília', '(20) 477-85-92', 5000);
INSERT INTO `orvos` (`orvos_id`, `szakterulet_id`, `nev`, `telefon`, `oradij`) VALUES (7, 9, 'Dr. Balogh Edina', '(20) 929-58-10', 6500);
INSERT INTO `orvos` (`orvos_id`, `szakterulet_id`, `nev`, `telefon`, `oradij`) VALUES (8, 7, 'Dr. Tolnai Mariann', '(20) 175-87-73', 5500);
INSERT INTO `orvos` (`orvos_id`, `szakterulet_id`, `nev`, `telefon`, `oradij`) VALUES (9, 8, 'Dr. Keller Nikolett', '(20) 710-29-33', 5500);
INSERT INTO `orvos` (`orvos_id`, `szakterulet_id`, `nev`, `telefon`, `oradij`) VALUES (10, 4, 'Dr. Csiszér Bettina', '(30) 751-49-81', 4500);
INSERT INTO `orvos` (`orvos_id`, `szakterulet_id`, `nev`, `telefon`, `oradij`) VALUES (11, 4, 'Dr. Ambrus Sándor', '(70) 353-95-18', 5500);
INSERT INTO `orvos` (`orvos_id`, `szakterulet_id`, `nev`, `telefon`, `oradij`) VALUES (12, 4, 'Dr. Zoltai Rita', '(20) 516-58-10', 3500);
INSERT INTO `orvos` (`orvos_id`, `szakterulet_id`, `nev`, `telefon`, `oradij`) VALUES (13, 2, 'Dr. Tóth Gábor', '(30) 761-86-35', 6500);
INSERT INTO `orvos` (`orvos_id`, `szakterulet_id`, `nev`, `telefon`, `oradij`) VALUES (14, 3, 'Dr. Szűcs Emília', '(20) 943-11-81', 3500);
INSERT INTO `orvos` (`orvos_id`, `szakterulet_id`, `nev`, `telefon`, `oradij`) VALUES (15, 1, 'Dr. Csala Adrián', '(20) 297-65-99', 8000);
INSERT INTO `orvos` (`orvos_id`, `szakterulet_id`, `nev`, `telefon`, `oradij`) VALUES (16, 8, 'Dr. Latorczai Etelka', '(20) 890-84-94', 7500);
INSERT INTO `orvos` (`orvos_id`, `szakterulet_id`, `nev`, `telefon`, `oradij`) VALUES (17, 9, 'Dr. Csiszér Buda', '(70) 540-78-48', 7000);
INSERT INTO `orvos` (`orvos_id`, `szakterulet_id`, `nev`, `telefon`, `oradij`) VALUES (18, 7, 'Dr. Varga Gergely', '(20) 578-25-26', 7000);
INSERT INTO `orvos` (`orvos_id`, `szakterulet_id`, `nev`, `telefon`, `oradij`) VALUES (19, 7, 'Dr. Nagy Rita', '(70) 553-91-27', 7500);
INSERT INTO `orvos` (`orvos_id`, `szakterulet_id`, `nev`, `telefon`, `oradij`) VALUES (20, 8, 'Dr. Balogh Linda', '(20) 282-27-80', 6500);

CREATE TABLE IF NOT EXISTS `paciens`(
	`paciens_id` int(11) NOT NULL AUTO_INCREMENT,
	`nev` varchar(28) CHARACTER SET utf8 NOT NULL,
	`telefon` varchar(21) CHARACTER SET utf8 NOT NULL,
	`szuletett` date NOT NULL,
 PRIMARY KEY (`paciens_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci AUTO_INCREMENT=37;

INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (1, 'Kovács Mariann', '(20) 674-21-94', CAST('1973-03-11' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (2, 'Molnár Lehel', '(20) 379-56-48', CAST('1973-04-05' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (3, 'Fazekas Gergely', '(30) 581-42-27', CAST('1973-04-18' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (4, 'Kányádi Bálint', '(20) 747-43-12', CAST('1973-04-20' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (5, 'Zsolnai György', '(70) 162-13-24', CAST('1973-04-22' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (6, 'Lukács András', '(20) 532-29-17', CAST('1973-04-24' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (7, 'Koczka Klaudia', '(30) 189-40-52', CAST('1973-05-20' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (8, 'Solymos Judit', '(30) 152-59-41', CAST('1973-06-17' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (9, 'Herczeg Lívia', '(70) 217-91-46', CAST('1973-06-27' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (10, 'Nagy Edina', '(30) 456-53-20', CAST('1973-07-07' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (11, 'Szabó Rita', '(20) 498-37-17', CAST('1973-07-12' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (12, 'Andrási Mariann', '(70) 610-74-27', CAST('1973-07-17' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (13, 'Veres Bence', '(30) 930-53-31', CAST('1973-07-18' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (14, 'Guttmann László', '(30) 169-37-71', CAST('1973-08-07' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (15, 'Kabai Edina', '(30) 528-46-11', CAST('1973-08-12' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (16, 'Magyar Lívia', '(30) 809-96-36', CAST('1973-08-19' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (17, 'Vörös Olga', '(30) 305-96-66', CAST('1973-08-20' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (18, 'Kovács Zsanett', '(20) 276-87-24', CAST('1973-09-12' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (19, 'Baranyai Eleonóra', '(70) 673-32-73', CAST('1973-09-20' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (20, 'Verpeléti Gabriella', '(20) 553-49-74', CAST('1974-03-20' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (21, 'Kalló Miklós', '(70) 749-54-72', CAST('1974-04-21' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (22, 'Braun Roland', '(30) 378-86-32', CAST('1974-05-15' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (23, 'Jászai Marietta', '(20) 978-75-34', CAST('1974-05-24' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (24, 'Csiszér Etelka', '(20) 578-85-91', CAST('1974-07-22' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (25, 'Kiss Kitty', '(20) 130-62-47', CAST('1974-07-24' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (26, 'Zsiday Tímea', '(20) 701-29-73', CAST('1974-07-26' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (27, 'Fekete Marietta', '(20) 399-10-19', CAST('1974-07-28' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (28, 'Zoltai Roland', '(70) 887-87-97', CAST('1974-08-16' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (29, 'Vörös Etelka', '(30) 807-96-92', CAST('1974-09-02' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (30, 'Verpeléti Fanny', '(30) 180-60-52', CAST('1974-09-03' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (31, 'Kaleczky Lehel', '(20) 816-55-74', CAST('1975-03-01' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (32, 'Zsiday Zita', '(30) 964-36-45', CAST('1975-03-24' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (33, 'Turai Dávid', '(20) 295-87-25', CAST('1975-04-03' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (34, 'Baranyai Ilona', '(20) 705-67-95', CAST('1975-04-10' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (35, 'Molnár István', '(30) 432-43-49', CAST('1975-04-26' AS Date));
INSERT INTO `paciens` (`paciens_id`, `nev`, `telefon`, `szuletett`) VALUES (36, 'Hegyi Dénes', '(20) 105-46-82', CAST('1975-05-04' AS Date));

CREATE TABLE IF NOT EXISTS `szakterulet`(
	`szakterulet_id` int(11) NOT NULL AUTO_INCREMENT,
	`nev` varchar(21) CHARACTER SET utf8 NOT NULL,
 PRIMARY KEY (`szakterulet_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci AUTO_INCREMENT=11;

INSERT INTO `szakterulet` (`szakterulet_id`, `nev`) VALUES (1, 'belgyógyász');
INSERT INTO `szakterulet` (`szakterulet_id`, `nev`) VALUES (2, 'fül-orr-gégész');
INSERT INTO `szakterulet` (`szakterulet_id`, `nev`) VALUES (3, 'bőrgyógyász');
INSERT INTO `szakterulet` (`szakterulet_id`, `nev`) VALUES (4, 'szemész');
INSERT INTO `szakterulet` (`szakterulet_id`, `nev`) VALUES (5, 'pszichiáter');
INSERT INTO `szakterulet` (`szakterulet_id`, `nev`) VALUES (6, 'addiktológus');
INSERT INTO `szakterulet` (`szakterulet_id`, `nev`) VALUES (7, 'dietetikus');
INSERT INTO `szakterulet` (`szakterulet_id`, `nev`) VALUES (8, 'nőgyógyász');
INSERT INTO `szakterulet` (`szakterulet_id`, `nev`) VALUES (9, 'gyógytornász');
INSERT INTO `szakterulet` (`szakterulet_id`, `nev`) VALUES (10, 'sebész');

ALTER TABLE `orvos`
ADD CONSTRAINT `orvos_szakterulet_id_fk` FOREIGN KEY (`szakterulet_id`) REFERENCES `szakterulet`(`szakterulet_id`);

ALTER TABLE `kezeles`
ADD CONSTRAINT `kezeles_orvos_id_fk` FOREIGN KEY (`orvos_id`) REFERENCES `orvos`(`orvos_id`),
ADD CONSTRAINT `kezeles_paciens_id_fk` FOREIGN KEY (`paciens_id`) REFERENCES `paciens`(`paciens_id`);
