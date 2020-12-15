using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Plugin.Widgets.InfoPanel.Models
{
    public class ConfigurationModel: BaseNopModel
    {
        public int ActiveStoreScopeConfiguration { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.InfoPanel.Text")]
        public string Text { get; set; }
        public bool Text_OverrideForStore { get; set; }
    }
}
