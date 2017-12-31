using System.Collections.Generic;
using System.IO;
using static System.IO.Directory;

namespace Common.Functions.ListFilesUnderDirectory
{
    public static class DirectoryFileLister
    {
        private const string AllFiles = "*.*";

        public static IEnumerable<string> ListFiles(string path)
            => EnumerateFiles(path, AllFiles, SearchOption.AllDirectories);
    }
}
