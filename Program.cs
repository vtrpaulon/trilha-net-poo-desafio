using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "988779944", modelo: "modelo plus", imei: "123456789", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "977446699", modelo: "modelo 20", imei: "444555789", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo();
