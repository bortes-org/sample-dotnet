using System;
using System.Reflection;

namespace sample_dotnet
{
    public class Env
    {
        public static readonly Assembly Reference = typeof(Env).Assembly;

        public static readonly Version Version = Reference.GetName().Version;
    }
}
