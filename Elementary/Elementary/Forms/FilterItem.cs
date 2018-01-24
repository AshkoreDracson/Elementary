namespace Elementary.Forms
{
    public struct FilterItem
    {
        /// <summary>
        /// The text of this <see cref="FilterItem"/>
        /// </summary>
        public string Text { get; }
        /// <summary>
        /// The extensions of this <see cref="FilterItem"/>
        /// </summary>
        public string[] Extensions { get; }

        public FilterItem(string text, params string[] extensions)
        {
            Text = text;
            Extensions = extensions;
        }
    }
}