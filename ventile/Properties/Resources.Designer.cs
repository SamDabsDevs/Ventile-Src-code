using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Ventile_Client.Properties
{
	[CompilerGenerated]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	internal class Resources
	{
		private static System.Resources.ResourceManager resourceMan;

		private static CultureInfo resourceCulture;

		internal static Bitmap background
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("background", Resources.resourceCulture);
			}
		}

		internal static Bitmap background2
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("background2", Resources.resourceCulture);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		internal static Bitmap discordLogo
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("discordLogo", Resources.resourceCulture);
			}
		}

		internal static Bitmap Error
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("Error", Resources.resourceCulture);
			}
		}

		internal static Bitmap Info
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("Info", Resources.resourceCulture);
			}
		}

		internal static Bitmap internet
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("internet", Resources.resourceCulture);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new System.Resources.ResourceManager("Ventile_Client.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		internal static Bitmap Success
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("Success", Resources.resourceCulture);
			}
		}

		internal static Bitmap transparent_logo_black
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("transparent_logo_black", Resources.resourceCulture);
			}
		}

		internal static Bitmap transparent_logo_white
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("transparent_logo_white", Resources.resourceCulture);
			}
		}

		internal static Bitmap Warning
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("Warning", Resources.resourceCulture);
			}
		}

		internal static Bitmap youtube
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("youtube", Resources.resourceCulture);
			}
		}

		internal Resources()
		{
		}
	}
}