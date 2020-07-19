<?php
    $token = file("../../../src/txt/validar.txt");
    error_reporting(0);
    if (isset($_POST["acesso"]) && isset($_POST["cmd"])){
    	if ($_POST["acesso"] == $token[0]){
    	    $opts = explode("|",$_POST["opt"]);
    	    $diretorioEnsaio = "../../../src/img/".$opts[0]."/";
			if(!is_dir($diretorioEnsaio)) mkdir($diretorioEnsaio);
			 
			if (count($opts) == 2){
				switch ($opts[1])
				{
					case "envia":
						$filename_path = md5(time().uniqid()).".jpg";
						$decoded=base64_decode($_POST["cmd"]); 
						file_put_contents($diretorioEnsaio.$filename_path,$decoded);  
						echo $filename_path;
						break; 	

					case "recebe":
						$ensaio = scandir($diretorioEnsaio);
						$jsonFinal = array();
						foreach($ensaio as $foto){
							if ($foto != "." && $foto != ".."){
								$x =  base64_encode(file_get_contents($diretorioEnsaio.$foto));
								array_push($jsonFinal,"{\"nomeImagem\":\"".$foto."\",\"imagem\":\"".$x."\"}");
							}
						}
						echo "[".implode(",",$jsonFinal)."]";	
						break;

					case "exclui":
						$target = $diretorioEnsaio.$_POST["cmd"];
						$sucess = false;
						if(is_dir($target)){
							$files = glob( $target . '*', GLOB_MARK );
							foreach( $files as $file ){
								unlink( $file );      
							}
							$sucess = rmdir( $target );
						} elseif(is_file($target)) {
							$sucess = unlink( $target );  
						}
						echo $sucess ? "true" : "false";
						break;

					case "conta":
						echo count(scandir($diretorioEnsaio));
						break;

					case "baixa":
						echo base64_encode(file_get_contents($diretorioEnsaio.$_POST["cmd"]));
						break;

					//Serve para excluir apenas uma imagem
					case "elimina":
						$final = $diretorioEnsaio.$_POST["cmd"];
						if (is_file($final))
							echo unlink($final) ? "true" : "false";
						else echo "false";
						break;
						
					default:
						echo "false";	
						break;
				}
				exit();	
			}
		}
	}
	echo "false";
?>