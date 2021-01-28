CREATE DEFINER=`root`@`localhost` PROCEDURE `TeknisyenEkle`(IN TekNo BIGINT, IN TekAdi varchar(50), IN TekSoyadi varchar(50))
BEGIN
	SET @a:=0;
    SET @a:=(select 1 from teknisyen where TeknisyenNo=TekNo);
    
    IF @a IS NULL THEN
		INSERT INTO arcelik.teknisyen (TeknisyenNo, TeknisyenAdi, TeknisyenSoyadi) VALUES (TekNo, TekAdi, TekSoyadi);
	END IF;
END