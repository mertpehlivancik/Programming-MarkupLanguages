<!DOCTYPE html>
<html lang="en">
<head>
  <title>SATIŞ</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
</head>

<?php
include("kullanici.php");
session_start();
if(isset($_SESSION["hanife"]) == false && isset($_SESSION["engin"]) == false && isset($_SESSION["serhat"]) == false){
    echo "<script type='text/javascript'>alert(\"Bu sayfayı görüntüleme yetkiniz yoktur.\");</script>";
    if(session_destroy())
    {
        header("Location: index.php");
    }
}else{
    if (isset($_SESSION["engin"]) == true){
        echo "<nav class='navbar navbar-expand-lg navbar-light bg-light'>";
        echo "<a class='navbar-brand' href='#'>Arçelik</a>";
        echo "<button class='navbar-toggler' type='button' data-toggle='collapse' data-target='#navbarNav' aria-controls='navbarNav' aria-expanded='false' aria-label='Toggle navigation'>";
        echo "<span class='navbar-toggler-icon'></span>";
        echo "</button>";
        echo "<div class='collapse navbar-collapse' id='navbarNav'>";
        echo "<ul class='navbar-nav'>";
        echo "<li class='nav-item active'>";
        echo "<a class='nav-link'href='anasayfa.php'>Anasayfa <span class='sr-only'>(current)</span></a>";
        echo "</li>";
        echo "<li class='nav-item'>";
        echo "<a class='nav-link' href='teknisyen.php'>Teknisyen</a>";
        echo "</li>";
        echo "<li class='nav-item'>";
        echo "<a class='nav-link' href='malzeme.php'>Malzeme</a>";
        echo "</li>";
        echo "<li class='nav-item'>";
        echo "<a class='nav-link' href='zimmet.php'>Malzeme Zimmet</a>";
        echo "</li>";
        echo "<li class='nav-item'>";
        echo "<a class='nav-link' href='satis.php'>Satış</a>";
        echo "</li>";
        echo "<li class='nav-item'>";
        echo "<a class='nav-link' href='logout.php'>Çıkış</a>";
        echo "</li>";
        echo "</ul>";
        echo "</div>";
        echo "</nav>";
    }else if(isset($_SESSION["serhat"]) == true){
        echo "<nav class='navbar navbar-expand-lg navbar-light bg-light'>";
        echo "<a class='navbar-brand' href='#'>Arçelik</a>";
        echo "<button class='navbar-toggler' type='button' data-toggle='collapse' data-target='#navbarNav' aria-controls='navbarNav' aria-expanded='false' aria-label='Toggle navigation'>";
        echo "<span class='navbar-toggler-icon'></span>";
        echo "</button>";
        echo "<div class='collapse navbar-collapse' id='navbarNav'>";
        echo "<ul class='navbar-nav'>";
        echo "<li class='nav-item'>";
        echo "<a class='nav-link' href='zimmet.php'>Malzeme Zimmet</a>";
        echo "</li>";
        echo "<li class='nav-item'>";
        echo "<a class='nav-link' href='satis.php'>Satış</a>";
        echo "</li>";
        echo "<li class='nav-item'>";
        echo "<a class='nav-link' href='logout.php'>Çıkış</a>";
        echo "</li>";
        echo "</ul>";
        echo "</div>";
        echo "</nav>";
    }else{
        echo "<nav class='navbar navbar-expand-lg navbar-light bg-light'>";
        echo "<a class='navbar-brand' href='#'>Arçelik</a>";
        echo "<button class='navbar-toggler' type='button' data-toggle='collapse' data-target='#navbarNav' aria-controls='navbarNav' aria-expanded='false' aria-label='Toggle navigation'>";
        echo "<span class='navbar-toggler-icon'></span>";
        echo "</button>";
        echo "<div class='collapse navbar-collapse' id='navbarNav'>";
        echo "<ul class='navbar-nav'>";
        echo "</li>";
        echo "<li class='nav-item'>";
        echo "<a class='nav-link' href='logout.php'>Çıkış</a>";
        echo "</li>";
        echo "</ul>";
        echo "</div>";
        echo "</nav>";
    }
}
?>

