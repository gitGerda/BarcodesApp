﻿#pragma checksum "..\..\WindowSettings.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C4725CB5DFB26898B74C471EBCFC783D12C696A6860AF4D34E4C0E7A8D50D19A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using NiceLabel.SDK;
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


namespace NiceLabel.SDK {
    
    
    /// <summary>
    /// WindowSettings
    /// </summary>
    public partial class WindowSettings : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\WindowSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_ComPort;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\WindowSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Server;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\WindowSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Db;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\WindowSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_User;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\WindowSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox tb_Pwd;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\WindowSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_trans;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\WindowSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_individual;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\WindowSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_individual_WY;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\WindowSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_trans;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\WindowSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_indiv;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\WindowSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_ind_WY;
        
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
            System.Uri resourceLocater = new System.Uri("/BarcodesAPP;component/windowsettings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowSettings.xaml"
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
            
            #line 8 "..\..\WindowSettings.xaml"
            ((NiceLabel.SDK.WindowSettings)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\WindowSettings.xaml"
            ((NiceLabel.SDK.WindowSettings)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 16 "..\..\WindowSettings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tb_ComPort = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\WindowSettings.xaml"
            this.tb_ComPort.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_ComPort_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tb_Server = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\WindowSettings.xaml"
            this.tb_Server.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_Server_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tb_Db = ((System.Windows.Controls.TextBox)(target));
            
            #line 46 "..\..\WindowSettings.xaml"
            this.tb_Db.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_Db_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tb_User = ((System.Windows.Controls.TextBox)(target));
            
            #line 47 "..\..\WindowSettings.xaml"
            this.tb_User.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_User_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tb_Pwd = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 48 "..\..\WindowSettings.xaml"
            this.tb_Pwd.PasswordChanged += new System.Windows.RoutedEventHandler(this.tb_Pwd_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 51 "..\..\WindowSettings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 9:
            this.tb_trans = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.tb_individual = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.tb_individual_WY = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.btn_trans = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\WindowSettings.xaml"
            this.btn_trans.Click += new System.Windows.RoutedEventHandler(this.btn_trans_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.btn_indiv = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\WindowSettings.xaml"
            this.btn_indiv.Click += new System.Windows.RoutedEventHandler(this.btn_indiv_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.btn_ind_WY = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\WindowSettings.xaml"
            this.btn_ind_WY.Click += new System.Windows.RoutedEventHandler(this.btn_ind_WY_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

