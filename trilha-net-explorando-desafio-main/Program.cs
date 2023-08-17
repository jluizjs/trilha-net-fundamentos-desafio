using DesafioPOO.Models;

Iphone iphone = new Iphone("99990-0000", "Iphone 11", "123456789", 5);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Joginho");

Nokia nokia = new Nokia("99990-1111", "Tijolão", "987654321", 1);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Editor de fotos");

Console.ReadKey();