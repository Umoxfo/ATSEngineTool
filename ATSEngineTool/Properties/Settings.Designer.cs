﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ATSEngineTool.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Updated {
            get {
                return ((bool)(this["Updated"]));
            }
            set {
                this["Updated"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SteamPath {
            get {
                return ((string)(this["SteamPath"]));
            }
            set {
                this["SteamPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IntegrateWithMod {
            get {
                return ((bool)(this["IntegrateWithMod"]));
            }
            set {
                this["IntegrateWithMod"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UpdateCheck {
            get {
                return ((bool)(this["UpdateCheck"]));
            }
            set {
                this["UpdateCheck"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Imperial")]
        public global::ATSEngineTool.UnitSystem UnitSystem {
            get {
                return ((global::ATSEngineTool.UnitSystem)(this["UnitSystem"]));
            }
            set {
                this["UnitSystem"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Imperial")]
        public global::ATSEngineTool.UnitSystem TorqueOutputUnitSystem {
            get {
                return ((global::ATSEngineTool.UnitSystem)(this["TorqueOutputUnitSystem"]));
            }
            set {
                this["TorqueOutputUnitSystem"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("TransmissionOnly")]
        public global::ATSEngineTool.CompileOption CompileOption {
            get {
                return ((global::ATSEngineTool.CompileOption)(this["CompileOption"]));
            }
            set {
                this["CompileOption"] = value;
            }
        }
    }
}
