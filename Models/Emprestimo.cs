using System;

public class Emprestimo
{
	public Cliente Cliente { get; set; }
	public Livro Livro { get; set; }

	public DateTime DataInicio { get; set; }
	public DateTime DataDevolucaoPrevista { get; set; }
	public DateTime? DataDevolucaoReal { get; set; }

	public bool Devolvido { get; set; }
	public decimal Multa { get; set; }

	public Emprestimo()
	{
	}
}