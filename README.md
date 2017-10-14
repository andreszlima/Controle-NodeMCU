## Resumo

Este programa foi criado como WPF (C#) com o intuito de controlar um NodeMCU através de um broker MQTT.

Em breve farei um tutorial partindo desde a compra do NodeMCU até controlar ele por um site especializado (gratuito) ou por este software (também gratuito). Caso alguém esteja interessado, pode me enviar um e-mail para andre.szlima1@gmail.com que farei de boa e postarei aqui.

## O que temos aqui

### Escolha seu broker

Testei com os dados fornecidos pelo "cloudmqtt" em sua versão gratuita e funcionou perfeitamente. Os campos para preenchimento de dados estão prontos para as informações fornecidas por lá.

### Controle

A luz no programa só mudará de estado quando receber um feedback do NodeMCU. Enquanto ele não enviar a mensagem de que seu estado atual é algum qualquer, a luz não mudará no programa.

## Motivação

Softwares de comunicação de IoT são muito feios e com funcionalidade duvidosa. Resolvi criar um pra fazer do jeito que eu gostaria que fosse e para aprender um pouco mais sobre IoT

## Uso

A pasta do arquivo executável deve ter consigo as dependências. Se usar só o executável não vai funcionar. Caso queira executar de outro local, basta criar um atalho.

O download da versão mais atual no momento pode ser feito aqui: https://github.com/andreszlima/Controle-NodeMCU/releases/latest

## Licença

A licença de uso é MIT. Você pode usar, modificar, publicar, vender, fazer o que quiser. Para mais informações, leia: [License.md](LICENSE.md)
