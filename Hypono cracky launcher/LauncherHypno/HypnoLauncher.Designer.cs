namespace LauncherHypno
{
	// Token: 0x02000002 RID: 2
	public partial class HypnoLauncher : global::System.Windows.Forms.Form
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002122 File Offset: 0x00000322
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002144 File Offset: 0x00000344
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::LauncherHypno.HypnoLauncher));
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.button1.BackgroundImage = global::LauncherHypno.Properties.Resources.Unbenannt_2;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.249999f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(348, 287);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(156, 46);
			this.button1.TabIndex = 0;
			this.button1.Text = "Inject";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.BackColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			this.button2.BackgroundImage = global::LauncherHypno.Properties.Resources.Unbenannt_2;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = global::System.Drawing.Color.BlueViolet;
			this.button2.ImageAlign = global::System.Drawing.ContentAlignment.TopCenter;
			this.button2.Location = new global::System.Drawing.Point(12, 12);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(66, 27);
			this.button2.TabIndex = 2;
			this.button2.Text = "Discord";
			this.button2.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button3.BackColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			this.button3.BackgroundImage = global::LauncherHypno.Properties.Resources.Unbenannt_2;
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button3.ForeColor = global::System.Drawing.Color.BlueViolet;
			this.button3.ImageAlign = global::System.Drawing.ContentAlignment.TopCenter;
			this.button3.Location = new global::System.Drawing.Point(765, 12);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(66, 27);
			this.button3.TabIndex = 3;
			this.button3.Text = "Website";
			this.button3.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::LauncherHypno.Properties.Resources.Unbenannt_51;
			base.ClientSize = new global::System.Drawing.Size(843, 500);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(859, 539);
			this.MinimumSize = new global::System.Drawing.Size(859, 539);
			base.Name = "HypnoLauncher";
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "HypnoLauncher";
			base.ResumeLayout(false);
		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000002 RID: 2
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Button button3;
	}
}
