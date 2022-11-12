using GetcuReone.MvvmFrame.Wpf.Entities;
using System.Windows;

namespace GetcuReone.Cdi.MvvmFrameWpf
{
    /// <inheritdoc/>
    public abstract class BaseGrUiService : UiServiceBase
    {
        /// <summary>
        /// Frame visibility.
        /// </summary>
        public Visibility VisibilityFrame { get => Frame.Visibility; set => Frame.Visibility = value; }
    }
}
