using System;

namespace FubuCore.Conversion
{
    public interface IConversionRequest
    {
        string Text { get; }
        T Get<T>();
		object Get(Type type);

        IConversionRequest AnotherRequest(string text);
    }
}