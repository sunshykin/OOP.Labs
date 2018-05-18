namespace OOP.Labs.Lab3
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
            this.dimensionSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem2 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.dimensionLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.aCoefMatrixControl = new OOP.Labs.Common.Controls.MatrixControl();
            this.bCoefMatrixControl = new OOP.Labs.Common.Controls.MatrixControl();
            this.cCoefMatrixControl = new OOP.Labs.Common.Controls.MatrixControl();
            this.xValueMatrixControl = new OOP.Labs.Common.Controls.MatrixControl();
            this.secondRootMatrixControl = new OOP.Labs.Common.Controls.MatrixControl();
            this.firstRootMatrixControl = new OOP.Labs.Common.Controls.MatrixControl();
            this.polynomValueMatrixControl = new OOP.Labs.Common.Controls.MatrixControl();
            this.aCoefLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.bCoefLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.cCoefLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.xValueLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCoefLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCoefLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCoefLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xValueLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.aCoefMatrixControl);
            this.layoutControl1.Controls.Add(this.bCoefMatrixControl);
            this.layoutControl1.Controls.Add(this.cCoefMatrixControl);
            this.layoutControl1.Controls.Add(this.xValueMatrixControl);
            this.layoutControl1.Controls.Add(this.secondRootMatrixControl);
            this.layoutControl1.Controls.Add(this.firstRootMatrixControl);
            this.layoutControl1.Controls.Add(this.polynomValueMatrixControl);
            this.layoutControl1.Controls.Add(this.dimensionSpinEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1070, 129, 650, 548);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(618, 579);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dimensionSpinEdit
            // 
            this.dimensionSpinEdit.EditValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.dimensionSpinEdit.Location = new System.Drawing.Point(47, 42);
            this.dimensionSpinEdit.Name = "dimensionSpinEdit";
            this.dimensionSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dimensionSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dimensionSpinEdit.Properties.IsFloatValue = false;
            this.dimensionSpinEdit.Properties.Mask.EditMask = "N00";
            this.dimensionSpinEdit.Properties.MaxValue = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.dimensionSpinEdit.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dimensionSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dimensionSpinEdit.Size = new System.Drawing.Size(53, 20);
            this.dimensionSpinEdit.StyleController = this.layoutControl1;
            this.dimensionSpinEdit.TabIndex = 11;
            this.dimensionSpinEdit.EditValueChanged += new System.EventHandler(this.DimensionChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlGroup4,
            this.layoutControlGroup5});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(618, 579);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.aCoefLayout,
            this.simpleLabelItem1,
            this.bCoefLayout,
            this.simpleLabelItem2,
            this.cCoefLayout,
            this.xValueLayout,
            this.emptySpaceItem2,
            this.emptySpaceItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 66);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(598, 229);
            this.layoutControlGroup2.Text = "Уравнение";
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.simpleLabelItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleLabelItem1.Location = new System.Drawing.Point(149, 0);
            this.simpleLabelItem1.MaxSize = new System.Drawing.Size(54, 0);
            this.simpleLabelItem1.MinSize = new System.Drawing.Size(54, 17);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(54, 91);
            this.simpleLabelItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.simpleLabelItem1.Text = "X^2 + ";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(50, 13);
            // 
            // simpleLabelItem2
            // 
            this.simpleLabelItem2.AllowHotTrack = false;
            this.simpleLabelItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.simpleLabelItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleLabelItem2.Location = new System.Drawing.Point(346, 0);
            this.simpleLabelItem2.MaxSize = new System.Drawing.Size(54, 0);
            this.simpleLabelItem2.MinSize = new System.Drawing.Size(54, 17);
            this.simpleLabelItem2.Name = "simpleLabelItem2";
            this.simpleLabelItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.simpleLabelItem2.Size = new System.Drawing.Size(54, 91);
            this.simpleLabelItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.simpleLabelItem2.Text = "X + ";
            this.simpleLabelItem2.TextSize = new System.Drawing.Size(50, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(201, 101);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(373, 86);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 91);
            this.emptySpaceItem3.MaxSize = new System.Drawing.Size(443, 10);
            this.emptySpaceItem3.MinSize = new System.Drawing.Size(443, 10);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(574, 10);
            this.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlItem5});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 295);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(598, 132);
            this.layoutControlGroup3.Text = "Корни";
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.emptySpaceItem4});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 427);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(598, 132);
            this.layoutControlGroup4.Text = "Значение";
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(289, 0);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(285, 90);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.dimensionLayout,
            this.emptySpaceItem5});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(598, 66);
            this.layoutControlGroup5.Text = "Размерность";
            // 
            // dimensionLayout
            // 
            this.dimensionLayout.Control = this.dimensionSpinEdit;
            this.dimensionLayout.Location = new System.Drawing.Point(0, 0);
            this.dimensionLayout.MaxSize = new System.Drawing.Size(80, 24);
            this.dimensionLayout.MinSize = new System.Drawing.Size(80, 24);
            this.dimensionLayout.Name = "dimensionLayout";
            this.dimensionLayout.Size = new System.Drawing.Size(80, 24);
            this.dimensionLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.dimensionLayout.Text = "N =";
            this.dimensionLayout.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.dimensionLayout.TextSize = new System.Drawing.Size(18, 13);
            this.dimensionLayout.TextToControlDistance = 5;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(80, 0);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(494, 24);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // aCoefMatrixControl
            // 
            this.aCoefMatrixControl.Location = new System.Drawing.Point(24, 108);
            this.aCoefMatrixControl.Name = "aCoefMatrixControl";
            this.aCoefMatrixControl.Size = new System.Drawing.Size(145, 87);
            this.aCoefMatrixControl.TabIndex = 12;
            // 
            // bCoefMatrixControl
            // 
            this.bCoefMatrixControl.Location = new System.Drawing.Point(227, 108);
            this.bCoefMatrixControl.Name = "bCoefMatrixControl";
            this.bCoefMatrixControl.Size = new System.Drawing.Size(139, 87);
            this.bCoefMatrixControl.TabIndex = 12;
            // 
            // cCoefMatrixControl
            // 
            this.cCoefMatrixControl.Location = new System.Drawing.Point(424, 108);
            this.cCoefMatrixControl.Name = "cCoefMatrixControl";
            this.cCoefMatrixControl.Size = new System.Drawing.Size(170, 87);
            this.cCoefMatrixControl.TabIndex = 12;
            // 
            // xValueMatrixControl
            // 
            this.xValueMatrixControl.Location = new System.Drawing.Point(46, 209);
            this.xValueMatrixControl.Name = "xValueMatrixControl";
            this.xValueMatrixControl.Size = new System.Drawing.Size(175, 82);
            this.xValueMatrixControl.TabIndex = 12;
            // 
            // secondRootMatrixControl
            // 
            this.secondRootMatrixControl.Location = new System.Drawing.Point(363, 337);
            this.secondRootMatrixControl.Name = "secondRootMatrixControl";
            this.secondRootMatrixControl.Size = new System.Drawing.Size(231, 86);
            this.secondRootMatrixControl.TabIndex = 12;
            // 
            // firstRootMatrixControl
            // 
            this.firstRootMatrixControl.Location = new System.Drawing.Point(77, 337);
            this.firstRootMatrixControl.Name = "firstRootMatrixControl";
            this.firstRootMatrixControl.Size = new System.Drawing.Size(229, 86);
            this.firstRootMatrixControl.TabIndex = 12;
            // 
            // polynomValueMatrixControl
            // 
            this.polynomValueMatrixControl.Location = new System.Drawing.Point(60, 469);
            this.polynomValueMatrixControl.Name = "polynomValueMatrixControl";
            this.polynomValueMatrixControl.Size = new System.Drawing.Size(249, 86);
            this.polynomValueMatrixControl.TabIndex = 12;
            // 
            // aCoefLayout
            // 
            this.aCoefLayout.Control = this.aCoefMatrixControl;
            this.aCoefLayout.Location = new System.Drawing.Point(0, 0);
            this.aCoefLayout.MinSize = new System.Drawing.Size(104, 24);
            this.aCoefLayout.Name = "aCoefLayout";
            this.aCoefLayout.Size = new System.Drawing.Size(149, 91);
            this.aCoefLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.aCoefLayout.TextSize = new System.Drawing.Size(0, 0);
            this.aCoefLayout.TextVisible = false;
            // 
            // bCoefLayout
            // 
            this.bCoefLayout.Control = this.bCoefMatrixControl;
            this.bCoefLayout.Location = new System.Drawing.Point(203, 0);
            this.bCoefLayout.MinSize = new System.Drawing.Size(104, 24);
            this.bCoefLayout.Name = "bCoefLayout";
            this.bCoefLayout.Size = new System.Drawing.Size(143, 91);
            this.bCoefLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.bCoefLayout.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.bCoefLayout.TextSize = new System.Drawing.Size(0, 0);
            this.bCoefLayout.TextToControlDistance = 0;
            this.bCoefLayout.TextVisible = false;
            // 
            // cCoefLayout
            // 
            this.cCoefLayout.Control = this.cCoefMatrixControl;
            this.cCoefLayout.Location = new System.Drawing.Point(400, 0);
            this.cCoefLayout.MinSize = new System.Drawing.Size(104, 24);
            this.cCoefLayout.Name = "cCoefLayout";
            this.cCoefLayout.Size = new System.Drawing.Size(174, 91);
            this.cCoefLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.cCoefLayout.TextSize = new System.Drawing.Size(0, 0);
            this.cCoefLayout.TextVisible = false;
            // 
            // xValueLayout
            // 
            this.xValueLayout.Control = this.xValueMatrixControl;
            this.xValueLayout.Location = new System.Drawing.Point(0, 101);
            this.xValueLayout.MinSize = new System.Drawing.Size(126, 24);
            this.xValueLayout.Name = "xValueLayout";
            this.xValueLayout.Size = new System.Drawing.Size(201, 86);
            this.xValueLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.xValueLayout.Text = "X =";
            this.xValueLayout.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.xValueLayout.TextSize = new System.Drawing.Size(17, 13);
            this.xValueLayout.TextToControlDistance = 5;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.secondRootMatrixControl;
            this.layoutControlItem6.Location = new System.Drawing.Point(286, 0);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(157, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(288, 90);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "Корень 2:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(50, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.firstRootMatrixControl;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(157, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(286, 90);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "Корень 1:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(50, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.polynomValueMatrixControl;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(289, 90);
            this.layoutControlItem7.Text = "P(X) =";
            this.layoutControlItem7.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(31, 13);
            this.layoutControlItem7.TextToControlDistance = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 579);
            this.Controls.Add(this.layoutControl1);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа по ООП №3";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dimensionSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCoefLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCoefLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCoefLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xValueLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
		private DevExpress.XtraLayout.LayoutControlItem aCoefLayout;
		private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
		private DevExpress.XtraLayout.LayoutControlItem bCoefLayout;
		private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem2;
		private DevExpress.XtraLayout.LayoutControlItem cCoefLayout;
		private DevExpress.XtraLayout.LayoutControlItem xValueLayout;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
		private DevExpress.XtraEditors.SpinEdit dimensionSpinEdit;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
		private DevExpress.XtraLayout.LayoutControlItem dimensionLayout;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
		private Common.Controls.MatrixControl aCoefMatrixControl;
		private Common.Controls.MatrixControl bCoefMatrixControl;
		private Common.Controls.MatrixControl cCoefMatrixControl;
		private Common.Controls.MatrixControl xValueMatrixControl;
		private Common.Controls.MatrixControl secondRootMatrixControl;
		private Common.Controls.MatrixControl firstRootMatrixControl;
		private Common.Controls.MatrixControl polynomValueMatrixControl;
	}
}

