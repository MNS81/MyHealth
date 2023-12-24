namespace MyHealth
{
    partial class Login
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
            pictureBox1 = new PictureBox();
            UserNameLabel = new Label();
            PassWordLabel = new Label();
            LoginInput = new TextBox();
            PassWordInput = new TextBox();
            LoginButtonPanel = new TableLayoutPanel();
            NewUserButton = new PictureBox();
            OKButton = new PictureBox();
            CancelButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            LoginButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NewUserButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OKButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CancelButton).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(95, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 135);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Location = new Point(140, 129);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(43, 15);
            UserNameLabel.TabIndex = 1;
            UserNameLabel.Text = "Логин";
            // 
            // PassWordLabel
            // 
            PassWordLabel.AutoSize = true;
            PassWordLabel.Location = new Point(140, 173);
            PassWordLabel.Name = "PassWordLabel";
            PassWordLabel.Size = new Size(50, 15);
            PassWordLabel.TabIndex = 2;
            PassWordLabel.Text = "Пароль";
            // 
            // LoginInput
            // 
            LoginInput.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginInput.Location = new Point(80, 147);
            LoginInput.Name = "LoginInput";
            LoginInput.Size = new Size(162, 24);
            LoginInput.TabIndex = 3;
            LoginInput.TextAlign = HorizontalAlignment.Right;
            // 
            // PassWordInput
            // 
            PassWordInput.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PassWordInput.Location = new Point(80, 191);
            PassWordInput.Name = "PassWordInput";
            PassWordInput.PasswordChar = '*';
            PassWordInput.Size = new Size(162, 27);
            PassWordInput.TabIndex = 4;
            PassWordInput.TextAlign = HorizontalAlignment.Right;
            // 
            // LoginButtonPanel
            // 
            LoginButtonPanel.ColumnCount = 3;
            LoginButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            LoginButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            LoginButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            LoginButtonPanel.Controls.Add(NewUserButton, 0, 0);
            LoginButtonPanel.Controls.Add(OKButton, 0, 0);
            LoginButtonPanel.Controls.Add(CancelButton, 2, 0);
            LoginButtonPanel.Location = new Point(67, 220);
            LoginButtonPanel.Name = "LoginButtonPanel";
            LoginButtonPanel.RowCount = 1;
            LoginButtonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            LoginButtonPanel.Size = new Size(186, 66);
            LoginButtonPanel.TabIndex = 5;
            // 
            // NewUserButton
            // 
            NewUserButton.Cursor = Cursors.Hand;
            NewUserButton.Image = Properties.Resources._new;
            NewUserButton.Location = new Point(65, 3);
            NewUserButton.Name = "NewUserButton";
            NewUserButton.Size = new Size(56, 60);
            NewUserButton.SizeMode = PictureBoxSizeMode.StretchImage;
            NewUserButton.TabIndex = 2;
            NewUserButton.TabStop = false;
            NewUserButton.Click += NewUserButton_Click;
            // 
            // OKButton
            // 
            OKButton.Cursor = Cursors.Hand;
            OKButton.Image = Properties.Resources.ok1;
            OKButton.Location = new Point(3, 3);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(56, 60);
            OKButton.SizeMode = PictureBoxSizeMode.StretchImage;
            OKButton.TabIndex = 0;
            OKButton.TabStop = false;
            OKButton.Click += OKButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Cursor = Cursors.Hand;
            CancelButton.Image = Properties.Resources.cancel1;
            CancelButton.Location = new Point(127, 3);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(56, 60);
            CancelButton.SizeMode = PictureBoxSizeMode.StretchImage;
            CancelButton.TabIndex = 1;
            CancelButton.TabStop = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 293);
            ControlBox = false;
            Controls.Add(LoginButtonPanel);
            Controls.Add(PassWordInput);
            Controls.Add(LoginInput);
            Controls.Add(PassWordLabel);
            Controls.Add(UserNameLabel);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            LoginButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)NewUserButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)OKButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)CancelButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label UserNameLabel;
        private Label PassWordLabel;
        private TextBox LoginInput;
        private TextBox PassWordInput;
        private TableLayoutPanel LoginButtonPanel;
        private PictureBox CancelButton;
        private PictureBox OKButton;
        private PictureBox NewUserButton;
    }
}