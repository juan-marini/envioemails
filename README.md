## Aplicativo de Envio de E-mails - MailKit + MimeKit

Este aplicativo foi desenvolvido para enviar e-mails diretamente pelo console utilizando as bibliotecas MailKit e MimeKit em C#. O usuário insere o e-mail do destinatário, o assunto e a mensagem, e o envio é realizado através do servidor SMTP do Gmail. Esta é a primeira versão do projeto.

## Tecnologias utilizadas:
* C#
* MailKit (cliente SMTP)
* MimeKit (composição de e-mails)
* .NET SDK

## Funcionalidades:
* Entrada de dados pelo console:
  - E-mail do destinatário
  - Assunto
  - Mensagem
* Envio de e-mail autenticado via SMTP (Gmail)
* Exibição de mensagens de sucesso ou erro no envio

## Como usar:
1. Clone este repositório.
2. Instale as dependências `MailKit` e `MimeKit`, usando o NuGet:
3. Substitua o e-mail do remetente e a senha no código (`emailRemetente` e `senha`) com suas credenciais.
> ⚠️ Use uma **senha de app** no Gmail para segurança.
4. Compile e execute o programa com:
5. Siga as instruções no console para enviar um e-mail.

## Requisitos:
* .NET 6 ou superior
* Conta Gmail com autenticação por senha de app ativada

## Feito por:
### LinkedIn: [Juan Marini](https://www.linkedin.com/in/juan-marini/)
