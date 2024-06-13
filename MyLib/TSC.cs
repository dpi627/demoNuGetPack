using System.Runtime.InteropServices;

namespace MyLib
{
    public partial class TSC
    {
        // import the DLL
        [LibraryImport("TSCLIB.dll", EntryPoint = "about")]
        private static partial int about();

        // implement the method
        public static int About() => about();
    }
}
