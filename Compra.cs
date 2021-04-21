using System;
using System.Collections.Generic;
using System.Linq;

public class Compra
{
    public int Codigo;
    public decimal Valor;
    public Cliente Cliente;
    public List<RoupaComprada> Roupas;

    public Compra(){
        Roupas = new List<RoupaComprada>();
    }

    public void AdicionarRoupa(Roupa roupa, int qtd, decimal valor)
    {
        RoupaComprada rc = new RoupaComprada();
        rc.Qtd           = qtd;
        rc.ValorUnitario = valor;
        rc.Roupa         = roupa;
        rc.Compra        = this;

        Roupas.Add(rc);

        this.Valor = this.Valor + (valor * qtd);
    }
}