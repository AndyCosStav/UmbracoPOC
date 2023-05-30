using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace UmbracoPOC.Models
{
    public class Movie
    {

        public int Id { get; set; } 
        public string Title { get; set; } 
        public string Description { get; set; }
        public int Rating { get; set; }
    }
}
