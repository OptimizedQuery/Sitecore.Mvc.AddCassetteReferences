using Sitecore.Mvc.Pipelines.Response.BuildPageDefinition;
using Sitecore.Mvc.Presentation;

namespace Sitecore.Mvc.AddCassetteReferences.Processor
{
	/// <summary>
	/// mvc.BuildPageDefinition pipeline processor to dynamically reference Cassette Bundles
	/// </summary>
	public class AddCassetteReferences : BuildPageDefinitionProcessor
	{
		public override void Process(BuildPageDefinitionArgs args)
		{
			ApplyDefaultReferences();
			ApplyRenderingSpecificReferences(args);
		}

		/// <summary>
		/// Applies the default references to Cassette bundles.
		/// </summary>
		protected void ApplyDefaultReferences()
		{
			/* Example of references that apply to all pages
			 * 
			 Bundles.Reference("css");
			 Bundles.Reference("js", "footer");
			 */
		}

		/// <summary>
		/// Applies the rendering specific references to Cassette bundles.
		/// </summary>
		/// <param name="args">The args.</param>
		protected void ApplyRenderingSpecificReferences(BuildPageDefinitionArgs args)
		{
			foreach (Rendering rendering in args.PageContext.PageDefinition.Renderings)
			{
				switch (rendering.Id.ToString())
				{
					/* Example of adding Bundle references based on the current item having a specific reference
					 * ItemReference is just a static class to reference ID's of specific items in Sitecore.
					 * 
					case ItemReference.SliderPanelRendering:
						Bundles.Reference("js/vendor/jquery.flexslider.js", "footer");
						Bundles.AddInlineScript("$(document).ready(function() { $('.home-slider').flexslider({ pauseOnHover: true, slideshow: false }); });", "footer");
						break;
					*/
					default:
						break;
				}
			}
		}
	}
}
