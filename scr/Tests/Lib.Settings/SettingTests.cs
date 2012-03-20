using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Seedworks.Lib.Settings;

namespace Seedworks.Tests.Lib.Settings
{
    [TestFixture]
    public class SettingTests : BaseTestSetting
    {
        [Test]
        public void Should_store_settings()
        {
            var settingsLoader = Resolve<SettingBag1Loader>();
            var settings1 = settingsLoader.Get();
            Assert.That(settings1.String1.Value, Is.EqualTo(""));
            Assert.That(settings1.String1.IsDefault(), Is.True);
            Assert.That(settings1.Integer1.Value, Is.EqualTo(99));

            settings1.String1.Value = "SomeValue";
            settings1.Integer1.Value = 88;
            settingsLoader.Update(settings1);

            var settings2 = Resolve<SettingBag1Loader>().Get();
            Assert.That(settings2.String1.Value, Is.EqualTo("SomeValue"));
            Assert.That(settings2.Integer1.Value, Is.EqualTo(88));
        }
    }
}
