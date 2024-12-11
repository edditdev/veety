<?php
$name = $_GET['FOLDER'];

if (file_exists($name) && is_dir($name)) {
    echo "failed";
} else {
    if (mkdir($name)) {
        echo "success";
    } else {
        echo "Failed to create folder.";
    }
}
?>

