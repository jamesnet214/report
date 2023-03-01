using Jamesnet.Wpf.Controls;
using Microsoft.Xaml.Behaviors;
using Microsoft.Xaml.Behaviors.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace JamesReport.Core
{
    public class DragMoveContent : ContentControl
    {
        public DragMoveContent()
        {
            MouseDragElementBehavior mouseDragElementBehavior = new MouseDragElementBehavior();
            mouseDragElementBehavior.ConstrainToParentBounds = true;
            Interaction.GetBehaviors(this).Add(mouseDragElementBehavior);
        }
    }
}
