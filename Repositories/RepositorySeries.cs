
namespace DotNet_series;


public class RepositorySeries : IRepository<Series>
{

    private List<Series> listaSeries = new List<Series>();
    public void Delete(int id)
    {
        listaSeries[id].Excluir();
    }

    public void Insert(Series entidade)
    {
        listaSeries.Add(entidade);
    }

    public List<Series> Lista()
    {
        return listaSeries;
    }

    public int NextId()
    {
        return listaSeries.Count;
    }

    public Series RetornaPorId(int id)
    {
        return listaSeries[id];
    }

    public void Update(int id, Series entidade)
    {
        listaSeries[id] = entidade;
    }
}