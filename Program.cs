using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("SmartPhone Nokia: ");
Smartphone nokia = new Nokia(numero:"54321", modelo:"modelo 01", imei:"22222", memoria: 69);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");


Console.WriteLine("\n");

Console.WriteLine("SmartPhone Iphone: ");
Smartphone iphone = new Iphone(numero: "98765", modelo:"modelo 03", imei: "33333", memoria: 120);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("telegram");