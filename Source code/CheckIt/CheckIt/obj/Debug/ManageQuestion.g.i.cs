﻿#pragma checksum "..\..\ManageQuestion.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9E2A70CBD2385C265467EB588023A7B91EADDC0701DC1EFFF56079023A1379FF"
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
    /// ManageQuestion
    /// </summary>
    public partial class ManageQuestion : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\ManageQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ManageQuestions;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\ManageQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Settings;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\ManageQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ViewResult;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\ManageQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cbx_TopicName;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\ManageQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_AddQuestion;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\ManageQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Cancel;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\ManageQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox Lbx_Questionlist;
        
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
            System.Uri resourceLocater = new System.Uri("/CheckIt;component/managequestion.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ManageQuestion.xaml"
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
            
            #line 8 "..\..\ManageQuestion.xaml"
            ((CheckIt.ManageQuestion)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ManageQuestions = ((System.Windows.Controls.MenuItem)(target));
            
            #line 20 "..\..\ManageQuestion.xaml"
            this.ManageQuestions.Click += new System.Windows.RoutedEventHandler(this.MenuItem_ManageQuestions_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Settings = ((System.Windows.Controls.MenuItem)(target));
            
            #line 26 "..\..\ManageQuestion.xaml"
            this.Settings.Click += new System.Windows.RoutedEventHandler(this.MenuItem_Settings_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ViewResult = ((System.Windows.Controls.MenuItem)(target));
            
            #line 31 "..\..\ManageQuestion.xaml"
            this.ViewResult.Click += new System.Windows.RoutedEventHandler(this.MenuItem_ViewResult_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Cbx_TopicName = ((System.Windows.Controls.ComboBox)(target));
            
            #line 50 "..\..\ManageQuestion.xaml"
            this.Cbx_TopicName.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Cbx_TopicName_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Btn_AddQuestion = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\ManageQuestion.xaml"
            this.Btn_AddQuestion.Click += new System.Windows.RoutedEventHandler(this.Btn_AddQuestion_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Btn_Cancel = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\ManageQuestion.xaml"
            this.Btn_Cancel.Click += new System.Windows.RoutedEventHandler(this.Btn_Cancel_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Lbx_Questionlist = ((System.Windows.Controls.ListBox)(target));
            
            #line 68 "..\..\ManageQuestion.xaml"
            this.Lbx_Questionlist.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Lbx_Questionlist_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

