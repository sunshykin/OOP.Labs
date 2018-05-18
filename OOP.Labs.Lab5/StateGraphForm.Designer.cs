namespace OOP.Labs.Lab5
{
	partial class StateGraphForm
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
			this.drawPanel = new DevExpress.XtraEditors.PanelControl();
			((System.ComponentModel.ISupportInitialize)(this.drawPanel)).BeginInit();
			this.SuspendLayout();
			// 
			// drawPanel
			// 
			this.drawPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.drawPanel.Location = new System.Drawing.Point(0, 0);
			this.drawPanel.Name = "drawPanel";
			this.drawPanel.Size = new System.Drawing.Size(450, 342);
			this.drawPanel.TabIndex = 10;
			this.drawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawPanelMouseDown);
			this.drawPanel.MouseEnter += new System.EventHandler(this.DrawPanelOnMouseEnter);
			// 
			// StateGraphForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(450, 342);
			this.Controls.Add(this.drawPanel);
			this.Name = "StateGraphForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Граф состояний";
			this.ResizeEnd += new System.EventHandler(this.OnResizeEnd);
			((System.ComponentModel.ISupportInitialize)(this.drawPanel)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl drawPanel;
	}
}