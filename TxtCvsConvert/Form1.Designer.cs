namespace TxtCvsConvert
{
    partial class Form1
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
            txtConvert = new Button();
            cvsConvert = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtConvert
            // 
            txtConvert.Location = new Point(188, 88);
            txtConvert.Name = "txtConvert";
            txtConvert.Size = new Size(137, 49);
            txtConvert.TabIndex = 0;
            txtConvert.Text = "Конвертировать в TXT";
            txtConvert.UseVisualStyleBackColor = true;
            txtConvert.Click += txtConvert_Click;
            // 
            // cvsConvert
            // 
            cvsConvert.Location = new Point(331, 88);
            cvsConvert.Name = "cvsConvert";
            cvsConvert.Size = new Size(139, 49);
            cvsConvert.TabIndex = 1;
            cvsConvert.Text = "Конвертировать в CSV";
            cvsConvert.UseVisualStyleBackColor = true;
            cvsConvert.Click += cvsConvert_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(81, 29);
            label1.Name = "label1";
            label1.Size = new Size(500, 33);
            label1.TabIndex = 2;
            label1.Text = "Проверка сохранения данных в .csv и .txt";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 166);
            Controls.Add(label1);
            Controls.Add(cvsConvert);
            Controls.Add(txtConvert);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button txtConvert;
        private Button cvsConvert;
        private Label label1;
    }
}
