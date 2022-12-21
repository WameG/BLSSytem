-- Datamatiker uddannelsen

-- 1 + 2. Semester
INSERT INTO Bog VALUES(1,'The Agile Samurai','Jonathan Rasmusson',2010,9781934356586,'Basiskemi B.jpg');

-- 3. Semester

INSERT INTO Bog VALUES(2,'Computer Networking','Jams K & Keith R',2021,9781292405469,'Computer Networking');
INSERT INTO Bog VALUES(3,'Engineering Software','Ian Sommerville',2020,9781292376349,'Engineering Software');

-- 4. Semester
INSERT INTO Bog VALUES(4,'Learning PHP','Robin Nixon',2018,9781491978917,'Learning PHP.jpg');

-- Laborant Uddannelsen
--1. Semester
INSERT INTO Bog VALUES(6,'Analyseteknink','Merete Norsker Bergsøe',2019,9788750059967, 'Analyseteknik.jpg');
INSERT INTO Bog VALUES(7,'Håndbog for laboratoriefolk',' Helle Jeppesen & Merete Norsker Bergsøe', 2019,9788750060154,'Håndbogforlabor');

---- 2. Semester
INSERT INTO Bog VALUES(8,'Basiskemi B 2. udgave',' H. Mygind, Vibeke Axelsen & O. Vesterlund Nielsen', 2022,9788729006114,'Basiskemi B.jpg');
INSERT INTO Bog VALUES (9, 'Arbejdsmiljø i laboratoriet', 'Claus Hansen & Helle Nielsen', 2021, 9788750059974,'Arbejdsmiljø.jpg');

----3. Semester
 INSERT INTO Bog VALUES (10, 'Praktik mikrobiologi',' René Møller Madsen', 2022, 9788750061328,'Praktiskmikrobiologi.jpg');


----4. Semester
INSERT INTO Bog VALUES (11, 'Molekylærbiologi & biokemi', 'Bodil Stilling', 2017,9788750060031, 'Molykulær.jpg');



--Markedsføringsøkonom uddannelsen

-- 1. semester
INSERT INTO Bog VALUES (12, 'International Markedsføring', 'Finn Rolighed Andersen, Bjarne Warming Jensen, Mette Risgaard Olsen, Sussanne Østergaard Olsen, Mia Post-Lundgaard & Ivan Hassinggaard', 2019,9788771541427, 'InternationalMarkeds.jpg'); 
INSERT INTO BOG VALUES (13, 'Introduktion til markedsføring på sociale medier','Kenneth Dosanjh, Halfdan Moth Timm & Alberte Hall', 2020, 9788741278360, 'IntroMark.png');

--2. Semester
INSERT INTO BOG VALUES (13, 'ERhvervsøkonomi til Akademiuddannelserne',' Lone Hansen, Morten Dalbøge & Torben Rosenkilde Jensen', 2022, 9788702317046, 'Erhvervs.jpg');


-- 3. Semester
INSERT INTO BOG VALUES (14, 'Organisation, Innovation & Supply Chain management', 'Dorthe Bholbro, THomas Lindholm Uth, Anne Sejer Hansen & Jes Victor Noldus Christiansen', 2019, 9788741271323, 'Organis.jpg');


--4. Semester

INSERT INTO Bog VALUES (15,'Erhvervsjura - for maerketing og service','Bjarke Tinten, Kennet Fischer Föh, Simon Juul Pedersen & Helle Næss-Schmidt Risdal', 2022, 9788702364101, 'Erhvjura.jpg');
INSERT INTO Bog VALUES (16, 'Erhvervsjura - lovsamling','Kennet Fischer Föh, Bjarke Tinten & Lotte Mohr Dupont-Mersing', 2022, 9788702364118, 'Juralov.jpg');

