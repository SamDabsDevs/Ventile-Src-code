using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventile_Client.Properties;

namespace Ventile_Client
{
	public class settings : Form
	{
		private RPC drpc = new RPC();

		private home ths;

		private string settingsPage = "Launcher";

		private bool onCooldown = false;

		private IContainer components = null;

		private Label label2;

		private Label label1;

		private Label label3;

		private Label label4;

		private Label label5;

		private Label label6;

		private MaskedTextBox maskedTextBox1;

		private Label label7;

		private Panel appearance;

		private Label accentBT;

		private TrackBar accentBlueSlider;

		private Label accentGT;

		private TrackBar accentGreenSlider;

		private Label accentRT;

		private Label labelForSlider2;

		private Label accentColorLabel;

		private TrackBar accentRedSlider;

		private Label outlineOT;

		private Label labelForSlider4;

		private Label outlineColorLabel;

		private TrackBar outlineBrightnessSlider;

		private Label buttonBuT;

		private Label labelForSlider3;

		private Label buttonColorLabel;

		private TrackBar buttonBrightnessSlider;

		private Label backgroundBT;

		private Label labelForSlider1;

		private Label backgroundColorLabel;

		private TrackBar backgroundBrightnessSlider;

		private Panel extras;

		private Label toastsTitle;

		private Guna2Button button1;

		private Guna2Button button2;

		private Guna2Button button3;

		private Guna2Button button4;

		private Guna2Button autoInject;

		private Guna2Button RpcToggle;

		private Guna2Button button5;

		private Guna2Button customLoc;

		private Guna2Button resetResourceLoc;

		private Guna2Button LauncherButton;

		private Guna2Button AppearanceButton;

		private Guna2Button ExtrasButton;

		private Guna2Button resetThemes;

		private Guna2Button AppearanceButton2;

		private Guna2Button toastsToggle;

		public Guna2Button theme;

		private Guna2Button roundedToggle;

		private Label roundedTitle;

		private Panel pictureBox1;

		private Guna2Button customImage;

		private Label customImageTitle;

		private Guna2Button buttonForRpc;

		private Label label10;

		private Label label9;

		private MaskedTextBox maskedTextBox3;

		private MaskedTextBox maskedTextBox2;

		public settings(home frm)
		{
			this.InitializeComponent();
			this.ths = frm;
		}

		private void accentBlueSlider_Scroll(object sender, EventArgs e)
		{
			Colors.Default.accentColor3 = this.accentBlueSlider.Value;
			this.ths.selectedIndicator.BackColor = Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3);
			this.updateColors();
		}

