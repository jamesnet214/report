using Jamesnet.Wpf.Controls;
using System.Windows;

namespace JamesReport
{
    public class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            return new Window();
        }
    }
}
