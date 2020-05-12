﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CushyTripV1.Class
{
    class MessageUtility
    {
        public static bool SendMessage(string json, string method)
        {
            string api = "http://192.168.1.20:3000/api/chat/sendMessage";



            RestClient rClient = new RestClient();
            rClient.endPoint = api;

            switch (method)
            {
                case "POST":
                    rClient.httpMethod = httpVerb.POST;
                    rClient.postJSON = json;
                    break;
                default:
                    rClient.httpMethod = httpVerb.GET;
                    break;
            }

            string strResponse = string.Empty;
            strResponse = rClient.makeRequest();

            return true;
        }
    }
}
