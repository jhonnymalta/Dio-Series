using System.Collections.Generic;
namespace DotNet_series;


public interface IRepository<T>
{
    List<T> Lista();
    T RetornaPorId(int id);
    void Insert(T entidade);
    void Delete(int id);
    void Update(int id, T entidade);
    int NextId();
}