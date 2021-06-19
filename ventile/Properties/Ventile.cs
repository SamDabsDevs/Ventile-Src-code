using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Ventile_Client.Properties
{
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
	internal sealed class Ventile : ApplicationSettingsBase
	{
		private static Ventile defaultInstance;

		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool AutoInject
		{
			get
			{
				return (bool)this["AutoInject"];
			}
			set
			{
				this["AutoInject"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("N/A")]
		[UserScopedSetting]
		public string ClientVersion
		{
			get
			{
				return (string)this["ClientVersion"];
			}
			set
			{
				this["ClientVersion"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("1.0.0")]
		[UserScopedSetting]
		public string CosmeticsVersion
		{
			get
			{
				return (string)this["CosmeticsVersion"];
			}
			set
			{
				this["CosmeticsVersion"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool CustomDLL
		{
			get
			{
				return (bool)this["CustomDLL"];
			}
			set
			{
				this["CustomDLL"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool customImage
		{
			get
			{
				return (bool)this["customImage"];
			}
			set
			{
				this["customImage"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string customImageLoc
		{
			get
			{
				return (string)this["customImageLoc"];
			}
			set
			{
				this["customImageLoc"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool CustomLoc
		{
			get
			{
				return (bool)this["CustomLoc"];
			}
			set
			{
				this["CustomLoc"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string CustomLocStr
		{
			get
			{
				return (string)this["CustomLocStr"];
			}
			set
			{
				this["CustomLocStr"] = value;
			}
		}

		public static Ventile Default
		{
			get
			{
				return Ventile.defaultInstance;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string DefaultDLL
		{
			get
			{
				return (string)this["DefaultDLL"];
			}
			set
			{
				this["DefaultDLL"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool internet
		{
			get
			{
				return (bool)this["internet"];
			}
			set
			{
				this["internet"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string LineRPC
		{
			get
			{
				return (string)this["LineRPC"];
			}
			set
			{
				this["LineRPC"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool Rounded
		{
			get
			{
				return (bool)this["Rounded"];
			}
			set
			{
				this["Rounded"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool rpcButton
		{
			get
			{
				return (bool)this["rpcButton"];
			}
			set
			{
				this["rpcButton"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string rpcButtonLink
		{
			get
			{
				return (string)this["rpcButtonLink"];
			}
			set
			{
				this["rpcButtonLink"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string rpcButtonText
		{
			get
			{
				return (string)this["rpcButtonText"];
			}
			set
			{
				this["rpcButtonText"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool RpcE
		{
			get
			{
				return (bool)this["RpcE"];
			}
			set
			{
				this["RpcE"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool Toasts
		{
			get
			{
				return (bool)this["Toasts"];
			}
			set
			{
				this["Toasts"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("Beta 2.4.0")]
		[UserScopedSetting]
		public string Version
		{
			get
			{
				return (string)this["Version"];
			}
			set
			{
				this["Version"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("Hide")]
		[UserScopedSetting]
		public string WindowSetting
		{
			get
			{
				return (string)this["WindowSetting"];
			}
			set
			{
				this["WindowSetting"] = value;
			}
		}

		static Ventile()
		{
			Ventile.defaultInstance = (Ventile)SettingsBase.Synchronized(new Ventile());
		}

		public Ventile()
		{
		}
	}
}