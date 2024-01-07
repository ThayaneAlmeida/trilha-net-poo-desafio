using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "1111", modelo: "iPhone 15", imei: "11112222-22", memoria: 516);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "2323", modelo: "G11 Plus", imei: "33334444-43", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

