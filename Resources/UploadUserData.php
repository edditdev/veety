<?php
$name = $_GET['USERNAME'];
move_uploaded_file($_FILES["file"]["tmp_name"], $name . $_FILES["file"]["name"]);
?>