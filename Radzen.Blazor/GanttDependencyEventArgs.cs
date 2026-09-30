namespace Radzen.Blazor
{
    /// <summary>
    /// Supplies information about a mouse interaction with a Gantt dependency line
    /// (click, double-click, context menu, mouse enter/leave).
    /// </summary>
    /// <typeparam name="TItem">The type of the task data item.</typeparam>
    public class GanttDependencyEventArgs<TItem>
    {
        /// <summary>The predecessor task.</summary>
        public TItem From { get; set; } = default!;

        /// <summary>The successor task.</summary>
        public TItem To { get; set; } = default!;

        /// <summary>The dependency type.</summary>
        public GanttDependencyType Type { get; set; }

        /// <summary>Mouse X position in viewport coordinates.</summary>
        public double ClientX { get; set; }

        /// <summary>Mouse Y position in viewport coordinates.</summary>
        public double ClientY { get; set; }
    }
}