		private void accentGreenSlider_Scroll(object sender, EventArgs e)
		{
			Colors.Default.accentColor2 = this.accentGreenSlider.Value;
			this.ths.selectedIndicator.BackColor = Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3);
			this.updateColors();
		}

		private void accentRedSlider_Scroll(object sender, EventArgs e)
		{
			Colors.Default.accentColor1 = this.accentRedSlider.Value;
			this.ths.selectedIndicator.BackColor = Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3);
			this.updateColors();
		}

		private void AppearanceButton_Click(object sender, EventArgs e)
		{
			this.settingsPage = "Appearance";
			this.appearance.Visible = true;
			this.extras.Visible = false;
		}

		private void AppearanceButton2_Click(object sender, EventArgs e)
		{
			this.settingsPage = "Appearance";
			this.appearance.Visible = true;
			this.extras.Visible = false;
		}

		private void autoInject_Click(object sender, EventArgs e)
		{
			if (Ventile.Default.AutoInject)
			{
				Ventile.Default.AutoInject = false;
				this.autoInject.set_FillColor(Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2));
				this.autoInject.Text = "Off";
			}
			else if (!Ventile.Default.AutoInject)
			{
				Ventile.Default.AutoInject = true;
				this.autoInject.set_FillColor(Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3));
				this.autoInject.Text = "On";
			}
			Ventile.Default.Save();
		}

		private void backgroundBrightnessSlider_Scroll(object sender, EventArgs e)
		{
			Colors.Default.backColor = this.backgroundBrightnessSlider.Value;
			this.updateColors();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Ventile.Default.WindowSetting = "Hide";
			this.button1.set_FillColor(Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3));
			this.button2.set_FillColor(Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2));
			this.button3.set_FillColor(Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2));
			this.button4.set_FillColor(Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2));
			Ventile.Default.Save();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Ventile.Default.WindowSetting = "Min";
			this.button2.set_FillColor(Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3));
			this.button1.set_FillColor(Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2));
			this.button3.set_FillColor(Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2));
			this.button4.set_FillColor(Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2));
			Ventile.Default.Save();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Ventile.Default.WindowSetting = "Close";
			this.button3.set_FillColor(Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3));
			this.button2.set_FillColor(Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2));
			this.button1.set_FillColor(Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2));
			this.button4.set_FillColor(Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2));
			Ventile.Default.Save();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Ventile.Default.WindowSetting = "Open";
			this.button4.set_FillColor(Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3));
			this.button2.set_FillColor(Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2));
			this.button3.set_FillColor(Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2));
			this.button1.set_FillColor(Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2));
			Ventile.Default.Save();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (Ventile.Default.CustomDLL)
			{
				Ventile.Default.CustomDLL = false;
				this.button5.set_FillColor(Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2));
			}
			else if (!Ventile.Default.CustomDLL)
			{
				Ventile.Default.CustomDLL = true;
				this.button5.set_FillColor(Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3));
			}
			Ventile.Default.Save();
		}

		private void buttonBrightnessSlider_Scroll(object sender, EventArgs e)
		{
			Colors.Default.backColor2 = this.buttonBrightnessSlider.Value;
			this.updateColors();
		}

		private void buttonForRpc_Click(object sender, EventArgs e)
		{
			if (Ventile.Default.rpcButton)
			{
				this.label9.Visible = false;
				this.label10.Visible = false;
				this.maskedTextBox2.Visible = false;
				this.maskedTextBox3.Visible = false;
				this.buttonForRpc.set_FillColor(Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2));
				Ventile.Default.rpcButton = false;
			}
			else
			{
				this.label9.Visible = true;
				this.label10.Visible = true;
				this.maskedTextBox2.Visible = true;
				this.maskedTextBox3.Visible = true;
				this.buttonForRpc.set_FillColor(Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3));
				Ventile.Default.rpcButton = true;
				this.maskedTextBox3.Text = Ventile.Default.rpcButtonText;
				this.maskedTextBox2.Text = Ventile.Default.rpcButtonLink;
			}
		}

		private async void Cooldown(int sec)
		{
			await Task.Delay(sec * 1000);
			this.onCooldown = false;
			this.Toast("Rich Presence", "Cooldown finished");
		}

		private void customImage_Click(object sender, EventArgs e)
		{
			if (!Ventile.Default.customImage)
			{
				OpenFileDialog openFileDialog = new OpenFileDialog()
				{
					Title = "Custom Background Image",
					Filter = "Image Files (*.bmp;*.jpg;*.jpeg)|*.BMP;*.JPG;*.JPEG"
				};
				if (openFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK)
				{
					this.Toast("Error", "There was an error selecting image.");
				}
				else
				{
					Ventile.Default.customImage = true;
					Ventile.Default.customImageLoc = openFileDialog.FileName;
					this.customImage.set_FillColor(Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3));
					this.BackgroundImage = new Bitmap(Ventile.Default.customImageLoc);
				}
			}
			else
			{
				Ventile.Default.customImage = false;
				this.customImage.set_FillColor(Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2));
				if (Colors.Default.theme == "Dark")
				{
					this.BackgroundImage = Resources.background;
				}
				else if (Colors.Default.theme == "Light")
				{
					this.BackgroundImage = Resources.background2;
				}
			}
		}

		private void customLoc_Click(object sender, EventArgs e)
		{
			if (Ventile.Default.CustomLoc)
			{
				Ventile.Default.CustomLoc = false;
				this.customLoc.set_FillColor(Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2));
				this.resetResourceLoc.Visible = false;
			}
			else if (!Ventile.Default.CustomLoc)
			{
				Ventile.Default.CustomLoc = true;
				this.customLoc.set_FillColor(Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3));
				this.resetResourceLoc.Visible = true;
				FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog()
				{
					RootFolder = Environment.SpecialFolder.MyComputer,
					Description = "Select the folder where cosmetics will install to \n(Resource Packs folder for minecraft)",
					ShowNewFolderButton = false
				};
				if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					Ventile.Default.CustomLocStr = folderBrowserDialog.SelectedPath;
					this.Toast("Chosen Path", folderBrowserDialog.SelectedPath.ToString());
					Thread.Sleep(100);
				}
			}
			Ventile.Default.Save();
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void ExtrasButton_Click(object sender, EventArgs e)
		{
			this.settingsPage = "Extras";
			this.appearance.Visible = false;
			this.extras.Visible = true;
		}

		private void InitializeComponent()
		{
			this.label2 = new Label();
			this.label1 = new Label();
			this.label3 = new Label();
			this.label4 = new Label();
			this.label5 = new Label();
			this.label6 = new Label();
			this.maskedTextBox1 = new MaskedTextBox();
			this.label7 = new Label();
			this.appearance = new Panel();
			this.resetThemes = new Guna2Button();
			this.ExtrasButton = new Guna2Button();
			this.LauncherButton = new Guna2Button();
			this.theme = new Guna2Button();
			this.outlineOT = new Label();
			this.labelForSlider4 = new Label();
			this.outlineColorLabel = new Label();
			this.outlineBrightnessSlider = new TrackBar();
			this.buttonBuT = new Label();
			this.labelForSlider3 = new Label();
			this.buttonColorLabel = new Label();
			this.buttonBrightnessSlider = new TrackBar();
			this.backgroundBT = new Label();
			this.labelForSlider1 = new Label();
			this.backgroundColorLabel = new Label();
			this.backgroundBrightnessSlider = new TrackBar();
			this.accentBT = new Label();
			this.accentBlueSlider = new TrackBar();
			this.accentGT = new Label();
			this.accentGreenSlider = new TrackBar();
			this.accentRT = new Label();
			this.labelForSlider2 = new Label();
			this.accentColorLabel = new Label();
			this.accentRedSlider = new TrackBar();
			this.extras = new Panel();
			this.customImage = new Guna2Button();
			this.customImageTitle = new Label();
			this.roundedToggle = new Guna2Button();
			this.roundedTitle = new Label();
			this.toastsToggle = new Guna2Button();
			this.AppearanceButton2 = new Guna2Button();
			this.toastsTitle = new Label();
			this.button1 = new Guna2Button();
			this.button2 = new Guna2Button();
			this.button3 = new Guna2Button();
			this.button4 = new Guna2Button();
			this.autoInject = new Guna2Button();
			this.RpcToggle = new Guna2Button();
			this.button5 = new Guna2Button();
			this.customLoc = new Guna2Button();
			this.resetResourceLoc = new Guna2Button();
			this.AppearanceButton = new Guna2Button();
			this.pictureBox1 = new Panel();
			this.buttonForRpc = new Guna2Button();
			this.label10 = new Label();
			this.label9 = new Label();
			this.maskedTextBox3 = new MaskedTextBox();
			this.maskedTextBox2 = new MaskedTextBox();
			this.appearance.SuspendLayout();
			((ISupportInitialize)this.outlineBrightnessSlider).BeginInit();
			((ISupportInitialize)this.buttonBrightnessSlider).BeginInit();
			((ISupportInitialize)this.backgroundBrightnessSlider).BeginInit();
			((ISupportInitialize)this.accentBlueSlider).BeginInit();
			((ISupportInitialize)this.accentGreenSlider).BeginInit();
			((ISupportInitialize)this.accentRedSlider).BeginInit();
			this.extras.SuspendLayout();
			this.pictureBox1.SuspendLayout();
			base.SuspendLayout();
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.White;
			this.label2.Location = new Point(250, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(155, 47);
			this.label2.TabIndex = 11;
			this.label2.Text = "Settings";
			this.label2.TextAlign = ContentAlignment.MiddleCenter;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(37, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(137, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Window State";
			this.label1.TextAlign = ContentAlignment.MiddleCenter;
			this.label3.AutoSize = true;
			this.label3.BackColor = Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label3.ForeColor = Color.White;
			this.label3.Location = new Point(468, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(142, 25);
			this.label3.TabIndex = 16;
			this.label3.Text = "Developer DLL";
			this.label3.TextAlign = ContentAlignment.MiddleCenter;
			this.label4.AutoSize = true;
			this.label4.BackColor = Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label4.ForeColor = Color.White;
			this.label4.Location = new Point(468, 147);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(140, 50);
			this.label4.TabIndex = 18;
			this.label4.Text = "Resource Pack\r\nLocation\r\n";
			this.label4.TextAlign = ContentAlignment.MiddleCenter;
			this.label5.AutoSize = true;
			this.label5.BackColor = Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label5.ForeColor = Color.White;
			this.label5.Location = new Point(47, 245);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(110, 25);
			this.label5.TabIndex = 21;
			this.label5.Text = "Auto Inject";
			this.label5.TextAlign = ContentAlignment.MiddleCenter;
			this.label6.AutoSize = true;
			this.label6.BackColor = Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label6.ForeColor = Color.White;
			this.label6.Location = new Point(261, 31);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(133, 25);
			this.label6.TabIndex = 23;
			this.label6.Text = "Rich Presence";
			this.label6.TextAlign = ContentAlignment.MiddleCenter;
			this.maskedTextBox1.BorderStyle = BorderStyle.None;
			this.maskedTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.maskedTextBox1.HidePromptOnLeave = true;
			this.maskedTextBox1.Location = new Point(255, 201);
			this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(143, 18);
			this.maskedTextBox1.TabIndex = 25;
			this.maskedTextBox1.TabStop = false;
			this.maskedTextBox1.TextChanged += new EventHandler(this.maskedTextBox1_TextChanged);
			this.label7.AutoSize = true;
			this.label7.BackColor = Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label7.ForeColor = Color.White;
			this.label7.Location = new Point(296, 27);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(71, 25);
			this.label7.TabIndex = 27;
			this.label7.Text = "Theme";
			this.label7.TextAlign = ContentAlignment.MiddleCenter;
			this.appearance.BackColor = Color.FromArgb(20, 20, 20);
			this.appearance.Controls.Add(this.resetThemes);
			this.appearance.Controls.Add(this.ExtrasButton);
			this.appearance.Controls.Add(this.LauncherButton);
			this.appearance.Controls.Add(this.theme);
			this.appearance.Controls.Add(this.outlineOT);
			this.appearance.Controls.Add(this.labelForSlider4);
			this.appearance.Controls.Add(this.outlineColorLabel);
			this.appearance.Controls.Add(this.outlineBrightnessSlider);
			this.appearance.Controls.Add(this.buttonBuT);
			this.appearance.Controls.Add(this.labelForSlider3);
			this.appearance.Controls.Add(this.buttonColorLabel);
			this.appearance.Controls.Add(this.buttonBrightnessSlider);
			this.appearance.Controls.Add(this.backgroundBT);
			this.appearance.Controls.Add(this.labelForSlider1);
			this.appearance.Controls.Add(this.backgroundColorLabel);
			this.appearance.Controls.Add(this.backgroundBrightnessSlider);
			this.appearance.Controls.Add(this.accentBT);
			this.appearance.Controls.Add(this.accentBlueSlider);
			this.appearance.Controls.Add(this.accentGT);
			this.appearance.Controls.Add(this.accentGreenSlider);
			this.appearance.Controls.Add(this.accentRT);
			this.appearance.Controls.Add(this.labelForSlider2);
			this.appearance.Controls.Add(this.accentColorLabel);
			this.appearance.Controls.Add(this.accentRedSlider);
			this.appearance.Controls.Add(this.label7);
			this.appearance.ForeColor = SystemColors.ControlText;
			this.appearance.Location = new Point(-6, 90);
			this.appearance.Name = "appearance";
			this.appearance.Size = new System.Drawing.Size(650, 373);
			this.appearance.TabIndex = 29;
			this.appearance.Visible = false;
			this.resetThemes.set_Animated(true);
			this.resetThemes.set_AutoRoundedCorners(true);
			this.resetThemes.BackColor = Color.Transparent;
			this.resetThemes.set_BorderRadius(13);
			this.resetThemes.get_CheckedState().set_Parent(this.resetThemes);
			this.resetThemes.Cursor = Cursors.Hand;
			this.resetThemes.get_CustomImages().set_Parent(this.resetThemes);
			this.resetThemes.set_FillColor(Color.FromArgb(40, 40, 40));
			this.resetThemes.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.resetThemes.ForeColor = Color.White;
			this.resetThemes.get_HoverState().set_Parent(this.resetThemes);
			this.resetThemes.Location = new Point(264, 317);
			this.resetThemes.Name = "resetThemes";
			this.resetThemes.get_ShadowDecoration().set_Parent(this.resetThemes);
			this.resetThemes.Size = new System.Drawing.Size(141, 29);
			this.resetThemes.TabIndex = 75;
			this.resetThemes.TabStop = false;
			this.resetThemes.Text = "Reset";
			this.resetThemes.Click += new EventHandler(this.resetThemes_Click);
			this.ExtrasButton.set_Animated(true);
			this.ExtrasButton.set_AutoRoundedCorners(true);
			this.ExtrasButton.BackColor = Color.Transparent;
			this.ExtrasButton.set_BorderRadius(13);
			this.ExtrasButton.get_CheckedState().set_Parent(this.ExtrasButton);
			this.ExtrasButton.Cursor = Cursors.Hand;
			this.ExtrasButton.get_CustomImages().set_Parent(this.ExtrasButton);
			this.ExtrasButton.set_FillColor(Color.FromArgb(40, 40, 40));
			this.ExtrasButton.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.ExtrasButton.ForeColor = Color.White;
			this.ExtrasButton.get_HoverState().set_Parent(this.ExtrasButton);
			this.ExtrasButton.Location = new Point(551, 337);
			this.ExtrasButton.Name = "ExtrasButton";
			this.ExtrasButton.get_ShadowDecoration().set_Parent(this.ExtrasButton);
			this.ExtrasButton.Size = new System.Drawing.Size(90, 29);
			this.ExtrasButton.TabIndex = 74;
			this.ExtrasButton.TabStop = false;
			this.ExtrasButton.Text = "Extras";
			this.ExtrasButton.Click += new EventHandler(this.ExtrasButton_Click);
			this.LauncherButton.set_Animated(true);
			this.LauncherButton.set_AutoRoundedCorners(true);
			this.LauncherButton.BackColor = Color.Transparent;
			this.LauncherButton.set_BorderRadius(13);
			this.LauncherButton.get_CheckedState().set_Parent(this.LauncherButton);
			this.LauncherButton.Cursor = Cursors.Hand;
			this.LauncherButton.get_CustomImages().set_Parent(this.LauncherButton);
			this.LauncherButton.set_FillColor(Color.FromArgb(40, 40, 40));
			this.LauncherButton.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.LauncherButton.ForeColor = Color.White;
			this.LauncherButton.get_HoverState().set_Parent(this.LauncherButton);
			this.LauncherButton.Location = new Point(16, 336);
			this.LauncherButton.Name = "LauncherButton";
			this.LauncherButton.get_ShadowDecoration().set_Parent(this.LauncherButton);
			this.LauncherButton.Size = new System.Drawing.Size(85, 29);
			this.LauncherButton.TabIndex = 73;
			this.LauncherButton.TabStop = false;
			this.LauncherButton.Text = "Launcher";
			this.LauncherButton.Click += new EventHandler(this.LauncherButton_Click);
			this.theme.set_Animated(true);
			this.theme.set_AutoRoundedCorners(true);
			this.theme.BackColor = Color.Transparent;
			this.theme.set_BorderRadius(13);
			this.theme.get_CheckedState().set_Parent(this.theme);
			this.theme.Cursor = Cursors.Hand;
			this.theme.get_CustomImages().set_Parent(this.theme);
			this.theme.set_FillColor(Color.FromArgb(40, 40, 40));
			this.theme.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.theme.ForeColor = Color.White;
			this.theme.get_HoverState().set_Parent(this.theme);
			this.theme.Location = new Point(261, 64);
			this.theme.Name = "theme";
			this.theme.get_ShadowDecoration().set_Parent(this.theme);
			this.theme.Size = new System.Drawing.Size(141, 29);
			this.theme.TabIndex = 72;
			this.theme.TabStop = false;
			this.theme.Text = "Dark";
			this.theme.Click += new EventHandler(this.theme_Click);
			this.outlineOT.AutoSize = true;
			this.outlineOT.BackColor = Color.Transparent;
			this.outlineOT.Font = new System.Drawing.Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.outlineOT.ForeColor = Color.White;
			this.outlineOT.Location = new Point(381, 277);
			this.outlineOT.Name = "outlineOT";
			this.outlineOT.Size = new System.Drawing.Size(29, 17);
			this.outlineOT.TabIndex = 56;
			this.outlineOT.Text = "255";
			this.labelForSlider4.AutoSize = true;
			this.labelForSlider4.BackColor = Color.Transparent;
			this.labelForSlider4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.labelForSlider4.ForeColor = Color.White;
			this.labelForSlider4.Location = new Point(254, 274);
			this.labelForSlider4.Name = "labelForSlider4";
			this.labelForSlider4.Size = new System.Drawing.Size(18, 20);
			this.labelForSlider4.TabIndex = 55;
			this.labelForSlider4.Text = "B";
			this.outlineColorLabel.AutoSize = true;
			this.outlineColorLabel.BackColor = Color.FromArgb(20, 20, 20);
			this.outlineColorLabel.Font = new System.Drawing.Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.outlineColorLabel.ForeColor = Color.White;
			this.outlineColorLabel.Location = new Point(269, 240);
			this.outlineColorLabel.Name = "outlineColorLabel";
			this.outlineColorLabel.Size = new System.Drawing.Size(131, 25);
			this.outlineColorLabel.TabIndex = 54;
			this.outlineColorLabel.Text = "Outline Color";
			this.outlineColorLabel.TextAlign = ContentAlignment.MiddleCenter;
			this.outlineBrightnessSlider.Location = new Point(277, 276);
			this.outlineBrightnessSlider.Maximum = 255;
			this.outlineBrightnessSlider.Name = "outlineBrightnessSlider";
			this.outlineBrightnessSlider.Size = new System.Drawing.Size(104, 45);
			this.outlineBrightnessSlider.TabIndex = 6;
			this.outlineBrightnessSlider.TabStop = false;
			this.outlineBrightnessSlider.TickStyle = TickStyle.None;
			this.outlineBrightnessSlider.Scroll += new EventHandler(this.outlineBrightnessSlider_Scroll);
			this.buttonBuT.AutoSize = true;
			this.buttonBuT.BackColor = Color.Transparent;
			this.buttonBuT.Font = new System.Drawing.Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.buttonBuT.ForeColor = Color.White;
			this.buttonBuT.Location = new Point(568, 149);
			this.buttonBuT.Name = "buttonBuT";
			this.buttonBuT.Size = new System.Drawing.Size(29, 17);
			this.buttonBuT.TabIndex = 48;
			this.buttonBuT.Text = "255";
			this.labelForSlider3.AutoSize = true;
			this.labelForSlider3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.labelForSlider3.ForeColor = Color.White;
			this.labelForSlider3.Location = new Point(441, 146);
			this.labelForSlider3.Name = "labelForSlider3";
			this.labelForSlider3.Size = new System.Drawing.Size(18, 20);
			this.labelForSlider3.TabIndex = 47;
			this.labelForSlider3.Text = "B";
			this.buttonColorLabel.AutoSize = true;
			this.buttonColorLabel.BackColor = Color.Transparent;
			this.buttonColorLabel.Font = new System.Drawing.Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.buttonColorLabel.ForeColor = Color.White;
			this.buttonColorLabel.Location = new Point(459, 112);
			this.buttonColorLabel.Name = "buttonColorLabel";
			this.buttonColorLabel.Size = new System.Drawing.Size(128, 25);
			this.buttonColorLabel.TabIndex = 46;
			this.buttonColorLabel.Text = "Button Color";
			this.buttonColorLabel.TextAlign = ContentAlignment.MiddleCenter;
			this.buttonBrightnessSlider.Location = new Point(464, 148);
			this.buttonBrightnessSlider.Maximum = 255;
			this.buttonBrightnessSlider.Name = "buttonBrightnessSlider";
			this.buttonBrightnessSlider.Size = new System.Drawing.Size(104, 45);
			this.buttonBrightnessSlider.TabIndex = 5;
			this.buttonBrightnessSlider.TabStop = false;
			this.buttonBrightnessSlider.TickStyle = TickStyle.None;
			this.buttonBrightnessSlider.Scroll += new EventHandler(this.buttonBrightnessSlider_Scroll);
			this.backgroundBT.AutoSize = true;
			this.backgroundBT.BackColor = Color.Transparent;
			this.backgroundBT.Font = new System.Drawing.Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.backgroundBT.ForeColor = Color.White;
			this.backgroundBT.Location = new Point(182, 149);
			this.backgroundBT.Name = "backgroundBT";
			this.backgroundBT.Size = new System.Drawing.Size(29, 17);
			this.backgroundBT.TabIndex = 40;
			this.backgroundBT.Text = "255";
			this.labelForSlider1.AutoSize = true;
			this.labelForSlider1.BackColor = Color.Transparent;
			this.labelForSlider1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.labelForSlider1.ForeColor = Color.White;
			this.labelForSlider1.Location = new Point(55, 146);
			this.labelForSlider1.Name = "labelForSlider1";
			this.labelForSlider1.Size = new System.Drawing.Size(18, 20);
			this.labelForSlider1.TabIndex = 39;
			this.labelForSlider1.Text = "B";
			this.backgroundColorLabel.AutoSize = true;
			this.backgroundColorLabel.BackColor = Color.Transparent;
			this.backgroundColorLabel.Font = new System.Drawing.Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.backgroundColorLabel.ForeColor = Color.White;
			this.backgroundColorLabel.Location = new Point(54, 112);
			this.backgroundColorLabel.Name = "backgroundColorLabel";
			this.backgroundColorLabel.Size = new System.Drawing.Size(176, 25);
			this.backgroundColorLabel.TabIndex = 38;
			this.backgroundColorLabel.Text = "Background Color";
			this.backgroundColorLabel.TextAlign = ContentAlignment.MiddleCenter;
			this.backgroundBrightnessSlider.Location = new Point(78, 148);
			this.backgroundBrightnessSlider.Maximum = 255;
			this.backgroundBrightnessSlider.Name = "backgroundBrightnessSlider";
			this.backgroundBrightnessSlider.Size = new System.Drawing.Size(104, 45);
			this.backgroundBrightnessSlider.TabIndex = 1;
			this.backgroundBrightnessSlider.TabStop = false;
			this.backgroundBrightnessSlider.TickStyle = TickStyle.None;
			this.backgroundBrightnessSlider.Scroll += new EventHandler(this.backgroundBrightnessSlider_Scroll);
			this.accentBT.AutoSize = true;
			this.accentBT.BackColor = Color.Transparent;
			this.accentBT.Font = new System.Drawing.Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.accentBT.ForeColor = Color.White;
			this.accentBT.Location = new Point(386, 194);
			this.accentBT.Name = "accentBT";
			this.accentBT.Size = new System.Drawing.Size(29, 17);
			this.accentBT.TabIndex = 36;
			this.accentBT.Text = "255";
			this.accentBlueSlider.Location = new Point(282, 193);
			this.accentBlueSlider.Maximum = 255;
			this.accentBlueSlider.Name = "accentBlueSlider";
			this.accentBlueSlider.Size = new System.Drawing.Size(104, 45);
			this.accentBlueSlider.TabIndex = 4;
			this.accentBlueSlider.TabStop = false;
			this.accentBlueSlider.TickStyle = TickStyle.None;
			this.accentBlueSlider.Scroll += new EventHandler(this.accentBlueSlider_Scroll);
			this.accentGT.AutoSize = true;
			this.accentGT.BackColor = Color.Transparent;
			this.accentGT.Font = new System.Drawing.Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.accentGT.ForeColor = Color.White;
			this.accentGT.Location = new Point(386, 171);
			this.accentGT.Name = "accentGT";
			this.accentGT.Size = new System.Drawing.Size(29, 17);
			this.accentGT.TabIndex = 34;
			this.accentGT.Text = "255";
			this.accentGreenSlider.Location = new Point(282, 170);
			this.accentGreenSlider.Maximum = 255;
			this.accentGreenSlider.Name = "accentGreenSlider";
			this.accentGreenSlider.Size = new System.Drawing.Size(104, 45);
			this.accentGreenSlider.TabIndex = 3;
			this.accentGreenSlider.TabStop = false;
			this.accentGreenSlider.TickStyle = TickStyle.None;
			this.accentGreenSlider.Scroll += new EventHandler(this.accentGreenSlider_Scroll);
			this.accentRT.AutoSize = true;
			this.accentRT.BackColor = Color.Transparent;
			this.accentRT.Font = new System.Drawing.Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.accentRT.ForeColor = Color.White;
			this.accentRT.Location = new Point(386, 149);
			this.accentRT.Name = "accentRT";
			this.accentRT.Size = new System.Drawing.Size(29, 17);
			this.accentRT.TabIndex = 32;
			this.accentRT.Text = "255";
			this.labelForSlider2.AutoSize = true;
			this.labelForSlider2.BackColor = Color.Transparent;
			this.labelForSlider2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.labelForSlider2.ForeColor = Color.White;
			this.labelForSlider2.Location = new Point(259, 149);
			this.labelForSlider2.Name = "labelForSlider2";
			this.labelForSlider2.Size = new System.Drawing.Size(19, 60);
			this.labelForSlider2.TabIndex = 31;
			this.labelForSlider2.Text = "R\r\nG\r\nB";
			this.accentColorLabel.AutoSize = true;
			this.accentColorLabel.BackColor = Color.Transparent;
			this.accentColorLabel.Font = new System.Drawing.Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.accentColorLabel.ForeColor = Color.White;
			this.accentColorLabel.Location = new Point(274, 112);
			this.accentColorLabel.Name = "accentColorLabel";
			this.accentColorLabel.Size = new System.Drawing.Size(126, 25);
			this.accentColorLabel.TabIndex = 30;
			this.accentColorLabel.Text = "Accent Color";
			this.accentColorLabel.TextAlign = ContentAlignment.MiddleCenter;
			this.accentRedSlider.Location = new Point(282, 148);
			this.accentRedSlider.Maximum = 255;
			this.accentRedSlider.Name = "accentRedSlider";
			this.accentRedSlider.Size = new System.Drawing.Size(104, 45);
			this.accentRedSlider.TabIndex = 2;
			this.accentRedSlider.TabStop = false;
			this.accentRedSlider.TickStyle = TickStyle.None;
			this.accentRedSlider.Scroll += new EventHandler(this.accentRedSlider_Scroll);
			this.extras.BackColor = Color.FromArgb(20, 20, 20);
			this.extras.Controls.Add(this.customImage);
			this.extras.Controls.Add(this.customImageTitle);
			this.extras.Controls.Add(this.roundedToggle);
			this.extras.Controls.Add(this.roundedTitle);
			this.extras.Controls.Add(this.toastsToggle);
			this.extras.Controls.Add(this.AppearanceButton2);
			this.extras.Controls.Add(this.toastsTitle);
			this.extras.Location = new Point(-3, 90);
			this.extras.Name = "extras";
			this.extras.Size = new System.Drawing.Size(647, 373);
			this.extras.TabIndex = 62;
			this.extras.Visible = false;
			this.customImage.set_Animated(true);
			this.customImage.set_AutoRoundedCorners(true);
			this.customImage.BackColor = Color.Transparent;
			this.customImage.set_BorderRadius(13);
			this.customImage.get_CheckedState().set_Parent(this.customImage);
			this.customImage.Cursor = Cursors.Hand;
			this.customImage.get_CustomImages().set_Parent(this.customImage);
			this.customImage.set_FillColor(Color.FromArgb(40, 40, 40));
			this.customImage.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.customImage.ForeColor = Color.White;
			this.customImage.get_HoverState().set_Parent(this.customImage);
			this.customImage.Location = new Point(56, 64);
			this.customImage.Name = "customImage";
			this.customImage.get_ShadowDecoration().set_Parent(this.customImage);
			this.customImage.Size = new System.Drawing.Size(141, 29);
			this.customImage.TabIndex = 77;
			this.customImage.TabStop = false;
			this.customImage.Text = "Choose Image";
			this.customImage.Click += new EventHandler(this.customImage_Click);
			this.customImageTitle.AutoSize = true;
			this.customImageTitle.BackColor = Color.Transparent;
			this.customImageTitle.Font = new System.Drawing.Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.customImageTitle.ForeColor = Color.White;
			this.customImageTitle.Location = new Point(39, 27);
			this.customImageTitle.Name = "customImageTitle";
			this.customImageTitle.Size = new System.Drawing.Size(182, 25);
			this.customImageTitle.TabIndex = 76;
			this.customImageTitle.Text = "Background Image";
			this.customImageTitle.TextAlign = ContentAlignment.MiddleCenter;
			this.roundedToggle.set_Animated(true);
			this.roundedToggle.set_AutoRoundedCorners(true);
			this.roundedToggle.BackColor = Color.Transparent;
			this.roundedToggle.set_BorderRadius(13);
			this.roundedToggle.get_CheckedState().set_Parent(this.roundedToggle);
			this.roundedToggle.Cursor = Cursors.Hand;
			this.roundedToggle.get_CustomImages().set_Parent(this.roundedToggle);
			this.roundedToggle.set_FillColor(Color.FromArgb(40, 40, 40));
			this.roundedToggle.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.roundedToggle.ForeColor = Color.White;
			this.roundedToggle.get_HoverState().set_Parent(this.roundedToggle);
			this.roundedToggle.Location = new Point(452, 64);
			this.roundedToggle.Name = "roundedToggle";
			this.roundedToggle.get_ShadowDecoration().set_Parent(this.roundedToggle);
			this.roundedToggle.Size = new System.Drawing.Size(141, 29);
			this.roundedToggle.TabIndex = 75;
			this.roundedToggle.TabStop = false;
			this.roundedToggle.Text = "On";
			this.roundedToggle.Click += new EventHandler(this.roundedToggle_Click);
			this.roundedTitle.AutoSize = true;
			this.roundedTitle.BackColor = Color.Transparent;
			this.roundedTitle.Font = new System.Drawing.Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.roundedTitle.ForeColor = Color.White;
			this.roundedTitle.Location = new Point(437, 27);
			this.roundedTitle.Name = "roundedTitle";
			this.roundedTitle.Size = new System.Drawing.Size(169, 25);
			this.roundedTitle.TabIndex = 74;
			this.roundedTitle.Text = "Rounded Buttons";
			this.roundedTitle.TextAlign = ContentAlignment.MiddleCenter;
			this.toastsToggle.set_Animated(true);
			this.toastsToggle.set_AutoRoundedCorners(true);
			this.toastsToggle.BackColor = Color.Transparent;
			this.toastsToggle.set_BorderRadius(13);
			this.toastsToggle.get_CheckedState().set_Parent(this.toastsToggle);
			this.toastsToggle.Cursor = Cursors.Hand;
			this.toastsToggle.get_CustomImages().set_Parent(this.toastsToggle);
			this.toastsToggle.set_FillColor(Color.FromArgb(40, 40, 40));
			this.toastsToggle.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.toastsToggle.ForeColor = Color.White;
			this.toastsToggle.get_HoverState().set_Parent(this.toastsToggle);
			this.toastsToggle.Location = new Point(258, 64);
			this.toastsToggle.Name = "toastsToggle";
			this.toastsToggle.get_ShadowDecoration().set_Parent(this.toastsToggle);
			this.toastsToggle.Size = new System.Drawing.Size(141, 29);
			this.toastsToggle.TabIndex = 73;
			this.toastsToggle.TabStop = false;
			this.toastsToggle.Text = "On";
			this.toastsToggle.Click += new EventHandler(this.toastsToggle_Click);
			this.AppearanceButton2.set_Animated(true);
			this.AppearanceButton2.set_AutoRoundedCorners(true);
			this.AppearanceButton2.BackColor = Color.Transparent;
			this.AppearanceButton2.set_BorderRadius(13);
			this.AppearanceButton2.get_CheckedState().set_Parent(this.AppearanceButton2);
			this.AppearanceButton2.Cursor = Cursors.Hand;
			this.AppearanceButton2.get_CustomImages().set_Parent(this.AppearanceButton2);
			this.AppearanceButton2.set_FillColor(Color.FromArgb(40, 40, 40));
			this.AppearanceButton2.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.AppearanceButton2.ForeColor = Color.White;
			this.AppearanceButton2.get_HoverState().set_Parent(this.AppearanceButton2);
			this.AppearanceButton2.Location = new Point(13, 336);
			this.AppearanceButton2.Name = "AppearanceButton2";
			this.AppearanceButton2.get_ShadowDecoration().set_Parent(this.AppearanceButton2);
			this.AppearanceButton2.Size = new System.Drawing.Size(99, 29);
			this.AppearanceButton2.TabIndex = 72;
			this.AppearanceButton2.TabStop = false;
			this.AppearanceButton2.Text = "Appearance";
			this.AppearanceButton2.Click += new EventHandler(this.AppearanceButton2_Click);
			this.toastsTitle.AutoSize = true;
			this.toastsTitle.BackColor = Color.Transparent;
			this.toastsTitle.Font = new System.Drawing.Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.toastsTitle.ForeColor = Color.White;
			this.toastsTitle.Location = new Point(295, 27);
			this.toastsTitle.Name = "toastsTitle";
			this.toastsTitle.Size = new System.Drawing.Size(66, 25);
			this.toastsTitle.TabIndex = 60;
			this.toastsTitle.Text = "Toasts";
			this.toastsTitle.TextAlign = ContentAlignment.MiddleCenter;
			this.button1.set_Animated(true);
			this.button1.set_AutoRoundedCorners(true);
			this.button1.BackColor = Color.Transparent;
			this.button1.set_BorderRadius(13);
			this.button1.get_CheckedState().set_Parent(this.button1);
			this.button1.Cursor = Cursors.Hand;
			this.button1.get_CustomImages().set_Parent(this.button1);
			this.button1.set_FillColor(Color.FromArgb(40, 40, 40));
			this.button1.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.button1.ForeColor = Color.White;
			this.button1.get_HoverState().set_Parent(this.button1);
			this.button1.Location = new Point(34, 76);
			this.button1.Name = "button1";
			this.button1.get_ShadowDecoration().set_Parent(this.button1);
			this.button1.Size = new System.Drawing.Size(141, 29);
			this.button1.TabIndex = 63;
			this.button1.TabStop = false;
			this.button1.Text = "Hide Launcher";
			this.button1.Click += new EventHandler(this.button1_Click);
			this.button2.set_Animated(true);
			this.button2.set_AutoRoundedCorners(true);
			this.button2.BackColor = Color.Transparent;
			this.button2.set_BorderRadius(13);
			this.button2.get_CheckedState().set_Parent(this.button2);
			this.button2.Cursor = Cursors.Hand;
			this.button2.get_CustomImages().set_Parent(this.button2);
			this.button2.set_FillColor(Color.FromArgb(40, 40, 40));
			this.button2.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.button2.ForeColor = Color.White;
			this.button2.get_HoverState().set_Parent(this.button2);
			this.button2.Location = new Point(34, 111);
			this.button2.Name = "button2";
			this.button2.get_ShadowDecoration().set_Parent(this.button2);
			this.button2.Size = new System.Drawing.Size(141, 29);
			this.button2.TabIndex = 64;
			this.button2.TabStop = false;
			this.button2.Text = "Minimize Launcher";
			this.button2.Click += new EventHandler(this.button2_Click);
			this.button3.set_Animated(true);
			this.button3.set_AutoRoundedCorners(true);
			this.button3.BackColor = Color.Transparent;
			this.button3.set_BorderRadius(13);
			this.button3.get_CheckedState().set_Parent(this.button3);
			this.button3.Cursor = Cursors.Hand;
			this.button3.get_CustomImages().set_Parent(this.button3);
			this.button3.set_FillColor(Color.FromArgb(40, 40, 40));
			this.button3.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.button3.ForeColor = Color.White;
			this.button3.get_HoverState().set_Parent(this.button3);
			this.button3.Location = new Point(33, 145);
			this.button3.Name = "button3";
			this.button3.get_ShadowDecoration().set_Parent(this.button3);
			this.button3.Size = new System.Drawing.Size(141, 29);
			this.button3.TabIndex = 65;
			this.button3.TabStop = false;
			this.button3.Text = "Close Launcher";
			this.button3.Click += new EventHandler(this.button3_Click);
			this.button4.set_Animated(true);
			this.button4.set_AutoRoundedCorners(true);
			this.button4.BackColor = Color.Transparent;
			this.button4.set_BorderRadius(13);
			this.button4.get_CheckedState().set_Parent(this.button4);
			this.button4.Cursor = Cursors.Hand;
			this.button4.get_CustomImages().set_Parent(this.button4);
			this.button4.set_FillColor(Color.FromArgb(40, 40, 40));
			this.button4.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.button4.ForeColor = Color.White;
			this.button4.get_HoverState().set_Parent(this.button4);
			this.button4.Location = new Point(33, 180);
			this.button4.Name = "button4";
			this.button4.get_ShadowDecoration().set_Parent(this.button4);
			this.button4.Size = new System.Drawing.Size(141, 29);
			this.button4.TabIndex = 66;
			this.button4.TabStop = false;
			this.button4.Text = "Leave Open";
			this.button4.Click += new EventHandler(this.button4_Click);
			this.autoInject.set_Animated(true);
			this.autoInject.set_AutoRoundedCorners(true);
			this.autoInject.BackColor = Color.Transparent;
			this.autoInject.set_BorderRadius(13);
			this.autoInject.get_CheckedState().set_Parent(this.autoInject);
			this.autoInject.Cursor = Cursors.Hand;
			this.autoInject.get_CustomImages().set_Parent(this.autoInject);
			this.autoInject.set_FillColor(Color.FromArgb(40, 40, 40));
			this.autoInject.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.autoInject.ForeColor = Color.White;
			this.autoInject.get_HoverState().set_Parent(this.autoInject);
			this.autoInject.Location = new Point(34, 278);
			this.autoInject.Name = "autoInject";
			this.autoInject.get_ShadowDecoration().set_Parent(this.autoInject);
			this.autoInject.Size = new System.Drawing.Size(141, 29);
			this.autoInject.TabIndex = 67;
			this.autoInject.TabStop = false;
			this.autoInject.Text = "On";
			this.autoInject.Click += new EventHandler(this.autoInject_Click);
			this.RpcToggle.set_Animated(true);
			this.RpcToggle.set_AutoRoundedCorners(true);
			this.RpcToggle.BackColor = Color.Transparent;
			this.RpcToggle.set_BorderRadius(13);
			this.RpcToggle.get_CheckedState().set_Parent(this.RpcToggle);
			this.RpcToggle.Cursor = Cursors.Hand;
			this.RpcToggle.get_CustomImages().set_Parent(this.RpcToggle);
			this.RpcToggle.set_FillColor(Color.FromArgb(40, 40, 40));
			this.RpcToggle.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.RpcToggle.ForeColor = Color.White;
			this.RpcToggle.get_HoverState().set_Parent(this.RpcToggle);
			this.RpcToggle.Location = new Point(256, 76);
			this.RpcToggle.Name = "RpcToggle";
			this.RpcToggle.get_ShadowDecoration().set_Parent(this.RpcToggle);
			this.RpcToggle.Size = new System.Drawing.Size(141, 29);
			this.RpcToggle.TabIndex = 68;
			this.RpcToggle.TabStop = false;
			this.RpcToggle.Text = "On";
			this.RpcToggle.Click += new EventHandler(this.RpcToggle_Click);
			this.button5.set_Animated(true);
			this.button5.set_AutoRoundedCorners(true);
			this.button5.BackColor = Color.Transparent;
			this.button5.set_BorderRadius(13);
			this.button5.get_CheckedState().set_Parent(this.button5);
			this.button5.Cursor = Cursors.Hand;
			this.button5.get_CustomImages().set_Parent(this.button5);
			this.button5.set_FillColor(Color.FromArgb(40, 40, 40));
			this.button5.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.button5.ForeColor = Color.White;
			this.button5.get_HoverState().set_Parent(this.button5);
			this.button5.Location = new Point(467, 76);
			this.button5.Name = "button5";
			this.button5.get_ShadowDecoration().set_Parent(this.button5);
			this.button5.Size = new System.Drawing.Size(141, 29);
			this.button5.TabIndex = 69;
			this.button5.TabStop = false;
			this.button5.Text = "Custom DLL";
			this.button5.Click += new EventHandler(this.button5_Click);
			this.customLoc.set_Animated(true);
			this.customLoc.set_AutoRoundedCorners(true);
			this.customLoc.BackColor = Color.Transparent;
			this.customLoc.set_BorderRadius(13);
			this.customLoc.get_CheckedState().set_Parent(this.customLoc);
			this.customLoc.Cursor = Cursors.Hand;
			this.customLoc.get_CustomImages().set_Parent(this.customLoc);
			this.customLoc.set_FillColor(Color.FromArgb(40, 40, 40));
			this.customLoc.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.customLoc.ForeColor = Color.White;
			this.customLoc.get_HoverState().set_Parent(this.customLoc);
			this.customLoc.Location = new Point(467, 210);
			this.customLoc.Name = "customLoc";
			this.customLoc.get_ShadowDecoration().set_Parent(this.customLoc);
			this.customLoc.Size = new System.Drawing.Size(141, 29);
			this.customLoc.TabIndex = 70;
			this.customLoc.TabStop = false;
			this.customLoc.Text = "Choose Location";
			this.customLoc.Click += new EventHandler(this.customLoc_Click);
			this.resetResourceLoc.set_Animated(true);
			this.resetResourceLoc.set_AutoRoundedCorners(true);
			this.resetResourceLoc.BackColor = Color.Transparent;
			this.resetResourceLoc.set_BorderRadius(13);
			this.resetResourceLoc.get_CheckedState().set_Parent(this.resetResourceLoc);
			this.resetResourceLoc.Cursor = Cursors.Hand;
			this.resetResourceLoc.get_CustomImages().set_Parent(this.resetResourceLoc);
			this.resetResourceLoc.set_FillColor(Color.FromArgb(40, 40, 40));
			this.resetResourceLoc.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.resetResourceLoc.ForeColor = Color.White;
			this.resetResourceLoc.get_HoverState().set_Parent(this.resetResourceLoc);
			this.resetResourceLoc.Location = new Point(467, 245);
			this.resetResourceLoc.Name = "resetResourceLoc";
			this.resetResourceLoc.get_ShadowDecoration().set_Parent(this.resetResourceLoc);
			this.resetResourceLoc.Size = new System.Drawing.Size(141, 29);
			this.resetResourceLoc.TabIndex = 71;
			this.resetResourceLoc.TabStop = false;
			this.resetResourceLoc.Text = "Reset";
			this.resetResourceLoc.Click += new EventHandler(this.resetResourceLoc_Click);
			this.AppearanceButton.set_Animated(true);
			this.AppearanceButton.set_AutoRoundedCorners(true);
			this.AppearanceButton.BackColor = Color.Transparent;
			this.AppearanceButton.set_BorderRadius(13);
			this.AppearanceButton.get_CheckedState().set_Parent(this.AppearanceButton);
			this.AppearanceButton.Cursor = Cursors.Hand;
			this.AppearanceButton.get_CustomImages().set_Parent(this.AppearanceButton);
			this.AppearanceButton.set_FillColor(Color.FromArgb(40, 40, 40));
			this.AppearanceButton.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.AppearanceButton.ForeColor = Color.White;
			this.AppearanceButton.get_HoverState().set_Parent(this.AppearanceButton);
			this.AppearanceButton.Location = new Point(540, 336);
			this.AppearanceButton.Name = "AppearanceButton";
			this.AppearanceButton.get_ShadowDecoration().set_Parent(this.AppearanceButton);
			this.AppearanceButton.Size = new System.Drawing.Size(96, 29);
			this.AppearanceButton.TabIndex = 72;
			this.AppearanceButton.TabStop = false;
			this.AppearanceButton.Text = "Appearance";
			this.AppearanceButton.Click += new EventHandler(this.AppearanceButton_Click);
			this.pictureBox1.BackColor = Color.FromArgb(20, 20, 20);
			this.pictureBox1.Controls.Add(this.buttonForRpc);
			this.pictureBox1.Controls.Add(this.label10);
			this.pictureBox1.Controls.Add(this.label9);
			this.pictureBox1.Controls.Add(this.maskedTextBox3);
			this.pictureBox1.Controls.Add(this.maskedTextBox2);
			this.pictureBox1.Controls.Add(this.label1);
			this.pictureBox1.Controls.Add(this.button1);
			this.pictureBox1.Controls.Add(this.button2);
			this.pictureBox1.Controls.Add(this.label6);
			this.pictureBox1.Controls.Add(this.button3);
			this.pictureBox1.Controls.Add(this.label3);
			this.pictureBox1.Controls.Add(this.RpcToggle);
			this.pictureBox1.Controls.Add(this.label4);
			this.pictureBox1.Controls.Add(this.label5);
			this.pictureBox1.Controls.Add(this.button5);
			this.pictureBox1.Controls.Add(this.button4);
			this.pictureBox1.Controls.Add(this.autoInject);
			this.pictureBox1.Controls.Add(this.customLoc);
			this.pictureBox1.Controls.Add(this.resetResourceLoc);
			this.pictureBox1.Controls.Add(this.AppearanceButton);
			this.pictureBox1.Location = new Point(-1, 91);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(650, 375);
			this.pictureBox1.TabIndex = 73;
			this.buttonForRpc.set_Animated(true);
			this.buttonForRpc.set_AutoRoundedCorners(true);
			this.buttonForRpc.BackColor = Color.Transparent;
			this.buttonForRpc.set_BorderRadius(8);
			this.buttonForRpc.get_CheckedState().set_Parent(this.buttonForRpc);
			this.buttonForRpc.Cursor = Cursors.Hand;
			this.buttonForRpc.get_CustomImages().set_Parent(this.buttonForRpc);
			this.buttonForRpc.set_FillColor(Color.FromArgb(40, 40, 40));
			this.buttonForRpc.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.buttonForRpc.ForeColor = Color.White;
			this.buttonForRpc.get_HoverState().set_Parent(this.buttonForRpc);
			this.buttonForRpc.Location = new Point(279, 134);
			this.buttonForRpc.Name = "buttonForRpc";
			this.buttonForRpc.get_ShadowDecoration().set_Parent(this.buttonForRpc);
			this.buttonForRpc.Size = new System.Drawing.Size(98, 19);
			this.buttonForRpc.TabIndex = 78;
			this.buttonForRpc.TabStop = false;
			this.buttonForRpc.Text = "Button";
			this.buttonForRpc.Click += new EventHandler(this.buttonForRpc_Click);
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label10.ForeColor = Color.White;
			this.label10.Location = new Point(252, 183);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(37, 20);
			this.label10.TabIndex = 77;
			this.label10.Text = "Text";
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label9.ForeColor = Color.White;
			this.label9.Location = new Point(252, 159);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(37, 20);
			this.label9.TabIndex = 76;
			this.label9.Text = "Link";
			this.maskedTextBox3.BorderStyle = BorderStyle.None;
			this.maskedTextBox3.Font = new System.Drawing.Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.maskedTextBox3.HidePromptOnLeave = true;
			this.maskedTextBox3.Location = new Point(296, 183);
			this.maskedTextBox3.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.maskedTextBox3.Name = "maskedTextBox3";
			this.maskedTextBox3.Size = new System.Drawing.Size(103, 18);
			this.maskedTextBox3.TabIndex = 75;
			this.maskedTextBox3.TabStop = false;
			this.maskedTextBox3.TextChanged += new EventHandler(this.maskedTextBox3_TextChanged);
			this.maskedTextBox2.BorderStyle = BorderStyle.None;
			this.maskedTextBox2.Font = new System.Drawing.Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.maskedTextBox2.HidePromptOnLeave = true;
			this.maskedTextBox2.Location = new Point(296, 159);
			this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.maskedTextBox2.Name = "maskedTextBox2";
			this.maskedTextBox2.Size = new System.Drawing.Size(103, 18);
			this.maskedTextBox2.TabIndex = 74;
			this.maskedTextBox2.TabStop = false;
			this.maskedTextBox2.TextChanged += new EventHandler(this.maskedTextBox2_TextChanged);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = Resources.background;
			this.BackgroundImageLayout = ImageLayout.Stretch;
			base.ClientSize = new System.Drawing.Size(645, 464);
			base.Controls.Add(this.extras);
			base.Controls.Add(this.appearance);
			base.Controls.Add(this.maskedTextBox1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.pictureBox1);
			this.DoubleBuffered = true;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "settings";
			this.Text = "settings";
			base.Load += new EventHandler(this.settings_Load);
			this.appearance.ResumeLayout(false);
			this.appearance.PerformLayout();
			((ISupportInitialize)this.outlineBrightnessSlider).EndInit();
			((ISupportInitialize)this.buttonBrightnessSlider).EndInit();
			((ISupportInitialize)this.backgroundBrightnessSlider).EndInit();
			((ISupportInitialize)this.accentBlueSlider).EndInit();
			((ISupportInitialize)this.accentGreenSlider).EndInit();
			((ISupportInitialize)this.accentRedSlider).EndInit();
			this.extras.ResumeLayout(false);
			this.extras.PerformLayout();
			this.pictureBox1.ResumeLayout(false);
			this.pictureBox1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void LauncherButton_Click(object sender, EventArgs e)
		{
			this.settingsPage = "Launcher";
			this.appearance.Visible = false;
			this.extras.Visible = false;
		}

		private void maskedTextBox1_TextChanged(object sender, EventArgs e)
		{
			Ventile.Default.LineRPC = this.maskedTextBox1.Text;
		}

		private void maskedTextBox2_TextChanged(object sender, EventArgs e)
		{
			Ventile.Default.rpcButtonLink = this.maskedTextBox2.Text;
			this.maskedTextBox2.Text = Ventile.Default.rpcButtonLink;
		}

		private void maskedTextBox3_TextChanged(object sender, EventArgs e)
		{
			Ventile.Default.rpcButtonText = this.maskedTextBox3.Text;
			this.maskedTextBox3.Text = Ventile.Default.rpcButtonText;
		}

		private void outlineBrightnessSlider_Scroll(object sender, EventArgs e)
		{
			Colors.Default.outlineColor = this.outlineBrightnessSlider.Value;
			this.outlineOT.Text = Colors.Default.outlineColor.ToString();
			this.ths.launchMc.set_BorderColor(Color.FromArgb(Colors.Default.outlineColor, Colors.Default.outlineColor, Colors.Default.outlineColor));
			this.ths.selectDll.set_BorderColor(Color.FromArgb(Colors.Default.outlineColor, Colors.Default.outlineColor, Colors.Default.outlineColor));
			this.ths.inject.set_BorderColor(Color.FromArgb(Colors.Default.outlineColor, Colors.Default.outlineColor, Colors.Default.outlineColor));
		}

		private void resetResourceLoc_Click(object sender, EventArgs e)
		{
			Ventile.Default.CustomLocStr = "C:\\Users\\%USERNAME%\\AppData\\Local\\Packages\\Microsoft.MinecraftUWP_8wekyb3d8bbwe\\LocalState\\games\\com.mojang\\resource_packs";
			this.Toast("Resources", "Resource pack location reset");
			Ventile.Default.CustomLoc = false;
			this.resetResourceLoc.Visible = false;
			this.customLoc.set_FillColor(Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2));
			Ventile.Default.Save();
		}

		private void resetThemes_Click(object sender, EventArgs e)
		{
			if (Colors.Default.theme == "Light")
			{
				this.BackgroundImage = Resources.background2;
				Colors.Default.backColor = 240;
				Colors.Default.backColor2 = 205;
				Colors.Default.accentColor1 = 15;
				Colors.Default.accentColor2 = 105;
				Colors.Default.accentColor3 = 255;
				Colors.Default.foreColor = 0;
				Colors.Default.outlineColor = 170;
				Colors.Default.fadedColor = 163;
				this.backgroundBrightnessSlider.Value = Colors.Default.backColor;
				this.buttonBrightnessSlider.Value = Colors.Default.backColor2;
				this.outlineBrightnessSlider.Value = Colors.Default.outlineColor;
				this.accentRedSlider.Value = Colors.Default.accentColor1;
				this.accentGreenSlider.Value = Colors.Default.accentColor2;
				this.accentBlueSlider.Value = Colors.Default.accentColor3;
			}
			else if (Colors.Default.theme == "Dark")
			{
				this.BackgroundImage = Resources.background;
				Colors.Default.backColor = 20;
				Colors.Default.backColor2 = 40;
				Colors.Default.accentColor1 = 65;
				Colors.Default.accentColor2 = 105;
				Colors.Default.accentColor3 = 255;
				Colors.Default.foreColor = 255;
				Colors.Default.outlineColor = 5;
				Colors.Default.fadedColor = 192;
				this.backgroundBrightnessSlider.Value = Colors.Default.backColor;
				this.buttonBrightnessSlider.Value = Colors.Default.backColor2;
				this.outlineBrightnessSlider.Value = Colors.Default.outlineColor;
				this.accentRedSlider.Value = Colors.Default.accentColor1;
				this.accentGreenSlider.Value = Colors.Default.accentColor2;
				this.accentBlueSlider.Value = Colors.Default.accentColor3;
			}
			this.ths.selectedIndicator.BackColor = Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3);
			this.updateColors();
		}

		private void roundedToggle_Click(object sender, EventArgs e)
		{
			if (!Ventile.Default.Rounded)
			{
				Ventile.Default.Rounded = true;
				this.roundedToggle.set_FillColor(Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3));
				this.roundedToggle.Text = "On";
			}
			else
			{
				Ventile.Default.Rounded = false;
				this.roundedToggle.set_FillColor(Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2));
				this.roundedToggle.Text = "Off";
			}
			this.settings_Reload();
		}

		private void RpcToggle_Click(object sender, EventArgs e)
		{
			if ((!Ventile.Default.RpcE ? false : !this.onCooldown))
			{
				this.onCooldown = true;
				this.Toast("Rich Presence", "Your on cooldown for 15s");
				this.Cooldown(15);
				this.drpc.Deinitialize();
				this.RpcToggle.set_FillColor(Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2));
				this.RpcToggle.Text = "Off";
				this.maskedTextBox1.Visible = false;
				this.buttonForRpc.Visible = false;
				this.label9.Visible = false;
				this.label10.Visible = false;
				this.maskedTextBox2.Visible = false;
				this.maskedTextBox3.Visible = false;
				Thread.Sleep(150);
				Ventile.Default.RpcE = false;
			}
			else if ((Ventile.Default.RpcE ? false : !this.onCooldown))
			{
				this.onCooldown = true;
				this.Toast("Rich Presence", "Your on cooldown for 15s");
				this.Cooldown(15);
				Ventile.Default.RpcE = true;
				this.drpc.Initialize();
				this.RpcToggle.set_FillColor(Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3));
				this.RpcToggle.Text = "On";
				this.maskedTextBox1.Visible = true;
				this.buttonForRpc.Visible = true;
				if (Ventile.Default.rpcButton)
				{
					this.label9.Visible = true;
					this.label10.Visible = true;
					this.maskedTextBox2.Visible = true;
					this.maskedTextBox3.Visible = true;
				}
				this.maskedTextBox1.Text = Ventile.Default.LineRPC;
			}
			Ventile.Default.Save();
		}

		private void settings_Load(object sender, EventArgs e)
		{
			this.settingsPage = "Launcher";
			this.appearance.Visible = false;
			this.extras.Visible = false;
			Label str = this.backgroundBT;
			int @default = Colors.Default.backColor;
			str.Text = @default.ToString();
			Label label = this.accentRT;
			@default = Colors.Default.accentColor1;
			label.Text = @default.ToString();
			Label str1 = this.accentGT;
			@default = Colors.Default.accentColor2;
			str1.Text = @default.ToString();
			Label label1 = this.accentBT;
			@default = Colors.Default.accentColor3;
			label1.Text = @default.ToString();
			Label str2 = this.buttonBuT;
			@default = Colors.Default.backColor2;
			str2.Text = @default.ToString();
			Label label2 = this.outlineOT;
			@default = Colors.Default.outlineColor;
			label2.Text = @default.ToString();
			this.accentRedSlider.Value = Colors.Default.accentColor1;
			this.accentGreenSlider.Value = Colors.Default.accentColor2;
			this.accentBlueSlider.Value = Colors.Default.accentColor3;
			this.backgroundBrightnessSlider.Value = Colors.Default.backColor;
			this.buttonBrightnessSlider.Value = Colors.Default.backColor2;
			this.outlineBrightnessSlider.Value = Colors.Default.outlineColor;
			this.theme.Text = Colors.Default.theme;
			Color color = Color.FromArgb(Colors.Default.backColor, Colors.Default.backColor, Colors.Default.backColor);
			Color color1 = Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3);
			Color color2 = Color.FromArgb(Colors.Default.foreColor, Colors.Default.foreColor, Colors.Default.foreColor);
			Color.FromArgb(Colors.Default.outlineColor, Colors.Default.outlineColor, Colors.Default.outlineColor);
			Color.FromArgb(Colors.Default.fadedColor, Colors.Default.fadedColor, Colors.Default.fadedColor);
			Color color3 = Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2);
			if (!Ventile.Default.rpcButton)
			{
				this.label9.Visible = false;
				this.label10.Visible = false;
				this.maskedTextBox2.Visible = false;
				this.maskedTextBox3.Visible = false;
				this.buttonForRpc.set_FillColor(color3);
			}
			else
			{
				this.label9.Visible = true;
				this.label10.Visible = true;
				this.maskedTextBox2.Visible = true;
				this.maskedTextBox3.Visible = true;
				this.buttonForRpc.set_FillColor(color1);
				this.maskedTextBox3.Text = Ventile.Default.rpcButtonText;
				this.maskedTextBox2.Text = Ventile.Default.rpcButtonLink;
			}
			this.RpcToggle.BackColor = color;
			if (!Ventile.Default.RpcE)
			{
				this.buttonForRpc.Visible = false;
				this.RpcToggle.set_FillColor(color3);
				this.RpcToggle.Text = "Off";
				this.maskedTextBox1.Visible = false;
				this.label9.Visible = false;
				this.label10.Visible = false;
				this.maskedTextBox2.Visible = false;
				this.maskedTextBox3.Visible = false;
				this.maskedTextBox3.Text = Ventile.Default.rpcButtonText;
				this.maskedTextBox2.Text = Ventile.Default.rpcButtonLink;
			}
			else
			{
				this.drpc.Settings();
				this.buttonForRpc.Visible = true;
				this.RpcToggle.set_FillColor(color1);
				this.RpcToggle.Text = "On";
				this.maskedTextBox1.Visible = true;
				this.maskedTextBox1.Text = Ventile.Default.LineRPC;
				this.maskedTextBox3.Text = Ventile.Default.rpcButtonText;
				this.maskedTextBox2.Text = Ventile.Default.rpcButtonLink;
			}
			this.label1.ForeColor = color2;
			this.label6.ForeColor = color2;
			this.label3.ForeColor = color2;
			this.label5.ForeColor = color2;
			this.label7.ForeColor = color2;
			this.label4.ForeColor = color2;
			this.backgroundColorLabel.ForeColor = color2;
			this.accentColorLabel.ForeColor = color2;
			this.buttonColorLabel.ForeColor = color2;
			this.outlineColorLabel.ForeColor = color2;
			this.labelForSlider1.ForeColor = color2;
			this.labelForSlider2.ForeColor = color2;
			this.labelForSlider3.ForeColor = color2;
			this.labelForSlider4.ForeColor = color2;
			this.backgroundBT.ForeColor = color2;
			this.accentRT.ForeColor = color2;
			this.accentGT.ForeColor = color2;
			this.accentBT.ForeColor = color2;
			this.buttonBuT.ForeColor = color2;
			this.outlineOT.ForeColor = color2;
			this.toastsTitle.ForeColor = color2;
			this.customImageTitle.ForeColor = color2;
			this.label9.ForeColor = color2;
			this.label10.ForeColor = color2;
			this.label1.BackColor = color;
			this.label6.BackColor = color;
			this.label3.BackColor = color;
			this.label5.BackColor = color;
			this.label7.BackColor = color;
			this.label4.BackColor = color;
			this.customImageTitle.BackColor = color;
			this.pictureBox1.BackColor = color;
			this.appearance.BackColor = color;
			this.extras.BackColor = color;
			this.backgroundColorLabel.BackColor = color;
			this.accentColorLabel.BackColor = color;
			this.buttonColorLabel.BackColor = color;
			this.outlineColorLabel.BackColor = color;
			this.labelForSlider1.BackColor = color;
			this.labelForSlider2.BackColor = color;
			this.labelForSlider3.BackColor = color;
			this.labelForSlider4.BackColor = color;
			this.backgroundBT.BackColor = color;
			this.accentRT.BackColor = color;
			this.accentGT.BackColor = color;
			this.accentBT.BackColor = color;
			this.buttonBuT.BackColor = color;
			this.outlineOT.BackColor = color;
			this.button1.set_FillColor(color3);
			this.button2.set_FillColor(color3);
			this.button3.set_FillColor(color3);
			this.button4.set_FillColor(color3);
			this.button1.BackColor = color;
			this.button2.BackColor = color;
			this.button3.BackColor = color;
			this.button4.BackColor = color;
			this.button1.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.button1.set_AutoRoundedCorners(true);
			}
			this.button2.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.button2.set_AutoRoundedCorners(true);
			}
			this.button3.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.button3.set_AutoRoundedCorners(true);
			}
			this.button4.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.button4.set_AutoRoundedCorners(true);
			}
			this.buttonForRpc.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.buttonForRpc.set_AutoRoundedCorners(true);
			}
			this.customImage.set_FillColor(color3);
			if (Ventile.Default.customImage)
			{
				this.customImage.set_FillColor(color1);
				this.BackgroundImage = new Bitmap(Ventile.Default.customImageLoc);
			}
			this.RpcToggle.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.RpcToggle.set_AutoRoundedCorners(true);
			}
			this.theme.set_FillColor(color3);
			this.theme.BackColor = color;
			this.theme.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.theme.set_AutoRoundedCorners(true);
			}
			this.AppearanceButton.set_FillColor(color3);
			this.AppearanceButton.BackColor = color;
			this.AppearanceButton.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.AppearanceButton.set_AutoRoundedCorners(true);
			}
			this.LauncherButton.set_FillColor(color3);
			this.LauncherButton.BackColor = color;
			this.LauncherButton.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.LauncherButton.set_AutoRoundedCorners(true);
			}
			this.ExtrasButton.set_FillColor(color3);
			this.ExtrasButton.BackColor = color;
			this.ExtrasButton.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.ExtrasButton.set_AutoRoundedCorners(true);
			}
			this.AppearanceButton2.set_FillColor(color3);
			this.AppearanceButton2.BackColor = color;
			this.AppearanceButton2.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.AppearanceButton2.set_AutoRoundedCorners(true);
			}
			this.resetThemes.set_FillColor(color3);
			this.resetThemes.BackColor = color;
			this.resetThemes.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.resetThemes.set_AutoRoundedCorners(true);
			}
			this.button5.set_FillColor(color3);
			this.button5.BackColor = color;
			this.button5.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.button5.set_AutoRoundedCorners(true);
			}
			this.resetResourceLoc.set_FillColor(color3);
			this.resetResourceLoc.BackColor = color;
			this.resetResourceLoc.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.resetResourceLoc.set_AutoRoundedCorners(true);
			}
			this.customLoc.set_FillColor(color3);
			this.customLoc.BackColor = color;
			this.customLoc.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.customLoc.set_AutoRoundedCorners(true);
			}
			this.roundedToggle.set_FillColor(color3);
			this.roundedToggle.BackColor = color;
			this.roundedToggle.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.roundedToggle.set_AutoRoundedCorners(true);
			}
			this.toastsToggle.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.toastsToggle.set_AutoRoundedCorners(true);
			}
			this.toastsTitle.BackColor = color;
			this.roundedTitle.BackColor = color;
			if (Colors.Default.theme != "Light")
			{
				this.maskedTextBox1.BackColor = Color.White;
				this.maskedTextBox1.ForeColor = Color.Black;
				this.maskedTextBox2.BackColor = Color.White;
				this.maskedTextBox2.ForeColor = Color.Black;
				this.maskedTextBox3.BackColor = Color.White;
				this.maskedTextBox3.ForeColor = Color.Black;
			}
			else
			{
				this.maskedTextBox1.BackColor = Color.DarkGray;
				this.maskedTextBox1.ForeColor = Color.White;
				this.maskedTextBox2.BackColor = Color.DarkGray;
				this.maskedTextBox2.ForeColor = Color.White;
				this.maskedTextBox3.BackColor = Color.DarkGray;
				this.maskedTextBox3.ForeColor = Color.White;
			}
			this.button1.ForeColor = color2;
			this.button2.ForeColor = color2;
			this.button3.ForeColor = color2;
			this.button4.ForeColor = color2;
			this.RpcToggle.ForeColor = color2;
			this.theme.ForeColor = color2;
			this.AppearanceButton.ForeColor = color2;
			this.LauncherButton.ForeColor = color2;
			this.ExtrasButton.ForeColor = color2;
			this.AppearanceButton2.ForeColor = color2;
			this.resetThemes.ForeColor = color2;
			this.button5.ForeColor = color2;
			this.resetResourceLoc.ForeColor = color2;
			this.customLoc.ForeColor = color2;
			this.label9.ForeColor = color2;
			this.label10.ForeColor = color2;
			this.buttonForRpc.ForeColor = color2;
			this.button1.set_FillColor(color3);
			this.button2.set_FillColor(color3);
			this.button3.set_FillColor(color3);
			this.button4.set_FillColor(color3);
			this.appearance.Visible = false;
			if (Colors.Default.theme == "Dark")
			{
				this.BackgroundImage = Resources.background;
			}
			else if (Colors.Default.theme == "Light")
			{
				this.BackgroundImage = Resources.background2;
			}
			this.customImage.set_FillColor(color3);
			if (Ventile.Default.customImage)
			{
				this.customImage.set_FillColor(color1);
				this.BackgroundImage = new Bitmap(Ventile.Default.customImageLoc);
			}
			this.resetResourceLoc.Visible = false;
			if (Ventile.Default.WindowSetting == "Hide")
			{
				this.button1.BackColor = color;
				this.button1.set_FillColor(color1);
			}
			else if (Ventile.Default.WindowSetting == "Min")
			{
				this.button2.BackColor = color;
				this.button2.set_FillColor(color1);
			}
			else if (Ventile.Default.WindowSetting == "Close")
			{
				this.button3.BackColor = color;
				this.button3.set_FillColor(color1);
			}
			else if (Ventile.Default.WindowSetting == "Open")
			{
				this.button4.BackColor = color;
				this.button4.set_FillColor(color1);
			}
			this.button5.BackColor = color;
			this.button5.set_FillColor(color3);
			if (Ventile.Default.CustomDLL)
			{
				this.button5.BackColor = color;
				this.button5.set_FillColor(color1);
			}
			this.autoInject.set_FillColor(color3);
			this.autoInject.Text = "Off";
			if (Ventile.Default.AutoInject)
			{
				this.autoInject.BackColor = color;
				this.autoInject.set_FillColor(color1);
				this.autoInject.Text = "On";
			}
			this.customLoc.BackColor = color3;
			if (!Ventile.Default.CustomLoc)
			{
				this.customLoc.BackColor = color;
				this.customLoc.set_FillColor(color3);
				this.resetResourceLoc.Visible = false;
			}
			else
			{
				this.customLoc.BackColor = color;
				this.customLoc.set_FillColor(color1);
				this.resetResourceLoc.Visible = true;
			}
			if (!Ventile.Default.Toasts)
			{
				this.toastsToggle.BackColor = color3;
				this.toastsToggle.Text = "Off";
			}
			else
			{
				this.toastsToggle.BackColor = color;
				this.toastsToggle.set_FillColor(color1);
				this.toastsToggle.Text = "On";
			}
			if (this.settingsPage == "Launcher")
			{
				this.appearance.Visible = false;
				this.extras.Visible = false;
			}
			else if (this.settingsPage == "Appearance")
			{
				this.appearance.Visible = true;
				this.extras.Visible = false;
			}
			else if (this.settingsPage == "Extras")
			{
				this.appearance.Visible = false;
				this.extras.Visible = true;
			}
			this.roundedToggle.set_FillColor(color3);
			if (Ventile.Default.Rounded)
			{
				this.roundedToggle.set_FillColor(color1);
			}
		}

		private void settings_Reload()
		{
			Label str = this.backgroundBT;
			int @default = Colors.Default.backColor;
			str.Text = @default.ToString();
			Label label = this.accentRT;
			@default = Colors.Default.accentColor1;
			label.Text = @default.ToString();
			Label str1 = this.accentGT;
			@default = Colors.Default.accentColor2;
			str1.Text = @default.ToString();
			Label label1 = this.accentBT;
			@default = Colors.Default.accentColor3;
			label1.Text = @default.ToString();
			Label str2 = this.buttonBuT;
			@default = Colors.Default.backColor2;
			str2.Text = @default.ToString();
			Label label2 = this.outlineOT;
			@default = Colors.Default.outlineColor;
			label2.Text = @default.ToString();
			this.accentRedSlider.Value = Colors.Default.accentColor1;
			this.accentGreenSlider.Value = Colors.Default.accentColor2;
			this.accentBlueSlider.Value = Colors.Default.accentColor3;
			this.backgroundBrightnessSlider.Value = Colors.Default.backColor;
			this.buttonBrightnessSlider.Value = Colors.Default.backColor2;
			this.outlineBrightnessSlider.Value = Colors.Default.outlineColor;
			this.theme.Text = Colors.Default.theme;
			Color color = Color.FromArgb(Colors.Default.backColor, Colors.Default.backColor, Colors.Default.backColor);
			Color color1 = Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3);
			Color color2 = Color.FromArgb(Colors.Default.foreColor, Colors.Default.foreColor, Colors.Default.foreColor);
			Color.FromArgb(Colors.Default.outlineColor, Colors.Default.outlineColor, Colors.Default.outlineColor);
			Color.FromArgb(Colors.Default.fadedColor, Colors.Default.fadedColor, Colors.Default.fadedColor);
			Color color3 = Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2);
			if (!Ventile.Default.rpcButton)
			{
				this.label9.Visible = false;
				this.label10.Visible = false;
				this.maskedTextBox2.Visible = false;
				this.maskedTextBox3.Visible = false;
				this.buttonForRpc.set_FillColor(color3);
			}
			else
			{
				this.label9.Visible = true;
				this.label10.Visible = true;
				this.maskedTextBox2.Visible = true;
				this.maskedTextBox3.Visible = true;
				this.buttonForRpc.set_FillColor(color1);
				this.maskedTextBox3.Text = Ventile.Default.rpcButtonText;
				this.maskedTextBox2.Text = Ventile.Default.rpcButtonLink;
			}
			this.RpcToggle.BackColor = color;
			if (!Ventile.Default.RpcE)
			{
				this.buttonForRpc.Visible = false;
				this.RpcToggle.set_FillColor(color3);
				this.RpcToggle.Text = "Off";
				this.maskedTextBox1.Visible = false;
				this.label9.Visible = false;
				this.label10.Visible = false;
				this.maskedTextBox2.Visible = false;
				this.maskedTextBox3.Visible = false;
				this.maskedTextBox3.Text = Ventile.Default.rpcButtonText;
				this.maskedTextBox2.Text = Ventile.Default.rpcButtonLink;
			}
			else
			{
				this.buttonForRpc.Visible = true;
				this.RpcToggle.set_FillColor(color1);
				this.RpcToggle.Text = "On";
				this.maskedTextBox1.Visible = true;
				this.maskedTextBox1.Text = Ventile.Default.LineRPC;
				this.maskedTextBox3.Text = Ventile.Default.rpcButtonText;
				this.maskedTextBox2.Text = Ventile.Default.rpcButtonLink;
			}
			this.label1.ForeColor = color2;
			this.label6.ForeColor = color2;
			this.label3.ForeColor = color2;
			this.label5.ForeColor = color2;
			this.label7.ForeColor = color2;
			this.label4.ForeColor = color2;
			this.backgroundColorLabel.ForeColor = color2;
			this.accentColorLabel.ForeColor = color2;
			this.buttonColorLabel.ForeColor = color2;
			this.outlineColorLabel.ForeColor = color2;
			this.labelForSlider1.ForeColor = color2;
			this.labelForSlider2.ForeColor = color2;
			this.labelForSlider3.ForeColor = color2;
			this.labelForSlider4.ForeColor = color2;
			this.backgroundBT.ForeColor = color2;
			this.accentRT.ForeColor = color2;
			this.accentGT.ForeColor = color2;
			this.accentBT.ForeColor = color2;
			this.buttonBuT.ForeColor = color2;
			this.outlineOT.ForeColor = color2;
			this.toastsTitle.ForeColor = color2;
			this.customImageTitle.ForeColor = color2;
			this.label9.ForeColor = color2;
			this.label10.ForeColor = color2;
			this.roundedTitle.ForeColor = color2;
			this.roundedToggle.ForeColor = color2;
			this.toastsToggle.ForeColor = color2;
			this.customImage.ForeColor = color2;
			this.label1.BackColor = color;
			this.label6.BackColor = color;
			this.label3.BackColor = color;
			this.label5.BackColor = color;
			this.label7.BackColor = color;
			this.label4.BackColor = color;
			this.customImageTitle.BackColor = color;
			this.pictureBox1.BackColor = color;
			this.appearance.BackColor = color;
			this.extras.BackColor = color;
			this.backgroundColorLabel.BackColor = color;
			this.accentColorLabel.BackColor = color;
			this.buttonColorLabel.BackColor = color;
			this.outlineColorLabel.BackColor = color;
			this.labelForSlider1.BackColor = color;
			this.labelForSlider2.BackColor = color;
			this.labelForSlider3.BackColor = color;
			this.labelForSlider4.BackColor = color;
			this.backgroundBT.BackColor = color;
			this.accentRT.BackColor = color;
			this.accentGT.BackColor = color;
			this.accentBT.BackColor = color;
			this.buttonBuT.BackColor = color;
			this.outlineOT.BackColor = color;
			this.button1.set_FillColor(color3);
			this.button2.set_FillColor(color3);
			this.button3.set_FillColor(color3);
			this.button4.set_FillColor(color3);
			this.button1.BackColor = color;
			this.button2.BackColor = color;
			this.button3.BackColor = color;
			this.button4.BackColor = color;
			this.customImage.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.customImage.set_AutoRoundedCorners(true);
			}
			this.button1.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.button1.set_AutoRoundedCorners(true);
			}
			this.button2.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.button2.set_AutoRoundedCorners(true);
			}
			this.button3.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.button3.set_AutoRoundedCorners(true);
			}
			this.button4.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.button4.set_AutoRoundedCorners(true);
			}
			this.buttonForRpc.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.buttonForRpc.set_AutoRoundedCorners(true);
			}
			this.customImage.set_FillColor(color3);
			if (Ventile.Default.customImage)
			{
				this.customImage.set_FillColor(color1);
				this.BackgroundImage = new Bitmap(Ventile.Default.customImageLoc);
			}
			this.RpcToggle.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.RpcToggle.set_AutoRoundedCorners(true);
			}
			this.theme.set_FillColor(color3);
			this.theme.BackColor = color;
			this.theme.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.theme.set_AutoRoundedCorners(true);
			}
			this.AppearanceButton.set_FillColor(color3);
			this.AppearanceButton.BackColor = color;
			this.AppearanceButton.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.AppearanceButton.set_AutoRoundedCorners(true);
			}
			this.LauncherButton.set_FillColor(color3);
			this.LauncherButton.BackColor = color;
			this.LauncherButton.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.LauncherButton.set_AutoRoundedCorners(true);
			}
			this.ExtrasButton.set_FillColor(color3);
			this.ExtrasButton.BackColor = color;
			this.ExtrasButton.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.ExtrasButton.set_AutoRoundedCorners(true);
			}
			this.AppearanceButton2.set_FillColor(color3);
			this.AppearanceButton2.BackColor = color;
			this.AppearanceButton2.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.AppearanceButton2.set_AutoRoundedCorners(true);
			}
			this.resetThemes.set_FillColor(color3);
			this.resetThemes.BackColor = color;
			this.resetThemes.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.resetThemes.set_AutoRoundedCorners(true);
			}
			this.button5.set_FillColor(color3);
			this.button5.BackColor = color;
			this.button5.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.button5.set_AutoRoundedCorners(true);
			}
			this.resetResourceLoc.set_FillColor(color3);
			this.resetResourceLoc.BackColor = color;
			this.resetResourceLoc.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.resetResourceLoc.set_AutoRoundedCorners(true);
			}
			this.customLoc.set_FillColor(color3);
			this.customLoc.BackColor = color;
			this.customLoc.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.customLoc.set_AutoRoundedCorners(true);
			}
			this.roundedToggle.set_FillColor(color3);
			this.roundedToggle.BackColor = color;
			this.roundedToggle.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.roundedToggle.set_AutoRoundedCorners(true);
			}
			this.toastsToggle.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.toastsToggle.set_AutoRoundedCorners(true);
			}
			this.toastsTitle.BackColor = color;
			this.roundedTitle.BackColor = color;
			if (Colors.Default.theme != "Light")
			{
				this.maskedTextBox1.BackColor = Color.White;
				this.maskedTextBox1.ForeColor = Color.Black;
				this.maskedTextBox2.BackColor = Color.White;
				this.maskedTextBox2.ForeColor = Color.Black;
				this.maskedTextBox3.BackColor = Color.White;
				this.maskedTextBox3.ForeColor = Color.Black;
			}
			else
			{
				this.maskedTextBox1.BackColor = Color.DarkGray;
				this.maskedTextBox1.ForeColor = Color.White;
				this.maskedTextBox2.BackColor = Color.DarkGray;
				this.maskedTextBox2.ForeColor = Color.White;
				this.maskedTextBox3.BackColor = Color.DarkGray;
				this.maskedTextBox3.ForeColor = Color.White;
			}
			this.button1.ForeColor = color2;
			this.button2.ForeColor = color2;
			this.button3.ForeColor = color2;
			this.button4.ForeColor = color2;
			this.RpcToggle.ForeColor = color2;
			this.theme.ForeColor = color2;
			this.AppearanceButton.ForeColor = color2;
			this.LauncherButton.ForeColor = color2;
			this.ExtrasButton.ForeColor = color2;
			this.AppearanceButton2.ForeColor = color2;
			this.resetThemes.ForeColor = color2;
			this.button5.ForeColor = color2;
			this.resetResourceLoc.ForeColor = color2;
			this.customLoc.ForeColor = color2;
			this.label9.ForeColor = color2;
			this.label10.ForeColor = color2;
			this.buttonForRpc.ForeColor = color2;
			this.button1.set_FillColor(color3);
			this.button2.set_FillColor(color3);
			this.button3.set_FillColor(color3);
			this.button4.set_FillColor(color3);
			this.appearance.Visible = false;
			if (Colors.Default.theme == "Dark")
			{
				this.BackgroundImage = Resources.background;
			}
			else if (Colors.Default.theme == "Light")
			{
				this.BackgroundImage = Resources.background2;
			}
			this.customImage.set_FillColor(color3);
			if (Ventile.Default.customImage)
			{
				this.customImage.set_FillColor(color1);
				this.BackgroundImage = new Bitmap(Ventile.Default.customImageLoc);
			}
			this.resetResourceLoc.Visible = false;
			if (Ventile.Default.WindowSetting == "Hide")
			{
				this.button1.BackColor = color;
				this.button1.set_FillColor(color1);
			}
			else if (Ventile.Default.WindowSetting == "Min")
			{
				this.button2.BackColor = color;
				this.button2.set_FillColor(color1);
			}
			else if (Ventile.Default.WindowSetting == "Close")
			{
				this.button3.BackColor = color;
				this.button3.set_FillColor(color1);
			}
			else if (Ventile.Default.WindowSetting == "Open")
			{
				this.button4.BackColor = color;
				this.button4.set_FillColor(color1);
			}
			this.button5.BackColor = color;
			this.button5.set_FillColor(color3);
			if (Ventile.Default.CustomDLL)
			{
				this.button5.BackColor = color;
				this.button5.set_FillColor(color1);
			}
			this.autoInject.set_FillColor(color3);
			this.autoInject.Text = "Off";
			if (Ventile.Default.AutoInject)
			{
				this.autoInject.BackColor = color;
				this.autoInject.set_FillColor(color1);
				this.autoInject.Text = "On";
			}
			this.customLoc.BackColor = color3;
			if (!Ventile.Default.CustomLoc)
			{
				this.customLoc.BackColor = color;
				this.customLoc.set_FillColor(color3);
				this.resetResourceLoc.Visible = false;
			}
			else
			{
				this.customLoc.BackColor = color;
				this.customLoc.set_FillColor(color1);
				this.resetResourceLoc.Visible = true;
			}
			if (!Ventile.Default.Toasts)
			{
				this.toastsToggle.BackColor = color3;
				this.toastsToggle.Text = "Off";
			}
			else
			{
				this.toastsToggle.BackColor = color;
				this.toastsToggle.set_FillColor(color1);
				this.toastsToggle.Text = "On";
			}
			if (this.settingsPage == "Launcher")
			{
				this.appearance.Visible = false;
				this.extras.Visible = false;
			}
			else if (this.settingsPage == "Appearance")
			{
				this.appearance.Visible = true;
				this.extras.Visible = false;
			}
			else if (this.settingsPage == "Extras")
			{
				this.appearance.Visible = false;
				this.extras.Visible = true;
			}
			this.roundedToggle.set_FillColor(color3);
			if (Ventile.Default.Rounded)
			{
				this.roundedToggle.set_FillColor(color1);
			}
		}

		private void theme_Click(object sender, EventArgs e)
		{
			if (Colors.Default.theme == "Dark")
			{
				Colors.Default.theme = "Light";
				this.BackgroundImage = Resources.background2;
				Colors.Default.backColor = 240;
				Colors.Default.backColor2 = 205;
				Colors.Default.foreColor = 0;
				Colors.Default.outlineColor = 170;
				Colors.Default.fadedColor = 163;
				this.backgroundBrightnessSlider.Value = Colors.Default.backColor;
				this.buttonBrightnessSlider.Value = Colors.Default.backColor2;
				this.outlineBrightnessSlider.Value = Colors.Default.outlineColor;
			}
			else if (Colors.Default.theme == "Light")
			{
				Colors.Default.theme = "Dark";
				this.BackgroundImage = Resources.background;
				Colors.Default.backColor = 20;
				Colors.Default.backColor2 = 40;
				Colors.Default.foreColor = 255;
				Colors.Default.outlineColor = 5;
				Colors.Default.fadedColor = 192;
				this.backgroundBrightnessSlider.Value = Colors.Default.backColor;
				this.buttonBrightnessSlider.Value = Colors.Default.backColor2;
				this.outlineBrightnessSlider.Value = Colors.Default.outlineColor;
			}
			this.settings_Reload();
			this.ths.reloadHome();
		}

		public void Toast(string title, string msg)
		{
			(new Toast()).showToast(title, msg);
		}

		private void toastsToggle_Click(object sender, EventArgs e)
		{
			if (!Ventile.Default.Toasts)
			{
				Ventile.Default.Toasts = true;
				this.toastsToggle.set_FillColor(Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3));
				this.toastsToggle.Text = "On";
			}
			else
			{
				Ventile.Default.Toasts = false;
				this.toastsToggle.set_FillColor(Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2));
				this.toastsToggle.Text = "Off";
			}
		}

		private void updateColors()
		{
			this.ths.sidebar.BackColor = Color.FromArgb(Colors.Default.backColor, Colors.Default.backColor, Colors.Default.backColor);
			this.ths.topPanel.BackColor = Color.FromArgb(Colors.Default.backColor, Colors.Default.backColor, Colors.Default.backColor);
			this.pictureBox1.BackColor = Color.FromArgb(Colors.Default.backColor, Colors.Default.backColor, Colors.Default.backColor);
			this.appearance.BackColor = Color.FromArgb(Colors.Default.backColor, Colors.Default.backColor, Colors.Default.backColor);
			this.extras.BackColor = Color.FromArgb(Colors.Default.backColor, Colors.Default.backColor, Colors.Default.backColor);
			Color color = Color.FromArgb(Colors.Default.backColor, Colors.Default.backColor, Colors.Default.backColor);
			Color color1 = Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3);
			Color color2 = Color.FromArgb(Colors.Default.foreColor, Colors.Default.foreColor, Colors.Default.foreColor);
			Color color3 = Color.FromArgb(Colors.Default.outlineColor, Colors.Default.outlineColor, Colors.Default.outlineColor);
			Color.FromArgb(Colors.Default.fadedColor, Colors.Default.fadedColor, Colors.Default.fadedColor);
			Color color4 = Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2);
			this.ths.iconButton1.set_IconColor(color1);
			this.ths.iconButton1.ForeColor = color2;
			this.ths.iconButton1.FlatAppearance.MouseOverBackColor = color4;
			this.ths.iconButton2.set_IconColor(color1);
			this.ths.iconButton2.ForeColor = color2;
			this.ths.iconButton2.FlatAppearance.MouseOverBackColor = color4;
			this.ths.iconButton3.set_IconColor(color1);
			this.ths.iconButton3.ForeColor = color2;
			this.ths.iconButton3.FlatAppearance.MouseOverBackColor = color4;
			this.ths.iconButton4.set_IconColor(color1);
			this.ths.iconButton4.ForeColor = color2;
			this.ths.iconButton4.FlatAppearance.MouseOverBackColor = color4;
			this.label1.ForeColor = color2;
			this.label6.ForeColor = color2;
			this.label3.ForeColor = color2;
			this.label5.ForeColor = color2;
			this.label7.ForeColor = color2;
			this.label4.ForeColor = color2;
			this.backgroundColorLabel.ForeColor = color2;
			this.accentColorLabel.ForeColor = color2;
			this.buttonColorLabel.ForeColor = color2;
			this.outlineColorLabel.ForeColor = color2;
			this.labelForSlider1.ForeColor = color2;
			this.labelForSlider2.ForeColor = color2;
			this.labelForSlider3.ForeColor = color2;
			this.labelForSlider4.ForeColor = color2;
			this.backgroundBT.ForeColor = color2;
			this.accentRT.ForeColor = color2;
			this.accentGT.ForeColor = color2;
			this.accentBT.ForeColor = color2;
			this.buttonBuT.ForeColor = color2;
			this.outlineOT.ForeColor = color2;
			this.toastsTitle.ForeColor = color2;
			this.label1.BackColor = color;
			this.label6.BackColor = color;
			this.label3.BackColor = color;
			this.label5.BackColor = color;
			this.label7.BackColor = color;
			this.label4.BackColor = color;
			this.appearance.BackColor = color;
			this.extras.BackColor = color;
			this.backgroundColorLabel.BackColor = color;
			this.accentColorLabel.BackColor = color;
			this.buttonColorLabel.BackColor = color;
			this.outlineColorLabel.BackColor = color;
			this.labelForSlider1.BackColor = color;
			this.labelForSlider2.BackColor = color;
			this.labelForSlider3.BackColor = color;
			this.labelForSlider4.BackColor = color;
			this.backgroundBT.BackColor = color;
			this.accentRT.BackColor = color;
			this.accentGT.BackColor = color;
			this.accentBT.BackColor = color;
			this.buttonBuT.BackColor = color;
			this.outlineOT.BackColor = color;
			this.pictureBox1.BackColor = color;
			this.button1.set_FillColor(color4);
			this.button2.set_FillColor(color4);
			this.button3.set_FillColor(color4);
			this.button4.set_FillColor(color4);
			this.button1.BackColor = color;
			this.button2.BackColor = color;
			this.button3.BackColor = color;
			this.button4.BackColor = color;
			this.theme.set_FillColor(color4);
			this.theme.BackColor = color;
			this.AppearanceButton.set_FillColor(color4);
			this.AppearanceButton.BackColor = color;
			this.LauncherButton.set_FillColor(color4);
			this.LauncherButton.BackColor = color;
			this.ExtrasButton.set_FillColor(color4);
			this.ExtrasButton.BackColor = color;
			this.AppearanceButton2.set_FillColor(color4);
			this.AppearanceButton2.BackColor = color;
			this.resetThemes.set_FillColor(color4);
			this.resetThemes.BackColor = color;
			this.button5.set_FillColor(color4);
			this.button5.BackColor = color;
			this.resetResourceLoc.set_FillColor(color4);
			this.resetResourceLoc.BackColor = color;
			this.customLoc.set_FillColor(color4);
			this.customLoc.BackColor = color;
			this.roundedToggle.set_FillColor(color4);
			this.roundedToggle.BackColor = color;
			this.toastsTitle.BackColor = color;
			this.roundedTitle.BackColor = color;
			if (Colors.Default.theme != "Light")
			{
				this.maskedTextBox1.BackColor = Color.White;
				this.maskedTextBox1.ForeColor = Color.Black;
			}
			else
			{
				this.maskedTextBox1.BackColor = Color.DarkGray;
				this.maskedTextBox1.ForeColor = Color.White;
			}
			this.button1.ForeColor = color2;
			this.button2.ForeColor = color2;
			this.button3.ForeColor = color2;
			this.button4.ForeColor = color2;
			this.RpcToggle.ForeColor = color2;
			this.theme.ForeColor = color2;
			this.AppearanceButton.ForeColor = color2;
			this.LauncherButton.ForeColor = color2;
			this.ExtrasButton.ForeColor = color2;
			this.AppearanceButton2.ForeColor = color2;
			this.resetThemes.ForeColor = color2;
			this.button5.ForeColor = color2;
			this.resetResourceLoc.ForeColor = color2;
			this.customLoc.ForeColor = color2;
			this.roundedTitle.ForeColor = color2;
			this.button1.set_FillColor(color4);
			this.button2.set_FillColor(color4);
			this.button3.set_FillColor(color4);
			this.button4.set_FillColor(color4);
			if (Ventile.Default.WindowSetting == "Hide")
			{
				this.button1.BackColor = color;
				this.button1.set_FillColor(color1);
			}
			else if (Ventile.Default.WindowSetting == "Min")
			{
				this.button2.BackColor = color;
				this.button2.set_FillColor(color1);
			}
			else if (Ventile.Default.WindowSetting == "Close")
			{
				this.button3.BackColor = color;
				this.button3.set_FillColor(color1);
			}
			else if (Ventile.Default.WindowSetting == "Open")
			{
				this.button4.BackColor = color;
				this.button4.set_FillColor(color1);
			}
			this.button5.BackColor = color;
			this.button5.set_FillColor(color4);
			if (Ventile.Default.CustomDLL)
			{
				this.button5.BackColor = color;
				this.button5.set_FillColor(color1);
			}
			this.autoInject.set_FillColor(color4);
			if (Ventile.Default.AutoInject)
			{
				this.autoInject.BackColor = color;
				this.autoInject.set_FillColor(color1);
			}
			this.customLoc.BackColor = color4;
			if (!Ventile.Default.CustomLoc)
			{
				this.customLoc.BackColor = color;
				this.customLoc.set_FillColor(color4);
			}
			else
			{
				this.customLoc.BackColor = color;
				this.customLoc.set_FillColor(color1);
			}
			if (!Ventile.Default.Toasts)
			{
				this.toastsToggle.BackColor = color4;
			}
			else
			{
				this.toastsToggle.BackColor = color;
				this.toastsToggle.set_FillColor(color1);
			}
			this.roundedToggle.set_FillColor(color4);
			if (Ventile.Default.Rounded)
			{
				this.roundedToggle.set_FillColor(color1);
			}
			this.ths.launchMc.set_BorderColor(color3);
			this.ths.selectDll.set_BorderColor(color3);
			this.ths.inject.set_BorderColor(color3);
			this.ths.close.BackColor = color;
			this.ths.minus.BackColor = color;
			Label str = this.backgroundBT;
			int @default = Colors.Default.backColor;
			str.Text = @default.ToString();
			Label label = this.accentRT;
			@default = Colors.Default.accentColor1;
			label.Text = @default.ToString();
			Label str1 = this.accentGT;
			@default = Colors.Default.accentColor2;
			str1.Text = @default.ToString();
			Label label1 = this.accentBT;
			@default = Colors.Default.accentColor3;
			label1.Text = @default.ToString();
			Label str2 = this.buttonBuT;
			@default = Colors.Default.backColor2;
			str2.Text = @default.ToString();
		}
	}
}