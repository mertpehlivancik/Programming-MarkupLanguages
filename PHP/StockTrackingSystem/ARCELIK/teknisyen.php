<!DOCTYPE html>
<html lang="en">
<head>
  <title>Teknisyen</title>
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
if(isset($_SESSION["engin"]) == false){
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
    }   
}
?>



<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $TekNo = $TekAdi = $TekSoyadi = "";
    $TekNo = test_input($_POST["TekNo"]);
    $TekAdi = test_input($_POST["TekAdi"]);
    $TekSoyadi = test_input($_POST["TekSoyadi"]);
    if(isset($_POST['submit'])) {
        $mysqli = new mysqli("localhost:3308", "root", "password", "arcelik");
        if ($mysqli->connect_errno) {
            echo "Failed to connect to MySQL: (" . $mysqli->connect_errno . ") " . $mysqli->connect_error;
        }
        $mysqli->multi_query("CALL TeknisyenEkle($TekNo,'$TekAdi','$TekSoyadi');");
        //$result = mysqli_query($mysqli,"CALL TeknisyenEkle($TekNo,$TekAdi,$TekSoyadi);");
        $mysqli->close();
    }
    if(isset($_POST['delete'])) {
        $mysqli = new mysqli("localhost:3308", "root", "password", "arcelik");
        if ($mysqli->connect_errno) {
            echo "Failed to connect to MySQL: (" . $mysqli->connect_errno . ") " . $mysqli->connect_error;
        }
        $mysqli->multi_query("CALL TeknisyenSil($TekNo);");
        $mysqli->close();
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
  <h2>Teknisyen Ekle</h2>
  <form method="post" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]);?>">
    <div class="form-group">
      <label for="TekNo">Teknisyen Numarası:</label>
      <input type="text" class="form-control" name="TekNo">
    </div>
    <div class="form-group">
      <label for="pwd">Teknisyen Adı:</label>
      <input type="text" class="form-control" name="TekAdi">
    </div>
    <div class="form-group">
      <label for="pwd">Teknisyen Soyadı:</label>
      <input type="text" class="form-control" name="TekSoyadi">
    </div>
    <button type="submit" class="btn btn-primary" name="submit">Ekle</button>
    <button type="submit" class="btn btn-primary" name="show">Göster</button>
    <button type="submit" class="btn btn-primary" name="delete">Sil</button>
    	<table class="table table-striped">
  		<thead>
    		<tr>   
      			<th scope="col">#</th>
      			<th scope="col">Teknisyen No</th>
      			<th scope="col">Teknisyen Adı</th>
      			<th scope="col">Teknisyen Soyadı</th>
    			</tr>
  		</thead>
  	<tbody>
  		<?php
  		if(isset($_POST['show'])){
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
    </tbody>
    </table>
    </form>
</div>
</body>
</html>





