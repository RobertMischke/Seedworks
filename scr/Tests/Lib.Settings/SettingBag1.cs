using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seedworks.Lib.Settings;

namespace Seedworks.Tests.Lib.Settings
{
    public class SettingBag1 : SettingBag
    {
        public static readonly string TypeName = SettingType.From(typeof(SettingBag1));

        public SettingString String1 { get { return Get<SettingString>("Key_String1"); } }
        public SettingString String2 { get { return Get<SettingString>("Key_String2", "SomeDefaultValue"); } }

        public SettingInteger Integer1 { get { return Get<SettingInteger>("Key_Int", "99"); } }
        public SettingBoolean Boolean1 { get { return Get<SettingBoolean>("Key_Bool1", "true"); } }

        public SettingBag1(IList<Setting> settings)
            : base(settings, TypeName)
        {
        }

    }
}
