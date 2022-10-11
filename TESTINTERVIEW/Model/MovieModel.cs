using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TESTINTERVIEW.Data;

namespace TESTINTERVIEW.Model
{
    public class MovieModel
    {
        [Key]
        public int MovieId { get; set; }

        public string Title { get; set; }

        public string MovieRating { get; set; }

        public string MovieImageURL { get; set; }

        public string MovieGenre { get; set; }

        public string MovieYear { get; set; }

        public string MovieRuntime { get; set; }

        public string MovieDirectort { get; set; }

        public string MovieStars { get; set; }
    }
}
