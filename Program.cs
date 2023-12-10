using DesafioPOO.Models;

Smartphone nokia = new Nokia(numero: "11993322933", modelo: "C12", imei: "111223445", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");

Smartphone iphone = new Iphone(numero: "11922334455", modelo: "14 plus", imei: "223111223", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
