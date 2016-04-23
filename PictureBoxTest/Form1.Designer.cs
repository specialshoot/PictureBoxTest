namespace PictureBoxTest {
    partial class Form1 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Target = new System.Windows.Forms.PictureBox();
            this.Label_Location = new System.Windows.Forms.Label();
            this.cbAdd = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_Target = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pictureBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Target)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "打开";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(646, 21);
            this.textBox1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(13, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 431);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Controls.Add(this.pictureBox_Target);
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(962, 423);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox_Target
            // 
            this.pictureBox_Target.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Target.Image = global::PictureBoxTest.Properties.Resources.favorite_place;
            this.pictureBox_Target.Location = new System.Drawing.Point(473, 239);
            this.pictureBox_Target.Name = "pictureBox_Target";
            this.pictureBox_Target.Size = new System.Drawing.Size(45, 45);
            this.pictureBox_Target.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Target.TabIndex = 1;
            this.pictureBox_Target.TabStop = false;
            this.pictureBox_Target.Visible = false;
            // 
            // Label_Location
            // 
            this.Label_Location.AutoSize = true;
            this.Label_Location.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_Location.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Location.Location = new System.Drawing.Point(225, 478);
            this.Label_Location.Name = "Label_Location";
            this.Label_Location.Size = new System.Drawing.Size(100, 23);
            this.Label_Location.TabIndex = 4;
            this.Label_Location.Text = "LOCATION";
            this.Label_Location.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbAdd
            // 
            this.cbAdd.AutoSize = true;
            this.cbAdd.Location = new System.Drawing.Point(746, 16);
            this.cbAdd.Name = "cbAdd";
            this.cbAdd.Size = new System.Drawing.Size(84, 16);
            this.cbAdd.TabIndex = 5;
            this.cbAdd.Text = "设置目标点";
            this.cbAdd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(11, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "坐标：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(9, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "目标点绝对坐标：";
            // 
            // Label_Target
            // 
            this.Label_Target.AutoSize = true;
            this.Label_Target.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Target.Location = new System.Drawing.Point(225, 510);
            this.Label_Target.Name = "Label_Target";
            this.Label_Target.Size = new System.Drawing.Size(76, 21);
            this.Label_Target.TabIndex = 8;
            this.Label_Target.Text = "TARGET";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 583);
            this.Controls.Add(this.Label_Target);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAdd);
            this.Controls.Add(this.Label_Location);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "图片缩放及图片比例定位";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pictureBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Target)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label_Location;
        private System.Windows.Forms.CheckBox cbAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_Target;
        private System.Windows.Forms.PictureBox pictureBox_Target;
    }
}

