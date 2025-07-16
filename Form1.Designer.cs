namespace WinFormsApp1
{
    partial class Login
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 46);
            label1.TabIndex = 0;
            label1.Text = "Início";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(12, 79);
            button1.Name = "button1";
            button1.Size = new Size(356, 43);
            button1.TabIndex = 5;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ScrollBar;
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(12, 128);
            button2.Name = "button2";
            button2.Size = new Size(356, 43);
            button2.TabIndex = 6;
            button2.Text = "Cadastrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 187);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            Text = "Acessar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}
