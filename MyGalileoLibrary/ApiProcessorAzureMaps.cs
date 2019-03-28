using System;
using RestSharp;
using Newtonsoft.Json;

namespace MyGalileoLibrary
{
    public static class ApiProcessorAzureMaps
    {
        public static ApiModelAzureMaps GetPoi(string PoiType, double Latitude, double Longitude)
        {
            string url = $"https://atlas.microsoft.com/search/poi/json?api-version=1.0&query={ PoiType }&lat={ Latitude }&lon={ Longitude }&limit=1";

            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);

            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Authorization", ConstAndParams.AzureMapsAuthorization);
            request.AddHeader("X-ms-client-id", ConstAndParams.AzureMapsKey);

            try
            {
                IRestResponse response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    string JsonContent = response.Content;

                    dynamic NewObject = JsonConvert.DeserializeObject<dynamic>(JsonContent);

                    ApiModelAzureMaps poi = new ApiModelAzureMaps
                    {
                        Name = NewObject.results[0].poi.name,
                        Distance = NewObject.results[0].dist
                    };
                    return poi;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}