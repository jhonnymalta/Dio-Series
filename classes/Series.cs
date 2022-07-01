namespace DotNet_series;


public class Series : EntidadeBase
{
    public Series(int id, Genero genero, string titulo, string descricao, int ano)
    {
        Id = id;
        Genero = genero;
        Titulo = titulo;
        Descricao = descricao;
        Ano = ano;
        Excluido = false;
    }

    private Genero Genero { get; set; }
    private string Titulo { get; set; }
    private string Descricao { get; set; }
    private int Ano { get; set; }
    private bool Excluido { get; set; }

    public override string ToString()
    {
        return @$"Filme do gênero {Genero}, 
               Gravado no ano de {Ano}.
               Ganhou as telinhas o o Título de {Titulo}.
               --------------
               {Descricao}.";

    }

    public string RetornaTitulo()
    {
        return this.Titulo;
    }
    public int RetornaId()
    {
        return this.Id;
    }
    public void Excluir()
    {
        Excluido = true;
    }
}
