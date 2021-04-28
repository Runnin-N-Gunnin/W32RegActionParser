﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace W32RegActionParser.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("W32RegActionParser.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Unique identifier assigned to a particular action for a software element..
        /// </summary>
        internal static string Col0DescriptionText {
            get {
                return ResourceManager.GetString("Col0DescriptionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Identifier for the software element..
        /// </summary>
        internal static string Col10DescriptionText {
            get {
                return ResourceManager.GetString("Col10DescriptionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to State of a software element.
        ///1: Deployable
        ///2: Installable
        ///3: Executable
        ///4: Running.
        /// </summary>
        internal static string Col11DescriptionText {
            get {
                return ResourceManager.GetString("Col11DescriptionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Target operating system of the owning software element. The possible values for this property are as follows.
        ///0: Unknown
        ///1: Other
        ///17: WIN98
        ///18: WINNT
        ///19: WINCE.
        /// </summary>
        internal static string Col12DescriptionText {
            get {
                return ResourceManager.GetString("Col12DescriptionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Version of the software element. Values should be in the form [Major].[Minor].[Revision]
        ///or [Major].[Minor][letter][revision]..
        /// </summary>
        internal static string Col13DescriptionText {
            get {
                return ResourceManager.GetString("Col13DescriptionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Short textual description of the object..
        /// </summary>
        internal static string Col1DescriptionText {
            get {
                return ResourceManager.GetString("Col1DescriptionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Description of the object..
        /// </summary>
        internal static string Col2DescriptionText {
            get {
                return ResourceManager.GetString("Col2DescriptionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Whether a particular CIM_Action object is part of a sequence of actions to transition the current software element to its next state (Install) or to remove the current software element (Uninstall).
        ///1: Install
        ///2: Uninstall.
        /// </summary>
        internal static string Col3DescriptionText {
            get {
                return ResourceManager.GetString("Col3DescriptionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property is written to the default registry key..
        /// </summary>
        internal static string Col4DescriptionText {
            get {
                return ResourceManager.GetString("Col4DescriptionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Registry value..
        /// </summary>
        internal static string Col5DescriptionText {
            get {
                return ResourceManager.GetString("Col5DescriptionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Key for the registry value..
        /// </summary>
        internal static string Col6DescriptionText {
            get {
                return ResourceManager.GetString("Col6DescriptionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name used to identify the software element..
        /// </summary>
        internal static string Col7DescriptionText {
            get {
                return ResourceManager.GetString("Col7DescriptionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Registry value name. If the EntryValue property is null, then the following strings in the Name property have special significance.
        ///+: The key is to be created, if absent upon the installation of the component.
        ///-: The key is to be deleted, if present, with all its values and subkeys upon the uninstallation of the component.
        ///*: The key is to be created, if absent upon the installation of the component AND the key is to be deleted, if present, with all its values and subkeys upon the uninstallation of the  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Col8DescriptionText {
            get {
                return ResourceManager.GetString("Col8DescriptionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to State of a software element.
        ///-1: HKEY_CURRENT_USER 
        ///-1: HKEY_LOCAL_MACHINE
        ///0: HKEY_CLASSES_ROOT
        ///1: HKEY_CURRENT_USER
        ///2: HKEY_LOCAL_MACHINE
        ///3: HKEY_USERS.
        /// </summary>
        internal static string Col9DescriptionText {
            get {
                return ResourceManager.GetString("Col9DescriptionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap reg22 {
            get {
                object obj = ResourceManager.GetObject("reg22", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
