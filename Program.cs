using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padrao_Repository
{
    // REPOSITORY GENERICO

    // OBS: Repositorio espefico é semelhante ao generico, o que muda, é o tipo (Ex: class produto)

    /*
     Um repositorio generico pode ser usado por qualquer entidade da camada de negocios e como isso economizamos codigo
     Porem, cada entidade da camada de dominio pode possuir suas particularidades distintas de outras entidades e isso pode inviabilizar o uso
     de um repositorio generico. 
     Assim para decidir é preciso fazer uma analise previa de modelo de dominio e das particularidades de cada entidade.

    Beneficios: 
    Minimiza a logica de consultas na sua aplicação evitando consultas esparramadas pelo seu codigo
    Encapsula a logica das consultas em um repositorio.
    desacopla a sua aplicação dos frameworks de persistencias com o EF Core.
    Facilita a realização de testes de unidade em sua aplicação.
    centraliza a logica de acesso a dados facilitando a manutenção
     */
    internal class Program
    {
        public class Repository<T> : IRepository<T> where T : class
        {
            public void Add(T item)
            {
                throw new NotImplementedException();
            }

            public void Delete(T item)
            {
                throw new NotImplementedException();
            }

            public IEnumerable<T> GetAll()
            {
                throw new NotImplementedException();
            }

            public T GetById(int id)
            {
                throw new NotImplementedException();
            }

            public void Update(T item)
            {
                throw new NotImplementedException();
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
