using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seedworks.Lib.Settings;

namespace Seedworks.Tests.Lib.Settings
{
    public class SettingBag1Loader
    {
        private readonly SettingStorage _settingStorage;

        public SettingBag1Loader(SettingStorage settingStorage)
        {
            _settingStorage = settingStorage;
        }

        public SettingBag1 Get()
        {
            return new SettingBag1(_settingStorage.GetAllCached());
        }

        public void Update(SettingBag1 settingBag1)
        {
            _settingStorage.Update(settingBag1.SettingList);
        }
    }
}
