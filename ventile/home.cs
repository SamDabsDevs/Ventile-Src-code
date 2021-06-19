using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Ventile_Client.Properties;

namespace Ventile_Client
{
	public class home : Form
	{
		private RPC drpc = new RPC();

		public static home instance;

		private bool selectedDLL = false;

		private int mouseX = 0;

		private int mouseY = 0;

		private int mouseinX = 0;

		private int mouseinY = 0;

		private bool mouseDown;

		private Form activeForm = null;

		private bool attemptedReload = false;

		public bool inGameTest = false;

		public bool hidden = false;

		private string dllPath;

		private const int PROCESS_CREATE_THREAD = 2;

		private const int PROCESS_QUERY_INFORMATION = 1024;

		private const int PROCESS_VM_OPERATION = 8;

		private const int PROCESS_VM_WRITE = 32;

		private const int PROCESS_VM_READ = 16;

		private const uint MEM_COMMIT = 4096;

		private const uint MEM_RESERVE = 8192;

		private const uint PAGE_READWRITE = 4;

		private static bool alreadyAttemptedInject;

		private IContainer components = null;

		private System.Windows.Forms.Timer FadeOut;

		private System.Windows.Forms.Timer tick;

		private Label label1;

		public Button close;

		public Button minus;

		public Panel topPanel;

		public PictureBox pictureBox3;

		public Panel sidebar;

		public IconButton iconButton4;

		public IconButton iconButton3;

		public IconButton iconButton2;

		public IconButton iconButton1;

		public Label version;

		public Label title;

		public Button line;

		public PictureBox selectedIndicator;

		public Panel panelChildForm;

		public System.Windows.Forms.Timer FadeIn;

		public Guna2Button inject;

		public Guna2Button selectDll;

		public Guna2Button launchMc;

		public home()
		{
			Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2);
			this.InitializeComponent();
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Region = System.Drawing.Region.FromHrgn(home.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
			this.iconButton1.BackColor = Color.Transparent;
			home.instance = this;
		}

		public static void applyAppPackages(string DLLPath)
		{
			FileInfo fileInfo = new FileInfo(DLLPath);
			FileSecurity accessControl = fileInfo.GetAccessControl();
			accessControl.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier("S-1-15-2-1"), FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
			fileInfo.SetAccessControl(accessControl);
		}

		private void close_Click_1(object sender, EventArgs e)
		{
			Cosmetic.Default.Save();
			Ventile.Default.Save();
			Colors.Default.Save();
			this.drpc.Deinitialize();
			Thread.Sleep(100);
			this.FadeOut.Start();
		}

