DROP DATABASE IF EXISTS `tanciskola`;
CREATE DATABASE IF NOT EXISTS `tanciskola`;

USE `tanciskola`;

CREATE TABLE IF NOT EXISTS `orarend`(
	`orarend_id` int(11) NOT NULL AUTO_INCREMENT,
	`nap` varchar(13) CHARACTER SET utf8 NOT NULL,
	`kezdo_idopont` varchar(7) CHARACTER SET utf8 NOT NULL,
	`hossz` int(11) NOT NULL,
	`tanc` int(11) NOT NULL,
	`szint` int(11) NOT NULL,
	`tanar1` int(11) NOT NULL,
	`tanar2` int(11) DEFAULT NULL,
	`terem` int(11) NOT NULL,
	`letszam` int(11) NOT NULL,
  PRIMARY KEY (`orarend_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci AUTO_INCREMENT=72;

INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (1, 'hétfő', '16:00', 90, 1, 1, 1, 5, 1, 14);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (2, 'hétfő', '18:00', 60, 1, 1, 1, 5, 1, 10);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (3, 'szerda', '16:00', 90, 1, 1, 1, 5, 1, 18);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (4, 'szerda', '18:00', 60, 1, 1, 1, 5, 1, 12);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (5, 'péntek', '16:00', 90, 1, 1, 1, 5, 1, 20);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (6, 'péntek', '18:00', 60, 1, 1, 1, 5, 1, 12);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (7, 'hétfő', '16:00', 90, 1, 2, 2, 9, 2, 20);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (8, 'hétfő', '18:00', 60, 1, 2, 2, 9, 2, 12);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (9, 'szerda', '16:00', 90, 1, 2, 2, 9, 2, 20);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (10, 'szerda', '18:00', 60, 1, 2, 2, 9, 2, 12);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (11, 'péntek', '16:00', 90, 1, 2, 2, 9, 2, 16);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (12, 'péntek', '18:00', 60, 1, 2, 2, 9, 2, 10);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (13, 'hétfő', '18:00', 90, 1, 4, 3, 6, 3, 6);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (14, 'kedd', '18:00', 90, 1, 3, 3, 6, 3, 8);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (15, 'szerda', '18:00', 90, 1, 4, 3, 6, 3, 6);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (16, 'csütörtök', '18:00', 90, 1, 3, 3, 6, 3, 8);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (17, 'péntek', '18:00', 90, 1, 4, 3, 6, 3, 6);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (18, 'hétfő', '20:00', 90, 1, 6, 3, 6, 3, 2);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (19, 'kedd', '20:00', 90, 1, 5, 3, 6, 3, 2);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (20, 'szerda', '20:00', 90, 1, 6, 3, 6, 3, 2);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (21, 'csütörtök', '20:00', 90, 1, 5, 3, 6, 3, 2);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (22, 'péntek', '20:00', 90, 1, 6, 3, 6, 3, 2);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (23, 'hétfő', '15:00', 60, 1, 7, 7, 13, 3, 20);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (24, 'szerda', '15:00', 60, 1, 7, 7, 13, 3, 20);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (25, 'péntek', '19:30', 90, 1, 8, 20, 18, 1, 20);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (26, 'péntek', '19:30', 90, 1, 8, 20, 18, 1, 20);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (27, 'szombat', '16:00', 90, 1, 8, 20, 18, 3, 20);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (28, 'szombat', '18:00', 90, 5, 8, 20, 18, 3, 20);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (29, 'szombat', '20:00', 90, 4, 8, 14, 12, 3, 20);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (30, 'kedd', '16:00', 90, 2, 1, 4, 10, 1, 18);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (31, 'csütörtök', '16:00', 90, 2, 1, 4, 10, 1, 18);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (32, 'kedd', '18:00', 90, 2, 2, 4, 10, 1, 18);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (33, 'csütörtök', '18:00', 90, 2, 2, 4, 10, 1, 18);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (34, 'szombat', '15:00', 90, 2, 1, 14, 12, 1, 18);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (35, 'szombat', '17:00', 90, 2, 2, 14, 12, 1, 18);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (36, 'kedd', '15:00', 60, 3, 1, 3, 6, 2, 20);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (37, 'csütörtök', '15:00', 60, 3, 1, 3, 6, 2, 20);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (38, 'kedd', '16:30', 60, 3, 2, 3, 6, 2, 18);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (39, 'csütörtök', '16:30', 60, 3, 2, 3, 6, 2, 18);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (40, 'hétfő', '16:30', 60, 6, 1, 7, 13, 3, 18);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (41, 'szerda', '16:30', 60, 6, 1, 7, 13, 3, 18);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (42, 'hétfő', '19:30', 90, 6, 2, 16, 11, 1, 16);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (43, 'szerda', '19:30', 90, 6, 2, 16, 11, 1, 16);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (44, 'kedd', '20:00', 60, 6, 1, 16, 11, 1, 18);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (45, 'csütörtök', '20:00', 60, 6, 1, 16, 11, 1, 18);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (46, 'hétfő', '19:30', 60, 9, 1, 17, 15, 2, 18);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (47, 'szerda', '19:30', 60, 9, 1, 17, 15, 2, 18);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (48, 'péntek', '19:30', 60, 9, 1, 17, 15, 2, 18);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (49, 'kedd', '18:00', 90, 9, 2, 17, 15, 2, 16);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (50, 'csütörtök', '18:00', 90, 9, 2, 17, 15, 2, 16);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `terem`, `letszam`) VALUES (51, 'kedd', '20:00', 90, 3, 2, 20, 2, 25);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `terem`, `letszam`) VALUES (52, 'csütörtök', '20:00', 90, 3, 2, 20, 2, 25);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `terem`, `letszam`) VALUES (53, 'kedd', '15:00', 60, 3, 1, 20, 3, 25);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `terem`, `letszam`) VALUES (54, 'csütörtök', '15:00', 60, 3, 1, 20, 3, 25);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `terem`, `letszam`) VALUES (55, 'kedd', '16:30', 60, 3, 2, 20, 3, 25);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `terem`, `letszam`) VALUES (56, 'csütörtök', '16:30', 60, 3, 2, 20, 3, 25);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (57, 'péntek', '15:00', 60, 4, 1, 14, 12, 3, 18);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `tanar2`, `terem`, `letszam`) VALUES (58, 'péntek', '16:30', 60, 4, 2, 14, 12, 3, 18);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `terem`, `letszam`) VALUES (59, 'hétfő', '15:00', 60, 7, 1, 19, 4, 20);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `terem`, `letszam`) VALUES (60, 'szerda', '15:00', 60, 7, 1, 19, 4, 20);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `terem`, `letszam`) VALUES (61, 'kedd', '15:00', 60, 8, 1, 8, 4, 16);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `terem`, `letszam`) VALUES (62, 'csütörtök', '15:00', 60, 8, 1, 8, 4, 16);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `terem`, `letszam`) VALUES (63, 'kedd', '16:30', 90, 7, 2, 19, 4, 18);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `terem`, `letszam`) VALUES (64, 'csütörtök', '16:30', 90, 7, 2, 19, 4, 18);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `terem`, `letszam`) VALUES (65, 'hétfő', '18:00', 90, 8, 2, 8, 4, 16);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `terem`, `letszam`) VALUES (66, 'szerda', '18:00', 90, 8, 2, 8, 4, 16);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `terem`, `letszam`) VALUES (67, 'hétfő', '16:30', 60, 10, 1, 8, 4, 16);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `terem`, `letszam`) VALUES (68, 'szerda', '16:30', 60, 10, 1, 8, 4, 16);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `terem`, `letszam`) VALUES (69, 'kedd', '18:30', 90, 10, 2, 7, 4, 16);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `terem`, `letszam`) VALUES (70, 'csütörtök', '18:30', 90, 10, 2, 7, 4, 16);
INSERT INTO `orarend` (`orarend_id`, `nap`, `kezdo_idopont`, `hossz`, `tanc`, `szint`, `tanar1`, `terem`, `letszam`) VALUES (71, 'péntek', '16:30', 90, 10, 2, 7, 4, 16);

CREATE TABLE IF NOT EXISTS `szint`(
	`szint_id` int(11) NOT NULL AUTO_INCREMENT,
	`kategoria` varchar(15) CHARACTER SET utf8 NOT NULL,
	`ar` int(11) NOT NULL,
  PRIMARY KEY (`szint_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci AUTO_INCREMENT=9;

INSERT INTO `szint` (`szint_id`, `kategoria`, `ar`) VALUES (1, 'kezdő', 4000);
INSERT INTO `szint` (`szint_id`, `kategoria`, `ar`) VALUES (2, 'haladó', 4000);
INSERT INTO `szint` (`szint_id`, `kategoria`, `ar`) VALUES (3, 'bronz', 6000);
INSERT INTO `szint` (`szint_id`, `kategoria`, `ar`) VALUES (4, 'ezüst', 7000);
INSERT INTO `szint` (`szint_id`, `kategoria`, `ar`) VALUES (5, 'arany', 9000);
INSERT INTO `szint` (`szint_id`, `kategoria`, `ar`) VALUES (6, 'aranysztár', 10000);
INSERT INTO `szint` (`szint_id`, `kategoria`, `ar`) VALUES (7, 'senior', 3000);
INSERT INTO `szint` (`szint_id`, `kategoria`, `ar`) VALUES (8, 'hobby', 2500);

CREATE TABLE IF NOT EXISTS `tanar`(
	`tanar_id` int(11) NOT NULL AUTO_INCREMENT,
	`nev` varchar(25) CHARACTER SET utf8 NOT NULL,
	`email` varchar(37) CHARACTER SET utf8 NOT NULL,
  PRIMARY KEY (`tanar_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci AUTO_INCREMENT=21;

INSERT INTO `tanar` (`tanar_id`, `nev`, `email`) VALUES (1, 'Jászai Szimonetta', 'jaszaisz@freemail.hu');
INSERT INTO `tanar` (`tanar_id`, `nev`, `email`) VALUES (2, 'Szűcs Helga', 'szucs.helga@gmail.com');
INSERT INTO `tanar` (`tanar_id`, `nev`, `email`) VALUES (3, 'Keller Nikolett', 'keller.nikolett@gmail.com');
INSERT INTO `tanar` (`tanar_id`, `nev`, `email`) VALUES (4, 'Balogh Linda', 'baloghl@freemail.hu');
INSERT INTO `tanar` (`tanar_id`, `nev`, `email`) VALUES (5, 'Tóth Gábor', 'toth.gabor@gmail.com');
INSERT INTO `tanar` (`tanar_id`, `nev`, `email`) VALUES (6, 'Csiszár Bálint', 'csiszar.balint@gmail.com');
INSERT INTO `tanar` (`tanar_id`, `nev`, `email`) VALUES (7, 'Balogh Edina', 'balogh.edina@ttt.hu');
INSERT INTO `tanar` (`tanar_id`, `nev`, `email`) VALUES (8, 'Nagy Rita', 'nagy.rita@ttt.hu');
INSERT INTO `tanar` (`tanar_id`, `nev`, `email`) VALUES (9, 'Balogh Bálint', 'balogh.balint@ttt.hu');
INSERT INTO `tanar` (`tanar_id`, `nev`, `email`) VALUES (10, 'Lukács Viktor', 'lukacs.viktor@ttt.hu');
INSERT INTO `tanar` (`tanar_id`, `nev`, `email`) VALUES (11, 'Zoltán Róbert', 'zoltan.robert@ttt.hu');
INSERT INTO `tanar` (`tanar_id`, `nev`, `email`) VALUES (12, 'Mozsár Gergő', 'mozsar.gergo@gmail.com');
INSERT INTO `tanar` (`tanar_id`, `nev`, `email`) VALUES (13, 'Varga András', 'varga.andras@ttt.hu');
INSERT INTO `tanar` (`tanar_id`, `nev`, `email`) VALUES (14, 'Tóth Mariann', 'toth.mariann@ttt.hu');
INSERT INTO `tanar` (`tanar_id`, `nev`, `email`) VALUES (15, 'Bognár Adrián', 'bognar.adrian@ttt.hu');
INSERT INTO `tanar` (`tanar_id`, `nev`, `email`) VALUES (16, 'Fekete Vera', 'fekete.vera@ttt.hu');
INSERT INTO `tanar` (`tanar_id`, `nev`, `email`) VALUES (17, 'Fehér Eszter', 'feher.eszter@ttt.hu');
INSERT INTO `tanar` (`tanar_id`, `nev`, `email`) VALUES (18, 'Szőke Zoltán', 'szoke.zoltan@gmail.com');
INSERT INTO `tanar` (`tanar_id`, `nev`, `email`) VALUES (19, 'Szabó Bence', 'szabo.bence@gmail.com');
INSERT INTO `tanar` (`tanar_id`, `nev`, `email`) VALUES (20, 'Major Andrea', 'major.andrea@gmail.com');

CREATE TABLE IF NOT EXISTS `tanc`(
	`tanc_id` int(11) NOT NULL AUTO_INCREMENT,
	`tanc_tipus` varchar(24) CHARACTER SET utf8 NOT NULL,
  PRIMARY KEY (`tanc_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci AUTO_INCREMENT=11;

INSERT INTO `tanc` (`tanc_id`, `tanc_tipus`) VALUES (1, 'társastánc');
INSERT INTO `tanc` (`tanc_id`, `tanc_tipus`) VALUES (2, 'salsa');
INSERT INTO `tanc` (`tanc_id`, `tanc_tipus`) VALUES (3, 'zumba');
INSERT INTO `tanc` (`tanc_id`, `tanc_tipus`) VALUES (4, 'bachata');
INSERT INTO `tanc` (`tanc_id`, `tanc_tipus`) VALUES (5, 'rocky');
INSERT INTO `tanc` (`tanc_id`, `tanc_tipus`) VALUES (6, 'west coast swing');
INSERT INTO `tanc` (`tanc_id`, `tanc_tipus`) VALUES (7, 'hip hop');
INSERT INTO `tanc` (`tanc_id`, `tanc_tipus`) VALUES (8, 'hastánc');
INSERT INTO `tanc` (`tanc_id`, `tanc_tipus`) VALUES (9, 'szamba');
INSERT INTO `tanc` (`tanc_id`, `tanc_tipus`) VALUES (10, 'jazztánc');

ALTER TABLE `orarend`
ADD CONSTRAINT `fk_orarend_tanc_id` FOREIGN KEY (`tanc`) REFERENCES `tanc`(`tanc_id`),
ADD CONSTRAINT `fk_orarend_szint_id` FOREIGN KEY (`szint`) REFERENCES `szint`(`szint_id`),
ADD CONSTRAINT `fk_orarend_tanar1_id` FOREIGN KEY (`tanar1`) REFERENCES `tanar`(`tanar_id`),
ADD CONSTRAINT `fk_orarend_tanar2_id` FOREIGN KEY (`tanar2`) REFERENCES `tanar`(`tanar_id`);
