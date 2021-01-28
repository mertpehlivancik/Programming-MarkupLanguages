CREATE DEFINER=`root`@`localhost` PROCEDURE `MusteriEkle`(IN FisID BIGINT, MusAd varchar(50), MusSoyad varchar(50))
BEGIN
	SET @a := 1;
    SET @a := (select 0 from musteri where FisNo = FisID);
    
    IF @a IS NULL THEN
		INSERT INTO musteri (FisNo, MusteriAd, MusteriSoyad) VALUES (FisID, MusAd, MusSoyad);
	END IF;
END