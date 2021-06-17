<?php
	$user = 'root';
	$password = 'root';
	$db = 'requests';
	$host = 'localhost';

	$link = new mysqli($host, $user, '', $db) or die("Ошибка: " . mysqli_error($link)); //Подключение к БД

	$YF = $_POST['YF']; //Запись данных из input в переменную
	$YI = $_POST['YI']; //Запись данных из input в переменную
	$YO = $_POST['YO']; //Запись данных из input в переменную
	$DA = $_POST['DA']; //Запись данных из input в переменную
	$MF = $_POST['MF']; //Запись данных из input в переменную
	$MI = $_POST['MI']; //Запись данных из input в переменную
	$MO = $_POST['MO']; //Запись данных из input в переменную
	$OF = $_POST['OF']; //Запись данных из input в переменную
	$OI = $_POST['OI']; //Запись данных из input в переменную
	$OO = $_POST['OO']; //Запись данных из input в переменную	
	
	$KSR = addslashes(file_get_contents($_FILES['KSR']['tmp_name']));
	$SZPPK = addslashes(file_get_contents($_FILES['SZPPK']['tmp_name']));
	$SNILS = addslashes(file_get_contents($_FILES['SNILS']['tmp_name']));

	$link->set_charset('utf8');

	$sql = "INSERT INTO allrequests VALUES (NULL, '$YF', '$YI', '$YO', '$DA', '$MF', '$MI', '$MO', '$OF', '$OI', '$OO', '$KSR', '$SZPPK', '$SNILS')"; //Запрос

	$result = mysqli_query($link, $sql);

	$link->close();
?>
<p><a href="LR.html">Успех!</a></p>