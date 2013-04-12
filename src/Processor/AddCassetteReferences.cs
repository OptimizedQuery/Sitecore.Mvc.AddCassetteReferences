using Sitecore.Data.Items;
using Sitecore.Layouts;
using Sitecore.Mvc.Pipelines.Response.BuildPageDefinition;

namespace Sitecore.Mvc.AddCassetteReferences.Processor
{
	/// <summary>
	/// mvc.BuildPageDefinition pipeline processor to dynamically reference Cassette Bundles
	/// </summary>
	public class AddCassetteReferences : BuildPageDefinitionProcessor
	{
		public override void Process(BuildPageDefinitionArgs args)
		{
			Item currentItem = args.PageContext.Item;
			DeviceItem currentDevice = args.PageContext.Device.DeviceItem;
			if (currentItem != null && currentDevice != null)
			{
				ApplyDefaultReferences();
				ApplyRenderingSpecificReferences(currentItem, currentDevice);
			}
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
		/// <param name="currentItem">The current item.</param>
		/// <param name="currentDevice">The current device.</param>
		protected void ApplyRenderingSpecificReferences(Item currentItem, DeviceItem currentDevice)
		{
			foreach (RenderingReference renderingReference in currentItem.Visualization.GetRenderings(currentDevice, true))
			{
				switch (renderingReference.RenderingID.ToString())
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
