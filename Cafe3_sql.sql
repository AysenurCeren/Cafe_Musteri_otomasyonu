create database Cafe3
use Cafe3

CREATE TABLE üyeler (
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

--üyeler tablo girdisi

INSERT INTO üyeler (kullanici, sifre)
VALUES ('ays', '123');




