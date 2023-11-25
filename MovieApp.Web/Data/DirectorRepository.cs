using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApp.Web.Entities;

namespace MovieApp.Web.Data
{
    public static class DirectorRepository
    {
        private static readonly List<Director> directors = null;
         
        static DirectorRepository()
        {
            directors = new List<Director>
            {
                new Director{Id = 1, Name = "Matt Eskandari", ImageUrl = "d1.jpg", Biography="Matt Eskandari is an Iranian-born American film director and screenwriter. His films include Victim, The Gauntlet, and 12 Feet Deep. He was also a contestant on the Fox Studios and Steven Spielberg filmmaker competition On the Lot."},
                new Director{Id = 2, Name = "Zoe Lister-Jones", ImageUrl = "d2.jpeg", Biography="Zoe Lister-Jones is an American actress and filmmaker who co-starred as Jen Collins Short in the CBS sitcom Life in Pieces from 2015 to 2019. She is also known for her roles in the television shows Delocated, Whitney, and New Girl. Lister-Jones made her directorial debut with the 2017 comedy-drama film Band Aid."},
                new Director{Id = 3, Name = "Christopher Nolan", ImageUrl = "d3.jpeg", Biography="Christopher Edward Nolan CBE is a British and American filmmaker. Known for his Hollywood blockbusters with complex storytelling, Nolan is considered a leading filmmaker of the 21st century. His films have grossed more than $6 billion worldwide."},
                new Director{Id = 4, Name = "Christopher Forbes", ImageUrl = "d4.jpg", Biography="Christopher Kip Forbes is vice chairman of the Forbes Publishing company. He attended St. Mark's School in Southborough, Massachusetts, and Princeton University. His brother is Steve Forbes, who has made multiple runs for the U.S. presidency and written some in-depth political and economic narratives."},
                new Director{Id = 5, Name = "Eshom Nelms", ImageUrl = "d5.jpg", Biography="Writers/Directors Eshom and Ian Nelms, grew up in central California waging two hundred man G.I. Joe wars and dreaming in John Ford Landscapes. Though their evolving passions temporarily took them in different directions - Ian went to college on a wrestling scholarship, along the way discovering a new interest for English and Literature, and Eshom pursued an education in fine art painting, but found the illustration of comic books better suited to his tastes - the two would always find themselves returning to their love of film. While Ian has produced various projects independently and Eshom has worked as a professional storyboard artist for over a decade, the Nelms Brothers always write and direct together and have made multiple award-winning short and feature films."},
                new Director{Id = 6, Name = "Dimitri Logothetis", ImageUrl = "d6.jpg", Biography="Logothetis was born in Athens, Greece,[3] and immigrated to the United States of America at the age of six with his mother, Anna, and his father, Euthymios. Euthymios moved to the United States to join his family, spending eight years working as a mechanic in Los Angeles and becoming an American citizen."},
            };
        } 

        public static List<Director> Directors => directors;
    }
}