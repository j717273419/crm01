﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BrightVision.Reporting.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BrightVision.Reporting.Properties.Resources", typeof(Resources).Assembly);
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
        
        internal static System.Drawing.Icon bv_logo {
            get {
                object obj = ResourceManager.GetObject("bv_logo", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;report_data&gt;
        ///	&lt;accounts&gt;
        ///		&lt;account  id=&quot;&quot;
        ///				  company_name=&quot;Company 1&quot;
        ///				  org_no=&quot;&quot;
        ///				  box_address=&quot;&quot;
        ///				  street_address=&quot;Company 1 Address&quot;
        ///				  zipcode=&quot;&quot;
        ///				  country=&quot;&quot;
        ///				  county=&quot;Company 1 State&quot;
        ///				  municipality=&quot;&quot;
        ///				  city=&quot;Company 1 City&quot;
        ///				  telephone=&quot;123345&quot;
        ///				  telefax=&quot;1231223443&quot;
        ///				  www=&quot;www.yahoo.com&quot;
        ///				  parent_company=&quot;&quot;
        ///				  year_established=&quot;&quot;
        ///				  activity_code=&quot;&quot;
        ///				  activity_code_2=&quot;&quot;
        ///				  currency=&quot;&quot;
        ///				  fiscal=&quot;&quot;
        ///				  turnove [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string sample_xml_data {
            get {
                return ResourceManager.GetString("sample_xml_data", resourceCulture);
            }
        }
    }
}
