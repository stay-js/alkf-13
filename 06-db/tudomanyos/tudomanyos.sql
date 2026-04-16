DROP DATABASE IF EXISTS `tudomanyos`;
CREATE DATABASE IF NOT EXISTS `tudomanyos`;

USE `tudomanyos`;

CREATE TABLE IF NOT EXISTS `eloadok`(
	`eloado_id` int(11) NOT NULL AUTO_INCREMENT,
	`nev` varchar(25) CHARACTER SET utf8 NOT NULL,
	`email` varchar(37) CHARACTER SET utf8 NOT NULL,
 PRIMARY KEY (`eloado_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci AUTO_INCREMENT=121;

INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (1, 'Illés Eszter', 'illes.eszter@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (2, 'Szabó Enikő', 'szabo.eniko@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (3, 'Simon László', 'simon.laszlo@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (4, 'Lakatos Ferenc', 'lakatos.ferenc@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (5, 'Veres Dóra', 'veres.dora@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (6, 'Török Enikő', 'torok.eniko@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (7, 'Sipos Dávid', 'sipos.david@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (8, 'Szekeres Vera', 'szekeres.vera@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (9, 'Tóth Bálint', 'toth.balint@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (10, 'Varga Judit', 'varga.judit@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (11, 'Lakatos Benedek', 'lakatos.benedek@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (12, 'Kocsis Bálint', 'kocsis.balint@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (13, 'Somogyi János', 'somogyi.janos@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (14, 'Fodor Katalin', 'fodor.katalin@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (15, 'Szűcs Krisztián', 'szucs.krisztian@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (16, 'Bálint Kata', 'balint.kata@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (17, 'Boros Réka', 'boros.reka@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (18, 'Simon Anna', 'simon.anna@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (19, 'Márton Hanna', 'marton.hanna@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (20, 'Szűcs Vera', 'szucs.vera@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (21, 'Gál Márk', 'gal.mark@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (22, 'Farkas Judit', 'farkas.judit@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (23, 'Márton Nikolett', 'marton.nikolett@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (24, 'Kiss Dávid', 'kiss.david@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (25, 'Hegedűs Dóra', 'hegedus.dora@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (26, 'Pintér Noémi', 'pinter.noemi@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (27, 'Kocsis Levente', 'kocsis.levente@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (28, 'Gera Bence', 'gera.bence@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (29, 'Barna Ádám', 'barna.adam@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (30, 'Sipos Eszter', 'sipos.eszter@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (31, 'Hegedűs Dávid', 'hegedus.david@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (32, 'Somogyi Máté', 'somogyi.mate@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (33, 'Illés Gergely', 'illes.gergely@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (34, 'Bognár Viktor', 'bognar.viktor@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (35, 'Takács Zsófia', 'takacs.zsofia@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (36, 'Horváth Bence', 'horvath.bence@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (37, 'Fehér Kata', 'feher.kata@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (38, 'Balla Máté', 'balla.mate@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (39, 'Varga Kata', 'varga.kata@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (40, 'Kiss Rita', 'kiss.rita@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (41, 'Simon Ádám', 'simon.adam@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (42, 'Illés Péter', 'illes.peter@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (43, 'Balogh Péter', 'balogh.peter@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (44, 'Pintér Judit', 'pinter.judit@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (45, 'Fehér Márk', 'feher.mark@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (46, 'Szűcs Gyöngyi', 'szucs.gyongyi@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (47, 'Antal Csaba', 'antal.csaba@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (48, 'Kocsis Kornél', 'kocsis.kornel@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (49, 'Balogh Krisztián', 'balogh.krisztian@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (50, 'Barna László', 'barna.laszlo@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (51, 'Balogh Ádám', 'balogh.adam@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (52, 'Hegedűs Márk', 'hegedus.mark@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (53, 'Illés Norbert', 'illes.norbert@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (54, 'Somogyi Kata', 'somogyi.kata@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (55, 'Török Miklós', 'torok.miklos@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (56, 'Balla Renáta', 'balla.renata@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (57, 'Nagy Kata', 'nagy.kata@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (58, 'Tóth Miklós', 'toth.miklos@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (59, 'Lengyel Márk', 'lengyel.mark@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (60, 'Horváth Judit', 'horvath.judit@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (61, 'Magyar Zsófia', 'magyar.zsofia@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (62, 'Szalai Judit', 'szalai.judit@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (63, 'Antal Éva', 'antal.eva@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (64, 'Lengyel Katalin', 'lengyel.katalin@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (65, 'Váradi Gábor', 'varadi.gabor@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (66, 'Oláh Ferenc', 'olah.ferenc@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (67, 'Mészáros Enikő', 'meszaros.eniko@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (68, 'Somogyi Krisztián', 'somogyi.krisztian@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (69, 'Oláh Enikő', 'olah.eniko@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (70, 'Szekeres Szilvia', 'szekeres.szilvia@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (71, 'Bognár Kata', 'bognar.kata@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (72, 'Németh Benedek', 'nemeth.benedek@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (73, 'Vincze Dávid', 'vincze.david@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (74, 'Márton Boglárka', 'marton.boglarka@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (75, 'Molnár Gábor', 'molnar.gabor@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (76, 'Illés Hanna', 'illes.hanna@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (77, 'Pál Gyöngyi', 'pal.gyongyi@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (78, 'György Sára', 'gyorgy.sara@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (79, 'Horváth Rita', 'horvath.rita@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (80, 'Hegedűs Sára', 'hegedus.sara@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (81, 'Váradi András', 'varadi.andras@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (82, 'Oláh Attila', 'olah.attila@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (83, 'Kovács Gyöngyi', 'kovacs.gyongyi@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (84, 'Barna Eszter', 'barna.eszter@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (85, 'Török Krisztián', 'torok.krisztian@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (86, 'Márton Márk', 'marton.mark@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (87, 'Balla Katalin', 'balla.katalin@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (88, 'Gál Eszter', 'gal.eszter@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (89, 'Rácz Vera', 'racz.vera@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (90, 'Kovács Edina', 'kovacs.edina@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (91, 'Barna Levente', 'barna.levente@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (92, 'Gulyás Adrienn', 'gulyas.adrienn@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (93, 'Papp Benedek', 'papp.benedek@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (94, 'Kiss Kornél', 'kiss.kornel@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (95, 'Fekete Kornél', 'fekete.kornel@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (96, 'Gulyás Sára', 'gulyas.sara@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (97, 'Takács Gábor', 'takacs.gabor@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (98, 'Bognár Adrienn', 'bognar.adrienn@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (99, 'Balla András', 'balla.andras@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (100, 'Kovács Sára', 'kovacs.sara@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (101, 'Szalai Éva', 'szalai.eva@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (102, 'Szabó Eszter', 'szabo.eszter@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (103, 'Bognár Mária', 'bognar.maria@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (104, 'Mészáros Boglárka', 'meszaros.boglarka@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (105, 'Mészáros Viktor', 'meszaros.viktor@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (106, 'Varga Dávid', 'varga.david@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (107, 'Barna Éva', 'barna.eva@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (108, 'Horváth Adrienn', 'horvath.adrienn@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (109, 'Sipos Renáta', 'sipos.renata@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (110, 'Németh Ferenc', 'nemeth.ferenc@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (111, 'Fehér Ágnes', 'feher.agnes@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (112, 'Somogyi Hanna', 'somogyi.hanna@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (113, 'Oláh András', 'olah.andras@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (114, 'Kocsis Vera', 'kocsis.vera@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (115, 'Juhász Krisztián', 'juhasz.krisztian@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (116, 'Márton Edina', 'marton.edina@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (117, 'Szűcs János', 'szucs.janos@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (118, 'Fodor Mária', 'fodor.maria@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (119, 'Lengyel Erika', 'lengyel.erika@konf.hu');
INSERT INTO `eloadok` (`eloado_id`, `nev`, `email`) VALUES (120, 'Antal Péter', 'antal.peter@konf.hu');

CREATE TABLE IF NOT EXISTS `program`(
	`program_id` int(11) NOT NULL AUTO_INCREMENT,
	`datum` varchar(15) CHARACTER SET utf8 NOT NULL,
	`kezdo_idopont` varchar(7) CHARACTER SET utf8 NOT NULL,
	`hossz` int(11) NOT NULL,
	`tema` int(11) NOT NULL,
	`szekcio` int(11) NOT NULL,
	`eloadok1` int(11) NOT NULL,
	`eloadok2` int(11) DEFAULT NULL,
	`terem` int(11) NOT NULL,
	`letszam` int(11) NOT NULL,
 PRIMARY KEY (`program_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci AUTO_INCREMENT=161;

INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (1, '2025.03.20', '17:00', 60, 8, 4, 29, 3, 10, 166);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (2, '2025.06.05', '12:30', 45, 5, 12, 81, 9, 1, 109);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (3, '2025.04.02', '17:00', 45, 18, 11, 63, 17, 12, 171);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (4, '2025.12.02', '16:30', 45, 31, 7, 25, 85, 7, 115);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (5, '2025.07.25', '15:30', 60, 4, 11, 84, 2, 40);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (6, '2025.06.05', '14:00', 45, 16, 4, 25, 3, 133);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (7, '2025.04.09', '13:00', 60, 16, 2, 57, 9, 50);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (8, '2025.03.14', '17:30', 45, 6, 4, 22, 8, 79);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (9, '2025.07.16', '09:30', 45, 25, 1, 50, 101, 8, 98);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (10, '2025.09.10', '17:30', 90, 32, 3, 25, 8, 10, 213);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (11, '2025.09.18', '09:30', 90, 21, 1, 7, 9, 160);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (12, '2025.06.30', '09:30', 90, 6, 3, 9, 11, 85);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (13, '2025.07.02', '10:30', 90, 16, 10, 77, 11, 7, 193);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (14, '2025.03.20', '17:00', 60, 17, 4, 86, 4, 92);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (15, '2025.04.28', '11:00', 90, 42, 5, 59, 2, 27);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (16, '2025.04.18', '10:30', 45, 35, 4, 65, 120, 6, 42);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (17, '2025.07.01', '14:30', 60, 11, 8, 107, 5, 181);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (18, '2025.09.18', '09:00', 90, 36, 5, 120, 3, 92);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (19, '2025.06.30', '10:30', 90, 36, 3, 35, 27, 12, 112);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (20, '2025.11.07', '13:00', 90, 32, 5, 116, 1, 48);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (21, '2025.05.28', '13:00', 45, 1, 6, 99, 34, 3, 214);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (22, '2025.04.29', '17:30', 90, 28, 9, 2, 114, 12, 63);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (23, '2025.03.03', '09:30', 60, 38, 9, 19, 1, 103);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (24, '2025.08.05', '09:30', 60, 14, 11, 32, 6, 168);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (25, '2025.12.04', '11:00', 45, 11, 3, 113, 3, 213);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (26, '2025.04.02', '15:30', 90, 16, 5, 21, 2, 122);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (27, '2025.10.01', '16:30', 45, 13, 8, 45, 4, 82);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (28, '2025.07.15', '12:00', 60, 22, 5, 111, 99, 5, 114);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (29, '2025.03.26', '15:00', 90, 35, 6, 4, 34, 3, 173);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (30, '2025.03.04', '09:30', 45, 39, 7, 45, 6, 136);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (31, '2025.06.23', '17:00', 45, 25, 10, 25, 91, 7, 25);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (32, '2025.11.19', '17:30', 90, 13, 6, 56, 86, 6, 184);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (33, '2025.08.08', '10:30', 90, 20, 9, 40, 6, 128);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (34, '2025.04.08', '17:30', 45, 13, 7, 86, 11, 216);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (35, '2025.03.18', '13:30', 60, 36, 1, 39, 56, 10, 180);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (36, '2025.04.03', '16:00', 60, 29, 11, 28, 12, 68);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (37, '2025.10.27', '13:30', 90, 41, 10, 43, 97, 4, 197);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (38, '2025.04.22', '12:30', 45, 10, 1, 6, 61, 10, 43);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (39, '2025.04.16', '15:30', 90, 37, 4, 92, 8, 127);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (40, '2025.03.10', '11:00', 90, 1, 2, 100, 3, 203);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (41, '2025.06.13', '16:00', 45, 36, 4, 118, 8, 59);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (42, '2025.08.04', '17:00', 90, 39, 6, 97, 10, 209);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (43, '2025.09.23', '15:30', 90, 29, 3, 96, 8, 91);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (44, '2025.08.20', '13:00', 90, 32, 11, 31, 10, 12, 98);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (45, '2025.06.04', '13:00', 60, 21, 9, 11, 30, 7, 202);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (46, '2025.08.18', '12:00', 45, 27, 7, 43, 7, 40);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (47, '2025.03.14', '15:30', 60, 38, 12, 3, 10, 122);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (48, '2025.12.02', '09:00', 60, 20, 7, 110, 7, 162);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (49, '2025.06.19', '12:30', 60, 15, 5, 56, 7, 111);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (50, '2025.07.02', '11:30', 60, 9, 10, 69, 51, 10, 169);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (51, '2025.09.04', '10:00', 90, 28, 3, 111, 1, 91);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (52, '2025.08.21', '14:00', 45, 30, 6, 44, 7, 96);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (53, '2025.05.14', '13:00', 45, 31, 1, 96, 6, 82);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (54, '2025.10.06', '09:30', 45, 16, 4, 108, 20, 4, 57);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (55, '2025.10.16', '10:30', 90, 14, 8, 90, 48, 3, 180);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (56, '2025.09.05', '10:30', 45, 20, 2, 75, 40, 10, 198);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (57, '2025.09.19', '15:00', 90, 13, 2, 76, 11, 87);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (58, '2025.06.23', '13:30', 90, 39, 2, 102, 1, 113);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (59, '2025.03.06', '15:30', 90, 24, 2, 65, 1, 132);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (60, '2025.07.22', '10:30', 60, 24, 11, 115, 12, 64);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (61, '2025.12.02', '11:30', 90, 34, 11, 35, 9, 148);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (62, '2025.10.20', '15:30', 90, 38, 5, 42, 2, 96);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (63, '2025.09.02', '12:30', 60, 37, 10, 86, 1, 151);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (64, '2025.08.05', '11:30', 60, 14, 6, 103, 36, 10, 204);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (65, '2025.11.03', '17:30', 45, 34, 4, 11, 53, 8, 167);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (66, '2025.09.10', '16:30', 90, 32, 8, 102, 38, 4, 128);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (67, '2025.10.16', '13:30', 90, 38, 6, 61, 6, 133);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (68, '2025.10.27', '14:00', 60, 30, 5, 40, 16, 12, 74);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (69, '2025.10.01', '10:30', 90, 35, 12, 24, 95, 8, 95);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (70, '2025.08.22', '17:00', 90, 19, 2, 107, 30, 6, 70);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (71, '2025.09.04', '09:00', 90, 35, 3, 36, 7, 9, 99);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (72, '2025.10.28', '16:30', 45, 1, 10, 37, 8, 112);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (73, '2025.07.30', '09:30', 60, 31, 2, 106, 63, 2, 172);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (74, '2025.07.14', '11:00', 45, 37, 5, 11, 2, 167);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (75, '2025.09.01', '12:30', 90, 25, 8, 117, 10, 134);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (76, '2025.03.13', '09:30', 90, 7, 4, 81, 85, 2, 65);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (77, '2025.11.27', '11:30', 90, 5, 3, 1, 12, 177);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (78, '2025.10.20', '13:30', 45, 15, 5, 91, 111, 8, 43);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (79, '2025.05.06', '13:00', 90, 38, 11, 103, 7, 54);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (80, '2025.11.17', '12:30', 90, 10, 5, 106, 8, 3, 103);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (81, '2025.04.01', '13:30', 60, 8, 8, 89, 7, 94);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (82, '2025.08.22', '17:30', 60, 29, 2, 77, 56, 12, 107);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (83, '2025.10.23', '13:00', 45, 6, 4, 87, 10, 175);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (84, '2025.06.04', '13:00', 90, 3, 3, 61, 8, 96);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (85, '2025.05.01', '15:30', 90, 32, 2, 61, 6, 107);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (86, '2025.06.30', '11:30', 60, 27, 12, 64, 52, 9, 34);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (87, '2025.07.01', '10:00', 60, 17, 6, 15, 7, 156);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (88, '2025.09.16', '17:30', 60, 27, 1, 25, 10, 218);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (89, '2025.07.21', '16:00', 45, 14, 5, 71, 37, 8, 203);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (90, '2025.03.27', '10:30', 45, 41, 10, 103, 21, 5, 166);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (91, '2025.11.17', '17:30', 60, 6, 4, 108, 8, 55);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (92, '2025.08.12', '16:30', 90, 19, 9, 91, 107, 8, 145);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (93, '2025.07.18', '16:00', 90, 10, 7, 25, 9, 216);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (94, '2025.09.23', '10:00', 60, 27, 6, 120, 5, 25);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (95, '2025.12.05', '13:30', 90, 38, 11, 63, 8, 162);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (96, '2025.07.01', '14:30', 60, 36, 9, 49, 6, 73);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (97, '2025.03.07', '15:00', 45, 27, 1, 41, 12, 122);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (98, '2025.05.08', '11:00', 60, 3, 3, 65, 6, 50);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (99, '2025.09.29', '10:30', 90, 30, 1, 93, 112, 11, 64);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (100, '2025.04.02', '16:30', 60, 22, 10, 89, 2, 109);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (101, '2025.10.13', '15:00', 60, 41, 12, 114, 9, 34);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (102, '2025.07.10', '10:00', 45, 41, 11, 118, 30, 12, 48);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (103, '2025.03.06', '10:30', 90, 7, 8, 22, 1, 36);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (104, '2025.07.07', '09:30', 60, 23, 6, 56, 68, 7, 169);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (105, '2025.05.22', '11:30', 45, 6, 10, 112, 11, 86);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (106, '2025.07.24', '11:00', 45, 30, 11, 33, 11, 27);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (107, '2025.09.09', '13:30', 90, 35, 3, 10, 6, 175);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (108, '2025.08.28', '15:30', 90, 17, 8, 109, 7, 148);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (109, '2025.11.17', '12:30', 60, 37, 6, 74, 90, 5, 30);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (110, '2025.03.24', '13:00', 45, 37, 11, 100, 1, 180);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (111, '2025.10.16', '13:30', 45, 39, 6, 29, 10, 89);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (112, '2025.06.12', '10:30', 90, 42, 1, 40, 1, 173);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (113, '2025.08.26', '11:00', 45, 19, 6, 96, 4, 58);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (114, '2025.12.01', '14:30', 90, 33, 5, 107, 117, 8, 100);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (115, '2025.10.14', '10:30', 60, 5, 3, 97, 11, 210);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (116, '2025.11.14', '17:30', 60, 6, 7, 2, 16, 8, 119);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (117, '2025.05.23', '15:00', 90, 24, 2, 87, 4, 10, 168);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (118, '2025.09.12', '12:30', 90, 5, 11, 106, 12, 102);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (119, '2025.08.21', '10:30', 45, 3, 1, 39, 2, 49);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (120, '2025.05.05', '17:30', 45, 25, 8, 48, 12, 203);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (121, '2025.04.25', '15:30', 90, 10, 7, 84, 63, 10, 129);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (122, '2025.09.10', '09:30', 90, 24, 4, 57, 4, 117);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (123, '2025.08.07', '14:30', 90, 42, 6, 8, 4, 56);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (124, '2025.07.15', '10:00', 90, 14, 11, 82, 1, 37);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (125, '2025.11.26', '12:30', 45, 37, 4, 9, 9, 78);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (126, '2025.08.14', '12:00', 45, 22, 3, 101, 1, 95);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (127, '2025.03.18', '11:00', 90, 17, 3, 15, 1, 58);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (128, '2025.03.05', '14:30', 45, 38, 6, 3, 7, 3, 214);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (129, '2025.04.18', '17:00', 45, 5, 8, 58, 9, 176);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (130, '2025.08.12', '16:00', 90, 15, 10, 6, 11, 158);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (131, '2025.05.09', '16:00', 90, 2, 1, 62, 7, 200);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (132, '2025.03.10', '16:30', 90, 29, 2, 116, 78, 3, 41);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (133, '2025.06.02', '13:00', 90, 41, 10, 71, 7, 177);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (134, '2025.07.07', '13:30', 60, 33, 10, 56, 90, 2, 192);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (135, '2025.11.03', '12:00', 60, 29, 4, 53, 8, 127);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (136, '2025.06.06', '10:30', 60, 28, 6, 86, 20, 11, 146);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (137, '2025.08.05', '10:00', 45, 6, 7, 13, 6, 58);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (138, '2025.10.15', '09:30', 90, 36, 9, 43, 7, 115);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (139, '2025.07.30', '09:30', 60, 39, 5, 46, 65, 4, 64);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (140, '2025.03.03', '12:30', 45, 23, 9, 48, 36, 10, 82);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (141, '2025.04.09', '17:30', 90, 40, 11, 83, 10, 193);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (142, '2025.10.09', '09:00', 45, 18, 12, 98, 6, 114);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (143, '2025.03.25', '11:30', 45, 37, 11, 52, 95, 11, 32);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (144, '2025.09.01', '17:00', 45, 25, 7, 59, 6, 104);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (145, '2025.07.07', '10:00', 45, 10, 3, 97, 11, 45);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (146, '2025.11.11', '16:00', 90, 28, 8, 78, 5, 80);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (147, '2025.04.02', '10:30', 60, 28, 2, 37, 10, 149);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (148, '2025.04.01', '13:30', 45, 15, 7, 77, 27, 5, 79);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (149, '2025.08.04', '13:00', 60, 21, 2, 1, 7, 69);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (150, '2025.03.05', '15:00', 90, 15, 9, 72, 6, 43);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (151, '2025.09.10', '09:30', 60, 2, 8, 118, 41, 10, 134);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (152, '2025.07.15', '15:00', 90, 41, 7, 38, 3, 6, 68);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (153, '2025.03.27', '16:00', 90, 24, 2, 56, 4, 136);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (154, '2025.09.12', '15:00', 90, 6, 7, 112, 6, 81);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (155, '2025.11.05', '11:30', 45, 33, 11, 15, 4, 114);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (156, '2025.10.15', '11:00', 45, 7, 3, 33, 78, 3, 219);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (157, '2025.07.24', '11:30', 90, 32, 8, 97, 10, 139);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `eloadok2`, `terem`, `letszam`) VALUES (158, '2025.03.12', '14:00', 90, 21, 3, 57, 81, 5, 95);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (159, '2025.06.25', '09:30', 60, 33, 2, 40, 1, 39);
INSERT INTO `program` (`program_id`, `datum`, `kezdo_idopont`, `hossz`, `tema`, `szekcio`, `eloadok1`, `terem`, `letszam`) VALUES (160, '2025.06.04', '13:30', 45, 42, 2, 79, 7, 143);

CREATE TABLE IF NOT EXISTS `szekciok`(
	`szekcio_id` int(11) NOT NULL AUTO_INCREMENT,
	`kategoria` varchar(37) CHARACTER SET utf8 NOT NULL,
	`ar` int(11) NOT NULL,
 PRIMARY KEY (`szekcio_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci AUTO_INCREMENT=13;

INSERT INTO `szekciok` (`szekcio_id`, `kategoria`, `ar`) VALUES (1, 'Informatika', 12000);
INSERT INTO `szekciok` (`szekcio_id`, `kategoria`, `ar`) VALUES (2, 'Mesterséges intelligencia', 15000);
INSERT INTO `szekciok` (`szekcio_id`, `kategoria`, `ar`) VALUES (3, 'Kiberbiztonság', 14000);
INSERT INTO `szekciok` (`szekcio_id`, `kategoria`, `ar`) VALUES (4, 'Adattudomány', 13000);
INSERT INTO `szekciok` (`szekcio_id`, `kategoria`, `ar`) VALUES (5, 'Robotika', 14000);
INSERT INTO `szekciok` (`szekcio_id`, `kategoria`, `ar`) VALUES (6, 'Mérnöktudományok', 11000);
INSERT INTO `szekciok` (`szekcio_id`, `kategoria`, `ar`) VALUES (7, 'Természettudományok', 10000);
INSERT INTO `szekciok` (`szekcio_id`, `kategoria`, `ar`) VALUES (8, 'Orvostudomány', 13000);
INSERT INTO `szekciok` (`szekcio_id`, `kategoria`, `ar`) VALUES (9, 'Környezettudomány', 11000);
INSERT INTO `szekciok` (`szekcio_id`, `kategoria`, `ar`) VALUES (10, 'Energetika', 12000);
INSERT INTO `szekciok` (`szekcio_id`, `kategoria`, `ar`) VALUES (11, 'Matematika', 10000);
INSERT INTO `szekciok` (`szekcio_id`, `kategoria`, `ar`) VALUES (12, 'Oktatástechnológia', 9000);

CREATE TABLE IF NOT EXISTS `temak`(
	`tema_id` int(11) NOT NULL AUTO_INCREMENT,
	`tema_nev` varchar(57) CHARACTER SET utf8 NOT NULL,
 PRIMARY KEY (`tema_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci AUTO_INCREMENT=43;

INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (1, 'Mesterséges intelligencia alapjai');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (2, 'Gépi tanulás alkalmazások');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (3, 'Adatvédelem és GDPR');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (4, 'Kiberbiztonság gyakorlati megközelítés');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (5, 'Robotika ipari alkalmazások');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (6, 'Képfeldolgozás');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (7, 'Természetes nyelvfeldolgozás');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (8, 'Felhőalapú rendszerek');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (9, 'Big Data és adatbányászat');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (10, 'Szoftverarchitektúrák');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (11, 'Mikroszolgáltatások');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (12, 'Tesztelés és minőségbiztosítás');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (13, 'DevOps és CI/CD');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (14, 'Irányítástechnika');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (15, 'IoT megoldások');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (16, 'Okos városok technológiái');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (17, 'Megújuló energia rendszerek');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (18, 'Környezeti modellezés');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (19, 'Kvantumszámítási alapok');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (20, 'Asztrofizika új eredményei');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (21, 'Biotechnológia');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (22, 'Genetika és genomika');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (23, 'Orvosi diagnosztika');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (24, 'Járványtani modellek');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (25, 'Anyagtudomány');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (26, 'Nanotechnológia');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (27, 'Folyadékmechanika');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (28, 'Számítógépes grafika');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (29, 'Digitális jelfeldolgozás');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (30, 'Kriptográfia modern módszerei');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (31, 'Adatvizualizáció');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (32, 'Párhuzamos programozás');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (33, 'Elosztott rendszerek');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (34, 'Szimuláció és modellezés');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (35, 'Matematikai optimalizálás');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (36, 'Statisztikai módszerek');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (37, 'Gazdasági informatika');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (38, 'Oktatástechnológia');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (39, 'Humán–gép interakció');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (40, 'Közlekedési rendszerek');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (41, 'Kiberfizikai rendszerek');
INSERT INTO `temak` (`tema_id`, `tema_nev`) VALUES (42, 'Szoftverfejlesztési minták');

ALTER TABLE `program`
ADD CONSTRAINT `fk_program_tema_id` FOREIGN KEY (`tema`) REFERENCES `temak` (`tema_id`),
ADD CONSTRAINT `fk_program_szekcio_id` FOREIGN KEY (`szekcio`) REFERENCES `szekciok` (`szekcio_id`),
ADD CONSTRAINT `fk_program_eloadok1_id` FOREIGN KEY (`eloadok1`) REFERENCES `eloadok` (`eloado_id`),
ADD CONSTRAINT `fk_program_eloadok2_id` FOREIGN KEY (`eloadok2`) REFERENCES `eloadok` (`eloado_id`);
