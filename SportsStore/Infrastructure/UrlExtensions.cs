﻿using Microsoft.AspNetCore.Http;

namespace SportsStore.Infrastructure
{
    public static class UrlExtensions
    {
        public static string PathAndQuery(this HttpRequest request)
        {
            if (request.QueryString.HasValue)
            {
                return $"{request.Path}{request.QueryString}";
            }
            else
            {
                return $"{request.Path}";
            }

        }
    }
}
