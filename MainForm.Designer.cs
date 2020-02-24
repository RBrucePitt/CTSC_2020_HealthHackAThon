namespace SAI_AM
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.Button_MF_LoadImageSet = new System.Windows.Forms.Button();
            this.Label_PatientName = new System.Windows.Forms.Label();
            this.TextBox_MF_PatientName = new System.Windows.Forms.TextBox();
            this.Label_MF_ControlNumber = new System.Windows.Forms.Label();
            this.TextBox_MF_ControlNumber = new System.Windows.Forms.TextBox();
            this.TextBox_MF_DoctorId = new System.Windows.Forms.TextBox();
            this.Label_DoctorId = new System.Windows.Forms.Label();
            this.Label_MF_ImageLocation = new System.Windows.Forms.Label();
            this.TextBox_MF_ImageLocatoin = new System.Windows.Forms.TextBox();
            this.Button_MF_Browse = new System.Windows.Forms.Button();
            this.PictureBox_MF_Raw = new System.Windows.Forms.PictureBox();
            this.PictureBox_MF_Processed = new System.Windows.Forms.PictureBox();
            this.TextBox_Raw_Status = new System.Windows.Forms.TextBox();
            this.Label_MF_RawStatus = new System.Windows.Forms.Label();
            this.Label_MF_ProcessingStatus = new System.Windows.Forms.Label();
            this.TextBox_ProcStatus = new System.Windows.Forms.TextBox();
            this.Button_MF_Struct1 = new System.Windows.Forms.Button();
            this.Button_MF_Struct2 = new System.Windows.Forms.Button();
            this.Button_MF_Struct3 = new System.Windows.Forms.Button();
            this.Button_MF_Struct4 = new System.Windows.Forms.Button();
            this.Button_MF_Struct5 = new System.Windows.Forms.Button();
            this.Button_MF_Struct6 = new System.Windows.Forms.Button();
            this.Button_MF_Struct7 = new System.Windows.Forms.Button();
            this.Button_MF_Struct8 = new System.Windows.Forms.Button();
            this.Button_MF_Struct9 = new System.Windows.Forms.Button();
            this.Button_MF_Struct10 = new System.Windows.Forms.Button();
            this.Button_MF_Struct11 = new System.Windows.Forms.Button();
            this.Button_MF_Struct12 = new System.Windows.Forms.Button();
            this.Button_MF_Search = new System.Windows.Forms.Button();
            this.ComboBox_MF_SetArea = new System.Windows.Forms.ComboBox();
            this.Label_MF_ImageSetArea = new System.Windows.Forms.Label();
            this.Button_MF_Exit = new System.Windows.Forms.Button();
            this.Button_MF_Help = new System.Windows.Forms.Button();
            this.Button_MF_About = new System.Windows.Forms.Button();
            this.Button_MF_LoadPatient = new System.Windows.Forms.Button();
            this.ComboBox_MF_Gender = new System.Windows.Forms.ComboBox();
            this.Label_MF_Gender = new System.Windows.Forms.Label();
            this.Label_MF_Age = new System.Windows.Forms.Label();
            this.TextBox_MF_Age = new System.Windows.Forms.TextBox();
            this.Label_MF_PatientFile = new System.Windows.Forms.Label();
            this.TextBox_MF_PatientFile = new System.Windows.Forms.TextBox();
            this.TextBox_MF_RawImageNo = new System.Windows.Forms.TextBox();
            this.Label_MF_RawImageNo = new System.Windows.Forms.Label();
            this.Button_MF_Raw_Left = new System.Windows.Forms.Button();
            this.Button_MF_Raw_Right = new System.Windows.Forms.Button();
            this.Button_MF_Proc_Right = new System.Windows.Forms.Button();
            this.Button_MF_Proc_Left = new System.Windows.Forms.Button();
            this.TextBox_MF_ProcImageNo = new System.Windows.Forms.TextBox();
            this.Label_MF_ProcImageNo = new System.Windows.Forms.Label();
            this.Button_MF_ColorMode = new System.Windows.Forms.Button();
            this.Button_MF_AnnotateMode = new System.Windows.Forms.Button();
            this.TextBox_X_Right = new System.Windows.Forms.TextBox();
            this.TextBox_Y_Right = new System.Windows.Forms.TextBox();
            this.TextBox_MF_Y_Left = new System.Windows.Forms.TextBox();
            this.TextBox_MF_X_Left = new System.Windows.Forms.TextBox();
            this.TextBox_Left_Color = new System.Windows.Forms.TextBox();
            this.TextBox_Right_Color = new System.Windows.Forms.TextBox();
            this.Timer_MF_LoadDoneCheck = new System.Windows.Forms.Timer(this.components);
            this.TextBox_MF_BrainArea = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_MF_Raw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_MF_Processed)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_MF_LoadImageSet
            // 
            this.Button_MF_LoadImageSet.Location = new System.Drawing.Point(791, 72);
            this.Button_MF_LoadImageSet.Name = "Button_MF_LoadImageSet";
            this.Button_MF_LoadImageSet.Size = new System.Drawing.Size(212, 23);
            this.Button_MF_LoadImageSet.TabIndex = 0;
            this.Button_MF_LoadImageSet.Text = "Load Image Set";
            this.Button_MF_LoadImageSet.UseVisualStyleBackColor = true;
            this.Button_MF_LoadImageSet.Click += new System.EventHandler(this.Button_MF_LoadImageSet_Click);
            // 
            // Label_PatientName
            // 
            this.Label_PatientName.AutoSize = true;
            this.Label_PatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PatientName.Location = new System.Drawing.Point(24, 22);
            this.Label_PatientName.Name = "Label_PatientName";
            this.Label_PatientName.Size = new System.Drawing.Size(87, 13);
            this.Label_PatientName.TabIndex = 1;
            this.Label_PatientName.Text = "Patient Name:";
            // 
            // TextBox_MF_PatientName
            // 
            this.TextBox_MF_PatientName.Location = new System.Drawing.Point(117, 18);
            this.TextBox_MF_PatientName.Name = "TextBox_MF_PatientName";
            this.TextBox_MF_PatientName.Size = new System.Drawing.Size(212, 20);
            this.TextBox_MF_PatientName.TabIndex = 2;
            this.TextBox_MF_PatientName.Text = "Alice Doe";
            // 
            // Label_MF_ControlNumber
            // 
            this.Label_MF_ControlNumber.AutoSize = true;
            this.Label_MF_ControlNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MF_ControlNumber.Location = new System.Drawing.Point(350, 21);
            this.Label_MF_ControlNumber.Name = "Label_MF_ControlNumber";
            this.Label_MF_ControlNumber.Size = new System.Drawing.Size(115, 13);
            this.Label_MF_ControlNumber.TabIndex = 3;
            this.Label_MF_ControlNumber.Text = "Id/Control Number:";
            // 
            // TextBox_MF_ControlNumber
            // 
            this.TextBox_MF_ControlNumber.Location = new System.Drawing.Point(471, 18);
            this.TextBox_MF_ControlNumber.Name = "TextBox_MF_ControlNumber";
            this.TextBox_MF_ControlNumber.Size = new System.Drawing.Size(120, 20);
            this.TextBox_MF_ControlNumber.TabIndex = 4;
            this.TextBox_MF_ControlNumber.Text = "9974CF123-002";
            // 
            // TextBox_MF_DoctorId
            // 
            this.TextBox_MF_DoctorId.Location = new System.Drawing.Point(117, 45);
            this.TextBox_MF_DoctorId.Name = "TextBox_MF_DoctorId";
            this.TextBox_MF_DoctorId.Size = new System.Drawing.Size(212, 20);
            this.TextBox_MF_DoctorId.TabIndex = 6;
            this.TextBox_MF_DoctorId.Text = "Dr. Immediately";
            // 
            // Label_DoctorId
            // 
            this.Label_DoctorId.AutoSize = true;
            this.Label_DoctorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DoctorId.Location = new System.Drawing.Point(24, 48);
            this.Label_DoctorId.Name = "Label_DoctorId";
            this.Label_DoctorId.Size = new System.Drawing.Size(64, 13);
            this.Label_DoctorId.TabIndex = 5;
            this.Label_DoctorId.Text = "Doctor Id:";
            // 
            // Label_MF_ImageLocation
            // 
            this.Label_MF_ImageLocation.AutoSize = true;
            this.Label_MF_ImageLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MF_ImageLocation.Location = new System.Drawing.Point(23, 77);
            this.Label_MF_ImageLocation.Name = "Label_MF_ImageLocation";
            this.Label_MF_ImageLocation.Size = new System.Drawing.Size(112, 13);
            this.Label_MF_ImageLocation.TabIndex = 7;
            this.Label_MF_ImageLocation.Text = "Image(s) Location:";
            // 
            // TextBox_MF_ImageLocatoin
            // 
            this.TextBox_MF_ImageLocatoin.Location = new System.Drawing.Point(141, 73);
            this.TextBox_MF_ImageLocatoin.Name = "TextBox_MF_ImageLocatoin";
            this.TextBox_MF_ImageLocatoin.Size = new System.Drawing.Size(229, 20);
            this.TextBox_MF_ImageLocatoin.TabIndex = 8;
            this.TextBox_MF_ImageLocatoin.Text = "D:\\BrainScanning\\images\\Test2\\MainSeq";
            // 
            // Button_MF_Browse
            // 
            this.Button_MF_Browse.Location = new System.Drawing.Point(385, 72);
            this.Button_MF_Browse.Name = "Button_MF_Browse";
            this.Button_MF_Browse.Size = new System.Drawing.Size(99, 23);
            this.Button_MF_Browse.TabIndex = 9;
            this.Button_MF_Browse.Text = "Browse";
            this.Button_MF_Browse.UseVisualStyleBackColor = true;
            this.Button_MF_Browse.Click += new System.EventHandler(this.Button_MF_Browse_Click);
            // 
            // PictureBox_MF_Raw
            // 
            this.PictureBox_MF_Raw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox_MF_Raw.Location = new System.Drawing.Point(36, 156);
            this.PictureBox_MF_Raw.Name = "PictureBox_MF_Raw";
            this.PictureBox_MF_Raw.Size = new System.Drawing.Size(397, 428);
            this.PictureBox_MF_Raw.TabIndex = 10;
            this.PictureBox_MF_Raw.TabStop = false;
            this.PictureBox_MF_Raw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MF_Raw_MouseMove);
            // 
            // PictureBox_MF_Processed
            // 
            this.PictureBox_MF_Processed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox_MF_Processed.Location = new System.Drawing.Point(591, 156);
            this.PictureBox_MF_Processed.Name = "PictureBox_MF_Processed";
            this.PictureBox_MF_Processed.Size = new System.Drawing.Size(422, 428);
            this.PictureBox_MF_Processed.TabIndex = 11;
            this.PictureBox_MF_Processed.TabStop = false;
            this.PictureBox_MF_Processed.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MF_Processed_MouseMove);
            // 
            // TextBox_Raw_Status
            // 
            this.TextBox_Raw_Status.Location = new System.Drawing.Point(106, 610);
            this.TextBox_Raw_Status.Name = "TextBox_Raw_Status";
            this.TextBox_Raw_Status.Size = new System.Drawing.Size(318, 20);
            this.TextBox_Raw_Status.TabIndex = 12;
            // 
            // Label_MF_RawStatus
            // 
            this.Label_MF_RawStatus.AutoSize = true;
            this.Label_MF_RawStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MF_RawStatus.Location = new System.Drawing.Point(24, 613);
            this.Label_MF_RawStatus.Name = "Label_MF_RawStatus";
            this.Label_MF_RawStatus.Size = new System.Drawing.Size(76, 13);
            this.Label_MF_RawStatus.TabIndex = 13;
            this.Label_MF_RawStatus.Text = "Raw Status:";
            // 
            // Label_MF_ProcessingStatus
            // 
            this.Label_MF_ProcessingStatus.AutoSize = true;
            this.Label_MF_ProcessingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MF_ProcessingStatus.Location = new System.Drawing.Point(604, 610);
            this.Label_MF_ProcessingStatus.Name = "Label_MF_ProcessingStatus";
            this.Label_MF_ProcessingStatus.Size = new System.Drawing.Size(113, 13);
            this.Label_MF_ProcessingStatus.TabIndex = 15;
            this.Label_MF_ProcessingStatus.Text = "Processing Status:";
            // 
            // TextBox_ProcStatus
            // 
            this.TextBox_ProcStatus.Location = new System.Drawing.Point(723, 607);
            this.TextBox_ProcStatus.Name = "TextBox_ProcStatus";
            this.TextBox_ProcStatus.Size = new System.Drawing.Size(281, 20);
            this.TextBox_ProcStatus.TabIndex = 14;
            // 
            // Button_MF_Struct1
            // 
            this.Button_MF_Struct1.Location = new System.Drawing.Point(448, 156);
            this.Button_MF_Struct1.Name = "Button_MF_Struct1";
            this.Button_MF_Struct1.Size = new System.Drawing.Size(116, 23);
            this.Button_MF_Struct1.TabIndex = 16;
            this.Button_MF_Struct1.Text = "Struct 1";
            this.Button_MF_Struct1.UseVisualStyleBackColor = true;
            this.Button_MF_Struct1.Visible = false;
            // 
            // Button_MF_Struct2
            // 
            this.Button_MF_Struct2.Location = new System.Drawing.Point(448, 192);
            this.Button_MF_Struct2.Name = "Button_MF_Struct2";
            this.Button_MF_Struct2.Size = new System.Drawing.Size(116, 23);
            this.Button_MF_Struct2.TabIndex = 17;
            this.Button_MF_Struct2.Text = "Struct 2";
            this.Button_MF_Struct2.UseVisualStyleBackColor = true;
            this.Button_MF_Struct2.Visible = false;
            // 
            // Button_MF_Struct3
            // 
            this.Button_MF_Struct3.Location = new System.Drawing.Point(448, 228);
            this.Button_MF_Struct3.Name = "Button_MF_Struct3";
            this.Button_MF_Struct3.Size = new System.Drawing.Size(116, 23);
            this.Button_MF_Struct3.TabIndex = 18;
            this.Button_MF_Struct3.Text = "Struct 3";
            this.Button_MF_Struct3.UseVisualStyleBackColor = true;
            this.Button_MF_Struct3.Visible = false;
            // 
            // Button_MF_Struct4
            // 
            this.Button_MF_Struct4.Location = new System.Drawing.Point(448, 264);
            this.Button_MF_Struct4.Name = "Button_MF_Struct4";
            this.Button_MF_Struct4.Size = new System.Drawing.Size(116, 23);
            this.Button_MF_Struct4.TabIndex = 19;
            this.Button_MF_Struct4.Text = "Struct 4";
            this.Button_MF_Struct4.UseVisualStyleBackColor = true;
            this.Button_MF_Struct4.Visible = false;
            // 
            // Button_MF_Struct5
            // 
            this.Button_MF_Struct5.Location = new System.Drawing.Point(448, 300);
            this.Button_MF_Struct5.Name = "Button_MF_Struct5";
            this.Button_MF_Struct5.Size = new System.Drawing.Size(116, 23);
            this.Button_MF_Struct5.TabIndex = 20;
            this.Button_MF_Struct5.Text = "Struct 5";
            this.Button_MF_Struct5.UseVisualStyleBackColor = true;
            this.Button_MF_Struct5.Visible = false;
            // 
            // Button_MF_Struct6
            // 
            this.Button_MF_Struct6.Location = new System.Drawing.Point(448, 336);
            this.Button_MF_Struct6.Name = "Button_MF_Struct6";
            this.Button_MF_Struct6.Size = new System.Drawing.Size(116, 23);
            this.Button_MF_Struct6.TabIndex = 21;
            this.Button_MF_Struct6.Text = "Struct 6";
            this.Button_MF_Struct6.UseVisualStyleBackColor = true;
            this.Button_MF_Struct6.Visible = false;
            // 
            // Button_MF_Struct7
            // 
            this.Button_MF_Struct7.Location = new System.Drawing.Point(448, 372);
            this.Button_MF_Struct7.Name = "Button_MF_Struct7";
            this.Button_MF_Struct7.Size = new System.Drawing.Size(116, 23);
            this.Button_MF_Struct7.TabIndex = 22;
            this.Button_MF_Struct7.Text = "Struct 7";
            this.Button_MF_Struct7.UseVisualStyleBackColor = true;
            this.Button_MF_Struct7.Visible = false;
            // 
            // Button_MF_Struct8
            // 
            this.Button_MF_Struct8.Location = new System.Drawing.Point(448, 408);
            this.Button_MF_Struct8.Name = "Button_MF_Struct8";
            this.Button_MF_Struct8.Size = new System.Drawing.Size(116, 23);
            this.Button_MF_Struct8.TabIndex = 23;
            this.Button_MF_Struct8.Text = "Struct 8";
            this.Button_MF_Struct8.UseVisualStyleBackColor = true;
            this.Button_MF_Struct8.Visible = false;
            // 
            // Button_MF_Struct9
            // 
            this.Button_MF_Struct9.Location = new System.Drawing.Point(448, 444);
            this.Button_MF_Struct9.Name = "Button_MF_Struct9";
            this.Button_MF_Struct9.Size = new System.Drawing.Size(116, 23);
            this.Button_MF_Struct9.TabIndex = 24;
            this.Button_MF_Struct9.Text = "Struct 9";
            this.Button_MF_Struct9.UseVisualStyleBackColor = true;
            this.Button_MF_Struct9.Visible = false;
            // 
            // Button_MF_Struct10
            // 
            this.Button_MF_Struct10.Location = new System.Drawing.Point(448, 480);
            this.Button_MF_Struct10.Name = "Button_MF_Struct10";
            this.Button_MF_Struct10.Size = new System.Drawing.Size(116, 23);
            this.Button_MF_Struct10.TabIndex = 25;
            this.Button_MF_Struct10.Text = "Struct 10";
            this.Button_MF_Struct10.UseVisualStyleBackColor = true;
            this.Button_MF_Struct10.Visible = false;
            // 
            // Button_MF_Struct11
            // 
            this.Button_MF_Struct11.Location = new System.Drawing.Point(448, 516);
            this.Button_MF_Struct11.Name = "Button_MF_Struct11";
            this.Button_MF_Struct11.Size = new System.Drawing.Size(116, 23);
            this.Button_MF_Struct11.TabIndex = 26;
            this.Button_MF_Struct11.Text = "Struct 11";
            this.Button_MF_Struct11.UseVisualStyleBackColor = true;
            this.Button_MF_Struct11.Visible = false;
            // 
            // Button_MF_Struct12
            // 
            this.Button_MF_Struct12.Location = new System.Drawing.Point(448, 552);
            this.Button_MF_Struct12.Name = "Button_MF_Struct12";
            this.Button_MF_Struct12.Size = new System.Drawing.Size(116, 23);
            this.Button_MF_Struct12.TabIndex = 27;
            this.Button_MF_Struct12.Text = "Struct 12";
            this.Button_MF_Struct12.UseVisualStyleBackColor = true;
            this.Button_MF_Struct12.Visible = false;
            // 
            // Button_MF_Search
            // 
            this.Button_MF_Search.Location = new System.Drawing.Point(448, 605);
            this.Button_MF_Search.Name = "Button_MF_Search";
            this.Button_MF_Search.Size = new System.Drawing.Size(116, 23);
            this.Button_MF_Search.TabIndex = 28;
            this.Button_MF_Search.Text = "Search";
            this.Button_MF_Search.UseVisualStyleBackColor = true;
            // 
            // ComboBox_MF_SetArea
            // 
            this.ComboBox_MF_SetArea.FormattingEnabled = true;
            this.ComboBox_MF_SetArea.Items.AddRange(new object[] {
            "Brain",
            "Lungs",
            "Heart",
            "Kidney",
            "Liver",
            "Spine"});
            this.ComboBox_MF_SetArea.Location = new System.Drawing.Point(625, 73);
            this.ComboBox_MF_SetArea.Name = "ComboBox_MF_SetArea";
            this.ComboBox_MF_SetArea.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_MF_SetArea.TabIndex = 29;
            // 
            // Label_MF_ImageSetArea
            // 
            this.Label_MF_ImageSetArea.AutoSize = true;
            this.Label_MF_ImageSetArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MF_ImageSetArea.Location = new System.Drawing.Point(522, 77);
            this.Label_MF_ImageSetArea.Name = "Label_MF_ImageSetArea";
            this.Label_MF_ImageSetArea.Size = new System.Drawing.Size(98, 13);
            this.Label_MF_ImageSetArea.TabIndex = 31;
            this.Label_MF_ImageSetArea.Text = "Image Set Area:";
            // 
            // Button_MF_Exit
            // 
            this.Button_MF_Exit.Location = new System.Drawing.Point(905, 641);
            this.Button_MF_Exit.Name = "Button_MF_Exit";
            this.Button_MF_Exit.Size = new System.Drawing.Size(99, 23);
            this.Button_MF_Exit.TabIndex = 32;
            this.Button_MF_Exit.Text = "Exit";
            this.Button_MF_Exit.UseVisualStyleBackColor = true;
            this.Button_MF_Exit.Click += new System.EventHandler(this.Button_MF_Exit_Click);
            // 
            // Button_MF_Help
            // 
            this.Button_MF_Help.Location = new System.Drawing.Point(791, 641);
            this.Button_MF_Help.Name = "Button_MF_Help";
            this.Button_MF_Help.Size = new System.Drawing.Size(99, 23);
            this.Button_MF_Help.TabIndex = 33;
            this.Button_MF_Help.Text = "Help";
            this.Button_MF_Help.UseVisualStyleBackColor = true;
            this.Button_MF_Help.Click += new System.EventHandler(this.Button_MF_Help_Click);
            // 
            // Button_MF_About
            // 
            this.Button_MF_About.Location = new System.Drawing.Point(676, 641);
            this.Button_MF_About.Name = "Button_MF_About";
            this.Button_MF_About.Size = new System.Drawing.Size(99, 23);
            this.Button_MF_About.TabIndex = 34;
            this.Button_MF_About.Text = "About";
            this.Button_MF_About.UseVisualStyleBackColor = true;
            this.Button_MF_About.Click += new System.EventHandler(this.Button_MF_About_Click);
            // 
            // Button_MF_LoadPatient
            // 
            this.Button_MF_LoadPatient.Location = new System.Drawing.Point(880, 15);
            this.Button_MF_LoadPatient.Name = "Button_MF_LoadPatient";
            this.Button_MF_LoadPatient.Size = new System.Drawing.Size(124, 23);
            this.Button_MF_LoadPatient.TabIndex = 35;
            this.Button_MF_LoadPatient.Text = "Load Patient Data";
            this.Button_MF_LoadPatient.UseVisualStyleBackColor = true;
            this.Button_MF_LoadPatient.Click += new System.EventHandler(this.Button_MF_LoadPatient_Click);
            // 
            // ComboBox_MF_Gender
            // 
            this.ComboBox_MF_Gender.FormattingEnabled = true;
            this.ComboBox_MF_Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "non-Binary"});
            this.ComboBox_MF_Gender.Location = new System.Drawing.Point(408, 45);
            this.ComboBox_MF_Gender.Name = "ComboBox_MF_Gender";
            this.ComboBox_MF_Gender.Size = new System.Drawing.Size(76, 21);
            this.ComboBox_MF_Gender.TabIndex = 36;
            this.ComboBox_MF_Gender.Text = "F";
            // 
            // Label_MF_Gender
            // 
            this.Label_MF_Gender.AutoSize = true;
            this.Label_MF_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MF_Gender.Location = new System.Drawing.Point(350, 51);
            this.Label_MF_Gender.Name = "Label_MF_Gender";
            this.Label_MF_Gender.Size = new System.Drawing.Size(52, 13);
            this.Label_MF_Gender.TabIndex = 37;
            this.Label_MF_Gender.Text = "Gender:";
            // 
            // Label_MF_Age
            // 
            this.Label_MF_Age.AutoSize = true;
            this.Label_MF_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MF_Age.Location = new System.Drawing.Point(512, 48);
            this.Label_MF_Age.Name = "Label_MF_Age";
            this.Label_MF_Age.Size = new System.Drawing.Size(33, 13);
            this.Label_MF_Age.TabIndex = 38;
            this.Label_MF_Age.Text = "Age:";
            // 
            // TextBox_MF_Age
            // 
            this.TextBox_MF_Age.Location = new System.Drawing.Point(551, 45);
            this.TextBox_MF_Age.Name = "TextBox_MF_Age";
            this.TextBox_MF_Age.Size = new System.Drawing.Size(40, 20);
            this.TextBox_MF_Age.TabIndex = 39;
            this.TextBox_MF_Age.Text = "7";
            // 
            // Label_MF_PatientFile
            // 
            this.Label_MF_PatientFile.AutoSize = true;
            this.Label_MF_PatientFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MF_PatientFile.Location = new System.Drawing.Point(604, 21);
            this.Label_MF_PatientFile.Name = "Label_MF_PatientFile";
            this.Label_MF_PatientFile.Size = new System.Drawing.Size(75, 13);
            this.Label_MF_PatientFile.TabIndex = 40;
            this.Label_MF_PatientFile.Text = "Patient File:";
            // 
            // TextBox_MF_PatientFile
            // 
            this.TextBox_MF_PatientFile.Location = new System.Drawing.Point(685, 17);
            this.TextBox_MF_PatientFile.Name = "TextBox_MF_PatientFile";
            this.TextBox_MF_PatientFile.Size = new System.Drawing.Size(189, 20);
            this.TextBox_MF_PatientFile.TabIndex = 41;
            // 
            // TextBox_MF_RawImageNo
            // 
            this.TextBox_MF_RawImageNo.Location = new System.Drawing.Point(253, 121);
            this.TextBox_MF_RawImageNo.Name = "TextBox_MF_RawImageNo";
            this.TextBox_MF_RawImageNo.Size = new System.Drawing.Size(64, 20);
            this.TextBox_MF_RawImageNo.TabIndex = 43;
            // 
            // Label_MF_RawImageNo
            // 
            this.Label_MF_RawImageNo.AutoSize = true;
            this.Label_MF_RawImageNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MF_RawImageNo.Location = new System.Drawing.Point(126, 125);
            this.Label_MF_RawImageNo.Name = "Label_MF_RawImageNo";
            this.Label_MF_RawImageNo.Size = new System.Drawing.Size(121, 13);
            this.Label_MF_RawImageNo.TabIndex = 42;
            this.Label_MF_RawImageNo.Text = "Raw Image Number:";
            // 
            // Button_MF_Raw_Left
            // 
            this.Button_MF_Raw_Left.Location = new System.Drawing.Point(67, 120);
            this.Button_MF_Raw_Left.Name = "Button_MF_Raw_Left";
            this.Button_MF_Raw_Left.Size = new System.Drawing.Size(53, 23);
            this.Button_MF_Raw_Left.TabIndex = 46;
            this.Button_MF_Raw_Left.Text = "<<";
            this.Button_MF_Raw_Left.UseVisualStyleBackColor = true;
            this.Button_MF_Raw_Left.Click += new System.EventHandler(this.Button_MF_Raw_Left_Click);
            // 
            // Button_MF_Raw_Right
            // 
            this.Button_MF_Raw_Right.Location = new System.Drawing.Point(332, 120);
            this.Button_MF_Raw_Right.Name = "Button_MF_Raw_Right";
            this.Button_MF_Raw_Right.Size = new System.Drawing.Size(53, 23);
            this.Button_MF_Raw_Right.TabIndex = 47;
            this.Button_MF_Raw_Right.Text = ">>";
            this.Button_MF_Raw_Right.UseVisualStyleBackColor = true;
            this.Button_MF_Raw_Right.Click += new System.EventHandler(this.Button_MF_Raw_Right_Click);
            // 
            // Button_MF_Proc_Right
            // 
            this.Button_MF_Proc_Right.Location = new System.Drawing.Point(913, 120);
            this.Button_MF_Proc_Right.Name = "Button_MF_Proc_Right";
            this.Button_MF_Proc_Right.Size = new System.Drawing.Size(53, 23);
            this.Button_MF_Proc_Right.TabIndex = 51;
            this.Button_MF_Proc_Right.Text = ">>";
            this.Button_MF_Proc_Right.UseVisualStyleBackColor = true;
            this.Button_MF_Proc_Right.Click += new System.EventHandler(this.Button_MF_Proc_Right_Click);
            // 
            // Button_MF_Proc_Left
            // 
            this.Button_MF_Proc_Left.Location = new System.Drawing.Point(648, 120);
            this.Button_MF_Proc_Left.Name = "Button_MF_Proc_Left";
            this.Button_MF_Proc_Left.Size = new System.Drawing.Size(53, 23);
            this.Button_MF_Proc_Left.TabIndex = 50;
            this.Button_MF_Proc_Left.Text = "<<";
            this.Button_MF_Proc_Left.UseVisualStyleBackColor = true;
            this.Button_MF_Proc_Left.Click += new System.EventHandler(this.Button_MF_Proc_Left_Click);
            // 
            // TextBox_MF_ProcImageNo
            // 
            this.TextBox_MF_ProcImageNo.Location = new System.Drawing.Point(834, 121);
            this.TextBox_MF_ProcImageNo.Name = "TextBox_MF_ProcImageNo";
            this.TextBox_MF_ProcImageNo.Size = new System.Drawing.Size(64, 20);
            this.TextBox_MF_ProcImageNo.TabIndex = 49;
            // 
            // Label_MF_ProcImageNo
            // 
            this.Label_MF_ProcImageNo.AutoSize = true;
            this.Label_MF_ProcImageNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MF_ProcImageNo.Location = new System.Drawing.Point(707, 125);
            this.Label_MF_ProcImageNo.Name = "Label_MF_ProcImageNo";
            this.Label_MF_ProcImageNo.Size = new System.Drawing.Size(121, 13);
            this.Label_MF_ProcImageNo.TabIndex = 48;
            this.Label_MF_ProcImageNo.Text = "Raw Image Number:";
            // 
            // Button_MF_ColorMode
            // 
            this.Button_MF_ColorMode.Location = new System.Drawing.Point(981, 121);
            this.Button_MF_ColorMode.Name = "Button_MF_ColorMode";
            this.Button_MF_ColorMode.Size = new System.Drawing.Size(32, 23);
            this.Button_MF_ColorMode.TabIndex = 52;
            this.Button_MF_ColorMode.Text = "[]";
            this.Button_MF_ColorMode.UseVisualStyleBackColor = true;
            this.Button_MF_ColorMode.Click += new System.EventHandler(this.Button_MF_ColorMode_Click);
            // 
            // Button_MF_AnnotateMode
            // 
            this.Button_MF_AnnotateMode.Location = new System.Drawing.Point(591, 121);
            this.Button_MF_AnnotateMode.Name = "Button_MF_AnnotateMode";
            this.Button_MF_AnnotateMode.Size = new System.Drawing.Size(32, 23);
            this.Button_MF_AnnotateMode.TabIndex = 53;
            this.Button_MF_AnnotateMode.Text = "][";
            this.Button_MF_AnnotateMode.UseVisualStyleBackColor = true;
            this.Button_MF_AnnotateMode.Click += new System.EventHandler(this.Button_MF_AnnotateMode_Click);
            // 
            // TextBox_X_Right
            // 
            this.TextBox_X_Right.Location = new System.Drawing.Point(370, 643);
            this.TextBox_X_Right.Name = "TextBox_X_Right";
            this.TextBox_X_Right.Size = new System.Drawing.Size(32, 20);
            this.TextBox_X_Right.TabIndex = 54;
            // 
            // TextBox_Y_Right
            // 
            this.TextBox_Y_Right.Location = new System.Drawing.Point(408, 643);
            this.TextBox_Y_Right.Name = "TextBox_Y_Right";
            this.TextBox_Y_Right.Size = new System.Drawing.Size(36, 20);
            this.TextBox_Y_Right.TabIndex = 55;
            // 
            // TextBox_MF_Y_Left
            // 
            this.TextBox_MF_Y_Left.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.TextBox_MF_Y_Left.Location = new System.Drawing.Point(83, 644);
            this.TextBox_MF_Y_Left.Name = "TextBox_MF_Y_Left";
            this.TextBox_MF_Y_Left.Size = new System.Drawing.Size(37, 20);
            this.TextBox_MF_Y_Left.TabIndex = 57;
            // 
            // TextBox_MF_X_Left
            // 
            this.TextBox_MF_X_Left.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.TextBox_MF_X_Left.Location = new System.Drawing.Point(36, 644);
            this.TextBox_MF_X_Left.Name = "TextBox_MF_X_Left";
            this.TextBox_MF_X_Left.Size = new System.Drawing.Size(41, 20);
            this.TextBox_MF_X_Left.TabIndex = 56;
            // 
            // TextBox_Left_Color
            // 
            this.TextBox_Left_Color.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.TextBox_Left_Color.Location = new System.Drawing.Point(129, 643);
            this.TextBox_Left_Color.Name = "TextBox_Left_Color";
            this.TextBox_Left_Color.Size = new System.Drawing.Size(207, 20);
            this.TextBox_Left_Color.TabIndex = 58;
            // 
            // TextBox_Right_Color
            // 
            this.TextBox_Right_Color.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.TextBox_Right_Color.Location = new System.Drawing.Point(450, 643);
            this.TextBox_Right_Color.Name = "TextBox_Right_Color";
            this.TextBox_Right_Color.Size = new System.Drawing.Size(201, 20);
            this.TextBox_Right_Color.TabIndex = 59;
            // 
            // Timer_MF_LoadDoneCheck
            // 
            this.Timer_MF_LoadDoneCheck.Tick += new System.EventHandler(this.Timer_MF_LoadDoneCheck_Tick);
            // 
            // TextBox_MF_BrainArea
            // 
            this.TextBox_MF_BrainArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.TextBox_MF_BrainArea.Location = new System.Drawing.Point(408, 123);
            this.TextBox_MF_BrainArea.Name = "TextBox_MF_BrainArea";
            this.TextBox_MF_BrainArea.Size = new System.Drawing.Size(156, 20);
            this.TextBox_MF_BrainArea.TabIndex = 60;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 676);
            this.Controls.Add(this.TextBox_MF_BrainArea);
            this.Controls.Add(this.TextBox_Right_Color);
            this.Controls.Add(this.TextBox_Left_Color);
            this.Controls.Add(this.TextBox_MF_Y_Left);
            this.Controls.Add(this.TextBox_MF_X_Left);
            this.Controls.Add(this.TextBox_Y_Right);
            this.Controls.Add(this.TextBox_X_Right);
            this.Controls.Add(this.Button_MF_AnnotateMode);
            this.Controls.Add(this.Button_MF_ColorMode);
            this.Controls.Add(this.Button_MF_Proc_Right);
            this.Controls.Add(this.Button_MF_Proc_Left);
            this.Controls.Add(this.TextBox_MF_ProcImageNo);
            this.Controls.Add(this.Label_MF_ProcImageNo);
            this.Controls.Add(this.Button_MF_Raw_Right);
            this.Controls.Add(this.Button_MF_Raw_Left);
            this.Controls.Add(this.TextBox_MF_RawImageNo);
            this.Controls.Add(this.Label_MF_RawImageNo);
            this.Controls.Add(this.TextBox_MF_PatientFile);
            this.Controls.Add(this.Label_MF_PatientFile);
            this.Controls.Add(this.TextBox_MF_Age);
            this.Controls.Add(this.Label_MF_Age);
            this.Controls.Add(this.Label_MF_Gender);
            this.Controls.Add(this.ComboBox_MF_Gender);
            this.Controls.Add(this.Button_MF_LoadPatient);
            this.Controls.Add(this.Button_MF_About);
            this.Controls.Add(this.Button_MF_Help);
            this.Controls.Add(this.Button_MF_Exit);
            this.Controls.Add(this.Label_MF_ImageSetArea);
            this.Controls.Add(this.ComboBox_MF_SetArea);
            this.Controls.Add(this.Button_MF_Search);
            this.Controls.Add(this.Button_MF_Struct12);
            this.Controls.Add(this.Button_MF_Struct11);
            this.Controls.Add(this.Button_MF_Struct10);
            this.Controls.Add(this.Button_MF_Struct9);
            this.Controls.Add(this.Button_MF_Struct8);
            this.Controls.Add(this.Button_MF_Struct7);
            this.Controls.Add(this.Button_MF_Struct6);
            this.Controls.Add(this.Button_MF_Struct5);
            this.Controls.Add(this.Button_MF_Struct4);
            this.Controls.Add(this.Button_MF_Struct3);
            this.Controls.Add(this.Button_MF_Struct2);
            this.Controls.Add(this.Button_MF_Struct1);
            this.Controls.Add(this.Label_MF_ProcessingStatus);
            this.Controls.Add(this.TextBox_ProcStatus);
            this.Controls.Add(this.Label_MF_RawStatus);
            this.Controls.Add(this.TextBox_Raw_Status);
            this.Controls.Add(this.PictureBox_MF_Processed);
            this.Controls.Add(this.PictureBox_MF_Raw);
            this.Controls.Add(this.Button_MF_Browse);
            this.Controls.Add(this.TextBox_MF_ImageLocatoin);
            this.Controls.Add(this.Label_MF_ImageLocation);
            this.Controls.Add(this.TextBox_MF_DoctorId);
            this.Controls.Add(this.Label_DoctorId);
            this.Controls.Add(this.TextBox_MF_ControlNumber);
            this.Controls.Add(this.Label_MF_ControlNumber);
            this.Controls.Add(this.TextBox_MF_PatientName);
            this.Controls.Add(this.Label_PatientName);
            this.Controls.Add(this.Button_MF_LoadImageSet);
            this.Name = "MainForm";
            this.Text = "Segmenting Anatomic Images - Team SAI";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_MF_Raw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_MF_Processed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_MF_LoadImageSet;
        private System.Windows.Forms.Label Label_PatientName;
        private System.Windows.Forms.TextBox TextBox_MF_PatientName;
        private System.Windows.Forms.Label Label_MF_ControlNumber;
        private System.Windows.Forms.TextBox TextBox_MF_ControlNumber;
        private System.Windows.Forms.TextBox TextBox_MF_DoctorId;
        private System.Windows.Forms.Label Label_DoctorId;
        private System.Windows.Forms.Label Label_MF_ImageLocation;
        private System.Windows.Forms.TextBox TextBox_MF_ImageLocatoin;
        private System.Windows.Forms.Button Button_MF_Browse;
        private System.Windows.Forms.PictureBox PictureBox_MF_Raw;
        private System.Windows.Forms.PictureBox PictureBox_MF_Processed;
        private System.Windows.Forms.TextBox TextBox_Raw_Status;
        private System.Windows.Forms.Label Label_MF_RawStatus;
        private System.Windows.Forms.Label Label_MF_ProcessingStatus;
        private System.Windows.Forms.TextBox TextBox_ProcStatus;
        private System.Windows.Forms.Button Button_MF_Struct1;
        private System.Windows.Forms.Button Button_MF_Struct2;
        private System.Windows.Forms.Button Button_MF_Struct3;
        private System.Windows.Forms.Button Button_MF_Struct4;
        private System.Windows.Forms.Button Button_MF_Struct5;
        private System.Windows.Forms.Button Button_MF_Struct6;
        private System.Windows.Forms.Button Button_MF_Struct7;
        private System.Windows.Forms.Button Button_MF_Struct8;
        private System.Windows.Forms.Button Button_MF_Struct9;
        private System.Windows.Forms.Button Button_MF_Struct10;
        private System.Windows.Forms.Button Button_MF_Struct11;
        private System.Windows.Forms.Button Button_MF_Struct12;
        private System.Windows.Forms.Button Button_MF_Search;
        private System.Windows.Forms.ComboBox ComboBox_MF_SetArea;
        private System.Windows.Forms.Label Label_MF_ImageSetArea;
        private System.Windows.Forms.Button Button_MF_Exit;
        private System.Windows.Forms.Button Button_MF_Help;
        private System.Windows.Forms.Button Button_MF_About;
        private System.Windows.Forms.Button Button_MF_LoadPatient;
        private System.Windows.Forms.ComboBox ComboBox_MF_Gender;
        private System.Windows.Forms.Label Label_MF_Gender;
        private System.Windows.Forms.Label Label_MF_Age;
        private System.Windows.Forms.TextBox TextBox_MF_Age;
        private System.Windows.Forms.Label Label_MF_PatientFile;
        private System.Windows.Forms.TextBox TextBox_MF_PatientFile;
        private System.Windows.Forms.TextBox TextBox_MF_RawImageNo;
        private System.Windows.Forms.Label Label_MF_RawImageNo;
        private System.Windows.Forms.Button Button_MF_Raw_Left;
        private System.Windows.Forms.Button Button_MF_Raw_Right;
        private System.Windows.Forms.Button Button_MF_Proc_Right;
        private System.Windows.Forms.Button Button_MF_Proc_Left;
        private System.Windows.Forms.TextBox TextBox_MF_ProcImageNo;
        private System.Windows.Forms.Label Label_MF_ProcImageNo;
        private System.Windows.Forms.Button Button_MF_ColorMode;
        private System.Windows.Forms.Button Button_MF_AnnotateMode;
        private System.Windows.Forms.TextBox TextBox_X_Right;
        private System.Windows.Forms.TextBox TextBox_Y_Right;
        private System.Windows.Forms.TextBox TextBox_MF_Y_Left;
        private System.Windows.Forms.TextBox TextBox_MF_X_Left;
        private System.Windows.Forms.TextBox TextBox_Left_Color;
        private System.Windows.Forms.TextBox TextBox_Right_Color;
        private System.Windows.Forms.Timer Timer_MF_LoadDoneCheck;
        private System.Windows.Forms.TextBox TextBox_MF_BrainArea;
    }
}

