create database [aspnet-Employee];

use [aspnet-Employee];

create table Employee(
id INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
code INT NOT NULL, 
name VARCHAR(80) NOT NULL,
surname VARCHAR(80) NOT NULL,
dateBirthday DATETIME NOT NULL,
address VARCHAR(150) NULL,
phone INT NULL,
position VARCHAR(80) NOT NULL,
salaryBase DECIMAL NOT NULL
);