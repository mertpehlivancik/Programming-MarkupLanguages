CREATE DEFINER=`root`@`localhost` PROCEDURE `TeknisyenSil`(IN TekNo BIGINT)
BEGIN
	DELETE FROM arcelik.teknisyen WHERE TeknisyenNo = TekNo;
END