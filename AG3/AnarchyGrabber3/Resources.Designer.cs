﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace yikes {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("yikes.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to const path = window.require(&apos;path&apos;);
        ///const fs = window.require(&apos;fs&apos;);
        ///const electron = window.require(&apos;electron&apos;);
        ///const Module = window.require(&apos;module&apos;).Module;
        ///Module.globalPaths.push(path.resolve(electron.remote.app.getAppPath(), &apos;node_modules&apos;));
        ///const currentWindow = electron.remote.getCurrentWindow();
        ///if (currentWindow.__preload) require(currentWindow.__preload);
        ///
        ///let currentPassword = &apos;&apos;;
        ///
        ///function sleep(ms) {
        ///    return new Promise(resolve =&gt; {
        ///        setTimeout(resolve, ms);
        ///    });
        /// </summary>
        internal static string discordmod {
            get {
                return ResourceManager.GetString("discordmod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///    This code is literally just yoinked from EnhancedDiscord cuz idk what it does atm, lmao
        ///*/
        ///
        ///const electron = require(&apos;electron&apos;);
        ///const path = require(&apos;path&apos;);
        ///const fs = require(&apos;fs&apos;);
        ///
        ///// CSP bypass
        ///electron.session.defaultSession.webRequest.onHeadersReceived(function(details, callback) {
        ///    if (!details.responseHeaders[&quot;content-security-policy-report-only&quot;] &amp;&amp; !details.responseHeaders[&quot;content-security-policy&quot;]) return callback({cancel: false});
        ///    delete details.responseHeaders[&quot;cont [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string inject {
            get {
                return ResourceManager.GetString("inject", resourceCulture);
            }
        }
    }
}