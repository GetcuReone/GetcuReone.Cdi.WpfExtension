using GetcuReone.Cdi.FactFactory;
using GetcuReone.Cdi.MvvmFrameWpf.Entities;
using GetcuReone.Cdo.Logging;
using GetcuReone.ComboPatterns.Adapter;
using GetcuReone.ComboPatterns.Facade;
using GetcuReone.ComboPatterns.Interfaces;
using GetcuReone.FactFactory.Interfaces;
using GetcuReone.MvvmFrame.Wpf;

namespace GetcuReone.Cdi.MvvmFrameWpf
{
    /// <inheritdoc/>
    public abstract class BaseGrModel : ModelBase, IFacadeCreation, IAdapterCreation
    {
        private IGrFactFactory _grFactFactory;

        /// <summary>
        /// Navigation info.
        /// </summary>
        public NavigationInfo NavigationInfo { get => _navigationInfo; set => SetPropertyValue(ref _navigationInfo, value); }
        private NavigationInfo _navigationInfo;

        /// <summary>
        /// Logger.
        /// </summary>
        protected NLogAdapter NLogger => _nLogAdapter ?? (_nLogAdapter = GetAdapter<NLogAdapter>());
        private NLogAdapter _nLogAdapter;

        /// <summary>
        /// Container.
        /// </summary>
        public virtual IFactContainer Container { get; set; }

        /// <inheritdoc/>
        public TAdapter GetAdapter<TAdapter>() where TAdapter : IAdapter, new()
        {
            if (Factory is IAdapterCreation adapterCreation)
                return adapterCreation.GetAdapter<TAdapter>();

            return AdapterBase.Create<TAdapter>(Factory);
        }

        /// <inheritdoc/>
        public virtual TFacade GetFacade<TFacade>() where TFacade : IFacade, new()
        {
            if (Factory is IFacadeCreation facadeCreation)
                return facadeCreation.GetFacade<TFacade>();

            return FacadeBase.Create<TFacade>(Factory);
        }

        /// <summary>
        /// Get fact factory.
        /// </summary>
        /// <typeparam name="TFactRulesProvider"></typeparam>
        /// <param name="needNewFactory"></param>
        /// <returns></returns>
        public virtual IGrFactFactory GetFactFactory<TFactRulesProvider>(bool needNewFactory = false)
            where TFactRulesProvider : IGrFactRulesProvider, new()
        {
            if (_grFactFactory == null || needNewFactory || !(_grFactFactory.Provider is TFactRulesProvider))
                _grFactFactory = CdiHelper.CreateFactFactory<TFactRulesProvider>(Factory);

            return _grFactFactory;
        }

        /// <inheritdoc/>
        public override TModel GetModel<TModel>()
        {
            var model = base.GetModel<TModel>();

            if (model is BaseGrModel modelBase)
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

            if (model is BaseGrModel modelBase)
            {
                modelBase.Container = Container;
                modelBase.NavigationInfo = NavigationInfo;
            }
        }
    }
}
