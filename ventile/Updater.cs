using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Ventile_Client.Properties;

namespace Ventile_Client
{
	public class Updater : Form
	{
		private IContainer components = null;

		private PictureBox pictureBox1;

		private Label label1;

		private System.Windows.Forms.Timer fadeIn;

		private System.Windows.Forms.Timer ticker;

		private System.Windows.Forms.Timer fadeOut;

		public Updater()
		{
			this.InitializeComponent();
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

		private void fadeIn_Tick(object sender, EventArgs e)
		{
			if (base.Opacity == 1)
			{
				this.fadeIn.Stop();
			}
			base.Opacity = base.Opacity + 0.1;
		}

		private void fadeOut_Tick(object sender, EventArgs e)
		{
			base.Opacity = base.Opacity - 0.1;
			if (base.Opacity == 0)
			{
				for (int i = 0; i < 25; i++)
				{
					home opacity = home.instance;
					opacity.Opacity = opacity.Opacity + 0.04;
					Thread.Sleep(1);
				}
				base.Close();
			}
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new Label();
			this.fadeIn = new System.Windows.Forms.Timer(this.components);
			this.ticker = new System.Windows.Forms.Timer(this.components);
			this.fadeOut = new System.Windows.Forms.Timer(this.components);
			this.pictureBox1 = new PictureBox();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.label1.Anchor = AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(44, 241);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(195, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "CHECKING FOR UPDATES";
			this.label1.TextAlign = ContentAlignment.MiddleCenter;
			this.fadeIn.Enabled = true;
			this.fadeIn.Interval = 1;
			this.fadeIn.Tick += new EventHandler(this.fadeIn_Tick);
			this.ticker.Enabled = true;
			this.ticker.Interval = 450;
			this.ticker.Tick += new EventHandler(this.ticker_Tick);
			this.fadeOut.Interval = 1;
			this.fadeOut.Tick += new EventHandler(this.fadeOut_Tick);
			this.pictureBox1.Anchor = AnchorStyles.None;
			this.pictureBox1.Image = Resources.transparent_logo_white;
			this.pictureBox1.Location = new Point(69, 80);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(136, 113);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(20, 20, 20);
			base.ClientSize = new System.Drawing.Size(283, 357);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Updater";
			base.Opacity = 0;
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Updater";
			base.TopMost = true;
			base.Load += new EventHandler(this.Updater_Load);
			((ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void ticker_Tick(object sender, EventArgs e)
		{
			Label label = this.label1;
			label.Text = string.Concat(label.Text, ".");
			if (this.label1.Text == "CHECKING FOR UPDATES....")
			{
				this.label1.Text = "CHECKING FOR UPDATES";
			}
		}

		public void Toast(string title, string msg)
		{
			(new Toast()).showToast(title, msg);
		}

		private void Updater_Load(object sender, EventArgs e)
		{
			base.TopMost = false;
			if (!Directory.Exists("C:\\temp"))
			{
				Directory.CreateDirectory("C:\\temp");
			}
			if (!Directory.Exists("C:\\temp\\VentileClient"))
			{
				Directory.CreateDirectory("C:\\temp\\VentileClient");
			}
			this.download("https://github.com/DeathlyBower959/Ventile-Client-Downloads/raw/main/Version.zip", "C:\\temp\\VentileClient", "Version.zip");
			ZipFile.ExtractToDirectory("C:\\temp\\VentileClient\\Version.zip", "C:\\temp\\VentileClient\\");
			if (File.ReadAllLines("C:\\temp\\VentileClient\\Version.txt")[0] == Ventile.Default.Version)
			{
				this.fadeOut.Start();
			}
			else
			{
				(new UpdatePrompt(this, home.instance)).Show();
				home.instance.Opacity = 0;
			}
		}
	}
}