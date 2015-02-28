using AHCWebDeveloperExam.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace AHCWebDeveloperExam.Helper
{
    public class ServerDataRestClient : IServerDataRestClient
    {
        private readonly RestClient _client;
        private readonly string _url = ConfigurationManager.AppSettings["webapibaseurl"];

        public ServerDataRestClient()
        {
            _client = new RestClient(_url);
        }

        public IEnumerable<OrderSummaryModel> GetAll(string theType)
        {
            if (theType == null || theType.Length == 0)
                throw new Exception("Data type is null!");

            OrderType theTypeEnum = (OrderType)Enum.Parse(typeof(OrderType), theType, true);

            string restReqStr = "api/OrderSummary/";

            switch (theTypeEnum)
            {
                case OrderType.WEEKLY: restReqStr += "WeekOverWeek"; break;
                case OrderType.MONTHLY: restReqStr += "MonthOverMonth"; break;
                case OrderType.YEARLY: restReqStr += "YearOverYear"; break;

                default:
                    throw new Exception("Incorrect data type sent!");
            }

            var request = new RestRequest(restReqStr, Method.GET) { RequestFormat = DataFormat.Json };

            var response = _client.Execute<List<OrderSummaryModel>>(request);

            if (response.Data == null)
                throw new Exception(response.ErrorMessage);

            return response.Data;
        }

    }
}