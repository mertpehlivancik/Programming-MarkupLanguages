CREATE DEFINER=`root`@`localhost` PROCEDURE `TeknisyenZimmetMalzeme`()
BEGIN
	select MalzemeKodu, MalzemeAdi, MalzemeFiyat from malzeme;
END