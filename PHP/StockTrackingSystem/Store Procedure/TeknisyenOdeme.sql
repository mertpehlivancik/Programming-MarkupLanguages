CREATE DEFINER=`root`@`localhost` PROCEDURE `TeknisyenOdeme`(IN TekNo BIGINT, IN basTarihi datetime, IN bitTarihi datetime)
BEGIN
/*
select s.TeknisyenNo, t.TeknisyenAdi, t.TeknisyenSoyadi, s.MalzemeKodu, m.MalzemeAdi, m.MalzemeKar, s.MalzemeMiktari, s.SatisTarihi, s.MalzemeMiktari*m.MalzemeKar AS VerilecekTutar 
from satis as s, teknisyen as t, malzeme as m 
where s.TeknisyenNo = t.TeknisyenNo AND s.MalzemeKodu = m.MalzemeKodu AND s.TeknisyenNo = 351418878909874 
AND (SatisTarihi BETWEEN '2019-04-07' AND '2019-08-09') GROUP BY s.TeknisyenNo, s.MalzemeKodu, s.FisNo;
*/

select s.TeknisyenNo, t.TeknisyenAdi, t.TeknisyenSoyadi, s.MalzemeKodu, m.MalzemeAdi, s.MalzemeTeknisyenKar, s.MalzemeMiktari, s.SatisTarihi, s.FisNo, s.MalzemeMiktari*s.MalzemeTeknisyenKar AS VerilecekTutar 
from satis as s, teknisyen as t, malzeme as m 
where s.TeknisyenNo = t.TeknisyenNo AND s.MalzemeKodu = m.MalzemeKodu AND s.TeknisyenNo = TekNo 
AND (SatisTarihi BETWEEN basTarihi AND bitTarihi) GROUP BY s.TeknisyenNo, s.MalzemeKodu, s.FisNo;

END