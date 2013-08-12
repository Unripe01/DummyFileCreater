namespace DummyFileCreater
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.Label lblFileName;
			System.Windows.Forms.Label label1;
			System.Windows.Forms.Label label2;
			System.Windows.Forms.Label label3;
			System.Windows.Forms.Label label4;
			System.Windows.Forms.Label label5;
			System.Windows.Forms.Label label6;
			System.Windows.Forms.Label label7;
			this.btnExecute = new System.Windows.Forms.Button();
			this.txtFileName = new System.Windows.Forms.TextBox();
			this.txtFolderPath = new System.Windows.Forms.TextBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.rbtSize = new System.Windows.Forms.RadioButton();
			this.rbtRowCount = new System.Windows.Forms.RadioButton();
			this.groupBoxCreateBy = new System.Windows.Forms.GroupBox();
			this.rbtSizeAndLines = new System.Windows.Forms.RadioButton();
			this.comboBoxFileSize = new System.Windows.Forms.ComboBox();
			this.numFileSize = new System.Windows.Forms.NumericUpDown();
			this.numRecordLength = new System.Windows.Forms.NumericUpDown();
			this.numRowCount = new System.Windows.Forms.NumericUpDown();
			this.txtReatChar = new System.Windows.Forms.TextBox();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.lblStatus = new System.Windows.Forms.Label();
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnCaluc = new System.Windows.Forms.Button();
			this.numRemainder = new System.Windows.Forms.NumericUpDown();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.lblTotalFileSize = new System.Windows.Forms.Label();
			this.chkboxDelimiter = new System.Windows.Forms.CheckBox();
			lblFileName = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			label6 = new System.Windows.Forms.Label();
			label7 = new System.Windows.Forms.Label();
			this.groupBoxCreateBy.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numFileSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numRecordLength)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numRowCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numRemainder)).BeginInit();
			this.SuspendLayout();
			// 
			// btnExecute
			// 
			this.btnExecute.Location = new System.Drawing.Point(514, 305);
			this.btnExecute.Name = "btnExecute";
			this.btnExecute.Size = new System.Drawing.Size(145, 23);
			this.btnExecute.TabIndex = 0;
			this.btnExecute.Text = "Create";
			this.btnExecute.UseVisualStyleBackColor = true;
			this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
			// 
			// txtFileName
			// 
			this.txtFileName.Location = new System.Drawing.Point(83, 52);
			this.txtFileName.Name = "txtFileName";
			this.txtFileName.Size = new System.Drawing.Size(479, 19);
			this.txtFileName.TabIndex = 1;
			// 
			// lblFileName
			// 
			lblFileName.AutoSize = true;
			lblFileName.Location = new System.Drawing.Point(13, 55);
			lblFileName.Name = "lblFileName";
			lblFileName.Size = new System.Drawing.Size(57, 12);
			lblFileName.TabIndex = 2;
			lblFileName.Text = "File Name";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(13, 23);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(64, 12);
			label1.TabIndex = 2;
			label1.Text = "Folder Path";
			// 
			// txtFolderPath
			// 
			this.txtFolderPath.Location = new System.Drawing.Point(83, 20);
			this.txtFolderPath.Name = "txtFolderPath";
			this.txtFolderPath.Size = new System.Drawing.Size(479, 19);
			this.txtFolderPath.TabIndex = 1;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(12, 302);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(476, 23);
			this.progressBar1.TabIndex = 6;
			// 
			// rbtSize
			// 
			this.rbtSize.AutoSize = true;
			this.rbtSize.Location = new System.Drawing.Point(12, 18);
			this.rbtSize.Name = "rbtSize";
			this.rbtSize.Size = new System.Drawing.Size(44, 16);
			this.rbtSize.TabIndex = 7;
			this.rbtSize.Text = "Size";
			this.rbtSize.UseVisualStyleBackColor = true;
			this.rbtSize.CheckedChanged += new System.EventHandler(this.rbtCreatedby_CheckedChanged);
			// 
			// rbtRowCount
			// 
			this.rbtRowCount.AutoSize = true;
			this.rbtRowCount.Location = new System.Drawing.Point(71, 18);
			this.rbtRowCount.Name = "rbtRowCount";
			this.rbtRowCount.Size = new System.Drawing.Size(77, 16);
			this.rbtRowCount.TabIndex = 8;
			this.rbtRowCount.Text = "Row count";
			this.rbtRowCount.UseVisualStyleBackColor = true;
			this.rbtRowCount.CheckedChanged += new System.EventHandler(this.rbtCreatedby_CheckedChanged);
			// 
			// groupBoxCreateBy
			// 
			this.groupBoxCreateBy.Controls.Add(this.rbtSizeAndLines);
			this.groupBoxCreateBy.Controls.Add(this.rbtRowCount);
			this.groupBoxCreateBy.Controls.Add(this.rbtSize);
			this.groupBoxCreateBy.Location = new System.Drawing.Point(12, 121);
			this.groupBoxCreateBy.Name = "groupBoxCreateBy";
			this.groupBoxCreateBy.Size = new System.Drawing.Size(270, 46);
			this.groupBoxCreateBy.TabIndex = 9;
			this.groupBoxCreateBy.TabStop = false;
			this.groupBoxCreateBy.Text = "Create by";
			// 
			// rbtSizeAndLines
			// 
			this.rbtSizeAndLines.AutoSize = true;
			this.rbtSizeAndLines.Location = new System.Drawing.Point(154, 18);
			this.rbtSizeAndLines.Name = "rbtSizeAndLines";
			this.rbtSizeAndLines.Size = new System.Drawing.Size(97, 16);
			this.rbtSizeAndLines.TabIndex = 8;
			this.rbtSizeAndLines.Text = "Size and Lines";
			this.rbtSizeAndLines.UseVisualStyleBackColor = true;
			this.rbtSizeAndLines.CheckedChanged += new System.EventHandler(this.rbtCreatedby_CheckedChanged);
			// 
			// comboBoxFileSize
			// 
			this.comboBoxFileSize.FormattingEnabled = true;
			this.comboBoxFileSize.Items.AddRange(new object[] {
            "byte"});
			this.comboBoxFileSize.Location = new System.Drawing.Point(288, 178);
			this.comboBoxFileSize.Name = "comboBoxFileSize";
			this.comboBoxFileSize.Size = new System.Drawing.Size(87, 20);
			this.comboBoxFileSize.TabIndex = 8;
			// 
			// numFileSize
			// 
			this.numFileSize.Location = new System.Drawing.Point(89, 179);
			this.numFileSize.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
			this.numFileSize.Name = "numFileSize";
			this.numFileSize.Size = new System.Drawing.Size(193, 19);
			this.numFileSize.TabIndex = 7;
			this.numFileSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numFileSize.Value = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(22, 181);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(26, 12);
			label2.TabIndex = 6;
			label2.Text = "Size";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(13, 89);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(79, 12);
			label3.TabIndex = 6;
			label3.Text = "Record Length";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(22, 215);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(61, 12);
			label4.TabIndex = 6;
			label4.Text = "Row Count";
			// 
			// numRecordLength
			// 
			this.numRecordLength.Location = new System.Drawing.Point(98, 87);
			this.numRecordLength.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
			this.numRecordLength.Name = "numRecordLength";
			this.numRecordLength.Size = new System.Drawing.Size(193, 19);
			this.numRecordLength.TabIndex = 7;
			this.numRecordLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numRecordLength.Value = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			// 
			// numRowCount
			// 
			this.numRowCount.Location = new System.Drawing.Point(89, 213);
			this.numRowCount.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
			this.numRowCount.Name = "numRowCount";
			this.numRowCount.Size = new System.Drawing.Size(193, 19);
			this.numRowCount.TabIndex = 7;
			this.numRowCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numRowCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(497, 89);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(93, 12);
			label5.TabIndex = 6;
			label5.Text = "Repeat character";
			// 
			// txtReatChar
			// 
			this.txtReatChar.Location = new System.Drawing.Point(596, 86);
			this.txtReatChar.MaxLength = 1;
			this.txtReatChar.Name = "txtReatChar";
			this.txtReatChar.Size = new System.Drawing.Size(43, 19);
			this.txtReatChar.TabIndex = 11;
			this.txtReatChar.Text = "0";
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(568, 50);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(71, 23);
			this.btnRefresh.TabIndex = 12;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(13, 287);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(51, 12);
			this.lblStatus.TabIndex = 13;
			this.lblStatus.Text = "stand-by";
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(568, 18);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(71, 23);
			this.btnOpen.TabIndex = 12;
			this.btnOpen.Text = "Open";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// btnCaluc
			// 
			this.btnCaluc.Location = new System.Drawing.Point(515, 276);
			this.btnCaluc.Name = "btnCaluc";
			this.btnCaluc.Size = new System.Drawing.Size(144, 23);
			this.btnCaluc.TabIndex = 14;
			this.btnCaluc.Text = "caluc";
			this.btnCaluc.UseVisualStyleBackColor = true;
			this.btnCaluc.Click += new System.EventHandler(this.CalucInputValue);
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.ForeColor = System.Drawing.Color.Red;
			label6.Location = new System.Drawing.Point(297, 89);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(55, 12);
			label6.TabIndex = 15;
			label6.Text = "remainder";
			// 
			// numRemainder
			// 
			this.numRemainder.ForeColor = System.Drawing.Color.Red;
			this.numRemainder.Location = new System.Drawing.Point(358, 87);
			this.numRemainder.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
			this.numRemainder.Name = "numRemainder";
			this.numRemainder.Size = new System.Drawing.Size(130, 19);
			this.numRemainder.TabIndex = 16;
			this.numRemainder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DoCreateFile);
			this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
			this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(450, 229);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(89, 12);
			label7.TabIndex = 17;
			label7.Text = "total file size is ";
			// 
			// lblTotalFileSize
			// 
			this.lblTotalFileSize.AutoSize = true;
			this.lblTotalFileSize.Location = new System.Drawing.Point(464, 251);
			this.lblTotalFileSize.Name = "lblTotalFileSize";
			this.lblTotalFileSize.Size = new System.Drawing.Size(11, 12);
			this.lblTotalFileSize.TabIndex = 18;
			this.lblTotalFileSize.Text = "0";
			// 
			// chkboxDelimiter
			// 
			this.chkboxDelimiter.AutoSize = true;
			this.chkboxDelimiter.Checked = true;
			this.chkboxDelimiter.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkboxDelimiter.Location = new System.Drawing.Point(289, 139);
			this.chkboxDelimiter.Name = "chkboxDelimiter";
			this.chkboxDelimiter.Size = new System.Drawing.Size(111, 16);
			this.chkboxDelimiter.TabIndex = 19;
			this.chkboxDelimiter.Text = "delimiter(CR/LF)";
			this.chkboxDelimiter.UseVisualStyleBackColor = true;
			this.chkboxDelimiter.CheckedChanged += new System.EventHandler(this.chkboxDelimiter_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(671, 341);
			this.Controls.Add(this.chkboxDelimiter);
			this.Controls.Add(this.lblTotalFileSize);
			this.Controls.Add(label7);
			this.Controls.Add(this.numRemainder);
			this.Controls.Add(label6);
			this.Controls.Add(this.btnCaluc);
			this.Controls.Add(this.comboBoxFileSize);
			this.Controls.Add(label4);
			this.Controls.Add(this.numFileSize);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(label2);
			this.Controls.Add(this.numRowCount);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.txtReatChar);
			this.Controls.Add(this.numRecordLength);
			this.Controls.Add(this.groupBoxCreateBy);
			this.Controls.Add(label5);
			this.Controls.Add(label3);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(label1);
			this.Controls.Add(lblFileName);
			this.Controls.Add(this.txtFolderPath);
			this.Controls.Add(this.txtFileName);
			this.Controls.Add(this.btnExecute);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "ダミーファイル作成";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBoxCreateBy.ResumeLayout(false);
			this.groupBoxCreateBy.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numFileSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numRecordLength)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numRowCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numRemainder)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnExecute;
		private System.Windows.Forms.TextBox txtFileName;
		private System.Windows.Forms.TextBox txtFolderPath;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.RadioButton rbtSize;
		private System.Windows.Forms.RadioButton rbtRowCount;
		private System.Windows.Forms.GroupBox groupBoxCreateBy;
		private System.Windows.Forms.ComboBox comboBoxFileSize;
		private System.Windows.Forms.NumericUpDown numFileSize;
		private System.Windows.Forms.NumericUpDown numRowCount;
		private System.Windows.Forms.NumericUpDown numRecordLength;
		private System.Windows.Forms.TextBox txtReatChar;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnCaluc;
		private System.Windows.Forms.RadioButton rbtSizeAndLines;
		private System.Windows.Forms.NumericUpDown numRemainder;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Label lblTotalFileSize;
		private System.Windows.Forms.CheckBox chkboxDelimiter;
	}
}

