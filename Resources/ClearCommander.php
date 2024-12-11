<?php
$file = 'commander'; // nazwa pliku do wyczyszczenia

// Otwieramy plik do zapisu, co spowoduje jego wyczyszczenie
if (file_put_contents($file, '') !== false) {
    echo "success.";
} else {
    echo "error.";
}
?>