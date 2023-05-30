using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;
using UmbracoPOC.Data;
using UmbracoPOC.Models;

namespace UmbracoPOC.Controllers
{
	public class MoviesController : RenderController
	{
        private readonly UmbracoDbContext _dbContext;
        private readonly IVariationContextAccessor _variationContextAccessor;
        private readonly ServiceContext _serviceContext;
        public MoviesController(ILogger<MoviesController> logger, ICompositeViewEngine compositeViewEngine, IUmbracoContextAccessor umbracoContextAccessor, IVariationContextAccessor variationContextAccessor, ServiceContext context, UmbracoDbContext dbContext)
            : base(logger, compositeViewEngine, umbracoContextAccessor)
        {
            _dbContext = dbContext;
            _variationContextAccessor = variationContextAccessor;
            _serviceContext = context;
        }


        public IActionResult Movies()
        {
            // you are in control here!

            var movies = _dbContext.Movies.ToList();

            var movieViewModel = new MovieViewModel(CurrentPage, new PublishedValueFallback(_serviceContext, _variationContextAccessor))
            {
                Movies = movies
            };
            // return a 'model' to the selected template/view for this page.
            return CurrentTemplate(movieViewModel);
		}

	}
}
