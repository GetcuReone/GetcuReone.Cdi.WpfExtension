using System;
using System.Windows;
using System.Windows.Controls;

namespace GetcuReone.Cdi.WpfEntities
{
    internal sealed class VisibleFrameScope : IDisposable
    {
        private readonly Frame _frame;

        public VisibleFrameScope(Frame frame)
        {
            _frame = frame;

            if (_frame.Visibility != Visibility.Visible)
                _frame.Visibility = Visibility.Visible;
        }

        public void Dispose()
        {
            _frame.Visibility = Visibility.Collapsed;
        }
    }
}
