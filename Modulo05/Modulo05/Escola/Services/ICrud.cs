using Modulo05.Escola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo05.Escola.Services
{
    public interface ICrud<T> where T : BaseModel
    {
        void Create(T model);
        IEnumerable<T> Read();
        void Update(T model);
        void Delete(int id);
    }
}
