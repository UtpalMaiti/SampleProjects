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
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "d0f5b32ae5764bae82181f19364f5d27";
    }
}
