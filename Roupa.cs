using System;
using System.Collections.Generic;
using System.Linq;

public class Roupa
{
    public int     CodIdentificador;
    public string  Tamanho;
    public int     QtdEstoque;
    public string  Descricao;
    public decimal Valor;

    public List<RoupaComprada> Vendas;

    public Roupa(int codigo, string tamanho, int qtdEstoque, string descricao, decimal valor)
    {
        CodIdentificador = codigo;
        Tamanho          = tamanho;
        QtdEstoque       = qtdEstoque;
        Descricao        = descricao;
        Valor            = valor;
    }
}