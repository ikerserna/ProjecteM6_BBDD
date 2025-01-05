CREATE DATABASE ProjecteM6_BBDD;
USE ProjecteM6_BBDD;

CREATE TABLE Categories (
    NomCategoria VARCHAR(255) PRIMARY KEY
);

CREATE TABLE Continents (
    NomContinent VARCHAR(255) PRIMARY KEY
);

CREATE TABLE Països (
    NomPais VARCHAR(255) PRIMARY KEY,
    NomContinent VARCHAR(255),
    FOREIGN KEY (NomContinent) REFERENCES Continents(NomContinent)
);

CREATE TABLE Ciutats (
    NomCiutat VARCHAR(255) PRIMARY KEY,
    NomPais VARCHAR(255),
    FOREIGN KEY (NomPais) REFERENCES Països(NomPais)
);

CREATE TABLE Restaurants (
    Nom VARCHAR(255) PRIMARY KEY,
    NomCategoria VARCHAR(255),
    NomPais VARCHAR(255),
    NomCiutat VARCHAR(255),
    Adreça VARCHAR(255),
    CodiPostal VARCHAR(20),
    CorreuContacte VARCHAR(255),
    Ressenya TEXT,
    Valoració TINYINT CHECK (Valoració BETWEEN 1 AND 5),
    Foto TEXT,
    MiniaturaWeb TEXT,
    EnllaçWeb VARCHAR(255),
    HorariVisita VARCHAR(255),
    GoogleMapsLink VARCHAR(255),
    FOREIGN KEY (NomCategoria) REFERENCES Categories(NomCategoria),
    FOREIGN KEY (NomPais) REFERENCES Països(NomPais),
    FOREIGN KEY (NomCiutat) REFERENCES Ciutats(NomCiutat)
);

CREATE TABLE TelèfonsContacte (
    NúmeroTelèfon VARCHAR(20) PRIMARY KEY,
    NomRestaurant VARCHAR(255),
    FOREIGN KEY (NomRestaurant) REFERENCES Restaurants(Nom)
);

CREATE TABLE GaleriaImatges (
    Imatge VARCHAR(255) PRIMARY KEY,
    NomRestaurant VARCHAR(255),
    FOREIGN KEY (NomRestaurant) REFERENCES Restaurants(Nom)
);
