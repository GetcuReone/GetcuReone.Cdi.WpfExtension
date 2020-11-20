using GetcuReone.Cdi.FactFactory;
using GetcuReone.Cdi.WpfEntities;
using GetcuReone.ComboPatterns.Adapter;
using GetcuReone.ComboPatterns.Facade;
using GetcuReone.ComboPatterns.Interfaces;
using GetcuReone.MvvmFrame.Wpf;
using GetcuReone.MvvmFrame.Wpf.EventArgs;
using System.Threading.Tasks;

namespace GetcuReone.Cdi
{
    /// <inheritdoc/>
    public abstract class GrViewModelBase : ViewModelBase, IFacadeCreation, IAdapterCreation
    {
        private GrFactFactory _grFactFactory;

        /// <summary>
        /// Object to wait.
        /// </summary>
        public virtual Awaiter Awaiter { get; protected set; } = new Awaiter();

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

        }

        /// <inheritdoc/>
        protected override ValueTask OnGoPageAsync(object navigateParam)
        {
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
    }
}
