using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Nokia n1 = new Nokia(numero: "123456789", modelo: "Nokia", imei: "11111111", memoria: 120);
n1.Ligar();
n1.InstalarAplicativo("Facebook");

Console.WriteLine("-------------");

Console.WriteLine("Smartphone Iphone");
Iphone i1 = new Iphone(numero: "987654321", modelo: "Iphone", imei: "222222222", memoria: 240);
i1.ReceberLigacao();
i1.InstalarAplicativo("Instagram");