
Use Verkauf;
GO

CREATE TABLE Artikel (
Artikel_ID INT IDENTITY PRIMARY KEY,
Artikel_Bezeichnung VARCHAR(100),
Artikel_Preis DECIMAL);



CREATE TABLE Rechnungen (
Rechnungs_ID INT IDENTITY PRIMARY KEY,
Artikel_ID INT,
Arbeitszeit INT,
FOREIGN KEY (Artikel_ID) REFERENCES Artikel(Artikel_ID),
Rechnungs_Datum DATE,
Gesamtpreis DECIMAL,
);

INSERT INTO Artikel(Artikel_Bezeichnung, Artikel_Preis)
VALUES
('Fahrrad-Helm Grün', 20),
('Fahrrad-Pumpe', 15),
('Reifen-Schlauch', 7),
('Fahrrad-Lampe', 5),
('Trinkflasche', 3);


