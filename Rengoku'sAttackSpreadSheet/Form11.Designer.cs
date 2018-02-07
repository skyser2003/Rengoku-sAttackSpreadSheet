﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rengoku_sAttackSpreadSheet {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Form1 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Form1() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Rengoku_sAttackSpreadSheet.Form1", typeof(Form1).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Point similar to {X=898,Y=17}.
        /// </summary>
        public static System.Drawing.Point AttackBoostTip_TrayLocation {
            get {
                object obj = ResourceManager.GetObject("AttackBoostTip.TrayLocation", resourceCulture);
                return ((System.Drawing.Point)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Point similar to {X=658,Y=41}.
        /// </summary>
        public static System.Drawing.Point CharmsTip_TrayLocation {
            get {
                object obj = ResourceManager.GetObject("CharmsTip.TrayLocation", resourceCulture);
                return ((System.Drawing.Point)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Point similar to {X=767,Y=41}.
        /// </summary>
        public static System.Drawing.Point CriticalBoostTips_TrayLocation {
            get {
                object obj = ResourceManager.GetObject("CriticalBoostTips.TrayLocation", resourceCulture);
                return ((System.Drawing.Point)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Point similar to {X=17,Y=41}.
        /// </summary>
        public static System.Drawing.Point CriticalEyeTip_TrayLocation {
            get {
                object obj = ResourceManager.GetObject("CriticalEyeTip.TrayLocation", resourceCulture);
                return ((System.Drawing.Point)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Modifier for Final Raw. 100 is full damage. 80 for Damage to Mast in Training Area.
        ///This is the percentage taken from the final raw AFTER the motion values modifiers are applied.
        ///Expect a variance of ~4% due to rounding.
        ///
        ///Go Here for HitZone Modifiers:
        ///https://mhworld.kiranico.com/monster.
        /// </summary>
        public static string E_ToolTip {
            get {
                return ResourceManager.GetString("E.ToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Point similar to {X=132,Y=17}.
        /// </summary>
        public static System.Drawing.Point FakeRawTip_TrayLocation {
            get {
                object obj = ResourceManager.GetObject("FakeRawTip.TrayLocation", resourceCulture);
                return ((System.Drawing.Point)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Point similar to {X=542,Y=41}.
        /// </summary>
        public static System.Drawing.Point FinalRawTip_TrayLocation {
            get {
                object obj = ResourceManager.GetObject("FinalRawTip.TrayLocation", resourceCulture);
                return ((System.Drawing.Point)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Point similar to {X=300,Y=41}.
        /// </summary>
        public static System.Drawing.Point HeroicsTip_TrayLocation {
            get {
                object obj = ResourceManager.GetObject("HeroicsTip.TrayLocation", resourceCulture);
                return ((System.Drawing.Point)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Point similar to {X=641,Y=17}.
        /// </summary>
        public static System.Drawing.Point HitZoneTips_TrayLocation {
            get {
                object obj = ResourceManager.GetObject("HitZoneTips.TrayLocation", resourceCulture);
                return ((System.Drawing.Point)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value seen in Equipment Info.If using the Value from the Status screen.
        ///Trua Raw  is obtained after dividing by the Weapon Class modifier.
        ///
        ///If using the Value from the Status screen:
        /// -Remove all Skill Modifiers as they would be counted already.
        /// - In the case of Weakness Exploit or Attack Boost, just add the amount to Natural Affinity..
        /// </summary>
        public static string label1_ToolTip {
            get {
                return ResourceManager.GetString("label1.ToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Affinity seen in Equipment Info.
        ///If using the Value from the Status screen:
        /// -Remove all Skill Modifiers as they would be counted already.
        /// - In the case of Weakness Exploit or Attack Boost, just add the amount to Natural Affinity..
        /// </summary>
        public static string label10_ToolTip {
            get {
                return ResourceManager.GetString("label10.ToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uses True Raw:
        ///Level 1: +3 Attack Power
        ///Level 2: +6 Attack Power
        ///Level 3: +9 Attack Power
        ///Level 4: +12 Attack and +5% Affinity
        ///Level 5: +15 Attack and +5% Affinity
        ///Level 6: +18 Attack and +5% Affinity
        ///Level 7: +21 Attack and +5% Affinity.
        /// </summary>
        public static string label3_ToolTip {
            get {
                return ResourceManager.GetString("label3.ToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Modifier for Final Raw. 100 is full damage. 80 for Damage to Mast in Training Area.
        ///This is the percentage taken from the final raw AFTER the motion values modifiers are applied.
        ///Expect a variance of ~4% due to rounding.
        ///
        ///Go Here for HitZone Modifiers:
        ///https://mhworld.kiranico.com/monster.
        /// </summary>
        public static string label9_ToolTip {
            get {
                return ResourceManager.GetString("label9.ToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Point similar to {X=248,Y=17}.
        /// </summary>
        public static System.Drawing.Point MotionValue_TrayLocation {
            get {
                object obj = ResourceManager.GetObject("MotionValue.TrayLocation", resourceCulture);
                return ((System.Drawing.Point)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Boolean similar to True.
        /// </summary>
        public static bool MotionValueBox_Locked {
            get {
                object obj = ResourceManager.GetObject("MotionValueBox.Locked", resourceCulture);
                return ((bool)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Affinity seen in Equipment Info.
        ///If using the Value from the Status screen:
        /// -Remove all Skill Modifiers as they would be counted already.
        /// - In the case of Weakness Exploit or Attack Boost, just add the amount to Natural Affinity..
        /// </summary>
        public static string NaturalAffinityLabel_ToolTip {
            get {
                return ResourceManager.GetString("NaturalAffinityLabel.ToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Point similar to {X=494,Y=17}.
        /// </summary>
        public static System.Drawing.Point NaturalAffinityTip_TrayLocation {
            get {
                object obj = ResourceManager.GetObject("NaturalAffinityTip.TrayLocation", resourceCulture);
                return ((System.Drawing.Point)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Point similar to {X=409,Y=41}.
        /// </summary>
        public static System.Drawing.Point ResentmentTip_TrayLocation {
            get {
                object obj = ResourceManager.GetObject("ResentmentTip.TrayLocation", resourceCulture);
                return ((System.Drawing.Point)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Point similar to {X=370,Y=17}.
        /// </summary>
        public static System.Drawing.Point ShowModTip_TrayLocation {
            get {
                object obj = ResourceManager.GetObject("ShowModTip.TrayLocation", resourceCulture);
                return ((System.Drawing.Point)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Point similar to {X=17,Y=17}.
        /// </summary>
        public static System.Drawing.Point TrueRawTip_TrayLocation {
            get {
                object obj = ResourceManager.GetObject("TrueRawTip.TrayLocation", resourceCulture);
                return ((System.Drawing.Point)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Point similar to {X=141,Y=41}.
        /// </summary>
        public static System.Drawing.Point WeaknessExploitTip_TrayLocation {
            get {
                object obj = ResourceManager.GetObject("WeaknessExploitTip.TrayLocation", resourceCulture);
                return ((System.Drawing.Point)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Point similar to {X=758,Y=17}.
        /// </summary>
        public static System.Drawing.Point WeaponModTip_TrayLocation {
            get {
                object obj = ResourceManager.GetObject("WeaponModTip.TrayLocation", resourceCulture);
                return ((System.Drawing.Point)(obj));
            }
        }
    }
}
