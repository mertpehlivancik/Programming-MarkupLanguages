CREATE DEFINER=`root`@`localhost` PROCEDURE `satis`(OUT output int, IN TekNo BIGINT, IN MalzKodu BIGINT, IN FisID BIGINT, MusAd varchar(50), IN MusSoyad varchar(50), IN MalzMiktari int, IN SatisTar datetime)
proc_label:BEGIN
	SET @a := 0;
    SET @b := 1;
    SET @c := 0;
	SET @a := (select 1 from teknisyen_malzeme where TeknisyenNo = TekNo AND MalzemeKodu = MalzKodu);
	SET @b := (select 0 from satis where TeknisyenNo = TekNo AND MalzemeKodu = MalzKodu AND FisNo = FisID);
    SET @bas := (select count(TeknisyenNo) from satis);
    
    IF @bas=0 THEN
		INSERT INTO satis (TeknisyenNo, MalzemeKodu, FisNo, MalzemeFiyat, MalzemeTeknisyenKar, MalzemeServisKar, MalzemeMiktari, SatisTarihi, IslemTarihi) VALUES (0, 0, 0, 0, 0, 0, 0, NOW(), NOW());
    END IF;
    
    IF @a IS NULL THEN
		SET output := 30; /*Teknisyenin üzerine bu malzeme hiç zimmetlenmemiştir.*/
		select output;
        LEAVE proc_label;
    END IF;
    
    IF @b=0 THEN
		SET output := 40; /*Girilen fiş numarasına aynı teknisyen aynı malzemeyi daha önceden satmıştır.*/
		select output;
        LEAVE proc_label;
	END IF;
    
	IF @a=1 AND @b IS NULL THEN
		SET @c := (select MalzemeStok from teknisyen_malzeme where TeknisyenNo = TekNo AND MalzemeKodu = MalzKodu);
		IF @c<MalzMiktari THEN
			SET output := 50; /*Satış yapmak için teknisyenin üzerinde yeterli zimmetli malzeme bulunmamaktadır.*/
			select output;
			LEAVE proc_label;
		END IF;
        IF @c >= MalzMiktari THEN
			CALL MusteriEkle(FisID, MusAd, MusSoyad);
    
			SET @MalzFiyat := 0.0;
            SET @MalzTekKar := 0.0;
			SET @MalzServKar := 0.0;
            
			SET @MalzFiyat := (select DISTINCT(m.MalzemeFiyat) from malzeme as m, satis as s where m.MalzemeKodu = MalzKodu);
            SET @MalzTekKar := (select DISTINCT(m.MalzemeTeknisyenKar) from malzeme as m, satis as s where m.MalzemeKodu = MalzKodu);
            SET @MalzServKar := (select DISTINCT(m.MalzemeServisKar) from malzeme as m, satis as s where m.MalzemeKodu = MalzKodu);
            
            #SET @MalzFiyat := (select DISTINCT(m.MalzemeFiyat) from malzeme as m inner join satis as s on m.MalzemeKodu = MalzKodu LIMIT 1);
            #SET @MalzTekKar := (select DISTINCT(m.MalzemeTeknisyenKar) from malzeme as m inner join satis as s on m.MalzemeKodu = MalzKodu LIMIT 1);
            #SET @MalzServKar := (select DISTINCT(m.MalzemeServisKar) from malzeme as m inner join satis as s on m.MalzemeKodu = MalzKodu LIMIT 1);
            
			INSERT INTO satis (TeknisyenNo, MalzemeKodu, FisNo, MalzemeFiyat, MalzemeTeknisyenKar, MalzemeServisKar, MalzemeMiktari, SatisTarihi, IslemTarihi) VALUES (TekNo, MalzKodu, FisID, @MalzFiyat, @MalzTekKar, @MalzServKar, MalzMiktari, SatisTar, NOW());
            
			#INSERT INTO satis (TeknisyenNo, MalzemeKodu, FisNo, MalzemeFiyat, MalzemeTeknisyenKar, MalzemeServisKar, MalzemeMiktari, SatisTarihi, IslemTarihi) VALUES (TekNo, MalzKodu, FisID, MalzFiyat, MalzTekKar, MalzServKar, MalzMiktari, SatisTar, NOW());

			SET @sil := (select 1 from satis where TeknisyenNo=0 AND MalzemeKodu=0 AND FisNo=0);
            
            IF @sil=1 THEN
				DELETE FROM satis WHERE TeknisyenNo=0 AND MalzemeKodu=0 AND FisNo=0;
            END IF;
            
            #INSERT INTO satis SET TeknisyenNo=TekNo, MalzemeKodu=MalzKodu, FisNo=FisID, MalzemeFiyat= @MalzFiyat, MalzemeTeknisyenKar=@MalzTekKar, MalzemeServisKar=@MalzServKar, MalzemeMiktari=MalzMiktari, SatisTarihi=SatisTar, IslemTarihi=NOW();
            
			INSERT INTO Deleted_Teknisyen_Malzeme (TeknisyenNo, MalzemeKodu, MalzemeStok, FisNo, MusteriAd, MusteriSoyad, Nedeni, IslemTarihi) VALUES (TekNo, MalzKodu, MalzMiktari, FisID, MusAd, MusSoyad, "satis", NOW());
			UPDATE teknisyen_malzeme SET MalzemeStok = MalzemeStok - MalzMiktari where MalzemeKodu = MalzKodu AND TeknisyenNo = TekNo;
            UPDATE teknisyen_malzeme SET IslemTarihi = (select IslemTarihi from satis where TeknisyenNo = TekNo AND MalzemeKodu = MalzKodu AND FisNo = FisID)  where MalzemeKodu = MalzKodu AND TeknisyenNo = TekNo;
            SET output := 20; /*Satış başarıyla gerçekleştirilmiştir.*/
			select output; 
        END IF;		
	END IF;
END