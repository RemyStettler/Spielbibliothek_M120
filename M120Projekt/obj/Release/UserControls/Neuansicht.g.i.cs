﻿#pragma checksum "..\..\..\UserControls\Neuansicht.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73C05E38AB8FDADEE4E8C5407ABED8DDBEBD181C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using M120Projekt.UserControls;
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


namespace M120Projekt.UserControls {
    
    
    /// <summary>
    /// Neuansicht
    /// </summary>
    public partial class Neuansicht : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\UserControls\Neuansicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtName;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\UserControls\Neuansicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPublisher;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\UserControls\Neuansicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateErscheinung;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\UserControls\Neuansicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMindestalter;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\UserControls\Neuansicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPreis;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\UserControls\Neuansicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkSteam;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\UserControls\Neuansicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBewertung;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\UserControls\Neuansicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNeu;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\UserControls\Neuansicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAbbrechen;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\UserControls\Neuansicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLeeren;
        
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
            System.Uri resourceLocater = new System.Uri("/M120Projekt;component/usercontrols/neuansicht.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\Neuansicht.xaml"
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
            this.txtName = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\..\UserControls\Neuansicht.xaml"
            this.txtName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtPublisher = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\..\UserControls\Neuansicht.xaml"
            this.txtPublisher.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtPublisher_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dateErscheinung = ((System.Windows.Controls.DatePicker)(target));
            
            #line 45 "..\..\..\UserControls\Neuansicht.xaml"
            this.dateErscheinung.CalendarClosed += new System.Windows.RoutedEventHandler(this.DateErscheinung_CalendarClosed);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtMindestalter = ((System.Windows.Controls.TextBox)(target));
            
            #line 50 "..\..\..\UserControls\Neuansicht.xaml"
            this.txtMindestalter.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtMindestalter_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtPreis = ((System.Windows.Controls.TextBox)(target));
            
            #line 55 "..\..\..\UserControls\Neuansicht.xaml"
            this.txtPreis.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtPreis_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.checkSteam = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.txtBewertung = ((System.Windows.Controls.TextBox)(target));
            
            #line 66 "..\..\..\UserControls\Neuansicht.xaml"
            this.txtBewertung.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtBewertung_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnNeu = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\..\UserControls\Neuansicht.xaml"
            this.btnNeu.Click += new System.Windows.RoutedEventHandler(this.BtnNeu_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnAbbrechen = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\UserControls\Neuansicht.xaml"
            this.btnAbbrechen.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnLeeren = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\UserControls\Neuansicht.xaml"
            this.btnLeeren.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

