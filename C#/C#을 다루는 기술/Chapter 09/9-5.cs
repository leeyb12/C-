// FormattableString에 선언된 멤버들

public abstract class FormattableString : IFormattable
{
    protected FormattableString();
    public abstract object GetArgument(int index);
    public abstract object[] GetArgument();
    public static string Invariant(FormattableString formattable);
    string IFormattable.ToString
        (string ignored, IFormatProvider formatProvider);
    public override string ToString();
    public abstract string ToString(IFormatProvider formatProvider);
    public abstract int ArgumentCount { get; }
    public abstract string Format { get; }
}