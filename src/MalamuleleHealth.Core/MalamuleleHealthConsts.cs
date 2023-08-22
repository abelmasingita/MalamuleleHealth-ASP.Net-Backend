using MalamuleleHealth.Debugging;

namespace MalamuleleHealth
{
    public class MalamuleleHealthConsts
    {
        public const string LocalizationSourceName = "MalamuleleHealth";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "b5d76f94361b447c8de50b972af36ce9";
    }
}
