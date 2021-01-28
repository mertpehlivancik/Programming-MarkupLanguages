CREATE DEFINER=`root`@`localhost` PROCEDURE `showSatisMalzNo`(IN MalzKodu BIGINT)
BEGIN
	select s.TeknisyenNo, t.TeknisyenAdi, t.TeknisyenSoyadi, s.MalzemeKodu, mal.MalzemeAdi, s.MalzemeMiktari, s.FisNo, mus.MusteriAd, mus.MusteriSoyad, s.SatisTarihi, s.IslemTarihi 
    from teknisyen as t, malzeme as mal, musteri as mus, satis as s 
    where t.TeknisyenNo = s.TeknisyenNo AND mal.MalzemeKodu = s.MalzemeKodu AND mus.FisNo = s.FisNo AND s.MalzemeKodu = MalzKodu ORDER BY s.IslemTarihi DESC;
END