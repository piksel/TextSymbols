namespace Piksel.TextSymbols
{
    public partial record TextSymbol(string Text)
    {
        public override string ToString() => Text;
        public static implicit operator string(TextSymbol ts) => ts.Text;
    }
}
