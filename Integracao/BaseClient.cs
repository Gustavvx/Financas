﻿namespace Integracao
{
    // All the code in this file is included in all platforms.
    public class BaseClient
    {
            static readonly HttpClient _client = new HttpClient();
            string _baseUrl = "https://rvh98qbf-44321.brs.devtunnels.ms/";

            public async Task<HttpResponseMessage> GetShare(string shareSymbol)
            {
                string end = _baseUrl + "Share/" + shareSymbol;
                var response = await _client.GetAsync(end);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Erro ao buscar informações da ação");
                }
                return response;
            }
        }
    }