<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $TekNo = $MalzKodu = $FisID = $MusAd = $MusSoyad = $MalzMiktari = $SatisTar = "";
    $TekNo = test_input($_POST["TekNo"]);
    $MalzKodu = test_input($_POST["MalzKodu"]);
    $FisID = test_input($_POST["FisID"]);
    $MusAd = test_input($_POST["MusAd"]);
    $MusSoyad = test_input($_POST["MusSoyad"]);
    $MalzMiktari = test_input($_POST["MalzMiktari"]);
    $SatisTar = test_input($_POST["SatisTar"]);
    

    
        function Tekns($TekNo) {
            $mysqli = new mysqli("localhost:3308", "root", "password", "arcelik");
            if ($mysqli->connect_errno) {
                echo "Failed to connect to MySQL: (" . $mysqli->connect_errno . ") " . $mysqli->connect_error;
            }
            if ($mysqli->multi_query("CALL TeknisyenName($TekNo);")){
                
                /* store first result set */
                if ($result = $mysqli->store_result()) {
                    while ($row = $result->fetch_row()) {
                        //                 echo $row[0]."\n";
                        //                 echo $row[1]."\n";
                        $nameSurname = "Teknisyen:"." ".$row[0]." ".$row[1];
                        echo "<script type='text/javascript'>alert(\"$nameSurname\");</script>";
                        //                             echo '<script type="text/javascript">alert("hello!");</script>';
                    };
                    $result->free();
                }
            }
            /* close connection */
            $mysqli->close();
            //                 echo "<script type='text/javascript'>alert('$nameSurname');</script>";
        }
        
        if(isset($_POST['addSatis'])) {
            if (is_numeric($TekNo) && is_numeric($MalzKodu) && is_numeric($FisID) && is_numeric($MalzMiktari) && is_string($MusAd) && is_string($MusSoyad)) {
                $mysqli = new mysqli("localhost:3308", "root", "password", "arcelik");
                if ($mysqli->connect_errno) {
                    echo "Failed to connect to MySQL: (" . $mysqli->connect_errno . ") " . $mysqli->connect_error;
                }
                if ($TekNo && $MalzKodu && $FisID && $MusAd && $MusSoyad && $MalzMiktari && $SatisTar != ""){
                    $mysqli->multi_query("CALL satis(@output,$TekNo,$MalzKodu,$FisID,'$MusAd','$MusSoyad',$MalzMiktari,'$SatisTar');");
                    $result = $mysqli->store_result();
                    if (!is_object($result)) {
                        echo $mysqli->error;
                    }else{
                        $row = $result->fetch_row();
                        if ($row[0] == 20){
                            Tekns($TekNo);
                            echo "<script type='text/javascript'>alert(\"Satış başarıyla gerçekleştirilmiştir.\");</script>";
                        }else if ($row[0] == 30) {
                            echo "<script type='text/javascript'>alert(\"Satış eklenemedi. Teknisyenin üzerine bu malzeme daha önce HİÇ zimmetlenmemiştir.\");</script>";
                        }else if ($row[0] == 40) {
                            echo "<script type='text/javascript'>alert(\"Satış eklenemedi. Girilen fiş numarasına aynı teknisyen aynı malzemeyi daha önceden satmıştır.\");</script>";
                        }else if ($row[0] == 50) {
                            echo "<script type='text/javascript'>alert(\"Satış eklenemedi. Satış yapmak için teknisyenin üzerinde yeterli zimmetli malzeme bulunmamaktadır.\");</script>";
                        }
                    }
                }else {
                    echo "<script type='text/javascript'>alert(\"Satış EKLENEMEDİ. Lütfen bilgi girişini eksiksiz yapınız.\");</script>";
                }
                // $result->free(); /*Hata verdiriyor*/
                $mysqli->close();
            }else {
                echo "<script type='text/javascript'>alert(\"İşlem BAŞARISIZ! Lütfen girilen değerleri kontrol ediniz.\");</script>";
            }
        }
        
        if (isset($_POST['cancelSatis'])) {
            if (is_numeric($TekNo) && is_numeric($MalzKodu) && is_numeric($FisID)) {
                $mysqli = new mysqli("localhost:3308", "root", "password", "arcelik");
                if ($mysqli->connect_errno) {
                    echo "Failed to connect to MySQL: (" . $mysqli->connect_errno . ") " . $mysqli->connect_error;
                }
                if ($TekNo && $MalzKodu && $FisID != "") {
                    $mysqli->multi_query("CALL SatisIptal(@outputt,$TekNo,$MalzKodu,$FisID);");
                    $result = $mysqli->store_result();
                    if(!is_object($result)){
                        echo $mysqli->error;
                    }else{
                        $row = $result->fetch_row();
                        echo $row[0];
                        if ($row[0] == 20) {
                            echo "<script type='text/javascript'>alert(\"Kayıt Başarıyla Silinmiştir.\");</script>";
                        }else if ($row[0] == 30) {
                            echo "<script type='text/javascript'>alert(\"İşlem BAŞARISIZ! Böyle bir kayıt yok. Lütfen girdiğiniz bilgileri kontrol ediniz.\");</script>";
                        }else{
                            echo "<script type='text/javascript'>alert(\"İşlem BAŞARISIZ! Lütfen gerekli kontrolleri yaptıktan sonra tekrar deneyiniz.\");</script>";
                        }
                    }
                }else{
                    echo "<script type='text/javascript'>alert(\"Satış SİLİNEMEDİ. Lütfen bilgi girişini eksiksiz yapınız.\");</script>";
                }
                $mysqli->close();
            }else {
                echo "<script type='text/javascript'>alert(\"Satış SİLİNEMEDİ. Lütfen girilen bilgileri kontrol ediniz.\");</script>";
            }
        }
    }
        
    


    function test_input($data) {
        $data = trim($data);
        $data = stripslashes($data);
        $data = htmlspecialchars($data);
        return $data;
    }

