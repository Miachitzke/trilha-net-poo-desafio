using DesafioPOO.Models;

// Instancia de teste do Nokia
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "97478716", modelo: "Tijolão", imei: 111111111, memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");
Console.WriteLine("\n");

// Instancia de teste do iPhone
Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "707070", modelo: "XR", imei: 302329252, memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");