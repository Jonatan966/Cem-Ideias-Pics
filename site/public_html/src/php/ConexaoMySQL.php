<?php 
	$token = file("../../../src/txt/validar.txt");
	//error_reporting(0);
	if (isset($_POST["acesso"]) && isset($_POST["cmd"])){
		if ($_POST["acesso"] == $token[0]){
			if(!is_bool($cx = mysqli_connect("localhost", "id12522389_cem_ideias_pics", "1072996170", "id12522389_pics"))){
			    //header("Location: https://cemideias-pics.000webhostapp.com/src/php/null.php");
			 	$consulta = mysqli_query($cx, $_POST["cmd"]);
    			if (!is_bool($consulta)){
    				$itens = array();
    				while($aux = mysqli_fetch_assoc($consulta)){
    					$itens[] = $aux;
    				}
    			    $convertido = json_encode($itens);
    			    
                    //echo substr($convertido, 1, strlen($convertido)-2);
                    echo $convertido;
    			}
    			else{
    			    echo ($consulta ? "true" : "false");
    			}
    			mysqli_close($cx);
    			exit();
			}
		}
	}
	else echo "false";
?>