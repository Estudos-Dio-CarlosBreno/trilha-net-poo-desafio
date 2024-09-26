using DesafioPOO.Models;



Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "9288013300", modelo: "Modelo1", imei: "111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");


Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "923300", modelo: "Modelo2", imei: "2221", memoria: 164);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");
// TODO: Realizar os testes com as classes Nokia e Iphone