﻿#pragma checksum "..\..\..\VIEW\MyUI.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "868A1C5032B524016DD9F8B7F22A20ADA3969720B9871468B5411CE5B2B8EECD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoCreationofDwg.VIEW;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace AutoCreationofDwg.VIEW {
    
    
    /// <summary>
    /// MyUI
    /// </summary>
    public partial class MyUI : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 57 "..\..\..\VIEW\MyUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CollectBtn;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\VIEW\MyUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DWGsBox;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\VIEW\MyUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ColumnTypesBox;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\VIEW\MyUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox LayersBox;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\..\VIEW\MyUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RefreshBtn;
        
        #line default
        #line hidden
        
        
        #line 182 "..\..\..\VIEW\MyUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TopLevelBox;
        
        #line default
        #line hidden
        
        
        #line 199 "..\..\..\VIEW\MyUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox BottomLevelBox;
        
        #line default
        #line hidden
        
        
        #line 215 "..\..\..\VIEW\MyUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GenerateBtn;
        
        #line default
        #line hidden
        
        
        #line 237 "..\..\..\VIEW\MyUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock noOfColumns_TextBlock;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AutoCreationofDwg;component/view/myui.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\VIEW\MyUI.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CollectBtn = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\VIEW\MyUI.xaml"
            this.CollectBtn.Click += new System.Windows.RoutedEventHandler(this.CollectBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DWGsBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.ColumnTypesBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.LayersBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.RefreshBtn = ((System.Windows.Controls.Button)(target));
            
            #line 165 "..\..\..\VIEW\MyUI.xaml"
            this.RefreshBtn.Click += new System.Windows.RoutedEventHandler(this.RefreshBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TopLevelBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.BottomLevelBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.GenerateBtn = ((System.Windows.Controls.Button)(target));
            
            #line 216 "..\..\..\VIEW\MyUI.xaml"
            this.GenerateBtn.Click += new System.Windows.RoutedEventHandler(this.GenerateBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.noOfColumns_TextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
