# apiGestores

This api contains the basic functions for a crud application.

This is an excersise taken from the course: https://www.udemy.com/course/full-stack-crud-con-react-js-aspnet-core-y-sql-server/

The course uses .NET Core 3.8, so I made a fewer changes to work with .NET Core 6.0,

Here you have the script for the SQL SERVER database that I Use on the crud excersise:

===============================================================
CREATE DATABASE LocalStuff
GO

USE LocalStuff
GO

CREATE TABLE gestores_bd (id INT NOT NULL IDENTITY PRIMARY KEY, nombre VARCHAR(50) NOT NULL, lanzamiento INT NOT NULL, desarrollador VARCHAR(50) NOT NULL)
GO

INSERT INTO gestores_bd (nombre, lanzamiento, desarrollador) 
VALUES ('Microsoft SQL Server', 1989, 'Microsoft'),
		('MySQL', 1995, 'MySQL, AB, Sun Microsystems and Oracle Corporation'),
		('PostgreSQL', 1996, 'PostgreSQL global'),
		('Oracle Database', 1977, 'Oracle Corporation'),
		('Mongo DB', 2009, 'MongoDB INC.')

===============================================================

The front end part of this project: https://github.com/DanielOsunaV/React-NET-CORE-6-CRUD

we only create a simple Database, a table and we add some values to have information on it.

This is my first CRUD in REACT using a .NET Core 6.0 API, I hope it helps you level up a little your skills, comments and contributions allowed, feel free to text me! 
