﻿#pragma checksum "C:\Source\Chapter13\ApressExtensionCS\ApressExtensionCS\ApressExtensionCS.Client\Presentation\Controls\DurationEditor.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3C226E87E15D96E0E7D2C9262E53FB7B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ApressControlsCS;
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
    
    
    public partial class DurationEditor : System.Windows.Controls.UserControl {
        
        internal ApressControlsCS.DurationEditorInternal DurationControl;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/ApressExtensionCS.Client;component/Presentation/Controls/DurationEditor.xaml", System.UriKind.Relative));
            this.DurationControl = ((ApressControlsCS.DurationEditorInternal)(this.FindName("DurationControl")));
        }
    }
}

