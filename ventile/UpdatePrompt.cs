using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Ventile_Client
{
	public class UpdatePrompt : Form
	{
		private Updater ths;

		private home ths2;

		private IContainer components = null;

		private Label Title;

		private Label text1;

		private Label text2;

		private Guna2Button update;

		private Guna2Button no;

		private Label version;

		public UpdatePrompt(Updater frm, home frm2)
		{
			this.InitializeComponent();
			this.ths = frm;
			this.ths2 = frm2;
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
			this.Title = new Label();
			this.text1 = new Label();
			this.text2 = new Label();
			this.update = new Guna2Button();
			this.no = new Guna2Button();
			this.version = new Label();
			base.SuspendLayout();
			this.Title.AutoSize = true;
			this.Title.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Title.ForeColor = Color.White;
			this.Title.Location = new Point(12, 9);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(136, 21);
			this.Title.TabIndex = 0;
			this.Title.Text = "Update avaliable!";
			this.text1.AutoSize = true;
			this.text1.BackColor = Color.FromArgb(20, 20, 20);
			this.text1.Font = new System.Drawing.Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.text1.ForeColor = Color.Silver;
			this.text1.Location = new Point(12, 40);
			this.text1.Name = "text1";
			this.text1.Size = new System.Drawing.Size(62, 21);
			this.text1.TabIndex = 1;
			this.text1.Text = "Version";
			this.text2.AutoSize = true;
			this.text2.BackColor = Color.FromArgb(20, 20, 20);
			this.text2.Font = new System.Drawing.Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.text2.ForeColor = Color.Silver;
			this.text2.Location = new Point(12, 61);
			this.text2.Name = "text2";
			this.text2.Size = new System.Drawing.Size(173, 63);
			this.text2.TabIndex = 2;
			this.text2.Text = "is avaliable! It is fully \r\noptional to download,\r\nbut is highly suggested.";
			this.update.set_Animated(true);
			this.update.set_AutoRoundedCorners(true);
			this.update.set_BorderRadius(13);
			this.update.get_CheckedState().set_Parent(this.update);
			this.update.get_CustomImages().set_Parent(this.update);
			this.update.set_FillColor(Color.FromArgb(40, 40, 40));
			this.update.Font = new System.Drawing.Font("Segoe UI", 9f);
			this.update.ForeColor = Color.White;
			this.update.get_HoverState().set_Parent(this.update);
			this.update.Location = new Point(115, 187);
			this.update.Name = "update";
			this.update.get_ShadowDecoration().set_Parent(this.update);
			this.update.Size = new System.Drawing.Size(95, 29);
			this.update.TabIndex = 3;
			this.update.Text = "Update!";
			this.update.Click += new EventHandler(this.update_Click);
			this.no.set_Animated(true);
			this.no.set_AutoRoundedCorners(true);
			this.no.set_BorderRadius(13);
			this.no.get_CheckedState().set_Parent(this.no);
			this.no.get_CustomImages().set_Parent(this.no);
			this.no.set_FillColor(Color.FromArgb(40, 40, 40));
			this.no.Font = new System.Drawing.Font("Segoe UI", 9f);
			this.no.ForeColor = Color.White;
			this.no.get_HoverState().set_Parent(this.no);
			this.no.Location = new Point(13, 187);
			this.no.Name = "no";
			this.no.get_ShadowDecoration().set_Parent(this.no);
			this.no.Size = new System.Drawing.Size(93, 29);
			this.no.TabIndex = 4;
			this.no.Text = "No thanks";
			this.no.Click += new EventHandler(this.no_Click);
			this.version.AutoSize = true;
			this.version.BackColor = Color.FromArgb(20, 20, 20);
			this.version.Font = new System.Drawing.Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.version.ForeColor = Color.Silver;
			this.version.Location = new Point(69, 40);
			this.version.Name = "version";
			this.version.Size = new System.Drawing.Size(75, 21);
			this.version.TabIndex = 5;
			this.version.Text = "VERSION";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(20, 20, 20);
			base.ClientSize = new System.Drawing.Size(222, 228);
			base.Controls.Add(this.version);
			base.Controls.Add(this.no);
			base.Controls.Add(this.update);
			base.Controls.Add(this.text2);
			base.Controls.Add(this.text1);
			base.Controls.Add(this.Title);
			this.DoubleBuffered = true;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "UpdatePrompt";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "UpdatePrompt";
			base.TopMost = true;
			base.Load += new EventHandler(this.UpdatePrompt_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void no_Click(object sender, EventArgs e)
		{
			this.ths2.Opacity = 0;
			this.ths.TopMost = false;
			base.TopMost = false;
			this.ths2.TopMost = true;
			this.ths2.TopMost = false;
			for (int i = 0; i < 10; i++)
			{
				home opacity = this.ths2;
				opacity.Opacity = opacity.Opacity + 0.1;
				Thread.Sleep(10);
			}
			this.ths.Close();
			base.Close();
		}

		private void update_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{
					Process.Start("C:\\temp\\Ventile-Updater.exe");
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					MessageBox.Show(string.Concat("Please open installer manually\n   Error: ", exception.Message), "Error");
				}
			}
			finally
			{
				this.ths2.Close();
			}
		}

		private void UpdatePrompt_Load(object sender, EventArgs e)
		{
			string[] strArrays = File.ReadAllLines("C:\\temp\\VentileClient\\Version.txt");
			this.version.Text = strArrays[0];
		}
	}
}