		[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

		[DllImport("Gdi32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		public void download(string link, string path, string name)
		{
			using (WebClient webClient = new WebClient())
			{
				if (!Ventile.Default.CustomLocStr.EndsWith("\\"))
				{
					webClient.DownloadFile(link, string.Concat(path, "\\", name));
				}
				else
				{
					webClient.DownloadFile(link, string.Concat(path, name));
				}
			}
		}

		private void FadeIn_Tick(object sender, EventArgs e)
		{
			if (base.Opacity >= 1)
			{
				this.FadeIn.Stop();
			}
			base.Opacity = base.Opacity + 0.04;
		}

		private void FadeOut_Tick(object sender, EventArgs e)
		{
			if (base.Opacity <= 0)
			{
				this.FadeOut.Stop();
				base.Close();
			}
			base.Opacity = base.Opacity - 0.04;
		}

		[DllImport("kernel32.dll", CharSet=CharSet.Auto, ExactSpelling=false)]
		public static extern IntPtr GetModuleHandle(string lpModuleName);

		[DllImport("kernel32", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

		private void home_Load(object sender, EventArgs e)
		{
			if (Ventile.Default.RpcE)
			{
				this.drpc.Initialize();
			}
			(new Updater()).Show();
			Color color = Color.FromArgb(Colors.Default.backColor, Colors.Default.backColor, Colors.Default.backColor);
			Color color1 = Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3);
			Color color2 = Color.FromArgb(Colors.Default.foreColor, Colors.Default.foreColor, Colors.Default.foreColor);
			Color color3 = Color.FromArgb(Colors.Default.outlineColor, Colors.Default.outlineColor, Colors.Default.outlineColor);
			Color color4 = Color.FromArgb(Colors.Default.fadedColor, Colors.Default.fadedColor, Colors.Default.fadedColor);
			Color color5 = Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2);
			this.selectedIndicator.BackColor = color1;
			this.iconButton1.set_IconColor(color1);
			this.iconButton1.ForeColor = color2;
			this.iconButton1.BackColor = Color.Transparent;
			this.iconButton1.FlatAppearance.MouseOverBackColor = color5;
			this.iconButton2.set_IconColor(color1);
			this.iconButton2.ForeColor = color2;
			this.iconButton2.BackColor = Color.Transparent;
			this.iconButton2.FlatAppearance.MouseOverBackColor = color5;
			this.iconButton3.set_IconColor(color1);
			this.iconButton3.ForeColor = color2;
			this.iconButton3.BackColor = Color.Transparent;
			this.iconButton3.FlatAppearance.MouseOverBackColor = color5;
			this.iconButton4.set_IconColor(color1);
			this.iconButton4.ForeColor = color2;
			this.iconButton4.BackColor = Color.Transparent;
			this.iconButton4.FlatAppearance.MouseOverBackColor = color5;
			this.sidebar.BackColor = color;
			this.topPanel.BackColor = color;
			this.launchMc.set_FillColor(color);
			this.selectDll.set_FillColor(color);
			this.inject.set_FillColor(color);
			this.close.BackColor = color;
			this.minus.BackColor = color;
			this.title.ForeColor = color2;
			this.line.ForeColor = color2;
			this.version.ForeColor = color4;
			this.launchMc.ForeColor = color2;
			this.selectDll.ForeColor = color2;
			this.inject.ForeColor = color2;
			this.launchMc.set_BorderColor(color3);
			this.selectDll.set_BorderColor(color3);
			this.inject.set_BorderColor(color3);
			if (Colors.Default.theme == "Dark")
			{
				this.pictureBox3.BackgroundImage = Resources.transparent_logo_white;
				this.panelChildForm.BackgroundImage = Resources.background;
			}
			else if (Colors.Default.theme == "Light")
			{
				this.pictureBox3.BackgroundImage = Resources.transparent_logo_black;
				this.panelChildForm.BackgroundImage = Resources.background2;
			}
			if (Ventile.Default.customImage)
			{
				this.panelChildForm.BackgroundImage = new Bitmap(Ventile.Default.customImageLoc);
			}
			this.launchMc.Location = new Point(169, 171);
			this.selectDll.Location = new Point(169, 248);
			this.inject.Location = new Point(357, 248);
			this.version.Text = Ventile.Default.Version.ToString();
			if (!Ventile.Default.CustomLoc)
			{
				Ventile.Default.CustomLocStr = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "\\Packages\\Microsoft.MinecraftUWP_8wekyb3d8bbwe\\LocalState\\games\\com.mojang\\resource_packs");
			}
			if (!Ventile.Default.CustomDLL)
			{
				this.selectDll.Visible = false;
			}
			else if (Ventile.Default.CustomDLL)
			{
				this.selectDll.Visible = true;
				this.selectDll.Location = new Point(235, 248);
			}
			if (Ventile.Default.AutoInject)
			{
				this.inject.Visible = false;
			}
			else if (!Ventile.Default.AutoInject)
			{
				this.inject.Visible = true;
				this.inject.Location = new Point(260, 248);
			}
			if ((!Ventile.Default.CustomDLL ? false : !Ventile.Default.AutoInject))
			{
				this.selectDll.Location = new Point(169, 248);
				this.inject.Location = new Point(357, 248);
			}
			if (Ventile.Default.RpcE)
			{
				Thread.Sleep(100);
				this.drpc.Initialize();
			}
			Ventile.Default.internet = home.InternetCheck();
			Thread.Sleep(1000);
			if (File.Exists("C:\\temp\\VentileClient\\Version.txt"))
			{
				File.Delete("C:\\temp\\VentileClient\\Version.txt");
			}
			if (File.Exists("C:\\temp\\VentileClient\\Version.zip"))
			{
				File.Delete("C:\\temp\\VentileClient\\Version.zip");
			}
			if (!Ventile.Default.internet)
			{
				this.Toast("Internet", "You do not have an active wifi connection");
			}
			else
			{
				if (Directory.Exists(string.Concat(Ventile.Default.CustomLocStr, "CosmeticMixer.zip")))
				{
					Directory.Delete(string.Concat(Ventile.Default.CustomLocStr, "CosmeticMixer.zip"));
				}
				this.download("https://github.com/DeathlyBower959/Ventile-Client-Downloads/releases/latest/download/Cosmetic.Mixer.V6.zip", Ventile.Default.CustomLocStr, "CosmeticMixer.zip");
				if (!Directory.Exists("C:\\temp"))
				{
					Directory.CreateDirectory("C:\\temp");
				}
				if (!Directory.Exists("C:\\temp\\VentileClient"))
				{
					Directory.CreateDirectory("C:\\temp\\VentileClient");
				}
			}
		}

		private void iconButton1_Click(object sender, EventArgs e)
		{
			Color.FromArgb(Colors.Default.backColor, Colors.Default.backColor, Colors.Default.backColor);
			Color color = Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2);
			Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3);
			if (this.activeForm != null)
			{
				this.activeForm.Close();
			}
			this.iconButton1.BackColor = color;
			this.iconButton2.BackColor = Color.Transparent;
			this.iconButton3.BackColor = Color.Transparent;
			this.iconButton4.BackColor = Color.Transparent;
			this.selectedIndicator.Location = new Point(0, 165);
			this.reloadHome();
		}

