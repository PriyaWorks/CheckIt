﻿#pragma checksum "..\..\Breadcrum.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F4F45340A0B493F16953B4C66E6C6A207768C0DD5157B9803C6607B852974AE2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CheckIt;
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


namespace CheckIt {
    
    
    /// <summary>
    /// Breadcrum
    /// </summary>
    public partial class Breadcrum : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Breadcrum.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_ManageQuestions;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Breadcrum.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Settings;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Breadcrum.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_ViewResult;
        
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
            System.Uri resourceLocater = new System.Uri("/CheckIt;component/breadcrum.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Breadcrum.xaml"
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
            this.Btn_ManageQuestions = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Breadcrum.xaml"
            this.Btn_ManageQuestions.Click += new System.Windows.RoutedEventHandler(this.Btn_ManageQuestions_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Btn_Settings = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\Breadcrum.xaml"
            this.Btn_Settings.Click += new System.Windows.RoutedEventHandler(this.Btn_Settings_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Btn_ViewResult = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\Breadcrum.xaml"
            this.Btn_ViewResult.Click += new System.Windows.RoutedEventHandler(this.Btn_ViewResult_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

