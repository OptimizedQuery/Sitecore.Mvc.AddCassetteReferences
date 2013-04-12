Sitecore.Mvc.AddCassetteReferences
==================================

Example code for Setting up a pipeline processor to dynamically reference Cassette Bundles in a Sitecore MVC project.

Project Contents:
/Processor/AddCassetteReferecens.cs - Example processor which shows adding bundle references based on specific renderings being present on Context Item.
/App_Config/Include/Sitecore.Mvc.AddCassetteReferences.config - Example of where in the Sitecore pipeline the custom processor should be patched.

Other Notes:
The attribute 'rewriteHtml' must be set to 'false' in the Cassette configuration in the web.config.  
