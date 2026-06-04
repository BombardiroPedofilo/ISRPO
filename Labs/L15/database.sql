CREATE DATABASE SnakeGameDB;
GO

USE SnakeGameDB;
GO

CREATE TABLE GameResults (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    PlayerName NVARCHAR(50) NOT NULL,
    Score INT NOT NULL,
    GameDuration INT NOT NULL,   -- длительность в секундах
    GameDate DATETIME NOT NULL DEFAULT GETDATE()
);
GO