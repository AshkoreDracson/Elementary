using System;
using System.Text;

namespace Elementary
{
    public class ConsoleProgressBar : IDisposable
    {
        private float _progress;
        /// <summary>
        /// The current progress of this progress bar, ranging from 0.0 to 1.0
        /// </summary>
        public float Progress
        {
            get => _progress;
            set
            {
                _progress = value.Clamp01();

                if (CanUpdateText)
                {
                    UpdateText(_progress);
                    lastUpdate = DateTime.Now;
                }
            }
        }

        /// <summary>
        /// Has the progress bar completed its progress?
        /// </summary>
        public bool Completed => Progress >= 1f;

        /// <summary>
        /// The max update interval for the progress bar
        /// </summary>
        public TimeSpan MaxUpdateInterval { get; set; } = TimeSpan.FromMilliseconds(50);

        protected virtual string Animation => @"|/-\";
        protected bool CanUpdateText => lastUpdate == null || DateTime.Now - lastUpdate >= MaxUpdateInterval || disposing;

        private int animationIndex = 0;
        private DateTime? lastUpdate;
        private string lastText;

        private bool disposing = false;

        public ConsoleProgressBar()
        {
            Progress = 0f;
        }

        public ConsoleProgressBar(float progress)
        {
            Progress = progress;
        }

        protected virtual void UpdateText(float progress)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append('[');

            for (int i = 0; i < 10; i++)
            {
                float computedProgress =  i / 10f + 1f / 10f / 2f;

                sb.Append(computedProgress <= progress ? '#' : '-');
            }

            sb.Append("] ");

            sb.Append($"{(progress * 100f).ToString("N0").PadLeft(3)}%");

            if (!Completed)
                sb.Append($" {Animation[animationIndex++]}");

            if (animationIndex >= Animation.Length)
                animationIndex = 0;

            if (lastText != null && lastText.Length > sb.Length)
                sb.Append(' ', lastText.Length - sb.Length);

            lastText = sb.ToString();

            sb.Append('\b', sb.Length);

            Console.Write(sb.ToString());
        }

        public void Dispose()
        {
            disposing = true;
            Progress = _progress;
            Console.WriteLine();
        }
    }
}