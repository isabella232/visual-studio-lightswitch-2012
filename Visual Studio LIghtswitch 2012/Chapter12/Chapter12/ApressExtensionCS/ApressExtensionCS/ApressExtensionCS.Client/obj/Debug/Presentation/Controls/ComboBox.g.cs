﻿#pragma checksum "C:\Source\Chapter12\ApressExtensionCS\ApressExtensionCS\ApressExtensionCS.Client\Presentation\Controls\ComboBox.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1EB048E31864F9EBA0B421864284C89B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace ApressExtensionCS.Presentation.Controls {
    
    
    public partial class ComboBox : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.UserControl DetailRoot;
        
        internal System.Windows.Controls.ComboBox Combo;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/ApressExtensionCS.Client;component/Presentation/Controls/ComboBox.xaml", System.UriKind.Relative));
            this.DetailRoot = ((System.Windows.Controls.UserControl)(this.FindName("DetailRoot")));
            this.Combo = ((System.Windows.Controls.ComboBox)(this.FindName("Combo")));
        }
    }
}

