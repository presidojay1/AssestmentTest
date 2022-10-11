using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TESTINTERVIEW.Data;
using TESTINTERVIEW.Model;

namespace TESTINTERVIEW.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly DataContext _context;
        public MovieRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<MovieModel> GetMovieByIdAsync(string MovieId)
        {

            var client = new RestClient("https://www.omdbapi.com/?t=" + MovieId + "&apikey=af5fee6");
            IRestRequest restRequest = new RestRequest("", Method.GET, DataFormat.Json);
            var response = await client.ExecuteAsync(restRequest);
            if (response.IsSuccessful)
            {
                var content = JsonConvert.DeserializeObject<JToken>(response.Content);
                if (response.Content == "{\"Response\":\"False\",\"Error\":\"Movie not found!\"}")
                {
                    return null;
                }
                var Title = content["Title"].Value<string>();
                var MovieRating = content["imdbRating"].Value<string>();
                var MovieRuntime = content["Runtime"].Value<string>();
                var MovieDirectort = content["Director"].Value<string>();
                var MovieYear = content["Year"].Value<string>();
                var MovieImageURL = content["Poster"].Value<string>();
                var MovieStars = content["Actors"].Value<string>();
                var Genre = content["Genre"].Value<string>();

                var nemovie = new MovieModel()
                {
                    Title = Title,
                    MovieRating = MovieRating,
                    MovieRuntime = MovieRuntime,
                    MovieDirectort = MovieDirectort,
                    MovieYear = MovieYear,
                    MovieImageURL = MovieImageURL,
                    MovieStars = MovieStars,
                    MovieGenre = Genre,
                };

                return nemovie;


            }
            return null;
        }
    }
}
