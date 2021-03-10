//@BaseCode
using System;

namespace CommonBase.Extensions
{
    public static class ObjectExtensions
    {
        public static void CheckArgument(this object src, string argName)
        {
            if (src == null)
                throw new ArgumentNullException(argName);
        }
    }
}
