using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Client.Models;
namespace Client.ServiceAPI
{
   public interface IAccountAPI
    {
        List<Account> findAll();
    }
}