		private void iconButton2_Click(object sender, EventArgs e)
		{
			Color.FromArgb(Colors.Default.backColor, Colors.Default.backColor, Colors.Default.backColor);
			Color color = Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2);
			this.openChildForm(new cosmetics());
			this.iconButton2.BackColor = color;
			this.iconButton1.BackColor = Color.Transparent;
			this.iconButton3.BackColor = Color.Transparent;
			this.iconButton4.BackColor = Color.Transparent;
			this.selectedIndicator.Location = new Point(0, 220);
		}

		private void iconButton3_Click(object sender, EventArgs e)
		{
			Color.FromArgb(Colors.Default.backColor, Colors.Default.backColor, Colors.Default.backColor);
			Color color = Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2);
			this.openChildForm(new settings(this));
			this.iconButton3.BackColor = color;
			this.iconButton2.BackColor = Color.Transparent;
			this.iconButton1.BackColor = Color.Transparent;
			this.iconButton4.BackColor = Color.Transparent;
			this.selectedIndicator.Location = new Point(0, 280);
		}

		private void iconButton4_Click(object sender, EventArgs e)
		{
			Color.FromArgb(Colors.Default.backColor, Colors.Default.backColor, Colors.Default.backColor);
			Color color = Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2);
			this.openChildForm(new about());
			this.iconButton4.BackColor = color;
			this.iconButton2.BackColor = Color.Transparent;
			this.iconButton3.BackColor = Color.Transparent;
			this.iconButton1.BackColor = Color.Transparent;
			this.selectedIndicator.Location = new Point(0, 340);
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(home));
			this.close = new Button();
			this.minus = new Button();
			this.topPanel = new Panel();
			this.pictureBox3 = new PictureBox();
			this.sidebar = new Panel();
			this.selectedIndicator = new PictureBox();
			this.title = new Label();
			this.line = new Button();
			this.iconButton1 = new IconButton();
			this.label1 = new Label();
			this.version = new Label();
			this.iconButton4 = new IconButton();
			this.iconButton3 = new IconButton();
			this.iconButton2 = new IconButton();
			this.panelChildForm = new Panel();
			this.inject = new Guna2Button();
			this.selectDll = new Guna2Button();
			this.launchMc = new Guna2Button();
			this.FadeOut = new System.Windows.Forms.Timer(this.components);
			this.tick = new System.Windows.Forms.Timer(this.components);
			this.FadeIn = new System.Windows.Forms.Timer(this.components);
			this.topPanel.SuspendLayout();
			((ISupportInitialize)this.pictureBox3).BeginInit();
			this.sidebar.SuspendLayout();
			((ISupportInitialize)this.selectedIndicator).BeginInit();
			this.panelChildForm.SuspendLayout();
			base.SuspendLayout();
			componentResourceManager.ApplyResources(this.close, "close");
			this.close.FlatAppearance.BorderColor = Color.Black;
			this.close.FlatAppearance.MouseDownBackColor = Color.Gray;
			this.close.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
			this.close.ForeColor = Color.Silver;
			this.close.Name = "close";
			this.close.TabStop = false;
			this.close.UseCompatibleTextRendering = true;
			this.close.UseVisualStyleBackColor = true;
			this.close.Click += new EventHandler(this.close_Click_1);
			componentResourceManager.ApplyResources(this.minus, "minus");
			this.minus.BackColor = Color.FromArgb(20, 20, 20);
			this.minus.FlatAppearance.BorderColor = Color.Black;
			this.minus.FlatAppearance.BorderSize = 0;
			this.minus.FlatAppearance.MouseDownBackColor = Color.Gray;
			this.minus.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
			this.minus.ForeColor = Color.Silver;
			this.minus.Name = "minus";
			this.minus.TabStop = false;
			this.minus.UseCompatibleTextRendering = true;
			this.minus.UseVisualStyleBackColor = false;
			this.minus.Click += new EventHandler(this.minus_Click);
			this.topPanel.BackColor = Color.FromArgb(20, 20, 20);
			this.topPanel.Controls.Add(this.minus);
			this.topPanel.Controls.Add(this.close);
			componentResourceManager.ApplyResources(this.topPanel, "topPanel");
			this.topPanel.Name = "topPanel";
			this.topPanel.MouseDown += new MouseEventHandler(this.topPanel_MouseDown);
			this.topPanel.MouseMove += new MouseEventHandler(this.topPanel_MouseMove);
			this.topPanel.MouseUp += new MouseEventHandler(this.topPanel_MouseUp);
			this.pictureBox3.BackColor = Color.Transparent;
			this.pictureBox3.BackgroundImage = Resources.transparent_logo_white;
			componentResourceManager.ApplyResources(this.pictureBox3, "pictureBox3");
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new EventHandler(this.pictureBox3_Click);
			this.sidebar.BackColor = Color.FromArgb(20, 20, 20);
			this.sidebar.Controls.Add(this.selectedIndicator);
			this.sidebar.Controls.Add(this.title);
			this.sidebar.Controls.Add(this.line);
			this.sidebar.Controls.Add(this.iconButton1);
			this.sidebar.Controls.Add(this.label1);
			this.sidebar.Controls.Add(this.version);
			this.sidebar.Controls.Add(this.iconButton4);
			this.sidebar.Controls.Add(this.iconButton3);
			this.sidebar.Controls.Add(this.iconButton2);
			this.sidebar.Controls.Add(this.pictureBox3);
			componentResourceManager.ApplyResources(this.sidebar, "sidebar");
			this.sidebar.Name = "sidebar";
			this.selectedIndicator.BackColor = Color.RoyalBlue;
			componentResourceManager.ApplyResources(this.selectedIndicator, "selectedIndicator");
			this.selectedIndicator.Name = "selectedIndicator";
			this.selectedIndicator.TabStop = false;
			componentResourceManager.ApplyResources(this.title, "title");
			this.title.ForeColor = Color.White;
			this.title.Name = "title";
			this.line.BackColor = Color.Transparent;
			this.line.Cursor = Cursors.Default;
			this.line.FlatAppearance.BorderSize = 0;
			this.line.FlatAppearance.MouseDownBackColor = Color.Transparent;
			this.line.FlatAppearance.MouseOverBackColor = Color.Transparent;
			componentResourceManager.ApplyResources(this.line, "line");
			this.line.ForeColor = Color.White;
			this.line.Name = "line";
			this.line.TabStop = false;
			this.line.UseVisualStyleBackColor = false;
			this.iconButton1.BackColor = Color.Transparent;
			this.iconButton1.Cursor = Cursors.Hand;
			this.iconButton1.FlatAppearance.BorderSize = 0;
			this.iconButton1.FlatAppearance.MouseDownBackColor = Color.Gray;
			this.iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
			componentResourceManager.ApplyResources(this.iconButton1, "iconButton1");
			this.iconButton1.ForeColor = Color.White;
			this.iconButton1.set_IconChar(61461);
			this.iconButton1.set_IconColor(Color.RoyalBlue);
			this.iconButton1.set_IconFont(0);
			this.iconButton1.Name = "iconButton1";
			this.iconButton1.TabStop = false;
			this.iconButton1.UseVisualStyleBackColor = false;
			this.iconButton1.Click += new EventHandler(this.iconButton1_Click);
			componentResourceManager.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			componentResourceManager.ApplyResources(this.version, "version");
			this.version.ForeColor = Color.Silver;
			this.version.Name = "version";
			this.iconButton4.BackColor = Color.Transparent;
			this.iconButton4.Cursor = Cursors.Hand;
			this.iconButton4.FlatAppearance.BorderSize = 0;
			this.iconButton4.FlatAppearance.MouseDownBackColor = Color.Gray;
			this.iconButton4.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
			componentResourceManager.ApplyResources(this.iconButton4, "iconButton4");
			this.iconButton4.ForeColor = Color.White;
			this.iconButton4.set_IconChar(61737);
			this.iconButton4.set_IconColor(Color.RoyalBlue);
			this.iconButton4.set_IconFont(0);
			this.iconButton4.Name = "iconButton4";
			this.iconButton4.TabStop = false;
			this.iconButton4.UseVisualStyleBackColor = false;
			this.iconButton4.Click += new EventHandler(this.iconButton4_Click);
			this.iconButton3.BackColor = Color.Transparent;
			this.iconButton3.Cursor = Cursors.Hand;
			this.iconButton3.FlatAppearance.BorderSize = 0;
			this.iconButton3.FlatAppearance.MouseDownBackColor = Color.Gray;
			this.iconButton3.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
			componentResourceManager.ApplyResources(this.iconButton3, "iconButton3");
			this.iconButton3.ForeColor = Color.White;
			this.iconButton3.set_IconChar(61459);
			this.iconButton3.set_IconColor(Color.RoyalBlue);
			this.iconButton3.set_IconFont(0);
			this.iconButton3.Name = "iconButton3";
			this.iconButton3.TabStop = false;
			this.iconButton3.UseVisualStyleBackColor = false;
			this.iconButton3.Click += new EventHandler(this.iconButton3_Click);
			this.iconButton2.BackColor = Color.Transparent;
			this.iconButton2.Cursor = Cursors.Hand;
			this.iconButton2.FlatAppearance.BorderSize = 0;
			this.iconButton2.FlatAppearance.MouseDownBackColor = Color.Gray;
			this.iconButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
			componentResourceManager.ApplyResources(this.iconButton2, "iconButton2");
			this.iconButton2.ForeColor = Color.White;
			this.iconButton2.set_IconChar(62803);
			this.iconButton2.set_IconColor(Color.RoyalBlue);
			this.iconButton2.set_IconFont(0);
			this.iconButton2.Name = "iconButton2";
			this.iconButton2.TabStop = false;
			this.iconButton2.UseVisualStyleBackColor = false;
			this.iconButton2.Click += new EventHandler(this.iconButton2_Click);
			this.panelChildForm.BackColor = Color.Transparent;
			this.panelChildForm.BackgroundImage = Resources.background;
			componentResourceManager.ApplyResources(this.panelChildForm, "panelChildForm");
			this.panelChildForm.Controls.Add(this.inject);
			this.panelChildForm.Controls.Add(this.selectDll);
			this.panelChildForm.Controls.Add(this.launchMc);
			this.panelChildForm.Name = "panelChildForm";
			this.inject.set_Animated(true);
			this.inject.get_CheckedState().set_Parent(this.inject);
			this.inject.Cursor = Cursors.Hand;
			this.inject.set_CustomBorderColor(Color.Black);
			this.inject.set_CustomBorderThickness(new System.Windows.Forms.Padding(3));
			this.inject.get_CustomImages().set_Parent(this.inject);
			this.inject.set_FillColor(Color.FromArgb(20, 20, 20));
			componentResourceManager.ApplyResources(this.inject, "inject");
			this.inject.ForeColor = Color.White;
			this.inject.get_HoverState().set_Parent(this.inject);
			this.inject.Name = "inject";
			this.inject.get_ShadowDecoration().set_Parent(this.inject);
			this.inject.TabStop = false;
			this.inject.Click += new EventHandler(this.inject_Click);
			this.selectDll.set_Animated(true);
			this.selectDll.get_CheckedState().set_Parent(this.selectDll);
			this.selectDll.Cursor = Cursors.Hand;
			this.selectDll.set_CustomBorderColor(Color.Black);
			this.selectDll.set_CustomBorderThickness(new System.Windows.Forms.Padding(3));
			this.selectDll.get_CustomImages().set_Parent(this.selectDll);
			this.selectDll.set_FillColor(Color.FromArgb(20, 20, 20));
			componentResourceManager.ApplyResources(this.selectDll, "selectDll");
			this.selectDll.ForeColor = Color.White;
			this.selectDll.get_HoverState().set_Parent(this.selectDll);
			this.selectDll.Name = "selectDll";
			this.selectDll.get_ShadowDecoration().set_Parent(this.selectDll);
			this.selectDll.TabStop = false;
			this.selectDll.Click += new EventHandler(this.selectDll_Click);
			this.launchMc.set_Animated(true);
			this.launchMc.get_CheckedState().set_Parent(this.launchMc);
			this.launchMc.Cursor = Cursors.Hand;
			this.launchMc.set_CustomBorderColor(Color.Black);
			this.launchMc.set_CustomBorderThickness(new System.Windows.Forms.Padding(3));
			this.launchMc.get_CustomImages().set_Parent(this.launchMc);
			this.launchMc.set_FillColor(Color.FromArgb(20, 20, 20));
			componentResourceManager.ApplyResources(this.launchMc, "launchMc");
			this.launchMc.ForeColor = Color.White;
			this.launchMc.get_HoverState().set_Parent(this.launchMc);
			this.launchMc.Name = "launchMc";
			this.launchMc.get_ShadowDecoration().set_Parent(this.launchMc);
			this.launchMc.TabStop = false;
			this.launchMc.Click += new EventHandler(this.launchMc_Click);
			this.FadeOut.Interval = 1;
			this.FadeOut.Tick += new EventHandler(this.FadeOut_Tick);
			this.tick.Enabled = true;
			this.tick.Interval = 500;
			this.tick.Tick += new EventHandler(this.tick_Tick);
			this.FadeIn.Interval = 1;
			this.FadeIn.Tick += new EventHandler(this.FadeIn_Tick);
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = SystemColors.Control;
			this.BackgroundImage = Resources.background;
			base.Controls.Add(this.panelChildForm);
			base.Controls.Add(this.topPanel);
			base.Controls.Add(this.sidebar);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "home";
			base.Opacity = 0;
			base.Load += new EventHandler(this.home_Load);
			this.topPanel.ResumeLayout(false);
			((ISupportInitialize)this.pictureBox3).EndInit();
			this.sidebar.ResumeLayout(false);
			this.sidebar.PerformLayout();
			((ISupportInitialize)this.selectedIndicator).EndInit();
			this.panelChildForm.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private void inject_Click(object sender, EventArgs e)
		{
			if (Process.GetProcessesByName("Minecraft.Windows").Length != 0)
			{
				if ((!Ventile.Default.CustomDLL ? false : this.selectedDLL))
				{
					this.InjectDLL(this.dllPath);
				}
			}
		}

		public void InjectDLL(string DownloadedDllFilePath)
		{
			UIntPtr uIntPtr;
			Thread.Sleep(1000);
			if (Process.GetProcessesByName("Minecraft.Windows").Length != 0)
			{
				home.applyAppPackages(DownloadedDllFilePath);
				Process processesByName = Process.GetProcessesByName("Minecraft.Windows")[0];
				IntPtr intPtr = home.OpenProcess(1082, false, processesByName.Id);
				IntPtr procAddress = home.GetProcAddress(home.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
				IntPtr intPtr1 = home.VirtualAllocEx(intPtr, IntPtr.Zero, (uint)((DownloadedDllFilePath.Length + 1) * Marshal.SizeOf(typeof(char))), 12288, 4);
				home.WriteProcessMemory(intPtr, intPtr1, Encoding.Default.GetBytes(DownloadedDllFilePath), (uint)((DownloadedDllFilePath.Length + 1) * Marshal.SizeOf(typeof(char))), out uIntPtr);
				home.CreateRemoteThread(intPtr, IntPtr.Zero, 0, procAddress, intPtr1, 0, IntPtr.Zero);
				home.alreadyAttemptedInject = false;
				this.Toast("DLL", "Injected!");
			}
			else if (home.alreadyAttemptedInject)
			{
				this.Toast("Minecraft", "I cannot find minecraft! (Bedrock)");
				home.alreadyAttemptedInject = false;
			}
			else
			{
				home.alreadyAttemptedInject = true;
				this.Toast("DLL", "Injection failed");
			}
		}

		public static bool InternetCheck()
		{
			int num;
			bool flag = home.InternetGetConnectedState(out num, 0);
			bool flag1 = home.OnlineCheck();
			return ((!flag ? true : !flag1) ? false : true);
		}

		[DllImport("wininet.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern bool InternetGetConnectedState(out int Description, int ReservedValue);

		private void launchMc_Click(object sender, EventArgs e)
		{
			Process.Start("minecraft://");
			Process[] processesByName = Process.GetProcessesByName("Minecraft.Windows");
			if (Ventile.Default.AutoInject)
			{
				if (processesByName.Length != 0)
				{
					if ((!Ventile.Default.CustomDLL ? true : !this.selectedDLL))
					{
						this.Toast("DLL", "Not injecting, no file specifed");
					}
					else
					{
						this.InjectDLL(Ventile.Default.DefaultDLL);
					}
				}
			}
		}

		private void minus_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		public static bool OnlineCheck()
		{
			bool statusCode;
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://github.com/");
			httpWebRequest.Timeout = 15000;
			httpWebRequest.Method = "HEAD";
			try
			{
				using (HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse())
				{
					statusCode = response.StatusCode == HttpStatusCode.OK;
				}
			}
			catch (WebException webException)
			{
				statusCode = false;
			}
			return statusCode;
		}

		private void openChildForm(Form childForm)
		{
			if (this.activeForm != null)
			{
				this.activeForm.Close();
			}
			this.activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			this.panelChildForm.Controls.Add(childForm);
			this.panelChildForm.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			Color.FromArgb(Colors.Default.backColor, Colors.Default.backColor, Colors.Default.backColor);
			Color color = Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2);
			this.activeForm.Close();
			this.iconButton1.BackColor = color;
			this.iconButton2.BackColor = Color.Transparent;
			this.iconButton3.BackColor = Color.Transparent;
			this.iconButton4.BackColor = Color.Transparent;
			this.selectedIndicator.Location = new Point(0, 159);
			this.reloadHome();
		}

		public void reloadHome()
		{
			Color color = Color.FromArgb(Colors.Default.backColor, Colors.Default.backColor, Colors.Default.backColor);
			Color color1 = Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3);
			Color color2 = Color.FromArgb(Colors.Default.foreColor, Colors.Default.foreColor, Colors.Default.foreColor);
			Color color3 = Color.FromArgb(Colors.Default.outlineColor, Colors.Default.outlineColor, Colors.Default.outlineColor);
			Color color4 = Color.FromArgb(Colors.Default.fadedColor, Colors.Default.fadedColor, Colors.Default.fadedColor);
			Color color5 = Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2);
			this.selectedIndicator.BackColor = color1;
			this.iconButton1.set_IconColor(color1);
			this.iconButton1.ForeColor = color2;
			this.iconButton1.BackColor = color;
			this.iconButton1.FlatAppearance.MouseOverBackColor = color5;
			this.iconButton2.set_IconColor(color1);
			this.iconButton2.ForeColor = color2;
			this.iconButton2.BackColor = color;
			this.iconButton2.FlatAppearance.MouseOverBackColor = color5;
			this.iconButton3.set_IconColor(color1);
			this.iconButton3.ForeColor = color2;
			this.iconButton3.BackColor = color;
			this.iconButton3.FlatAppearance.MouseOverBackColor = color5;
			this.iconButton4.set_IconColor(color1);
			this.iconButton4.ForeColor = color2;
			this.iconButton4.BackColor = color;
			this.iconButton4.FlatAppearance.MouseOverBackColor = color5;
			this.sidebar.BackColor = color;
			this.topPanel.BackColor = color;
			this.launchMc.set_FillColor(color);
			this.selectDll.set_FillColor(color);
			this.inject.set_FillColor(color);
			this.close.BackColor = color;
			this.minus.BackColor = color;
			this.title.ForeColor = color2;
			this.line.ForeColor = color2;
			this.version.ForeColor = color4;
			this.launchMc.ForeColor = color2;
			this.selectDll.ForeColor = color2;
			this.inject.ForeColor = color2;
			this.launchMc.set_BorderColor(color3);
			this.selectDll.set_BorderColor(color3);
			this.inject.set_BorderColor(color3);
			if (Colors.Default.theme == "Dark")
			{
				this.pictureBox3.BackgroundImage = Resources.transparent_logo_white;
				this.panelChildForm.BackgroundImage = Resources.background;
			}
			else if (Colors.Default.theme == "Light")
			{
				this.pictureBox3.BackgroundImage = Resources.transparent_logo_black;
				this.panelChildForm.BackgroundImage = Resources.background2;
			}
			if (Ventile.Default.customImage)
			{
				this.panelChildForm.BackgroundImage = null;
				this.panelChildForm.BackgroundImage = new Bitmap(Ventile.Default.customImageLoc);
			}
			if (!Ventile.Default.CustomDLL)
			{
				this.selectDll.Visible = false;
			}
			else if (Ventile.Default.CustomDLL)
			{
				this.selectDll.Visible = true;
				if (Ventile.Default.DefaultDLL != null)
				{
					this.selectedDLL = true;
				}
				this.selectDll.Location = new Point(235, 248);
			}
			if (Ventile.Default.AutoInject)
			{
				this.inject.Visible = false;
			}
			else if (!Ventile.Default.AutoInject)
			{
				this.inject.Visible = true;
				this.inject.Location = new Point(260, 248);
			}
			if ((!Ventile.Default.CustomDLL ? false : !Ventile.Default.AutoInject))
			{
				this.selectDll.Location = new Point(169, 248);
				this.inject.Location = new Point(357, 248);
			}
		}

		private void selectDll_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog()
			{
				RestoreDirectory = true
			};
			if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				if (!openFileDialog.SafeFileName.ToLower().EndsWith(".dll"))
				{
					this.Toast("DLL", "You didnt specify a DLL!");
				}
				else
				{
					this.dllPath = openFileDialog.FileName;
					Ventile.Default.DefaultDLL = this.dllPath;
					this.Toast("DLL", "Your DLL is selected!");
					this.selectedDLL = true;
					Ventile.Default.Save();
				}
			}
		}

		private void tick_Tick(object sender, EventArgs e)
		{
			if ((!(Ventile.Default.WindowSetting == "Min") || Process.GetProcessesByName("Minecraft.Windows").Length == 0 ? false : !this.attemptedReload))
			{
				base.WindowState = FormWindowState.Minimized;
				this.attemptedReload = true;
			}
			else if ((!(Ventile.Default.WindowSetting == "Min") || Process.GetProcessesByName("Minecraft.Windows").Length != 0 ? false : this.attemptedReload))
			{
				this.attemptedReload = false;
			}
			if ((!(Ventile.Default.WindowSetting == "Hide") || Process.GetProcessesByName("Minecraft.Windows").Length == 0 ? false : !this.hidden))
			{
				base.Hide();
				this.hidden = true;
			}
			else if ((!(Ventile.Default.WindowSetting == "Hide") || Process.GetProcessesByName("Minecraft.Windows").Length != 0 ? false : this.hidden))
			{
				base.Show();
				this.hidden = false;
			}
			if ((Ventile.Default.WindowSetting != "Close" ? false : Process.GetProcessesByName("Minecraft.Windows").Length != 0))
			{
				base.Close();
			}
			if ((Process.GetProcessesByName("Minecraft.Windows").Length == 0 ? false : !this.inGameTest))
			{
				this.inGameTest = true;
				this.drpc.InGame();
				this.Toast("Rich Prescence", "In the Game!");
			}
			else if ((Process.GetProcessesByName("Minecraft.Windows").Length != 0 ? false : this.inGameTest))
			{
				this.inGameTest = false;
				this.drpc.Home();
				this.Toast("Rich Prescence", "In the Launcher!");
			}
		}

		public void Toast(string title, string msg)
		{
			(new Toast()).showToast(title, msg);
		}

		private void topPanel_MouseDown(object sender, MouseEventArgs e)
		{
			this.mouseDown = true;
			int x = Control.MousePosition.X;
			Rectangle bounds = base.Bounds;
			this.mouseinX = x - bounds.X;
			int y = Control.MousePosition.Y;
			bounds = base.Bounds;
			this.mouseinY = y - bounds.Y;
		}

		private void topPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.mouseDown)
			{
				Point mousePosition = Control.MousePosition;
				this.mouseX = mousePosition.X - this.mouseinX;
				mousePosition = Control.MousePosition;
				this.mouseY = mousePosition.Y - this.mouseinY;
				base.SetDesktopLocation(this.mouseX, this.mouseY);
			}
		}

		private void topPanel_MouseUp(object sender, MouseEventArgs e)
		{
			this.mouseDown = false;
		}

		[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=true, SetLastError=true)]
		private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

		[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
		private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);
	}
}