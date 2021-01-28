CREATE DEFINER=`root`@`localhost` PROCEDURE `TeknisyenZimmetEkle`(IN output int, IN tekID BIGINT, IN MalzKodu BIGINT, IN MalzStok int)
proc_label:BEGIN
	SET @a := 0;
    SET @b := 0;
    SET @c := 0;
    SET @d := 0;
    SET @e := 0;
    
	SET @a := (select TeknisyenNo from teknisyen where TeknisyenNo = tekID);
    SET @b := (select MalzemeKodu from malzeme where MalzemeKodu = MalzKodu);
    SET @c := (select TeknisyenNo from teknisyen_malzeme where TeknisyenNo = tekID AND MalzemeKodu = MalzKodu);
    SET @e := (select MalzemeStok from teknisyen_malzeme where MalzemeKodu = MalzKodu AND TeknisyenNo = tekID);

	IF @a IS NULL THEN
		SET output := 10; /*Böyle bir teknisyen bulunamadı.*/
		select output;
        LEAVE proc_label;
	END IF;
    
    IF @b IS NULL THEN
		SET output := 30; /*Böyle bir malzeme bulunamadı.*/
		select output;
        LEAVE proc_label;
	END IF;    
    
    IF @c IS NULL THEN
		SET @d := 1;
    END IF;
	
    IF @a!=0 AND @b!=0 AND @d=1 THEN
			INSERT INTO teknisyen_malzeme (TeknisyenNo, MalzemeKodu, MalzemeStok, IslemTarihi) VALUES (tekID, MalzKodu, MalzStok, NOW());
            SET output := 20; /*Teknisyene malzeme başarıyla zimmetlendi.*/
			select output;
			LEAVE proc_label;
	END IF;
	
    IF @e IS NOT NULL THEN
		SET @e := @e + MalzStok;
		UPDATE teknisyen_malzeme
		SET MalzemeStok = @e
        WHERE MalzemeKodu = MalzKodu AND TeknisyenNo = tekID;
        SET output := 25; /*Malzeme stoğu başarıyla güncellendi.*/
		select output;
        LEAVE proc_label;
	END IF;

END