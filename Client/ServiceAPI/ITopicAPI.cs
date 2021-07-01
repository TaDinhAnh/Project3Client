using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Models;
namespace Client.ServiceAPI
{
    public interface ITopicAPI
    {
        List<Topic> FindAll();
    }
}
