using System;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

class Program
{
    static void Main()
    {
        Console.Write("Digite o e-mail do destinatário: ");
        string destinatario = Console.ReadLine();

        Console.Write("Digite o assunto do e-mail: ");
        string assunto = Console.ReadLine();

        Console.Write("Digite a mensagem: ");
        string mensagem = Console.ReadLine();

        try
        {
            EnviarEmail(destinatario, assunto, mensagem);
            Console.WriteLine("✅ E-mail enviado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Erro ao enviar e-mail: {ex.Message}");
        }
    }

    static void EnviarEmail(string destinatario, string assunto, string mensagem)
    {
        string emailRemetente = "SEU_EMAIL_AQUI";  
        string senha = "SUA_SENHA_AQUI";

        var emailMessage = new MimeMessage();
        emailMessage.From.Add(new MailboxAddress("SEU_NOME_AQUI", emailRemetente));
        emailMessage.To.Add(new MailboxAddress("", destinatario));
        emailMessage.Subject = assunto;
        emailMessage.Body = new TextPart("plain") { Text = mensagem };


        using (var client = new SmtpClient())
        {
            client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            client.Authenticate(emailRemetente, senha);
            client.Send(emailMessage);
            client.Disconnect(true);
        }
    }
}
