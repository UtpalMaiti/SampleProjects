using ALL.ALL.Debugging;

namespace ALL.ALL
{
    public class ALLConsts
    {
        public const string LocalizationSourceName = "ALL";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "56631ffb98e445a380cb8efcabb6e542";
    }
}
