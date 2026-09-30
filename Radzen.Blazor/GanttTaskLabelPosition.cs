namespace Radzen.Blazor
{
    /// <summary>
    /// Controls where the task label is rendered relative to the task bar.
    /// </summary>
    public enum GanttTaskLabelPosition
    {
        /// <summary>
        /// Label is rendered inside the bar (default). Clipped when the bar is too narrow.
        /// </summary>
        Inside,

        /// <summary>
        /// Label is always rendered to the right of the bar, outside.
        /// </summary>
        Right,

        /// <summary>
        /// Label is always rendered to the left of the bar, outside.
        /// </summary>
        Left,

        /// <summary>
        /// Label is rendered inside the bar when it fits; otherwise to the right.
        /// </summary>
        Auto
    }
}
