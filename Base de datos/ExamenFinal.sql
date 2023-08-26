create database ExamenEncuestas

use ExamenEncuestas
-- Creación de Tablas
CREATE TABLE Encuestas (
    Numero INT IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
	Genero NVARCHAR(1) CHECK (Genero IN ('M', 'F', 'O')),
    Edad INT CHECK (Edad >= 18 AND Edad <= 50),
    CorreoElectronico VARCHAR(100) UNIQUE CHECK (CorreoElectronico LIKE '%_@__%.__%'),
    PartidoPolitico NVARCHAR(50) NOT NULL
	constraint pk_numero primary key (numero)
);

CREATE TABLE Bitacora (
    BitacoraID INT IDENTITY(1,1) PRIMARY KEY,
    Accion NVARCHAR(100) NOT NULL,
    FechaRegistro DATETIME DEFAULT GETDATE(),
    Detalles NVARCHAR(MAX)
);

-- Creación de Procedimientos Almacenados
CREATE PROCEDURE Sp_Encuesta
	@Operacion int = 0,
	@Numero int = 0,
    @Nombre NVARCHAR(100) = '',
	@Genero NVARCHAR(1) = '',
    @Edad INT = 0,
    @CorreoElectronico NVARCHAR(100) = '',
    @PartidoPolitico NVARCHAR(50) =''
AS
BEGIN
	if @Operacion = 1
	begin
		INSERT INTO Encuestas (Nombre,Genero, Edad, CorreoElectronico, PartidoPolitico)
		VALUES (@Nombre,@Genero, @Edad, @CorreoElectronico, @PartidoPolitico);
	end
	Else if @Operacion = 2
	begin
		SELECT * FROM Encuestas;
	end
	Else if @Operacion = 3
	begin
		SELECT * FROM Bitacora;
	end
END;

exec Sp_Encuesta 1,0,'Andrea','F',50,'Andre@gmail.com','PAC'

exec Sp_Encuesta 2
exec Sp_Encuesta 3



-- Creación de Trigger
create TRIGGER CrearBitacoraEncuesta
ON Encuestas
AFTER INSERT
AS
BEGIN
    DECLARE @Nombre NVARCHAR(100);
    SELECT @Nombre = Nombre FROM INSERTED;

    INSERT INTO Bitacora (Accion, Detalles)
    VALUES ('Nuevo intento encontrado.', CONCAT('Encuesta de ', @Nombre, ' agregada'));
END;

CREATE PROCEDURE MenuReportes
    @TipoReporte INT
AS
BEGIN
    IF @TipoReporte = 1
    BEGIN
        -- Reporte: Cantidad total de encuestas realizadas
        SELECT COUNT(*) AS CantidadEncuestas FROM Encuestas;
    END
    ELSE IF @TipoReporte = 2
    BEGIN
        -- Reporte: Cantidad de personas masculinas y femeninas
        SELECT
            (SELECT COUNT(*) FROM Encuestas WHERE Genero = 'M') AS CantidadMasculinos,
            (SELECT COUNT(*) FROM Encuestas WHERE Genero = 'F') AS CantidadFemeninos;
    END
END

exec MenuReportes 2