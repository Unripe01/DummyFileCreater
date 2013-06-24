using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace DummyFileCreater
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load( object sender, EventArgs e )
		{
			this.txtFolderPath.Text =  Path.GetDirectoryName( Application.ExecutablePath );
			this.txtFileName.Text =  string.Format( "dummy_{0}", System.DateTime.Now.ToString("yyyyMMddHHmmss") );
			//Size
			this.comboBoxFileSize.SelectedIndex = 0;
			//radio
			this.rbtSize.Checked = true;

		}

		/// <summary>
		/// Get dummy file name from datetime 
		/// </summary>
		private void btnRefresh_Click( object sender, EventArgs e )
		{
			this.txtFileName.Text =  string.Format( "dummy_{0}", System.DateTime.Now.ToString( "yyyyMMddHHmmss" ) );
		}

		/// <summary>
		/// change group box's enable 
		/// </summary>
		private void rbtCreatedby_CheckedChanged( object sender, EventArgs e )
		{
			if( this.rbtSize.Checked )
			{
				//caluc by file size
				this.numRecordLength.Enabled = true;
				this.numFileSize.Enabled = true;
				this.numRowCount.Enabled = false;

			} else if ( this.rbtRowCount.Checked ) {
				//caluc by row count
				this.numRecordLength.Enabled = true;
				this.numFileSize.Enabled = false;
				this.numRowCount.Enabled = true;

			}
			else if( this.rbtSizeAndLines.Checked )
			{
				//caluc by size and lines
				this.numRecordLength.Enabled = false;
				this.numFileSize.Enabled = true;
				this.numRowCount.Enabled = true;

			}
		}

		private void CalucByFileSize()
		{
			this.numRowCount.Value = 
			 numFileSize.Value / ( numRecordLength.Value + 2 );
			//remnant 
			this.numRemainder.Value = 
				numFileSize.Value % ( numRecordLength.Value + 2 );
		}

		private void CalucByRowCount()
		{
			this.numFileSize.Value = 
				numRowCount.Value * ( numRecordLength.Value + 2 );
			//remnant 
			this.numRemainder.Value = 
				numFileSize.Value % ( numRecordLength.Value + 2 );
		}

		private void CalucBySizeAndLines()
		{
			this.numRecordLength.Value = 
				numFileSize.Value / ( numRecordLength.Value + 2 );
			//remnant 
			this.numRemainder.Value = 
				numFileSize.Value % ( numRecordLength.Value + 2 );
		}

		private void CreateFile( string filePath, decimal rowCount, int recordLength, string repeatChar )
		{
			string recordChar = repeatChar.PadLeft( recordLength, repeatChar.ToCharArray()[0] );

			using(
				System.IO.StreamWriter sw = new System.IO.StreamWriter(
				filePath, false, System.Text.Encoding.GetEncoding( "shift_jis" ) )
			)
			{
				for( int i = 0; i < rowCount; i++ )
				{
					//write file
					sw.WriteLine( recordChar );
					backgroundWorker1.ReportProgress( i );
				}
				sw.Close();
			}
		}

		/// <summary>
		/// execute file create
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnExecute_Click( object sender, EventArgs e )
		{
			//処理が行われているときは、何もしない
			if( backgroundWorker1.IsBusy )
			{
				return;
			}

			//コントロールを初期化する
			progressBar1.Minimum = 0;
			progressBar1.Maximum = (int)this.numRowCount.Value;
			progressBar1.Value = 0;
			progressBar1.Text = "0";
			backgroundWorker1.WorkerReportsProgress = true;
			backgroundWorker1.RunWorkerAsync();

			//File Create Start
			lblStatus.Text = "start";
		}

		private void btnOpen_Click( object sender, EventArgs e )
		{
			System.Diagnostics.Process.Start( this.txtFolderPath.Text );
		}

		private void CalucInputValue( object sender, EventArgs e )
		{
			if( this.rbtSize.Checked )
			{
				this.CalucByFileSize();
			}
			else if( this.rbtRowCount.Checked )
			{
				this.CalucByRowCount();
			}
			else if( this.rbtSizeAndLines.Checked )
			{
				this.CalucBySizeAndLines();
			}
			lblTotalFileSize.Text = this.GetTotalFileSize().ToString();
		}

		private decimal GetTotalFileSize()
		{
			return( this.numRecordLength.Value + 2 ) * this.numRowCount.Value;
		}

		private void DoCreateFile( object sender, DoWorkEventArgs e )
		{
			this.CreateFile(
				Path.Combine( this.txtFolderPath.Text, this.txtFileName.Text )
				, this.numRowCount.Value
				, (int)this.numRecordLength.Value
				, this.txtReatChar.Text
			);
		}

		private void backgroundWorker1_RunWorkerCompleted( object sender, RunWorkerCompletedEventArgs e )
		{
			lblStatus.Text = "finish";
		}

		private void backgroundWorker1_ProgressChanged( object sender, ProgressChangedEventArgs e )
		{
			//ProgressBar1の値を変更する
			progressBar1.Value = e.ProgressPercentage;
		}

	}
}
