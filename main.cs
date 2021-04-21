using System;

class MainClass {
    public static void Main (string[] args) {
        Roupa camisa  = new Roupa(   1, "M", 50, "Camisa oficial Flamengo", 200);        
        Roupa bermuda = new Roupa(   2, "M", 80, "Short oficial Flamengo" ,  75);
        Roupa meiao   = new Roupa(3456, "M", 35, "Meião oficial Flamengo" ,  50);

        Cliente tony     = new Cliente("123.456.789-80", "Tony Stark"       );
        Cliente peter    = new Cliente("987.654.321.00", "Peter Parker"     );
        Cliente natascha = new Cliente("123.456.789-80", "Natascha Romanova");

        Compra compraDoPeter = peter.NovaCompra();
        compraDoPeter.AdicionarRoupa(camisa , 2, 200);
        compraDoPeter.AdicionarRoupa(bermuda, 1,  75);
        compraDoPeter.AdicionarRoupa(meiao  , 1,  50);

        Console.WriteLine("Valor total da compra do Peter Parker: "+ compraDoPeter.Valor);
    }
}