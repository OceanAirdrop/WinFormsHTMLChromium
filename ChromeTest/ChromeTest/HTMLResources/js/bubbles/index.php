<html>
	<head>
		<style>
		*{
			margin:0;
			padding:0;
		}
		
		body{
			font-family:Arial;
			font-size:12px;
		}
		
		#control{
			position:fixed;
			z-index:555;
			bottom:0px;
			left:0px;
			padding:6px;
			background-color:#FFF;
		}
		
		#control select, #control label{
			margin-left:20px;
		}
		</style>
	</head>
	<body style="background-color:#222">
		<div id="canvasBubbles" style="position:relative; height:100%; width:100%"></div>
		<div id="control">
			<form action="#" method="get">
				<select name="type">
					<option value="linear">linear</option>
					<option value="radial">radial</option>
				</select>
				<select name="revolve">
					<option value="center">center</option>
					<option value="topLeft">top left</option>
					<option value="bottomLeft">bottom left</option>
					<option value="topRight">top right</option>
					<option value="bottomRight">bottom right</option>
				</select>
				<label>Min Speed : </label><input type="text" name="minSpeed" value="50"/>
				<label>Max Speed : </label><input type="text" name="maxSpeed" value="100"/>
				<label>Min Size : </label><input type="text" name="minSize" value="50"/>
				<label>Max Size : </label><input type="text" name="maxSize" value="100"/>
				<label>Number Of Bubbles : </label><input type="text" name="num" value="100"/>
				<input type="submit" value="Submit"/>
			</form>
		</div>
		<script src="bubbles.js"></script>
		<script>
			<?php
				if(isset($_GET)){
					?>
						bubblesMain(new Object({
							type : "<?=$_GET['type'];?>",
							revolve : "<?=$_GET['revolve'];?>",
							minSpeed : <?=$_GET['minSpeed'];?>,
							maxSpeed : <?=$_GET['maxSpeed'];?>,
							minSize : <?=$_GET['minSize'];?>,
							maxSize : <?=$_GET['maxSize'];?>,
							num : <?=$_GET['num'];?>,
							colors : new Array('#FF0000','#FFFFFF','#BBBBBB')
						}));
					<?php
				}else{
					?>
						bubblesMain(new Object({
							type : 'radial',
							revolve : 'center',
							minSpeed : 100,
							maxSpeed : 500,
							minSize : 50,
							maxSize : 150,
							num : 100,
							colors : new Array('#FF0000','#FFFFFF','#BBBBBB')
						}));
					<?php
				}
			?>
		</script>
	</body>
</html>