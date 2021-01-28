CREATE DEFINER=`root`@`localhost` PROCEDURE `OdemeToplam`(IN basTarihi datetime, IN bitTarihi datetime)
BEGIN
	select s.TeknisyenNo, t.TeknisyenAdi, t.TeknisyenSoyadi, s.MalzemeKodu, m.MalzemeAdi, s.MalzemeTeknisyenKar, s.MalzemeMiktari, s.SatisTarihi, s.FisNo, s.MalzemeMiktari * s.MalzemeTeknisyenKar AS VerilecekTutar 
	from satis as s, teknisyen as t, malzeme as m 
	where s.TeknisyenNo = t.TeknisyenNo AND s.MalzemeKodu = m.MalzemeKodu 
	AND (SatisTarihi BETWEEN basTarihi AND bitTarihi) GROUP BY s.TeknisyenNo, s.MalzemeKodu, s.FisNo;
END