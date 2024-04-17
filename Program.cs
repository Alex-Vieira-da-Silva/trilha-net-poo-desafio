using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia= new Nokia("7305698", "Modelo 730", "3333655", 64);
Console.WriteLine("Smartphone Nokia:");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Smartphone iphone = new Iphone("6985441", "Modelo 13", "1112336", 128);
Console.WriteLine("Smartphone Iphone:");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");