DROP DATABASE IF EXISTS `karbantartas`;
CREATE DATABASE IF NOT EXISTS `karbantartas`;

USE `karbantartas`;

CREATE TABLE IF NOT EXISTS `karbantartasok`(
	`karbantartas_id` int(11) NOT NULL AUTO_INCREMENT,
	`szerelo_id` int(11) NOT NULL,
	`megrendelo_id` int(11) NOT NULL,
	`datum` date NOT NULL,
	`javido` int(11) NOT NULL,
 PRIMARY KEY (`karbantartas_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci AUTO_INCREMENT=43;

INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (1, 6, 8, CAST('2022-01-02' AS Date), 3);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (2, 9, 3, CAST('2022-01-02' AS Date), 5);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (3, 8, 4, CAST('2022-01-08' AS Date), 4);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (4, 10, 9, CAST('2022-01-09' AS Date), 6);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (5, 5, 1, CAST('2022-01-13' AS Date), 6);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (6, 10, 5, CAST('2022-01-13' AS Date), 2);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (7, 7, 8, CAST('2022-01-13' AS Date), 3);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (8, 2, 9, CAST('2022-01-15' AS Date), 3);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (9, 10, 7, CAST('2022-01-15' AS Date), 6);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (10, 2, 2, CAST('2022-01-16' AS Date), 3);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (11, 9, 6, CAST('2022-01-18' AS Date), 3);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (12, 5, 5, CAST('2022-01-20' AS Date), 2);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (13, 9, 6, CAST('2022-01-25' AS Date), 5);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (14, 6, 7, CAST('2022-01-26' AS Date), 4);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (15, 8, 8, CAST('2022-02-05' AS Date), 3);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (16, 10, 4, CAST('2022-02-11' AS Date), 5);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (17, 8, 4, CAST('2022-02-12' AS Date), 2);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (18, 4, 8, CAST('2022-02-15' AS Date), 6);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (19, 1, 1, CAST('2022-02-19' AS Date), 2);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (20, 6, 1, CAST('2022-02-23' AS Date), 4);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (21, 3, 2, CAST('2022-02-25' AS Date), 4);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (22, 7, 3, CAST('2022-02-27' AS Date), 4);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (23, 3, 6, CAST('2022-03-02' AS Date), 5);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (24, 2, 2, CAST('2022-03-08' AS Date), 6);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (25, 2, 6, CAST('2022-03-14' AS Date), 2);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (26, 2, 7, CAST('2022-03-15' AS Date), 4);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (27, 8, 3, CAST('2022-03-17' AS Date), 4);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (28, 7, 5, CAST('2022-03-18' AS Date), 4);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (29, 8, 3, CAST('2022-03-21' AS Date), 2);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (30, 10, 4, CAST('2022-03-24' AS Date), 4);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (31, 8, 6, CAST('2022-03-27' AS Date), 5);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (32, 2, 7, CAST('2022-04-07' AS Date), 3);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (33, 4, 8, CAST('2022-04-11' AS Date), 3);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (34, 8, 4, CAST('2022-04-16' AS Date), 6);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (35, 2, 9, CAST('2022-04-18' AS Date), 6);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (36, 1, 5, CAST('2022-04-26' AS Date), 4);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (37, 5, 2, CAST('2022-04-27' AS Date), 4);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (38, 2, 1, CAST('2022-04-27' AS Date), 2);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (39, 4, 9, CAST('2022-04-28' AS Date), 6);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (40, 1, 3, CAST('2022-05-05' AS Date), 5);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (41, 5, 5, CAST('2022-05-09' AS Date), 4);
INSERT INTO `karbantartasok` (`karbantartas_id`, `szerelo_id`, `megrendelo_id`, `datum`, `javido`) VALUES (42, 5, 3, CAST('2022-05-09' AS Date), 3);

CREATE TABLE IF NOT EXISTS `megrendelok`(
	`megrendelo_id` int(11) NOT NULL AUTO_INCREMENT,
	`nev` varchar(27) CHARACTER SET utf8 NOT NULL,
	`cim` varchar(42) CHARACTER SET utf8 NOT NULL,
	`kedvezmeny` int(11) NOT NULL,
	`telefon` varchar(21) CHARACTER SET utf8 NOT NULL,
 PRIMARY KEY (`megrendelo_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci AUTO_INCREMENT=11;

INSERT INTO `megrendelok` (`megrendelo_id`, `nev`, `cim`, `kedvezmeny`, `telefon`) VALUES (1, 'Verpeléti Kitty', 'Jászberény Miklos u 5', 5, '(70) 301-94-97');
INSERT INTO `megrendelok` (`megrendelo_id`, `nev`, `cim`, `kedvezmeny`, `telefon`) VALUES (2, 'Lukács Lilla', 'Jászapáti Dió köz 1', 3, '(70) 536-80-44');
INSERT INTO `megrendelok` (`megrendelo_id`, `nev`, `cim`, `kedvezmeny`, `telefon`) VALUES (3, 'Solymos Sámuel', 'Jászberény Petőfi út 33', 10, '(70) 857-69-49');
INSERT INTO `megrendelok` (`megrendelo_id`, `nev`, `cim`, `kedvezmeny`, `telefon`) VALUES (4, 'Szabó András', 'Jászol Széna tér 3', 8, '(70) 393-54-66');
INSERT INTO `megrendelok` (`megrendelo_id`, `nev`, `cim`, `kedvezmeny`, `telefon`) VALUES (5, 'Braun Zsanett', 'Budapest Sehol nincs u. 42', 7, '(70) 111-62-88');
INSERT INTO `megrendelok` (`megrendelo_id`, `nev`, `cim`, `kedvezmeny`, `telefon`) VALUES (6, 'Cseszneki Julianna', 'Orosháza Kossuth tér 4', 5, '(20) 513-89-86');
INSERT INTO `megrendelok` (`megrendelo_id`, `nev`, `cim`, `kedvezmeny`, `telefon`) VALUES (7, 'Balogh Adrián', 'Gyöngyös Tigris köz 2', 2, '(20) 169-73-57');
INSERT INTO `megrendelok` (`megrendelo_id`, `nev`, `cim`, `kedvezmeny`, `telefon`) VALUES (8, 'Halmos Bálint', 'Hatvan Ötvenkettesek tere 40', 4, '(70) 802-81-31');
INSERT INTO `megrendelok` (`megrendelo_id`, `nev`, `cim`, `kedvezmeny`, `telefon`) VALUES (9, 'Jászai Linda', 'Jászapáti János u. 22.', 4, '(20) 581-38-50');
INSERT INTO `megrendelok` (`megrendelo_id`, `nev`, `cim`, `kedvezmeny`, `telefon`) VALUES (10, 'Hertelendi Mariann', 'Budapest Oroszlán tér 2', 2, '(30) 678-93-23');

CREATE TABLE IF NOT EXISTS `szakteruletek`(
	`szakterulet_id` int(11) NOT NULL AUTO_INCREMENT,
	`megnevezes` varchar(21) CHARACTER SET utf8 NOT NULL,
 PRIMARY KEY (`szakterulet_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci AUTO_INCREMENT=5;

INSERT INTO `szakteruletek` (`szakterulet_id`, `megnevezes`) VALUES (1, 'Vízszerelő');
INSERT INTO `szakteruletek` (`szakterulet_id`, `megnevezes`) VALUES (2, 'Gázszerelő');
INSERT INTO `szakteruletek` (`szakterulet_id`, `megnevezes`) VALUES (3, 'Villanyszerelő');
INSERT INTO `szakteruletek` (`szakterulet_id`, `megnevezes`) VALUES (4, 'Mindenes');

CREATE TABLE IF NOT EXISTS `szerelok`(
	`szerelo_id` int(11) NOT NULL AUTO_INCREMENT,
	`szakterulet_id` int(11) NOT NULL,
	`nev` varchar(22) CHARACTER SET utf8 NOT NULL,
	`cim` varchar(51) CHARACTER SET utf8 NOT NULL,
	`telefon` varchar(21) CHARACTER SET utf8 NOT NULL,
	`oradij` int(11) NOT NULL,
 PRIMARY KEY (`szerelo_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci AUTO_INCREMENT=11;

INSERT INTO `szerelok` (`szerelo_id`, `szakterulet_id`, `nev`, `cim`, `telefon`, `oradij`) VALUES (1, 1, 'Keller János', 'Pécs, Ceglédi utca 88.', '(30) 834-47-72', 5000);
INSERT INTO `szerelok` (`szerelo_id`, `szakterulet_id`, `nev`, `cim`, `telefon`, `oradij`) VALUES (2, 2, 'Megyeri György', 'Tapolca, Virág utca 80.', '(20) 716-19-54', 6000);
INSERT INTO `szerelok` (`szerelo_id`, `szakterulet_id`, `nev`, `cim`, `telefon`, `oradij`) VALUES (3, 3, 'Eszes Lehel', 'Székesfehérvár, Mikszáth utca 37.', '(70) 599-12-77', 4500);
INSERT INTO `szerelok` (`szerelo_id`, `szakterulet_id`, `nev`, `cim`, `telefon`, `oradij`) VALUES (4, 4, 'Csikós László', 'Budapest, Mikszáth utca 39.', '(20) 825-55-55', 5500);
INSERT INTO `szerelok` (`szerelo_id`, `szakterulet_id`, `nev`, `cim`, `telefon`, `oradij`) VALUES (5, 4, 'Verpeléti Bence', 'Pécs, Arany János utca 86.', '(70) 611-94-92', 7000);
INSERT INTO `szerelok` (`szerelo_id`, `szakterulet_id`, `nev`, `cim`, `telefon`, `oradij`) VALUES (6, 3, 'Józsa Sándor', 'Fót, Kossuth utca 47.', '(30) 394-33-50', 6500);
INSERT INTO `szerelok` (`szerelo_id`, `szakterulet_id`, `nev`, `cim`, `telefon`, `oradij`) VALUES (7, 4, 'Lukács Pál', 'Balatonfüred, Arany János utca 95.', '(20) 302-85-17', 5000);
INSERT INTO `szerelok` (`szerelo_id`, `szakterulet_id`, `nev`, `cim`, `telefon`, `oradij`) VALUES (8, 1, 'Madarász Bálint', 'Pécs, Petőfi utca 30.', '(20) 256-60-58', 5500);
INSERT INTO `szerelok` (`szerelo_id`, `szakterulet_id`, `nev`, `cim`, `telefon`, `oradij`) VALUES (9, 3, 'Szabó Mátyás', 'Székesfehérvár, Csillag utca 86.', '(70) 115-20-98', 4000);
INSERT INTO `szerelok` (`szerelo_id`, `szakterulet_id`, `nev`, `cim`, `telefon`, `oradij`) VALUES (10, 2, 'Kalányos Lajos', 'Szeged, Kossuth utca 22.', '(20) 696-11-95', 4500);

ALTER TABLE `karbantartasok`
ADD CONSTRAINT `karbantartasok_megrendelo_id_fk` FOREIGN KEY (`megrendelo_id`) REFERENCES `megrendelok`(`megrendelo_id`),
ADD CONSTRAINT `karbantartasok_szerelo_id_fk` FOREIGN KEY (`szerelo_id`) REFERENCES `szerelok`(`szerelo_id`);

ALTER TABLE `szerelok`
ADD CONSTRAINT `szerelok_szakterulet_id_fk` FOREIGN KEY (`szakterulet_id`) REFERENCES `szakteruletek`(`szakterulet_id`);
