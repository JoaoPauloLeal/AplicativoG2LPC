﻿#pragma checksum "C:\Users\JoãoPaulo\Documents\Visual Studio 2013\Projects\AppGlobo\AppGlobo\Cidade.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9AD7F9E573F00139CEEBAB244F2D275F"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.34209
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
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


namespace AppGlobo {
    
    
    public partial class Cidade : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox TxtCidade;
        
        internal System.Windows.Controls.TextBox TxtUf;
        
        internal System.Windows.Controls.TextBlock TxtCidadeBlock;
        
        internal System.Windows.Controls.Button BtnConfirmaCidade;
        
        internal System.Windows.Controls.CheckBox ckbLembrar;
        
        internal System.Windows.Controls.Image imgThumb;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/AppGlobo;component/Cidade.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.TxtCidade = ((System.Windows.Controls.TextBox)(this.FindName("TxtCidade")));
            this.TxtUf = ((System.Windows.Controls.TextBox)(this.FindName("TxtUf")));
            this.TxtCidadeBlock = ((System.Windows.Controls.TextBlock)(this.FindName("TxtCidadeBlock")));
            this.BtnConfirmaCidade = ((System.Windows.Controls.Button)(this.FindName("BtnConfirmaCidade")));
            this.ckbLembrar = ((System.Windows.Controls.CheckBox)(this.FindName("ckbLembrar")));
            this.imgThumb = ((System.Windows.Controls.Image)(this.FindName("imgThumb")));
        }
    }
}

