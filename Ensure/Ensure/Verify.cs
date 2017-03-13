using System;

namespace Ensure
{
    public static class Verify
    {
        public static void NotNull<T>(object source, string message) where T : Exception
        {
            if (source == null)
            {
                Throw.New<T>(message);
            }
        }

        public static void NotNull<T>(object source) where T : Exception
        {
            NotNull<T>(source, "Source object is null");
        }
    }
}
