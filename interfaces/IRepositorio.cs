using System.Collections.Generic;

namespace Dio.Series.interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lista();
         T RetornaPorId(int id);
         void Insere(T entidade);
         void Excluir(int id);
         void Atualizar(int id, T entidade);
         int ProximoId();
         
    }
}