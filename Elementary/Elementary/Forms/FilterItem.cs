namespace Elementary.Forms
{
    public struct FilterItem
    {
        public string Text { get; }
        public string[] Extensions { get; }

        public FilterItem(string text, params string[] extensions)
        {
            Text = text;
            Extensions = extensions;
        }
    }
}