using System;
using System.Linq;
using System.Text;

namespace Elementary
{
    public static class ConsoleExtension
    {
        public static string CreateTable(int width, params string[] items)
        {
            if (items == null) throw new ArgumentNullException(nameof(items));
            if (width < 3) throw new Exception("Table width is too small. Minimum width: 3");

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"╔{new string('═', width - 2)}╗");

            for (int i = 0; i < items.Length; i++)
            {
                sb.AppendLine($"║{items[i].Clamp(width - 2).PadRight(width - 2, '\0')}║");

                if (i < items.Length - 1)
                    sb.AppendLine($"╟{new string('─', width - 2)}╢");
            }

            sb.Append($"╚{new string('═', width - 2)}╝");

            return sb.ToString();
        }
        public static string CreateTable(int[] widths, string[,] items)
        {
            if (widths == null) throw new ArgumentNullException(nameof(widths));
            if (items == null) throw new ArgumentNullException(nameof(items));
            if (widths.Length == 0 || widths.Length != items.GetLength(1)) throw new Exception("Invalid amount of widths.");
            if (widths.Any(width => width < 3)) throw new Exception("Table width is too small. Minimum width: 3");

            StringBuilder sb = new StringBuilder();

            sb.Append("╔");

            for (int x = 0; x < widths.Length; x++)
            {
                sb.Append(new string('═', widths[x]));

                if (x < widths.Length - 1)
                    sb.Append("╤");
            }

            sb.AppendLine("╗");

            for (int y = 0; y < items.GetLength(0); y++)
            {
                sb.Append("║");

                for (int x = 0; x < items.GetLength(1); x++)
                {
                    sb.Append(items[y, x].Clamp(widths[x]).PadRight(widths[x], '\0'));

                    if (x < widths.Length - 1)
                        sb.Append("│");
                }

                sb.AppendLine("║");

                if (y < items.GetLength(0) - 1)
                {
                    sb.Append("╟");

                    for (int x = 0; x < widths.Length; x++)
                    {
                        sb.Append(new string('─', widths[x]));

                        if (x < widths.Length - 1)
                            sb.Append("┼");
                    }

                    sb.AppendLine("╢");
                }
            }

            sb.Append("╚");

            for (int x = 0; x < widths.Length; x++)
            {
                sb.Append(new string('═', widths[x]));

                if (x < widths.Length - 1)
                    sb.Append("╧");
            }

            sb.Append("╝");

            return sb.ToString();
        }
    }
}