using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace UmbracoPOC.Models
{
    public class MovieViewModel : Movies
    {

		public MovieViewModel(IPublishedContent content, IPublishedValueFallback publishedValueFallback) : base(content, publishedValueFallback)
		{
		}
		public List<Movie> Movies { get; set; }
    }
}
