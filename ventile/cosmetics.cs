using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Ventile_Client.Properties;

namespace Ventile_Client
{
	public class cosmetics : Form
	{
		private IContainer components = null;

		private Button button1;

		private Label label1;

		private PictureBox pictureBox1;

		private Label label2;

		private Label label3;

		private Label label4;

		private Label label5;

		private Label label6;

		private Guna2Button cBlack;

		private Guna2Button cWhite;

		private Guna2Button cPink;

		private Guna2Button cBlue;

		private Guna2Button cYellow;

		private Guna2Button cRick;

		private Guna2Button resetAllCosmetics;

		private Guna2Button mRick;

		private Guna2Button mYellow;

		private Guna2Button mBlue;

		private Guna2Button mPink;

		private Guna2Button mWhite;

		private Guna2Button mBlack;

		private Guna2Button aGlowing;

		private Guna2Button aSlide;

		private Guna2Button oWavy;

		private Guna2Button oKagune;

		public cosmetics()
		{
			this.InitializeComponent();
		}

		private void aGlowing_Click(object sender, EventArgs e)
		{
			this.resetExtras();
			if (!Ventile.Default.internet)
			{
				MessageBox.Show("You currrently do not have an internet connection!", "No Internet");
			}
			else
			{
				this.aGlowing.set_FillColor(Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3));
				Cosmetic.Default.aGlowing = true;
				this.download("https://github.com/DeathlyBower959/Ventile-Client-Downloads/releases/latest/download/aGlowing.zip", Ventile.Default.CustomLocStr, "GlowingVentileCape.zip");
			}
		}

