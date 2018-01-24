using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Elementary.Forms
{
    public class FilterCollection : IEnumerable<FilterItem>
    {
        /// <summary>
        /// The generated filter string for use with <see cref="OpenFileDialog"/> or <see cref="SaveFileDialog"/>
        /// </summary>
        public string Filter => string.Join("|", Items.Select(item => $"{item.Text}|{string.Join(";", item.Extensions)}"));
        /// <summary>
        /// Items in this <see cref="FilterCollection"/>
        /// </summary>
        public List<FilterItem> Items { get; }

        public FilterCollection()
        {
            Items = new List<FilterItem>();
        }
        public FilterCollection(IEnumerable<FilterItem> items) : this()
        {
            Items.AddRange(items);
        }
        public FilterCollection(params FilterItem[] items) : this()
        {
            Items.AddRange(items);
        }

        /// <inheritdoc />
        /// <summary>
        /// Returns an enumerator that iterates through the <see cref="FilterCollection" />
        /// </summary>
        /// <returns>An enumerator that iterates through the <see cref="FilterCollection" /></returns>
        public IEnumerator<FilterItem> GetEnumerator() => Items.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}