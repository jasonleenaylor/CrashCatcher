namespace CrashCatcher
{
	partial class DropWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.resultsBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// resultsBox
			// 
			this.resultsBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.resultsBox.Location = new System.Drawing.Point(0, 0);
			this.resultsBox.Multiline = true;
			this.resultsBox.Name = "resultsBox";
			this.resultsBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.resultsBox.Size = new System.Drawing.Size(284, 261);
			this.resultsBox.TabIndex = 0;
			// 
			// DropWindow
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.resultsBox);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DropWindow";
			this.ShowIcon = false;
			this.Text = "Drop Crashing App On Me";
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.DropWindow_DragEnter);
			this.DragLeave += new System.EventHandler(this.DropWindow_DragLeave);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox resultsBox;
	}
}

