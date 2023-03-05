namespace Project.WinUI
{
    partial class Form2
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
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtSector = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtSaloonSector = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSponsorName = new System.Windows.Forms.TextBox();
            this.txtSponsorSector = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbRequests = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.dtmStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtmEndDate = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.lstRequests = new System.Windows.Forms.ListBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.btnAddIssue = new System.Windows.Forms.Button();
            this.txtIssueDesc = new System.Windows.Forms.TextBox();
            this.txtIssueRecoveryTime = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnAddSaloon = new System.Windows.Forms.Button();
            this.btnAddRequest = new System.Windows.Forms.Button();
            this.btnAddSponsor = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.lstIssues = new System.Windows.Forms.ListBox();
            this.btnTotalPrice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(33, 109);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyName.TabIndex = 0;
            // 
            // txtSector
            // 
            this.txtSector.Location = new System.Drawing.Point(33, 170);
            this.txtSector.Name = "txtSector";
            this.txtSector.Size = new System.Drawing.Size(100, 20);
            this.txtSector.TabIndex = 0;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(33, 230);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCountry.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şirket İsmi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sektörü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ülkesi";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 73);
            this.label4.TabIndex = 1;
            this.label4.Text = "Müşteri bilgilerini buraya giriniz.";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(237, -5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 329);
            this.label5.TabIndex = 2;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "label5";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(237, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 329);
            this.label7.TabIndex = 2;
            this.label7.Text = "label5";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(237, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 329);
            this.label8.TabIndex = 2;
            this.label8.Text = "label5";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(21, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 54);
            this.label9.TabIndex = 3;
            this.label9.Text = "Salon bilgilerini buraya giriniz.";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(33, 518);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 20);
            this.txtLocation.TabIndex = 4;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(33, 579);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(100, 20);
            this.txtCapacity.TabIndex = 4;
            // 
            // txtSaloonSector
            // 
            this.txtSaloonSector.Location = new System.Drawing.Point(33, 638);
            this.txtSaloonSector.Name = "txtSaloonSector";
            this.txtSaloonSector.Size = new System.Drawing.Size(100, 20);
            this.txtSaloonSector.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 397);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Başlangıç Tarihi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 447);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Bitiş Tarihi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 502);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Lokasyon";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 563);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Kapasite";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 622);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Sektör";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(237, 308);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(249, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "label5";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(473, -5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 329);
            this.label16.TabIndex = 2;
            this.label16.Text = "label5";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(473, 320);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 329);
            this.label17.TabIndex = 2;
            this.label17.Text = "label5";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(473, 416);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 329);
            this.label18.TabIndex = 2;
            this.label18.Text = "label5";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(264, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(174, 55);
            this.label19.TabIndex = 6;
            this.label19.Text = "Sponsor bilgilerini buraya giriniz.";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(269, 93);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 13);
            this.label20.TabIndex = 7;
            this.label20.Text = "Sponsor İsmi";
            // 
            // txtSponsorName
            // 
            this.txtSponsorName.Location = new System.Drawing.Point(269, 108);
            this.txtSponsorName.Name = "txtSponsorName";
            this.txtSponsorName.Size = new System.Drawing.Size(100, 20);
            this.txtSponsorName.TabIndex = 8;
            // 
            // txtSponsorSector
            // 
            this.txtSponsorSector.Location = new System.Drawing.Point(269, 170);
            this.txtSponsorSector.Name = "txtSponsorSector";
            this.txtSponsorSector.Size = new System.Drawing.Size(100, 20);
            this.txtSponsorSector.TabIndex = 9;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(269, 154);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 13);
            this.label21.TabIndex = 1;
            this.label21.Text = "Sektörü";
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(264, 335);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(166, 54);
            this.label22.TabIndex = 10;
            this.label22.Text = "Talepleri buradan ekleyiniz.";
            // 
            // cmbRequests
            // 
            this.cmbRequests.FormattingEnabled = true;
            this.cmbRequests.Location = new System.Drawing.Point(264, 411);
            this.cmbRequests.Name = "cmbRequests";
            this.cmbRequests.Size = new System.Drawing.Size(189, 21);
            this.cmbRequests.TabIndex = 11;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(266, 395);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(45, 13);
            this.label23.TabIndex = 12;
            this.label23.Text = "Talepler";
            // 
            // dtmStartDate
            // 
            this.dtmStartDate.Location = new System.Drawing.Point(33, 412);
            this.dtmStartDate.Name = "dtmStartDate";
            this.dtmStartDate.Size = new System.Drawing.Size(175, 20);
            this.dtmStartDate.TabIndex = 13;
            // 
            // dtmEndDate
            // 
            this.dtmEndDate.Location = new System.Drawing.Point(33, 463);
            this.dtmEndDate.Name = "dtmEndDate";
            this.dtmEndDate.Size = new System.Drawing.Size(175, 20);
            this.dtmEndDate.TabIndex = 13;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(443, 308);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(738, 16);
            this.label24.TabIndex = 2;
            this.label24.Text = "label5";
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.Location = new System.Drawing.Point(492, 28);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(297, 277);
            this.lstCustomers.TabIndex = 14;
            // 
            // lstRequests
            // 
            this.lstRequests.FormattingEnabled = true;
            this.lstRequests.Location = new System.Drawing.Point(825, 28);
            this.lstRequests.Name = "lstRequests";
            this.lstRequests.Size = new System.Drawing.Size(297, 277);
            this.lstRequests.TabIndex = 14;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.Location = new System.Drawing.Point(493, 9);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(62, 13);
            this.label25.TabIndex = 15;
            this.label25.Text = "Müşteriler";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.Location = new System.Drawing.Point(822, 9);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(53, 13);
            this.label26.TabIndex = 15;
            this.label26.Text = "Talepler";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label27.Location = new System.Drawing.Point(511, 349);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(234, 13);
            this.label27.TabIndex = 17;
            this.label27.Text = "Problem bilgilerini buradan görebilirsiniz.";
            // 
            // btnAddIssue
            // 
            this.btnAddIssue.Location = new System.Drawing.Point(517, 652);
            this.btnAddIssue.Name = "btnAddIssue";
            this.btnAddIssue.Size = new System.Drawing.Size(85, 23);
            this.btnAddIssue.TabIndex = 21;
            this.btnAddIssue.Text = "Problem Ekle";
            this.btnAddIssue.UseVisualStyleBackColor = true;
            // 
            // txtIssueDesc
            // 
            this.txtIssueDesc.Location = new System.Drawing.Point(517, 588);
            this.txtIssueDesc.Name = "txtIssueDesc";
            this.txtIssueDesc.Size = new System.Drawing.Size(100, 20);
            this.txtIssueDesc.TabIndex = 22;
            // 
            // txtIssueRecoveryTime
            // 
            this.txtIssueRecoveryTime.Location = new System.Drawing.Point(517, 622);
            this.txtIssueRecoveryTime.Name = "txtIssueRecoveryTime";
            this.txtIssueRecoveryTime.Size = new System.Drawing.Size(100, 20);
            this.txtIssueRecoveryTime.TabIndex = 23;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(517, 569);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(74, 13);
            this.label29.TabIndex = 24;
            this.label29.Text = "Problem Bilgisi";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(517, 606);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(108, 13);
            this.label30.TabIndex = 24;
            this.label30.Text = "Tahmini çözüm süresi";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(33, 274);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnAddCustomer.TabIndex = 25;
            this.btnAddCustomer.Text = "Müşteri Ekle";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAddSaloon
            // 
            this.btnAddSaloon.Location = new System.Drawing.Point(26, 684);
            this.btnAddSaloon.Name = "btnAddSaloon";
            this.btnAddSaloon.Size = new System.Drawing.Size(75, 23);
            this.btnAddSaloon.TabIndex = 26;
            this.btnAddSaloon.Text = "Salon Ekle";
            this.btnAddSaloon.UseVisualStyleBackColor = true;
            // 
            // btnAddRequest
            // 
            this.btnAddRequest.Location = new System.Drawing.Point(264, 463);
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.Size = new System.Drawing.Size(75, 23);
            this.btnAddRequest.TabIndex = 27;
            this.btnAddRequest.Text = "Talep Ekle";
            this.btnAddRequest.UseVisualStyleBackColor = true;
            // 
            // btnAddSponsor
            // 
            this.btnAddSponsor.Location = new System.Drawing.Point(264, 274);
            this.btnAddSponsor.Name = "btnAddSponsor";
            this.btnAddSponsor.Size = new System.Drawing.Size(86, 23);
            this.btnAddSponsor.TabIndex = 28;
            this.btnAddSponsor.Text = "Sponsor Ekle";
            this.btnAddSponsor.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(800, 313);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(13, 329);
            this.label31.TabIndex = 2;
            this.label31.Text = "label5";
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.Black;
            this.label32.Location = new System.Drawing.Point(800, 422);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(13, 329);
            this.label32.TabIndex = 2;
            this.label32.Text = "label5";
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblResult.Location = new System.Drawing.Point(822, 354);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(224, 78);
            this.lblResult.TabIndex = 29;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(822, 335);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(71, 13);
            this.label33.TabIndex = 30;
            this.label33.Text = "Toplam Ücret";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label34.Location = new System.Drawing.Point(195, 259);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(36, 39);
            this.label34.TabIndex = 31;
            this.label34.Text = "1";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label35.Location = new System.Drawing.Point(195, 684);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(36, 39);
            this.label35.TabIndex = 31;
            this.label35.Text = "2";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label36.Location = new System.Drawing.Point(431, 259);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(36, 39);
            this.label36.TabIndex = 31;
            this.label36.Text = "3";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label37.Location = new System.Drawing.Point(431, 684);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(36, 39);
            this.label37.TabIndex = 31;
            this.label37.Text = "4";
            // 
            // lstIssues
            // 
            this.lstIssues.FormattingEnabled = true;
            this.lstIssues.Location = new System.Drawing.Point(514, 365);
            this.lstIssues.Name = "lstIssues";
            this.lstIssues.Size = new System.Drawing.Size(246, 160);
            this.lstIssues.TabIndex = 32;
            // 
            // btnTotalPrice
            // 
            this.btnTotalPrice.Location = new System.Drawing.Point(819, 436);
            this.btnTotalPrice.Name = "btnTotalPrice";
            this.btnTotalPrice.Size = new System.Drawing.Size(100, 35);
            this.btnTotalPrice.TabIndex = 33;
            this.btnTotalPrice.Text = "Toplam Ücreti Hesapla";
            this.btnTotalPrice.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1157, 732);
            this.Controls.Add(this.btnTotalPrice);
            this.Controls.Add(this.lstIssues);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnAddSponsor);
            this.Controls.Add(this.btnAddRequest);
            this.Controls.Add(this.btnAddSaloon);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.txtIssueRecoveryTime);
            this.Controls.Add(this.txtIssueDesc);
            this.Controls.Add(this.btnAddIssue);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.lstRequests);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.dtmEndDate);
            this.Controls.Add(this.dtmStartDate);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.cmbRequests);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtSponsorSector);
            this.Controls.Add(this.txtSponsorName);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSaloonSector);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtSector);
            this.Controls.Add(this.txtCompanyName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtSector;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtSaloonSector;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtSponsorName;
        private System.Windows.Forms.TextBox txtSponsorSector;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbRequests;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtmStartDate;
        private System.Windows.Forms.DateTimePicker dtmEndDate;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.ListBox lstRequests;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnAddIssue;
        private System.Windows.Forms.TextBox txtIssueDesc;
        private System.Windows.Forms.TextBox txtIssueRecoveryTime;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnAddSaloon;
        private System.Windows.Forms.Button btnAddRequest;
        private System.Windows.Forms.Button btnAddSponsor;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.ListBox lstIssues;
        private System.Windows.Forms.Button btnTotalPrice;
    }
}