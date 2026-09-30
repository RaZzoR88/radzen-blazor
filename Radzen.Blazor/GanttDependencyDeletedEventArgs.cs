namespace Radzen.Blazor
{
    /// <summary>
    /// Arguments for the <see cref="RadzenGantt{TItem}.DependencyDoubleClick"/> event.
    /// Kept for source compatibility — use <see cref="GanttDependencyMouseEventArgs{TItem}"/> for new code.
    /// </summary>
    /// <typeparam name="TItem">The task item type.</typeparam>
    public class GanttDependencyDeletedEventArgs<TItem>
    {
        /// <summary>
        /// The predecessor task of the dependency that was deleted.
        /// </summary>
        public TItem From { get; set; } = default!;

        /// <summary>
        /// The successor task of the dependency that was deleted.
        /// </summary>
        public TItem To { get; set; } = default!;

        /// <summary>
        /// The type of the dependency that was deleted.
        /// </summary>
        public GanttDependencyType Type { get; set; }
    }
}
