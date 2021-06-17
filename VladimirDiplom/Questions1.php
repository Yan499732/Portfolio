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
<body onload="Questions()">
	<header></header>
	<section>
		<div class="dop">
			<div class="a">
				<a class="a" href="http://umkou.ucoz.net">Вернуться на главную страницу</a>
			</div>
		</div>
		<div class="main">
			<h1>Веб-модуль тестирования учащихся - География - Общие знания</h1>
			<form action="Form1.php" method="post" enctype="multipart/form-data">
				<p id="v1"></p>
				<p id="v11"></p>
				<p id="v12"></p>
				<p id="v13"></p>
				<p id="v14"></p>
				<p id="v2"></p>
				<p id="v21"></p>
				<p id="v22"></p>
				<p id="v23"></p>
				<p id="v24"></p>
				<p id="v3"></p>
				<p id="v31"></p>
				<p id="v32"></p>
				<p id="v33"></p>
				<p id="v34"></p>
				<p id="v4"></p>
				<p id="v41"></p>
				<p id="v42"></p>
				<p id="v43"></p>
				<p id="v44"></p>
				<button type="submit">Отправить</button>
			</form>
		</div>
	</section>

	<script>
		async function Questions() {
			let form = document.forms[0],
			answer = await fetch('Вопросы1.txt'),
                  data = await answer.text(),
                  arrayData = data.split`\n`;
                  let arr = new Array();

                  for (let i = 0; i < arrayData.length; i++)
                  {
            	     arr[i] = arrayData[i];
            	     if (arrayData[i].indexOf('+') != -1)
            	     {
            		    arrayData[i] = arrayData[i].substring(0, arrayData[i].length - 2);
            	     }
                  }

                  var v1 = document.getElementById("v1");
                  var v11 = document.getElementById("v11");
                  var v12 = document.getElementById("v12");
                  var v13 = document.getElementById("v13");
                  var v14 = document.getElementById("v14");
                  var v2 = document.getElementById("v2");
                  var v21 = document.getElementById("v21");
                  var v22 = document.getElementById("v22");
                  var v23 = document.getElementById("v23");
                  var v24 = document.getElementById("v24");
                  var v3 = document.getElementById("v3");
                  var v31 = document.getElementById("v31");
                  var v32 = document.getElementById("v32");
                  var v33 = document.getElementById("v33");
                  var v34 = document.getElementById("v34");
                  var v4 = document.getElementById("v4");
                  var v41 = document.getElementById("v41");
                  var v42 = document.getElementById("v42");
                  var v43 = document.getElementById("v43");
                  var v44 = document.getElementById("v44");

                  v1.innerHTML = arr[0];
                  v11.innerHTML = '<input type="radio" name="First" value="' + arr[1] + '">' + arrayData[1];
                  v12.innerHTML = '<input type="radio" name="First" value="' + arr[2] + '">' + arrayData[2];
                  v13.innerHTML = '<input type="radio" name="First" value="' + arr[3] + '">' + arrayData[3];
                  v14.innerHTML = '<input type="radio" name="First" value="' + arr[4] + '">' + arrayData[4];
                  v2.innerHTML = arr[5];
                  v21.innerHTML = '<input type="radio" name="Second" value="' + arr[6] + '">' + arrayData[6];
                  v22.innerHTML = '<input type="radio" name="Second" value="' + arr[7] + '">' + arrayData[7];
                  v23.innerHTML = '<input type="radio" name="Second" value="' + arr[8] + '">' + arrayData[8];
                  v24.innerHTML = '<input type="radio" name="Second" value="' + arr[9] + '">' + arrayData[9];
                  v3.innerHTML = arr[10];
                  v31.innerHTML = '<input type="radio" name="Third" value="' + arr[11] + '">' + arrayData[11];
                  v32.innerHTML = '<input type="radio" name="Third" value="' + arr[12] + '">' + arrayData[12];
                  v33.innerHTML = '<input type="radio" name="Third" value="' + arr[13] + '">' + arrayData[13];
                  v34.innerHTML = '<input type="radio" name="Third" value="' + arr[14] + '">' + arrayData[14];
                  v4.innerHTML = arr[15];
                  v41.innerHTML = '<input type="radio" name="Fourth" value="' + arr[16] + '">' + arrayData[16];
                  v42.innerHTML = '<input type="radio" name="Fourth" value="' + arr[17] + '">' + arrayData[17];
                  v43.innerHTML = '<input type="radio" name="Fourth" value="' + arr[18] + '">' + arrayData[18];
                  v44.innerHTML = '<input type="radio" name="Fourth" value="' + arr[19] + '">' + arrayData[19];
		}
	</script>
</body>
</html>