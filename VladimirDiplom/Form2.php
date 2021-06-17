<?php
	session_start();

	$user = 'root';
	$password = 'root';
	$db = 'tests';
	$host = 'localhost';

	$link = new mysqli($host, $user, '', $db) or die("Ошибка: " . mysqli_error($link)); //Подключение к БД

	if (isset($_POST['First'])) $Fi = $_POST['First'];
	if (isset($_POST['Second'])) $Se = $_POST['Second'];
	if (isset($_POST['Third'])) $Th = $_POST['Third'];
	if (isset($_POST['Fourth'])) $Fo = $_POST['Fourth'];
	$ID = $_SESSION['ID'];
	$Find = '+';
	$Result = 0;
	$Date = date('Y/m/d');

	if (isset($_POST['First']))
	{
		if (strpos($Fi, $Find) !== false) $Result += 1;
	}
	if (isset($_POST['Second']))
	{
		if (strpos($Se, $Find) !== false) $Result += 1;
	}
	if (isset($_POST['Third']))
	{
		if (strpos($Th, $Find) !== false) $Result += 1;
	}
	if (isset($_POST['Fourth']))
	{
		if (strpos($Fo, $Find) !== false) $Result += 1;
	}

	$ResultRates = $Result/4 * 100;

	$link->set_charset('utf8');

	$sql = "INSERT INTO results VALUES (NULL, '$ID', '$Date', 'Физика', 'Общие знания', '$ResultRates')"; //Запрос

	$result = mysqli_query($link, $sql);

	$link->close();
?>

<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title>Веб-модуль тестирования учащихся</title>
	<link rel="stylesheet" type="text/css" href="style.css">
</head>
<body>
	<header></header>
	<section>
		<div class="dop">
			<div class="a">
				<a href="http://umkou.ucoz.net">Вернуться на главную страницу</a>
			</div>
		</div>
		<div class="main">
			<h1>Результат</h1>
			<p> Колличество правильных ответов: <?php echo $Result; ?> (<?php echo $ResultRates; ?> %) </p>
		</div>
	</section>
</body>
</html>