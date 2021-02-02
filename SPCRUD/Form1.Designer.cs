﻿
namespace SPCRUD {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.btnRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.dgvEmp = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
			this.textBoxEmp1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.textBoxCity1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.textBoxDept1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.comboBoxGen1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
			this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.EmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.comboBoxGen1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(197, 222);
			this.btnSave.Name = "btnSave";
			this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnSave.Size = new System.Drawing.Size(105, 45);
			this.btnSave.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
			this.btnSave.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopRight;
			this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.TabIndex = 13;
			this.btnSave.Values.Image = global::SPCRUD.Properties.Resources.menu_add_line;
			this.btnSave.Values.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(313, 222);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnRefresh.Size = new System.Drawing.Size(105, 45);
			this.btnRefresh.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
			this.btnRefresh.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopRight;
			this.btnRefresh.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRefresh.TabIndex = 14;
			this.btnRefresh.Values.Image = global::SPCRUD.Properties.Resources.refresh_line__1_;
			this.btnRefresh.Values.Text = "Refresh";
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Enabled = false;
			this.btnDelete.Location = new System.Drawing.Point(426, 222);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnDelete.Size = new System.Drawing.Size(105, 45);
			this.btnDelete.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
			this.btnDelete.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopRight;
			this.btnDelete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.TabIndex = 15;
			this.btnDelete.Values.Image = global::SPCRUD.Properties.Resources.delete_bin_5_line__1_;
			this.btnDelete.Values.Text = "Delete";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// dgvEmp
			// 
			this.dgvEmp.AllowUserToAddRows = false;
			this.dgvEmp.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dgvEmp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvEmp.ColumnHeadersHeight = 40;
			this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpId,
            this.EmployeeName,
            this.City,
            this.Department,
            this.Gender});
			this.dgvEmp.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dgvEmp.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
			this.dgvEmp.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
			this.dgvEmp.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
			this.dgvEmp.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
			this.dgvEmp.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
			this.dgvEmp.Location = new System.Drawing.Point(28, 276);
			this.dgvEmp.MultiSelect = false;
			this.dgvEmp.Name = "dgvEmp";
			this.dgvEmp.ReadOnly = true;
			this.dgvEmp.RowHeadersVisible = false;
			this.dgvEmp.RowHeadersWidth = 50;
			this.dgvEmp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dgvEmp.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvEmp.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dgvEmp.RowTemplate.Height = 25;
			this.dgvEmp.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvEmp.Size = new System.Drawing.Size(503, 242);
			this.dgvEmp.TabIndex = 16;
			this.dgvEmp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmp_CellClick);
			this.dgvEmp.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEmp_CellFormatting);
			// 
			// textBoxEmp1
			// 
			this.textBoxEmp1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBoxEmp1.Location = new System.Drawing.Point(197, 28);
			this.textBoxEmp1.Name = "textBoxEmp1";
			this.textBoxEmp1.Size = new System.Drawing.Size(334, 29);
			this.textBoxEmp1.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxEmp1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4);
			this.textBoxEmp1.TabIndex = 17;
			// 
			// kryptonLabel1
			// 
			this.kryptonLabel1.Location = new System.Drawing.Point(28, 31);
			this.kryptonLabel1.Name = "kryptonLabel1";
			this.kryptonLabel1.Size = new System.Drawing.Size(167, 26);
			this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kryptonLabel1.TabIndex = 21;
			this.kryptonLabel1.Values.Image = global::SPCRUD.Properties.Resources.user_3_fill__2_;
			this.kryptonLabel1.Values.Text = "Employee Name :";
			// 
			// kryptonLabel2
			// 
			this.kryptonLabel2.Location = new System.Drawing.Point(28, 75);
			this.kryptonLabel2.Name = "kryptonLabel2";
			this.kryptonLabel2.Size = new System.Drawing.Size(134, 26);
			this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kryptonLabel2.TabIndex = 23;
			this.kryptonLabel2.Values.Image = global::SPCRUD.Properties.Resources.community_fill;
			this.kryptonLabel2.Values.Text = "Current City :";
			// 
			// textBoxCity1
			// 
			this.textBoxCity1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBoxCity1.Location = new System.Drawing.Point(197, 72);
			this.textBoxCity1.Name = "textBoxCity1";
			this.textBoxCity1.Size = new System.Drawing.Size(334, 29);
			this.textBoxCity1.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCity1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4);
			this.textBoxCity1.TabIndex = 22;
			// 
			// kryptonLabel3
			// 
			this.kryptonLabel3.Location = new System.Drawing.Point(28, 119);
			this.kryptonLabel3.Name = "kryptonLabel3";
			this.kryptonLabel3.Size = new System.Drawing.Size(132, 26);
			this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kryptonLabel3.TabIndex = 25;
			this.kryptonLabel3.Values.Image = global::SPCRUD.Properties.Resources.honour_fill;
			this.kryptonLabel3.Values.Text = "Department :";
			// 
			// textBoxDept1
			// 
			this.textBoxDept1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBoxDept1.Location = new System.Drawing.Point(197, 116);
			this.textBoxDept1.Name = "textBoxDept1";
			this.textBoxDept1.Size = new System.Drawing.Size(334, 29);
			this.textBoxDept1.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxDept1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4);
			this.textBoxDept1.TabIndex = 24;
			// 
			// kryptonLabel4
			// 
			this.kryptonLabel4.Location = new System.Drawing.Point(30, 169);
			this.kryptonLabel4.Name = "kryptonLabel4";
			this.kryptonLabel4.Size = new System.Drawing.Size(101, 26);
			this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kryptonLabel4.TabIndex = 26;
			this.kryptonLabel4.Values.Image = global::SPCRUD.Properties.Resources.parent_fill;
			this.kryptonLabel4.Values.Text = "Gender :";
			// 
			// comboBoxGen1
			// 
			this.comboBoxGen1.DropDownWidth = 334;
			this.comboBoxGen1.Items.AddRange(new object[] {
            "Male",
            "Female"});
			this.comboBoxGen1.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Command;
			this.comboBoxGen1.Location = new System.Drawing.Point(197, 166);
			this.comboBoxGen1.Name = "comboBoxGen1";
			this.comboBoxGen1.Size = new System.Drawing.Size(334, 29);
			this.comboBoxGen1.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxGen1.StateActive.ComboBox.Content.Padding = new System.Windows.Forms.Padding(50, 1, 1, 1);
			this.comboBoxGen1.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxGen1.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(50, 5, 5, 5);
			this.comboBoxGen1.StateCommon.Item.Content.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.comboBoxGen1.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxGen1.StateNormal.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxGen1.StateNormal.ComboBox.Content.Padding = new System.Windows.Forms.Padding(50, 5, 5, 5);
			this.comboBoxGen1.TabIndex = 27;
			// 
			// kryptonLabel5
			// 
			this.kryptonLabel5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
			this.kryptonLabel5.Location = new System.Drawing.Point(37, 223);
			this.kryptonLabel5.Name = "kryptonLabel5";
			this.kryptonLabel5.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
			this.kryptonLabel5.Size = new System.Drawing.Size(122, 21);
			this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.DarkSlateGray;
			this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kryptonLabel5.TabIndex = 28;
			this.kryptonLabel5.Values.Text = "Stored Procedures";
			// 
			// kryptonLabel6
			// 
			this.kryptonLabel6.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
			this.kryptonLabel6.Location = new System.Drawing.Point(49, 240);
			this.kryptonLabel6.Name = "kryptonLabel6";
			this.kryptonLabel6.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
			this.kryptonLabel6.Size = new System.Drawing.Size(89, 30);
			this.kryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.DarkSlateGray;
			this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kryptonLabel6.TabIndex = 29;
			this.kryptonLabel6.Values.Text = "C R U D";
			// 
			// kryptonLabel7
			// 
			this.kryptonLabel7.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
			this.kryptonLabel7.Location = new System.Drawing.Point(49, 196);
			this.kryptonLabel7.Name = "kryptonLabel7";
			this.kryptonLabel7.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
			this.kryptonLabel7.Size = new System.Drawing.Size(6, 4);
			this.kryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.DarkSlateGray;
			this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kryptonLabel7.TabIndex = 30;
			this.kryptonLabel7.Values.Text = "";
			// 
			// EmpId
			// 
			this.EmpId.HeaderText = "Employee Id";
			this.EmpId.Name = "EmpId";
			this.EmpId.ReadOnly = true;
			// 
			// EmployeeName
			// 
			this.EmployeeName.HeaderText = "Name";
			this.EmployeeName.Name = "EmployeeName";
			this.EmployeeName.ReadOnly = true;
			// 
			// City
			// 
			this.City.HeaderText = "City";
			this.City.Name = "City";
			this.City.ReadOnly = true;
			// 
			// Department
			// 
			this.Department.HeaderText = "Department";
			this.Department.Name = "Department";
			this.Department.ReadOnly = true;
			// 
			// Gender
			// 
			this.Gender.HeaderText = "Gender";
			this.Gender.Name = "Gender";
			this.Gender.ReadOnly = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(563, 545);
			this.Controls.Add(this.kryptonLabel7);
			this.Controls.Add(this.kryptonLabel6);
			this.Controls.Add(this.kryptonLabel5);
			this.Controls.Add(this.comboBoxGen1);
			this.Controls.Add(this.kryptonLabel4);
			this.Controls.Add(this.kryptonLabel3);
			this.Controls.Add(this.textBoxDept1);
			this.Controls.Add(this.kryptonLabel2);
			this.Controls.Add(this.textBoxCity1);
			this.Controls.Add(this.kryptonLabel1);
			this.Controls.Add(this.textBoxEmp1);
			this.Controls.Add(this.dgvEmp);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnSave);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.comboBoxGen1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRefresh;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvEmp;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxEmp1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxCity1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxDept1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboBoxGen1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
		private System.Windows.Forms.DataGridViewTextBoxColumn EmpId;
		private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
		private System.Windows.Forms.DataGridViewTextBoxColumn City;
		private System.Windows.Forms.DataGridViewTextBoxColumn Department;
		private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
	}
}

