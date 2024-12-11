<?php
// Sprawdź, czy parametr 'text' jest ustawiony
if (isset($_GET['text'])) {
    // Pobierz wartość parametru 'text'
    $text = $_GET['text'];

    // Określ nazwę pliku
    $filename = 'commander';

    // Otwórz plik do zapisu (w trybie "a" dodajemy tekst na końcu pliku, w trybie "w" nadpisujemy plik)
    $file = fopen($filename, 'a');

    // Sprawdź, czy otwarcie pliku się powiodło
    if ($file) {
        // Zapisz tekst do pliku
        fwrite($file, $text . PHP_EOL);
        // Zamknij plik
        fclose($file);
        echo "success";
    } else {
        echo "fail";
    }
} else {
    echo "fail";
}
?>