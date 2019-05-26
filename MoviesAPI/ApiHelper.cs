using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Newtonsoft.Json.Linq;

namespace MoviesAPI
{
    public class ApiHelper
    {
        private readonly string _authToken;
        private readonly string _baseUrl;

        public ApiHelper()
        {
            _authToken = "34ff968449f0ae5e6315dfc14a7e6625";
            _baseUrl = "https://api.themoviedb.org/3/";
        }

        //public Task<MovieModel> GetMovie()
        //{
        //    var result = _baseUrl
        //    .AppendPathSegment("movie/550")
        //    .WithOAuthBearerToken(_authToken)
        //    .GetJsonAsync<MovieModel>();

        //    return result;
        //}https://api.themoviedb.org/3/movie/550?api_key=34ff968449f0ae5e6315dfc14a7e6625

        public MovieModel GetMovie()
        {
            string appendUrl = "movie/550";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_baseUrl + appendUrl);
            request.Method = "GET";
            //request.Headers.Add("Authorization", "Bearer " + _authToken);
            request.Headers.Add(HttpRequestHeader.Authorization, _authToken);
            

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if(response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception(response.StatusCode.ToString() + response.StatusDescription);
                }

                //request.Headers.Add("api_key", _authToken);

                using (Stream responseStream = response.GetResponseStream())
                {
                    if(responseStream != null)
                    {
                        using(StreamReader reader = new StreamReader(responseStream))
                        {
                            string strResponseValue = reader.ReadToEnd();
                            
                        }
                    }
                }
            }
            return null;
        }
    }
}
