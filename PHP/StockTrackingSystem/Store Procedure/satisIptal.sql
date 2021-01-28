CREATE DEFINER=`root`@`localhost` PROCEDURE `SatisIptal`(OUT outputt int, IN TeknNo BIGINT, MalzKodu BIGINT, FisID BIGINT)
proc_label:BEGIN
	SET @a := 0;
    SET @b := 0;
    SET @c := 0;
    
    SET @a := (select TeknisyenNo from satis where TeknisyenNo = TeknNo AND MalzemeKodu = MalzKodu AND FisNo = FisID);
    SET @b := (select MalzemeKodu from satis where TeknisyenNo = TeknNo AND MalzemeKodu = MalzKodu AND FisNo = FisID);
    SET @c := (select FisNo from satis where TeknisyenNo = TeknNo AND MalzemeKodu = MalzKodu AND FisNo = FisID);
    
    IF @a IS NULL OR @b IS NULL OR @c IS NULL THEN
		SET outputt := 30; /*İşlem BAŞARISIZ! Böyle bir kayıt yok. Lütfen girdiğiniz bilgileri kontrol ediniz.*/
		select outputt;
        LEAVE proc_label;
    END IF;
    
    IF @a IS NOT NULL AND @b IS NOT NULL AND @c IS NOT NULL THEN
		SET outputt := 20; /*Kayıt Başarıyla Silinmiştir.*/
		select outputt;
		SET @a := 0;
        SET @b := 0;
        SET @c := 0;
        
        SET @a := (select MalzemeMiktari from satis where TeknisyenNo = TeknNo AND MalzemeKodu = MalzKodu AND FisNo = FisID);
        SET @b := (select MusteriAd from musteri where FisNo = FisID);
        SET @c := (select MusteriSoyad from musteri where FisNo = FisID);
        
		INSERT INTO deleted_teknisyen_malzeme (TeknisyenNo, MalzemeKodu, MalzemeStok, FisNo, MusteriAd, MusteriSoyad, Nedeni, IslemTarihi) VALUES (TeknNo, MalzKodu, @a, FisID, @b, @c, 'SatisIptali', NOW());
        CALL TeknisyenZimmetEkle (@output,TeknNo, MalzKodu, (select MalzemeMiktari from satis where TeknisyenNo = TeknNo AND MalzemeKodu = MalzKodu AND FisNo = FisID));
        DELETE FROM satis WHERE TeknisyenNo = TeknNo AND MalzemeKodu = MalzKodu AND FisNo = FisID;
        
        #SET outputt := 20; /*Kayıt Başarıyla Silinmiştir.*/
		#select outputt;
        #LEAVE proc_label;
	
	END IF;
END