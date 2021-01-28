#DROP DATABASE arcelik
#create database arcelik;

DROP TABLE teknisyen;
DROP TABLE malzeme;
DROP TABLE musteri;
DROP TABLE teknisyen_malzeme;
DROP TABLE satis;
DROP TABLE Deleted_Teknisyen_Malzeme;

create table Teknisyen (
	TeknisyenNo BIGINT NOT NULL,
    TeknisyenAdi varchar(50) NOT NULL,
    TeknisyenSoyadi varchar(50) NOT NULL,
    
    CONSTRAINT PK_Teknisyen PRIMARY KEY Teknisyen(TeknisyenNo)
);

create table Malzeme (
	MalzemeKodu BIGINT NOT NULL,
    MalzemeAdi varchar(255),
    MalzemeFiyat decimal(15,2),
    MalzemeTeknisyenKar decimal(15,2),
    MalzemeServisKar decimal(15,2),
    
    CONSTRAINT PK_Malzeme PRIMARY KEY Malzeme(MalzemeKodu)
);

create table Musteri (
	FisNo BIGINT NOT NULL,
    MusteriAd varchar(50),
    MusteriSoyad varchar(50),
    
    CONSTRAINT PK_Musteri PRIMARY KEY Musteri(FisNo)
);

create table Teknisyen_Malzeme (
	TeknisyenNo BIGINT NOT NULL,
    MalzemeKodu BIGINT NOT NULL,
    MalzemeStok int NOT NULL,
    IslemTarihi datetime NOT NULL,
    
    CONSTRAINT PK_TeknisyenMalzeme PRIMARY KEY Teknisyen_Malzeme(TeknisyenNo,MalzemeKodu),
    CONSTRAINT FK_TeknisyenMalzeme FOREIGN KEY (TeknisyenNo) REFERENCES Teknisyen(TeknisyenNo),
    CONSTRAINT FK2_TeknisyenMalzeme FOREIGN KEY (MalzemeKodu) REFERENCES Malzeme(MalzemeKodu)
);

create table Satis (
	TeknisyenNo BIGINT NOT NULL,
    MalzemeKodu BIGINT NOT NULL,
    FisNo BIGINT NOT NULL,
    MalzemeFiyat decimal(15,2),
    MalzemeTeknisyenKar decimal(15,2),
    MalzemeServisKar decimal(15,2),
    MalzemeMiktari int NOT NULL,
    SatisTarihi datetime,
    IslemTarihi datetime,

	CONSTRAINT PK_Satis PRIMARY KEY Satis(TeknisyenNo,MalzemeKodu,FisNo),
    CONSTRAINT FK_Satis FOREIGN KEY (TeknisyenNo) REFERENCES Teknisyen_Malzeme(TeknisyenNo),
    CONSTRAINT FK_Satis2 FOREIGN KEY (MalzemeKodu) REFERENCES Teknisyen_Malzeme(MalzemeKodu),
    CONSTRAINT FK_Satis3 FOREIGN KEY (FisNo) REFERENCES Musteri(FisNo)
);

create table Deleted_Teknisyen_Malzeme (
	TeknisyenNo BIGINT NOT NULL,
    MalzemeKodu BIGINT NOT NULL,
    MalzemeStok int NOT NULL,
    FisNo BIGINT NULL,
    MusteriAd varchar(50) NULL,
    MusteriSoyad varchar(50) NULL,
    Nedeni varchar(50) NULL,
    IslemTarihi datetime NOT NULL
);





