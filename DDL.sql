create database Test
Go
use Test
Go
CREATE TABLE Clients (
    Id INT PRIMARY KEY,
    FirstName NVARCHAR(100) NOT NULL,
    LastName NVARCHAR(100) NOT NULL,
    Age INT NOT NULL,
    CreatedDate DATETIME NOT NULL
);
