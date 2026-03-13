-- SISTEMA DE ASISTENCIA ESCOLAR
CREATE DATABASE EscuelaDB
GO
USE EscuelaDB
GO


CREATE TABLE Curso
(
    IdCurso       INT IDENTITY PRIMARY KEY,
    NombreCurso   VARCHAR(100)
)

CREATE TABLE Seccion
(
    IdSeccion     INT IDENTITY PRIMARY KEY,
    NombreSeccion VARCHAR(50),
    IdCurso       INT
)

CREATE TABLE Estudiante
(
    IdEstudiante  INT IDENTITY PRIMARY KEY,
    Matricula     VARCHAR(20) UNIQUE NOT NULL,
    Nombre        VARCHAR(100),
    Apellido      VARCHAR(100),
    IdSeccion     INT
)

CREATE TABLE Asistencia
(
    IdAsistencia  INT IDENTITY PRIMARY KEY,
    IdEstudiante  INT,
    Fecha         DATE,
    Presente      BIT
)

CREATE TABLE Periodo
(
    IdPeriodo     INT IDENTITY PRIMARY KEY,
    NombrePeriodo VARCHAR(50),
    FechaInicio   DATE,
    FechaFin      DATE
)
GO


-- DATOS DE PRUEBA

INSERT INTO Curso (NombreCurso) VALUES
('1ro Bachiller'),
('2do Bachiller'),
('3ro Bachiller'),
('4to Bachiller'),
('5to Bachiller'),
('6to Bachiller')

INSERT INTO Seccion (NombreSeccion, IdCurso) VALUES
('Seccion A', 1),
('Seccion A', 2),
('Seccion A', 3),
('Seccion A', 4),
('Seccion A', 5),
('Seccion A', 6)


INSERT INTO Seccion (NombreSeccion, IdCurso) VALUES
('Seccion B', 1),
('Seccion B', 2),
('Seccion B', 3),
('Seccion B', 4),
('Seccion B', 5),
('Seccion B', 6)

INSERT INTO Estudiante (Matricula, Nombre, Apellido, IdSeccion) VALUES
('2026-001', 'Miguelito',  'Francisco',  1),
('2026-002', 'Maria',      'Jesus',      1),
('2026-003', 'Carlos',     'Federico',   2),
('2026-004', 'Ana',        'Martinez',   2),
('2026-005', 'Pedro',      'Reyes',      3),
('2026-006', 'Laura',      'Sanchez',    3)

INSERT INTO Periodo (NombrePeriodo, FechaInicio, FechaFin) VALUES
('Primer Trimestre 2026', '2026-01-01', '2026-04-30')
GO

CREATE PROC sp_ObtenerEstudiantes
AS
SELECT * FROM Estudiante
GO

CREATE PROC sp_ObtenerCursos
AS
SELECT * FROM Curso
GO

CREATE PROC sp_ObtenerSecciones
@IdCurso INT
AS
SELECT * FROM Seccion WHERE IdCurso = @IdCurso
GO

CREATE PROC sp_ObtenerEstudiantesPorSeccion
@IdSeccion INT
AS
SELECT * FROM Estudiante WHERE IdSeccion = @IdSeccion
GO

CREATE PROC sp_InsertarEstudiante
@Matricula VARCHAR(20), @Nombre VARCHAR(100), @Apellido VARCHAR(100), @IdSeccion INT
AS
INSERT INTO Estudiante (Matricula, Nombre, Apellido, IdSeccion)
VALUES (@Matricula, @Nombre, @Apellido, @IdSeccion)
GO

CREATE PROC sp_EditarEstudiante
@IdEstudiante INT, @Matricula VARCHAR(20), @Nombre VARCHAR(100), @Apellido VARCHAR(100), @IdSeccion INT
AS
UPDATE Estudiante SET Matricula=@Matricula, Nombre=@Nombre, Apellido=@Apellido, IdSeccion=@IdSeccion
WHERE IdEstudiante = @IdEstudiante
GO

CREATE PROC sp_EliminarEstudiante
@IdEstudiante INT
AS
DELETE FROM Asistencia WHERE IdEstudiante = @IdEstudiante
DELETE FROM Estudiante WHERE IdEstudiante = @IdEstudiante
GO

CREATE PROC sp_RegistrarAsistencia
@IdEstudiante INT, @Fecha DATE, @Presente BIT
AS
INSERT INTO Asistencia (IdEstudiante, Fecha, Presente)
VALUES (@IdEstudiante, @Fecha, @Presente)
GO

CREATE PROC sp_RankingInasistencia
AS
SELECT IdEstudiante, COUNT(*) AS Inasistencias
FROM Asistencia WHERE Presente = 0
GROUP BY IdEstudiante
ORDER BY Inasistencias DESC
GO

CREATE PROC sp_AlertaAsistencia80
AS
SELECT IdEstudiante,
COUNT(*) AS TotalClases,
SUM(CASE WHEN Presente = 1 THEN 1 ELSE 0 END) AS Asistencias,
SUM(CASE WHEN Presente = 1 THEN 1 ELSE 0 END) * 100.0 / COUNT(*) AS Porcentaje
FROM Asistencia
GROUP BY IdEstudiante
HAVING SUM(CASE WHEN Presente = 1 THEN 1 ELSE 0 END) * 100.0 / COUNT(*) < 80
GO
