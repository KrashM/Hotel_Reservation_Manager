IF DB_ID('Reception') IS NULL
	create database Reception;
GO
use Reception;

IF object_id('Users') IS NULL
    CREATE TABLE Users(id uniqueidentifier NOT NULL PRIMARY KEY, 
                      username VARCHAR(25) NOT NULL,
                      password VARCHAR(30) NOT NULL,
                      name VARCHAR(20) NOT NULL,
                      middle_name VARCHAR(20) NOT NULL,
                      sir_name VARCHAR(20) NOT NULL,
                      personal_id VARCHAR(10) NOT NULL,
                      phone_number VARCHAR(13) NOT NULL,
                      email VARCHAR(50) NOT NULL,
                      date_of_appointment DATE NOT NULL,
                      active BIT NOT NULL,
                      date_of_dismissal DATE  NOT NULL,
                      administrator BIT NOT NULL)

IF object_id('Clients') IS NULL
    CREATE TABLE Clients(id uniqueidentifier NOT NULL PRIMARY KEY,
                        name VARCHAR(20) NOT NULL,
                        sir_name VARCHAR(20) NOT NULL,
                        phone_number VARCHAR(13) NOT NULL,
                        email VARCHAR(50) NOT NULL,
                        adult BIT NOT NULL)

IF object_id('Rooms') IS NULL
    CREATE TABLE Rooms(id uniqueidentifier NOT NULL PRIMARY KEY,
                    capacity INT NOT NULL,
                    type VARCHAR(20) NOT NULL,
                    price_for_bed_adult FLOAT NOT NULL,
                    price_for_bed_child FLOAT NOT NULL,
                    number int NOT NULL)

IF object_id('Reservations') IS NULL
    CREATE TABLE Reservations(id uniqueidentifier NOT NULL PRIMARY KEY,
                            room_number INT NOT NULL,
                            id_of_appointer uniqueidentifier FOREIGN KEY(id_of_appointer) REFERENCES Users(id),
                            -- Спицък с клинтите, които ще се помещават в стаята?
                            date_of_accommodation DATE NOT NULL,
                            release_date DATE NOT NULL,
                            breakfast BIT NOT NULL,
                            all_inclusive BIT NOT NULL,
                            price FLOAT NOT NULL)