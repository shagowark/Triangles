namespace Triangles
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawPanel = new System.Windows.Forms.Panel();
            this.myPictureBox = new System.Windows.Forms.PictureBox();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClearText = new System.Windows.Forms.Button();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxY3 = new System.Windows.Forms.TextBox();
            this.textBoxX3 = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.drawPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).BeginInit();
            this.toolPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawPanel
            // 
            this.drawPanel.Controls.Add(this.myPictureBox);
            this.drawPanel.Location = new System.Drawing.Point(1, 1);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(588, 544);
            this.drawPanel.TabIndex = 0;
            // 
            // myPictureBox
            // 
            this.myPictureBox.Location = new System.Drawing.Point(0, 0);
            this.myPictureBox.Name = "myPictureBox";
            this.myPictureBox.Size = new System.Drawing.Size(588, 544);
            this.myPictureBox.TabIndex = 0;
            this.myPictureBox.TabStop = false;
            this.myPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.MyPictureBox_Paint);
            this.myPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyPictureBox_MouseDown);
            this.myPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MyPictureBox_MouseMove);
            this.myPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MyPictureBox_MouseUp);
            // 
            // toolPanel
            // 
            this.toolPanel.Controls.Add(this.buttonClear);
            this.toolPanel.Controls.Add(this.buttonClearText);
            this.toolPanel.Controls.Add(this.buttonDraw);
            this.toolPanel.Controls.Add(this.label6);
            this.toolPanel.Controls.Add(this.label5);
            this.toolPanel.Controls.Add(this.label4);
            this.toolPanel.Controls.Add(this.label3);
            this.toolPanel.Controls.Add(this.label2);
            this.toolPanel.Controls.Add(this.label1);
            this.toolPanel.Controls.Add(this.textBoxY3);
            this.toolPanel.Controls.Add(this.textBoxX3);
            this.toolPanel.Controls.Add(this.textBoxY2);
            this.toolPanel.Controls.Add(this.textBoxX2);
            this.toolPanel.Controls.Add(this.textBoxY1);
            this.toolPanel.Controls.Add(this.textBoxX1);
            this.toolPanel.Location = new System.Drawing.Point(587, 1);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(190, 544);
            this.toolPanel.TabIndex = 1;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(35, 457);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(119, 34);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // buttonClearText
            // 
            this.buttonClearText.Location = new System.Drawing.Point(35, 373);
            this.buttonClearText.Name = "buttonClearText";
            this.buttonClearText.Size = new System.Drawing.Size(119, 64);
            this.buttonClearText.TabIndex = 13;
            this.buttonClearText.Text = "Очистить поля";
            this.buttonClearText.UseVisualStyleBackColor = true;
            this.buttonClearText.Click += new System.EventHandler(this.ButtonClearText_Click);
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(35, 318);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(119, 34);
            this.buttonDraw.TabIndex = 12;
            this.buttonDraw.Text = "Нарисовать";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.ButtonDraw_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "y3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "x3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "y2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "x2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "y1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "x1";
            // 
            // textBoxY3
            // 
            this.textBoxY3.Location = new System.Drawing.Point(107, 239);
            this.textBoxY3.Name = "textBoxY3";
            this.textBoxY3.Size = new System.Drawing.Size(70, 26);
            this.textBoxY3.TabIndex = 5;
            // 
            // textBoxX3
            // 
            this.textBoxX3.Location = new System.Drawing.Point(8, 239);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.Size = new System.Drawing.Size(70, 26);
            this.textBoxX3.TabIndex = 4;
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(107, 164);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(70, 26);
            this.textBoxY2.TabIndex = 3;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(8, 164);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(70, 26);
            this.textBoxX2.TabIndex = 2;
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(107, 86);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(70, 26);
            this.textBoxY1.TabIndex = 1;
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(8, 86);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(70, 26);
            this.textBoxX1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.toolPanel);
            this.Controls.Add(this.drawPanel);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.drawPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).EndInit();
            this.toolPanel.ResumeLayout(false);
            this.toolPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxY3;
        private System.Windows.Forms.TextBox textBoxX3;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClearText;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.PictureBox myPictureBox;
    }
}

