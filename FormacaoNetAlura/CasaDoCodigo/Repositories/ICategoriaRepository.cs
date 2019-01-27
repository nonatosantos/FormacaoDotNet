using CasaDoCodigo.Models;

namespace CasaDoCodigo.Repositories
{
    public interface ICategoriaRepository
    {
        Categoria AddCategoria(string nome);
    }
}