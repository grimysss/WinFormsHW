namespace test__wf1
{
	partial class Form1
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
			if(disposing && (components != null))
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
			this._txtName = new System.Windows.Forms.Label();
			this._txtEnterName = new System.Windows.Forms.TextBox();
			this._txtEnterLastName = new System.Windows.Forms.TextBox();
			this._txtLastName = new System.Windows.Forms.Label();
			this._rdiGender1 = new System.Windows.Forms.RadioButton();
			this._rdiGender2 = new System.Windows.Forms.RadioButton();
			this._txtCompetence1 = new System.Windows.Forms.Label();
			this._txtCompetence2 = new System.Windows.Forms.Label();
			this._txtCompetence3 = new System.Windows.Forms.Label();
			this._chkCompetence1 = new System.Windows.Forms.CheckBox();
			this._chkCompetence2 = new System.Windows.Forms.CheckBox();
			this._chkCompetence3 = new System.Windows.Forms.CheckBox();
			this._txtCompetenceLevel1 = new System.Windows.Forms.Label();
			this._cmbEnterCompetenceLevel1 = new System.Windows.Forms.ComboBox();
			this._cmbEnterCompetenceLevel2 = new System.Windows.Forms.ComboBox();
			this._txtCompetenceLevel2 = new System.Windows.Forms.Label();
			this._cmbEnterCompetenceLevel3 = new System.Windows.Forms.ComboBox();
			this._txtCompetenceLevel3 = new System.Windows.Forms.Label();
			this._txtPosition = new System.Windows.Forms.Label();
			this._cmbEnterPosition = new System.Windows.Forms.ComboBox();
			this._grpMain = new System.Windows.Forms.GroupBox();
			this._btnSave = new System.Windows.Forms.Button();
			this._dataGridView = new System.Windows.Forms.DataGridView();
			this._grpMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// _txtName
			// 
			this._txtName.AutoSize = true;
			this._txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtName.Location = new System.Drawing.Point(29, 47);
			this._txtName.Name = "_txtName";
			this._txtName.Size = new System.Drawing.Size(34, 16);
			this._txtName.TabIndex = 0;
			this._txtName.Text = "Имя";
			this._txtName.Click += new System.EventHandler(this.label1_Click);
			// 
			// _txtEnterName
			// 
			this._txtEnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtEnterName.Location = new System.Drawing.Point(121, 44);
			this._txtEnterName.Name = "_txtEnterName";
			this._txtEnterName.Size = new System.Drawing.Size(187, 22);
			this._txtEnterName.TabIndex = 1;
			this._txtEnterName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this._txtEnterName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtEnterName_KeyPress);
			// 
			// _txtEnterLastName
			// 
			this._txtEnterLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtEnterLastName.Location = new System.Drawing.Point(121, 78);
			this._txtEnterLastName.Name = "_txtEnterLastName";
			this._txtEnterLastName.Size = new System.Drawing.Size(187, 22);
			this._txtEnterLastName.TabIndex = 3;
			this._txtEnterLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtEnterLastName_KeyPress);
			// 
			// _txtLastName
			// 
			this._txtLastName.AutoSize = true;
			this._txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtLastName.Location = new System.Drawing.Point(29, 81);
			this._txtLastName.Name = "_txtLastName";
			this._txtLastName.Size = new System.Drawing.Size(67, 16);
			this._txtLastName.TabIndex = 2;
			this._txtLastName.Text = "Фамилия";
			// 
			// _rdiGender1
			// 
			this._rdiGender1.AutoSize = true;
			this._rdiGender1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._rdiGender1.Location = new System.Drawing.Point(32, 130);
			this._rdiGender1.Name = "_rdiGender1";
			this._rdiGender1.Size = new System.Drawing.Size(54, 20);
			this._rdiGender1.TabIndex = 5;
			this._rdiGender1.TabStop = true;
			this._rdiGender1.Text = "Муж";
			this._rdiGender1.UseVisualStyleBackColor = true;
			// 
			// _rdiGender2
			// 
			this._rdiGender2.AutoSize = true;
			this._rdiGender2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._rdiGender2.Location = new System.Drawing.Point(121, 130);
			this._rdiGender2.Name = "_rdiGender2";
			this._rdiGender2.Size = new System.Drawing.Size(55, 20);
			this._rdiGender2.TabIndex = 5;
			this._rdiGender2.TabStop = true;
			this._rdiGender2.Text = "Жен";
			this._rdiGender2.UseVisualStyleBackColor = true;
			// 
			// _txtCompetence1
			// 
			this._txtCompetence1.AutoSize = true;
			this._txtCompetence1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtCompetence1.Location = new System.Drawing.Point(29, 180);
			this._txtCompetence1.Name = "_txtCompetence1";
			this._txtCompetence1.Size = new System.Drawing.Size(130, 16);
			this._txtCompetence1.TabIndex = 1;
			this._txtCompetence1.Text = "Лидерские навыки";
			// 
			// _txtCompetence2
			// 
			this._txtCompetence2.AutoSize = true;
			this._txtCompetence2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtCompetence2.Location = new System.Drawing.Point(29, 204);
			this._txtCompetence2.Name = "_txtCompetence2";
			this._txtCompetence2.Size = new System.Drawing.Size(192, 16);
			this._txtCompetence2.TabIndex = 2;
			this._txtCompetence2.Text = "Умение работать в команде";
			// 
			// _txtCompetence3
			// 
			this._txtCompetence3.AutoSize = true;
			this._txtCompetence3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtCompetence3.Location = new System.Drawing.Point(29, 226);
			this._txtCompetence3.Name = "_txtCompetence3";
			this._txtCompetence3.Size = new System.Drawing.Size(153, 16);
			this._txtCompetence3.TabIndex = 3;
			this._txtCompetence3.Text = "Стрессоустойчивость";
			this._txtCompetence3.Click += new System.EventHandler(this._txtCompetence3_Click);
			// 
			// _chkCompetence1
			// 
			this._chkCompetence1.AutoSize = true;
			this._chkCompetence1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._chkCompetence1.Location = new System.Drawing.Point(293, 180);
			this._chkCompetence1.Name = "_chkCompetence1";
			this._chkCompetence1.Size = new System.Drawing.Size(15, 14);
			this._chkCompetence1.TabIndex = 1;
			this._chkCompetence1.UseVisualStyleBackColor = true;
			this._chkCompetence1.CheckedChanged += new System.EventHandler(this._chkCompetence1_CheckedChanged);
			// 
			// _chkCompetence2
			// 
			this._chkCompetence2.AutoSize = true;
			this._chkCompetence2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._chkCompetence2.Location = new System.Drawing.Point(293, 204);
			this._chkCompetence2.Name = "_chkCompetence2";
			this._chkCompetence2.Size = new System.Drawing.Size(15, 14);
			this._chkCompetence2.TabIndex = 2;
			this._chkCompetence2.UseVisualStyleBackColor = true;
			this._chkCompetence2.CheckedChanged += new System.EventHandler(this._chkCompetence2_CheckedChanged);
			// 
			// _chkCompetence3
			// 
			this._chkCompetence3.AutoSize = true;
			this._chkCompetence3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._chkCompetence3.Location = new System.Drawing.Point(293, 227);
			this._chkCompetence3.Name = "_chkCompetence3";
			this._chkCompetence3.Size = new System.Drawing.Size(15, 14);
			this._chkCompetence3.TabIndex = 3;
			this._chkCompetence3.UseVisualStyleBackColor = true;
			this._chkCompetence3.CheckedChanged += new System.EventHandler(this._chkCompetence3_CheckedChanged);
			// 
			// _txtCompetenceLevel1
			// 
			this._txtCompetenceLevel1.AutoSize = true;
			this._txtCompetenceLevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtCompetenceLevel1.Location = new System.Drawing.Point(348, 174);
			this._txtCompetenceLevel1.Name = "_txtCompetenceLevel1";
			this._txtCompetenceLevel1.Size = new System.Drawing.Size(215, 16);
			this._txtCompetenceLevel1.TabIndex = 1;
			this._txtCompetenceLevel1.Text = "Навык управления персоналом";
			this._txtCompetenceLevel1.Click += new System.EventHandler(this._txtCompetenceLevel1_Click);
			// 
			// _cmbEnterCompetenceLevel1
			// 
			this._cmbEnterCompetenceLevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._cmbEnterCompetenceLevel1.FormattingEnabled = true;
			this._cmbEnterCompetenceLevel1.Items.AddRange(new object[] {
            "Отличный",
            "Хороший",
            "Удовлетворительный",
            "Плохой"});
			this._cmbEnterCompetenceLevel1.Location = new System.Drawing.Point(612, 169);
			this._cmbEnterCompetenceLevel1.Name = "_cmbEnterCompetenceLevel1";
			this._cmbEnterCompetenceLevel1.Size = new System.Drawing.Size(176, 24);
			this._cmbEnterCompetenceLevel1.TabIndex = 2;
			// 
			// _cmbEnterCompetenceLevel2
			// 
			this._cmbEnterCompetenceLevel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._cmbEnterCompetenceLevel2.FormattingEnabled = true;
			this._cmbEnterCompetenceLevel2.Items.AddRange(new object[] {
            "Отличный",
            "Хороший",
            "Удовлетворительный",
            "Плохой"});
			this._cmbEnterCompetenceLevel2.Location = new System.Drawing.Point(612, 196);
			this._cmbEnterCompetenceLevel2.Name = "_cmbEnterCompetenceLevel2";
			this._cmbEnterCompetenceLevel2.Size = new System.Drawing.Size(176, 24);
			this._cmbEnterCompetenceLevel2.TabIndex = 7;
			// 
			// _txtCompetenceLevel2
			// 
			this._txtCompetenceLevel2.AutoSize = true;
			this._txtCompetenceLevel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtCompetenceLevel2.Location = new System.Drawing.Point(348, 201);
			this._txtCompetenceLevel2.Name = "_txtCompetenceLevel2";
			this._txtCompetenceLevel2.Size = new System.Drawing.Size(171, 16);
			this._txtCompetenceLevel2.TabIndex = 6;
			this._txtCompetenceLevel2.Text = "Навык работы в команде";
			this._txtCompetenceLevel2.Click += new System.EventHandler(this._txtCompetenceLevel2_Click);
			// 
			// _cmbEnterCompetenceLevel3
			// 
			this._cmbEnterCompetenceLevel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._cmbEnterCompetenceLevel3.FormattingEnabled = true;
			this._cmbEnterCompetenceLevel3.Items.AddRange(new object[] {
            "Отличный",
            "Хороший",
            "Удовлетворительный",
            "Плохой"});
			this._cmbEnterCompetenceLevel3.Location = new System.Drawing.Point(612, 223);
			this._cmbEnterCompetenceLevel3.Name = "_cmbEnterCompetenceLevel3";
			this._cmbEnterCompetenceLevel3.Size = new System.Drawing.Size(176, 24);
			this._cmbEnterCompetenceLevel3.TabIndex = 9;
			// 
			// _txtCompetenceLevel3
			// 
			this._txtCompetenceLevel3.AutoSize = true;
			this._txtCompetenceLevel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtCompetenceLevel3.Location = new System.Drawing.Point(348, 228);
			this._txtCompetenceLevel3.Name = "_txtCompetenceLevel3";
			this._txtCompetenceLevel3.Size = new System.Drawing.Size(256, 16);
			this._txtCompetenceLevel3.TabIndex = 8;
			this._txtCompetenceLevel3.Text = "Навык работы в стрессовой ситуации";
			// 
			// _txtPosition
			// 
			this._txtPosition.AutoSize = true;
			this._txtPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtPosition.Location = new System.Drawing.Point(348, 44);
			this._txtPosition.Name = "_txtPosition";
			this._txtPosition.Size = new System.Drawing.Size(79, 16);
			this._txtPosition.TabIndex = 10;
			this._txtPosition.Text = "Должность";
			// 
			// _cmbEnterPosition
			// 
			this._cmbEnterPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._cmbEnterPosition.FormattingEnabled = true;
			this._cmbEnterPosition.Items.AddRange(new object[] {
            "Уборщик",
            "Помошник",
            "Разработчик",
            "Лидер проекта"});
			this._cmbEnterPosition.Location = new System.Drawing.Point(456, 41);
			this._cmbEnterPosition.Name = "_cmbEnterPosition";
			this._cmbEnterPosition.Size = new System.Drawing.Size(186, 24);
			this._cmbEnterPosition.TabIndex = 11;
			// 
			// _grpMain
			// 
			this._grpMain.Controls.Add(this._btnSave);
			this._grpMain.Controls.Add(this._txtName);
			this._grpMain.Controls.Add(this._cmbEnterCompetenceLevel1);
			this._grpMain.Controls.Add(this._cmbEnterPosition);
			this._grpMain.Controls.Add(this._txtEnterName);
			this._grpMain.Controls.Add(this._txtPosition);
			this._grpMain.Controls.Add(this._txtLastName);
			this._grpMain.Controls.Add(this._cmbEnterCompetenceLevel3);
			this._grpMain.Controls.Add(this._txtEnterLastName);
			this._grpMain.Controls.Add(this._txtCompetenceLevel3);
			this._grpMain.Controls.Add(this._rdiGender1);
			this._grpMain.Controls.Add(this._cmbEnterCompetenceLevel2);
			this._grpMain.Controls.Add(this._txtCompetence1);
			this._grpMain.Controls.Add(this._txtCompetenceLevel2);
			this._grpMain.Controls.Add(this._txtCompetence2);
			this._grpMain.Controls.Add(this._chkCompetence1);
			this._grpMain.Controls.Add(this._chkCompetence3);
			this._grpMain.Controls.Add(this._rdiGender2);
			this._grpMain.Controls.Add(this._txtCompetenceLevel1);
			this._grpMain.Controls.Add(this._chkCompetence2);
			this._grpMain.Controls.Add(this._txtCompetence3);
			this._grpMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._grpMain.Location = new System.Drawing.Point(12, 12);
			this._grpMain.Name = "_grpMain";
			this._grpMain.Size = new System.Drawing.Size(809, 314);
			this._grpMain.TabIndex = 12;
			this._grpMain.TabStop = false;
			this._grpMain.Text = "Трудоустройство на работу";
			this._grpMain.Enter += new System.EventHandler(this._grpMain_Enter);
			// 
			// _btnSave
			// 
			this._btnSave.Location = new System.Drawing.Point(612, 275);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Size = new System.Drawing.Size(112, 33);
			this._btnSave.TabIndex = 12;
			this._btnSave.Text = "Записать";
			this._btnSave.UseVisualStyleBackColor = true;
			this._btnSave.Click += new System.EventHandler(this.button1_Click);
			// 
			// _dataGridView
			// 
			this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._dataGridView.Location = new System.Drawing.Point(12, 332);
			this._dataGridView.Name = "_dataGridView";
			this._dataGridView.RowHeadersVisible = false;
			this._dataGridView.Size = new System.Drawing.Size(808, 257);
			this._dataGridView.TabIndex = 13;
			this._dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(832, 601);
			this.Controls.Add(this._dataGridView);
			this.Controls.Add(this._grpMain);
			this.Name = "Form1";
			this.Text = "Form1";
			this._grpMain.ResumeLayout(false);
			this._grpMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TextBox _txtEnterName;
		private System.Windows.Forms.Label _txtName;
		private System.Windows.Forms.TextBox _txtEnterLastName;
		private System.Windows.Forms.Label _txtLastName;
		private System.Windows.Forms.RadioButton _rdiGender2;
		private System.Windows.Forms.RadioButton _rdiGender1;
		private System.Windows.Forms.CheckBox _chkCompetence3;
		private System.Windows.Forms.Label _txtCompetence3;
		private System.Windows.Forms.CheckBox _chkCompetence2;
		private System.Windows.Forms.CheckBox _chkCompetence1;
		private System.Windows.Forms.Label _txtCompetence2;
		private System.Windows.Forms.Label _txtCompetence1;
		private System.Windows.Forms.ComboBox _cmbEnterCompetenceLevel1;
		private System.Windows.Forms.Label _txtCompetenceLevel1;
		private System.Windows.Forms.ComboBox _cmbEnterCompetenceLevel3;
		private System.Windows.Forms.Label _txtCompetenceLevel3;
		private System.Windows.Forms.ComboBox _cmbEnterCompetenceLevel2;
		private System.Windows.Forms.Label _txtCompetenceLevel2;
		private System.Windows.Forms.ComboBox _cmbEnterPosition;
		private System.Windows.Forms.Label _txtPosition;
		private System.Windows.Forms.GroupBox _grpMain;
		private System.Windows.Forms.DataGridView _dataGridView;
		private System.Windows.Forms.Button _btnSave;
	}
}