--INSERT INTO Hold VALUES(1);
--INSERT INTO Hold VALUES(2);
--INSERT INTO Hold VALUES(3);
--INSERT INTO Hold VALUES(4);
--INSERT INTO Hold VALUES(5);
--INSERT INTO Hold VALUES(6);
--INSERT INTO Hold VALUES(7);
--INSERT INTO Hold VALUES(8);
--INSERT INTO Hold VALUES(9);
--INSERT INTO Hold VALUES(10);
--INSERT INTO Hold VALUES(11);
--INSERT INTO Hold VALUES(12);
--INSERT INTO Hold VALUES(14);
--INSERT INTO Hold VALUES(15);

INSERT INTO Koordinator VALUES (1, 'Jens Andersen');



---- 1 & 2. Semester Datamatiker Undervisere

INSERT INTO Underviser VALUES(1,'Jens Peter Andersen','JPAN');
INSERT INTO Underviser VALUES(2,'Vibeke Sandau','VISA');

-- 3. Semester Datamatiker Undervisere

INSERT INTO Underviser VALUES (3, 'Thomas Thomsen','TOMT',1);
INSERT INTO Underviser VALUES (4, 'Jette Hansen','JETH',2);
-- 4. Semester Datamatiker Undervisere

INSERT INTO Underviser VALUES (5, 'James Bobby Jackson', 'JBJN',2);
INSERT INTO Underviser VALUES (6, 'Maria Sønderbye','MSOE',1);

-- 5. Semester Datamatiker Undervisere
INSERT INTO Underviser VALUES (7,' Hans Petersen', 'HSPE',1);


---- 1 & 2. Semester Laborant
INSERT INTO Underviser VALUES (8,'Christina Christensen', 'CCRS',2);
INSERT INTO Underviser VALUES (9,'Kasper Ohasen','KOHA',2);

---- 3 & 4. Semester Laborant
INSERT INTO Underviser VALUES (10,'Connan O´Loren', 'COLO',2);
INSERT INTO Underviser VALUES (11, 'Kilas Komono','KIKO',1);


---- 1 & 2. Semester Markedsføring økonom Undervisere
INSERT INTO Underviser VALUES (12,'Bo Bodilsen','BOBO',1);
INSERT INTO Underviser VALUES (13,' Dorthe Ditlevsen',' DODI',1);


---- 3. Semester
INSERT INTO Underviser VALUES (14, 'Ditte Dortesen', 'DIDO',2);


---- 4. Semester
INSERT INTO Underviser VALUES (15, 'Klaus Madsen', 'KLMD',1);


----Datamatiker Uddannelsen Fag
---- 1 & 2. Semester Fag
INSERT INTO Fag VALUES (1,'Software Construction');
INSERT INTO Fag VALUES (2, 'Software Design');

----3 & 4. Semester Fag
INSERT INTO Fag VALUES (3, 'Network');
INSERT INTO Fag VALUES (4, 'Machine Learning');

----Laborant Uddannelsen Fag:
------ 1 & 2. Semester Fag
INSERT INTO FAG VALUES (5, 'Kemi');
INSERT INTO FAG VALUES (6, 'BioKemi');

---- 3 & 4. Semester Fag
INSERT INTO FAG VALUES (7,'Mikrobiologi');
INSERT INTO FAG VALUES (8, 'Makroøkologi');

--Markedføringsøkonm uddannelsen Fag 
----1 & 2. Semester
INSERT INTO FAG VALUES (9, 'MarkedsføringsØkonom');
INSERT INTO FAG VALUES (10, 'Økonomi');

---- 3 & 4. Semester
INSERT INTO FAG VALUES (11,'Innovation');
INSERT INTO FAG VALUES (12,'Erhvervsjura');


INSERT INTO Semestre VALUES(1, '1. Semester');
INSERT INTO Semestre VALUES(2, '2. Semester');
INSERT INTO Semestre VALUES(3, '3. Semester');
INSERT INTO Semestre VALUES(4, '4. Semester');
INSERT INTO Semestre VALUES(5, '5. Semester');


INSERT INTO Uddannelse VALUES (2, 'Laborant');
INSERT INTO Uddannelse VALUES (3, ' Markedsførings økonom');