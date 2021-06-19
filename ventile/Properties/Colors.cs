using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Ventile_Client.Properties
{
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
	internal sealed class Colors : ApplicationSettingsBase
	{
		private static Colors defaultInstance;

		[DebuggerNonUserCode]
		[DefaultSettingValue("65")]
		[UserScopedSetting]
		public int accentColor1
		{
			get
			{
				return (int)this["accentColor1"];
			}
			set
			{
				this["accentColor1"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("105")]
		[UserScopedSetting]
		public int accentColor2
		{
			get
			{
				return (int)this["accentColor2"];
			}
			set
			{
				this["accentColor2"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("255")]
		[UserScopedSetting]
		public int accentColor3
		{
			get
			{
				return (int)this["accentColor3"];
			}
			set
			{
				this["accentColor3"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("20")]
		[UserScopedSetting]
		public int backColor
		{
			get
			{
				return (int)this["backColor"];
			}
			set
			{
				this["backColor"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("40")]
		[UserScopedSetting]
		public int backColor2
		{
			get
			{
				return (int)this["backColor2"];
			}
			set
			{
				this["backColor2"] = value;
			}
		}

		public static Colors Default
		{
			get
			{
				return Colors.defaultInstance;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("192")]
		[UserScopedSetting]
		public int fadedColor
		{
			get
			{
				return (int)this["fadedColor"];
			}
			set
			{
				this["fadedColor"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("255")]
		[UserScopedSetting]
		public int foreColor
		{
			get
			{
				return (int)this["foreColor"];
			}
			set
			{
				this["foreColor"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("5")]
		[UserScopedSetting]
		public int outlineColor
		{
			get
			{
				return (int)this["outlineColor"];
			}
			set
			{
				this["outlineColor"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("Dark")]
		[UserScopedSetting]
		public string theme
		{
			get
			{
				return (string)this["theme"];
			}
			set
			{
				this["theme"] = value;
			}
		}

		static Colors()
		{
			Colors.defaultInstance = (Colors)SettingsBase.Synchronized(new Colors());
		}

		public Colors()
		{
		}
	}
}