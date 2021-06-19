using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using Ventile_Client.Properties;

namespace Ventile_Client
{
	public class about : Form
	{
		private IContainer components = null;

		private Label label1;

		private Label launcher;

		private PictureBox pictureBox1;

		private Label label2;

		private Label texture;

		private Label client;

		private PictureBox pictureBox2;

		private Label label3;

		private PictureBox pictureBox3;

		private PictureBox pictureBox4;

		private Label launcherVLabel;

		private Label clientVLabel;

		private Label cosmeticsVLabel;

		public about()
		{
			this.InitializeComponent();
		}

		private void about_Load(object sender, EventArgs e)
		{
			this.launcherVLabel.Text = Ventile.Default.Version;
			this.clientVLabel.Text = Ventile.Default.ClientVersion;
			this.cosmeticsVLabel.Text = Ventile.Default.CosmeticsVersion;
			Color color = Color.FromArgb(Colors.Default.backColor, Colors.Default.backColor, Colors.Default.backColor);
			Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3);
			Color color1 = Color.FromArgb(Colors.Default.foreColor, Colors.Default.foreColor, Colors.Default.foreColor);
			Color.FromArgb(Colors.Default.outlineColor, Colors.Default.outlineColor, Colors.Default.outlineColor);
			Color.FromArgb(Colors.Default.backColor2, Colors.Default.backColor2, Colors.Default.backColor2);
			Color color2 = Color.FromArgb(Colors.Default.fadedColor, Colors.Default.fadedColor, Colors.Default.fadedColor);
			this.texture.ForeColor = color1;
			this.texture.BackColor = color;
			this.launcher.ForeColor = color1;
			this.launcher.BackColor = color;
			this.client.ForeColor = color1;
			this.client.BackColor = color;
			this.label3.ForeColor = color1;
			this.label3.BackColor = color;
			this.label1.ForeColor = color1;
			this.label1.BackColor = color;
			this.pictureBox1.BackColor = color;
			this.pictureBox2.BackColor = color1;
			this.pictureBox4.BackColor = color;
			this.pictureBox3.BackColor = color;
			this.cosmeticsVLabel.BackColor = color;
			this.cosmeticsVLabel.ForeColor = color2;
			this.launcherVLabel.BackColor = color;
			this.launcherVLabel.ForeColor = color2;
			this.clientVLabel.BackColor = color;
			this.clientVLabel.ForeColor = color2;
			if (Colors.Default.theme == "Dark")
			{
				this.pictureBox3.Image = Resources.transparent_logo_white;
				this.BackgroundImage = Resources.background;
			}
			else if (Colors.Default.theme == "Light")
			{
				this.pictureBox3.Image = Resources.transparent_logo_black;
				this.BackgroundImage = Resources.background2;
			}
			if (Ventile.Default.customImage)
			{
				this.BackgroundImage = new Bitmap(Ventile.Default.customImageLoc);
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

		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(about));
			this.label1 = new Label();
			this.launcher = new Label();
			this.pictureBox1 = new PictureBox();
			this.label2 = new Label();
			this.texture = new Label();
			this.client = new Label();
			this.pictureBox2 = new PictureBox();
			this.label3 = new Label();
			this.pictureBox3 = new PictureBox();
			this.pictureBox4 = new PictureBox();
			this.launcherVLabel = new Label();
			this.clientVLabel = new Label();
			this.cosmeticsVLabel = new Label();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			((ISupportInitialize)this.pictureBox2).BeginInit();
			((ISupportInitialize)this.pictureBox3).BeginInit();
			((ISupportInitialize)this.pictureBox4).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.FromArgb(20, 20, 20);
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(-9, 310);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(664, 168);
			this.label1.TabIndex = 1;
			this.label1.Text = componentResourceManager.GetString("label1.Text");
			this.label1.TextAlign = ContentAlignment.MiddleCenter;
			this.launcher.AutoSize = true;
			this.launcher.BackColor = Color.FromArgb(20, 20, 20);
			this.launcher.Font = new System.Drawing.Font("Segoe UI Semibold", 18f, FontStyle.Bold);
			this.launcher.ForeColor = Color.White;
			this.launcher.Location = new Point(229, 120);
			this.launcher.Name = "launcher";
			this.launcher.Size = new System.Drawing.Size(201, 32);
			this.launcher.TabIndex = 6;
			this.launcher.Text = "Launcher Version";
			this.launcher.TextAlign = ContentAlignment.MiddleCenter;
			this.pictureBox1.BackColor = Color.FromArgb(20, 20, 20);
			this.pictureBox1.Location = new Point(-5, 90);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(660, 246);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.White;
			this.label2.Location = new Point(265, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 47);
			this.label2.TabIndex = 8;
			this.label2.Text = "About";
			this.label2.TextAlign = ContentAlignment.MiddleCenter;
			this.texture.AutoSize = true;
			this.texture.BackColor = Color.FromArgb(20, 20, 20);
			this.texture.Font = new System.Drawing.Font("Segoe UI Semibold", 18f, FontStyle.Bold);
			this.texture.ForeColor = Color.White;
			this.texture.Location = new Point(11, 159);
			this.texture.Name = "texture";
			this.texture.Size = new System.Drawing.Size(210, 32);
			this.texture.TabIndex = 10;
			this.texture.Text = "Cosmetics Version";
			this.texture.TextAlign = ContentAlignment.MiddleCenter;
			this.client.AutoSize = true;
			this.client.BackColor = Color.FromArgb(20, 20, 20);
			this.client.Font = new System.Drawing.Font("Segoe UI Semibold", 18f, FontStyle.Bold);
			this.client.ForeColor = Color.White;
			this.client.Location = new Point(447, 159);
			this.client.Name = "client";
			this.client.Size = new System.Drawing.Size(164, 32);
			this.client.TabIndex = 12;
			this.client.Text = "Client Version";
			this.client.TextAlign = ContentAlignment.MiddleCenter;
			this.pictureBox2.Location = new Point(-5, 297);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(660, 3);
			this.pictureBox2.TabIndex = 13;
			this.pictureBox2.TabStop = false;
			this.label3.AutoSize = true;
			this.label3.BackColor = Color.FromArgb(20, 20, 20);
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label3.ForeColor = Color.White;
			this.label3.Location = new Point(183, 264);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(279, 25);
			this.label3.TabIndex = 14;
			this.label3.Text = "Launcher By: DeathlyBower959";
			this.label3.TextAlign = ContentAlignment.MiddleCenter;
			this.pictureBox3.BackColor = Color.FromArgb(20, 20, 20);
			this.pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
			this.pictureBox3.Image = Resources.transparent_logo_white;
			this.pictureBox3.Location = new Point(588, 414);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(48, 41);
			this.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 15;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new EventHandler(this.pictureBox3_Click);
			this.pictureBox4.BackColor = Color.FromArgb(20, 20, 20);
			this.pictureBox4.Image = Resources.internet;
			this.pictureBox4.Location = new Point(10, 410);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(48, 47);
			this.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 16;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new EventHandler(this.pictureBox4_Click);
			this.launcherVLabel.BackColor = Color.FromArgb(20, 20, 20);
			this.launcherVLabel.Font = new System.Drawing.Font("Segoe UI", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.launcherVLabel.ForeColor = Color.Silver;
			this.launcherVLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.launcherVLabel.Location = new Point(242, 159);
			this.launcherVLabel.Name = "launcherVLabel";
			this.launcherVLabel.Size = new System.Drawing.Size(170, 32);
			this.launcherVLabel.TabIndex = 17;
			this.launcherVLabel.Text = "Version";
			this.launcherVLabel.TextAlign = ContentAlignment.TopCenter;
			this.clientVLabel.BackColor = Color.FromArgb(20, 20, 20);
			this.clientVLabel.Font = new System.Drawing.Font("Segoe UI", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.clientVLabel.ForeColor = Color.Silver;
			this.clientVLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.clientVLabel.Location = new Point(445, 199);
			this.clientVLabel.Name = "clientVLabel";
			this.clientVLabel.Size = new System.Drawing.Size(170, 32);
			this.clientVLabel.TabIndex = 18;
			this.clientVLabel.Text = "Version";
			this.clientVLabel.TextAlign = ContentAlignment.TopCenter;
			this.cosmeticsVLabel.BackColor = Color.FromArgb(20, 20, 20);
			this.cosmeticsVLabel.Font = new System.Drawing.Font("Segoe UI", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cosmeticsVLabel.ForeColor = Color.Silver;
			this.cosmeticsVLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cosmeticsVLabel.Location = new Point(28, 191);
			this.cosmeticsVLabel.Name = "cosmeticsVLabel";
			this.cosmeticsVLabel.Size = new System.Drawing.Size(170, 32);
			this.cosmeticsVLabel.TabIndex = 19;
			this.cosmeticsVLabel.Text = "Version";
			this.cosmeticsVLabel.TextAlign = ContentAlignment.TopCenter;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = Resources.background;
			this.BackgroundImageLayout = ImageLayout.Stretch;
			base.ClientSize = new System.Drawing.Size(645, 464);
			base.Controls.Add(this.cosmeticsVLabel);
			base.Controls.Add(this.clientVLabel);
			base.Controls.Add(this.launcherVLabel);
			base.Controls.Add(this.pictureBox4);
			base.Controls.Add(this.pictureBox3);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.client);
			base.Controls.Add(this.texture);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.launcher);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			this.DoubleBuffered = true;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "about";
			this.Text = "about";
			base.Load += new EventHandler(this.about_Load);
			((ISupportInitialize)this.pictureBox1).EndInit();
			((ISupportInitialize)this.pictureBox2).EndInit();
			((ISupportInitialize)this.pictureBox3).EndInit();
			((ISupportInitialize)this.pictureBox4).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/rgrGyBDrrV");
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			Process.Start("https://sites.google.com/view/ventileclient/");
		}
	}
}