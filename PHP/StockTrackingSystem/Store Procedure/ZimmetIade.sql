CREATE DEFINER=`root`@`localhost` PROCEDURE `ZimmetIade`(OUT output int, IN TeknNo BIGINT, IN MalzKodu BIGINT, IN MalzStok int)
proc_label:BEGIN
    SET @a := (select MalzemeStok from teknisyen_malzeme where TeknisyenNo = TeknNo AND MalzemeKodu = MalzKodu);
    
    IF @a IS NULL THEN
		SET output := 10; /*Böyle bir malzeme bulunamadı.*/
		select output;
        LEAVE proc_label;
	END IF;
    
	IF @a < MalzStok THEN
		SET output := 30; /*Teknisyenin üzerindeki malzeme miktarı iade etmek istediğiniz malzeme miktarından daha AZ!*/
		select output;
        LEAVE proc_label;
	END IF;
    
    IF @a >= MalzStok THEN
		INSERT INTO Deleted_Teknisyen_Malzeme(TeknisyenNo, MalzemeKodu, MalzemeStok, FisNo, MusteriAd, MusteriSoyad, Nedeni, IslemTarihi) VALUES (TeknNo, MalzKodu, MalzStok, NULL, NULL, NULL, 'Iade', NOW());
		UPDATE teknisyen_malzeme SET MalzemeStok = MalzemeStok - MalzStok WHERE TeknisyenNo = TeknNo AND MalzemeKodu = MalzKodu;
        UPDATE teknisyen_malzeme SET IslemTarihi = NOW() WHERE TeknisyenNo = TeknNo AND MalzemeKodu = MalzKodu;
        SET output := 20; /*İade işlemi başarıyla tamamlandı.*/
		select output;
        LEAVE proc_label;
	END IF;
END