namespace Builder
{
    public abstract class Label
    {
        public string Text { get; protected set; }

        public override string ToString()
        {
            return "\"" + Text + "\"";
        }
    }
}
