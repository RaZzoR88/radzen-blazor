namespace Radzen.Blazor
{
    /// <summary>
    /// Arguments for the <see cref="RadzenGantt{TItem}.DependencyCreate"/> event.
    /// Raised when the user draws a new dependency link between two task bars.
    /// </summary>
    /// <typeparam name="TItem">The task item type.</typeparam>
    public class GanttDependencyCreatedEventArgs<TItem>
    {
        /// <summary>
        /// The predecessor task (drag source).
        /// </summary>
        public TItem From { get; set; } = default!;

        /// <summary>
        /// The successor task (drag target).
        /// </summary>
        public TItem To { get; set; } = default!;

        /// <summary>
        /// The dependency type, automatically determined by which connector handles were used:
        /// <list type="bullet">
        ///   <item>End → Start = <see cref="GanttDependencyType.FinishToStart"/></item>
        ///   <item>Start → Start = <see cref="GanttDependencyType.StartToStart"/></item>
        ///   <item>End → End = <see cref="GanttDependencyType.FinishToFinish"/></item>
        ///   <item>Start → End = <see cref="GanttDependencyType.StartToFinish"/></item>
        /// </list>
        /// </summary>
        public GanttDependencyType Type { get; set; } = GanttDependencyType.FinishToStart;
    }
}
