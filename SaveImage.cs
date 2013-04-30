using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FractalViewer
{
	/// <summary>
	/// Summary description for SaveImage.
	/// </summary>
	public class SaveImage : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxFileType;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		private string filename;
		private System.Drawing.Imaging.ImageFormat format;
		private Bitmap image;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SaveImage(Bitmap image)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			this.image = image;

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SaveImage));
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxFileType = new System.Windows.Forms.ComboBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "File name:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(72, 8);
			this.textBox1.Name = "textBox1";
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "image1";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 21);
			this.label2.TabIndex = 2;
			this.label2.Text = "File type:";
			// 
			// comboBoxFileType
			// 
			this.comboBoxFileType.Items.AddRange(new object[] {
																  "Bmp",
																  "Emf",
																  "Exif",
																  "Gif",
																  "Icon",
																  "Jpeg",
																  "MemoryBmp",
																  "Png",
																  "Tiff",
																  "Wmf"});
			this.comboBoxFileType.Location = new System.Drawing.Point(72, 32);
			this.comboBoxFileType.Name = "comboBoxFileType";
			this.comboBoxFileType.Size = new System.Drawing.Size(104, 21);
			this.comboBoxFileType.TabIndex = 3;
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(168, 64);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.TabIndex = 5;
			this.buttonOK.Text = "OK";
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(80, 64);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.TabIndex = 4;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// SaveImage
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(248, 93);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.comboBoxFileType);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SaveImage";
			this.Text = "Save File As ...";
			this.ResumeLayout(false);

		}
		#endregion

		private void buttonOK_Click(object sender, System.EventArgs e)
		{

			this.filename = this.textBox1.Text;
			switch (this.comboBoxFileType.Text)
			{
				case "Wmf":
					this.format = System.Drawing.Imaging.ImageFormat.Wmf;
					this.filename = this.filename + ".wmf";
					break;
				case "Tiff":
					this.format = System.Drawing.Imaging.ImageFormat.Tiff;
					this.filename = this.filename + ".tiff";
					break;
				case "Png":
					this.format = System.Drawing.Imaging.ImageFormat.Png;
					this.filename = this.filename + ".png";
					break;
				case "MemoryBmp":
					this.format = System.Drawing.Imaging.ImageFormat.MemoryBmp;
					this.filename = this.filename + ".bmp";
					break;
				case "Jpeg":
					this.format = System.Drawing.Imaging.ImageFormat.Jpeg;
					this.filename = this.filename + ".jpeg";
					break;
				case "Icon":
					this.format = System.Drawing.Imaging.ImageFormat.Icon;
					this.filename = this.filename + ".ico";
					break;
				case "Gif":
					this.format = System.Drawing.Imaging.ImageFormat.Gif;
					this.filename = this.filename + ".gif";
					break;
				case "Exif":
					this.format = System.Drawing.Imaging.ImageFormat.Exif;
					this.filename = this.filename + ".exif";
					break;
				case "Emf":
					this.format = System.Drawing.Imaging.ImageFormat.Emf;
					this.filename = this.filename + ".emf";
					break;
				case "Bmp":
				default:
					this.format = System.Drawing.Imaging.ImageFormat.Bmp;
					this.filename = this.filename + ".bmp";
					break;
			}

			image.Save(this.filename,this.format);
			
			this.Close();
		}

		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
