﻿#pragma checksum "C:\Users\Raúl\OneDrive - Universidad de Castilla-La Mancha\Ingeniería Informática\Tercero\INTERACCIÓN PERSONA-ORDENADOR I\Practicas\PokemonGrupal\PokemonGrupal\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C2218A56AD28D866D6690F216D591F7460763335054D4A5C83FDEF00E1369F1E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PokemonGrupal
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 27
                {
                    this.fmMain = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 3: // MainPage.xaml line 35
                {
                    this.spMenu = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 4: // MainPage.xaml line 70
                {
                    this.btMenu = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btMenu).Click += this.btMenu_Click;
                }
                break;
            case 5: // MainPage.xaml line 53
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Click += this.irInicio;
                }
                break;
            case 6: // MainPage.xaml line 56
                {
                    global::Windows.UI.Xaml.Controls.Button element6 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element6).Click += this.irPokeDex;
                }
                break;
            case 7: // MainPage.xaml line 59
                {
                    global::Windows.UI.Xaml.Controls.Button element7 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element7).Click += this.irCombate;
                }
                break;
            case 8: // MainPage.xaml line 29
                {
                    this.MyWartortle = (global::PokemonGrupal.wartortle)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
