CREATE DATABASE buttons_db;
GO

USE buttons_db;
GO

CREATE TABLE buttons (
    button_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    button_count INT NULL
);
GO
