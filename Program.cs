using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia (numero: "9876543", modelo: "Modelo 1", imei: "123456789", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

System.Console.WriteLine("\n");
Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone (numero: "9876543", modelo: "Modelo 1", imei: "123456789", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("telegram");
