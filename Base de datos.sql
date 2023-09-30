Create database FG100220_FA100620

USE FG100220_FA100620

Create table elecciones_2019(
id int Primary Key Identity(1,1) not null,
departamento varchar(50),
candidato varchar(50),
votos int
)

INSERT INTO [elecciones_2019] ([departamento], [candidato], [votos]) VALUES
('Ahuachap�n', 'Nayib Bukele', 117231),
('Ahuachap�n', 'Carlos Calleja', 50392),
('Ahuachap�n', 'Hugo Mart�nez', 27776),
('Ahuachap�n', 'Otros', 19481),
('Caba�as', 'Nayib Bukele', 48514),
('Caba�as', 'Carlos Calleja', 22804),
('Caba�as', 'Hugo Mart�nez', 14520),
('Caba�as', 'Otros', 10989),
('Chalatenango', 'Nayib Bukele', 58488),
('Chalatenango', 'Carlos Calleja', 25729),
('Chalatenango', 'Hugo Mart�nez', 17201),
('Chalatenango', 'Otros', 15550),
('La Libertad', 'Nayib Bukele', 250573),
('La Libertad', 'Carlos Calleja', 100126),
('La Libertad', 'Hugo Mart�nez', 53661),
('La Libertad', 'Otros', 96788),
('Moraz�n', 'Nayib Bukele', 54991),
('Moraz�n', 'Carlos Calleja', 23840),
('Moraz�n', 'Hugo Mart�nez', 14634),
('Moraz�n', 'Otros', 16517),
('San Miguel', 'Nayib Bukele', 190873),
('San Miguel', 'Carlos Calleja', 75285),
('San Miguel', 'Hugo Mart�nez', 41463),
('San Miguel', 'Otros', 74125),
('San Salvador', 'Nayib Bukele', 375745),
('San Salvador', 'Carlos Calleja', 144389),
('San Salvador', 'Hugo Mart�nez', 80278),
('San Salvador', 'Otros', 150078),
('Santa Ana', 'Nayib Bukele', 133774),
('Santa Ana', 'Carlos Calleja', 54159),
('Santa Ana', 'Hugo Mart�nez', 29518),
('Santa Ana', 'Otros', 49097),
('Sonsonate', 'Nayib Bukele', 102641),
('Sonsonate', 'Carlos Calleja', 41207),
('Sonsonate', 'Hugo Mart�nez', 22149),
('Sonsonate', 'Otros', 39285),
('Cuscatl�n', 'Nayib Bukele', 121.318),
('Cuscatl�n', 'Carlos Calleja', 47.067),
('Cuscatl�n', 'Hugo Mart�nez', 26.302),
('Cuscatl�n', 'Otros', 18.343),
('Usulut�n', 'Nayib Bukele', 104.712),
('Usulut�n', 'Carlos Calleja', 42.934),
('Usulut�n', 'Hugo Mart�nez', 25.749),
('Usulut�n', 'Otros', 26.605),
('La Paz', 'Nayib Bukele', 93.179),
('La Paz', 'Carlos Calleja', 37.617),
('La Paz', 'Hugo Mart�nez', 22.783),
('La Paz', 'Otros', 26.421); 

CREATE VIEW VistaElecciones2019 AS
SELECT
 [candidato],
 SUM([votos]) AS CantidadDeVotos,
 CAST(SUM([votos]) * 100.0 / SUM(SUM([votos])) OVER () AS DECIMAL(10, 2)) AS Porcentaje
FROM
 elecciones_2019
GROUP BY
 [candidato]


 SELECT * FROM VistaElecciones2019;