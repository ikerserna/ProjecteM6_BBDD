CREATE DATABASE RestaurantsDB;
GO

--DROP DATABASE RestaurantsDB;
--GO

USE RestaurantsDB;
GO

CREATE TABLE Continents (
    NomContinent NVARCHAR(60) PRIMARY KEY
);

CREATE TABLE Paisos (
    NomPais NVARCHAR(60) PRIMARY KEY,
    NomContinent NVARCHAR(60),
    FOREIGN KEY (NomContinent) REFERENCES Continents(NomContinent)
);

CREATE TABLE Ciutats (
    NomCiutat NVARCHAR(60) PRIMARY KEY,
    NomPais NVARCHAR(60),
    FOREIGN KEY (NomPais) REFERENCES Paisos(NomPais)
);

CREATE TABLE Restaurants (
    Nom NVARCHAR(60),
	idRestaurant INT IDENTITY(1,1) PRIMARY KEY,
    NomCiutat NVARCHAR(60),
    Adresa NVARCHAR(60),
    CodiPostal NVARCHAR(20),    
    eMail NVARCHAR(40),
    TelefonContacte NVARCHAR(20),
    MiniaturaWeb NVARCHAR(500),
    LinkWeb NVARCHAR(255),
    GoogleMapsLink NVARCHAR(255),
    CuinaEspecialitzada NVARCHAR(60),
    FOREIGN KEY (NomCiutat) REFERENCES Ciutats(NomCiutat)
);


CREATE TABLE Categories(
	idCategoria INT IDENTITY(1,1) PRIMARY KEY,
	descripcioCategoria NVARCHAR(30)
);

CREATE TABLE   (
    idRestaurant INT,
    idCategoria INT,
    PRIMARY KEY (idRestaurant, idCategoria),
    FOREIGN KEY (idRestaurant) REFERENCES Restaurants(idRestaurant),
    FOREIGN KEY (idCategoria) REFERENCES Categories(idCategoria)
);

CREATE TABLE Horaris (
    idHorari INT IDENTITY(1,1) PRIMARY KEY,
    idRestaurant INT,
    diaSetmana NVARCHAR(20),
    horaObertura TIME,
    horaTancament TIME,
    FOREIGN KEY (idRestaurant) REFERENCES Restaurants(idRestaurant), 
    CONSTRAINT UNQ_HORARI UNIQUE (idRestaurant, diaSetmana),
    CONSTRAINT CHK_DiaSetmana CHECK (diaSetmana IN ('dilluns', 'dimarts', 'dimecres', 'dijous', 'divendres', 'dissabte', 'diumenge'))
);

CREATE TABLE GaleriaImatges (
    imatge NVARCHAR(MAX),
    idImatge INT PRIMARY KEY,
    idRestaurant INT,
    FOREIGN KEY (idRestaurant) REFERENCES Restaurants(idRestaurant)
);

CREATE TABLE Usuaris (
    idUsuari INT IDENTITY(1,1) PRIMARY KEY,
    NomUsuari NVARCHAR(60),
    Correu NVARCHAR(60) UNIQUE,
    Telefon NVARCHAR(20),
    Contrassenya NVARCHAR(60)
);

CREATE TABLE Resenyes (
    idResenya INT IDENTITY(1,1) PRIMARY KEY,
    resenya NVARCHAR(2000),
    valoracio INT CHECK (valoracio BETWEEN 1 AND 5),
    idUsuari INT,
    FOREIGN KEY (idUsuari) REFERENCES Usuaris(idUsuari)
);

CREATE TABLE Reserves (
    IDReserva INT IDENTITY(1,1) PRIMARY KEY,
    idRestaurant INT,
    idUsuari INT,
    DataReserva DATE,
    HoraReserva TIME,
    NumeroPersones INT CHECK (NumeroPersones > 0),
    FOREIGN KEY (idRestaurant) REFERENCES Restaurants(idRestaurant),
    FOREIGN KEY (idUsuari) REFERENCES Usuaris(idUsuari),
    CONSTRAINT UNQ_Reserves UNIQUE (idRestaurant, DataReserva, HoraReserva),
    CONSTRAINT CK_NumeroPersones CHECK (NumeroPersones BETWEEN 1 AND 20)
);
GO

CREATE TRIGGER TRG_ValidarHorariReserva
ON Reserves
FOR INSERT
AS
BEGIN
    DECLARE @idRestaurant INT,
            @HoraReserva TIME,
            @DataReserva DATE,
            @DiaSetmana NVARCHAR(20),
            @HoraApertura TIME,
            @HoraCierre TIME;
    
    SELECT @idRestaurant = idRestaurant, 
           @HoraReserva = HoraReserva, 
           @DataReserva = DataReserva
    FROM INSERTED;
    
    SET @DiaSetmana = DATENAME(weekday, @DataReserva);
    
    SELECT @HoraApertura = horaObertura, @HoraCierre = horaTancament
    FROM Horaris
    WHERE idRestaurant = @idRestaurant
      AND diaSetmana = @DiaSetmana;

    IF @HoraReserva < @HoraApertura OR @HoraReserva > @HoraCierre
    BEGIN
        RAISERROR('La reserva no es pot realitzar fora de l''horari del restaurant.', 16, 1);
        ROLLBACK TRANSACTION; 
    END
