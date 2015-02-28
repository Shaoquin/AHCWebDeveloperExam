using AHCWebDeveloperExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHCWebDeveloperExam.Helper
{
    public interface IServerDataRestClient
    {
        IEnumerable<OrderSummaryModel> GetAll(string theType);
    }
}
