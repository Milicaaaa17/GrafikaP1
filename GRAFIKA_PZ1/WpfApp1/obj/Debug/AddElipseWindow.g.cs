﻿#pragma checksum "..\..\AddElipseWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DF4769600562328E898CA85F93FD19A6249B7FC0C00158478A478D4AF24B3240"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// AddElipseWindow
    /// </summary>
    public partial class AddElipseWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\AddElipseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox xVrednost;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AddElipseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox yVrednost;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AddElipseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox debljinaVrednost;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AddElipseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox bojaVrednost;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AddElipseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tekstVrednost;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\AddElipseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox bojaTekstaVrednost;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\AddElipseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox providnostVrednost;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/addelipsewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddElipseWindow.xaml"
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
            this.xVrednost = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\AddElipseWindow.xaml"
            this.xVrednost.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.ValidationNumber);
            
            #line default
            #line hidden
            return;
            case 2:
            this.yVrednost = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\AddElipseWindow.xaml"
            this.yVrednost.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.ValidationNumber);
            
            #line default
            #line hidden
            return;
            case 3:
            this.debljinaVrednost = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\AddElipseWindow.xaml"
            this.debljinaVrednost.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.ValidationNumber);
            
            #line default
            #line hidden
            return;
            case 4:
            this.bojaVrednost = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.tekstVrednost = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.bojaTekstaVrednost = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.providnostVrednost = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 24 "..\..\AddElipseWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Draw_click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 25 "..\..\AddElipseWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel_click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

