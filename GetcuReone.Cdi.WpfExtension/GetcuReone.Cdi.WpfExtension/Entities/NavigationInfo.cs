using GetcuReone.MvvmFrame.Wpf;

namespace GetcuReone.Cdi.MvvmFrameWpf.Entities
{
    /// <summary>
    /// Navigation info.
    /// </summary>
    public class NavigationInfo : ModelBase
    {
        /// <summary>
        /// Latest navigation view-model.
        /// </summary>
        public GrViewModelBase LatestViewModel { get => _latestViewModel; set => SetPropertyValue(ref _latestViewModel, value); }
        private GrViewModelBase _latestViewModel;
    }
}
