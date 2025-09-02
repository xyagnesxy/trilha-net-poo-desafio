using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia("123", "seila", "123123", 64);
Smartphone iphone = new Iphone("456", "outro sei la", "456456", 32);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("instagram");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("face");