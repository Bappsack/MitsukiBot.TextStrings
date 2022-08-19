namespace Chatbot_TextStrings
{
    public static class Discord_TextStrings
    {
        public static class ErrorStrings
        {
            public readonly static string IllegalFileProvided = "{0} your provided file is illegal. Trade cancelled!";

            public readonly static string InvalidFileTypeGeneral = "{0} your provided file is not supported. Trade cancelled!";
            public readonly static string InvalidFileTypePK6 = "{0} your provided file is not supported in XY/ORAS, please use a .PK6 file. Trade cancelled!";
            public readonly static string InvalidFileTypePK7 = "{0} your provided file is not supported in SM/USUM, please use a .PK7 file. Trade cancelled!";
            public readonly static string InvalidFileTypePK8 = "{0} your provided file is not supported in SWSH, please use a .PK8 file. Trade cancelled!";
            public readonly static string InvalidFileTypePB8 = "{0} your provided file is not supported in BDSP, please use a .PB8 file. Trade cancelled!";
            public readonly static string InvalidFileTypePA8 = "{0} your provided file is not supported in PLA, please use a .PA8 file. Trade cancelled!";
        }

        public static class ResponseStrings
        {
            public readonly static string DumpMessageLegal = "This is what you traded to me. This Pokémon is legal!\n\n{0}";
            public readonly static string DumpMessageIllegal = "This is what you traded to me. This Pokémon is illegal!\n\n{0}";
        }
    }
}