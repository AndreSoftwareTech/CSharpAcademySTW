using Modulo05.Escola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo05.Escola.Services
{
    public class CrudBase<B> : ICrud<B> where B : BaseModel
    {
        public void Create(B model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<B> Read()
        {
            throw new NotImplementedException();
        }

        public void Update(B model)
        {
            throw new NotImplementedException();
        }
    }
}
