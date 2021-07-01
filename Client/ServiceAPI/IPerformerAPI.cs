using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Models;
namespace Client.ServiceAPI
{
    public interface IPerformerAPI
    {
        List<Performer> Find2(int idSeminar);
    }
}
