create database Cafe3
use Cafe3

CREATE TABLE �yeler (
    idkullanici INT PRIMARY KEY IDENTITY,
    kullanici nchar(20),
    sifre nchar(20),
);
CREATE TABLE satis (
    idsatis INT PRIMARY KEY IDENTITY,
    ad VARCHAR(255),
    kart_numarasi BIGINT,
    son_tarih DATE
);

--�yeler tablo girdisi

INSERT INTO �yeler (kullanici, sifre)
VALUES ('ays', '123');




