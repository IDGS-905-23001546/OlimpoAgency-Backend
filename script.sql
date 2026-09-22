IF DB_ID('OlimpoAgencyDB') IS NOT NULL
BEGIN
    ALTER DATABASE OlimpoAgencyDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE OlimpoAgencyDB;
END
GO

CREATE DATABASE OlimpoAgencyDB;
GO

USE OlimpoAgencyDB;
GO

CREATE TABLE Usuarios (
    Id             INT IDENTITY(1,1) PRIMARY KEY,
    Nombre         NVARCHAR(100) NOT NULL,
    Correo         NVARCHAR(150) NOT NULL UNIQUE,
    PasswordHash   NVARCHAR(500) NOT NULL,
    Rol            NVARCHAR(20)  NOT NULL DEFAULT 'cliente'
);
GO

INSERT INTO Usuarios (Nombre, Correo, PasswordHash, Rol) VALUES
('Admin Olimpo', 'admin@olimpo.com', '$2a$11$KI6Z65YYfCTQ13T.eJoJPuz9rtYPe/4wnyXpEvjOVH17Iu7BPscaC', 'admin'),
('Carlos Rios',  'carlos@olimpo.com', '$2a$11$KQn.SyzSDD1d6u8Fb243gOHQ33xAEcbZOoTvVE5C8RFzZZVKUcyvy', 'cliente');
GO

SELECT * FROM Usuarios;
GO