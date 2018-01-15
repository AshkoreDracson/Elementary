namespace Elementary
{
    public enum MidpointRounding
    {
        /// <summary>
        /// When a number is halfway between two others, it is rounded towards the nearest even number
        /// </summary>
        ToEven = 0,
        /// <summary>
        /// When a number is halfway between two others, it is rounded towards the nearest number that is away from zero
        /// </summary>
        AwayFromZero = 1
    }
}
