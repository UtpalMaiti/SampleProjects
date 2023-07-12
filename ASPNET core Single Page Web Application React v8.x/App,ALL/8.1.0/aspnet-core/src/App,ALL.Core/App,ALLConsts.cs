using App,ALL.Debugging;

namespace App,ALL
{
    public class App,ALLConsts
    {
        public const string LocalizationSourceName = "App,ALL";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "9363799177794ad3a0248ef4a37251af";
    }
}
