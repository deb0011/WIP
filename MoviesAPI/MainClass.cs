using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesAPI
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            ApiHelper api = new ApiHelper();
            var result = api.GetMovie();
            //result.ContinueWith(SampleMethod, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private static void SampleMethod(Task<MovieModel> m)
        {
            
        }
    }
}
