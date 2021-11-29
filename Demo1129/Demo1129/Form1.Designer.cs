
namespace Demo1129
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.Role_Image = new System.Windows.Forms.Button();
            this.btn_攻擊我 = new System.Windows.Forms.Button();
            this.btn_攻擊怪物 = new System.Windows.Forms.Button();
            this.lbl_blood_me = new System.Windows.Forms.Label();
            this.lbl_myname = new System.Windows.Forms.Label();
            this.lbl_blood_master = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.myImage = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gbox_game = new System.Windows.Forms.GroupBox();
            this.cbox_role = new System.Windows.Forms.ComboBox();
            this.btn_again = new System.Windows.Forms.Button();
            this.masterImage = new System.Windows.Forms.Button();
            this.gbox_game.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(20, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "請選擇角色:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(20, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "輸入暱稱:";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_name.Location = new System.Drawing.Point(116, 12);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(205, 33);
            this.txt_name.TabIndex = 11;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Transparent;
            this.btn_submit.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_submit.Location = new System.Drawing.Point(454, 191);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(91, 35);
            this.btn_submit.TabIndex = 12;
            this.btn_submit.Text = "送出";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // Role_Image
            // 
            this.Role_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Role_Image.Location = new System.Drawing.Point(135, 105);
            this.Role_Image.Name = "Role_Image";
            this.Role_Image.Size = new System.Drawing.Size(108, 121);
            this.Role_Image.TabIndex = 4;
            this.Role_Image.UseVisualStyleBackColor = true;
            // 
            // btn_攻擊我
            // 
            this.btn_攻擊我.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_攻擊我.Location = new System.Drawing.Point(196, 126);
            this.btn_攻擊我.Name = "btn_攻擊我";
            this.btn_攻擊我.Size = new System.Drawing.Size(106, 49);
            this.btn_攻擊我.TabIndex = 22;
            this.btn_攻擊我.Text = "<< 攻擊";
            this.btn_攻擊我.UseVisualStyleBackColor = true;
            this.btn_攻擊我.Click += new System.EventHandler(this.btn_攻擊我_Click);
            // 
            // btn_攻擊怪物
            // 
            this.btn_攻擊怪物.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_攻擊怪物.Location = new System.Drawing.Point(196, 67);
            this.btn_攻擊怪物.Name = "btn_攻擊怪物";
            this.btn_攻擊怪物.Size = new System.Drawing.Size(106, 53);
            this.btn_攻擊怪物.TabIndex = 21;
            this.btn_攻擊怪物.Text = "攻擊 >>";
            this.btn_攻擊怪物.UseVisualStyleBackColor = true;
            this.btn_攻擊怪物.Click += new System.EventHandler(this.btn_攻擊怪物_Click);
            // 
            // lbl_blood_me
            // 
            this.lbl_blood_me.AutoSize = true;
            this.lbl_blood_me.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_blood_me.Location = new System.Drawing.Point(81, 219);
            this.lbl_blood_me.Name = "lbl_blood_me";
            this.lbl_blood_me.Size = new System.Drawing.Size(36, 19);
            this.lbl_blood_me.TabIndex = 20;
            this.lbl_blood_me.Text = "150";
            // 
            // lbl_myname
            // 
            this.lbl_myname.AutoSize = true;
            this.lbl_myname.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_myname.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_myname.Location = new System.Drawing.Point(29, 189);
            this.lbl_myname.Name = "lbl_myname";
            this.lbl_myname.Size = new System.Drawing.Size(29, 24);
            this.lbl_myname.TabIndex = 19;
            this.lbl_myname.Text = "我";
            // 
            // lbl_blood_master
            // 
            this.lbl_blood_master.AutoSize = true;
            this.lbl_blood_master.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_blood_master.Location = new System.Drawing.Point(389, 219);
            this.lbl_blood_master.Name = "lbl_blood_master";
            this.lbl_blood_master.Size = new System.Drawing.Size(79, 19);
            this.lbl_blood_master.TabIndex = 18;
            this.lbl_blood_master.Text = "血量:150";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(409, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "怪物";
            // 
            // myImage
            // 
            this.myImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myImage.Location = new System.Drawing.Point(22, 46);
            this.myImage.Name = "myImage";
            this.myImage.Size = new System.Drawing.Size(122, 140);
            this.myImage.TabIndex = 16;
            this.myImage.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(29, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "血量:";
            // 
            // gbox_game
            // 
            this.gbox_game.Controls.Add(this.btn_again);
            this.gbox_game.Controls.Add(this.label7);
            this.gbox_game.Controls.Add(this.btn_攻擊我);
            this.gbox_game.Controls.Add(this.btn_攻擊怪物);
            this.gbox_game.Controls.Add(this.lbl_blood_me);
            this.gbox_game.Controls.Add(this.lbl_myname);
            this.gbox_game.Controls.Add(this.lbl_blood_master);
            this.gbox_game.Controls.Add(this.label6);
            this.gbox_game.Controls.Add(this.myImage);
            this.gbox_game.Controls.Add(this.masterImage);
            this.gbox_game.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbox_game.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbox_game.Location = new System.Drawing.Point(19, 238);
            this.gbox_game.Name = "gbox_game";
            this.gbox_game.Size = new System.Drawing.Size(517, 299);
            this.gbox_game.TabIndex = 24;
            this.gbox_game.TabStop = false;
            this.gbox_game.Text = "開始遊戲";
            // 
            // cbox_role
            // 
            this.cbox_role.AutoCompleteCustomSource.AddRange(new string[] {
            "美人魚",
            "魔術師",
            "小精靈"});
            this.cbox_role.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox_role.FormattingEnabled = true;
            this.cbox_role.Items.AddRange(new object[] {
            "美人魚",
            "小精靈",
            "魔術師"});
            this.cbox_role.Location = new System.Drawing.Point(135, 67);
            this.cbox_role.Name = "cbox_role";
            this.cbox_role.Size = new System.Drawing.Size(121, 32);
            this.cbox_role.TabIndex = 25;
            this.cbox_role.SelectedIndexChanged += new System.EventHandler(this.cbox_role_SelectedIndexChanged);
            // 
            // btn_again
            // 
            this.btn_again.BackColor = System.Drawing.Color.Transparent;
            this.btn_again.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_again.Location = new System.Drawing.Point(370, 248);
            this.btn_again.Name = "btn_again";
            this.btn_again.Size = new System.Drawing.Size(126, 39);
            this.btn_again.TabIndex = 26;
            this.btn_again.Text = "重新開始";
            this.btn_again.UseVisualStyleBackColor = false;
            this.btn_again.Click += new System.EventHandler(this.btn_again_Click);
            // 
            // masterImage
            // 
            this.masterImage.BackgroundImage = global::Demo1129.Properties.Resources.怪物;
            this.masterImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.masterImage.Location = new System.Drawing.Point(367, 46);
            this.masterImage.Name = "masterImage";
            this.masterImage.Size = new System.Drawing.Size(110, 140);
            this.masterImage.TabIndex = 15;
            this.masterImage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(574, 542);
            this.Controls.Add(this.cbox_role);
            this.Controls.Add(this.gbox_game);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Role_Image);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "小遊戲";
            this.gbox_game.ResumeLayout(false);
            this.gbox_game.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Role_Image;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_攻擊我;
        private System.Windows.Forms.Button btn_攻擊怪物;
        private System.Windows.Forms.Label lbl_blood_me;
        private System.Windows.Forms.Label lbl_myname;
        private System.Windows.Forms.Label lbl_blood_master;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button myImage;
        private System.Windows.Forms.Button masterImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbox_game;
        private System.Windows.Forms.ComboBox cbox_role;
        private System.Windows.Forms.Button btn_again;
    }
}

