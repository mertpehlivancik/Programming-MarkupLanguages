CREATE DEFINER=`root`@`localhost` PROCEDURE `MalzemeEkle`(IN MalzKodu BIGINT, IN MalzAdi varchar(255), IN MalzFiyat decimal(15,2), IN MalzTekKar decimal(15,2), IN MalzSerKar decimal(15,2))
BEGIN
	SET @a:=0;
    SET @a:=(select 1 from malzeme where MalzemeKodu=MalzKodu);
    
    IF @a IS NULL THEN
		INSERT INTO arcelik.malzeme (MalzemeKodu, MalzemeAdi, MalzemeFiyat, MalzemeTeknisyenKar, MalzemeServisKar) VALUES (MalzKodu, MalzAdi, MalzFiyat, MalzTekKar, MalzSerKar);
	END IF;
END