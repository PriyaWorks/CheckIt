﻿#pragma checksum "..\..\AddQuestion.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2ED5DBD0601AD99288DFCB5505AB3B520F2FA013B7D99287DC4D22E3CA1416DA"
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
    /// AddQuestion
    /// </summary>
    public partial class AddQuestion : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\AddQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_BackMainWindow;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\AddQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stk_TopicName;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\AddQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stk_QuestionDetails;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\AddQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox QuestionDesciption;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\AddQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Chbx_A;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\AddQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OptionA;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\AddQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Chbx_B;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\AddQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OptionB;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\AddQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Chbx_C;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\AddQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OptionC;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\AddQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Chbx_D;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\AddQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OptionD;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\AddQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_SaveQuestion;
        
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
            System.Uri resourceLocater = new System.Uri("/CheckIt;component/addquestion.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddQuestion.xaml"
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
            
            #line 8 "..\..\AddQuestion.xaml"
            ((CheckIt.AddQuestion)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Btn_BackMainWindow = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\AddQuestion.xaml"
            this.Btn_BackMainWindow.Click += new System.Windows.RoutedEventHandler(this.Btn_BackMainWindow_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.stk_TopicName = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.stk_QuestionDetails = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.QuestionDesciption = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Chbx_A = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.OptionA = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Chbx_B = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 9:
            this.OptionB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.Chbx_C = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 11:
            this.OptionC = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.Chbx_D = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 13:
            this.OptionD = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.Btn_SaveQuestion = ((System.Windows.Controls.Button)(target));
            
            #line 134 "..\..\AddQuestion.xaml"
            this.Btn_SaveQuestion.Click += new System.Windows.RoutedEventHandler(this.Btn_SaveQuestion_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

