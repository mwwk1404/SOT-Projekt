USE Master;
GO

CREATE DATABASE Verkauf;
Use Verkauf;
GO

CREATE TABLE Artikel (
Artikel_ID INT IDENTITY PRIMARY KEY,
Artikel_Bezeichnung VARCHAR(100),
Artikel_Preis DECIMAL);


CREATE TABLE Artikelliste (
Artikelliste_ID INT IDENTITY PRIMARY KEY,
Gesamtpreis DECIMAL,
Artikel_ID INT,
FOREIGN KEY (Artikel_ID) REFERENCES Artikel(Artikel_ID));

CREATE TABLE Rechnungen (
Rechnungs_ID INT IDENTITY PRIMARY KEY,
Rechnungsgesamtpreis DECIMAL,
Rechnungs_Datum DATE,
Artikelliste_ID INT,
FOREIGN KEY (Artikelliste_ID) REFERENCES Artikelliste(Artikelliste_ID));

INSERT INTO Artikel(Artikel_Bezeichnung, Artikel_Preis)
VALUES
('Fahrrad-Helm Grün', 20),
('Fahrrad-Pumpe', 15),
('Reifen-Schlauch', 7),
('Fahrrad-Lampe', 5),
('Trinkflasche', 3);


