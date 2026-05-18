USE master
GO

DROP DATABASE IF EXISTS TennisDb
GO

CREATE DATABASE TennisDb
GO

USE TennisDb
GO

CREATE TABLE TennisRacket
(
	ItemId		int			PRIMARY KEY IDENTITY
	,Weight		tinyint		NOT NULL
	,HeadSize	smallint	NOT NULL
	,Brand		varchar(30) NOT NULL
	,Price		smallmoney	NOT NULL CHECK (Price > 0)
)