### Custom Ribbon Buttons for Sitecore Content Editor
1. Write the command (DemoButtonCommand.cs)
1. Register implementation as an available command (z.Feature.DemoButton.config)
1. Setup new Chunk in /sitecore/content/Applications/Content Editor/Ribbons/Chunks in Core DB using /sitecore/templates/System/Ribbon/Chunk template
1. Add button as a child of newly created Chunk using template /sitecore/templates/System/Ribbon/Large Button 
1. Add Reference to the newly created Chunk to an existing Strip in the ribbon, such as /sitecore/content/Applications/Content Editor/Ribbons/Strips/Home. Reference is of type /sitecore/templates/System/Reference 