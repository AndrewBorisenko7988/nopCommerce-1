using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Core.Caching;
using Nop.Plugin.Widgets.InfoPanel.Models;
using Nop.Services.Caching;
using Nop.Services.Configuration;
using Nop.Web.Framework.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nop.Plugin.Widgets.InfoPanel.Components
{
    [ViewComponent(Name = "WidgetsInfoPanel")]
    public class WidgetsInfoPanelViewComponent: NopViewComponent
    {
        private readonly IStoreContext _storeContext;
        private readonly ISettingService _settingService;

        public WidgetsInfoPanelViewComponent(IStoreContext storeContext,
            ISettingService settingService)
        {
            _storeContext = storeContext;
            _settingService = settingService;
        }

        public IViewComponentResult Invoke(string widgetZone, object additionalData)
        {
            var infoPanelSettings = _settingService.LoadSetting<InfoPanelSettings>(_storeContext.CurrentStore.Id);

            var model = new PublicInfoPanelModel
            {           
                Text = infoPanelSettings.Text,               
            };



            return View("~/Plugins/Widgets.InfoPanel/Views/PublicInfo.cshtml", model);
        }
    }
}
