using System;
using RestSharp;

namespace MyGalileoLibrary
{
    public static class InternetManager
    {
        public static bool CheckForInternetConnection()
        {
            string url = $"http://clients3.google.com/generate_204";

            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
