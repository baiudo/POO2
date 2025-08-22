namespace WinFormsApp1
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
            textBox_C = new TextBox();
            button_converte = new Button();
            label1 = new Label();
            label_conversao = new Label();
            SuspendLayout();
            // 
            // textBox_C
            // 
            textBox_C.Location = new Point(168, 109);
            textBox_C.Name = "textBox_C";
            textBox_C.Size = new Size(100, 23);
            textBox_C.TabIndex = 0;
            // 
            // button_converte
            // 
            button_converte.Location = new Point(181, 158);
            button_converte.Name = "button_converte";
            button_converte.Size = new Size(64, 27);
            button_converte.TabIndex = 1;
            button_converte.Text = "Converte";
            button_converte.UseVisualStyleBackColor = true;
            button_converte.Click += button_converte_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 117);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 2;
            label1.Text = "ºC";
            // 
            // label_conversao
            // 
            label_conversao.AutoSize = true;
            label_conversao.Location = new Point(274, 170);
            label_conversao.Name = "label_conversao";
            label_conversao.Size = new Size(0, 15);
            label_conversao.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_conversao);
            Controls.Add(label1);
            Controls.Add(button_converte);
            Controls.Add(textBox_C);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_C;
        private Button button_converte;
        private Label label1;
        private Label label_conversao;
    }
}
