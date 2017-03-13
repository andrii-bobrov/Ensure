using System;

namespace Ensure
{
    public static class Throw
    {
        public static T New<T>(string message) where T : Exception
        {
            throw (T) Activator.CreateInstance(typeof(T), message);
        }

        public static T New<T>() where T : Exception, new()
        {
            throw new T();
        }
    }
}
