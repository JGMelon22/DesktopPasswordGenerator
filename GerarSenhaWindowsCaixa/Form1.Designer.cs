namespace GerarSenhaWindowsCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            checkBox1 = new CheckBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.CharacterCasing = CharacterCasing.Lower;
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(10, 34);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.MaxLength = 50;
            textBox1.Name = "textBox1";
            textBox1.ShortcutsEnabled = false;
            textBox1.Size = new Size(292, 26);
            textBox1.TabIndex = 0;
            textBox1.KeyPress += textBox1_KeyPress;
            textBox1.Leave += textBox1_Leave;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(10, 67);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(113, 30);
            button1.TabIndex = 1;
            button1.Text = "Gerar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(176, 67);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(126, 30);
            button2.TabIndex = 2;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(182, 19);
            label1.TabIndex = 3;
            label1.Text = "Digite um nome de um país:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(214, 7);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(88, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Senha Forte";
            checkBox1.UseVisualStyleBackColor = true;
            //checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(10, 67);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(113, 30);
            button3.TabIndex = 5;
            button3.Text = "Gerar";
            button3.UseVisualStyleBackColor = true;
            //button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(314, 101);
            Controls.Add(button3);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerador de senha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private CheckBox checkBox1;
        private Button button3;
    }
}