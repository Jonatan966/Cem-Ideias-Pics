<?php
    $token = file("../../../src/txt/validar.txt");
    //error_reporting(0);
    if (isset($_POST["acesso"]) && isset($_POST["cmd"])){
    	if ($_POST["acesso"] == $token[0]){
    	    $opts = explode("|",$_POST["opt"]);
    	    $diretorioEnsaio = "../../../src/img/".$opts[0]."/";
     	    if( is_dir($diretorioEnsaio) === false )
            {
                mkdir($diretorioEnsaio);
            }
    	    if ($opts[1] == "envia"){
        	    $filename_path = md5(time().uniqid()).".jpg";
                $decoded=base64_decode($_POST["cmd"]); 
                file_put_contents($diretorioEnsaio.$filename_path,$decoded);   
    	    }
    	    else if($opts[1] == "recebe"){
    	        $ensaio = scandir($diretorioEnsaio);
    	        $jsonFinal = array();
    	        foreach($ensaio as $foto){
    	            if ($foto != "." && $foto != ".."){
    	                $x =  base64_encode(file_get_contents($diretorioEnsaio.$foto));
    	                array_push($jsonFinal,"{\"nomeImagem\":\"".$foto."\",\"imagem\":\"".$x."\"}");
    	            }
    	        }
    	        echo "[".implode(",",$jsonFinal)."]";
    	    }
    	    else if($opts[1] == "exclui"){
    	        echo unlink($diretorioEnsaio.$_POST["cmd"]) ? "true" : "false";
    	    }
    	}
    }
?>