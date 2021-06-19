using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Ventile_Client.Properties;

namespace Ventile_Client
{
	public class Toast : Form
	{
		private Toast.enmAction action;

		private int x;

		private int y;

		private IContainer components = null;

		private Timer timer1;

		private Label message;

		private Label title;

		public Toast()
		{
			this.InitializeComponent();
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Region = System.Drawing.Region.FromHrgn(Toast.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

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

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Toast));
			this.timer1 = new Timer(this.components);
			this.message = new Label();
			this.title = new Label();
			base.SuspendLayout();
			this.timer1.Tick += new EventHandler(this.timer1_Tick);
			this.message.AutoSize = true;
			this.message.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.message.ForeColor = Color.FromArgb(64, 64, 64);
			this.message.Location = new Point(34, 35);
			this.message.Name = "message";
			this.message.Size = new System.Drawing.Size(96, 25);
			this.message.TabIndex = 0;
			this.message.Text = "MESSAGE";
			this.title.AutoSize = true;
			this.title.BackColor = Color.Transparent;
			this.title.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75f, FontStyle.Bold);
			this.title.ForeColor = Color.Black;
			this.title.Location = new Point(10, 3);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(64, 30);
			this.title.TabIndex = 1;
			this.title.Text = "TITLE";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.White;
			base.ClientSize = new System.Drawing.Size(395, 81);
			base.Controls.Add(this.title);
			base.Controls.Add(this.message);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Toast";
			base.ShowInTaskbar = false;
			this.Text = "Toast";
			base.TopMost = true;
			base.Load += new EventHandler(this.Toast_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		public void showToast(string title, string msg)
		{
			Rectangle workingArea;
			if (Ventile.Default.Toasts)
			{
				base.Opacity = 0;
				base.StartPosition = FormStartPosition.Manual;
				int num = 0;
				while (num < 10)
				{
					string str = string.Concat("toast", num.ToString());
					if ((Toast)Application.OpenForms[str] != null)
					{
						num++;
					}
					else
					{
						base.Name = str;
						workingArea = Screen.PrimaryScreen.WorkingArea;
						this.x = workingArea.Width - base.Width + 15;
						this.y = 7 + (base.Height + 3) * num;
						base.Location = new Point(this.x, this.y);
						break;
					}
				}
				workingArea = Screen.PrimaryScreen.WorkingArea;
				this.x = workingArea.Width - base.Width - 5;
				this.message.Text = msg;
				this.title.Text = title;
				base.Show();
				this.action = Toast.enmAction.start;
				this.timer1.Interval = 1;
				this.timer1.Start();
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			switch (this.action)
			{
				case Toast.enmAction.wait:
				{
					this.timer1.Interval = 3250;
					this.action = Toast.enmAction.close;
					break;
				}
				case Toast.enmAction.start:
				{
					this.timer1.Interval = 1;
					base.Opacity = base.Opacity + 0.1;
					if (this.x < base.Location.X)
					{
						base.Left = base.Left - 1;
					}
					else if (base.Opacity == 1)
					{
						this.action = Toast.enmAction.wait;
					}
					break;
				}
				case Toast.enmAction.close:
				{
					this.timer1.Interval = 1;
					base.Opacity = base.Opacity - 0.1;
					base.Left = base.Left - 3;
					if (base.Opacity == 0)
					{
						base.Close();
					}
					break;
				}
			}
		}

		private void Toast_Load(object sender, EventArgs e)
		{
			this.BackColor = Color.FromArgb(Colors.Default.accentColor1, Colors.Default.accentColor2, Colors.Default.accentColor3);
			if (Colors.Default.theme == "Dark")
			{
				this.title.ForeColor = Color.FromArgb(Colors.Default.foreColor, Colors.Default.foreColor, Colors.Default.foreColor);
				this.message.ForeColor = Color.FromArgb(Colors.Default.foreColor, Colors.Default.foreColor, Colors.Default.foreColor);
			}
			else if (Colors.Default.theme == "Light")
			{
				this.title.ForeColor = Color.FromArgb(Colors.Default.foreColor, Colors.Default.foreColor, Colors.Default.foreColor);
				this.message.ForeColor = Color.FromArgb(Colors.Default.foreColor, Colors.Default.foreColor, Colors.Default.foreColor);
			}
		}

		public enum enmAction
		{
			wait,
			start,
			close
		}
	}
}