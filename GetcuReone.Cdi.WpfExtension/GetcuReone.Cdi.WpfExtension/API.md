<a name='assembly'></a>
# GetcuReone.Cdi.WpfExtension

## Contents

- [Awaiter](#T-GetcuReone-Cdi-MvvmFrameWpf-Entities-Awaiter 'GetcuReone.Cdi.MvvmFrameWpf.Entities.Awaiter')
  - [#ctor(waitStep)](#M-GetcuReone-Cdi-MvvmFrameWpf-Entities-Awaiter-#ctor-System-Int32- 'GetcuReone.Cdi.MvvmFrameWpf.Entities.Awaiter.#ctor(System.Int32)')
  - [Finished](#P-GetcuReone-Cdi-MvvmFrameWpf-Entities-Awaiter-Finished 'GetcuReone.Cdi.MvvmFrameWpf.Entities.Awaiter.Finished')
  - [AddChild(awaiter)](#M-GetcuReone-Cdi-MvvmFrameWpf-Entities-Awaiter-AddChild-GetcuReone-Cdi-MvvmFrameWpf-Entities-Awaiter- 'GetcuReone.Cdi.MvvmFrameWpf.Entities.Awaiter.AddChild(GetcuReone.Cdi.MvvmFrameWpf.Entities.Awaiter)')
  - [Finish()](#M-GetcuReone-Cdi-MvvmFrameWpf-Entities-Awaiter-Finish 'GetcuReone.Cdi.MvvmFrameWpf.Entities.Awaiter.Finish')
  - [WaitFinishAsync()](#M-GetcuReone-Cdi-MvvmFrameWpf-Entities-Awaiter-WaitFinishAsync 'GetcuReone.Cdi.MvvmFrameWpf.Entities.Awaiter.WaitFinishAsync')
- [BaseGrModel](#T-GetcuReone-Cdi-MvvmFrameWpf-BaseGrModel 'GetcuReone.Cdi.MvvmFrameWpf.BaseGrModel')
  - [Container](#P-GetcuReone-Cdi-MvvmFrameWpf-BaseGrModel-Container 'GetcuReone.Cdi.MvvmFrameWpf.BaseGrModel.Container')
  - [NLogger](#P-GetcuReone-Cdi-MvvmFrameWpf-BaseGrModel-NLogger 'GetcuReone.Cdi.MvvmFrameWpf.BaseGrModel.NLogger')
  - [NavigationInfo](#P-GetcuReone-Cdi-MvvmFrameWpf-BaseGrModel-NavigationInfo 'GetcuReone.Cdi.MvvmFrameWpf.BaseGrModel.NavigationInfo')
  - [BindModel\`\`1()](#M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrModel-BindModel``1-``0- 'GetcuReone.Cdi.MvvmFrameWpf.BaseGrModel.BindModel``1(``0)')
  - [GetAdapter\`\`1()](#M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrModel-GetAdapter``1 'GetcuReone.Cdi.MvvmFrameWpf.BaseGrModel.GetAdapter``1')
  - [GetFacade\`\`1()](#M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrModel-GetFacade``1 'GetcuReone.Cdi.MvvmFrameWpf.BaseGrModel.GetFacade``1')
  - [GetFactFactory\`\`1(needNewFactory)](#M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrModel-GetFactFactory``1-System-Boolean- 'GetcuReone.Cdi.MvvmFrameWpf.BaseGrModel.GetFactFactory``1(System.Boolean)')
  - [GetModel\`\`1()](#M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrModel-GetModel``1 'GetcuReone.Cdi.MvvmFrameWpf.BaseGrModel.GetModel``1')
- [BaseGrUiService](#T-GetcuReone-Cdi-MvvmFrameWpf-BaseGrUiService 'GetcuReone.Cdi.MvvmFrameWpf.BaseGrUiService')
  - [VisibilityFrame](#P-GetcuReone-Cdi-MvvmFrameWpf-BaseGrUiService-VisibilityFrame 'GetcuReone.Cdi.MvvmFrameWpf.BaseGrUiService.VisibilityFrame')
- [BaseGrViewModel](#T-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel 'GetcuReone.Cdi.MvvmFrameWpf.BaseGrViewModel')
  - [Awaiter](#P-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-Awaiter 'GetcuReone.Cdi.MvvmFrameWpf.BaseGrViewModel.Awaiter')
  - [Container](#P-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-Container 'GetcuReone.Cdi.MvvmFrameWpf.BaseGrViewModel.Container')
  - [NLogger](#P-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-NLogger 'GetcuReone.Cdi.MvvmFrameWpf.BaseGrViewModel.NLogger')
  - [NavigationInfo](#P-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-NavigationInfo 'GetcuReone.Cdi.MvvmFrameWpf.BaseGrViewModel.NavigationInfo')
  - [TitlePage](#P-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-TitlePage 'GetcuReone.Cdi.MvvmFrameWpf.BaseGrViewModel.TitlePage')
  - [BindModel\`\`1()](#M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-BindModel``1-``0- 'GetcuReone.Cdi.MvvmFrameWpf.BaseGrViewModel.BindModel``1(``0)')
  - [CreateGrViewModel\`\`1(frame,options,uiServices,navigationManager,factContainer,navigationInfo)](#M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-CreateGrViewModel``1-System-Windows-Controls-Frame,GetcuReone-MvvmFrame-Interfaces-IModelOptions,GetcuReone-MvvmFrame-Wpf-Interfaces-IConfigUiServices,GetcuReone-MvvmFrame-Wpf-Entities-NavigationViewModelManager,GetcuReone-FactFactory-Interfaces-IFactContainer,GetcuReone-Cdi-MvvmFrameWpf-Entities-NavigationInfo- 'GetcuReone.Cdi.MvvmFrameWpf.BaseGrViewModel.CreateGrViewModel``1(System.Windows.Controls.Frame,GetcuReone.MvvmFrame.Interfaces.IModelOptions,GetcuReone.MvvmFrame.Wpf.Interfaces.IConfigUiServices,GetcuReone.MvvmFrame.Wpf.Entities.NavigationViewModelManager,GetcuReone.FactFactory.Interfaces.IFactContainer,GetcuReone.Cdi.MvvmFrameWpf.Entities.NavigationInfo)')
  - [GetAdapter\`\`1()](#M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-GetAdapter``1 'GetcuReone.Cdi.MvvmFrameWpf.BaseGrViewModel.GetAdapter``1')
  - [GetFacade\`\`1()](#M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-GetFacade``1 'GetcuReone.Cdi.MvvmFrameWpf.BaseGrViewModel.GetFacade``1')
  - [GetFactFactory\`\`1(needNewFactory)](#M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-GetFactFactory``1-System-Boolean- 'GetcuReone.Cdi.MvvmFrameWpf.BaseGrViewModel.GetFactFactory``1(System.Boolean)')
  - [GetModel\`\`1()](#M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-GetModel``1 'GetcuReone.Cdi.MvvmFrameWpf.BaseGrViewModel.GetModel``1')
  - [GetViewModel\`\`1()](#M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-GetViewModel``1 'GetcuReone.Cdi.MvvmFrameWpf.BaseGrViewModel.GetViewModel``1')
  - [Initialize()](#M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-Initialize 'GetcuReone.Cdi.MvvmFrameWpf.BaseGrViewModel.Initialize')
  - [OnGoPageAsync()](#M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-OnGoPageAsync-System-Object- 'GetcuReone.Cdi.MvvmFrameWpf.BaseGrViewModel.OnGoPageAsync(System.Object)')
  - [OnLeavePageAsync()](#M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-OnLeavePageAsync-GetcuReone-MvvmFrame-Wpf-EventArgs-NavigatingEventArgs- 'GetcuReone.Cdi.MvvmFrameWpf.BaseGrViewModel.OnLeavePageAsync(GetcuReone.MvvmFrame.Wpf.EventArgs.NavigatingEventArgs)')
  - [OnLoadPageAsync()](#M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-OnLoadPageAsync 'GetcuReone.Cdi.MvvmFrameWpf.BaseGrViewModel.OnLoadPageAsync')
  - [TryGoBack()](#M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-TryGoBack 'GetcuReone.Cdi.MvvmFrameWpf.BaseGrViewModel.TryGoBack')
- [CdiWpfHelper](#T-GetcuReone-Cdi-MvvmFrameWpf-CdiWpfHelper 'GetcuReone.Cdi.MvvmFrameWpf.CdiWpfHelper')
  - [CopyTo(from,to)](#M-GetcuReone-Cdi-MvvmFrameWpf-CdiWpfHelper-CopyTo-GetcuReone-FactFactory-Interfaces-IFactContainer,GetcuReone-FactFactory-Interfaces-IFactContainer- 'GetcuReone.Cdi.MvvmFrameWpf.CdiWpfHelper.CopyTo(GetcuReone.FactFactory.Interfaces.IFactContainer,GetcuReone.FactFactory.Interfaces.IFactContainer)')
  - [CreateVisibleScope(frame)](#M-GetcuReone-Cdi-MvvmFrameWpf-CdiWpfHelper-CreateVisibleScope-System-Windows-Controls-Frame- 'GetcuReone.Cdi.MvvmFrameWpf.CdiWpfHelper.CreateVisibleScope(System.Windows.Controls.Frame)')
  - [TryUpdateAndRemoveFact\`\`2(container,fact,args)](#M-GetcuReone-Cdi-MvvmFrameWpf-CdiWpfHelper-TryUpdateAndRemoveFact``2-``0,``1,GetcuReone-MvvmFrame-Wpf-Commands-CommandArgs- 'GetcuReone.Cdi.MvvmFrameWpf.CdiWpfHelper.TryUpdateAndRemoveFact``2(``0,``1,GetcuReone.MvvmFrame.Wpf.Commands.CommandArgs)')
  - [TryUpdateAndRemoveFact\`\`2(container,fact,args)](#M-GetcuReone-Cdi-MvvmFrameWpf-CdiWpfHelper-TryUpdateAndRemoveFact``2-``0,``1,GetcuReone-MvvmFrame-Wpf-Commands-AsyncCommandArgs- 'GetcuReone.Cdi.MvvmFrameWpf.CdiWpfHelper.TryUpdateAndRemoveFact``2(``0,``1,GetcuReone.MvvmFrame.Wpf.Commands.AsyncCommandArgs)')
- [GrModelBase](#T-GetcuReone-Cdi-MvvmFrameWpf-GrModelBase 'GetcuReone.Cdi.MvvmFrameWpf.GrModelBase')
- [GrUiServiceBase](#T-GetcuReone-Cdi-MvvmFrameWpf-GrUiServiceBase 'GetcuReone.Cdi.MvvmFrameWpf.GrUiServiceBase')
- [GrViewModelBase](#T-GetcuReone-Cdi-MvvmFrameWpf-GrViewModelBase 'GetcuReone.Cdi.MvvmFrameWpf.GrViewModelBase')
- [NavigationInfo](#T-GetcuReone-Cdi-MvvmFrameWpf-Entities-NavigationInfo 'GetcuReone.Cdi.MvvmFrameWpf.Entities.NavigationInfo')
  - [LastTitlePage](#P-GetcuReone-Cdi-MvvmFrameWpf-Entities-NavigationInfo-LastTitlePage 'GetcuReone.Cdi.MvvmFrameWpf.Entities.NavigationInfo.LastTitlePage')

<a name='T-GetcuReone-Cdi-MvvmFrameWpf-Entities-Awaiter'></a>
## Awaiter `type`

##### Namespace

GetcuReone.Cdi.MvvmFrameWpf.Entities

##### Summary

Object to wait.

<a name='M-GetcuReone-Cdi-MvvmFrameWpf-Entities-Awaiter-#ctor-System-Int32-'></a>
### #ctor(waitStep) `constructor`

##### Summary

Constructor.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| waitStep | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='P-GetcuReone-Cdi-MvvmFrameWpf-Entities-Awaiter-Finished'></a>
### Finished `property`

##### Summary

Finished.

<a name='M-GetcuReone-Cdi-MvvmFrameWpf-Entities-Awaiter-AddChild-GetcuReone-Cdi-MvvmFrameWpf-Entities-Awaiter-'></a>
### AddChild(awaiter) `method`

##### Summary

Add child [Awaiter](#T-GetcuReone-Cdi-MvvmFrameWpf-Entities-Awaiter 'GetcuReone.Cdi.MvvmFrameWpf.Entities.Awaiter').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| awaiter | [GetcuReone.Cdi.MvvmFrameWpf.Entities.Awaiter](#T-GetcuReone-Cdi-MvvmFrameWpf-Entities-Awaiter 'GetcuReone.Cdi.MvvmFrameWpf.Entities.Awaiter') |  |

<a name='M-GetcuReone-Cdi-MvvmFrameWpf-Entities-Awaiter-Finish'></a>
### Finish() `method`

##### Summary

Finish.

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-MvvmFrameWpf-Entities-Awaiter-WaitFinishAsync'></a>
### WaitFinishAsync() `method`

##### Summary

wait for the end.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-GetcuReone-Cdi-MvvmFrameWpf-BaseGrModel'></a>
## BaseGrModel `type`

##### Namespace

GetcuReone.Cdi.MvvmFrameWpf

##### Summary

*Inherit from parent.*

<a name='P-GetcuReone-Cdi-MvvmFrameWpf-BaseGrModel-Container'></a>
### Container `property`

##### Summary

Container.

<a name='P-GetcuReone-Cdi-MvvmFrameWpf-BaseGrModel-NLogger'></a>
### NLogger `property`

##### Summary

Logger.

<a name='P-GetcuReone-Cdi-MvvmFrameWpf-BaseGrModel-NavigationInfo'></a>
### NavigationInfo `property`

##### Summary

Navigation info.

<a name='M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrModel-BindModel``1-``0-'></a>
### BindModel\`\`1() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrModel-GetAdapter``1'></a>
### GetAdapter\`\`1() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrModel-GetFacade``1'></a>
### GetFacade\`\`1() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrModel-GetFactFactory``1-System-Boolean-'></a>
### GetFactFactory\`\`1(needNewFactory) `method`

##### Summary

Get fact factory.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| needNewFactory | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TFactRulesProvider |  |

<a name='M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrModel-GetModel``1'></a>
### GetModel\`\`1() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-GetcuReone-Cdi-MvvmFrameWpf-BaseGrUiService'></a>
## BaseGrUiService `type`

##### Namespace

GetcuReone.Cdi.MvvmFrameWpf

##### Summary

*Inherit from parent.*

<a name='P-GetcuReone-Cdi-MvvmFrameWpf-BaseGrUiService-VisibilityFrame'></a>
### VisibilityFrame `property`

##### Summary

Frame visibility.

<a name='T-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel'></a>
## BaseGrViewModel `type`

##### Namespace

GetcuReone.Cdi.MvvmFrameWpf

##### Summary

*Inherit from parent.*

<a name='P-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-Awaiter'></a>
### Awaiter `property`

##### Summary

Object to wait.

<a name='P-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-Container'></a>
### Container `property`

##### Summary

Container.

<a name='P-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-NLogger'></a>
### NLogger `property`

##### Summary

Logger.

<a name='P-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-NavigationInfo'></a>
### NavigationInfo `property`

##### Summary

Navigation info.

<a name='P-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-TitlePage'></a>
### TitlePage `property`

##### Summary

Title page.

<a name='M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-BindModel``1-``0-'></a>
### BindModel\`\`1() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-CreateGrViewModel``1-System-Windows-Controls-Frame,GetcuReone-MvvmFrame-Interfaces-IModelOptions,GetcuReone-MvvmFrame-Wpf-Interfaces-IConfigUiServices,GetcuReone-MvvmFrame-Wpf-Entities-NavigationViewModelManager,GetcuReone-FactFactory-Interfaces-IFactContainer,GetcuReone-Cdi-MvvmFrameWpf-Entities-NavigationInfo-'></a>
### CreateGrViewModel\`\`1(frame,options,uiServices,navigationManager,factContainer,navigationInfo) `method`

##### Summary

Method creation veiw-model.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| frame | [System.Windows.Controls.Frame](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.Frame 'System.Windows.Controls.Frame') | Frame to which pages will be linked and view-model. |
| options | [GetcuReone.MvvmFrame.Interfaces.IModelOptions](#T-GetcuReone-MvvmFrame-Interfaces-IModelOptions 'GetcuReone.MvvmFrame.Interfaces.IModelOptions') |  |
| uiServices | [GetcuReone.MvvmFrame.Wpf.Interfaces.IConfigUiServices](#T-GetcuReone-MvvmFrame-Wpf-Interfaces-IConfigUiServices 'GetcuReone.MvvmFrame.Wpf.Interfaces.IConfigUiServices') |  |
| navigationManager | [GetcuReone.MvvmFrame.Wpf.Entities.NavigationViewModelManager](#T-GetcuReone-MvvmFrame-Wpf-Entities-NavigationViewModelManager 'GetcuReone.MvvmFrame.Wpf.Entities.NavigationViewModelManager') |  |
| factContainer | [GetcuReone.FactFactory.Interfaces.IFactContainer](#T-GetcuReone-FactFactory-Interfaces-IFactContainer 'GetcuReone.FactFactory.Interfaces.IFactContainer') |  |
| navigationInfo | [GetcuReone.Cdi.MvvmFrameWpf.Entities.NavigationInfo](#T-GetcuReone-Cdi-MvvmFrameWpf-Entities-NavigationInfo 'GetcuReone.Cdi.MvvmFrameWpf.Entities.NavigationInfo') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TViewModel |  |

<a name='M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-GetAdapter``1'></a>
### GetAdapter\`\`1() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-GetFacade``1'></a>
### GetFacade\`\`1() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-GetFactFactory``1-System-Boolean-'></a>
### GetFactFactory\`\`1(needNewFactory) `method`

##### Summary

Get fact factory.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| needNewFactory | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TFactRulesProvider |  |

<a name='M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-GetModel``1'></a>
### GetModel\`\`1() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-GetViewModel``1'></a>
### GetViewModel\`\`1() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-Initialize'></a>
### Initialize() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-OnGoPageAsync-System-Object-'></a>
### OnGoPageAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-OnLeavePageAsync-GetcuReone-MvvmFrame-Wpf-EventArgs-NavigatingEventArgs-'></a>
### OnLeavePageAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-OnLoadPageAsync'></a>
### OnLoadPageAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-MvvmFrameWpf-BaseGrViewModel-TryGoBack'></a>
### TryGoBack() `method`

##### Summary

Try navigation back.

##### Parameters

This method has no parameters.

<a name='T-GetcuReone-Cdi-MvvmFrameWpf-CdiWpfHelper'></a>
## CdiWpfHelper `type`

##### Namespace

GetcuReone.Cdi.MvvmFrameWpf

##### Summary

Helper for GetcuReone.Cdi.Wpf.

<a name='M-GetcuReone-Cdi-MvvmFrameWpf-CdiWpfHelper-CopyTo-GetcuReone-FactFactory-Interfaces-IFactContainer,GetcuReone-FactFactory-Interfaces-IFactContainer-'></a>
### CopyTo(from,to) `method`

##### Summary

Copy container.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| from | [GetcuReone.FactFactory.Interfaces.IFactContainer](#T-GetcuReone-FactFactory-Interfaces-IFactContainer 'GetcuReone.FactFactory.Interfaces.IFactContainer') | Container to copy from. |
| to | [GetcuReone.FactFactory.Interfaces.IFactContainer](#T-GetcuReone-FactFactory-Interfaces-IFactContainer 'GetcuReone.FactFactory.Interfaces.IFactContainer') | Container to copy to. |

<a name='M-GetcuReone-Cdi-MvvmFrameWpf-CdiWpfHelper-CreateVisibleScope-System-Windows-Controls-Frame-'></a>
### CreateVisibleScope(frame) `method`

##### Summary

Create visibile scope.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| frame | [System.Windows.Controls.Frame](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.Frame 'System.Windows.Controls.Frame') |  |

<a name='M-GetcuReone-Cdi-MvvmFrameWpf-CdiWpfHelper-TryUpdateAndRemoveFact``2-``0,``1,GetcuReone-MvvmFrame-Wpf-Commands-CommandArgs-'></a>
### TryUpdateAndRemoveFact\`\`2(container,fact,args) `method`

##### Summary

Update and remove fact.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| container | [\`\`0](#T-``0 '``0') |  |
| fact | [\`\`1](#T-``1 '``1') |  |
| args | [GetcuReone.MvvmFrame.Wpf.Commands.CommandArgs](#T-GetcuReone-MvvmFrame-Wpf-Commands-CommandArgs 'GetcuReone.MvvmFrame.Wpf.Commands.CommandArgs') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TFact |  |
| TFactContainer |  |

<a name='M-GetcuReone-Cdi-MvvmFrameWpf-CdiWpfHelper-TryUpdateAndRemoveFact``2-``0,``1,GetcuReone-MvvmFrame-Wpf-Commands-AsyncCommandArgs-'></a>
### TryUpdateAndRemoveFact\`\`2(container,fact,args) `method`

##### Summary

Update and remove fact.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| container | [\`\`0](#T-``0 '``0') |  |
| fact | [\`\`1](#T-``1 '``1') |  |
| args | [GetcuReone.MvvmFrame.Wpf.Commands.AsyncCommandArgs](#T-GetcuReone-MvvmFrame-Wpf-Commands-AsyncCommandArgs 'GetcuReone.MvvmFrame.Wpf.Commands.AsyncCommandArgs') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TFact |  |
| TFactContainer |  |

<a name='T-GetcuReone-Cdi-MvvmFrameWpf-GrModelBase'></a>
## GrModelBase `type`

##### Namespace

GetcuReone.Cdi.MvvmFrameWpf

##### Summary

*Inherit from parent.*

<a name='T-GetcuReone-Cdi-MvvmFrameWpf-GrUiServiceBase'></a>
## GrUiServiceBase `type`

##### Namespace

GetcuReone.Cdi.MvvmFrameWpf

##### Summary

*Inherit from parent.*

<a name='T-GetcuReone-Cdi-MvvmFrameWpf-GrViewModelBase'></a>
## GrViewModelBase `type`

##### Namespace

GetcuReone.Cdi.MvvmFrameWpf

##### Summary

*Inherit from parent.*

<a name='T-GetcuReone-Cdi-MvvmFrameWpf-Entities-NavigationInfo'></a>
## NavigationInfo `type`

##### Namespace

GetcuReone.Cdi.MvvmFrameWpf.Entities

##### Summary

Navigation info.

<a name='P-GetcuReone-Cdi-MvvmFrameWpf-Entities-NavigationInfo-LastTitlePage'></a>
### LastTitlePage `property`

##### Summary

last title page.
