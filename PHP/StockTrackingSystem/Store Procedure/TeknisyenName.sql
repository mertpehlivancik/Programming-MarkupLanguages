CREATE DEFINER=`root`@`localhost` PROCEDURE `TeknisyenName`(IN TekID BIGINT)
BEGIN
	select TeknisyenAdi, TeknisyenSoyadi from teknisyen where TeknisyenNo = TekID;
END