CREATE DEFINER=`root`@`localhost` PROCEDURE `MalzemeSil`(IN MalzKodu BIGINT)
BEGIN
	DELETE FROM arcelik.malzeme WHERE MalzemeKodu = MalzKodu;
END