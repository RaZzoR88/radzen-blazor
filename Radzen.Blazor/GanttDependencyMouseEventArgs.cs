using Microsoft.AspNetCore.Components;

namespace Radzen.Blazor
{
    /// <summary>
    /// Supplies information about a <see cref="RadzenGantt{TItem}.DependencyMouseEnter" /> or
    /// <see cref="RadzenGantt{TItem}.DependencyMouseLeave" /> event.
    /// </summary>
    /// <typeparam name="TItem">The type of the task data item.</typeparam>
    public class GanttDependencyMouseEventArgs<TItem>
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
