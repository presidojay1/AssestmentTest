using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TESTINTERVIEW.Model;

namespace TESTINTERVIEW.Repository
{
   public  interface IMovieRepository
    {
        Task<MovieModel> GetMovieByIdAsync(string MovieId);
    }
}
