<?php
	session_start();
	if (!isset($_SESSION['ID']))
	{
		header('location: Authorization.php');
	}
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
				<a class="a" href="http://umkou.ucoz.net">Вернуться на главную страницу</a>
			</div>
		</div>
		<div class="main">
			<h1>Веб-модуль тестирования учащихся - Выбор теста</h1>
			<h3>География</h3>
			<a class="h3-a" href="Questions1.php">Общие знания</a>
			<h3>Физика</h3>
			<a class="h3-a" href="Questions2.php">Общие знания</a>
		</div>
	</section>
</body>
</html>