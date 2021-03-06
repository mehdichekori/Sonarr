﻿using RestSharp;
using NzbDrone.Common.EnvironmentInfo;

namespace NzbDrone.Core.Rest
{
    public static class RestClientFactory
    {
        public static RestClient BuildClient(string baseUrl)
        {
            var restClient = new RestClient(baseUrl)
            {
                UserAgent = $"{BuildInfo.AppName}/{BuildInfo.Version} ({OsInfo.Os})"
            };


            return restClient;
        }
    }
}
