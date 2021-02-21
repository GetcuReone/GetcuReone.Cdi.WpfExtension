using GetcuReone.Cdi.FactFactory;
using GetcuReone.Cdi.MvvmFrameWpf.Entities;
using GetcuReone.Cdo.Logging;
using GetcuReone.ComboPatterns.Adapter;
using GetcuReone.ComboPatterns.Facade;
using GetcuReone.ComboPatterns.Interfaces;
using GetcuReone.FactFactory.Interfaces;
using GetcuReone.FactFactory.Versioned.Entities;
using GetcuReone.MvvmFrame.Interfaces;
using GetcuReone.MvvmFrame.Wpf;
using GetcuReone.MvvmFrame.Wpf.Entities;
using GetcuReone.MvvmFrame.Wpf.EventArgs;
using GetcuReone.MvvmFrame.Wpf.Interfaces;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GetcuReone.Cdi.MvvmFrameWpf
{
    /// <inheritdoc/>
    public abstract class GrViewModelBase : ViewModelBase, IFacadeCreation, IAdapterCreation
    {
        private GrFactFactory _grFactFactory;

        /// <summary>
        /// Title page.
        /// </summary>
        public virtual string TitlePage { get => _titlePage; protected set => SetPropertyValue(ref _titlePage, value); }
        private string _titlePage;

        /// <summary>
        /// Object to wait.
        /// </summary>
        public virtual Awaiter Awaiter { get; protected set; } = new Awaiter();

        /// <summary>
        /// Navigation info.
        /// </summary>
        public NavigationInfo NavigationInfo { get => _navigationInfo; protected set => SetPropertyValue(ref _navigationInfo, value); }
        private NavigationInfo _navigationInfo;

        /// <summary>
        /// Logger.
        /// </summary>
        protected NLogAdapter NLogger => _nLogAdapter ?? (_nLogAdapter = GetAdapter<NLogAdapter>());
        private NLogAdapter _nLogAdapter;

        /// <summary>
        /// Container.
        /// </summary>
        public virtual IFactContainer Container { get; protected set; }

        /// <inheritdoc/>
        public virtual TAdapter GetAdapter<TAdapter>() where TAdapter : IAdapter, new()
        {
            return AdapterBase.Create<TAdapter>(this);
        }

        /// <inheritdoc/>
        public virtual TFacade GetFacade<TFacade>() where TFacade : IFacade, new()
        {
            return FacadeBase.Create<TFacade>(this);
        }

        /// <summary>
        /// Get fact factory.
        /// </summary>
        /// <typeparam name="TFactRulesProvider"></typeparam>
        /// <param name="needNewFactory"></param>
        /// <returns></returns>
        public virtual GrFactFactory GetFactFactory<TFactRulesProvider>(bool needNewFactory = false)
            where TFactRulesProvider : GrFactRulesProviderBase, new()
        {
            if (_grFactFactory == null || needNewFactory || !_grFactFactory.IsRulesProvider<TFactRulesProvider>())
                _grFactFactory = CdiHelper.CreateFactFactory<TFactRulesProvider>(this);
            return _grFactFactory;
        }

        /// <summary>
        /// Try navigation back.
        /// </summary>
        protected virtual void TryGoBack()
        {
            if (NavigationManager.CanGoBack)
                NavigationManager.GoBack();
        }

        /// <inheritdoc/>
        protected override void Initialize()
        {
            if (Container == null)
                Container = new VersionedFactContainer();
            if (NavigationInfo == null)
                NavigationInfo = GetModel<NavigationInfo>();
        }

        /// <inheritdoc/>
        protected override ValueTask OnGoPageAsync(object navigateParam)
        {
            NavigationInfo.LastTitlePage = TitlePage;
            return default;
        }

        /// <inheritdoc/>
        protected override ValueTask OnLeavePageAsync(NavigatingEventArgs args)
        {
            return default;
        }

        /// <inheritdoc/>
        protected override ValueTask OnLoadPageAsync()
        {
            return default;
        }

        /// <inheritdoc/>
        public override TModel GetModel<TModel>()
        {
            var model = base.GetModel<TModel>();

            if (model is GrModelBase modelBase)
            {
                modelBase.Container = Container;
                modelBase.NavigationInfo = NavigationInfo;
            }

            return model;
        }

        /// <inheritdoc/>
        public override void BindModel<TModel>(TModel model)
        {
            base.BindModel(model);

            if (model is GrModelBase modelBase)
            {
                modelBase.Container = Container;
                modelBase.NavigationInfo = NavigationInfo;
            }
        }

        /// <inheritdoc/>
        public override TViewModel GetViewModel<TViewModel>()
        {
            var viewModel = base.GetViewModel<TViewModel>();

            if (viewModel is GrViewModelBase viewModelBase)
            {
                viewModelBase.NavigationInfo = NavigationInfo;
            }

            return viewModel;
        }

        /// <summary>
        /// Method creation veiw-model.
        /// </summary>
        /// <typeparam name="TViewModel"></typeparam>
        /// <param name="frame">Frame to which pages will be linked and view-model.</param>
        /// <param name="options"></param>
        /// <param name="uiServices"></param>
        /// <param name="navigationManager"></param>
        /// <param name="factContainer"></param>
        /// <param name="navigationInfo"></param>
        /// <returns></returns>
        public static TViewModel CreateGrViewModel<TViewModel>(Frame frame, IModelOptions options = null, IConfigUiServices uiServices = null, NavigationViewModelManager navigationManager = null, IFactContainer factContainer = null, NavigationInfo navigationInfo = null)
            where TViewModel : GrViewModelBase, new()
        {
            var viewModel = CreateViewModel<TViewModel>(frame, options, uiServices, navigationManager);
            viewModel.Container = factContainer;
            viewModel.NavigationInfo = navigationInfo;

            return viewModel;
        }
    }
}
