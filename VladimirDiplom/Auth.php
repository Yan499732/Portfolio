<?php
	session_start();

	$user = 'root';
	$password = 'root';
	$db = 'tests';
	$host = 'localhost';

	$link = new mysqli($host, $user, '', $db) or die("Ошибка: " . mysqli_error($link)); //Подключение к БД

	$login = $_POST['login']; //Запись данных из input в переменную
	$password = $_POST['password']; //Запись данных из input в переменную

	$result = mysqli_query($link, "SELECT * FROM `users` WHERE `Login` = '$login' AND `Password` = '$password'"); //Запрос

	$row = mysqli_fetch_array($result);

	if(count($row) == 0) //Проверка
	{
		$_SESSION['Error'] = 'Авторизоваться не удалось! Повторите попытку!';
		header('location: Authorization.php');
	}
	else
	{
		$_SESSION['ID'] = $row['ID'];
		header('location: Questions.php');
	}

	$link->close();
?>