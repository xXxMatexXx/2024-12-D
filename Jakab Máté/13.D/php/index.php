<?php

echo "Hello Darkness, my old friend<h1>";
/*
//deklarálás
$sex = "finger";

echo $sex;

$a = 10;
$b = 5;

echo $a/$b;

echo "<br>";

if ($a > $b) {
    echo "Az a nagyobb, mint a B";
}

elseif($b >$a){
    echo"A, B nagyobb, mint az A";
}

 else {
    echo "Az A ugyanannyi, mint a B";
 }
 */

/*
 $j = 0;
 //feltétel
 while ($j <=10){
    echo $j;
    $j++;
 }
*/

//1-től 100-ig
//3-mal osztható számok

/*
$f = 1;
$g = 100;

echo "<br>";

/*
foreach (range(1, 100) as $value) {
    echo ("$value\n");
}
*/

/*
for ($i = 1; $i < 101; $i++){
    if ($i % 3 == 0) {
        echo $i;
    }
}


for($i=1; $i < 101; $i++) {
    if ($i % 5 == 0)
    {echo "<b>".$i."</b>";


    }else{
        echo$i;
    }
}
*/

echo "<br>";

echo "<table>";
$szam = 1;
//sor
for ($i=0; $i < 10; $i++){
echo "<tr>";
//oszlop
for ($j = 0; $j < 10;$j++) {
    if ($szam % 5 == 0){
        echo "<td><b>".$szam."<b><td>";
    }else{
        echo"<td>".$szam."</td>";
    }
    $szam++;

}
echo "</tr>";

}
?>