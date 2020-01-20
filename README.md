# Custom Ribbon Buttons for Sitecore Content Editor

## Prerequesites
Sitecore 9.2

## Getting this demo running locally
1. Install the Sitecore Package [Sitecore Content Editor Button Demo-1.0.zip](https://github.com/philbo87/SitecoreContentEditorButtonDemo/blob/master/Sitecore%20Content%20Editor%20Button%20Demo-1.0.zip)
1. Create a publish profile in this solution to publish to your local Sitecore site
1. Publish your changes to your local IIS website

## Basic steps on accomplishing this from the ground up
1. Write the command [DemoButtonCommand.cs](https://github.com/philbo87/SitecoreContentEditorButtonDemo/blob/master/Feature.DemoButton/Commands/DemoButtonCommand.cs) is a simple example.
1. Register implementation as an available command using Sitecore Configuration [z.Feature.DemoButton.config](https://github.com/philbo87/SitecoreContentEditorButtonDemo/blob/master/Feature.DemoButton/App_Config/Include/z.Feature.DemoButton.config) does this in this solution.
1. Setup new Chunk in /sitecore/content/Applications/Content Editor/Ribbons/Chunks in Core DB using /sitecore/templates/System/Ribbon/Chunk template
1. Add button as a child of newly created Chunk using template /sitecore/templates/System/Ribbon/Large Button 
1. Add Reference to the newly created Chunk to an existing Strip in the ribbon, such as /sitecore/content/Applications/Content Editor/Ribbons/Strips/Home. Reference is of type /sitecore/templates/System/Reference 