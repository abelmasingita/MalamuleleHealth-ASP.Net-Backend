using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace MalamuleleHealth.Localization
{
    public static class MalamuleleHealthLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(MalamuleleHealthConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(MalamuleleHealthLocalizationConfigurer).GetAssembly(),
                        "MalamuleleHealth.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
