using System;
using System.Collections.Generic;
using System.Linq;

public class Cliente{
    public string  Cpf;
    public string  Nome;
    public List<Compra> Compras;

    public Cliente(string Cpf, string Nome)
    {
        this.Cpf  = Cpf;
        this.Nome = Nome;
    }

    public Compra NovaCompra(){
        Compra c  = new Compra();
        c.Cliente = this;
        return c;
    }
}