<?php
    $validador = file("../../../src/txt/validar.txt");
    if (isset($_POST["acesso"])){
        if ($_POST["acesso"] == $validador[0]){
            if (isset($_POST["cmd"])){
                if ($_POST["cmd"] != ""){
                    try {
                        $cx = mysqli_connect("localhost", "id12522389_cem_ideias_picsa", "1072996170", "id12522389_pics");

                        $sql = mysqli_query($cx, $_POST["cmd"]);
                        
                        if (gettype($sql) != "boolean"){
                            $itens = array();
                            while($aux = mysqli_fetch_assoc($sql)){
                                array_push($itens, implode("|", $aux));
                            }
                            echo implode("§", $itens);
                        }
                        else{
                            if (!mysqli_error($cx)){
                                echo "true";
                            }
                        }
                    }
                    catch (Exception $e){
                        echo "false";
                    }
                }
                else{
                    echo "true";
                }
            }
            else{
                echo "true";
            }
        }
        else{
            echo "false";
        }
    }
    else{
        echo "false";
    }
?>