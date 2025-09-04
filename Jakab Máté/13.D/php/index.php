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
/*
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
*/

$szamok = [2, 5, 10, 12, 64, 23, 73, 4, 19, 47];


foreach ($szamok as $szam) {
    //összes szám kíirása
    //echo $szam. "";

    if ($szam % 2 == 0) {
        echo $szam. "";
    }
}

echo "<h1>Programozáso tételek</h1>";
echo "<b>Tömb elemei:";

$max = $szamok[0];
foreach ($szamok as $maxkeres) {
    if ($maxkeres > $max) {
        $max = $maxkeres;
    }
}

echo " A legnagyobb szám: " .$max;

echo "<h2>2. Lineáris keresés</h2>";
/*
$index = 0;
$found = false;
while(!$found && $index < count($szamok)) {
    if ($szamok [$index] == 23) {
        $found = true;
    }else{
        $index++;
    }
}

if($found) {
    echo "A keresett szám megtalálható a ".($index + 1)
}else{
    echo "A keresett szám nincs benne a tömbben"
}

echo "<h2>3. Kiválasztás</h2>"

$pos = 0;
$found = false;

while(!$found && $found)
*/
/*
echo "<h2>4. Eldöntés</h2>";

$index = 0;
$found = false;

while(!$found && $index < count($szamok)) {
    if($szamok [$index] == 23) {
        $found = true;
    }
    $index++;
}
if ($found) {
    echo "Benne van a tömben a szám.";
}else{
    echo "Nincs benne a tömben a szám.";
}

echo "<h2>5. Sorozatszámítás</h2>";

$sum = 0;
foreach($szamok  as $szam) {
    if ($szam % 2 !=0); {
        $sum += $szam;
    }
}
echo " A páratlan számok összege:".$sum;

echo "<h2>6. Megszámolás</h2>";

$db = 0;

foreach ($szamok as $szam) {
    if ($szam %2 == 0) {
        $db++;
    }
}

echo $db. "db páros szám található.";
*/

$emberek = [
    ["János", "Budapest", 17, "tanuló"],
    ["Elemér", "Kecskemét", 28, "orvos"],
    ["Károly", "Budapest", 33, "rendőr"],
    ["Ferenc", "Miskolc", 58, "vállalkozó"],
    ["Gábor", "Budapest", 31, "rendőr"],
    ["István", "Szeged", 47, "pék"]
];

//1.feladat
//Mennyi emberről van adatunk?
$mennyiség = count($emberek);

echo "$mennyiség ember van.";

//2. feladat
//Mennyi a budapesti lakosok átlag életkora?

//3. feladat
//Melyik a legfiatalabb rendőr?

//4. feladat
//Van-e az emberek között pék?
//Ha igen,milyen idős és hol lakik?

?>