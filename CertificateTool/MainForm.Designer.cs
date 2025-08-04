namespace CertificateTool
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtCN = new TextBox();
            lblO = new Label();
            txtO = new TextBox();
            lblOU = new Label();
            txtOU = new TextBox();
            lblC = new Label();
            lblST = new Label();
            txtST = new TextBox();
            lblL = new Label();
            txtL = new TextBox();
            lblKeySize = new Label();
            cmbKeySize = new ComboBox();
            lblKeyPassword = new Label();
            lblSavePath = new Label();
            txtSavePath = new TextBox();
            btnBrowseSave = new Button();
            btnGenerateCSR = new Button();
            lblCN = new Label();
            tabControlMain = new TabControl();
            tabPageCSR = new TabPage();
            picInfoCSRPage = new PictureBox();
            groupKeyInfo = new GroupBox();
            passwordBoxCSR = new PasswordBoxWithToggle();
            groupCsrInfo = new GroupBox();
            cmbCountry = new ComboBox();
            tabPagePFX = new TabPage();
            passwordBoxPFX = new PasswordBoxWithToggle();
            btnBuildPFX = new Button();
            btnBrowsePfxOutput = new Button();
            txtPfxOutput = new TextBox();
            lblPfxOutput = new Label();
            lblPfxPassword = new Label();
            btnBrowseIntermediate = new Button();
            txtIntermediate = new TextBox();
            lblIntermediate = new Label();
            btnBrowseKey = new Button();
            txtKeyPath = new TextBox();
            lblKeyPath = new Label();
            btnBrowseCert = new Button();
            txtCertPath = new TextBox();
            lblCertPath = new Label();
            toolTip1 = new ToolTip(components);
            tabControlMain.SuspendLayout();
            tabPageCSR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picInfoCSRPage).BeginInit();
            groupKeyInfo.SuspendLayout();
            groupCsrInfo.SuspendLayout();
            tabPagePFX.SuspendLayout();
            SuspendLayout();
            // 
            // txtCN
            // 
            txtCN.Location = new Point(203, 64);
            txtCN.Name = "txtCN";
            txtCN.Size = new Size(230, 30);
            txtCN.TabIndex = 1;
            // 
            // lblO
            // 
            lblO.AutoSize = true;
            lblO.Location = new Point(6, 149);
            lblO.Name = "lblO";
            lblO.Size = new Size(154, 23);
            lblO.TabIndex = 2;
            lblO.Text = "Organization (O)";
            // 
            // txtO
            // 
            txtO.Location = new Point(203, 145);
            txtO.Name = "txtO";
            txtO.Size = new Size(230, 30);
            txtO.TabIndex = 3;
            // 
            // lblOU
            // 
            lblOU.AutoSize = true;
            lblOU.Location = new Point(6, 230);
            lblOU.Name = "lblOU";
            lblOU.Size = new Size(129, 23);
            lblOU.TabIndex = 4;
            lblOU.Text = "Org Unit (OU)";
            // 
            // txtOU
            // 
            txtOU.Location = new Point(203, 226);
            txtOU.Name = "txtOU";
            txtOU.Size = new Size(230, 30);
            txtOU.TabIndex = 5;
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Location = new Point(6, 311);
            lblC.Name = "lblC";
            lblC.Size = new Size(107, 23);
            lblC.TabIndex = 6;
            lblC.Text = "Country (C)";
            // 
            // lblST
            // 
            lblST.AutoSize = true;
            lblST.Location = new Point(6, 392);
            lblST.Name = "lblST";
            lblST.Size = new Size(172, 23);
            lblST.TabIndex = 8;
            lblST.Text = "State/Province (ST)";
            // 
            // txtST
            // 
            txtST.Location = new Point(203, 388);
            txtST.Name = "txtST";
            txtST.Size = new Size(230, 30);
            txtST.TabIndex = 9;
            // 
            // lblL
            // 
            lblL.AutoSize = true;
            lblL.Location = new Point(6, 473);
            lblL.Name = "lblL";
            lblL.Size = new Size(101, 23);
            lblL.TabIndex = 10;
            lblL.Text = "Locality (L)";
            // 
            // txtL
            // 
            txtL.Location = new Point(203, 469);
            txtL.Name = "txtL";
            txtL.Size = new Size(230, 30);
            txtL.TabIndex = 11;
            // 
            // lblKeySize
            // 
            lblKeySize.AutoSize = true;
            lblKeySize.Location = new Point(6, 68);
            lblKeySize.Name = "lblKeySize";
            lblKeySize.Size = new Size(79, 23);
            lblKeySize.TabIndex = 12;
            lblKeySize.Text = "Key Size";
            // 
            // cmbKeySize
            // 
            cmbKeySize.FormattingEnabled = true;
            cmbKeySize.Items.AddRange(new object[] { "2048", "3072", "4096" });
            cmbKeySize.Location = new Point(224, 64);
            cmbKeySize.Name = "cmbKeySize";
            cmbKeySize.Size = new Size(209, 31);
            cmbKeySize.TabIndex = 13;
            // 
            // lblKeyPassword
            // 
            lblKeyPassword.AutoSize = true;
            lblKeyPassword.Location = new Point(6, 149);
            lblKeyPassword.Name = "lblKeyPassword";
            lblKeyPassword.Size = new Size(171, 23);
            lblKeyPassword.TabIndex = 14;
            lblKeyPassword.Text = "Key 密碼（可不填）";
            // 
            // lblSavePath
            // 
            lblSavePath.AutoSize = true;
            lblSavePath.Location = new Point(14, 578);
            lblSavePath.Name = "lblSavePath";
            lblSavePath.Size = new Size(82, 23);
            lblSavePath.TabIndex = 16;
            lblSavePath.Text = "儲存路徑";
            // 
            // txtSavePath
            // 
            txtSavePath.Location = new Point(115, 574);
            txtSavePath.Name = "txtSavePath";
            txtSavePath.Size = new Size(833, 30);
            txtSavePath.TabIndex = 17;
            // 
            // btnBrowseSave
            // 
            btnBrowseSave.Location = new Point(954, 572);
            btnBrowseSave.Name = "btnBrowseSave";
            btnBrowseSave.Size = new Size(112, 34);
            btnBrowseSave.TabIndex = 18;
            btnBrowseSave.Text = "瀏覽...";
            btnBrowseSave.UseVisualStyleBackColor = true;
            btnBrowseSave.Click += btnBrowseSave_Click;
            // 
            // btnGenerateCSR
            // 
            btnGenerateCSR.BackColor = Color.FromArgb(0, 123, 255);
            btnGenerateCSR.FlatAppearance.BorderSize = 0;
            btnGenerateCSR.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 144, 255);
            btnGenerateCSR.FlatStyle = FlatStyle.Flat;
            btnGenerateCSR.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnGenerateCSR.ForeColor = Color.White;
            btnGenerateCSR.Location = new Point(867, 639);
            btnGenerateCSR.Name = "btnGenerateCSR";
            btnGenerateCSR.Size = new Size(171, 40);
            btnGenerateCSR.TabIndex = 19;
            btnGenerateCSR.Text = "產生 CSR 與私鑰";
            btnGenerateCSR.UseVisualStyleBackColor = true;
            btnGenerateCSR.Click += btnGenerateCSR_Click;
            // 
            // lblCN
            // 
            lblCN.AutoSize = true;
            lblCN.Location = new Point(6, 68);
            lblCN.Name = "lblCN";
            lblCN.Size = new Size(190, 23);
            lblCN.TabIndex = 20;
            lblCN.Text = "Common Name (CN)";
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageCSR);
            tabControlMain.Controls.Add(tabPagePFX);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1080, 723);
            tabControlMain.TabIndex = 21;
            // 
            // tabPageCSR
            // 
            tabPageCSR.Controls.Add(picInfoCSRPage);
            tabPageCSR.Controls.Add(groupKeyInfo);
            tabPageCSR.Controls.Add(groupCsrInfo);
            tabPageCSR.Controls.Add(btnGenerateCSR);
            tabPageCSR.Controls.Add(btnBrowseSave);
            tabPageCSR.Controls.Add(txtSavePath);
            tabPageCSR.Controls.Add(lblSavePath);
            tabPageCSR.Location = new Point(4, 32);
            tabPageCSR.Name = "tabPageCSR";
            tabPageCSR.Padding = new Padding(3);
            tabPageCSR.Size = new Size(1072, 687);
            tabPageCSR.TabIndex = 0;
            tabPageCSR.Text = "產生 CSR";
            tabPageCSR.UseVisualStyleBackColor = true;
            // 
            // picInfoCSRPage
            // 
            picInfoCSRPage.Image = Properties.Resources.information;
            picInfoCSRPage.Location = new Point(1044, 648);
            picInfoCSRPage.Name = "picInfoCSRPage";
            picInfoCSRPage.Size = new Size(20, 20);
            picInfoCSRPage.SizeMode = PictureBoxSizeMode.StretchImage;
            picInfoCSRPage.TabIndex = 24;
            picInfoCSRPage.TabStop = false;
            picInfoCSRPage.Click += pictureBox1_Click;
            // 
            // groupKeyInfo
            // 
            groupKeyInfo.Controls.Add(passwordBoxCSR);
            groupKeyInfo.Controls.Add(lblKeySize);
            groupKeyInfo.Controls.Add(cmbKeySize);
            groupKeyInfo.Controls.Add(lblKeyPassword);
            groupKeyInfo.Location = new Point(544, 22);
            groupKeyInfo.Name = "groupKeyInfo";
            groupKeyInfo.Size = new Size(522, 522);
            groupKeyInfo.TabIndex = 23;
            groupKeyInfo.TabStop = false;
            groupKeyInfo.Text = "私鑰產製資訊";
            // 
            // passwordBoxCSR
            // 
            passwordBoxCSR.Location = new Point(224, 145);
            passwordBoxCSR.Name = "passwordBoxCSR";
            passwordBoxCSR.Password = "";
            passwordBoxCSR.Size = new Size(209, 30);
            passwordBoxCSR.TabIndex = 15;
            // 
            // groupCsrInfo
            // 
            groupCsrInfo.Controls.Add(cmbCountry);
            groupCsrInfo.Controls.Add(lblCN);
            groupCsrInfo.Controls.Add(lblL);
            groupCsrInfo.Controls.Add(lblST);
            groupCsrInfo.Controls.Add(txtCN);
            groupCsrInfo.Controls.Add(txtL);
            groupCsrInfo.Controls.Add(txtST);
            groupCsrInfo.Controls.Add(lblO);
            groupCsrInfo.Controls.Add(lblC);
            groupCsrInfo.Controls.Add(txtO);
            groupCsrInfo.Controls.Add(txtOU);
            groupCsrInfo.Controls.Add(lblOU);
            groupCsrInfo.Location = new Point(14, 22);
            groupCsrInfo.Name = "groupCsrInfo";
            groupCsrInfo.Size = new Size(522, 522);
            groupCsrInfo.TabIndex = 22;
            groupCsrInfo.TabStop = false;
            groupCsrInfo.Text = "憑證產製資訊";
            // 
            // cmbCountry
            // 
            cmbCountry.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCountry.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(203, 307);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(230, 31);
            cmbCountry.TabIndex = 21;
            cmbCountry.SelectedIndexChanged += cmbCountry_SelectedIndexChanged;
            // 
            // tabPagePFX
            // 
            tabPagePFX.Controls.Add(passwordBoxPFX);
            tabPagePFX.Controls.Add(btnBuildPFX);
            tabPagePFX.Controls.Add(btnBrowsePfxOutput);
            tabPagePFX.Controls.Add(txtPfxOutput);
            tabPagePFX.Controls.Add(lblPfxOutput);
            tabPagePFX.Controls.Add(lblPfxPassword);
            tabPagePFX.Controls.Add(btnBrowseIntermediate);
            tabPagePFX.Controls.Add(txtIntermediate);
            tabPagePFX.Controls.Add(lblIntermediate);
            tabPagePFX.Controls.Add(btnBrowseKey);
            tabPagePFX.Controls.Add(txtKeyPath);
            tabPagePFX.Controls.Add(lblKeyPath);
            tabPagePFX.Controls.Add(btnBrowseCert);
            tabPagePFX.Controls.Add(txtCertPath);
            tabPagePFX.Controls.Add(lblCertPath);
            tabPagePFX.Location = new Point(4, 32);
            tabPagePFX.Name = "tabPagePFX";
            tabPagePFX.Padding = new Padding(3);
            tabPagePFX.Size = new Size(1072, 687);
            tabPagePFX.TabIndex = 1;
            tabPagePFX.Text = "合成 PFX 檔案";
            tabPagePFX.UseVisualStyleBackColor = true;
            // 
            // passwordBoxPFX
            // 
            passwordBoxPFX.Location = new Point(203, 311);
            passwordBoxPFX.Name = "passwordBoxPFX";
            passwordBoxPFX.Password = "";
            passwordBoxPFX.Size = new Size(217, 38);
            passwordBoxPFX.TabIndex = 22;
            // 
            // btnBuildPFX
            // 
            btnBuildPFX.BackColor = Color.FromArgb(0, 123, 255);
            btnBuildPFX.FlatAppearance.BorderSize = 0;
            btnBuildPFX.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 144, 255);
            btnBuildPFX.FlatStyle = FlatStyle.Flat;
            btnBuildPFX.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnBuildPFX.ForeColor = Color.White;
            btnBuildPFX.Location = new Point(952, 639);
            btnBuildPFX.Name = "btnBuildPFX";
            btnBuildPFX.Size = new Size(112, 40);
            btnBuildPFX.TabIndex = 14;
            btnBuildPFX.Text = "合成 PFX";
            btnBuildPFX.UseVisualStyleBackColor = true;
            btnBuildPFX.Click += btnBuildPFX_Click;
            // 
            // btnBrowsePfxOutput
            // 
            btnBrowsePfxOutput.Location = new Point(952, 572);
            btnBrowsePfxOutput.Name = "btnBrowsePfxOutput";
            btnBrowsePfxOutput.Size = new Size(112, 34);
            btnBrowsePfxOutput.TabIndex = 13;
            btnBrowsePfxOutput.Text = "瀏覽";
            btnBrowsePfxOutput.UseVisualStyleBackColor = true;
            btnBrowsePfxOutput.Click += btnBrowsePfxOutput_Click;
            // 
            // txtPfxOutput
            // 
            txtPfxOutput.Location = new Point(125, 574);
            txtPfxOutput.Name = "txtPfxOutput";
            txtPfxOutput.Size = new Size(821, 30);
            txtPfxOutput.TabIndex = 12;
            // 
            // lblPfxOutput
            // 
            lblPfxOutput.AutoSize = true;
            lblPfxOutput.Location = new Point(14, 578);
            lblPfxOutput.Name = "lblPfxOutput";
            lblPfxOutput.Size = new Size(105, 23);
            lblPfxOutput.TabIndex = 11;
            lblPfxOutput.Text = "輸出 PFX 檔";
            // 
            // lblPfxPassword
            // 
            lblPfxPassword.AutoSize = true;
            lblPfxPassword.Location = new Point(6, 311);
            lblPfxPassword.Name = "lblPfxPassword";
            lblPfxPassword.Size = new Size(82, 23);
            lblPfxPassword.TabIndex = 9;
            lblPfxPassword.Text = "PFX 密碼";
            // 
            // btnBrowseIntermediate
            // 
            btnBrowseIntermediate.Location = new Point(952, 225);
            btnBrowseIntermediate.Name = "btnBrowseIntermediate";
            btnBrowseIntermediate.Size = new Size(112, 34);
            btnBrowseIntermediate.TabIndex = 8;
            btnBrowseIntermediate.Text = "瀏覽";
            btnBrowseIntermediate.UseVisualStyleBackColor = true;
            btnBrowseIntermediate.Click += btnBrowseIntermediate_Click;
            // 
            // txtIntermediate
            // 
            txtIntermediate.Location = new Point(203, 227);
            txtIntermediate.Name = "txtIntermediate";
            txtIntermediate.Size = new Size(743, 30);
            txtIntermediate.TabIndex = 7;
            // 
            // lblIntermediate
            // 
            lblIntermediate.AutoSize = true;
            lblIntermediate.Location = new Point(6, 230);
            lblIntermediate.Name = "lblIntermediate";
            lblIntermediate.Size = new Size(154, 23);
            lblIntermediate.TabIndex = 6;
            lblIntermediate.Text = "中繼憑證（可選）";
            // 
            // btnBrowseKey
            // 
            btnBrowseKey.Location = new Point(952, 149);
            btnBrowseKey.Name = "btnBrowseKey";
            btnBrowseKey.Size = new Size(112, 34);
            btnBrowseKey.TabIndex = 5;
            btnBrowseKey.Text = "瀏覽";
            btnBrowseKey.UseVisualStyleBackColor = true;
            btnBrowseKey.Click += btnBrowseKey_Click;
            // 
            // txtKeyPath
            // 
            txtKeyPath.Location = new Point(203, 149);
            txtKeyPath.Name = "txtKeyPath";
            txtKeyPath.Size = new Size(743, 30);
            txtKeyPath.TabIndex = 4;
            // 
            // lblKeyPath
            // 
            lblKeyPath.AutoSize = true;
            lblKeyPath.Location = new Point(6, 155);
            lblKeyPath.Name = "lblKeyPath";
            lblKeyPath.Size = new Size(115, 23);
            lblKeyPath.TabIndex = 3;
            lblKeyPath.Text = "私鑰（.key）";
            // 
            // btnBrowseCert
            // 
            btnBrowseCert.Location = new Point(952, 68);
            btnBrowseCert.Name = "btnBrowseCert";
            btnBrowseCert.Size = new Size(112, 34);
            btnBrowseCert.TabIndex = 2;
            btnBrowseCert.Text = "瀏覽";
            btnBrowseCert.UseVisualStyleBackColor = true;
            btnBrowseCert.Click += btnBrowseCert_Click;
            // 
            // txtCertPath
            // 
            txtCertPath.Location = new Point(203, 68);
            txtCertPath.Name = "txtCertPath";
            txtCertPath.Size = new Size(743, 30);
            txtCertPath.TabIndex = 1;
            // 
            // lblCertPath
            // 
            lblCertPath.AutoSize = true;
            lblCertPath.Location = new Point(6, 74);
            lblCertPath.Name = "lblCertPath";
            lblCertPath.Size = new Size(178, 23);
            lblCertPath.TabIndex = 0;
            lblCertPath.Text = "主憑證（.pem, .crt）";
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 723);
            Controls.Add(tabControlMain);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load_1;
            tabControlMain.ResumeLayout(false);
            tabPageCSR.ResumeLayout(false);
            tabPageCSR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picInfoCSRPage).EndInit();
            groupKeyInfo.ResumeLayout(false);
            groupKeyInfo.PerformLayout();
            groupCsrInfo.ResumeLayout(false);
            groupCsrInfo.PerformLayout();
            tabPagePFX.ResumeLayout(false);
            tabPagePFX.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtCN;
        private Label lblO;
        private TextBox txtO;
        private Label lblOU;
        private TextBox txtOU;
        private Label lblC;
        private Label lblST;
        private TextBox txtST;
        private Label lblL;
        private TextBox txtL;
        private Label lblKeySize;
        private ComboBox cmbKeySize;
        private Label lblKeyPassword;
        private Label lblSavePath;
        private TextBox txtSavePath;
        private Button btnBrowseSave;
        private Button btnGenerateCSR;
        private Label lblCN;
        private TabControl tabControlMain;
        private TabPage tabPageCSR;
        private TabPage tabPagePFX;
        private Label lblKeyPath;
        private Button btnBrowseCert;
        private TextBox txtCertPath;
        private Label lblCertPath;
        private Button btnBuildPFX;
        private Button btnBrowsePfxOutput;
        private TextBox txtPfxOutput;
        private Label lblPfxOutput;
        private Label lblPfxPassword;
        private Button btnBrowseIntermediate;
        private TextBox txtIntermediate;
        private Label lblIntermediate;
        private Button btnBrowseKey;
        private TextBox txtKeyPath;
        private GroupBox groupCsrInfo;
        private GroupBox groupKeyInfo;
        private ComboBox cmbCountry;
        private PasswordBoxWithToggle passwordBoxPFX;
        private PasswordBoxWithToggle passwordBoxCSR;
        private PictureBox picInfoCSRPage;
        private ToolTip toolTip1;
    }
}
