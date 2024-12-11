<?php
// Sprawdź, czy parametry 'ITEM' i 'fileID' są ustawione w URL
if (isset($_GET['ITEM']) && isset($_GET['fileID'])) {
    // Pobierz wartości z URL
    $serverName = htmlspecialchars($_GET['ITEM']); // Bezpieczne pobieranie
    $fileID = basename($_GET['fileID']); // Upewnij się, że to tylko nazwa pliku, bez ścieżki

    // Otwórz plik w trybie dopisywania
    $plik = fopen($fileID, 'a');

    // Sprawdź, czy plik został poprawnie otwarty
    if ($plik) {
        // Dodaj nową linię na końcu pliku
        fwrite($plik, $serverName . PHP_EOL);
        
        // Zamknij plik
        fclose($plik);

        echo "success";
    } else {
        echo "fail";
    }
} else {
    echo "Nie podano wymaganych parametrów.";
}
?>
