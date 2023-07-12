using App.ALL.Debugging;

namespace App.ALL
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
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "1ebd6856883f40a1b7670d573ebaccff";
    }
}
