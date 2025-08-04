namespace CertificateTool
{
    partial class PasswordBoxWithToggle
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            txtPassword = new TextBox();
            picToggle = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picToggle).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(0, 0);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(168, 30);
            txtPassword.TabIndex = 0;
            // 
            // picToggle
            // 
            picToggle.Image = Properties.Resources.eye_closed;
            picToggle.Location = new Point(174, -1);
            picToggle.Name = "picToggle";
            picToggle.Size = new Size(32, 32);
            picToggle.SizeMode = PictureBoxSizeMode.StretchImage;
            picToggle.TabIndex = 1;
            picToggle.TabStop = false;
            // 
            // PasswordBoxWithToggle
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(picToggle);
            Controls.Add(txtPassword);
            Name = "PasswordBoxWithToggle";
            Size = new Size(209, 36);
            ((System.ComponentModel.ISupportInitialize)picToggle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private PictureBox picToggle;
    }
}
