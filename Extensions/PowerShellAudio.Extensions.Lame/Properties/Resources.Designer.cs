﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PowerShellAudio.Extensions.Lame.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PowerShellAudio.Extensions.Lame.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Lame encountered an encoding error: The buffer is too small.
        /// </summary>
        internal static string NativeEncoderBufferError {
            get {
                return ResourceManager.GetString("NativeEncoderBufferError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lame encountered an encoding error: Problem allocating memory.
        /// </summary>
        internal static string NativeEncoderMemoryError {
            get {
                return ResourceManager.GetString("NativeEncoderMemoryError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lame encountered an encoding error: Psychoacoustic problems.
        /// </summary>
        internal static string NativeEncoderPsychoacousticError {
            get {
                return ResourceManager.GetString("NativeEncoderPsychoacousticError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unrecognized AddMetadata value &apos;{0}&apos;. Specify &apos;True&apos; or &apos;False&apos;. Default is &apos;True&apos;.
        /// </summary>
        internal static string SampleEncoderBadAddMetadata {
            get {
                return ResourceManager.GetString("SampleEncoderBadAddMetadata", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unrecognized BitRate value &apos;{0}&apos;. Specify a value between &apos;8&apos; and &apos;320&apos;.
        /// </summary>
        internal static string SampleEncoderBadBitRate {
            get {
                return ResourceManager.GetString("SampleEncoderBadBitRate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unrecognized ForceCBR value &apos;{0}&apos;. Specify &apos;True&apos; or &apos;False&apos;. Default is &apos;False&apos;.
        /// </summary>
        internal static string SampleEncoderBadForceCBR {
            get {
                return ResourceManager.GetString("SampleEncoderBadForceCBR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unrecognized Quality value &apos;{0}&apos;. Specify a value between &apos;0&apos; (high) and &apos;9&apos; (low). Default is &apos;3&apos;.
        /// </summary>
        internal static string SampleEncoderBadQuality {
            get {
                return ResourceManager.GetString("SampleEncoderBadQuality", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unrecognized VBRQuality value &apos;{0}&apos;. Specify a value between &apos;0&apos; (high) and &apos;9.999&apos; (low). Default is &apos;2&apos;.
        /// </summary>
        internal static string SampleEncoderBadVBRQuality {
            get {
                return ResourceManager.GetString("SampleEncoderBadVBRQuality", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lame failed to initialize the encoder using the specified settings.
        /// </summary>
        internal static string SampleEncoderFailedToInitialize {
            get {
                return ResourceManager.GetString("SampleEncoderFailedToInitialize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no sample filter named &apos;ReplayGain&apos; installed.
        /// </summary>
        internal static string SampleEncoderReplayGainFilterError {
            get {
                return ResourceManager.GetString("SampleEncoderReplayGainFilterError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ForceCBR switch must be used in conjunction with the BitRate setting.
        /// </summary>
        internal static string SampleEncoderUnexpectedForceCBR {
            get {
                return ResourceManager.GetString("SampleEncoderUnexpectedForceCBR", resourceCulture);
            }
        }
    }
}
