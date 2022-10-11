using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TESTINTERVIEW.Data
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        public string Title { get; set; }

        public string MoviRating { get; set; }

        public string MovieImageURL { get; set; }

        public string MovieGenre { get; set; }

        public string MovieYear { get; set; }

        public string MovieRuntime { get; set; }

        public string MovieDirectort { get; set; }

        public string MovieStars { get; set; }


    }
}
