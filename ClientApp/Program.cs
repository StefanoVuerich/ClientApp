
// See https://aka.ms/new-console-template for more information
using MyClassLibrary;

Console.WriteLine("Hello, World!");

//MyService service = new MyService();
//service.SendMail();

IMailService serviceGmail = new MailServiceGmail();
serviceGmail.SendMail("from@gmail.com", "to@gmail.com");