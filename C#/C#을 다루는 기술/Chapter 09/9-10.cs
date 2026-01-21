// 새롭게 개발한 FormattableString 구현체

using System.Globalization;

namespace System.Runtime.CompilerServices
{
    internal static class FormattableStringFactory
    {
        internal static FormattableString Create(
            string format, params object[] arguments) =>
            new FormattableString(format, arguments);
    }
}

namespace System
{
    internal class FormattableString : IFormattable
    {
        public string Format { get; }
        private readonly object[] arguments;

        internal FormattableString(string format, object[] arguments)
        {
            Format = format;
            this.arguments = arguments;
        }

        public object GetArgument(int index) => arguments[index];
        public object[] GetArguments() => arguments;
        public int ArgumentCount => arguments.Length;
        public static string Invariant(FormattableString formattable) =>
            formattable?.ToString(CultureInfo.InvariantCulture);

        public string ToString(IFormatProvider formatProvider) =>
            string.Format(formatProvider, Format, arguments);
        public string ToString(
            string ignored, IFormatProvider formatProvider) =>
            ToString(formatProvider);
    }
}