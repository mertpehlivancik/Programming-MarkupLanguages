    <!doctype html>
<html lang="en">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
    <title>Anasayfa</title>
  </head>  

<?php
include("kullanici.php");
session_start();
if(!isset($_SESSION["engin"])){
    echo "<script type='text/javascript'>alert(\"Bu sayfayı görüntüleme yetkiniz yoktur.\");</script>";
    if(session_destroy())
    {
        header("Location: index.php");
    }
}else{
    
}
?>

<body>
  <nav class="navbar navbar-expand-lg navbar-light bg-light">
  	<a class="navbar-brand" href="#">Arçelik</a>
  	<button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  	</button>
  <div class="collapse navbar-collapse" id="navbarNav">
    <ul class="navbar-nav">
    <li class="nav-item active">
        <a class="nav-link" href="anasayfa.php">Anasayfa <span class="sr-only">(current)</span></a>
    </li>
    <li class="nav-item">
        <a class="nav-link" href="teknisyen.php">Teknisyen</a>
    </li>
    <li class="nav-item">
        <a class="nav-link" href="malzeme.php">Malzeme</a>
    </li>
    <li class="nav-item">
        <a class="nav-link" href="zimmet.php">Malzeme Zimmet</a>
    </li>
    <li class="nav-item">
        <a class="nav-link" href="satis.php">Satış</a>
    </li>
        <li class="nav-item">
        <a class="nav-link" href="logout.php">ÇIKIŞ</a>
    </li>
    </ul>
  </div>
</nav>
<div class="container">
  <h2>SATIŞ TUTARLARI</h2>
  <form method="post" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]);?>">
    <div class="form-group">
      <label for="TekNo" id = "labelTekNo">Teknisyen Numarası:</label>
      <input type="text" class="form-control" name="TekNo" value="<?php if (isset($_POST['TekNo'])) { echo $_POST['TekNo'];}?>">
    </div>
    <div class="form-group">
      <label for="BaslangicTar">Başlangıç Tarihi:</label>
      <input type="date" class="form-control" name="BaslangicTar">
    </div>
    <div class="form-group">
      <label for="BitisTar">Bitiş Tarihi:</label>
      <input type="date" class="form-control" name="BitisTar">
    </div>     
     <div class="form-group">
      	<button type="submit" class="btn btn-primary" name="showTutar">Göster</button>
	 </div>
<?php

    if ($_SERVER["REQUEST_METHOD"] == "POST") {
        $TekNo = $BaslangicTar = $BitisTar = "";
        $TekNo = test_input($_POST["TekNo"]);
        $BaslangicTar = test_input($_POST["BaslangicTar"]);
        $BitisTar = test_input($_POST["BitisTar"]);
            if(isset($_POST['showTutar'])){
                echo "<table class='table table-striped'>";
                echo "<thead>";
                echo "<tr>";
                echo "<th scope='col'>#</th>";
                echo "<th scope='col'>Teknisyen No</th>";
                echo "<th scope='col'>Teknisyen Adı</th>";
                echo "<th scope='col'>Teknisyen Soyadı</th>";
                echo "<th scope='col'>Malzeme Kodu</th>";
                echo "<th scope='col'>Malzeme Adı</th>";
                echo "<th scope='col'>Malzeme Karı</th>";
                echo "<th scope='col'>Malzeme Miktarı</th>";
                echo "<th scope='col'>Satış Tarihi</th>";
                echo "<th scope='col'>Fiş Numarası</th>";
                echo "<th scope='col'>Teknisyene Ödenecek Tutar</th>";
                echo "</tr>";
                echo "</thead>";
                echo "<tbody>";
                if (is_numeric($TekNo) || $TekNo == ""){
                    $mysqli = new mysqli("localhost:3308", "root", "password", "arcelik");
                    if ($mysqli->connect_errno) {
                        echo "Failed to connect to MySQL: (" . $mysqli->connect_errno . ") " . $mysqli->connect_error;
                    }
                    if ($TekNo && $BaslangicTar && $BitisTar != ""){
                        if ($BitisTar > $BaslangicTar){
                            $result = mysqli_query($mysqli,"CALL TeknisyenOdeme($TekNo,'$BaslangicTar','$BitisTar');");
                            $counter = 0;
                            $toplam = 0;
                            while($row = mysqli_fetch_array($result)) {
                                $counter = $counter + 1;
                                echo "<tr>";
                                echo "<th scope='row'>". $counter ."</th>";
                                echo "<td>" . $row['TeknisyenNo'] . "</td>";
                                echo "<td>" . $row['TeknisyenAdi'] . "</td>";
                                echo "<td>" . $row['TeknisyenSoyadi'] . "</td>";
                                echo "<td>" . $row['MalzemeKodu'] . "</td>";
                                echo "<td>" . $row['MalzemeAdi'] . "</td>";
                                echo "<td>" . $row['MalzemeTeknisyenKar'] . "</td>";
                                echo "<td>" . $row['MalzemeMiktari'] . "</td>";
                                echo "<td>" . $row['SatisTarihi'] . "</td>";
                                echo "<td>" . $row['FisNo'] . "</td>";
                                echo "<td>" . $row['VerilecekTutar'] . "</td>";
                                $toplam = $toplam + $row['VerilecekTutar'];
                                $teknisyen = $row['TeknisyenAdi']." ".$row['TeknisyenSoyadi'];
                                echo "</tr>";
                            }
                            echo $teknisyen.": ".$toplam." "."TL Ödenecektir.";
                            echo "</tbody>";
                            echo "</table>";
                            $mysqli->close();
                        }else{
                            echo "<script type='text/javascript'>alert(\"İşlem BAŞARISIZ! Başlangıç tarihi bitiş tarihinden büyük olamaz!\");</script>";
                        }
                    }else if($BaslangicTar && $BitisTar != ""){
                        $result = mysqli_query($mysqli,"CALL OdemeToplam('$BaslangicTar','$BitisTar');");
                        $counter = 0;
                        $toplam = 0;
                        while($row = mysqli_fetch_array($result)) {
                            $counter = $counter + 1;
                            echo "<tr>";
                            echo "<th scope='row'>". $counter ."</th>";
                            echo "<td>" . $row['TeknisyenNo'] . "</td>";
                            echo "<td>" . $row['TeknisyenAdi'] . "</td>";
                            echo "<td>" . $row['TeknisyenSoyadi'] . "</td>";
                            echo "<td>" . $row['MalzemeKodu'] . "</td>";
                            echo "<td>" . $row['MalzemeAdi'] . "</td>";
                            echo "<td>" . $row['MalzemeTeknisyenKar'] . "</td>";
                            echo "<td>" . $row['MalzemeMiktari'] . "</td>";
                            echo "<td>" . $row['SatisTarihi'] . "</td>";
                            echo "<td>" . $row['FisNo'] . "</td>";
                            echo "<td>" . $row['VerilecekTutar'] . "</td>";
                            $toplam = $toplam + $row['VerilecekTutar'];
                            $tarih = $BaslangicTar." -- ".$BitisTar;
                            echo "</tr>";
                        }
                        echo $tarih." arasında toplam ".$toplam." "."TL Ödenecektir.";
                        echo "</tbody>";
                        echo "</table>";
                        $mysqli->close();
                    }else{
                        echo "<script type='text/javascript'>alert(\"İşlem BAŞARISIZ! Lütfen bilgi girişini eksiksiz yapınız.\");</script>";
                    }
                }else{
                    echo "<script type='text/javascript'>alert(\"İşlem BAŞARISIZ! Lütfen girilen değerleri kontrol ediniz.\");</script>";
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
    </form>
</div> 
</body>
</html>