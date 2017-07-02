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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbManualTrein = new System.Windows.Forms.RadioButton();
            this.rbAvtoTrein = new System.Windows.Forms.RadioButton();
            this.btnTrein = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbManualSerch = new System.Windows.Forms.RadioButton();
            this.rbAvtoSerch = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbManualRecognaze = new System.Windows.Forms.RadioButton();
            this.rbAvtoRecognaze = new System.Windows.Forms.RadioButton();
            this.btnRecognaze = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbVideo = new System.Windows.Forms.RadioButton();
            this.rbFoto = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.btnLoad.Location = new System.Drawing.Point(21, 93);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // btnSerchFace
            // 
            this.btnSerchFace.Enabled = false;
            this.btnSerchFace.Location = new System.Drawing.Point(22, 92);
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
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 131);
            this.panel1.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbManualTrein);
            this.groupBox4.Controls.Add(this.rbAvtoTrein);
            this.groupBox4.Controls.Add(this.btnTrein);
            this.groupBox4.Location = new System.Drawing.Point(253, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(117, 122);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Тренировка";
            // 
            // rbManualTrein
            // 
            this.rbManualTrein.AutoSize = true;
            this.rbManualTrein.Location = new System.Drawing.Point(6, 57);
            this.rbManualTrein.Name = "rbManualTrein";
            this.rbManualTrein.Size = new System.Drawing.Size(67, 17);
            this.rbManualTrein.TabIndex = 0;
            this.rbManualTrein.Text = "Вручную";
            this.rbManualTrein.UseVisualStyleBackColor = true;
            // 
            // rbAvtoTrein
            // 
            this.rbAvtoTrein.AutoSize = true;
            this.rbAvtoTrein.Checked = true;
            this.rbAvtoTrein.Location = new System.Drawing.Point(5, 23);
            this.rbAvtoTrein.Name = "rbAvtoTrein";
            this.rbAvtoTrein.Size = new System.Drawing.Size(104, 17);
            this.rbAvtoTrein.TabIndex = 0;
            this.rbAvtoTrein.TabStop = true;
            this.rbAvtoTrein.Text = "Автомарически";
            this.rbAvtoTrein.UseVisualStyleBackColor = true;
            this.rbAvtoTrein.CheckedChanged += new System.EventHandler(this.RbAvtoTrein_CheckedChanged);
            // 
            // btnTrein
            // 
            this.btnTrein.Location = new System.Drawing.Point(18, 92);
            this.btnTrein.Name = "btnTrein";
            this.btnTrein.Size = new System.Drawing.Size(82, 23);
            this.btnTrein.TabIndex = 5;
            this.btnTrein.Text = "Тренировать";
            this.btnTrein.UseVisualStyleBackColor = true;
            this.btnTrein.Click += new System.EventHandler(this.BtnTrein_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbManualSerch);
            this.groupBox3.Controls.Add(this.rbAvtoSerch);
            this.groupBox3.Controls.Add(this.btnSerchFace);
            this.groupBox3.Location = new System.Drawing.Point(130, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(117, 122);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск";
            // 
            // rbManualSerch
            // 
            this.rbManualSerch.AutoSize = true;
            this.rbManualSerch.Location = new System.Drawing.Point(6, 57);
            this.rbManualSerch.Name = "rbManualSerch";
            this.rbManualSerch.Size = new System.Drawing.Size(67, 17);
            this.rbManualSerch.TabIndex = 0;
            this.rbManualSerch.Text = "Вручную";
            this.rbManualSerch.UseVisualStyleBackColor = true;
            this.rbManualSerch.CheckedChanged += new System.EventHandler(this.RbManualSerch_CheckedChanged);
            // 
            // rbAvtoSerch
            // 
            this.rbAvtoSerch.AutoSize = true;
            this.rbAvtoSerch.Checked = true;
            this.rbAvtoSerch.Location = new System.Drawing.Point(5, 23);
            this.rbAvtoSerch.Name = "rbAvtoSerch";
            this.rbAvtoSerch.Size = new System.Drawing.Size(104, 17);
            this.rbAvtoSerch.TabIndex = 0;
            this.rbAvtoSerch.TabStop = true;
            this.rbAvtoSerch.Text = "Автомарически";
            this.rbAvtoSerch.UseVisualStyleBackColor = true;
            this.rbAvtoSerch.CheckedChanged += new System.EventHandler(this.RbAvtoSerch_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbManualRecognaze);
            this.groupBox2.Controls.Add(this.rbAvtoRecognaze);
            this.groupBox2.Controls.Add(this.btnRecognaze);
            this.groupBox2.Location = new System.Drawing.Point(377, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 122);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Разпознование";
            // 
            // rbManualRecognaze
            // 
            this.rbManualRecognaze.AutoSize = true;
            this.rbManualRecognaze.Location = new System.Drawing.Point(6, 57);
            this.rbManualRecognaze.Name = "rbManualRecognaze";
            this.rbManualRecognaze.Size = new System.Drawing.Size(67, 17);
            this.rbManualRecognaze.TabIndex = 0;
            this.rbManualRecognaze.Text = "Вручную";
            this.rbManualRecognaze.UseVisualStyleBackColor = true;
            // 
            // rbAvtoRecognaze
            // 
            this.rbAvtoRecognaze.AutoSize = true;
            this.rbAvtoRecognaze.Checked = true;
            this.rbAvtoRecognaze.Location = new System.Drawing.Point(5, 23);
            this.rbAvtoRecognaze.Name = "rbAvtoRecognaze";
            this.rbAvtoRecognaze.Size = new System.Drawing.Size(104, 17);
            this.rbAvtoRecognaze.TabIndex = 0;
            this.rbAvtoRecognaze.TabStop = true;
            this.rbAvtoRecognaze.Text = "Автомарически";
            this.rbAvtoRecognaze.UseVisualStyleBackColor = true;
            // 
            // btnRecognaze
            // 
            this.btnRecognaze.Location = new System.Drawing.Point(18, 93);
            this.btnRecognaze.Name = "btnRecognaze";
            this.btnRecognaze.Size = new System.Drawing.Size(75, 23);
            this.btnRecognaze.TabIndex = 6;
            this.btnRecognaze.Text = "Распознать";
            this.btnRecognaze.UseVisualStyleBackColor = true;
            this.btnRecognaze.Click += new System.EventHandler(this.BtnRecognaze_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbVideo);
            this.groupBox1.Controls.Add(this.rbFoto);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 122);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Источник данных";
            // 
            // rbVideo
            // 
            this.rbVideo.AutoSize = true;
            this.rbVideo.Location = new System.Drawing.Point(7, 57);
            this.rbVideo.Name = "rbVideo";
            this.rbVideo.Size = new System.Drawing.Size(56, 17);
            this.rbVideo.TabIndex = 0;
            this.rbVideo.Text = "Видео";
            this.rbVideo.UseVisualStyleBackColor = true;
            // 
            // rbFoto
            // 
            this.rbFoto.AutoSize = true;
            this.rbFoto.Checked = true;
            this.rbFoto.Location = new System.Drawing.Point(6, 23);
            this.rbFoto.Name = "rbFoto";
            this.rbFoto.Size = new System.Drawing.Size(53, 17);
            this.rbFoto.TabIndex = 0;
            this.rbFoto.TabStop = true;
            this.rbFoto.Text = "Фото";
            this.rbFoto.UseVisualStyleBackColor = true;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 455);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(400, 89);
            this.textBox2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 556);
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbVideo;
        private System.Windows.Forms.RadioButton rbFoto;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbManualTrein;
        private System.Windows.Forms.RadioButton rbAvtoTrein;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbManualSerch;
        private System.Windows.Forms.RadioButton rbAvtoSerch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbManualRecognaze;
        private System.Windows.Forms.RadioButton rbAvtoRecognaze;
        private System.Windows.Forms.Button btnRecognaze;
        private System.Windows.Forms.Label label3;
    }
}

