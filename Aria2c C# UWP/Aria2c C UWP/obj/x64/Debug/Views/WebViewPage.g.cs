﻿#pragma checksum "C:\Users\eddy.EDDY-PC\source\repos\Aria2c C UWP\Aria2c C UWP\Views\WebViewPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "509F2BD1CB1A8469B4817D088CE53EA3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aria2c_C_UWP.Views
{
    partial class WebViewPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_WebView_Source(global::Windows.UI.Xaml.Controls.WebView obj, global::System.Uri value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Uri) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Uri), targetNullValue);
                }
                obj.Source = value;
            }
            public static void Set_Windows_UI_Xaml_UIElement_Visibility(global::Windows.UI.Xaml.UIElement obj, global::Windows.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(global::Windows.UI.Xaml.Controls.Primitives.ButtonBase obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ProgressRing_IsActive(global::Windows.UI.Xaml.Controls.ProgressRing obj, global::System.Boolean value)
            {
                obj.IsActive = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class WebViewPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IWebViewPage_Bindings
        {
            private global::Aria2c_C_UWP.Views.WebViewPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.WebView obj2;
            private global::Windows.UI.Xaml.Controls.StackPanel obj3;
            private global::Windows.UI.Xaml.Controls.StackPanel obj4;
            private global::Windows.UI.Xaml.Controls.Button obj5;
            private global::Windows.UI.Xaml.Controls.Button obj6;
            private global::Windows.UI.Xaml.Controls.Button obj7;
            private global::Windows.UI.Xaml.Controls.Button obj8;
            private global::Windows.UI.Xaml.Controls.HyperlinkButton obj9;
            private global::Windows.UI.Xaml.Controls.ProgressRing obj10;

            private WebViewPage_obj1_BindingsTracking bindingsTracking;

            public WebViewPage_obj1_Bindings()
            {
                this.bindingsTracking = new WebViewPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Views\WebViewPage.xaml line 84
                        this.obj2 = (global::Windows.UI.Xaml.Controls.WebView)target;
                        break;
                    case 3: // Views\WebViewPage.xaml line 85
                        this.obj3 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                        break;
                    case 4: // Views\WebViewPage.xaml line 91
                        this.obj4 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                        break;
                    case 5: // Views\WebViewPage.xaml line 108
                        this.obj5 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 6: // Views\WebViewPage.xaml line 111
                        this.obj6 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 7: // Views\WebViewPage.xaml line 100
                        this.obj7 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 8: // Views\WebViewPage.xaml line 103
                        this.obj8 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 9: // Views\WebViewPage.xaml line 95
                        this.obj9 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)target;
                        break;
                    case 10: // Views\WebViewPage.xaml line 88
                        this.obj10 = (global::Windows.UI.Xaml.Controls.ProgressRing)target;
                        break;
                    default:
                        break;
                }
            }

            // IWebViewPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Aria2c_C_UWP.Views.WebViewPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Aria2c_C_UWP.Views.WebViewPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::Aria2c_C_UWP.ViewModels.WebViewViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Source(obj.Source, phase);
                        this.Update_ViewModel_IsLoadingVisibility(obj.IsLoadingVisibility, phase);
                        this.Update_ViewModel_FailedMesageVisibility(obj.FailedMesageVisibility, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_RefreshCommand(obj.RefreshCommand, phase);
                        this.Update_ViewModel_OpenInBrowserCommand(obj.OpenInBrowserCommand, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_BrowserBackCommand(obj.BrowserBackCommand, phase);
                        this.Update_ViewModel_BrowserForwardCommand(obj.BrowserForwardCommand, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_RetryCommand(obj.RetryCommand, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_IsLoading(obj.IsLoading, phase);
                    }
                }
            }
            private void Update_ViewModel_Source(global::System.Uri obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\WebViewPage.xaml line 84
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_WebView_Source(this.obj2, obj, null);
                }
            }
            private void Update_ViewModel_IsLoadingVisibility(global::Windows.UI.Xaml.Visibility obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\WebViewPage.xaml line 85
                    XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj3, obj);
                }
            }
            private void Update_ViewModel_FailedMesageVisibility(global::Windows.UI.Xaml.Visibility obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\WebViewPage.xaml line 91
                    XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj4, obj);
                }
            }
            private void Update_ViewModel_RefreshCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\WebViewPage.xaml line 108
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj5, obj, null);
                }
            }
            private void Update_ViewModel_OpenInBrowserCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\WebViewPage.xaml line 111
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj6, obj, null);
                }
            }
            private void Update_ViewModel_BrowserBackCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\WebViewPage.xaml line 100
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj7, obj, null);
                }
            }
            private void Update_ViewModel_BrowserForwardCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\WebViewPage.xaml line 103
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj8, obj, null);
                }
            }
            private void Update_ViewModel_RetryCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\WebViewPage.xaml line 95
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj9, obj, null);
                }
            }
            private void Update_ViewModel_IsLoading(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\WebViewPage.xaml line 88
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ProgressRing_IsActive(this.obj10, obj);
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class WebViewPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<WebViewPage_obj1_Bindings> weakRefToBindingObj; 

                public WebViewPage_obj1_BindingsTracking(WebViewPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<WebViewPage_obj1_Bindings>(obj);
                }

                public WebViewPage_obj1_Bindings TryGetBindingObject()
                {
                    WebViewPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ViewModel(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    WebViewPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Aria2c_C_UWP.ViewModels.WebViewViewModel obj = sender as global::Aria2c_C_UWP.ViewModels.WebViewViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_Source(obj.Source, DATA_CHANGED);
                                bindings.Update_ViewModel_IsLoadingVisibility(obj.IsLoadingVisibility, DATA_CHANGED);
                                bindings.Update_ViewModel_FailedMesageVisibility(obj.FailedMesageVisibility, DATA_CHANGED);
                                bindings.Update_ViewModel_BrowserBackCommand(obj.BrowserBackCommand, DATA_CHANGED);
                                bindings.Update_ViewModel_BrowserForwardCommand(obj.BrowserForwardCommand, DATA_CHANGED);
                                bindings.Update_ViewModel_IsLoading(obj.IsLoading, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Source":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Source(obj.Source, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsLoadingVisibility":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_IsLoadingVisibility(obj.IsLoadingVisibility, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "FailedMesageVisibility":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_FailedMesageVisibility(obj.FailedMesageVisibility, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "BrowserBackCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_BrowserBackCommand(obj.BrowserBackCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "BrowserForwardCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_BrowserForwardCommand(obj.BrowserForwardCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsLoading":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_IsLoading(obj.IsLoading, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Aria2c_C_UWP.ViewModels.WebViewViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::Aria2c_C_UWP.ViewModels.WebViewViewModel obj)
                {
                    if (obj != cache_ViewModel)
                    {
                        if (cache_ViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel).PropertyChanged -= PropertyChanged_ViewModel;
                            cache_ViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\WebViewPage.xaml line 84
                {
                    this.webView = (global::Windows.UI.Xaml.Controls.WebView)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\WebViewPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    WebViewPage_obj1_Bindings bindings = new WebViewPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

