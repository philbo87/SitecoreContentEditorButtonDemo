using Sitecore.Diagnostics;
using Sitecore.Shell.Framework.Commands;
using System;

namespace Feature.DemoButton.Commands
{
    public class DemoButtonCommand : Command
    {
        public override void Execute(CommandContext context)
        {
            Sitecore.Context.ClientPage.ClientResponse.Alert("This demo is working!");
        }

        public override CommandState QueryState(CommandContext context)
        {
            Assert.ArgumentNotNull(context, "context");
            if (context.Items[0].Name.Equals("Disabled", StringComparison.CurrentCultureIgnoreCase))
            {
                return CommandState.Disabled;
            }

            return base.QueryState(context);
        }
    }
}