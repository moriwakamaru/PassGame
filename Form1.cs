using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 突破ゲーム
{
    public partial class Form1 : Form
    {
        Point Cpos;
        Boolean shotFlg;//true:発射移動中
        Boolean hitFlg;//true:当たった
        long score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void movePlayer()
        {
            if(hitFlg)
            {
                return;
            }
            Player.Top -= 12;
            if(Player.Top<(0-Player.Height))
            {
                score+= 10;//画面上部まで来たのでスコア加算
                Scorerbl.Text = score.ToString();
                sukima.Width -= 5;
                initPlayer();//プレイヤーの初期化
            }

            long pH = Player.Height;
            long pW = Player.Width;
            long sH = sukima.Height;
            long sW = sukima.Width;

            if((Player.Top<sukima.Top+sH)&&(Player.Top+pH>sukima.Top))
            {
                if((Player.Left<sukima.Left)||(Player.Left+pH>sukima.Left+sW))
                {
                    hitFlg = true;
                    StartButton.Enabled = true;
                    GameOver.Show();
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Cpos = PointToClient(Cursor.Position);
            Console.WriteLine(Cpos.X+" "+Cpos.Y);
            moveSukima();

            if(shotFlg)
            {
                movePlayer();//プレイヤーの上移動
                return;
            }

            if(Cpos.X<0)
            {
                Cpos.X = 0;
            }
            if(Cpos.X>Width-Player.Width)
            {
                Cpos.X = Width - Player.Width;
            }

            Player.Left = Cpos.X;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initGame();
        }

        private void initGame()
        {
            hitFlg = false;
            GameOver.Hide();
            StartButton.Enabled = false;
            score = 0;
            Scorerbl.Text = "0";
            sukima.Width = 300;
            initPlayer();
        }

        private void moveSukima()
        {
            if(hitFlg)
            {
                return;
            }
            sukima.Left += 6;
            if(sukima.Left>Width)
            {
                sukima.Left = -sukima.Left;
            }
        }
        private void initPlayer()
        {
            Player.Top = Height - (Player.Height * 2);
            Player.Left = Cpos.X;
            shotFlg = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            shotFlg = true;//true:発射移動中
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            initGame();
        }
    }
}
