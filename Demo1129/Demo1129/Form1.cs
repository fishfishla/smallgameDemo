using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1129
{
    public partial class Form1 : Form
    {
        Role mymaster = new Master("怪物", "怪物");
        public Form1()
        {
            InitializeComponent();
            隱藏下方遊戲();
            cbox_role.SelectedIndex = 0;
            
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            
            if ((txt_name.Text!= "")&&(cbox_role.SelectedIndex!=-1))
            {
                創建角色();
                顯示下方遊戲();
            }
            else
            {
                MessageBox.Show("請輸入角色暱稱，並選擇角色");
            }

        }
        
        private void btn_攻擊怪物_Click(object sender, EventArgs e)
        {
          
                Random random = new Random();
                int hurt = random.Next(1,50);
                mymaster.受傷害(hurt);
                

                 if (mymaster.getHp() > 0)
                {
                    MessageBox.Show(mymaster.getName() + "受到" + hurt + "的傷害");
                    lbl_blood_master.Text = "血量:" + mymaster.getHp();
                    btn_攻擊我.Enabled = true;
                    btn_攻擊怪物.Enabled = false;
                }
                else
                {
                    MessageBox.Show("恭喜" + lbl_myname.Text + "獲勝!");
                    masterImage.BackgroundImage = Properties.Resources.dead;
                    lbl_blood_master.Text = "血量:" + mymaster.getHp();
                    btn_攻擊我.Enabled = false;
                    btn_攻擊怪物.Enabled = false;
            }

            
        }

        private void btn_攻擊我_Click(object sender, EventArgs e)
        {

            Role myrole = new myRole(lbl_myname.Text, cbox_role.Text, int.Parse(lbl_blood_me.Text));
            Random randomHurt = new Random();
            int hurt = randomHurt.Next(1, 35);
            myrole.受傷害(hurt);

            if (myrole.getHp() > 0)
            {
                MessageBox.Show(myrole.getName() + "受到" + hurt + "的傷害");

                lbl_blood_me.Text = "" + myrole.getHp();
                btn_攻擊我.Enabled = false;
                btn_攻擊怪物.Enabled = true;
            }
            else
            {
                lbl_blood_me.Text = "0";
                MessageBox.Show(myrole.getName() + "被怪物打敗了!");
                myImage.BackgroundImage = Properties.Resources.dead;
                btn_攻擊我.Enabled = false;
                btn_攻擊怪物.Enabled = false;
            }
           
        }
      
        public void 隱藏下方遊戲()
        {
            lbl_myname.Text = "";
            gbox_game.Hide();
        }
        public void 顯示下方遊戲()
        {
            txt_name.Enabled = false;
            cbox_role.Enabled = false;
            btn_submit.Enabled = false;
            btn_攻擊怪物.Enabled = true;
            btn_攻擊我.Enabled = false;
            Role_Image.Enabled = false;
            gbox_game.Show();
        }
        public void 創建角色 ()
        {
           
            Role myrole = new myRole(txt_name.Text, cbox_role.Text, 150);
            MessageBox.Show(txt_name.Text + " 歡迎來到小遊戲!");  
            if (cbox_role.SelectedIndex == 0)
            {
                myImage.BackgroundImage = Properties.Resources.fish;
            }
            else if (cbox_role.SelectedIndex == 1)
            {
                myImage.BackgroundImage = Properties.Resources.小精靈;
            }
            else
            {
                myImage.BackgroundImage = Properties.Resources.魔法師;
            }
            lbl_myname.Text = myrole.getName();
            lbl_blood_me.Text = "" + myrole.getHp();
            lbl_blood_master.Text = "血量:" + mymaster.getHp();
        }
        public void 角色選單()
        {
        
            if (cbox_role.Text == "美人魚")
            {
                Role_Image.BackgroundImage = Properties.Resources.fish;
            }else if (cbox_role.Text == "小精靈")
            {
                Role_Image.BackgroundImage = Properties.Resources.小精靈;
            }
            else
            {
                Role_Image.BackgroundImage = Properties.Resources.魔法師;
            }
        }

        private void cbox_role_SelectedIndexChanged(object sender, EventArgs e)
        {
            角色選單();
        }

        private void btn_again_Click(object sender, EventArgs e)
        {
            DialogResult myResult = MessageBox.Show
("確定要重新開始嗎?", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           
            if (myResult == DialogResult.Yes)
            {
                Hide();
                Form1 formOrder = new Form1();
                formOrder.ShowDialog();
            }
        
          
        }
    }
}
