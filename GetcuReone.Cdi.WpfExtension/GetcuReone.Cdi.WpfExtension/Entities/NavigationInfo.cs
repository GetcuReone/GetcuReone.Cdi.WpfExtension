using GetcuReone.MvvmFrame.Wpf;

namespace GetcuReone.Cdi.MvvmFrameWpf.Entities
{
    /// <summary>
    /// Navigation info.
    /// </summary>
    public class NavigationInfo : ModelBase
    {
        /// <summary>
        /// last title page.
        /// </summary>
        public string LastTitlePage { get => _lastTitlePage; set => SetPropertyValue(ref _lastTitlePage, value); }
        private string _lastTitlePage;
    }
}
