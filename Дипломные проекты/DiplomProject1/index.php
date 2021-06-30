<?php
	$user = 'root';
	$password = 'root';
	$db = 'school';
	$host = 'localhost';

	$link = new mysqli($host, $user, '', $db) or die("Ошибка: " . mysqli_error($link)); //Подключение к БД
	//Получение данных из БД
	$result = $link->query("SELECT eventresults.ID, eventsmembers.Name, eventsmembers.Surname, eventsmembers.Patronymic, eventresults.TypeMP, eventresults.NameMP, eventresults.Year, eventresults.Place FROM eventresults JOIN eventsmembers ON eventresults.ID_member = eventsmembers.ID_member");
?>

<!DOCTYPE html>
<html>
<head>
	<title></title>
	<link rel="stylesheet" type="text/css" href="style.css">
</head>
<body>
	<header>
		<a href="http://ukkaban.edu22.info">Вернуться на главную страницу</a>
	</header>
	<div class="image"></div>
	<div class="line1"></div>
	<div class="line2"></div>
	<section>
		<h1>Лучшие ученики</h1>
		<?php while($row = mysqli_fetch_array($result))
			if ($row['Place'] <= 3)
			printf(
				"<div>
					<p>Имя: ".$row['Name']."</p>
					<p>Фамилия: ".$row['Surname']."</p>
					<p>Отчество: ".$row['Patronymic']."</p>
					<p>Тип мероприятия: ".$row['TypeMP']."</p>
					<p>Название мероприятия: ".$row['NameMP']."</p>
					<p>Год: ".$row['Year']."</p>
					<p>Место: ".$row['Place']."</p>
				</div>"
			);
		?>
	</section>
</body>
</html>