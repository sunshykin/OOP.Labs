namespace OOP.Labs.Lab4
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.drawPanel = new DevExpress.XtraEditors.PanelControl();
            this.adjacencyTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.vertexTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.adjacencySimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.vertexSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.fileLoadDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjacencyTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertexTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.drawPanel);
            this.layoutControl1.Controls.Add(this.adjacencyTextEdit);
            this.layoutControl1.Controls.Add(this.vertexTextEdit);
            this.layoutControl1.Controls.Add(this.adjacencySimpleButton);
            this.layoutControl1.Controls.Add(this.vertexSimpleButton);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(935, 217, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(631, 425);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // drawPanel
            // 
            this.drawPanel.Location = new System.Drawing.Point(12, 64);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(607, 349);
            this.drawPanel.TabIndex = 8;
            // 
            // adjacencyTextEdit
            // 
            this.adjacencyTextEdit.Location = new System.Drawing.Point(138, 12);
            this.adjacencyTextEdit.Name = "adjacencyTextEdit";
            this.adjacencyTextEdit.Size = new System.Drawing.Size(360, 20);
            this.adjacencyTextEdit.StyleController = this.layoutControl1;
            this.adjacencyTextEdit.TabIndex = 4;
            // 
            // vertexTextEdit
            // 
            this.vertexTextEdit.Location = new System.Drawing.Point(138, 38);
            this.vertexTextEdit.Name = "vertexTextEdit";
            this.vertexTextEdit.Size = new System.Drawing.Size(360, 20);
            this.vertexTextEdit.StyleController = this.layoutControl1;
            this.vertexTextEdit.TabIndex = 5;
            // 
            // adjacencySimpleButton
            // 
            this.adjacencySimpleButton.Location = new System.Drawing.Point(502, 12);
            this.adjacencySimpleButton.Name = "adjacencySimpleButton";
            this.adjacencySimpleButton.Size = new System.Drawing.Size(117, 22);
            this.adjacencySimpleButton.StyleController = this.layoutControl1;
            this.adjacencySimpleButton.TabIndex = 6;
            this.adjacencySimpleButton.Text = "Загрузить файл";
            this.adjacencySimpleButton.Click += new System.EventHandler(this.Adjacency_LoadClick);
            // 
            // vertexSimpleButton
            // 
            this.vertexSimpleButton.Location = new System.Drawing.Point(502, 38);
            this.vertexSimpleButton.Name = "vertexSimpleButton";
            this.vertexSimpleButton.Size = new System.Drawing.Size(117, 22);
            this.vertexSimpleButton.StyleController = this.layoutControl1;
            this.vertexSimpleButton.TabIndex = 7;
            this.vertexSimpleButton.Text = "Загрузить файл";
            this.vertexSimpleButton.Click += new System.EventHandler(this.Vertex_LoadClick);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(631, 425);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.adjacencyTextEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(490, 26);
            this.layoutControlItem1.Text = "Матрица смежности:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(123, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.vertexTextEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(490, 26);
            this.layoutControlItem2.Text = "Матрица вершин графа:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(123, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.adjacencySimpleButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(490, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(121, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.vertexSimpleButton;
            this.layoutControlItem4.Location = new System.Drawing.Point(490, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(121, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.drawPanel;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(611, 353);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 425);
            this.Controls.Add(this.layoutControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа по ООП №4";
            this.ResizeEnd += new System.EventHandler(this.ResizeEnded);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drawPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjacencyTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertexTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraEditors.TextEdit adjacencyTextEdit;
		private DevExpress.XtraEditors.TextEdit vertexTextEdit;
		private DevExpress.XtraEditors.SimpleButton adjacencySimpleButton;
		private DevExpress.XtraEditors.SimpleButton vertexSimpleButton;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private System.Windows.Forms.OpenFileDialog fileLoadDialog;
		private DevExpress.XtraEditors.PanelControl drawPanel;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
	}
}

