using DesafioPOO.Models;

// Testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123123123", modelo: "Nokia 1", imei: "1111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "456456456", modelo: "iPhone 2", imei: "2222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");