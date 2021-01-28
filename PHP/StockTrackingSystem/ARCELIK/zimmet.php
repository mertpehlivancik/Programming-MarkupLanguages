<!DOCTYPE html>
<html lang="en">
<head>
  <title>Zimmet</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
  <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
</head>
<?php
include("kullanici.php");
session_start();
if(isset($_SESSION["serhat"]) == false && isset($_SESSION["engin"]) == false){
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
    }   
}
?>
<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $TekNo = $MalzKodu = $MalzStok ="";
    $TekNo = test_input($_POST["TekNo"]);
    $MalzKodu = test_input($_POST["MalzKodu"]);
    $MalzStok = test_input($_POST["MalzStok"]);
    
    function Tekns($TekNo) {
        $mysqli = new mysqli("localhost:3308", "root", "password", "arcelik");
        if ($mysqli->connect_errno) {
            echo "Failed to connect to MySQL: (" . $mysqli->connect_errno . ") " . $mysqli->connect_error;
        }
        if ($mysqli->multi_query("CALL TeknisyenName($TekNo);")){
            if ($result = $mysqli->store_result()) {
                while ($row = $result->fetch_row()) {
                    $nameSurname = "Teknisyen:"." ".$row[0]." ".$row[1];
                    echo "<script type='text/javascript'>alert(\"$nameSurname\");</script>";
                };
                $result->free();
            }
        }
        $mysqli->close();
    }
    
    if(isset($_POST['ZimmetEkle'])) {
        if (is_numeric($TekNo) && is_numeric($MalzKodu) && is_numeric($MalzStok)) {
            $mysqli = new mysqli("localhost:3308", "root", "password", "arcelik");
            if ($mysqli->connect_errno) {
                echo "Failed to connect to MySQL: (" . $mysqli->connect_errno . ") " . $mysqli->connect_error;
            }
            if ($TekNo && $MalzKodu && $MalzStok != ""){
                $mysqli->multi_query("CALL TeknisyenZimmetEkle(@output,$TekNo,$MalzKodu,$MalzStok);");
                $result = $mysqli->store_result();
                if (!is_object($result)){
                    echo $mysqli->error;
                }else{
                    $row = $result->fetch_row();
                    if ($row[0] == 20){
                        Tekns($TekNo);
                        echo "<script type='text/javascript'>alert(\"Teknisyene malzeme başarıyla zimmetlendi.\");</script>";
                    }else if ($row[0] == 25) {
                        echo "<script type='text/javascript'>alert(\"Malzeme stoğu başarıyla güncellendi.\");</script>";
                    }else if ($row[0] == 10){
                        echo "<script type='text/javascript'>alert(\"Böyle bir teknisyen bulunamadı.\");</script>";
                    }else if ($row[0] == 30){
                        echo "<script type='text/javascript'>alert(\"Böyle bir malzeme bulunamadı.\");</script>";
                    }else {
                        echo "<script type='text/javascript'>alert(\"İşlem başarısız!\");</script>";
                    }
                }
            }else {
                echo "<script type='text/javascript'>alert(\"İşlem BAŞARISIZ! Lütfen bilgi girişini eksiksiz yapınız.\");</script>";
            }
            $mysqli->close();
        }else {
            echo "<script type='text/javascript'>alert(\"İşlem BAŞARISIZ! Lütfen girilen değerleri kontrol ediniz.\");</script>";
        }
    }
}

    if(isset($_POST['ZimmetIade'])) {
        if (is_numeric($TekNo) && is_numeric($MalzKodu) && is_numeric($MalzStok)){
            $mysqli = new mysqli("localhost:3308", "root", "password", "arcelik");
            if ($mysqli->connect_errno) {
                echo "Failed to connect to MySQL: (" . $mysqli->connect_errno . ") " . $mysqli->connect_error;
            }
            $mysqli->multi_query("CALL ZimmetIade(@output,$TekNo,$MalzKodu,$MalzStok);");
            $result = $mysqli->store_result();
            if (!is_object($result)){
                echo $mysqli->error;
            }else{
                $row = $result->fetch_row();
                if ($row[0] == 20){
                    Tekns($TekNo);
                    echo "<script type='text/javascript'>alert(\"İade işlemi başarıyla tamamlandı.\");</script>";
                }else if ($row[0] == 10) {
                    echo "<script type='text/javascript'>alert(\"Teknisyenin üzerinde böyle bir malzeme bulunamadı.\");</script>";
                }else if ($row[0] == 30){
                    echo "<script type='text/javascript'>alert(\"Teknisyenin üzerindeki malzeme miktarı iade etmek istediğiniz malzeme miktarından daha AZ!\");</script>";
                }else {
                    echo "<script type='text/javascript'>alert(\"İşlem başarısız!\");</script>";
                }
            }
            $mysqli->close();
        }else {
            echo "<script type='text/javascript'>alert(\"İşlem BAŞARISIZ! Lütfen girilen değerleri kontrol ediniz.\");</script>";
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
  <h2>ZİMMET</h2>
  <form method="post" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]);?>">
    <div class="form-group">
      <label for="TekNo">Teknisyen Numarası:</label>
      <input type="text" class="form-control" name="TekNo" value="<?php if (isset($_POST['TekNo'])) { echo $_POST['TekNo'];}?>">
    </div>
    <div class="form-group">
      <label for="pwd">Malzeme Kodu:</label>
      <input type="text" class="form-control" name="MalzKodu" value="<?php if (isset($_POST['MalzKodu'])) { echo $_POST['MalzKodu'];}?>">
    </div>
    <div class="form-group">
      <label for="pwd">Malzeme Adet:</label>
      <input type="text" class="form-control" name="MalzStok">
    </div>
    <button type="submit" class="btn btn-primary" name="showZimmet">Zimmetleri Liste</button>
    <button type="submit" class="btn btn-primary" name="showTeknisyen">Teknisyenleri Liste</button>
    <button type="submit" class="btn btn-primary" name="showMalzeme">Malzemeleri Liste</button>
    <button type="submit" class="btn btn-primary" name="ZimmetEkle">Zimmet Ekle</button>
    <button type="submit" class="btn btn-primary" name="ZimmetIade">Zimmet İade</button>
    	
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
    </form>
</div>
</body>
</html>