		private void aSlide_Click(object sender, EventArgs e)
		{
			this.resetExtras();
			if (!Ventile.Default.internet)
			{
				MessageBox.Show("You currrently do not have an internet connection!", "No Internet");
			}
			else
			{
				this.aSlide.set_FillColor(Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3));
				Cosmetic.Default.aSlide = true;
				this.download("https://github.com/DeathlyBower959/Ventile-Client-Downloads/releases/latest/download/aSlide.zip", Ventile.Default.CustomLocStr, "SlidingVentileCape.zip");
			}
		}

		private void cBlack_Click(object sender, EventArgs e)
		{
			this.resetCapes();
			if (!Ventile.Default.internet)
			{
				MessageBox.Show("You currrently do not have an internet connection!", "No Internet");
			}
			else
			{
				this.cBlack.set_FillColor(Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3));
				Cosmetic.Default.cBlack = true;
				this.download("https://github.com/DeathlyBower959/Ventile-Client-Downloads/releases/latest/download/BlackVentileCape.zip", Ventile.Default.CustomLocStr, "BlackVentileCape.zip");
			}
		}

		private void cBlue_Click(object sender, EventArgs e)
		{
			this.resetCapes();
			if (!Ventile.Default.internet)
			{
				MessageBox.Show("You currrently do not have an internet connection!", "No Internet");
			}
			else
			{
				this.cBlue.set_FillColor(Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3));
				Cosmetic.Default.cBlue = true;
				this.download("https://github.com/DeathlyBower959/Ventile-Client-Downloads/releases/latest/download/BlueVentileCape.zip", Ventile.Default.CustomLocStr, "BlueVentileCape.zip");
			}
		}

		private void cosmetics_Load(object sender, EventArgs e)
		{
			Color color = Color.FromArgb(Colors.Default.backColor, Colors.Default.backColor, Colors.Default.backColor);
			Color color1 = Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3);
			Color color2 = Color.FromArgb(Colors.Default.foreColor, Colors.Default.foreColor, Colors.Default.foreColor);
			Color.FromArgb(Colors.Default.outlineColor, Colors.Default.outlineColor, Colors.Default.outlineColor);
			Color color3 = Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2);
			this.label3.ForeColor = color2;
			this.label5.ForeColor = color2;
			this.label4.ForeColor = color2;
			this.label6.ForeColor = color2;
			this.resetAllCosmetics.ForeColor = color2;
			this.label3.BackColor = color;
			this.label5.BackColor = color;
			this.label4.BackColor = color;
			this.label6.BackColor = color;
			this.resetAllCosmetics.BackColor = color;
			this.resetAllCosmetics.set_FillColor(color3);
			this.resetAllCosmetics.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.resetAllCosmetics.set_AutoRoundedCorners(true);
			}
			this.cBlack.BackColor = color;
			this.cBlack.set_FillColor(color3);
			this.cBlack.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.cBlack.set_AutoRoundedCorners(true);
			}
			this.cWhite.BackColor = color;
			this.cWhite.set_FillColor(color3);
			this.cWhite.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.cWhite.set_AutoRoundedCorners(true);
			}
			this.cPink.BackColor = color;
			this.cPink.set_FillColor(color3);
			this.cPink.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.cPink.set_AutoRoundedCorners(true);
			}
			this.cBlue.BackColor = color;
			this.cBlue.set_FillColor(color3);
			this.cBlue.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.cBlue.set_AutoRoundedCorners(true);
			}
			this.cYellow.BackColor = color;
			this.cYellow.set_FillColor(color3);
			this.cYellow.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.cYellow.set_AutoRoundedCorners(true);
			}
			this.cRick.BackColor = color;
			this.cRick.set_FillColor(color3);
			this.cRick.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.cRick.set_AutoRoundedCorners(true);
			}
			this.mBlack.BackColor = color;
			this.mBlack.set_FillColor(color3);
			this.mBlack.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.mBlack.set_AutoRoundedCorners(true);
			}
			this.mWhite.BackColor = color;
			this.mWhite.set_FillColor(color3);
			this.mWhite.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.mWhite.set_AutoRoundedCorners(true);
			}
			this.mPink.BackColor = color;
			this.mPink.set_FillColor(color3);
			this.mPink.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.mPink.set_AutoRoundedCorners(true);
			}
			this.mBlue.BackColor = color;
			this.mBlue.set_FillColor(color3);
			this.mBlue.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.mBlue.set_AutoRoundedCorners(true);
			}
			this.mYellow.BackColor = color;
			this.mYellow.set_FillColor(color3);
			this.mYellow.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.mYellow.set_AutoRoundedCorners(true);
			}
			this.mRick.BackColor = color;
			this.mRick.set_FillColor(color3);
			this.mRick.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.mRick.set_AutoRoundedCorners(true);
			}
			this.aGlowing.BackColor = color;
			this.aGlowing.set_FillColor(color3);
			this.aGlowing.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.aGlowing.set_AutoRoundedCorners(true);
			}
			this.aSlide.BackColor = color;
			this.aSlide.set_FillColor(color3);
			this.aSlide.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.aSlide.set_AutoRoundedCorners(true);
			}
			this.oWavy.BackColor = color;
			this.oWavy.set_FillColor(color3);
			this.oWavy.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.oWavy.set_AutoRoundedCorners(true);
			}
			this.oKagune.BackColor = color;
			this.oKagune.set_FillColor(color3);
			this.oKagune.set_AutoRoundedCorners(false);
			if (Ventile.Default.Rounded)
			{
				this.oKagune.set_AutoRoundedCorners(true);
			}
			this.cBlack.ForeColor = color2;
			this.cWhite.ForeColor = color2;
			this.cPink.ForeColor = color2;
			this.cBlue.ForeColor = color2;
			this.cYellow.ForeColor = color2;
			this.cRick.ForeColor = color2;
			this.mBlack.ForeColor = color2;
			this.mWhite.ForeColor = color2;
			this.mPink.ForeColor = color2;
			this.mBlue.ForeColor = color2;
			this.mYellow.ForeColor = color2;
			this.mRick.ForeColor = color2;
			this.aGlowing.ForeColor = color2;
			this.aSlide.ForeColor = color2;
			this.oWavy.ForeColor = color2;
			this.oKagune.ForeColor = color2;
			this.pictureBox1.BackColor = color;
			if (Colors.Default.theme == "Dark")
			{
				this.BackgroundImage = Resources.background;
			}
			else if (Colors.Default.theme == "Light")
			{
				this.BackgroundImage = Resources.background2;
			}
			if (Ventile.Default.customImage)
			{
				this.BackgroundImage = new Bitmap(Ventile.Default.customImageLoc);
			}
			if (Cosmetic.Default.cBlack)
			{
				this.cBlack.set_FillColor(color1);
			}
			else if (Cosmetic.Default.cWhite)
			{
				this.cWhite.set_FillColor(color1);
			}
			else if (Cosmetic.Default.cPink)
			{
				this.cPink.set_FillColor(color1);
			}
			else if (Cosmetic.Default.cBlue)
			{
				this.cBlue.set_FillColor(color1);
			}
			else if (Cosmetic.Default.cYellow)
			{
				this.cYellow.set_FillColor(color1);
			}
			else if (Cosmetic.Default.cRick)
			{
				this.cRick.set_FillColor(color1);
			}
			if (Cosmetic.Default.mBlack)
			{
				this.mBlack.set_FillColor(color1);
			}
			else if (Cosmetic.Default.mWhite)
			{
				this.mWhite.set_FillColor(color1);
			}
			else if (Cosmetic.Default.mPink)
			{
				this.mPink.set_FillColor(color1);
			}
			else if (Cosmetic.Default.mBlue)
			{
				this.mBlue.set_FillColor(color1);
			}
			else if (Cosmetic.Default.mYellow)
			{
				this.mYellow.set_FillColor(color1);
			}
			else if (Cosmetic.Default.mRick)
			{
				this.mRick.set_FillColor(color1);
			}
			if (Cosmetic.Default.aGlowing)
			{
				this.aGlowing.set_FillColor(color1);
			}
			else if (Cosmetic.Default.aSlide)
			{
				this.aSlide.set_FillColor(color1);
			}
			if (Cosmetic.Default.oKagune)
			{
				this.oKagune.set_FillColor(color1);
			}
			if (Cosmetic.Default.oWavy)
			{
				this.oKagune.set_FillColor(color1);
			}
		}

		private void cPink_Click(object sender, EventArgs e)
		{
			this.resetCapes();
			if (!Ventile.Default.internet)
			{
				MessageBox.Show("You currrently do not have an internet connection!", "No Internet");
			}
			else
			{
				this.cPink.set_FillColor(Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3));
				Cosmetic.Default.cPink = true;
				this.download("https://github.com/DeathlyBower959/Ventile-Client-Downloads/releases/latest/download/PinkVentileCape.zip", Ventile.Default.CustomLocStr, "PinkVentileCape.zip");
			}
		}

		private void cRick_Click(object sender, EventArgs e)
		{
			this.resetCapes();
			if (!Ventile.Default.internet)
			{
				MessageBox.Show("You currrently do not have an internet connection!", "No Internet");
			}
			else
			{
				this.cRick.set_FillColor(Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3));
				Cosmetic.Default.cRick = true;
				this.download("https://github.com/DeathlyBower959/Ventile-Client-Downloads/releases/latest/download/RickVentileCape.zip", Ventile.Default.CustomLocStr, "RickVentileCape.zip");
			}
		}

		private void cWhite_Click(object sender, EventArgs e)
		{
			this.resetCapes();
			if (!Ventile.Default.internet)
			{
				MessageBox.Show("You currrently do not have an internet connection!", "No Internet");
			}
			else
			{
				this.cWhite.set_FillColor(Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3));
				Cosmetic.Default.cWhite = true;
				this.download("https://github.com/DeathlyBower959/Ventile-Client-Downloads/releases/latest/download/WhiteVentileCape.zip", Ventile.Default.CustomLocStr, "WhiteVentileCape.zip");
			}
		}

		private void cYellow_Click(object sender, EventArgs e)
		{
			this.resetCapes();
			if (!Ventile.Default.internet)
			{
				MessageBox.Show("You currrently do not have an internet connection!", "No Internet");
			}
			else
			{
				this.cYellow.set_FillColor(Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3));
				Cosmetic.Default.cYellow = true;
				this.download("https://github.com/DeathlyBower959/Ventile-Client-Downloads/releases/latest/download/GoldVentileCape.zip", Ventile.Default.CustomLocStr, "GoldVentileCape.zip");
			}
		}

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

		private void InitializeComponent()
		{
			this.button1 = new Button();
			this.label1 = new Label();
			this.pictureBox1 = new PictureBox();
			this.label2 = new Label();
			this.label3 = new Label();
			this.label4 = new Label();
			this.label5 = new Label();
			this.label6 = new Label();
			this.cBlack = new Guna2Button();
			this.cWhite = new Guna2Button();
			this.cPink = new Guna2Button();
			this.cBlue = new Guna2Button();
			this.cYellow = new Guna2Button();
			this.cRick = new Guna2Button();
			this.resetAllCosmetics = new Guna2Button();
			this.mRick = new Guna2Button();
			this.mYellow = new Guna2Button();
			this.mBlue = new Guna2Button();
			this.mPink = new Guna2Button();
			this.mWhite = new Guna2Button();
			this.mBlack = new Guna2Button();
			this.aGlowing = new Guna2Button();
			this.aSlide = new Guna2Button();
			this.oWavy = new Guna2Button();
			this.oKagune = new Guna2Button();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.button1.BackColor = Color.FromArgb(40, 40, 40);
			this.button1.Cursor = Cursors.Hand;
			this.button1.FlatAppearance.BorderColor = Color.Black;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button1.ForeColor = Color.White;
			this.button1.Location = new Point(54, 190);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(140, 29);
			this.button1.TabIndex = 13;
			this.button1.Text = "Hide Launcher";
			this.button1.UseVisualStyleBackColor = false;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.FromArgb(20, 20, 20);
			this.label1.Cursor = Cursors.Hand;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(57, 114);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(137, 25);
			this.label1.TabIndex = 14;
			this.label1.Text = "Window State";
			this.label1.TextAlign = ContentAlignment.MiddleCenter;
			this.pictureBox1.BackColor = Color.FromArgb(20, 20, 20);
			this.pictureBox1.Location = new Point(-6, 90);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(660, 375);
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.White;
			this.label2.Location = new Point(225, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(185, 47);
			this.label2.TabIndex = 16;
			this.label2.Text = "Cosmetics";
			this.label2.TextAlign = ContentAlignment.MiddleCenter;
			this.label3.AutoSize = true;
			this.label3.BackColor = Color.FromArgb(20, 20, 20);
			this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label3.ForeColor = Color.White;
			this.label3.Location = new Point(57, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 25);
			this.label3.TabIndex = 17;
			this.label3.Text = "Capes";
			this.label3.TextAlign = ContentAlignment.MiddleCenter;
			this.label4.AutoSize = true;
			this.label4.BackColor = Color.FromArgb(20, 20, 20);
			this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label4.ForeColor = Color.White;
			this.label4.Location = new Point(326, 114);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(155, 25);
			this.label4.TabIndex = 18;
			this.label4.Text = "Animated Capes";
			this.label4.TextAlign = ContentAlignment.MiddleCenter;
			this.label5.AutoSize = true;
			this.label5.BackColor = Color.FromArgb(20, 20, 20);
			this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label5.ForeColor = Color.White;
			this.label5.Location = new Point(214, 114);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 25);
			this.label5.TabIndex = 19;
			this.label5.Text = "Masks";
			this.label5.TextAlign = ContentAlignment.MiddleCenter;
			this.label6.AutoSize = true;
			this.label6.BackColor = Color.FromArgb(20, 20, 20);
			this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label6.ForeColor = Color.White;
			this.label6.Location = new Point(526, 114);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 25);
			this.label6.TabIndex = 35;
			this.label6.Text = "Other";
			this.label6.TextAlign = ContentAlignment.MiddleCenter;
			this.cBlack.set_Animated(true);
			this.cBlack.set_AutoRoundedCorners(true);
			this.cBlack.BackColor = Color.FromArgb(20, 20, 20);
			this.cBlack.set_BorderRadius(13);
			this.cBlack.get_CheckedState().set_Parent(this.cBlack);
			this.cBlack.Cursor = Cursors.Hand;
			this.cBlack.get_CustomImages().set_Parent(this.cBlack);
			this.cBlack.set_FillColor(Color.FromArgb(40, 40, 40));
			this.cBlack.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.cBlack.ForeColor = Color.White;
			this.cBlack.get_HoverState().set_Parent(this.cBlack);
			this.cBlack.Location = new Point(19, 155);
			this.cBlack.Name = "cBlack";
			this.cBlack.get_ShadowDecoration().set_Parent(this.cBlack);
			this.cBlack.Size = new System.Drawing.Size(141, 29);
			this.cBlack.TabIndex = 74;
			this.cBlack.TabStop = false;
			this.cBlack.Text = "Black";
			this.cBlack.Click += new EventHandler(this.cBlack_Click);
			this.cWhite.set_Animated(true);
			this.cWhite.set_AutoRoundedCorners(true);
			this.cWhite.BackColor = Color.FromArgb(20, 20, 20);
			this.cWhite.set_BorderRadius(13);
			this.cWhite.get_CheckedState().set_Parent(this.cWhite);
			this.cWhite.Cursor = Cursors.Hand;
			this.cWhite.get_CustomImages().set_Parent(this.cWhite);
			this.cWhite.set_FillColor(Color.FromArgb(40, 40, 40));
			this.cWhite.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.cWhite.ForeColor = Color.White;
			this.cWhite.get_HoverState().set_Parent(this.cWhite);
			this.cWhite.Location = new Point(19, 190);
			this.cWhite.Name = "cWhite";
			this.cWhite.get_ShadowDecoration().set_Parent(this.cWhite);
			this.cWhite.Size = new System.Drawing.Size(141, 29);
			this.cWhite.TabIndex = 75;
			this.cWhite.TabStop = false;
			this.cWhite.Text = "White";
			this.cWhite.Click += new EventHandler(this.cWhite_Click);
			this.cPink.set_Animated(true);
			this.cPink.set_AutoRoundedCorners(true);
			this.cPink.BackColor = Color.FromArgb(20, 20, 20);
			this.cPink.set_BorderRadius(13);
			this.cPink.get_CheckedState().set_Parent(this.cPink);
			this.cPink.Cursor = Cursors.Hand;
			this.cPink.get_CustomImages().set_Parent(this.cPink);
			this.cPink.set_FillColor(Color.FromArgb(40, 40, 40));
			this.cPink.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.cPink.ForeColor = Color.White;
			this.cPink.get_HoverState().set_Parent(this.cPink);
			this.cPink.Location = new Point(18, 225);
			this.cPink.Name = "cPink";
			this.cPink.get_ShadowDecoration().set_Parent(this.cPink);
			this.cPink.Size = new System.Drawing.Size(141, 29);
			this.cPink.TabIndex = 76;
			this.cPink.TabStop = false;
			this.cPink.Text = "Pink Galaxy";
			this.cPink.Click += new EventHandler(this.cPink_Click);
			this.cBlue.set_Animated(true);
			this.cBlue.set_AutoRoundedCorners(true);
			this.cBlue.BackColor = Color.FromArgb(20, 20, 20);
			this.cBlue.set_BorderRadius(13);
			this.cBlue.get_CheckedState().set_Parent(this.cBlue);
			this.cBlue.Cursor = Cursors.Hand;
			this.cBlue.get_CustomImages().set_Parent(this.cBlue);
			this.cBlue.set_FillColor(Color.FromArgb(40, 40, 40));
			this.cBlue.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.cBlue.ForeColor = Color.White;
			this.cBlue.get_HoverState().set_Parent(this.cBlue);
			this.cBlue.Location = new Point(19, 260);
			this.cBlue.Name = "cBlue";
			this.cBlue.get_ShadowDecoration().set_Parent(this.cBlue);
			this.cBlue.Size = new System.Drawing.Size(141, 29);
			this.cBlue.TabIndex = 77;
			this.cBlue.TabStop = false;
			this.cBlue.Text = "Dark Blue Sky";
			this.cBlue.Click += new EventHandler(this.cBlue_Click);
			this.cYellow.set_Animated(true);
			this.cYellow.set_AutoRoundedCorners(true);
			this.cYellow.BackColor = Color.FromArgb(20, 20, 20);
			this.cYellow.set_BorderRadius(13);
			this.cYellow.get_CheckedState().set_Parent(this.cYellow);
			this.cYellow.Cursor = Cursors.Hand;
			this.cYellow.get_CustomImages().set_Parent(this.cYellow);
			this.cYellow.set_FillColor(Color.FromArgb(40, 40, 40));
			this.cYellow.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.cYellow.ForeColor = Color.White;
			this.cYellow.get_HoverState().set_Parent(this.cYellow);
			this.cYellow.Location = new Point(18, 295);
			this.cYellow.Name = "cYellow";
			this.cYellow.get_ShadowDecoration().set_Parent(this.cYellow);
			this.cYellow.Size = new System.Drawing.Size(141, 29);
			this.cYellow.TabIndex = 78;
			this.cYellow.TabStop = false;
			this.cYellow.Text = "Yellow Gradient";
			this.cYellow.Click += new EventHandler(this.cYellow_Click);
			this.cRick.set_Animated(true);
			this.cRick.set_AutoRoundedCorners(true);
			this.cRick.BackColor = Color.FromArgb(20, 20, 20);
			this.cRick.set_BorderRadius(13);
			this.cRick.get_CheckedState().set_Parent(this.cRick);
			this.cRick.Cursor = Cursors.Hand;
			this.cRick.get_CustomImages().set_Parent(this.cRick);
			this.cRick.set_FillColor(Color.FromArgb(40, 40, 40));
			this.cRick.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.cRick.ForeColor = Color.White;
			this.cRick.get_HoverState().set_Parent(this.cRick);
			this.cRick.Location = new Point(18, 330);
			this.cRick.Name = "cRick";
			this.cRick.get_ShadowDecoration().set_Parent(this.cRick);
			this.cRick.Size = new System.Drawing.Size(141, 29);
			this.cRick.TabIndex = 79;
			this.cRick.TabStop = false;
			this.cRick.Text = "Rick Astley";
			this.cRick.Click += new EventHandler(this.cRick_Click);
			this.resetAllCosmetics.set_Animated(true);
			this.resetAllCosmetics.set_AutoRoundedCorners(true);
			this.resetAllCosmetics.BackColor = Color.FromArgb(20, 20, 20);
			this.resetAllCosmetics.set_BorderRadius(13);
			this.resetAllCosmetics.get_CheckedState().set_Parent(this.resetAllCosmetics);
			this.resetAllCosmetics.Cursor = Cursors.Hand;
			this.resetAllCosmetics.get_CustomImages().set_Parent(this.resetAllCosmetics);
			this.resetAllCosmetics.set_FillColor(Color.FromArgb(40, 40, 40));
			this.resetAllCosmetics.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.resetAllCosmetics.ForeColor = Color.White;
			this.resetAllCosmetics.get_HoverState().set_Parent(this.resetAllCosmetics);
			this.resetAllCosmetics.Location = new Point(242, 423);
			this.resetAllCosmetics.Name = "resetAllCosmetics";
			this.resetAllCosmetics.get_ShadowDecoration().set_Parent(this.resetAllCosmetics);
			this.resetAllCosmetics.Size = new System.Drawing.Size(141, 29);
			this.resetAllCosmetics.TabIndex = 80;
			this.resetAllCosmetics.TabStop = false;
			this.resetAllCosmetics.Text = "Reset";
			this.resetAllCosmetics.Click += new EventHandler(this.resetAllCosmetics_Click);
			this.mRick.set_Animated(true);
			this.mRick.set_AutoRoundedCorners(true);
			this.mRick.BackColor = Color.FromArgb(20, 20, 20);
			this.mRick.set_BorderRadius(13);
			this.mRick.get_CheckedState().set_Parent(this.mRick);
			this.mRick.Cursor = Cursors.Hand;
			this.mRick.get_CustomImages().set_Parent(this.mRick);
			this.mRick.set_FillColor(Color.FromArgb(40, 40, 40));
			this.mRick.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.mRick.ForeColor = Color.White;
			this.mRick.get_HoverState().set_Parent(this.mRick);
			this.mRick.Location = new Point(173, 330);
			this.mRick.Name = "mRick";
			this.mRick.get_ShadowDecoration().set_Parent(this.mRick);
			this.mRick.Size = new System.Drawing.Size(141, 29);
			this.mRick.TabIndex = 86;
			this.mRick.TabStop = false;
			this.mRick.Text = "Rick Astley";
			this.mRick.Click += new EventHandler(this.mRick_Click);
			this.mYellow.set_Animated(true);
			this.mYellow.set_AutoRoundedCorners(true);
			this.mYellow.BackColor = Color.FromArgb(20, 20, 20);
			this.mYellow.set_BorderRadius(13);
			this.mYellow.get_CheckedState().set_Parent(this.mYellow);
			this.mYellow.Cursor = Cursors.Hand;
			this.mYellow.get_CustomImages().set_Parent(this.mYellow);
			this.mYellow.set_FillColor(Color.FromArgb(40, 40, 40));
			this.mYellow.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.mYellow.ForeColor = Color.White;
			this.mYellow.get_HoverState().set_Parent(this.mYellow);
			this.mYellow.Location = new Point(173, 295);
			this.mYellow.Name = "mYellow";
			this.mYellow.get_ShadowDecoration().set_Parent(this.mYellow);
			this.mYellow.Size = new System.Drawing.Size(141, 29);
			this.mYellow.TabIndex = 85;
			this.mYellow.TabStop = false;
			this.mYellow.Text = "Yellow Gradient";
			this.mYellow.Click += new EventHandler(this.mYellow_Click);
			this.mBlue.set_Animated(true);
			this.mBlue.set_AutoRoundedCorners(true);
			this.mBlue.BackColor = Color.FromArgb(20, 20, 20);
			this.mBlue.set_BorderRadius(13);
			this.mBlue.get_CheckedState().set_Parent(this.mBlue);
			this.mBlue.Cursor = Cursors.Hand;
			this.mBlue.get_CustomImages().set_Parent(this.mBlue);
			this.mBlue.set_FillColor(Color.FromArgb(40, 40, 40));
			this.mBlue.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.mBlue.ForeColor = Color.White;
			this.mBlue.get_HoverState().set_Parent(this.mBlue);
			this.mBlue.Location = new Point(174, 260);
			this.mBlue.Name = "mBlue";
			this.mBlue.get_ShadowDecoration().set_Parent(this.mBlue);
			this.mBlue.Size = new System.Drawing.Size(141, 29);
			this.mBlue.TabIndex = 84;
			this.mBlue.TabStop = false;
			this.mBlue.Text = "Dark Blue Sky";
			this.mBlue.Click += new EventHandler(this.mBlue_Click);
			this.mPink.set_Animated(true);
			this.mPink.set_AutoRoundedCorners(true);
			this.mPink.BackColor = Color.FromArgb(20, 20, 20);
			this.mPink.set_BorderRadius(13);
			this.mPink.get_CheckedState().set_Parent(this.mPink);
			this.mPink.Cursor = Cursors.Hand;
			this.mPink.get_CustomImages().set_Parent(this.mPink);
			this.mPink.set_FillColor(Color.FromArgb(40, 40, 40));
			this.mPink.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.mPink.ForeColor = Color.White;
			this.mPink.get_HoverState().set_Parent(this.mPink);
			this.mPink.Location = new Point(173, 225);
			this.mPink.Name = "mPink";
			this.mPink.get_ShadowDecoration().set_Parent(this.mPink);
			this.mPink.Size = new System.Drawing.Size(141, 29);
			this.mPink.TabIndex = 83;
			this.mPink.TabStop = false;
			this.mPink.Text = "Pink Galaxy";
			this.mPink.Click += new EventHandler(this.mPink_Click);
			this.mWhite.set_Animated(true);
			this.mWhite.set_AutoRoundedCorners(true);
			this.mWhite.BackColor = Color.FromArgb(20, 20, 20);
			this.mWhite.set_BorderRadius(13);
			this.mWhite.get_CheckedState().set_Parent(this.mWhite);
			this.mWhite.Cursor = Cursors.Hand;
			this.mWhite.get_CustomImages().set_Parent(this.mWhite);
			this.mWhite.set_FillColor(Color.FromArgb(40, 40, 40));
			this.mWhite.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.mWhite.ForeColor = Color.White;
			this.mWhite.get_HoverState().set_Parent(this.mWhite);
			this.mWhite.Location = new Point(174, 190);
			this.mWhite.Name = "mWhite";
			this.mWhite.get_ShadowDecoration().set_Parent(this.mWhite);
			this.mWhite.Size = new System.Drawing.Size(141, 29);
			this.mWhite.TabIndex = 82;
			this.mWhite.TabStop = false;
			this.mWhite.Text = "White";
			this.mWhite.Click += new EventHandler(this.mWhite_Click);
			this.mBlack.set_Animated(true);
			this.mBlack.set_AutoRoundedCorners(true);
			this.mBlack.BackColor = Color.FromArgb(20, 20, 20);
			this.mBlack.set_BorderRadius(13);
			this.mBlack.get_CheckedState().set_Parent(this.mBlack);
			this.mBlack.Cursor = Cursors.Hand;
			this.mBlack.get_CustomImages().set_Parent(this.mBlack);
			this.mBlack.set_FillColor(Color.FromArgb(40, 40, 40));
			this.mBlack.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.mBlack.ForeColor = Color.White;
			this.mBlack.get_HoverState().set_Parent(this.mBlack);
			this.mBlack.Location = new Point(174, 155);
			this.mBlack.Name = "mBlack";
			this.mBlack.get_ShadowDecoration().set_Parent(this.mBlack);
			this.mBlack.Size = new System.Drawing.Size(141, 29);
			this.mBlack.TabIndex = 81;
			this.mBlack.TabStop = false;
			this.mBlack.Text = "Black";
			this.mBlack.Click += new EventHandler(this.mBlack_Click);
			this.aGlowing.set_Animated(true);
			this.aGlowing.set_AutoRoundedCorners(true);
			this.aGlowing.BackColor = Color.FromArgb(20, 20, 20);
			this.aGlowing.set_BorderRadius(13);
			this.aGlowing.get_CheckedState().set_Parent(this.aGlowing);
			this.aGlowing.Cursor = Cursors.Hand;
			this.aGlowing.get_CustomImages().set_Parent(this.aGlowing);
			this.aGlowing.set_FillColor(Color.FromArgb(40, 40, 40));
			this.aGlowing.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.aGlowing.ForeColor = Color.White;
			this.aGlowing.get_HoverState().set_Parent(this.aGlowing);
			this.aGlowing.Location = new Point(331, 155);
			this.aGlowing.Name = "aGlowing";
			this.aGlowing.get_ShadowDecoration().set_Parent(this.aGlowing);
			this.aGlowing.Size = new System.Drawing.Size(141, 29);
			this.aGlowing.TabIndex = 87;
			this.aGlowing.TabStop = false;
			this.aGlowing.Text = "Glowing Pulse";
			this.aGlowing.Click += new EventHandler(this.aGlowing_Click);
			this.aSlide.set_Animated(true);
			this.aSlide.set_AutoRoundedCorners(true);
			this.aSlide.BackColor = Color.FromArgb(20, 20, 20);
			this.aSlide.set_BorderRadius(13);
			this.aSlide.get_CheckedState().set_Parent(this.aSlide);
			this.aSlide.Cursor = Cursors.Hand;
			this.aSlide.get_CustomImages().set_Parent(this.aSlide);
			this.aSlide.set_FillColor(Color.FromArgb(40, 40, 40));
			this.aSlide.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.aSlide.ForeColor = Color.White;
			this.aSlide.get_HoverState().set_Parent(this.aSlide);
			this.aSlide.Location = new Point(331, 190);
			this.aSlide.Name = "aSlide";
			this.aSlide.get_ShadowDecoration().set_Parent(this.aSlide);
			this.aSlide.Size = new System.Drawing.Size(141, 29);
			this.aSlide.TabIndex = 88;
			this.aSlide.TabStop = false;
			this.aSlide.Text = "Slide";
			this.aSlide.Click += new EventHandler(this.aSlide_Click);
			this.oWavy.set_Animated(true);
			this.oWavy.set_AutoRoundedCorners(true);
			this.oWavy.BackColor = Color.FromArgb(20, 20, 20);
			this.oWavy.set_BorderRadius(13);
			this.oWavy.get_CheckedState().set_Parent(this.oWavy);
			this.oWavy.Cursor = Cursors.Hand;
			this.oWavy.get_CustomImages().set_Parent(this.oWavy);
			this.oWavy.set_FillColor(Color.FromArgb(40, 40, 40));
			this.oWavy.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.oWavy.ForeColor = Color.White;
			this.oWavy.get_HoverState().set_Parent(this.oWavy);
			this.oWavy.Location = new Point(487, 155);
			this.oWavy.Name = "oWavy";
			this.oWavy.get_ShadowDecoration().set_Parent(this.oWavy);
			this.oWavy.Size = new System.Drawing.Size(141, 29);
			this.oWavy.TabIndex = 89;
			this.oWavy.TabStop = false;
			this.oWavy.Text = "Wavy Capes";
			this.oWavy.Click += new EventHandler(this.oWavy_Click);
			this.oKagune.set_Animated(true);
			this.oKagune.set_AutoRoundedCorners(true);
			this.oKagune.BackColor = Color.FromArgb(20, 20, 20);
			this.oKagune.set_BorderRadius(13);
			this.oKagune.get_CheckedState().set_Parent(this.oKagune);
			this.oKagune.Cursor = Cursors.Hand;
			this.oKagune.get_CustomImages().set_Parent(this.oKagune);
			this.oKagune.set_FillColor(Color.FromArgb(40, 40, 40));
			this.oKagune.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold);
			this.oKagune.ForeColor = Color.White;
			this.oKagune.get_HoverState().set_Parent(this.oKagune);
			this.oKagune.Location = new Point(487, 190);
			this.oKagune.Name = "oKagune";
			this.oKagune.get_ShadowDecoration().set_Parent(this.oKagune);
			this.oKagune.Size = new System.Drawing.Size(141, 29);
			this.oKagune.TabIndex = 90;
			this.oKagune.TabStop = false;
			this.oKagune.Text = "Kagune";
			this.oKagune.Click += new EventHandler(this.oKagune_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.Black;
			this.BackgroundImage = Resources.background;
			this.BackgroundImageLayout = ImageLayout.Stretch;
			base.ClientSize = new System.Drawing.Size(645, 464);
			base.Controls.Add(this.oKagune);
			base.Controls.Add(this.oWavy);
			base.Controls.Add(this.aSlide);
			base.Controls.Add(this.aGlowing);
			base.Controls.Add(this.mRick);
			base.Controls.Add(this.mYellow);
			base.Controls.Add(this.mBlue);
			base.Controls.Add(this.mPink);
			base.Controls.Add(this.mWhite);
			base.Controls.Add(this.mBlack);
			base.Controls.Add(this.resetAllCosmetics);
			base.Controls.Add(this.cRick);
			base.Controls.Add(this.cYellow);
			base.Controls.Add(this.cBlue);
			base.Controls.Add(this.cPink);
			base.Controls.Add(this.cWhite);
			base.Controls.Add(this.cBlack);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.button1);
			this.DoubleBuffered = true;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "cosmetics";
			this.Text = "cosmetics";
			base.Load += new EventHandler(this.cosmetics_Load);
			((ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void mBlack_Click(object sender, EventArgs e)
		{
			this.resetMasks();
			if (!Ventile.Default.internet)
			{
				MessageBox.Show("You currrently do not have an internet connection!", "No Internet");
			}
			else
			{
				this.mBlack.set_FillColor(Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3));
				Cosmetic.Default.mBlack = true;
				this.download("https://github.com/DeathlyBower959/Ventile-Client-Downloads/releases/latest/download/BlackVentileMask.zip", Ventile.Default.CustomLocStr, "BlackVentileMask.zip");
			}
		}

		private void mBlue_Click(object sender, EventArgs e)
		{
			this.resetMasks();
			if (!Ventile.Default.internet)
			{
				MessageBox.Show("You currrently do not have an internet connection!", "No Internet");
			}
			else
			{
				this.mBlue.set_FillColor(Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3));
				Cosmetic.Default.mBlue = true;
				this.download("https://github.com/DeathlyBower959/Ventile-Client-Downloads/releases/latest/download/BlueVentileMask.zip", Ventile.Default.CustomLocStr, "BlueVentileMask.zip");
			}
		}

		private void mPink_Click(object sender, EventArgs e)
		{
			this.resetMasks();
			if (!Ventile.Default.internet)
			{
				MessageBox.Show("You currrently do not have an internet connection!", "No Internet");
			}
			else
			{
				this.mPink.set_FillColor(Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3));
				Cosmetic.Default.mPink = true;
				this.download("https://github.com/DeathlyBower959/Ventile-Client-Downloads/releases/latest/download/PinkVentileMask.zip", Ventile.Default.CustomLocStr, "PinkVentileMask.zip");
			}
		}

		private void mRick_Click(object sender, EventArgs e)
		{
			this.resetMasks();
			if (!Ventile.Default.internet)
			{
				MessageBox.Show("You currrently do not have an internet connection!", "No Internet");
			}
			else
			{
				this.mRick.set_FillColor(Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3));
				Cosmetic.Default.mRick = true;
				this.download("https://github.com/DeathlyBower959/Ventile-Client-Downloads/releases/latest/download/RickVentileMask.zip", Ventile.Default.CustomLocStr, "RickVentileMask.zip");
			}
		}

		private void mWhite_Click(object sender, EventArgs e)
		{
			this.resetMasks();
			if (!Ventile.Default.internet)
			{
				MessageBox.Show("You currrently do not have an internet connection!", "No Internet");
			}
			else
			{
				this.mWhite.set_FillColor(Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3));
				Cosmetic.Default.mWhite = true;
				this.download("https://github.com/DeathlyBower959/Ventile-Client-Downloads/releases/latest/download/WhiteVentileMask.zip", Ventile.Default.CustomLocStr, "WhiteVentileMask.zip");
			}
		}

		private void mYellow_Click(object sender, EventArgs e)
		{
			this.resetMasks();
			if (!Ventile.Default.internet)
			{
				MessageBox.Show("You currrently do not have an internet connection!", "No Internet");
			}
			else
			{
				this.mYellow.set_FillColor(Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3));
				Cosmetic.Default.mYellow = true;
				this.download("https://github.com/DeathlyBower959/Ventile-Client-Downloads/releases/latest/download/YellowVentileMask.zip", Ventile.Default.CustomLocStr, "YellowVentileMask.zip");
			}
		}

		private void oKagune_Click(object sender, EventArgs e)
		{
			if (!Ventile.Default.internet)
			{
				MessageBox.Show("You currrently do not have an internet connection!", "No Internet");
			}
			else if (!Cosmetic.Default.oKagune)
			{
				this.oKagune.set_FillColor(Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3));
				Cosmetic.Default.oKagune = true;
				if (File.Exists(string.Concat(Ventile.Default.CustomLocStr, "\\KaguneVentile.zip")))
				{
					File.Delete(string.Concat(Ventile.Default.CustomLocStr, "\\KaguneVentile.zip"));
				}
				this.download("https://github.com/DeathlyBower959/Ventile-Client-Downloads/releases/latest/download/oKagune.zip", Ventile.Default.CustomLocStr, "KaguneVentile.zip");
			}
			else if (Cosmetic.Default.oKagune)
			{
				if (File.Exists(string.Concat(Ventile.Default.CustomLocStr, "\\KaguneVentile.zip")))
				{
					File.Delete(string.Concat(Ventile.Default.CustomLocStr, "\\KaguneVentile.zip"));
				}
				this.oKagune.set_FillColor(Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2));
				Cosmetic.Default.oKagune = false;
			}
		}

		private void oWavy_Click(object sender, EventArgs e)
		{
			if (!Ventile.Default.internet)
			{
				MessageBox.Show("You currrently do not have an internet connection!", "No Internet");
			}
			else if (!Cosmetic.Default.oWavy)
			{
				this.oWavy.set_FillColor(Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3));
				Cosmetic.Default.oWavy = true;
				if (File.Exists(string.Concat(Ventile.Default.CustomLocStr, "\\WavyVentile.zip")))
				{
					File.Delete(string.Concat(Ventile.Default.CustomLocStr, "\\WavyVentile.zip"));
				}
				this.download("https://github.com/DeathlyBower959/Ventile-Client-Downloads/releases/latest/download/oWavy.zip", Ventile.Default.CustomLocStr, "WavyVentile.zip");
			}
			else if (Cosmetic.Default.oWavy)
			{
				if (File.Exists(string.Concat(Ventile.Default.CustomLocStr, "\\WavyVentile.zip")))
				{
					File.Delete(string.Concat(Ventile.Default.CustomLocStr, "\\WavyVentile.zip"));
				}
				this.oWavy.set_FillColor(Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2));
				Cosmetic.Default.oWavy = false;
			}
		}

		private void resetAllCosmetics_Click(object sender, EventArgs e)
		{
			this.resetCapes();
			this.resetMasks();
			this.resetExtras();
			if (Ventile.Default.internet)
			{
				if (File.Exists(string.Concat(Ventile.Default.CustomLocStr, "\\KaguneVentile.zip")))
				{
					File.Delete(string.Concat(Ventile.Default.CustomLocStr, "\\KaguneVentile.zip"));
				}
				this.oKagune.set_FillColor(Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2));
				Cosmetic.Default.oKagune = false;
			}
			if (Ventile.Default.internet)
			{
				if (File.Exists(string.Concat(Ventile.Default.CustomLocStr, "\\WavyVentile.zip")))
				{
					File.Delete(string.Concat(Ventile.Default.CustomLocStr, "\\WavyVentile.zip"));
				}
				this.oWavy.set_FillColor(Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2));
				Cosmetic.Default.oWavy = false;
			}
		}

		private void resetCapes()
		{
			Color.FromArgb(Colors.Default.backColor, Colors.Default.backColor, Colors.Default.backColor);
			Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3);
			Color.FromArgb(Colors.Default.foreColor, Colors.Default.foreColor, Colors.Default.foreColor);
			Color.FromArgb(Colors.Default.outlineColor, Colors.Default.outlineColor, Colors.Default.outlineColor);
			Color color = Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2);
			this.cBlack.set_FillColor(color);
			this.cWhite.set_FillColor(color);
			this.cPink.set_FillColor(color);
			this.cBlue.set_FillColor(color);
			this.cYellow.set_FillColor(color);
			this.cRick.set_FillColor(color);
			Cosmetic.Default.cBlack = false;
			Cosmetic.Default.cWhite = false;
			Cosmetic.Default.cPink = false;
			Cosmetic.Default.cBlue = false;
			Cosmetic.Default.cYellow = false;
			Cosmetic.Default.cRick = false;
			if (Ventile.Default.internet)
			{
				if (File.Exists(string.Concat(Ventile.Default.CustomLocStr, "\\BlackVentileCape.zip")))
				{
					File.Delete(string.Concat(Ventile.Default.CustomLocStr, "\\BlackVentileCape.zip"));
				}
				if (File.Exists(string.Concat(Ventile.Default.CustomLocStr, "\\WhiteVentileCape.zip")))
				{
					File.Delete(string.Concat(Ventile.Default.CustomLocStr, "\\WhiteVentileCape.zip"));
				}
				if (File.Exists(string.Concat(Ventile.Default.CustomLocStr, "\\PinkVentileCape.zip")))
				{
					File.Delete(string.Concat(Ventile.Default.CustomLocStr, "\\PinkVentileCape.zip"));
				}
				if (File.Exists(string.Concat(Ventile.Default.CustomLocStr, "\\BlueVentileCape.zip")))
				{
					File.Delete(string.Concat(Ventile.Default.CustomLocStr, "\\BlueVentileCape.zip"));
				}
				if (File.Exists(string.Concat(Ventile.Default.CustomLocStr, "\\GoldVentileCape.zip")))
				{
					File.Delete(string.Concat(Ventile.Default.CustomLocStr, "\\GoldVentileCape.zip"));
				}
				if (File.Exists(string.Concat(Ventile.Default.CustomLocStr, "\\RickVentileCape.zip")))
				{
					File.Delete(string.Concat(Ventile.Default.CustomLocStr, "\\RickVentileCape.zip"));
				}
			}
		}

		private void resetExtras()
		{
			this.aGlowing.set_FillColor(Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2));
			this.aSlide.set_FillColor(Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2));
			Cosmetic.Default.aGlowing = false;
			Cosmetic.Default.aSlide = false;
			if (Ventile.Default.internet)
			{
				if (File.Exists(string.Concat(Ventile.Default.CustomLocStr, "\\GlowingVentileCape.zip")))
				{
					File.Delete(string.Concat(Ventile.Default.CustomLocStr, "\\GlowingVentileCape.zip"));
				}
				if (File.Exists(string.Concat(Ventile.Default.CustomLocStr, "\\SlidingVentileCape.zip")))
				{
					File.Delete(string.Concat(Ventile.Default.CustomLocStr, "\\SlidingVentileCape.zip"));
				}
			}
		}

		public void resetMasks()
		{
			Color.FromArgb(Colors.Default.backColor, Colors.Default.backColor, Colors.Default.backColor);
			Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3);
			Color.FromArgb(Colors.Default.foreColor, Colors.Default.foreColor, Colors.Default.foreColor);
			Color.FromArgb(Colors.Default.outlineColor, Colors.Default.outlineColor, Colors.Default.outlineColor);
			Color color = Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2);
			this.mBlack.set_FillColor(color);
			this.mWhite.set_FillColor(color);
			this.mPink.set_FillColor(color);
			this.mBlue.set_FillColor(color);
			this.mYellow.set_FillColor(color);
			this.mRick.set_FillColor(color);
			Cosmetic.Default.mBlack = false;
			Cosmetic.Default.mWhite = false;
			Cosmetic.Default.mPink = false;
			Cosmetic.Default.mBlue = false;
			Cosmetic.Default.mYellow = false;
			Cosmetic.Default.mRick = false;
			if (File.Exists(string.Concat(Ventile.Default.CustomLocStr, "\\WhiteVentileMask.zip")))
			{
				File.Delete(string.Concat(Ventile.Default.CustomLocStr, "\\WhiteVentileMask.zip"));
			}
			if (File.Exists(string.Concat(Ventile.Default.CustomLocStr, "\\BlackVentileMask.zip")))
			{
				File.Delete(string.Concat(Ventile.Default.CustomLocStr, "\\BlackVentileMask.zip"));
			}
			if (File.Exists(string.Concat(Ventile.Default.CustomLocStr, "\\PinkVentileMask.zip")))
			{
				File.Delete(string.Concat(Ventile.Default.CustomLocStr, "\\PinkVentileMask.zip"));
			}
			if (File.Exists(string.Concat(Ventile.Default.CustomLocStr, "\\BlueVentileMask.zip")))
			{
				File.Delete(string.Concat(Ventile.Default.CustomLocStr, "\\BlueVentileMask.zip"));
			}
			if (File.Exists(string.Concat(Ventile.Default.CustomLocStr, "\\YellowVentileMask.zip")))
			{
				File.Delete(string.Concat(Ventile.Default.CustomLocStr, "\\YellowVentileMask.zip"));
			}
			if (File.Exists(string.Concat(Ventile.Default.CustomLocStr, "\\RickVentileMask.zip")))
			{
				File.Delete(string.Concat(Ventile.Default.CustomLocStr, "\\RickVentileMask.zip"));
			}
		}
	}
}