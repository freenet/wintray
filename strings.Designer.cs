﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FreenetTray {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FreenetTray.strings", typeof(strings).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following details will help people provide support:.
        /// </summary>
        internal static string AdditionalCrashInfo {
            get {
                return ResourceManager.GetString("AdditionalCrashInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Choose the folder Freenet is installed to..
        /// </summary>
        internal static string ChooseCustomLocation {
            get {
                return ResourceManager.GetString("ChooseCustomLocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Freenet is starting..
        /// </summary>
        internal static string FreenetStarting {
            get {
                return ResourceManager.GetString("FreenetStarting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No Java runtime is available.
        /// </summary>
        internal static string JRENotFound {
            get {
                return ResourceManager.GetString("JRENotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration file &apos;{0}&apos; does not contain a valid value for &apos;{1}&apos;..
        /// </summary>
        internal static string MalformedConfig {
            get {
                return ResourceManager.GetString("MalformedConfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The path is too long. Please install Freenet to a folder with a shorter path..
        /// </summary>
        internal static string PathTooLong {
            get {
                return ResourceManager.GetString("PathTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown Error.
        /// </summary>
        internal static string UnknownWrapperLaunchErrorTitle {
            get {
                return ResourceManager.GetString("UnknownWrapperLaunchErrorTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This tray icon controls Freenet. Left-click opens Freenet and right-click opens a menu..
        /// </summary>
        internal static string WelcomeTip {
            get {
                return ResourceManager.GetString("WelcomeTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrapper executable was not found at &apos;{0}&apos;..
        /// </summary>
        internal static string WrapperFileNotFound {
            get {
                return ResourceManager.GetString("WrapperFileNotFound", resourceCulture);
            }
        }
    }
}
