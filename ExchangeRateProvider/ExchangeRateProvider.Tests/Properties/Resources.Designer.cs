﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExchangeRateProvider.Tests.Properties {
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
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ExchangeRateProvider.Tests.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to {&quot;Updated&quot;:&quot;2017-01-27T16:01:59Z&quot;,&quot;TableNameHeader&quot;:&quot;Currency (code)&quot;,&quot;TableGraphHeader&quot;:&quot;Last mth&quot;,&quot;TableDynamicHeaders&quot;:[&quot;27 Jan&quot;,&quot;26 Jan&quot;],&quot;TableEntries&quot;:[{&quot;Name&quot;:&quot;Australian dollar (AUD)&quot;,&quot;Id&quot;:&quot;AUD&quot;,&quot;ConversionFactor&quot;:1,&quot;Values&quot;:[&quot;6.2947&quot;,&quot;6.2805&quot;],&quot;GraphUrl&quot;:&quot;/WebDAV/stat/Valutakurser/png/aud.png&quot;},{&quot;Name&quot;:&quot;Bulgarian lev (BGN)&quot;,&quot;Id&quot;:&quot;BGN&quot;,&quot;ConversionFactor&quot;:100,&quot;Values&quot;:[&quot;456.03&quot;,&quot;456.16&quot;],&quot;GraphUrl&quot;:&quot;/WebDAV/stat/Valutakurser/png/bgn.png&quot;},{&quot;Name&quot;:&quot;Brazilian real (BRL)&quot;,&quot;Id&quot;:&quot;BRL&quot;,&quot;ConversionFactor&quot;:1 [rest of string was truncated]&quot;;.
        /// </summary>
        public static string ApiResponseJsonString {
            get {
                return ResourceManager.GetString("ApiResponseJsonString", resourceCulture);
            }
        }
    }
}