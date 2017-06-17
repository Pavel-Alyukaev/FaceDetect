namespace FaceDetect
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
            this.components = new System.ComponentModel.Container();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSerchFace = new System.Windows.Forms.Button();
            this.btnNextFace = new System.Windows.Forms.Button();
            this.btnPrewFace = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAddBase = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRecognaze = new System.Windows.Forms.Button();
            this.btnTrein = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.Location = new System.Drawing.Point(12, 149);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(400, 300);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox2.Location = new System.Drawing.Point(432, 149);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(200, 200);
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(65, 55);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // btnSerchFace
            // 
            this.btnSerchFace.Location = new System.Drawing.Point(202, 55);
            this.btnSerchFace.Name = "btnSerchFace";
            this.btnSerchFace.Size = new System.Drawing.Size(75, 23);
            this.btnSerchFace.TabIndex = 4;
            this.btnSerchFace.Text = "Найти";
            this.btnSerchFace.UseVisualStyleBackColor = true;
            this.btnSerchFace.Click += new System.EventHandler(this.BtnSerchFace_Click);
            // 
            // btnNextFace
            // 
            this.btnNextFace.Location = new System.Drawing.Point(557, 355);
            this.btnNextFace.Name = "btnNextFace";
            this.btnNextFace.Size = new System.Drawing.Size(75, 23);
            this.btnNextFace.TabIndex = 5;
            this.btnNextFace.Text = ">>";
            this.btnNextFace.UseVisualStyleBackColor = true;
            this.btnNextFace.Click += new System.EventHandler(this.BtnNextFace_Click);
            // 
            // btnPrewFace
            // 
            this.btnPrewFace.Location = new System.Drawing.Point(432, 355);
            this.btnPrewFace.Name = "btnPrewFace";
            this.btnPrewFace.Size = new System.Drawing.Size(75, 23);
            this.btnPrewFace.TabIndex = 6;
            this.btnPrewFace.Text = "<<";
            this.btnPrewFace.UseVisualStyleBackColor = true;
            this.btnPrewFace.Click += new System.EventHandler(this.BtnPrewFace_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAddBase
            // 
            this.btnAddBase.Location = new System.Drawing.Point(501, 426);
            this.btnAddBase.Name = "btnAddBase";
            this.btnAddBase.Size = new System.Drawing.Size(75, 23);
            this.btnAddBase.TabIndex = 8;
            this.btnAddBase.Text = "Add Base";
            this.btnAddBase.UseVisualStyleBackColor = true;
            this.btnAddBase.Click += new System.EventHandler(this.BtnAddBase_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(464, 384);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Имя";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnRecognaze);
            this.panel1.Controls.Add(this.btnTrein);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.btnSerchFace);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 100);
            this.panel1.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Фото",
            "Видео"});
            this.comboBox1.Location = new System.Drawing.Point(19, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // btnRecognaze
            // 
            this.btnRecognaze.Location = new System.Drawing.Point(408, 55);
            this.btnRecognaze.Name = "btnRecognaze";
            this.btnRecognaze.Size = new System.Drawing.Size(75, 23);
            this.btnRecognaze.TabIndex = 6;
            this.btnRecognaze.Text = "Распознать";
            this.btnRecognaze.UseVisualStyleBackColor = true;
            this.btnRecognaze.Click += new System.EventHandler(this.BtnRecognaze_Click);
            // 
            // btnTrein
            // 
            this.btnTrein.Location = new System.Drawing.Point(298, 55);
            this.btnTrein.Name = "btnTrein";
            this.btnTrein.Size = new System.Drawing.Size(82, 23);
            this.btnTrein.TabIndex = 5;
            this.btnTrein.Text = "Тренировать";
            this.btnTrein.UseVisualStyleBackColor = true;
            this.btnTrein.Click += new System.EventHandler(this.BtnTrein_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 455);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(400, 89);
            this.textBox2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 556);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAddBase);
            this.Controls.Add(this.btnPrewFace);
            this.Controls.Add(this.btnNextFace);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.imageBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSerchFace;
        private System.Windows.Forms.Button btnNextFace;
        private System.Windows.Forms.Button btnPrewFace;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAddBase;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTrein;
        private System.Windows.Forms.Button btnRecognaze;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

