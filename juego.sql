DROP DATABASE IF EXISTS juego;
CREATE DATABASE juego;

USE juego;

CREATE TABLE jugador (
	username VARCHAR (20) PRIMARY KEY NOT NULL, 
	password VARCHAR (20) NOT NULL, 
	partidas INTEGER NOT NULL, 
	ganadas INTEGER NOT NULL

	)ENGINE = InnoDB;
	
CREATE TABLE partida (
	idpartida INTEGER PRIMARY KEY NOT NULL, 
	ganador VARCHAR (20) NOT NULL, 
	fecha DATE NOT NULL, 
	horain TIME NOT NULL, 
	horafin TIME NOT NULL,
	duracion TIME NOT NULL

	)ENGINE = InnoDB;
	
CREATE TABLE relacion (
	idpartida INTEGER not null, 
	foreign key(idpartida) references partida(idpartida),
	username VARCHAR (20) not null,
	foreign key(username) references jugador(username)

	)ENGINE = InnoDB;

INSERT INTO jugador (username, password, partidas, ganadas) VALUES ('Jordi', 'upc', 2, 2);
INSERT INTO jugador (username, password, partidas, ganadas) VALUES ('Pablo', 'upc1', 3, 1);
INSERT INTO jugador (username, password, partidas, ganadas) VALUES ('Polet', 'upc2', 3, 1);


INSERT INTO partida (idpartida, ganador, fecha, horain, horafin, duracion)
	VALUES (1,'Jordi','2020-03-08','11:40:00','12:30:00','00:20:00');
INSERT INTO partida (idpartida, ganador, fecha, horain, horafin, duracion)
	VALUES (2,'Jordi','2020-03-08','10:35:00','11:00:10','00:30:00');
INSERT INTO partida (idpartida, ganador, fecha, horain, horafin, duracion)
	VALUES (3,'Polet','2020-03-08','18:10:30','13:40:20','00:10:00');
INSERT INTO partida (idpartida, ganador, fecha, horain, horafin, duracion)
	VALUES (4,'Pablo','2020-03-08','11:30:00','15:02:50','00:07:00');

INSERT INTO relacion (idpartida, username) VALUES (1,'Jordi');
INSERT INTO relacion (idpartida, username) VALUES (1,'Pablo');
INSERT INTO relacion (idpartida, username) VALUES (2,'Polet');
INSERT INTO relacion (idpartida, username) VALUES (2,'Jordi');
INSERT INTO relacion (idpartida, username) VALUES (3,'Polet');
INSERT INTO relacion (idpartida, username) VALUES (3,'Pablo');
INSERT INTO relacion (idpartida, username) VALUES (4,'Polet');
INSERT INTO relacion (idpartida, username) VALUES (4,'Pablo');




