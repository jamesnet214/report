using Microsoft.Xaml.Behaviors;
using Microsoft.Xaml.Behaviors.Layout;

namespace JamesReport.Core
{
    public class DragMoveContent : ReportObject
    {
        public DragMoveContent()
        {
            MouseDragElementBehavior mouseDragElementBehavior = new MouseDragElementBehavior();
            mouseDragElementBehavior.ConstrainToParentBounds = true;
            Interaction.GetBehaviors(this).Add(mouseDragElementBehavior);
        }
    }
}
