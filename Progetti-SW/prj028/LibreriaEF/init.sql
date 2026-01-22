CREATE DATABASE IF NOT EXISTS LibreriaDB;
USE LibreriaDB;

CREATE TABLE Autori (
    Id INT AUTO_INCREMENT PRIMARY KEY;
    Nome VARCHAR(100) NOT NULL,
    Cognome VARCHAR(100) NOT NULL,
    Email VARCHAR(150) NOT NULL
);

CREATE TABLE Libri(
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Titolo VARCHAR(100) NOT NULL,
    ISBN VARCHAR(13) UNIQUE NOT NULL,
    Prezzo DECIMAL(10,2),
    AutoreId INT,
    FOREIGN KEY(AutoreId) REFERENCES Autori(Id)
);

INSERT INTO Autori (Nome, Cognome, Email) VALUES 
('Umberto', 'Eco', 'umberto.eco@example.com'),
('Italo', 'Calvino', 'italo.calvino@example.com');

INSERT INTO Libri (Titolo, ISBN, Prezzo, AutoreId) VALUES 
('Il Nome della Rosa', '9788804680385', 15.90, 1),
('Il Barone Rampante', '9788804667669', 12.99, 2);