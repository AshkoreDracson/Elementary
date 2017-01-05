namespace Elementary
{
    public enum LogOutput : byte
    {
        /// <summary>
        /// No log output
        /// </summary>
        None = 0x00,
        /// <summary>
        /// Console log output
        /// </summary>
        Console = 0x01,
        /// <summary>
        /// Immediate window log output
        /// </summary>
        ImmediateWindow = 0x02,
        /// <summary>
        /// File log output
        /// </summary>
        File = 0x04
    }
}
