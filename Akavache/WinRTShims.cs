using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace System.IO
{
    public enum FileMode
    {
        CreateNew,
        Create,
        Open,
        OpenOrCreate,
        Truncate,
        Append,
    }

    public enum FileAccess
    {
        Read,
        Write,
        ReadWrite,
    }

    public enum FileShare
    {
        None,
        Read,
        Write,
        ReadWrite,
        Delete,
    }
}

namespace System.IO.IsolatedStorage
{
    class IsolatedStorageException : Exception { }
}