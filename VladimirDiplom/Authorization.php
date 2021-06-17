<?php
	session_start();
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
			<h1>Веб-модуль тестирования учащихся - Авторизация</h1>
			<form action="Auth.php" method="post" enctype="multipart/form-data">
				<p>Логин:</p>
				<p><input type="text" name="login"></p></br>
				<p>Пароль:</p>
				<p><input type="password" name="password"></p></br>
				<p><button type="submit">Отправить</button></p>
				<?php
					if (isset($_SESSION['Error']))
					{
						echo $_SESSION['Error'];
						unset($_SESSION['Error']);
					}
				?>
			</form>
		</div>
	</section>
</body>
</html>