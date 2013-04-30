using System;
using System.Drawing;
using System.Windows.Forms;

namespace FractalViewer
{
	/// <summary>
	/// Summary description for SaveImage.
	/// </summary>
	public class SaveImage : System.Windows.Forms.Form
    {
        #region Form Items
        private System.Windows.Forms.Label labelFileName;
		private System.Windows.Forms.TextBox textBoxLocation;
		private System.Windows.Forms.Label labelFileType;
		private System.Windows.Forms.ComboBox comboBoxFileType;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
        #endregion

        private string filename;
		private System.Drawing.Imaging.ImageFormat format;
		private Bitmap image;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

        /// <summary>
        /// Save Image Constructor
        /// </summary>
        /// <param name="image"></param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveImage));
            this.labelFileName = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.labelFileType = new System.Windows.Forms.Label();
            this.comboBoxFileType = new System.Windows.Forms.ComboBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFileName
            // 
            this.labelFileName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileName.Location = new System.Drawing.Point(8, 8);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(64, 20);
            this.labelFileName.TabIndex = 0;
            this.labelFileName.Text = "File name:";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(72, 8);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(100, 20);
            this.textBoxLocation.TabIndex = 1;
            this.textBoxLocation.Text = "image1";
            // 
            // labelFileType
            // 
            this.labelFileType.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileType.Location = new System.Drawing.Point(8, 32);
            this.labelFileType.Name = "labelFileType";
            this.labelFileType.Size = new System.Drawing.Size(64, 21);
            this.labelFileType.TabIndex = 2;
            this.labelFileType.Text = "File type:";
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
            this.comboBoxFileType.Size = new System.Drawing.Size(100, 21);
            this.comboBoxFileType.TabIndex = 3;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(161, 64);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(80, 64);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
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
            this.Controls.Add(this.labelFileType);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.labelFileName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SaveImage";
            this.Text = "Save File As ...";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        /// <summary>
        /// Proceed to save image given user selections
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void buttonOK_Click(object sender, System.EventArgs e)
		{
            string fileExtension = ".bmp";

			switch (this.comboBoxFileType.Text)
			{
				case "Wmf":
					this.format = System.Drawing.Imaging.ImageFormat.Wmf;
					fileExtension = ".wmf";
					break;
				case "Tiff":
					this.format = System.Drawing.Imaging.ImageFormat.Tiff;
                    fileExtension = ".tiff";
					break;
				case "Png":
					this.format = System.Drawing.Imaging.ImageFormat.Png;
                    fileExtension = ".png";
					break;
				case "MemoryBmp":
					this.format = System.Drawing.Imaging.ImageFormat.MemoryBmp;
                    fileExtension = ".bmp";
					break;
				case "Jpeg":
					this.format = System.Drawing.Imaging.ImageFormat.Jpeg;
                    fileExtension = ".jpeg";
					break;
				case "Icon":
					this.format = System.Drawing.Imaging.ImageFormat.Icon;
                    fileExtension = ".ico";
					break;
				case "Gif":
					this.format = System.Drawing.Imaging.ImageFormat.Gif;
                    fileExtension = ".gif";
					break;
				case "Exif":
					this.format = System.Drawing.Imaging.ImageFormat.Exif;
                    fileExtension = ".exif";
					break;
				case "Emf":
					this.format = System.Drawing.Imaging.ImageFormat.Emf;
                    fileExtension = ".emf";
					break;
				case "Bmp":
				default:
					this.format = System.Drawing.Imaging.ImageFormat.Bmp;
                    fileExtension = ".bmp";
					break;
			}

            this.filename = this.textBoxLocation.Text + fileExtension;
			image.Save(this.filename,this.format);
			
			this.Close();
		}

        /// <summary>
        /// Close Save Image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
