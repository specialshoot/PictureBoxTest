using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace PictureBoxTest {
    public partial class Form1 : Form {

        Bitmap myBmp;
        Point mouseDownPoint = new Point(); //记录拖拽过程鼠标位置
        bool isMove = false;    //判断鼠标在picturebox上移动时，是否处于拖拽过程(鼠标左键是否按下)
        int zoomStep = 20;      //缩放步长
        int oriWidth = 0;
        int oriHeight = 0;
        double widthRatio = 1.0;//x方向变换比率
        double heightRatio = 1.0;//y方向变换比率
        int targetX = 0;
        int targetY = 0;

        public Form1() {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                mouseDownPoint.X = Cursor.Position.X;   //记录鼠标左键按下时位置
                mouseDownPoint.Y = Cursor.Position.Y;
                isMove = true;
                pictureBox1.Focus();    //鼠标滚轮事件(缩放时)需要picturebox有焦点
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                isMove = false;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e) {
            pictureBox1.Focus();    //鼠标在picturebox上时才有焦点，此时可以缩放
            if (isMove) {
                int x, y;           //新的pictureBox1.Location(x,y)
                int moveX, moveY;   //X方向，Y方向移动大小。
                moveX = Cursor.Position.X - mouseDownPoint.X;
                moveY = Cursor.Position.Y - mouseDownPoint.Y;
                x = pictureBox1.Location.X + moveX;
                y = pictureBox1.Location.Y + moveY;
                pictureBox1.Location = new Point(x, y);
                mouseDownPoint.X = Cursor.Position.X;
                mouseDownPoint.Y = Cursor.Position.Y;
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            pictureBox1.MouseWheel += new MouseEventHandler(pictureBox1_MouseWheel);
        }

        /*
         * pictureBox缩放事件
         */
        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e) {
            int x = e.Location.X;
            int y = e.Location.Y;
            int ow = pictureBox1.Width;
            int oh = pictureBox1.Height;
            int VX, VY;     //因缩放产生的位移矢量
            if (e.Delta > 0)    //放大
            {
                //第①步
                pictureBox1.Width += zoomStep;
                pictureBox1.Height += zoomStep;
                //第②步
                PropertyInfo pInfo = pictureBox1.GetType().GetProperty("ImageRectangle", BindingFlags.Instance |
                    BindingFlags.NonPublic);
                Rectangle rect = (Rectangle)pInfo.GetValue(pictureBox1, null);
                //第③步
                pictureBox1.Width = rect.Width;
                pictureBox1.Height = rect.Height;
            }
            if (e.Delta < 0)    //缩小
            {
                //防止一直缩成负值
                if (pictureBox1.Width < myBmp.Width / 10)
                    return;

                pictureBox1.Width -= zoomStep;
                pictureBox1.Height -= zoomStep;
                PropertyInfo pInfo = pictureBox1.GetType().GetProperty("ImageRectangle", BindingFlags.Instance |
                    BindingFlags.NonPublic);
                Rectangle rect = (Rectangle)pInfo.GetValue(pictureBox1, null);
                pictureBox1.Width = rect.Width;
                pictureBox1.Height = rect.Height;
            }
            //第④步，求因缩放产生的位移，进行补偿，实现锚点缩放的效果
            VX = (int)((double)x * (ow - pictureBox1.Width) / ow);
            VY = (int)((double)y * (oh - pictureBox1.Height) / oh);
            pictureBox1.Location = new Point(pictureBox1.Location.X + VX, pictureBox1.Location.Y + VY);
            int tarX = (int)(targetX * (pictureBox1.Width * 1.0 / oriWidth));
            int tarY = (int)(targetY * (pictureBox1.Height * 1.0 / oriHeight));
            pictureBox_Target.Location = new Point(tarX - pictureBox_Target.Width / 2, tarY - pictureBox_Target.Height);
        }

        private void button1_Click(object sender, EventArgs e) {
            string filename = "";
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Tiff文件|*.tif|Bmp文件|*.bmp|Erdas img文件|*.img|EVNI文件|*.hdr|jpeg文件|*.jpg|raw文件|*.raw|vrt文件|*.vrt|所有文件|*.*";
            dlg.FilterIndex = 8;
            if (dlg.ShowDialog() == DialogResult.OK) {
                filename = dlg.FileName;
            }
            if (filename == "") {
                return;
            }
            myBmp = new Bitmap(filename);
            if (myBmp == null) {
                MessageBox.Show("读取失败");
                return;
            }
            textBox1.Text = filename;
            pictureBox1.Image = myBmp;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; //设置picturebox为缩放模式
            pictureBox1.Width = myBmp.Width;
            pictureBox1.Height = myBmp.Height;
            oriWidth = myBmp.Width;
            oriHeight = myBmp.Height;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                mouseDownPoint.X = Cursor.Position.X;
                mouseDownPoint.Y = Cursor.Position.Y;
                isMove = true;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                isMove = false;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e) {
            panel1.Focus();
            if (isMove) {
                int x, y;
                int moveX, moveY;
                moveX = Cursor.Position.X - mouseDownPoint.X;
                moveY = Cursor.Position.Y - mouseDownPoint.Y;
                x = pictureBox1.Location.X + moveX;
                y = pictureBox1.Location.Y + moveY;
                pictureBox1.Location = new Point(x, y);
                mouseDownPoint.X = Cursor.Position.X;
                mouseDownPoint.Y = Cursor.Position.Y;
                int tarX = (int)(targetX * (pictureBox1.Width * 1.0 / oriWidth));
                int tarY = (int)(targetY * (pictureBox1.Height * 1.0 / oriHeight));
                pictureBox_Target.Location = new Point(tarX - pictureBox_Target.Width / 2, tarY - pictureBox_Target.Height);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e) {
            widthRatio = pictureBox1.Width * 1.0 / oriWidth;
            heightRatio = pictureBox1.Height * 1.0 / oriHeight;
            int afterSizeX = e.X * oriWidth / pictureBox1.Width;
            int afterSizeY = e.Y * oriHeight / pictureBox1.Height;
            Label_Location.Text = e.X + ";" + e.Y + ";" + widthRatio + ";" + heightRatio + ";" + afterSizeX + ";" + afterSizeY;
            if (cbAdd.Checked) {
                pictureBox_Target.Visible = Visible;
                pictureBox_Target.Location = new Point(e.X - pictureBox_Target.Width / 2, e.Y - pictureBox_Target.Height);
                targetX = afterSizeX;
                targetY = afterSizeY;
            }
        }
    }
}