?>

<body>
<div class="container">
  <h2>SATIŞ</h2>
  <form method="post" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]);?>">
    <div class="form-group">
      <label for="TekNo" id = "labelTekNo">Teknisyen Numarası:</label>
      <input type="text" class="form-control" name="TekNo" value="<?php if (isset($_POST['TekNo'])) { echo $_POST['TekNo'];}?>">
    </div>
    <div class="form-group">
      <label for="MalzKodu">Malzeme Kodu:</label>
      <input type="text" class="form-control" name="MalzKodu" value="<?php if (isset($_POST['MalzKodu'])) { echo $_POST['MalzKodu'];}?>">
    </div>
    <div class="form-group">
      <label for="FisID">Fiş Numarası:</label>
      <input type="text" class="form-control" name="FisID" value="<?php if (isset($_POST['FisID'])) { echo $_POST['FisID'];}?>">
    </div>
    <div class="form-group">
      <label for="MusAd">Müşteri Adı: </label>
      <input type="text" class="form-control" name="MusAd" value="<?php if (isset($_POST['MusAd'])) { echo $_POST['MusAd'];}?>">
    </div>
    <div class="form-group">
      <label for="MusSoyad">Müşteri Soyadı:</label>
      <input type="text" class="form-control" name="MusSoyad" value="<?php if (isset($_POST['MusSoyad'])) { echo $_POST['MusSoyad'];}?>">
    </div>
    <div class="form-group">
      <label for="MalzMiktari">Malzeme Miktarı:</label>
      <input type="text" class="form-control" name="MalzMiktari">
    </div>
    <div class="form-group">
      <label for="SatisTar">Satış Tarihi:</label>
      <input type="date" class="form-control" name="SatisTar">
    </div>    
     <div class="form-group">
      	<button type="submit" class="btn btn-primary" name="showZimmet">Zimmetleri Listele</button>
     	<button type="submit" class="btn btn-primary" name="showTeknisyen">Teknisyenleri Listele</button>
    	<button type="submit" class="btn btn-primary" name="showMalzeme" >Malzemeleri Listele</button>
    	<button type="submit" class="btn btn-primary" name="showSatis">Satışları Listele</button>
    	<button type="submit" class="btn btn-primary" name="addSatis" onclick="return confirm('<?php echo "Satışı eklemek istediğinizden emin misiniz?"?>')">Satış Ekle</button>
    	<button type="submit" class="btn btn-primary" name="cancelSatis" onclick="return confirm('<?php echo "ŞATIŞ İPTALİ yapmak istediğinizden emin misiz? Eğer devam etmek isterseniz teknisyen numarası, malzeme kodu ve fiş numarası bölümlerini BOŞ BIRAKMAYINIZ ve tamama basınız. işlemi İPTAL etmek için iptale BASINIZ!"?>')">Satış İptal</button>
	 </div>
    	<?php
  		if(isset($_POST['showSatis'])){
  		    if($TekNo != "" && $MalzKodu == "" && $FisID == ""){
  		        if(is_numeric($TekNo)){
  		            echo "<table class='table table-striped'>";
  		            echo "<thead>";
  		            echo "<tr>";
  		            echo "<th scope='col'>#</th>";
  		            echo "<th scope='col'>Teknisyen No</th>";
  		            echo "<th scope='col'>Teknisyen Adı</th>";
  		            echo "<th scope='col'>Teknisyen Soyadı</th>";
  		            echo "<th scope='col'>Malzeme Kodu</th>";
  		            echo "<th scope='col'>Malzeme Adı</th>";
  		            echo "<th scope='col'>Malzeme Miktarı</th>";
  		            echo "<th scope='col'>Fiş Numarası</th>";
  		            echo "<th scope='col'>Müşteri Adı</th>";
  		            echo "<th scope='col'>Müşteri Soyadı</th>";
  		            echo "<th scope='col'>Satış Tarihi</th>";
  		            echo "<th scope='col'>İşlem Tarihi</th>";
  		            echo "</tr>";
  		            echo "</thead>";
  		            echo "<tbody>";
  		            $mysqli = new mysqli("localhost:3308", "root", "password", "arcelik");
  		            if ($mysqli->connect_errno) {
  		                echo "Failed to connect to MySQL: (" . $mysqli->connect_errno . ") " . $mysqli->connect_error;
  		            }
  		            $result = mysqli_query($mysqli,"CALL showSatisTekNo($TekNo);");
  		            $counter = 0;
  		            while($row = mysqli_fetch_array($result)) {
  		                $counter = $counter + 1;
  		                echo "<tr>";
  		                echo "<th scope='row'>". $counter ."</th>";
  		                echo "<td>" . $row['TeknisyenNo'] . "</td>";
  		                echo "<td>" . $row['TeknisyenAdi'] . "</td>";
  		                echo "<td>" . $row['TeknisyenSoyadi'] . "</td>";
  		                echo "<td>" . $row['MalzemeKodu'] . "</td>";
  		                echo "<td>" . $row['MalzemeAdi'] . "</td>";
  		                echo "<td>" . $row['MalzemeMiktari'] . "</td>";
  		                echo "<td>" . $row['FisNo'] . "</td>";
  		                echo "<td>" . $row['MusteriAd'] . "</td>";
  		                echo "<td>" . $row['MusteriSoyad'] . "</td>";
  		                echo "<td>" . $row['SatisTarihi'] . "</td>";
  		                echo "<td>" . $row['IslemTarihi'] . "</td>";
  		                echo "</tr>";
  		            }
  		            echo "</tbody>";
  		            echo "</table>";
  		            $mysqli->close();
  		        }else{
  		            echo "<script type='text/javascript'>alert(\"İşlem BAŞARISIZ! Lütfen Teknisyen Numarasını Düzgün Giriniz!\");</script>";
  		        }
  		    }else if($TekNo == "" && $MalzKodu != "" && $FisID == ""){
  		        if(is_numeric($MalzKodu)){
  		            echo "<table class='table table-striped'>";
  		            echo "<thead>";
  		            echo "<tr>";
  		            echo "<th scope='col'>#</th>";
  		            echo "<th scope='col'>Teknisyen No</th>";
  		            echo "<th scope='col'>Teknisyen Adı</th>";
  		            echo "<th scope='col'>Teknisyen Soyadı</th>";
  		            echo "<th scope='col'>Malzeme Kodu</th>";
  		            echo "<th scope='col'>Malzeme Adı</th>";
  		            echo "<th scope='col'>Malzeme Miktarı</th>";
  		            echo "<th scope='col'>Fiş Numarası</th>";
  		            echo "<th scope='col'>Müşteri Adı</th>";
  		            echo "<th scope='col'>Müşteri Soyadı</th>";
  		            echo "<th scope='col'>Satış Tarihi</th>";
  		            echo "<th scope='col'>İşlem Tarihi</th>";
  		            echo "</tr>";
  		            echo "</thead>";
  		            echo "<tbody>";
  		            $mysqli = new mysqli("localhost:3308", "root", "password", "arcelik");
  		            if ($mysqli->connect_errno) {
  		                echo "Failed to connect to MySQL: (" . $mysqli->connect_errno . ") " . $mysqli->connect_error;
  		            }
  		            $result = mysqli_query($mysqli,"CALL showSatisMalzNo($MalzKodu);");
  		            $counter = 0;
  		            while($row = mysqli_fetch_array($result)) {
  		                $counter = $counter + 1;
  		                echo "<tr>";
  		                echo "<th scope='row'>". $counter ."</th>";
  		                echo "<td>" . $row['TeknisyenNo'] . "</td>";
  		                echo "<td>" . $row['TeknisyenAdi'] . "</td>";
  		                echo "<td>" . $row['TeknisyenSoyadi'] . "</td>";
  		                echo "<td>" . $row['MalzemeKodu'] . "</td>";
  		                echo "<td>" . $row['MalzemeAdi'] . "</td>";
  		                echo "<td>" . $row['MalzemeMiktari'] . "</td>";
  		                echo "<td>" . $row['FisNo'] . "</td>";
  		                echo "<td>" . $row['MusteriAd'] . "</td>";
  		                echo "<td>" . $row['MusteriSoyad'] . "</td>";
  		                echo "<td>" . $row['SatisTarihi'] . "</td>";
  		                echo "<td>" . $row['IslemTarihi'] . "</td>";
  		                echo "</tr>";
  		            }
  		            echo "</tbody>";
  		            echo "</table>";
  		            $mysqli->close();
  		        }else{
  		            echo "<script type='text/javascript'>alert(\"İşlem BAŞARISIZ! Lütfen Malzeme Kodunu Düzgün Giriniz!\");</script>";
  		        }
  		    }else if($TekNo == "" && $MalzKodu == "" && $FisID != ""){
  		        if(is_numeric($FisID)){
  		            echo "<table class='table table-striped'>";
  		            echo "<thead>";
  		            echo "<tr>";
  		            echo "<th scope='col'>#</th>";
  		            echo "<th scope='col'>Teknisyen No</th>";
  		            echo "<th scope='col'>Teknisyen Adı</th>";
  		            echo "<th scope='col'>Teknisyen Soyadı</th>";
  		            echo "<th scope='col'>Malzeme Kodu</th>";
  		            echo "<th scope='col'>Malzeme Adı</th>";
  		            echo "<th scope='col'>Malzeme Miktarı</th>";
  		            echo "<th scope='col'>Fiş Numarası</th>";
  		            echo "<th scope='col'>Müşteri Adı</th>";
  		            echo "<th scope='col'>Müşteri Soyadı</th>";
  		            echo "<th scope='col'>Satış Tarihi</th>";
  		            echo "<th scope='col'>İşlem Tarihi</th>";
  		            echo "</tr>";
  		            echo "</thead>";
  		            echo "<tbody>";
  		            $mysqli = new mysqli("localhost:3308", "root", "password", "arcelik");
  		            if ($mysqli->connect_errno) {
  		                echo "Failed to connect to MySQL: (" . $mysqli->connect_errno . ") " . $mysqli->connect_error;
  		            }
  		            $result = mysqli_query($mysqli,"CALL showSatisFisNo($FisID);");
  		            $counter = 0;
  		            while($row = mysqli_fetch_array($result)) {
  		                $counter = $counter + 1;
  		                echo "<tr>";
  		                echo "<th scope='row'>". $counter ."</th>";
  		                echo "<td>" . $row['TeknisyenNo'] . "</td>";
  		                echo "<td>" . $row['TeknisyenAdi'] . "</td>";
  		                echo "<td>" . $row['TeknisyenSoyadi'] . "</td>";
  		                echo "<td>" . $row['MalzemeKodu'] . "</td>";
  		                echo "<td>" . $row['MalzemeAdi'] . "</td>";
  		                echo "<td>" . $row['MalzemeMiktari'] . "</td>";
  		                echo "<td>" . $row['FisNo'] . "</td>";
  		                echo "<td>" . $row['MusteriAd'] . "</td>";
  		                echo "<td>" . $row['MusteriSoyad'] . "</td>";
  		                echo "<td>" . $row['SatisTarihi'] . "</td>";
  		                echo "<td>" . $row['IslemTarihi'] . "</td>";
  		                echo "</tr>";
  		            }
  		            echo "</tbody>";
  		            echo "</table>";
  		            $mysqli->close();
  		        }else{
  		            echo "<script type='text/javascript'>alert(\"İşlem BAŞARISIZ! Lütfen Fiş Numarasını Düzgün Giriniz!\");</script>";
  		        }
  		    }else if($TekNo != "" && $MalzKodu != "" && $FisID != ""){
  		        if(is_numeric($TekNo) && is_numeric($MalzKodu) && is_numeric($FisID)){
  		            echo "<table class='table table-striped'>";
  		            echo "<thead>";
  		            echo "<tr>";
  		            echo "<th scope='col'>#</th>";
  		            echo "<th scope='col'>Teknisyen No</th>";
  		            echo "<th scope='col'>Teknisyen Adı</th>";
  		            echo "<th scope='col'>Teknisyen Soyadı</th>";
  		            echo "<th scope='col'>Malzeme Kodu</th>";
  		            echo "<th scope='col'>Malzeme Adı</th>";
  		            echo "<th scope='col'>Malzeme Miktarı</th>";
  		            echo "<th scope='col'>Fiş Numarası</th>";
  		            echo "<th scope='col'>Müşteri Adı</th>";
  		            echo "<th scope='col'>Müşteri Soyadı</th>";
  		            echo "<th scope='col'>Satış Tarihi</th>";
  		            echo "<th scope='col'>İşlem Tarihi</th>";
  		            echo "</tr>";
  		            echo "</thead>";
  		            echo "<tbody>";
  		            $mysqli = new mysqli("localhost:3308", "root", "password", "arcelik");
  		            if ($mysqli->connect_errno) {
  		                echo "Failed to connect to MySQL: (" . $mysqli->connect_errno . ") " . $mysqli->connect_error;
  		            }
  		            $result = mysqli_query($mysqli,"CALL showSatisTMF($TekNo, $MalzKodu, $FisID);");
  		            $counter = 0;
  		            while($row = mysqli_fetch_array($result)) {
  		                $counter = $counter + 1;
  		                echo "<tr>";
  		                echo "<th scope='row'>". $counter ."</th>";
  		                echo "<td>" . $row['TeknisyenNo'] . "</td>";
  		                echo "<td>" . $row['TeknisyenAdi'] . "</td>";
  		                echo "<td>" . $row['TeknisyenSoyadi'] . "</td>";
  		                echo "<td>" . $row['MalzemeKodu'] . "</td>";
  		                echo "<td>" . $row['MalzemeAdi'] . "</td>";
  		                echo "<td>" . $row['MalzemeMiktari'] . "</td>";
  		                echo "<td>" . $row['FisNo'] . "</td>";
  		                echo "<td>" . $row['MusteriAd'] . "</td>";
  		                echo "<td>" . $row['MusteriSoyad'] . "</td>";
  		                echo "<td>" . $row['SatisTarihi'] . "</td>";
  		                echo "<td>" . $row['IslemTarihi'] . "</td>";
  		                echo "</tr>";
  		            }
  		            echo "</tbody>";
  		            echo "</table>";
  		            $mysqli->close();
  		        }else{
  		            echo "<script type='text/javascript'>alert(\"İşlem BAŞARISIZ! Lütfen Girdiğiniz Değerleri Kontrol Ediniz!\");</script>";
  		        }
  		    }else{
  		        echo "<table class='table table-striped'>";
  		        echo "<thead>";
  		        echo "<tr>";
  		        echo "<th scope='col'>#</th>";
  		        echo "<th scope='col'>Teknisyen No</th>";
  		        echo "<th scope='col'>Teknisyen Adı</th>";
  		        echo "<th scope='col'>Teknisyen Soyadı</th>";
  		        echo "<th scope='col'>Malzeme Kodu</th>";
  		        echo "<th scope='col'>Malzeme Adı</th>";
  		        echo "<th scope='col'>Malzeme Miktarı</th>";
  		        echo "<th scope='col'>Fiş Numarası</th>";
  		        echo "<th scope='col'>Müşteri Adı</th>";
  		        echo "<th scope='col'>Müşteri Soyadı</th>";
  		        echo "<th scope='col'>Satış Tarihi</th>";
  		        echo "<th scope='col'>İşlem Tarihi</th>";
  		        echo "</tr>";
  		        echo "</thead>";
  		        echo "<tbody>";
  		        $mysqli = new mysqli("localhost:3308", "root", "password", "arcelik");
  		        if ($mysqli->connect_errno) {
  		            echo "Failed to connect to MySQL: (" . $mysqli->connect_errno . ") " . $mysqli->connect_error;
  		        }
  		        $result = mysqli_query($mysqli,"CALL showSatis();");
  		        $counter = 0;
  		        while($row = mysqli_fetch_array($result)) {
  		            $counter = $counter + 1;
  		            echo "<tr>";
  		            echo "<th scope='row'>". $counter ."</th>";
  		            echo "<td>" . $row['TeknisyenNo'] . "</td>";
  		            echo "<td>" . $row['TeknisyenAdi'] . "</td>";
  		            echo "<td>" . $row['TeknisyenSoyadi'] . "</td>";
  		            echo "<td>" . $row['MalzemeKodu'] . "</td>";
  		            echo "<td>" . $row['MalzemeAdi'] . "</td>";
  		            echo "<td>" . $row['MalzemeMiktari'] . "</td>";
  		            echo "<td>" . $row['FisNo'] . "</td>";
  		            echo "<td>" . $row['MusteriAd'] . "</td>";
  		            echo "<td>" . $row['MusteriSoyad'] . "</td>";
  		            echo "<td>" . $row['SatisTarihi'] . "</td>";
  		            echo "<td>" . $row['IslemTarihi'] . "</td>";
  		            echo "</tr>";
  		        }
  		        echo "</tbody>";
  		        echo "</table>";
  		        $mysqli->close();
  		    }
  		}
        ?>
  		<?php
  		if(isset($_POST['showZimmet'])){
  		    if($TekNo != "" && $MalzKodu == ""){
  		        if(is_numeric($TekNo)){
  		            echo "<table class='table table-striped'>";
  		            echo "<thead>";
  		            echo "<tr>";
  		            echo "<th scope='col'>#</th>";
  		            echo "<th scope='col'>Teknisyen No</th>";
  		            echo "<th scope='col'>Teknisyen Adı</th>";
  		            echo "<th scope='col'>Teknisyen Soyadı</th>";
  		            echo "<th scope='col'>Malzeme Kodu</th>";
  		            echo "<th scope='col'>Malzeme Adı</th>";
  		            echo "<th scope='col'>Malzeme Adet</th>";
  		            echo "<th scope='col'>İslem Tarihi</th>";
  		            echo "</tr>";
  		            echo "</thead>";
  		            echo "<tbody>";
  		            $mysqli = new mysqli("localhost:3308", "root", "password", "arcelik");
  		            if ($mysqli->connect_errno) {
  		                echo "Failed to connect to MySQL: (" . $mysqli->connect_errno . ") " . $mysqli->connect_error;
  		            }
  		            $result = mysqli_query($mysqli,"CALL ZimmetGosterTekNo($TekNo);");
  		            $counter = 0;
  		            while($row = mysqli_fetch_array($result)) {
  		                $counter = $counter + 1;
  		                echo "<tr>";
  		                echo "<th scope='row'>". $counter ."</th>";
  		                echo "<td>" . $row['TeknisyenNo'] . "</td>";
  		                echo "<td>" . $row['TeknisyenAdi'] . "</td>";
  		                echo "<td>" . $row['TeknisyenSoyadi'] . "</td>";
  		                echo "<td>" . $row['MalzemeKodu'] . "</td>";
  		                echo "<td>" . $row['MalzemeAdi'] . "</td>";
  		                echo "<td>" . $row['MalzemeStok'] . "</td>";
  		                echo "<td>" . $row['IslemTarihi'] . "</td>";
  		                echo "</tr>";
  		            }
  		            echo "</tbody>";
  		            echo "</table>";
  		            $mysqli->close();
  		        }else{
  		            echo "<script type='text/javascript'>alert(\"Lütfen Teknisyen Numarasını Düzgün Giriniz!\");</script>";
  		        }
  		    }else if($TekNo == "" && $MalzKodu != ""){
  		        if(is_numeric($MalzKodu)){
  		            echo "<table class='table table-striped'>";
  		            echo "<thead>";
  		            echo "<tr>";
  		            echo "<th scope='col'>#</th>";
  		            echo "<th scope='col'>Teknisyen No</th>";
  		            echo "<th scope='col'>Teknisyen Adı</th>";
  		            echo "<th scope='col'>Teknisyen Soyadı</th>";
  		            echo "<th scope='col'>Malzeme Kodu</th>";
  		            echo "<th scope='col'>Malzeme Adı</th>";
  		            echo "<th scope='col'>Malzeme Adet</th>";
  		            echo "<th scope='col'>İslem Tarihi</th>";
  		            echo "</tr>";
  		            echo "</thead>";
  		            echo "<tbody>";
  		            $mysqli = new mysqli("localhost:3308", "root", "password", "arcelik");
  		            if ($mysqli->connect_errno) {
  		                echo "Failed to connect to MySQL: (" . $mysqli->connect_errno . ") " . $mysqli->connect_error;
  		            }
  		            $result = mysqli_query($mysqli,"CALL ZimmetGosterMalzKodu($MalzKodu);");
  		            $counter = 0;
  		            while($row = mysqli_fetch_array($result)) {
  		                $counter = $counter + 1;
  		                echo "<tr>";
  		                echo "<th scope='row'>". $counter ."</th>";
  		                echo "<td>" . $row['TeknisyenNo'] . "</td>";
  		                echo "<td>" . $row['TeknisyenAdi'] . "</td>";
  		                echo "<td>" . $row['TeknisyenSoyadi'] . "</td>";
  		                echo "<td>" . $row['MalzemeKodu'] . "</td>";
  		                echo "<td>" . $row['MalzemeAdi'] . "</td>";
  		                echo "<td>" . $row['MalzemeStok'] . "</td>";
  		                echo "<td>" . $row['IslemTarihi'] . "</td>";
  		                echo "</tr>";
  		            }
  		            echo "</tbody>";
  		            echo "</table>";
  		            $mysqli->close();
  		        }else {
  		            echo "<script type='text/javascript'>alert(\"Lütfen Malzeme Kodunu Düzgün Giriniz!\");</script>";
  		        }
  		    }else if($TekNo != "" && $MalzKodu != ""){
  		        if(is_numeric($TekNo) && is_numeric($MalzKodu)){
  		            echo "<table class='table table-striped'>";
  		            echo "<thead>";
  		            echo "<tr>";
  		            echo "<th scope='col'>#</th>";
  		            echo "<th scope='col'>Teknisyen No</th>";
  		            echo "<th scope='col'>Teknisyen Adı</th>";
  		            echo "<th scope='col'>Teknisyen Soyadı</th>";
  		            echo "<th scope='col'>Malzeme Kodu</th>";
  		            echo "<th scope='col'>Malzeme Adı</th>";
  		            echo "<th scope='col'>Malzeme Adet</th>";
  		            echo "<th scope='col'>İslem Tarihi</th>";
  		            echo "</tr>";
  		            echo "</thead>";
  		            echo "<tbody>";
  		            $mysqli = new mysqli("localhost:3308", "root", "password", "arcelik");
  		            if ($mysqli->connect_errno) {
  		                echo "Failed to connect to MySQL: (" . $mysqli->connect_errno . ") " . $mysqli->connect_error;
  		            }
  		            $result = mysqli_query($mysqli,"CALL ZimmetGosterTekMalNo($TekNo,$MalzKodu);");
  		            $counter = 0;
  		            while($row = mysqli_fetch_array($result)) {
  		                $counter = $counter + 1;
  		                echo "<tr>";
  		                echo "<th scope='row'>". $counter ."</th>";
  		                echo "<td>" . $row['TeknisyenNo'] . "</td>";
  		                echo "<td>" . $row['TeknisyenAdi'] . "</td>";
  		                echo "<td>" . $row['TeknisyenSoyadi'] . "</td>";
  		                echo "<td>" . $row['MalzemeKodu'] . "</td>";
  		                echo "<td>" . $row['MalzemeAdi'] . "</td>";
  		                echo "<td>" . $row['MalzemeStok'] . "</td>";
  		                echo "<td>" . $row['IslemTarihi'] . "</td>";
  		                echo "</tr>";
  		            }
  		            echo "</tbody>";
  		            echo "</table>";
  		            $mysqli->close();
  		        }else{
  		            echo "<script type='text/javascript'>alert(\"Lütfen Teknisyen Numarasını düzgün giriniz!\");</script>";
  		        }
  		    }else{
  		        echo "<table class='table table-striped'>";
  		        echo "<thead>";
  		        echo "<tr>";
  		        echo "<th scope='col'>#</th>";
  		        echo "<th scope='col'>Teknisyen No</th>";
  		        echo "<th scope='col'>Teknisyen Adı</th>";
  		        echo "<th scope='col'>Teknisyen Soyadı</th>";
  		        echo "<th scope='col'>Malzeme Kodu</th>";
  		        echo "<th scope='col'>Malzeme Adı</th>";
  		        echo "<th scope='col'>Malzeme Adet</th>";
  		        echo "<th scope='col'>İslem Tarihi</th>";
  		        echo "</tr>";
  		        echo "</thead>";
  		        echo "<tbody>";
  		        $mysqli = new mysqli("localhost:3308", "root", "password", "arcelik");
  		        if ($mysqli->connect_errno) {
  		            echo "Failed to connect to MySQL: (" . $mysqli->connect_errno . ") " . $mysqli->connect_error;
  		        }
  		        $result = mysqli_query($mysqli,"CALL ZimmetGoster();");
  		        $counter = 0;
  		        while($row = mysqli_fetch_array($result)) {
  		            $counter = $counter + 1;
  		            echo "<tr>";
  		            echo "<th scope='row'>". $counter ."</th>";
  		            echo "<td>" . $row['TeknisyenNo'] . "</td>";
  		            echo "<td>" . $row['TeknisyenAdi'] . "</td>";
  		            echo "<td>" . $row['TeknisyenSoyadi'] . "</td>";
  		            echo "<td>" . $row['MalzemeKodu'] . "</td>";
  		            echo "<td>" . $row['MalzemeAdi'] . "</td>";
  		            echo "<td>" . $row['MalzemeStok'] . "</td>";
  		            echo "<td>" . $row['IslemTarihi'] . "</td>";
  		            echo "</tr>";
  		        }
  		        echo "</tbody>";
  		        echo "</table>";
  		        $mysqli->close();
  		    }
  		}
        ?>
        <?php
  		if(isset($_POST['showTeknisyen'])){
  		    echo "<table class='table table-striped'>";
  		    echo "<thead>";
  		    echo "<tr>";
  		    echo "<th scope='col'>#</th>";
  		    echo "<th scope='col'>Teknisyen No</th>";
  		    echo "<th scope='col'>Teknisyen Adı</th>";
  		    echo "<th scope='col'>Teknisyen Soyadı</th>";
  		    echo "</tr>";
  		    echo "</thead>";
  		    echo "<tbody>";
  		    $mysqli = new mysqli("localhost:3308", "root", "password", "arcelik");
  		    if ($mysqli->connect_errno) {
  		        echo "Failed to connect to MySQL: (" . $mysqli->connect_errno . ") " . $mysqli->connect_error;
  		    }
  		    $result = mysqli_query($mysqli,"CALL TeknisyenGoster();");
  		    $counter = 0;
  		    while($row = mysqli_fetch_array($result)) {
  		        $counter = $counter + 1;
  		        echo "<tr>";
  		        echo "<th scope='row'>". $counter ."</th>";
  		        echo "<td>" . $row['TeknisyenNo'] . "</td>";
  		        echo "<td>" . $row['TeknisyenAdi'] . "</td>";
  		        echo "<td>" . $row['TeknisyenSoyadi'] . "</td>";
  		        echo "</tr>";
  		    }
  		    echo "</tbody>";
  		    echo "</table>";
  		    $mysqli->close();
  		}
        ?>
        <?php
  		if(isset($_POST['showMalzeme'])){
  		    echo "<table class='table table-striped'>";
  		    echo "<thead>";
  		    echo "<tr>";
  		    echo "<th scope='col'>#</th>";
  		    echo "<th scope='col'>Malzeme Kodu</th>";
  		    echo "<th scope='col'>Malzeme Adı</th>";
  		    echo "<th scope='col'>Malzeme Fiyatı</th>";
  		    echo "</tr>";
  		    echo "</thead>";
  		    echo "<tbody>";
  		    $mysqli = new mysqli("localhost:3308", "root", "password", "arcelik");
  		    if ($mysqli->connect_errno) {
  		        echo "Failed to connect to MySQL: (" . $mysqli->connect_errno . ") " . $mysqli->connect_error;
  		    }
  		    $result = mysqli_query($mysqli,"CALL TeknisyenZimmetMalzeme();");
  		    $counter = 0;
  		    while($row = mysqli_fetch_array($result)) {
  		        $counter = $counter + 1;
  		        echo "<tr>";
  		        echo "<th scope='row'>". $counter ."</th>";
  		        echo "<td>" . $row['MalzemeKodu'] . "</td>";
  		        echo "<td>" . $row['MalzemeAdi'] . "</td>";
  		        echo "<td>" . $row['MalzemeFiyat'] . "</td>";
  		        echo "</tr>";
  		    }
  		    echo "</tbody>";
  		    echo "</table>";
  		    $mysqli->close();
  		}
        ?>
		<script>
		function myFunction() {
			  
			}
		</script>
    </form>
</div>
</body>
</html>





