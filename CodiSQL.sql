CREATE DATABASE ProjecteM6_BBDD;
GO

DROP DATABASE ProjecteM6_BBDD;
GO


USE ProjecteM6_BBDD;
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
    Nom NVARCHAR(60) PRIMARY KEY,
    estrellesMichellin INT,
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

CREATE TABLE Horaris (
    idHorari INT IDENTITY(1,1) PRIMARY KEY,
    nomRestaurant NVARCHAR(60),
    diaSetmana NVARCHAR(20),
    horaObertura TIME,
    horaTancament TIME,
    FOREIGN KEY (nomRestaurant) REFERENCES Restaurants(Nom), 
    CONSTRAINT UNQ_HORARI UNIQUE (nomRestaurant, diaSetmana),
    CONSTRAINT CHK_DiaSetmana CHECK (diaSetmana IN ('dilluns', 'dimarts', 'dimecres', 'dijous', 'divendres', 'dissabte', 'diumenge'))
);



CREATE TABLE GaleriaImatges (
    nomImatge NVARCHAR(60),
	idImatge INT PRIMARY KEY,
    NomRestaurant NVARCHAR(60),
    FOREIGN KEY (NomRestaurant) REFERENCES Restaurants(Nom)
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
	FOREIGN KEY (idUsuari)  REFERENCES Usuaris(idUsuari)

);

CREATE TABLE Reserves (
    IDReserva INT IDENTITY(1,1) PRIMARY KEY,
    NomRestaurant NVARCHAR(60),
    idUsuari INT,
    DataReserva DATE,
    HoraReserva TIME,
    NumeroPersones INT CHECK (NumeroPersones > 0),
    FOREIGN KEY (NomRestaurant) REFERENCES Restaurants(Nom),
    FOREIGN KEY (idUsuari) REFERENCES Usuaris(idUsuari),
	CONSTRAINT UNQ_Reserves UNIQUE (NomRestaurant, DataReserva, HoraReserva),
	CONSTRAINT CK_NumeroPersones CHECK (NumeroPersones BETWEEN 1 AND 20)
);
GO

CREATE TRIGGER TRG_ValidarHorariReserva
ON Reserves
FOR INSERT
AS
BEGIN
    DECLARE @NomRestaurant NVARCHAR(60),
            @HoraReserva TIME,
            @DataReserva DATE,
            @DiaSetmana NVARCHAR(20),
            @HoraApertura TIME,
            @HoraCierre TIME;
    
    SELECT @NomRestaurant = NomRestaurant, 
           @HoraReserva = HoraReserva, 
           @DataReserva = DataReserva
    FROM INSERTED;
    
    SET @DiaSetmana = DATENAME(weekday, @DataReserva);
    
    SELECT @HoraApertura = horaObertura, @HoraCierre = horaTancament
    FROM Horaris
    WHERE nomRestaurant = @NomRestaurant 
      AND diaSetmana = @DiaSetmana;

    IF @HoraReserva < @HoraApertura OR @HoraReserva > @HoraCierre
    BEGIN
        RAISERROR('La reserva no se puede realizar fuera del horario del restaurante.', 16, 1);
        ROLLBACK TRANSACTION; 
    END
END

GO


-- Datos de Continentes
INSERT INTO Continents (NomContinent) VALUES
('Europa'),
('Asia'),
('América'),
('África'),
('Oceanía');

-- Datos de Países
INSERT INTO Paisos (NomPais, NomContinent) VALUES
('España', 'Europa'),
('Francia', 'Europa'),
('Italia', 'Europa'),
('Japón', 'Asia'),
('EE.UU.', 'América');

-- Datos de Ciudades
INSERT INTO Ciutats (NomCiutat, NomPais) VALUES
('Madrid', 'España'),
('Barcelona', 'España'),
('París', 'Francia'),
('Roma', 'Italia'),
('Tokio', 'Japón'),
('Nueva York', 'EE.UU.');

-- Datos de Restaurantes
INSERT INTO Restaurants (Nom, estrellesMichellin, NomCiutat, Adresa, CodiPostal, eMail, TelefonContacte, MiniaturaWeb, LinkWeb, GoogleMapsLink, CuinaEspecialitzada) VALUES
('El Celler de Can Roca', 3, 'Barcelona', 'Carrer de Can Roca, 1', '08001', 'contacto@cellercanroca.com', '934567890', 'imagen.jpg', 'http://cellercanroca.com', 'https://goo.gl/maps/xxxxxx', 'Mediterránea'),
('Le Bernardin', 3, 'Nueva York', '155 W 51st St', '10019', 'contacto@lebernardin.com', '2125551234', 'imagen2.jpg', 'http://lebernardin.com', 'https://goo.gl/maps/yyyyyy', 'Francesa'),
('Narisawa', 2, 'Tokio', 'Minato City, 2 Chome-6-15', '107-0062', 'contacto@narizawa.com', '03-5785-1234', 'imagen3.jpg', 'http://narizawa.com', 'https://goo.gl/maps/zzzzzz', 'Japonesa');

-- Datos de Horarios
INSERT INTO Horaris (nomRestaurant, diaSetmana, horaObertura, horaTancament) VALUES
('El Celler de Can Roca', 'dilluns', '12:00', '23:00'),
('El Celler de Can Roca', 'dimarts', '12:00', '23:00'),
('Le Bernardin', 'dilluns', '12:00', '22:00'),
('Le Bernardin', 'dimarts', '12:00', '22:00'),
('Narisawa', 'dilluns', '18:00', '22:00'),
('Narisawa', 'dimarts', '18:00', '22:00');

-- Datos de Usuarios
INSERT INTO Usuaris (NomUsuari, Correu, Telefon, Contrassenya) VALUES
('johndoe', 'johndoe@example.com', '123456789', 'contraseña123'),
('janedoe', 'janedoe@example.com', '987654321', 'contraseña456');

-- Datos de Reseñas
INSERT INTO Resenyes (resenya, valoracio, idUsuari) VALUES
('Excelente restaurante, la comida es espectacular y el servicio es de primera.', 5, 1),
('Muy buena experiencia, aunque el precio es algo elevado.', 4, 2);

-- Datos de Reservas
INSERT INTO Reserves (NomRestaurant, idUsuari, DataReserva, HoraReserva, NumeroPersones) VALUES
('El Celler de Can Roca', 1, '2025-01-15', '13:00', 4),
('Le Bernardin', 2, '2025-01-16', '19:00', 2),
('Narisawa', 1, '2025-01-17', '20:00', 3);

