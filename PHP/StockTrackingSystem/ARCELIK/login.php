<?php
include("kullanici.php");
session_start();
ob_start();
    if(($_POST["username"]==$hanifeAdi) and ($_POST["password"]==$hanifeSifresi)){
        $_SESSION["hanife"] = "true";
        $_SESSION["hanifeAdi"] = $hanifeAdi;
        $_SESSION["hanifeSifresi"] = $hanifeSifresi;
        header("Location:satis.php");
    }else if(($_POST["username"]==$enginAdi) and ($_POST["password"]==$enginSifresi)){
        $_SESSION["engin"] = "true";
        $_SESSION["enginAdi"] = $enginAdi;
        $_SESSION["enginSifresi"] = $enginSifresi;
        header("Location:anasayfa.php");
    }else if(($_POST["username"]==$serhatAdi) and ($_POST["password"]==$serhatSifresi)){
        $_SESSION["serhat"] = "true";
        $_SESSION["serhatAdi"] = $serhatAdi;
        $_SESSION["serhatSifresi"] = $serhatSifresi;
        header("Location:zimmet.php");
    }else{
        echo "Kullancı Adı veya Şifre Yanlış.<br>";
        echo "Giriş sayfasına yönlendiriliyorsunuz.";
        header("Refresh: 2; url=index.php");
    }
ob_end_flush();
?>