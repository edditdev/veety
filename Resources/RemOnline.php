<?php
// Sprawdź, czy parametr 'UserID' jest ustawiony w URL
if (isset($_GET['UserID'])) {
    // Pobierz wartość parametru 'UserID' z URL
    $UserID = $_GET['UserID'];

    // Wczytaj zawartość pliku 'online.html' do tablicy
    $linie = file('online.html', FILE_IGNORE_NEW_LINES);

    // Sprawdź, czy plik został poprawnie wczytany
    if ($linie !== false) {
        // Znajdź linię z tekstem równym $UserID i usuń ją
        $nowe_linie = array_filter($linie, function($linia) use ($UserID) {
            return trim($linia) !== $UserID;
        });

        // Sprawdź, czy nastąpiła zmiana (czy tekst został znaleziony i usunięty)
        if (count($nowe_linie) !== count($linie)) {
            // Zapisz zaktualizowaną zawartość z powrotem do pliku
            $plik = fopen('online.html', 'w');

            // Sprawdź, czy plik został poprawnie otwarty
            if ($plik) {
                foreach ($nowe_linie as $nowa_linia) {
                    fwrite($plik, $nowa_linia . PHP_EOL);
                }

                // Zamknij plik
                fclose($plik);

                echo "success";
            } else {
                echo "fail";
            }
        } else {
            echo "Nie znaleziono podanego tekstu.";
        }
    } else {
        echo "Nie udało się otworzyć pliku.";
    }
} else {
    echo "Nie podano tekstu.";
}
?>