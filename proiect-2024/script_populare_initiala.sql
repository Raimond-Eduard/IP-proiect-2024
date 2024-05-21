-- Populare Utilizator

-- 3 utilizatori de baza

INSERT INTO Utilizatori VALUES(1, 'Puscasu', 'Marin', 'mp123', 42, 'user', 'marin.puscasu@hotmail.com', '0769420169', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4');
INSERT INTO Utilizatori (id_utilizator, nume, prenume, username, rol, email, telefon, parola) VALUES(2,'John', 'Doe', 'jd2109', 'Manager', 'john.doe@yahoo.com', '0765432109', 'a80b568a237f50391d2f1f97beaf99564e33d2e1c8a2e5cac21ceda701570312');
INSERT INTO Utilizatori (id_utilizator, username, rol, parola) VALUES(3,'admin', 'Admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918');


--Populare camere

INSERT INTO Camera VALUES(1, 609, 150, 6, 'Deluxe', 'Comun', 4);
INSERT INTO Camera VALUES(2, 210, 100, 2, 'Standard','Propriu', 1);
INSERT INTO Camera VALUES(3, 480, 175, 1, 'Apartament','Fara', 2);



