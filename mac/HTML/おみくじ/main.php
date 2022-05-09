<?php

$kuji_num = random_int(1,6);

$folder = "image/"
$daikichi = "omikuji_daikichi.png"
$kichi = "omikuji_kichi.png"
$chuukichi = "omikuji_chuukichi.png"
$suekichi = "omikuji_suekichi.png"
$kyou = "omikuji_kyou.png"
$daikyou = "omikuji_daikyou.png"

$kuji = ""
  
switch($kuji_num){
    //
    case 1:
        $kuji = $daikichi
        break;
    case 2:
        $kuji = $kichi
        break;
    case 3:
        $kuji = $chukichi
        break;
    case 4:
        $kuji = $suekichi
        break;
    case 5:
        $kuji = $kyou
        break;
    case 6:
        $kuji = $daikyou
        break;
};

echo "<img src= ".$folder + $kuji.">"

?>