END
GO

-- Dades de Continents
INSERT INTO Continents (NomContinent) VALUES
	('Europa'),
	('Àsia'),
	('Amèrica'),
	('Àfrica'),
	('Oceania');

-- Dades de Països
INSERT INTO Paisos (NomPais, NomContinent) VALUES
	('Espanya', 'Europa'),
	('França', 'Europa'),
	('Itàlia', 'Europa'),
	('Japó', 'Àsia'),
	('EE.UU.', 'Amèrica');

-- Dades de Ciutats
INSERT INTO Ciutats (NomCiutat, NomPais) VALUES
	('Madrid', 'Espanya'),
	('Barcelona', 'Espanya'),
	('París', 'França'),
	('Roma', 'Itàlia'),
	('Tòquio', 'Japó'),
	('Nova York', 'EE.UU.');

-- Dades de Restaurants
INSERT INTO Restaurants (Nom, NomCiutat, Adresa, CodiPostal, eMail, TelefonContacte, MiniaturaWeb, LinkWeb, GoogleMapsLink, CuinaEspecialitzada) VALUES
	('El Celler de Can Roca', 'Barcelona', 'Carrer de Can Roca, 1', '08001', 'contacte@cellercanroca.com', '934567890', 'imatge.jpg', 'http://cellercanroca.com', 'https://goo.gl/maps/xxxxxx', 'Mediterrània'),
	('Le Bernardin', 'Nova York', '155 W 51st St', '10019', 'contacte@lebernardin.com', '2125551234', 'imatge2.jpg', 'http://lebernardin.com', 'https://goo.gl/maps/yyyyyy', 'Francesa'),
	('Narisawa','Tòquio', 'Minato City, 2 Chome-6-15', '107-0062', 'contacte@narizawa.com', '03-5785-1234', 'imatge3.jpg', 'http://narizawa.com', 'https://goo.gl/maps/zzzzzz', 'Japonesa');

-- Dades de Horaris (corrigiendo `nomRestaurant` a `idRestaurant`)
INSERT INTO Horaris (idRestaurant, diaSetmana, horaObertura, horaTancament) VALUES
    (1, 'dilluns', '12:00', '23:00'),
    (1, 'dimarts', '12:00', '23:00'),
    (2, 'dilluns', '12:00', '22:00'),
    (2, 'dimarts', '12:00', '22:00'),
    (3, 'dilluns', '18:00', '22:00'),
    (3, 'dimarts', '18:00', '22:00');


-- Dades d'Usuaris
INSERT INTO Usuaris (NomUsuari, Correu, Telefon, Contrassenya) VALUES
	('johndoe', 'johndoe@example.com', '123456789', 'contrasenya123'),
	('janedoe', 'janedoe@example.com', '987654321', 'contrasenya456');

-- Dades de Ressenyes
INSERT INTO Resenyes (resenya, valoracio, idUsuari) VALUES
	('Excel·lent restaurant, el menjar és espectacular i el servei és de primera.', 5, 1),
	('Molt bona experiència, tot i que el preu és una mica elevat.', 4, 2);


	-- Dades de Reserves (corrigiendo `NomRestaurant` a `idRestaurant`)
INSERT INTO Reserves (idRestaurant, idUsuari, DataReserva, HoraReserva, NumeroPersones) VALUES
    (1, 1, '2025-01-15', '13:00', 4),
    (2, 2, '2025-01-16', '19:00', 2),
    (3, 1, '2025-01-17', '20:00', 3);

	-- Dades de Categories
INSERT INTO Categories (descripcioCategoria) VALUES
    ('1 Estrella Michelin'),
    ('2 Estrellas Michelin'),
    ('3 Estrellas Michelin'),
    ('Gastronomía Mediterránea'),
    ('Gastronomía Japonesa');

-- Asociar restaurantes con categorías
INSERT INTO RestaurantCategories (idRestaurant, idCategoria) VALUES
    (1, 3), -- El restaurante 1 tiene "3 Estrellas Michelin"
    (1, 4), -- El restaurante 1 también tiene "Gastronomía Mediterránea"
    (2, 3), -- El restaurante 2 tiene "3 Estrellas Michelin"
    (3, 2), -- El restaurante 3 tiene "2 Estrellas Michelin"
    (3, 5); -- El restaurante 3 tiene "Gastronomía Japonesa"
