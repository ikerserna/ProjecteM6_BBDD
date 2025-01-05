CREATE DATABASE ProjecteM6_BBDD;
GO

USE ProjecteM6_BBDD;
GO

CREATE TABLE Categories (
    NomCategoria NVARCHAR(255) PRIMARY KEY
);

CREATE TABLE Continents (
    NomContinent NVARCHAR(255) PRIMARY KEY
);

CREATE TABLE Paisos (
    NomPais NVARCHAR(255) PRIMARY KEY,
    NomContinent NVARCHAR(255),
    FOREIGN KEY (NomContinent) REFERENCES Continents(NomContinent)
);

CREATE TABLE Ciutats (
    NomCiutat NVARCHAR(255) PRIMARY KEY,
    NomPais NVARCHAR(255),
    FOREIGN KEY (NomPais) REFERENCES Paisos(NomPais)
);

CREATE TABLE Restaurants (
    Nom NVARCHAR(255) PRIMARY KEY,
    NomCategoria NVARCHAR(255),
    NomPais NVARCHAR(255),
    NomCiutat NVARCHAR(255),
    Adresa NVARCHAR(255),
    CodiPostal NVARCHAR(20),
    CorreuContacte NVARCHAR(255),
    TelefonContacte NVARCHAR(20),
    Ressenya NVARCHAR(MAX),
    Valoracio TINYINT CHECK (Valoracio BETWEEN 1 AND 5),
    Foto NVARCHAR(MAX),
    MiniaturaWeb NVARCHAR(MAX),
    LinkWeb NVARCHAR(255),
    HorariVisita NVARCHAR(255),
    GoogleMapsLink NVARCHAR(255),
    CuinaEspecialitzada NVARCHAR(MAX),
    FOREIGN KEY (NomCategoria) REFERENCES Categories(NomCategoria),
    FOREIGN KEY (NomPais) REFERENCES Paisos(NomPais),
    FOREIGN KEY (NomCiutat) REFERENCES Ciutats(NomCiutat)
);

CREATE TABLE TelefonsContacte (
    NumeroTelefon NVARCHAR(20) PRIMARY KEY,
    NomRestaurant NVARCHAR(255),
    FOREIGN KEY (NomRestaurant) REFERENCES Restaurants(Nom)
);

CREATE TABLE GaleriaImatges (
    Imatge NVARCHAR(255) PRIMARY KEY,
    NomRestaurant NVARCHAR(255),
    FOREIGN KEY (NomRestaurant) REFERENCES Restaurants(Nom)
);

CREATE TABLE Usuaris (
    IDUsuari INT IDENTITY(1,1) PRIMARY KEY,
    NomUsuari NVARCHAR(255),
    Correu NVARCHAR(255) UNIQUE,
    Telefon NVARCHAR(20),
    Contrassenya NVARCHAR(255),
    Rol NVARCHAR(50) DEFAULT 'Usuari' CHECK (Rol IN ('Usuari', 'Admin'))
);

CREATE TABLE Reserves (
    IDReserva INT IDENTITY(1,1) PRIMARY KEY,
    NomRestaurant NVARCHAR(255),
    IDUsuari INT,
    DataReserva DATE,
    HoraReserva TIME,
    NumeroPersones INT CHECK (NumeroPersones > 0),
    Comentaris NVARCHAR(MAX),
    FOREIGN KEY (NomRestaurant) REFERENCES Restaurants(Nom),
    FOREIGN KEY (IDUsuari) REFERENCES Usuaris(IDUsuari)
);

CREATE TABLE Comentaris (
    IDComentari INT IDENTITY(1,1) PRIMARY KEY,
    NomRestaurant NVARCHAR(255),
    IDUsuari INT,
    TextComentari NVARCHAR(MAX),
    Valoracio TINYINT CHECK (Valoracio BETWEEN 1 AND 5),
    DataHora DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (NomRestaurant) REFERENCES Restaurants(Nom),
    FOREIGN KEY (IDUsuari) REFERENCES Usuaris(IDUsuari)
);
GO
