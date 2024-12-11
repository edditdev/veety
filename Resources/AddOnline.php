<?php
// Sprawdź, czy parametr 'tekst' jest ustawiony w URL
if (isset($_GET['UserID'])) {
    // Pobierz tekst z URL
    $UserID= $_GET['UserID'];

    // Otwórz plik 'online.yml' w trybie dopisywania
    $plik = fopen('online.html', 'a');

    // Sprawdź, czy plik został poprawnie otwarty
    if ($plik) {
        // Dodaj nową linię na końcu pliku
        fwrite($plik, $UserID . PHP_EOL);
        
        // Zamknij plik
        fclose($plik);

        echo "success";
    } else {
        echo "fail";
    }
} else {
    echo "Nie podano tekstu.";
}
?>
