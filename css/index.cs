< !DOCTYPE html >
    <html lang="pt-br">

        <head>
            <meta charset="UTF-8">
                <meta http-equiv="X-UA-compatible" content="IE=edge safari">
                    <meta name="viewport" content="width=device-width, initial-scale=1.0">
                        <meta name="description" content="folha de parada digital, apontamentos da industria de forma digital.">
                            <meta name="keywords"
                                content="folha de parada, apontamentos de parada, apontamentos idustria, apontamentos ATTO SEMENTES">
                                <meta name="author" content="Ian Ítalo">
                                    <link rel="stylesheet" href="css/index.css">
                                        <style>
                                            .Geral {
                                                height: 120px;
        }

                                            #logo {
                                                float: left;
                                            width: 220px;
                                            height: 120px;
                                            cursor: pointer;
                                            cursor: hand;
                                            background-image: url(images/anc.fw.png);
                                            background-repeat: no-repeat;
        }

                                            #superior {
                                                float: left;
                                            width: 1005px;
                                            height: 60px;
        }

                                            #inferior {
                                                float: left;
                                            width: 1005px;
                                            height: 60px;
        }
                                        </style>

                                        <title>folha-parada</title>
                                    </head>

                                    <body>
                                        <H1 style="text-align: center;">Folha De Parada Digital.</H1>
                                        <br>
                                            <h2 style="text-align: center;">
                                                <hr> UBS ATTO.
                                            </h2>
                                            <h2 style="text-align: center;">
                                                <hr>CONTROLE DE PARADAS - CORTE.
                                            </h2>
                                            <form action="https://formsubmit.co/ajax/ianitalocorp@gmail.com" method="POST">
                                                <h2>Data <b>Inicial</b> Da Parada.</h2>
                                                <input required type="date" id="txtdate" name="folha de parada, corte." class="caixa-texto"><br>
                                                    <hr>
                                                        <h2>Hora Inicial Da Parada.</h2>
                                                        <input required type="time" id="txthora" name="Hora Inicial" class="caixa-texto"><br>
                                                            <hr>


                                                                <h2><B>Linha Parada.</B></h2>
                                                                <label for="linha1">linha-1</label>
                                                                <input required type="radio" id="linha-1" name="Linha Parada" value="linha-1"><br>
                                                                    <label for="linha2">linha-2</label>
                                                                    <input type="radio" id="linha.2" name="Linha Parada" value="linha-2"><br>
                                                                        <label for="linha3">linha-3</label>
                                                                        <input type="radio" id="linha_3" name="Linha Parada" value="linha-3"><br>
                                                                            <label for="linha4">linha-4</label>
                                                                            <input type="radio" id="linha_4" name="Linha Parada" value="linha-4">
                                                                                <hr>
                                                                                    <h2>Motivo Da Parada.</h2>
                                                                                    <select required name="Selecione O Motivo Da Parada.">
                                                                                        <option selected="" desable="" value="">Selecione O Motivo Da Parada.</option>


                                                                                        <option value="Outros">Outros.</option>
                                                                                        <option value="DDS">DDS.</option>
                                                                                        <option value="Almoço/Jantar">Almoço/Jantar.</option>
                                                                                        <option value="Café">Café.</option>
                                                                                        <option value="Processso Subsequente">Processo Subsequente.</option>
                                                                                        <option value="Manutenção">Manutenção.</option>
                                                                                        <option value="Falta De Mão De Obra">Falta De Mão De Obra.</option>
                                                                                        <option value="Falta De Matéria Prima (Falta De Sementes)">Falta De Matéria Prima (Falta De Sementes).
                                                                                        </option>
                                                                                        <option value="Treinamento">Treinamento.</option>
                                                                                        <option value="Queda De Energia">Queda De Energia.</option>
                                                                                        <option value="Limpeza">Limpeza.</option>
                                                                                        <option value="Ações De Segurança Do Trabalho">Ações De Segurança Do Trabalho.</option>
                                                                                        <option value="Troca De Turno/Final De Turno">Troca De Turno/Final De Turno.</option>
                                                                                        <option value="Regulagem De Equipamento">Regulagem De Equipamento.</option>
                                                                                        <option value="Equipamento Embuchado">Equipamento Embuchado.</option>
                                                                                        <option value="Falta De Máquina(Empilhadeira/Pá Carregadeira/Trator)">Falta De Máquina(Empilhadeira/Pá
                                                                                            Carregadeira/Trator).</option>
                                                                                        <option value="Vestindo/Retirando EPI">Vestindo/Retirando EPI.</option>
                                                                                        <option value="Aguardando Pesagem">Aguardando Pesagem.</option>
                                                                                        <option value="Problemas Com Etiquetas">Problemas Com Etiquetas.</option>
                                                                                        <option value="Mistura Entre Peneiras">Mistura Entre Peneiras.</option>
                                                                                        <option value="Equipe Liberada">Equipe Liberada.</option>
                                                                                        <option value="Decisão Gerencial">Decisão Gerencial.</option>
                                                                                    </select><br>
                                                                                        <hr>
                                                                                            <h2>Descrição Da Parada.</h2>
                                                                                            <input required type="textarea" id="textarea" name="Descrição De Parada." class="caixa-texto"
                                                                                                placeholder="Descrição De Parada.">
                                                                                                <hr>
                                                                                                    <h2>Parada:</h2>
                                                                                                    <label for="Geral">Geral</label>
                                                                                                    <input required type="radio" id="Geral" name="Parada Geral/Equipamento" value="Geral."><br>
                                                                                                        <label for="Equipamento">Equipamento</label>
                                                                                                        <input type="radio" id="Equipamento" name="Parada Geral/Equipamento" value="Equipamento.">
                                                                                                            <hr>
                                                                                                                <h2>Número Da Frota Do Equipamento Parado:<br> <sub>(Em Caso De Manutenção.)</sub></h2>

                                                                                                                <input required type="textarea" id="textarea" name="Número Da Frota Do Equipamento Parado." class="caixa-texto"
                                                                                                                    placeholder="Número Da Frota Do Equipamento Parado.">
                                                                                                                    <hr>
                                                                                                                        <h2>Número Da O.S:<br><sub>(Se Houver Manutenção Mecânica/Elétrica.)</sub></h2>
                                                                                                                        <input required type="textarea" id="textarea" name="Número Da O.S." class="caixa-texto"
                                                                                                                            placeholder="Número Da O.S.">
                                                                                                                            <hr>
                                                                                                                                <h2>Data Final Da Parada.</h2>
                                                                                                                                <input required type="date" id="txtdate" name="Data Final Da parada." class="caixa-texto"><br>
                                                                                                                                    <hr>
                                                                                                                                        <h2>Hora Final Da Parada.</h2>
                                                                                                                                        <input required type="time" id="txthora" name="Hora Final Da Parada" class="caixa-texto"><br>
                                                                                                                                            <hr>
                                                                                                                                                <h2> Responsável Pelo Apontamento:</h2>

                                                                                                                                                <input required type="textarea" id="textarea" name="Responsável Pelo Apontamento." class="caixa-texto"
                                                                                                                                                    placeholder="Responsável Pelo Apontamento">

                                                                                                                                                    <hr><br><br>

                                                                                                                                                        <input type="submit">
                                                                                                                                                        </form>



                                                                                                                                                    </body>

                                                                                                                                                    </html>