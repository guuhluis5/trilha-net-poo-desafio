using DesafioPOO.Models;

static void Main()
    {
        Iphone iphone = new Iphone("1020", "Iphone11", "teste", 100);
        Nokia nokia = new Nokia("2010", "Nokia Tijolo", "testando", 100);

        nokia.Ligar();
        iphone.Ligar();

        nokia.InstalarAplicativo("WhatsApp");
        iphone.InstalarAplicativo("Instagram");

        nokia.ReceberLigacao();
        iphone.ReceberLigacao();
    }