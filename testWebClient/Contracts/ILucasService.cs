using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using testWebClient.Model;

namespace testWebClient.Contracts
{
    public interface ILucasService
    {
        public  Task<Root> GetDataAsync();
    }
}
