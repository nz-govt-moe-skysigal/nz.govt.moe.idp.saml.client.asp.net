﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dk.nita.saml20.ext.brs {
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
    internal class Errors {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Errors() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("dk.nita.saml20.ext.brs.Errors", typeof(Errors).Assembly);
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
        ///   Looks up a localized string similar to Attempted read of authorisations, but no authorisations have been loaded..
        /// </summary>
        internal static string AuthorisationsNotLoaded {
            get {
                return ResourceManager.GetString("AuthorisationsNotLoaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to decode Authorisations attribute from base64 string:
        ///base64: {0}
        ///Exception: {1}.
        /// </summary>
        internal static string DecodeFailed {
            get {
                return ResourceManager.GetString("DecodeFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to decode Authorisations attribute from base64 string.
        /// </summary>
        internal static string DecodeFailedMsg {
            get {
                return ResourceManager.GetString("DecodeFailedMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempt to load a null reference.
        /// </summary>
        internal static string LoadNullAuthorisations {
            get {
                return ResourceManager.GetString("LoadNullAuthorisations", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no Authorisations attribute available for the current user. You may want to retrieve by performing an attribute query..
        /// </summary>
        internal static string NoAuthorisationsAttribute {
            get {
                return ResourceManager.GetString("NoAuthorisationsAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Saml20Identity.Current is null. The user is not logged in..
        /// </summary>
        internal static string NoSaml20Identity {
            get {
                return ResourceManager.GetString("NoSaml20Identity", resourceCulture);
            }
        }
    }
}
