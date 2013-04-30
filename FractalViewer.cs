using System;
using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
using System.Windows.Forms;
//using System.Data;
//using System.Threading;

namespace FractalViewer
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItemFractalTitle;
		private System.Windows.Forms.MenuItem menuItemHelpTitle;
		private System.Windows.Forms.MenuItem menuItemOrbit_XsquareMinus2;
		private System.Windows.Forms.Label labelSeed;
		private System.Windows.Forms.NumericUpDown numericUpDownSeed;
		private System.Windows.Forms.MenuItem menuItemMandelbrotSet;
		private System.Windows.Forms.Panel panelOrbit;
		private System.Windows.Forms.MenuItem menuItemJuliaSet;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItemBoxFractal;
		private System.Windows.Forms.MenuItem menuItemFractalsTitle;
		private System.Windows.Forms.MenuItem menuItemComplexSystemTitle;
		private System.Windows.Forms.NumericUpDown numericUpDownComplex;
		private System.Windows.Forms.NumericUpDown numericUpDownReal;
		private System.Windows.Forms.Label labelComplexParam;
		private System.Windows.Forms.Label labelPlus;
		private System.Windows.Forms.Label labeli;
		private System.Windows.Forms.MenuItem menuItemAbout;
		private System.Windows.Forms.MenuItem menuItemSaveImageAs;
		private System.Windows.Forms.MenuItem menuItemFileTitle;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItemExit;
		private System.Windows.Forms.NumericUpDown numericUpDownOrbitDispaly;
		private System.Windows.Forms.Label labelViewLast;
		private System.Windows.Forms.MenuItem menuItemColorTitle;
		private System.Windows.Forms.MenuItem menuItemColorOrbit;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.MenuItem menuItemBackground;
        private System.Windows.Forms.ColorDialog colorDialog2;
		private System.Windows.Forms.MenuItem menuItemColorFractals;
		private System.Windows.Forms.ColorDialog colorDialog3;
		private System.Windows.Forms.MenuItem menuItemColorComplexSysTitle;
		private System.Windows.Forms.MenuItem menuItemCSColor1;
		private System.Windows.Forms.MenuItem menuItemCSColor2;
		private System.Windows.Forms.MenuItem menuItemCSColor3;
		private System.Windows.Forms.MenuItem menuItemCSColor4;
		private System.Windows.Forms.ColorDialog colorDialogComplex1;
		private System.Windows.Forms.ColorDialog colorDialogComplex2;
		private System.Windows.Forms.ColorDialog colorDialogComplex3;
		private System.Windows.Forms.ColorDialog colorDialogComplex4;
		private System.Windows.Forms.ColorDialog colorDialogComplex5;
		private System.Windows.Forms.MenuItem menuItemCSColor5;
		private System.Windows.Forms.MenuItem menuItemCSColor6;
		private System.Windows.Forms.MenuItem menuItemCSColor7;
		private System.Windows.Forms.MenuItem menuItemCSColor8;
		private System.Windows.Forms.MenuItem menuItemCSColor9;
		private System.Windows.Forms.ColorDialog colorDialogComplex6;
		private System.Windows.Forms.ColorDialog colorDialogComplex7;
		private System.Windows.Forms.ColorDialog colorDialogComplex8;
		private System.Windows.Forms.ColorDialog colorDialogComplex9;
		private System.Windows.Forms.MenuItem menuItemOrbitsTitle;
        private System.Windows.Forms.MenuItem menuItemNewtonMethod;
		private System.Windows.Forms.MenuItem menuItem35;
		private System.Windows.Forms.MenuItem menuItemPrint;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
		private System.Windows.Forms.MenuItem menuItemPageSetup;
		private System.Windows.Forms.MenuItem menuItemNew;
		private System.Windows.Forms.MenuItem menuItem39;
		private System.Windows.Forms.MenuItem menuItemSierpinskiTriangle;

        private Point mouseDownLocation;
        private Label labelBoxFractal;
        private NumericUpDown numericUpDownBoxFractal;
        private NumericUpDown numericUpDownSierp;
        private Point mouseUpLocation;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			this.panelOrbit.Visible = false;

            this.mouseDownLocation = new Point(0, 0);
            this.mouseUpLocation = new Point(this.pictureBox1.Width, this.pictureBox1.Height);

			//Double Buffering

			//this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer,true);

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItemFileTitle = new System.Windows.Forms.MenuItem();
            this.menuItemNew = new System.Windows.Forms.MenuItem();
            this.menuItem39 = new System.Windows.Forms.MenuItem();
            this.menuItemSaveImageAs = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItemPageSetup = new System.Windows.Forms.MenuItem();
            this.menuItemPrint = new System.Windows.Forms.MenuItem();
            this.menuItem35 = new System.Windows.Forms.MenuItem();
            this.menuItemExit = new System.Windows.Forms.MenuItem();
            this.menuItemFractalTitle = new System.Windows.Forms.MenuItem();
            this.menuItemOrbitsTitle = new System.Windows.Forms.MenuItem();
            this.menuItemOrbit_XsquareMinus2 = new System.Windows.Forms.MenuItem();
            this.menuItemFractalsTitle = new System.Windows.Forms.MenuItem();
            this.menuItemBoxFractal = new System.Windows.Forms.MenuItem();
            this.menuItemSierpinskiTriangle = new System.Windows.Forms.MenuItem();
            this.menuItemComplexSystemTitle = new System.Windows.Forms.MenuItem();
            this.menuItemMandelbrotSet = new System.Windows.Forms.MenuItem();
            this.menuItemJuliaSet = new System.Windows.Forms.MenuItem();
            this.menuItemNewtonMethod = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItemColorTitle = new System.Windows.Forms.MenuItem();
            this.menuItemBackground = new System.Windows.Forms.MenuItem();
            this.menuItemColorOrbit = new System.Windows.Forms.MenuItem();
            this.menuItemColorFractals = new System.Windows.Forms.MenuItem();
            this.menuItemColorComplexSysTitle = new System.Windows.Forms.MenuItem();
            this.menuItemCSColor1 = new System.Windows.Forms.MenuItem();
            this.menuItemCSColor2 = new System.Windows.Forms.MenuItem();
            this.menuItemCSColor3 = new System.Windows.Forms.MenuItem();
            this.menuItemCSColor4 = new System.Windows.Forms.MenuItem();
            this.menuItemCSColor5 = new System.Windows.Forms.MenuItem();
            this.menuItemCSColor6 = new System.Windows.Forms.MenuItem();
            this.menuItemCSColor7 = new System.Windows.Forms.MenuItem();
            this.menuItemCSColor8 = new System.Windows.Forms.MenuItem();
            this.menuItemCSColor9 = new System.Windows.Forms.MenuItem();
            this.menuItemHelpTitle = new System.Windows.Forms.MenuItem();
            this.menuItemAbout = new System.Windows.Forms.MenuItem();
            this.panelOrbit = new System.Windows.Forms.Panel();
            this.numericUpDownSierp = new System.Windows.Forms.NumericUpDown();
            this.labelBoxFractal = new System.Windows.Forms.Label();
            this.numericUpDownBoxFractal = new System.Windows.Forms.NumericUpDown();
            this.labelViewLast = new System.Windows.Forms.Label();
            this.numericUpDownOrbitDispaly = new System.Windows.Forms.NumericUpDown();
            this.labeli = new System.Windows.Forms.Label();
            this.labelPlus = new System.Windows.Forms.Label();
            this.numericUpDownSeed = new System.Windows.Forms.NumericUpDown();
            this.labelSeed = new System.Windows.Forms.Label();
            this.labelComplexParam = new System.Windows.Forms.Label();
            this.numericUpDownReal = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownComplex = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.colorDialogComplex1 = new System.Windows.Forms.ColorDialog();
            this.colorDialogComplex2 = new System.Windows.Forms.ColorDialog();
            this.colorDialogComplex3 = new System.Windows.Forms.ColorDialog();
            this.colorDialogComplex4 = new System.Windows.Forms.ColorDialog();
            this.colorDialogComplex5 = new System.Windows.Forms.ColorDialog();
            this.colorDialogComplex6 = new System.Windows.Forms.ColorDialog();
            this.colorDialogComplex7 = new System.Windows.Forms.ColorDialog();
            this.colorDialogComplex8 = new System.Windows.Forms.ColorDialog();
            this.colorDialogComplex9 = new System.Windows.Forms.ColorDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelOrbit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSierp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBoxFractal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrbitDispaly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownComplex)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(624, 281);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxPaint);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFileTitle,
            this.menuItemFractalTitle,
            this.menuItemColorTitle,
            this.menuItemHelpTitle});
            // 
            // menuItemFileTitle
            // 
            this.menuItemFileTitle.Index = 0;
            this.menuItemFileTitle.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemNew,
            this.menuItem39,
            this.menuItemSaveImageAs,
            this.menuItem14,
            this.menuItemPageSetup,
            this.menuItemPrint,
            this.menuItem35,
            this.menuItemExit});
            this.menuItemFileTitle.Text = "&File";
            // 
            // menuItemNew
            // 
            this.menuItemNew.Index = 0;
            this.menuItemNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.menuItemNew.Text = "&New";
            this.menuItemNew.Click += new System.EventHandler(this.menuItem38_Click);
            // 
            // menuItem39
            // 
            this.menuItem39.Index = 1;
            this.menuItem39.Text = "-";
            // 
            // menuItemSaveImageAs
            // 
            this.menuItemSaveImageAs.Index = 2;
            this.menuItemSaveImageAs.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.menuItemSaveImageAs.Text = "&Save Image  As...";
            this.menuItemSaveImageAs.Click += new System.EventHandler(this.menuItem12_Click);
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 3;
            this.menuItem14.Text = "-";
            // 
            // menuItemPageSetup
            // 
            this.menuItemPageSetup.Index = 4;
            this.menuItemPageSetup.Text = "Page Setup...";
            this.menuItemPageSetup.Click += new System.EventHandler(this.menuItem37_Click);
            // 
            // menuItemPrint
            // 
            this.menuItemPrint.Index = 5;
            this.menuItemPrint.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
            this.menuItemPrint.Text = "Print";
            this.menuItemPrint.Click += new System.EventHandler(this.menuItem36_Click);
            // 
            // menuItem35
            // 
            this.menuItem35.Index = 6;
            this.menuItem35.Text = "-";
            // 
            // menuItemExit
            // 
            this.menuItemExit.Index = 7;
            this.menuItemExit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.menuItemExit.Text = "&Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItem15_Click);
            // 
            // menuItemFractalTitle
            // 
            this.menuItemFractalTitle.Index = 1;
            this.menuItemFractalTitle.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemOrbitsTitle,
            this.menuItemFractalsTitle,
            this.menuItemComplexSystemTitle});
            this.menuItemFractalTitle.Text = "F&ractal";
            // 
            // menuItemOrbitsTitle
            // 
            this.menuItemOrbitsTitle.Index = 0;
            this.menuItemOrbitsTitle.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemOrbit_XsquareMinus2});
            this.menuItemOrbitsTitle.Text = "Orbits";
            // 
            // menuItemOrbit_XsquareMinus2
            // 
            this.menuItemOrbit_XsquareMinus2.Index = 0;
            this.menuItemOrbit_XsquareMinus2.Text = "(x*x) - 2";
            this.menuItemOrbit_XsquareMinus2.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItemFractalsTitle
            // 
            this.menuItemFractalsTitle.Index = 1;
            this.menuItemFractalsTitle.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemBoxFractal,
            this.menuItemSierpinskiTriangle});
            this.menuItemFractalsTitle.Text = "Fractals";
            // 
            // menuItemBoxFractal
            // 
            this.menuItemBoxFractal.Index = 0;
            this.menuItemBoxFractal.Text = "Box Fractal";
            this.menuItemBoxFractal.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // menuItemSierpinskiTriangle
            // 
            this.menuItemSierpinskiTriangle.Index = 1;
            this.menuItemSierpinskiTriangle.Text = "Sierpinski Triangle";
            this.menuItemSierpinskiTriangle.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItemComplexSystemTitle
            // 
            this.menuItemComplexSystemTitle.Index = 2;
            this.menuItemComplexSystemTitle.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemMandelbrotSet,
            this.menuItemJuliaSet,
            this.menuItemNewtonMethod});
            this.menuItemComplexSystemTitle.Text = "Complex Systems";
            // 
            // menuItemMandelbrotSet
            // 
            this.menuItemMandelbrotSet.Index = 0;
            this.menuItemMandelbrotSet.Text = "Mandelbrot Set (Medium CPU Load)";
            this.menuItemMandelbrotSet.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItemJuliaSet
            // 
            this.menuItemJuliaSet.Index = 1;
            this.menuItemJuliaSet.Text = "Julia Set (Low CPU Load)";
            this.menuItemJuliaSet.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItemNewtonMethod
            // 
            this.menuItemNewtonMethod.Index = 2;
            this.menuItemNewtonMethod.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem7});
            this.menuItemNewtonMethod.Text = "Newton\'s Method (High CPU Load)";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 0;
            this.menuItem7.Text = "(x*x*x*x) + (y*y*y*y) + (2*x*x*y*y)";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItemColorTitle
            // 
            this.menuItemColorTitle.Index = 2;
            this.menuItemColorTitle.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemBackground,
            this.menuItemColorOrbit,
            this.menuItemColorFractals,
            this.menuItemColorComplexSysTitle});
            this.menuItemColorTitle.Text = "C&olor";
            // 
            // menuItemBackground
            // 
            this.menuItemBackground.Index = 0;
            this.menuItemBackground.Text = "Background";
            this.menuItemBackground.Click += new System.EventHandler(this.menuItem18_Click);
            // 
            // menuItemColorOrbit
            // 
            this.menuItemColorOrbit.Index = 1;
            this.menuItemColorOrbit.Text = "Orbit";
            this.menuItemColorOrbit.Click += new System.EventHandler(this.menuItem17_Click);
            // 
            // menuItemColorFractals
            // 
            this.menuItemColorFractals.Index = 2;
            this.menuItemColorFractals.Text = "Fractals";
            this.menuItemColorFractals.Click += new System.EventHandler(this.menuItem20_Click);
            // 
            // menuItemColorComplexSysTitle
            // 
            this.menuItemColorComplexSysTitle.Index = 3;
            this.menuItemColorComplexSysTitle.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemCSColor1,
            this.menuItemCSColor2,
            this.menuItemCSColor3,
            this.menuItemCSColor4,
            this.menuItemCSColor5,
            this.menuItemCSColor6,
            this.menuItemCSColor7,
            this.menuItemCSColor8,
            this.menuItemCSColor9});
            this.menuItemColorComplexSysTitle.Text = "Complex Systems";
            // 
            // menuItemCSColor1
            // 
            this.menuItemCSColor1.Index = 0;
            this.menuItemCSColor1.Text = "Color 1";
            this.menuItemCSColor1.Click += new System.EventHandler(this.menuItem22_Click);
            // 
            // menuItemCSColor2
            // 
            this.menuItemCSColor2.Index = 1;
            this.menuItemCSColor2.Text = "Color 2";
            this.menuItemCSColor2.Click += new System.EventHandler(this.menuItem23_Click);
            // 
            // menuItemCSColor3
            // 
            this.menuItemCSColor3.Index = 2;
            this.menuItemCSColor3.Text = "Color 3";
            this.menuItemCSColor3.Click += new System.EventHandler(this.menuItem24_Click);
            // 
            // menuItemCSColor4
            // 
            this.menuItemCSColor4.Index = 3;
            this.menuItemCSColor4.Text = "Color 4";
            this.menuItemCSColor4.Click += new System.EventHandler(this.menuItem25_Click);
            // 
            // menuItemCSColor5
            // 
            this.menuItemCSColor5.Index = 4;
            this.menuItemCSColor5.Text = "Color 5";
            this.menuItemCSColor5.Click += new System.EventHandler(this.menuItem26_Click);
            // 
            // menuItemCSColor6
            // 
            this.menuItemCSColor6.Index = 5;
            this.menuItemCSColor6.Text = "Color 6";
            this.menuItemCSColor6.Click += new System.EventHandler(this.menuItem27_Click);
            // 
            // menuItemCSColor7
            // 
            this.menuItemCSColor7.Index = 6;
            this.menuItemCSColor7.Text = "Color 7";
            this.menuItemCSColor7.Click += new System.EventHandler(this.menuItem28_Click);
            // 
            // menuItemCSColor8
            // 
            this.menuItemCSColor8.Index = 7;
            this.menuItemCSColor8.Text = "Color 8";
            this.menuItemCSColor8.Click += new System.EventHandler(this.menuItem29_Click);
            // 
            // menuItemCSColor9
            // 
            this.menuItemCSColor9.Index = 8;
            this.menuItemCSColor9.Text = "Color 9";
            this.menuItemCSColor9.Click += new System.EventHandler(this.menuItem30_Click);
            // 
            // menuItemHelpTitle
            // 
            this.menuItemHelpTitle.Index = 3;
            this.menuItemHelpTitle.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemAbout});
            this.menuItemHelpTitle.Text = "&Help";
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Index = 0;
            this.menuItemAbout.Text = "About";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItem11_Click);
            // 
            // panelOrbit
            // 
            this.panelOrbit.Controls.Add(this.numericUpDownSierp);
            this.panelOrbit.Controls.Add(this.labelBoxFractal);
            this.panelOrbit.Controls.Add(this.numericUpDownBoxFractal);
            this.panelOrbit.Controls.Add(this.labelViewLast);
            this.panelOrbit.Controls.Add(this.numericUpDownOrbitDispaly);
            this.panelOrbit.Controls.Add(this.labeli);
            this.panelOrbit.Controls.Add(this.labelPlus);
            this.panelOrbit.Controls.Add(this.numericUpDownSeed);
            this.panelOrbit.Controls.Add(this.labelSeed);
            this.panelOrbit.Controls.Add(this.labelComplexParam);
            this.panelOrbit.Controls.Add(this.numericUpDownReal);
            this.panelOrbit.Controls.Add(this.numericUpDownComplex);
            this.panelOrbit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOrbit.Location = new System.Drawing.Point(0, 0);
            this.panelOrbit.Name = "panelOrbit";
            this.panelOrbit.Size = new System.Drawing.Size(624, 32);
            this.panelOrbit.TabIndex = 1;
            this.panelOrbit.Visible = false;
            // 
            // numericUpDownSierp
            // 
            this.numericUpDownSierp.Location = new System.Drawing.Point(95, 6);
            this.numericUpDownSierp.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownSierp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSierp.Name = "numericUpDownSierp";
            this.numericUpDownSierp.Size = new System.Drawing.Size(67, 20);
            this.numericUpDownSierp.TabIndex = 11;
            this.numericUpDownSierp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSierp.ValueChanged += new System.EventHandler(this.numericUpDownSierp_ValueChanged);
            // 
            // labelBoxFractal
            // 
            this.labelBoxFractal.AutoSize = true;
            this.labelBoxFractal.Font = new System.Drawing.Font("Lucida Console", 9.75F);
            this.labelBoxFractal.Location = new System.Drawing.Point(10, 9);
            this.labelBoxFractal.Name = "labelBoxFractal";
            this.labelBoxFractal.Size = new System.Drawing.Size(79, 13);
            this.labelBoxFractal.TabIndex = 10;
            this.labelBoxFractal.Text = "Precision";
            // 
            // numericUpDownBoxFractal
            // 
            this.numericUpDownBoxFractal.DecimalPlaces = 2;
            this.numericUpDownBoxFractal.Location = new System.Drawing.Point(95, 5);
            this.numericUpDownBoxFractal.Maximum = new decimal(new int[] {
            125,
            0,
            0,
            0});
            this.numericUpDownBoxFractal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownBoxFractal.Name = "numericUpDownBoxFractal";
            this.numericUpDownBoxFractal.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownBoxFractal.TabIndex = 9;
            this.numericUpDownBoxFractal.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownBoxFractal.ValueChanged += new System.EventHandler(this.numericUpDownBoxFractal_ValueChanged);
            // 
            // labelViewLast
            // 
            this.labelViewLast.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewLast.Location = new System.Drawing.Point(128, 8);
            this.labelViewLast.Name = "labelViewLast";
            this.labelViewLast.Size = new System.Drawing.Size(86, 16);
            this.labelViewLast.TabIndex = 8;
            this.labelViewLast.Tag = "This program does 50 iterations, change this value to see the last (number) of th" +
                "ese.";
            this.labelViewLast.Text = "View Last:";
            this.labelViewLast.Visible = false;
            // 
            // numericUpDownOrbitDispaly
            // 
            this.numericUpDownOrbitDispaly.Location = new System.Drawing.Point(224, 4);
            this.numericUpDownOrbitDispaly.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownOrbitDispaly.Name = "numericUpDownOrbitDispaly";
            this.numericUpDownOrbitDispaly.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownOrbitDispaly.TabIndex = 7;
            this.numericUpDownOrbitDispaly.Tag = "Change this value to see the last number of iterations. This program only goes up" +
                " to the first 50.";
            this.numericUpDownOrbitDispaly.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownOrbitDispaly.Visible = false;
            this.numericUpDownOrbitDispaly.ValueChanged += new System.EventHandler(this.Form1_Resize);
            // 
            // labeli
            // 
            this.labeli.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeli.Location = new System.Drawing.Point(288, 8);
            this.labeli.Name = "labeli";
            this.labeli.Size = new System.Drawing.Size(14, 16);
            this.labeli.TabIndex = 6;
            this.labeli.Tag = "Represents the imaginary value";
            this.labeli.Text = "i";
            this.labeli.Visible = false;
            // 
            // labelPlus
            // 
            this.labelPlus.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlus.Location = new System.Drawing.Point(216, 8);
            this.labelPlus.Name = "labelPlus";
            this.labelPlus.Size = new System.Drawing.Size(14, 16);
            this.labelPlus.TabIndex = 5;
            this.labelPlus.Text = "+";
            this.labelPlus.Visible = false;
            // 
            // numericUpDownSeed
            // 
            this.numericUpDownSeed.DecimalPlaces = 3;
            this.numericUpDownSeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownSeed.Location = new System.Drawing.Point(64, 4);
            this.numericUpDownSeed.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownSeed.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            this.numericUpDownSeed.Name = "numericUpDownSeed";
            this.numericUpDownSeed.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownSeed.TabIndex = 1;
            this.numericUpDownSeed.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDownSeed.Visible = false;
            this.numericUpDownSeed.ValueChanged += new System.EventHandler(this.Form1_Resize);
            // 
            // labelSeed
            // 
            this.labelSeed.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeed.Location = new System.Drawing.Point(8, 8);
            this.labelSeed.Name = "labelSeed";
            this.labelSeed.Size = new System.Drawing.Size(56, 16);
            this.labelSeed.TabIndex = 0;
            this.labelSeed.Tag = "Change the seed value of where the orbit orbit analysis begins";
            this.labelSeed.Text = "Seed:";
            this.labelSeed.Visible = false;
            // 
            // labelComplexParam
            // 
            this.labelComplexParam.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComplexParam.Location = new System.Drawing.Point(8, 8);
            this.labelComplexParam.Name = "labelComplexParam";
            this.labelComplexParam.Size = new System.Drawing.Size(152, 16);
            this.labelComplexParam.TabIndex = 4;
            this.labelComplexParam.Tag = "Change these values to manipulate the Julia Set";
            this.labelComplexParam.Text = "Complex Parameter:";
            this.labelComplexParam.Visible = false;
            // 
            // numericUpDownReal
            // 
            this.numericUpDownReal.DecimalPlaces = 3;
            this.numericUpDownReal.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownReal.Location = new System.Drawing.Point(168, 4);
            this.numericUpDownReal.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownReal.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            -2147483648});
            this.numericUpDownReal.Name = "numericUpDownReal";
            this.numericUpDownReal.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownReal.TabIndex = 2;
            this.numericUpDownReal.Tag = "Changes this value, that represents the reals, to see the changes in the Julia Se" +
                "t.";
            this.numericUpDownReal.Value = new decimal(new int[] {
            290,
            0,
            0,
            196608});
            this.numericUpDownReal.Visible = false;
            this.numericUpDownReal.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDownComplex
            // 
            this.numericUpDownComplex.DecimalPlaces = 3;
            this.numericUpDownComplex.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownComplex.Location = new System.Drawing.Point(232, 4);
            this.numericUpDownComplex.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownComplex.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            -2147483648});
            this.numericUpDownComplex.Name = "numericUpDownComplex";
            this.numericUpDownComplex.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownComplex.TabIndex = 3;
            this.numericUpDownComplex.Tag = "Changes this value, that represents the imaginary, to see the changes in the Juli" +
                "a Set. ";
            this.numericUpDownComplex.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147418112});
            this.numericUpDownComplex.Visible = false;
            this.numericUpDownComplex.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.Red;
            this.colorDialog1.ShowHelp = true;
            this.colorDialog1.SolidColorOnly = true;
            // 
            // colorDialog2
            // 
            this.colorDialog2.Color = System.Drawing.Color.White;
            this.colorDialog2.ShowHelp = true;
            this.colorDialog2.SolidColorOnly = true;
            // 
            // colorDialog3
            // 
            this.colorDialog3.ShowHelp = true;
            this.colorDialog3.SolidColorOnly = true;
            // 
            // colorDialogComplex1
            // 
            this.colorDialogComplex1.ShowHelp = true;
            this.colorDialogComplex1.SolidColorOnly = true;
            // 
            // colorDialogComplex2
            // 
            this.colorDialogComplex2.Color = System.Drawing.Color.Navy;
            this.colorDialogComplex2.ShowHelp = true;
            this.colorDialogComplex2.SolidColorOnly = true;
            // 
            // colorDialogComplex3
            // 
            this.colorDialogComplex3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colorDialogComplex3.ShowHelp = true;
            this.colorDialogComplex3.SolidColorOnly = true;
            // 
            // colorDialogComplex4
            // 
            this.colorDialogComplex4.Color = System.Drawing.Color.Blue;
            this.colorDialogComplex4.ShowHelp = true;
            this.colorDialogComplex4.SolidColorOnly = true;
            // 
            // colorDialogComplex5
            // 
            this.colorDialogComplex5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.colorDialogComplex5.ShowHelp = true;
            this.colorDialogComplex5.SolidColorOnly = true;
            // 
            // colorDialogComplex6
            // 
            this.colorDialogComplex6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.colorDialogComplex6.ShowHelp = true;
            this.colorDialogComplex6.SolidColorOnly = true;
            // 
            // colorDialogComplex7
            // 
            this.colorDialogComplex7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.colorDialogComplex7.ShowHelp = true;
            // 
            // colorDialogComplex8
            // 
            this.colorDialogComplex8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colorDialogComplex8.ShowHelp = true;
            this.colorDialogComplex8.SolidColorOnly = true;
            // 
            // colorDialogComplex9
            // 
            this.colorDialogComplex9.Color = System.Drawing.Color.Gray;
            this.colorDialogComplex9.ShowHelp = true;
            this.colorDialogComplex9.SolidColorOnly = true;
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "Fractal Viewer";
            this.printDocument1.OriginAtMargins = true;
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.UseAntiAlias = true;
            this.printPreviewDialog1.Visible = false;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(624, 281);
            this.Controls.Add(this.panelOrbit);
            this.Controls.Add(this.pictureBox1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Tag = "Fractal Viewer allows you to view some  of the images in Chaotic Dynamical System" +
                "s";
            this.Text = "Fractal Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelOrbit.ResumeLayout(false);
            this.panelOrbit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSierp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBoxFractal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrbitDispaly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownComplex)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main() 
		{
			Application.Run(new Form1());
		}



		private Bitmap backBuffer;

		protected override void OnPaintBackground(PaintEventArgs preventJ)
		{
		}

		public void PictureBoxPaint(object sender, System.Windows.Forms.PaintEventArgs e)
		{

			if(backBuffer == null)
			{
				backBuffer = new Bitmap(this.pictureBox1.Width,this.pictureBox1.Height);
			}
			Graphics g = Graphics.FromImage(backBuffer);
            //g.PageUnit = GraphicsUnit.Document;
            Color[] ComplexColors = new Color[9];
            ComplexColors[0] = this.colorDialogComplex1.Color;
            ComplexColors[1] = this.colorDialogComplex2.Color;
            ComplexColors[2] = this.colorDialogComplex3.Color;
            ComplexColors[3] = this.colorDialogComplex4.Color;
            ComplexColors[4] = this.colorDialogComplex5.Color;
            ComplexColors[5] = this.colorDialogComplex6.Color;
            ComplexColors[6] = this.colorDialogComplex7.Color;
            ComplexColors[7] = this.colorDialogComplex8.Color;
            ComplexColors[8] = this.colorDialogComplex9.Color;
			

			#region orbit
			if(menuItemOrbit_XsquareMinus2.Checked)
			{
                FractalViewer.Orbit orbit = new Orbit(g, this.colorDialog1.Color, (float)this.numericUpDownSeed.Value, (int)this.numericUpDownOrbitDispaly.Value);
                this.Cursor = Cursors.WaitCursor;
                orbit.Draw(this.pictureBox1.Width, this.pictureBox1.Height);
                this.Cursor = Cursors.Default;
			}
			#endregion
			#region mandelbrot
			else if(this.menuItemMandelbrotSet.Checked)
			{
                FractalViewer.Mandelbrot mandelbrot = new Mandelbrot(g,ComplexColors);
                this.Cursor = Cursors.WaitCursor;
                mandelbrot.draw(this.pictureBox1.Width, this.pictureBox1.Height);
                this.Cursor = Cursors.Default;
			}
			#endregion
			#region julia set
			else if(this.menuItemJuliaSet.Checked)
			{
                FractalViewer.JuliaSet juliaset = new JuliaSet(g,ComplexColors);
                this.Cursor = Cursors.WaitCursor;
                juliaset.draw(this.pictureBox1.Width, this.pictureBox1.Height, (float)this.numericUpDownReal.Value, (float)this.numericUpDownComplex.Value);
                this.Cursor = Cursors.Default;
			}
				#endregion
			#region sierpinski triangle
			else if(this.menuItemSierpinskiTriangle.Checked)
			{
                FractalViewer.SierpinskiTriangle sierp = new SierpinskiTriangle(g, this.colorDialog3.Color);
                this.Cursor = Cursors.WaitCursor;
                g.Clear(this.colorDialog2.Color);
                sierp.draw(pictureBox1.Width, pictureBox1.Height, (float)this.numericUpDownSierp.Value);
                this.Cursor = Cursors.Default;
			}
			#endregion
			#region newton's method
            else if (this.menuItem7.Checked)
            {
                FractalViewer.NewtonsMethod newton = new NewtonsMethod(g, ComplexColors);
                this.Cursor = Cursors.WaitCursor;
                newton.draw(this.pictureBox1.Width, this.pictureBox1.Height);
                this.Cursor = Cursors.Default;
            }
            #endregion
            #region Box Fractal
            else if (this.menuItemBoxFractal.Checked)
            {
                FractalViewer.BoxFractal box = new BoxFractal(g, this.colorDialog2.Color, this.colorDialog3.Color, (float)this.numericUpDownBoxFractal.Value);
                this.Cursor = Cursors.WaitCursor;
                box.draw(this.pictureBox1.Width, this.pictureBox1.Height);
                this.Cursor = Cursors.Default;
            }
			#endregion
			g.Dispose();
            e.Graphics.DrawImageUnscaled(backBuffer, 0, 0,this.pictureBox1.Width/700,this.pictureBox1.Height/700);

            
           
		}

		private void Form1_Resize(object sender, System.EventArgs e)
		{
			if(backBuffer != null)
			{
				backBuffer.Dispose();
				backBuffer = null;
			}
			this.pictureBox1.BackColor = this.colorDialog2.Color;
			this.pictureBox1.Invalidate();
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			this.labelViewLast.Visible = true;
			this.numericUpDownOrbitDispaly.Visible = true;
			this.menuItemOrbit_XsquareMinus2.Checked = true;
			this.menuItemMandelbrotSet.Checked = false;
			this.menuItemJuliaSet.Checked = false;
			this.menuItemSierpinskiTriangle.Checked = false;
			this.menuItem7.Checked = false;
			this.labelSeed.Visible = true;
			this.menuItemBoxFractal.Checked = false;
			this.labelComplexParam.Visible = false;
			this.labeli.Visible = false;
			this.labelPlus.Visible = false;
			this.numericUpDownComplex.Visible = false;
			this.numericUpDownReal.Visible = false;
            this.panelOrbit.Visible = true;
            this.labelBoxFractal.Visible = false;
            this.numericUpDownBoxFractal.Visible = false;
            this.numericUpDownSierp.Visible = false;
			

			this.numericUpDownSeed.Visible = true;
			backBuffer = null;
			this.pictureBox1.Invalidate();
			
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			this.labelViewLast.Visible = false;
			this.numericUpDownOrbitDispaly.Visible = false;
			this.menuItemOrbit_XsquareMinus2.Checked = false;
			this.menuItemMandelbrotSet.Checked = true;
			this.menuItemJuliaSet.Checked = false;
			this.labelSeed.Visible = false;
			this.menuItemSierpinskiTriangle.Checked = false;
			this.menuItem7.Checked = false;
			this.menuItemBoxFractal.Checked = false;
			this.numericUpDownSeed.Visible = false;
			this.labelComplexParam.Visible = false;
			this.labeli.Visible = false;
			this.labelPlus.Visible = false;
            this.panelOrbit.Visible = false;
            this.labelBoxFractal.Visible = false;
            this.numericUpDownBoxFractal.Visible = false;
            this.numericUpDownSierp.Visible = false;

			this.numericUpDownComplex.Visible = false;
			this.numericUpDownReal.Visible = false;
			backBuffer = null;
			this.pictureBox1.Invalidate();
		}


		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			this.labelViewLast.Visible = false;
			this.numericUpDownOrbitDispaly.Visible = false;
			this.menuItemOrbit_XsquareMinus2.Checked = false;
			this.menuItemMandelbrotSet.Checked = false;
			this.menuItemJuliaSet.Checked = true;
			this.menuItemSierpinskiTriangle.Checked = false;
			this.menuItem7.Checked = false;
			this.labelSeed.Visible = false;
			this.menuItemBoxFractal.Checked = false;
			this.numericUpDownSeed.Visible = false;
			this.labelComplexParam.Visible = true;
            this.panelOrbit.Visible = true;
            this.labelBoxFractal.Visible = false;
            this.numericUpDownBoxFractal.Visible = false;
            this.numericUpDownSierp.Visible = false;

			this.labeli.Visible = true;
			this.labelPlus.Visible = true;
			this.numericUpDownComplex.Visible = true;
			this.numericUpDownReal.Visible = true;
			backBuffer = null;
			this.pictureBox1.Invalidate();

		}

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
		{
			this.pictureBox1.Invalidate();
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
            this.labelViewLast.Visible = false;
            this.numericUpDownOrbitDispaly.Visible = false;
            this.labelSeed.Visible = false;
            this.numericUpDownSeed.Visible = false;
            this.menuItemOrbit_XsquareMinus2.Checked = false;
            this.menuItemMandelbrotSet.Checked = false;
            this.menuItemJuliaSet.Checked = false;
            this.menuItemSierpinskiTriangle.Checked = true;
            this.menuItemBoxFractal.Checked = false;
            this.menuItem7.Checked = false;
            this.labelComplexParam.Visible = false;
            this.labeli.Visible = false;
            this.labelPlus.Visible = false;
            this.numericUpDownComplex.Visible = false;
            this.numericUpDownReal.Visible = false;
            this.panelOrbit.Visible = true;
            this.labelBoxFractal.Visible = true;
            this.numericUpDownBoxFractal.Visible = false;
            this.numericUpDownSierp.Visible = true;


            this.backBuffer = null;
            this.pictureBox1.Invalidate();
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			this.labelViewLast.Visible = false;
			this.numericUpDownOrbitDispaly.Visible = false;
			this.labelSeed.Visible = false;
			this.numericUpDownSeed.Visible = false;
			this.menuItemOrbit_XsquareMinus2.Checked = false;
			this.menuItemMandelbrotSet.Checked = false;
			this.menuItemJuliaSet.Checked = false;
			this.menuItemSierpinskiTriangle.Checked = false;
			this.menuItem7.Checked = true;
			this.menuItemBoxFractal.Checked = false;
			this.labelComplexParam.Visible = false;
			this.labeli.Visible = false;
			this.labelPlus.Visible = false;
			this.numericUpDownComplex.Visible = false;
			this.numericUpDownReal.Visible = false;
            this.panelOrbit.Visible = false;
            this.labelBoxFractal.Visible = false;
            this.numericUpDownBoxFractal.Visible = false;
            this.numericUpDownSierp.Visible = false;

			this.backBuffer = null;
			this.pictureBox1.Invalidate();
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			this.labelViewLast.Visible = false;
			this.numericUpDownOrbitDispaly.Visible = false;
			this.labelSeed.Visible = false;
			this.numericUpDownSeed.Visible = false;
			this.menuItemOrbit_XsquareMinus2.Checked = false;
			this.menuItemMandelbrotSet.Checked = false;
			this.menuItemJuliaSet.Checked = false;
			this.menuItemSierpinskiTriangle.Checked = false;
			this.menuItem7.Checked = false;
			this.menuItemBoxFractal.Checked = true;
			this.labelComplexParam.Visible = false;
			this.labeli.Visible = false;
			this.labelPlus.Visible = false;
			this.numericUpDownComplex.Visible = false;
			this.numericUpDownReal.Visible = false;
            this.panelOrbit.Visible = true;
            this.labelBoxFractal.Visible = true;
            this.numericUpDownBoxFractal.Visible = true;
            this.numericUpDownSierp.Visible = false;


			this.backBuffer = null;
			this.pictureBox1.Invalidate();
		}

		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Developed by William Andrus (c) 2006-2008 All Right Reserved.\nVersion 1.3\n\nResource:\"A First Course in Chaotic Dynamical Systems\" by Robert L. Devaney","About Fractal Viewer",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		private void menuItem12_Click(object sender, System.EventArgs e)
		{	
			SaveImage saveimage = new SaveImage(this.backBuffer);
			saveimage.Show();
		}

		private void menuItem15_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void menuItem17_Click(object sender, System.EventArgs e)
		{
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Refresh();
            }
		}

		private void menuItem18_Click(object sender, System.EventArgs e)
		{
            if (this.colorDialog2.ShowDialog() == DialogResult.OK)
            {
                this.Refresh();
                this.pictureBox1.BackColor = colorDialog2.Color;
            }
		}

		private void menuItem20_Click(object sender, System.EventArgs e)
		{
            if (this.colorDialog3.ShowDialog() == DialogResult.OK)
            {
                this.Refresh();
            }
		}

		private void menuItem22_Click(object sender, System.EventArgs e)
		{
            if (this.colorDialogComplex1.ShowDialog() == DialogResult.OK)
            {
                this.Refresh();
            }
		}

		private void menuItem23_Click(object sender, System.EventArgs e)
		{
            if (this.colorDialogComplex2.ShowDialog() == DialogResult.OK)
            {
                this.Refresh();
            }
		}

		private void menuItem24_Click(object sender, System.EventArgs e)
		{
            if (this.colorDialogComplex3.ShowDialog() == DialogResult.OK)
            {
                this.Refresh();
            }
		}

		private void menuItem25_Click(object sender, System.EventArgs e)
		{
            if (this.colorDialogComplex4.ShowDialog() == DialogResult.OK)
            {
                this.Refresh();
            }
		}

		private void menuItem26_Click(object sender, System.EventArgs e)
		{
            if (this.colorDialogComplex5.ShowDialog() == DialogResult.OK)
            {
                this.Refresh();
            }
		}

		private void menuItem27_Click(object sender, System.EventArgs e)
		{
            if (this.colorDialogComplex6.ShowDialog() == DialogResult.OK)
            {
                this.Refresh();
            }
		}

		private void menuItem28_Click(object sender, System.EventArgs e)
		{
            if (this.colorDialogComplex7.ShowDialog() == DialogResult.OK)
            {
                this.Refresh();
            }
		}

		private void menuItem29_Click(object sender, System.EventArgs e)
		{
            if (this.colorDialogComplex8.ShowDialog() == DialogResult.OK)
            {
                this.Refresh();
            }
		}

		private void menuItem30_Click(object sender, System.EventArgs e)
		{
            if (this.colorDialogComplex9.ShowDialog() == DialogResult.OK)
            {
                this.Refresh();
            }
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{

			e.Graphics.DrawImage(this.backBuffer,new System.Drawing.Rectangle(0,0,this.pageSetupDialog1.PageSettings.PaperSize.Width,this.pageSetupDialog1.PageSettings.PaperSize.Height));
		}

		private void menuItem36_Click(object sender, System.EventArgs e)
		{
			
			this.printDocument1.Print();
		}

		private void menuItem37_Click(object sender, System.EventArgs e)
		{
			this.pageSetupDialog1.ShowDialog();
		}

		private void menuItem38_Click(object sender, System.EventArgs e)
		{
			Form1 newForm = new Form1();
			newForm.Show();
		}

        private void numericUpDownBoxFractal_ValueChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Invalidate();
        }

        private void numericUpDownSierp_ValueChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Invalidate();
        }
	}
}
