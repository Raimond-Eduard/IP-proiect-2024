PRAGMA foreign_keys = ON;

CREATE TABLE Utilizatori(
	id_utilizator INT PRIMARY KEY NOT NULL,
	nume TEXT,
	prenume TEXT,
	username TEXT NOT NULL,
	varsta INT CHECK(varsta >= 18),
	rol TEXT NOT NULL,
	email TEXT,
	telefon TEXT UNIQUE
);


CREATE TABLE Camera(
	id_camera INT PRIMARY KEY NOT NULL,
	numar_camera INT NOT NULL,
	pret_per_noapte INT NOT NULL,
	etaj INT NOT NULL,
	tip_camera TEXT NOT NULL,
	tip_balcon TEXT NOT NULL,
	capacitate INT NOT NULL
);

CREATE TABLE Rezervare(
	id_rezervare INT PRIMARY KEY NOT NULL,
	id_client INT NOT NULL,
	id_camera INT NOT NULL,
	total_plata INT NOT NULL,
	check_in TEXT NOT NULL,
	check_out TEXT NOT NULL,
	FOREIGN KEY(id_client) REFERENCES Utilizator(id_utilizator),
	FOREIGN KEY(id_camera) REFERENCES Camera(id_camera)
	/*
	Pentru insertia de date se va folosit functie
	datetime(parametru) unde parametru este string cu data
	*/
);

