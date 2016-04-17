namespace chatroomServer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.servStopListener = new System.Windows.Forms.Button();
            this.servStartListener = new System.Windows.Forms.Button();
            this.isAnonymous = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.servPort = new System.Windows.Forms.TextBox();
            this.servAddress = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.banAll = new System.Windows.Forms.Button();
            this.kickout = new System.Windows.Forms.Button();
            this.banUser = new System.Windows.Forms.Button();
            this.userList = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.exportRecord = new System.Windows.Forms.Button();
            this.sendToAllBtn = new System.Windows.Forms.Button();
            this.sendMessageBtn = new System.Windows.Forms.Button();
            this.sendText = new System.Windows.Forms.TextBox();
            this.chatRecordList = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.servStopListener);
            this.groupBox1.Controls.Add(this.servStartListener);
            this.groupBox1.Controls.Add(this.isAnonymous);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.servPort);
            this.groupBox1.Controls.Add(this.servAddress);
            this.groupBox1.Location = new System.Drawing.Point(24, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务器设置";
            // 
            // servStopListener
            // 
            this.servStopListener.Location = new System.Drawing.Point(234, 74);
            this.servStopListener.Name = "servStopListener";
            this.servStopListener.Size = new System.Drawing.Size(75, 23);
            this.servStopListener.TabIndex = 6;
            this.servStopListener.Text = "停止监听";
            this.servStopListener.UseVisualStyleBackColor = true;
            this.servStopListener.Click += new System.EventHandler(this.servStopListener_Click);
            // 
            // servStartListener
            // 
            this.servStartListener.Location = new System.Drawing.Point(139, 74);
            this.servStartListener.Name = "servStartListener";
            this.servStartListener.Size = new System.Drawing.Size(75, 23);
            this.servStartListener.TabIndex = 5;
            this.servStartListener.Text = "开始监听";
            this.servStartListener.UseVisualStyleBackColor = true;
            this.servStartListener.Click += new System.EventHandler(this.servStartListener_Click);
            // 
            // isAnonymous
            // 
            this.isAnonymous.AutoSize = true;
            this.isAnonymous.Location = new System.Drawing.Point(18, 81);
            this.isAnonymous.Name = "isAnonymous";
            this.isAnonymous.Size = new System.Drawing.Size(71, 16);
            this.isAnonymous.TabIndex = 4;
            this.isAnonymous.TabStop = true;
            this.isAnonymous.Text = "允许匿名";
            this.isAnonymous.UseVisualStyleBackColor = true;
            this.isAnonymous.Click += new System.EventHandler(this.isAnonymous_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "服务器IP地址和端口号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // servPort
            // 
            this.servPort.Location = new System.Drawing.Point(302, 32);
            this.servPort.Name = "servPort";
            this.servPort.Size = new System.Drawing.Size(46, 21);
            this.servPort.TabIndex = 1;
            // 
            // servAddress
            // 
            this.servAddress.Location = new System.Drawing.Point(139, 32);
            this.servAddress.Name = "servAddress";
            this.servAddress.Size = new System.Drawing.Size(140, 21);
            this.servAddress.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.banAll);
            this.groupBox2.Controls.Add(this.kickout);
            this.groupBox2.Controls.Add(this.banUser);
            this.groupBox2.Controls.Add(this.userList);
            this.groupBox2.Location = new System.Drawing.Point(404, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 487);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户列表";
            // 
            // banAll
            // 
            this.banAll.Location = new System.Drawing.Point(205, 450);
            this.banAll.Name = "banAll";
            this.banAll.Size = new System.Drawing.Size(75, 23);
            this.banAll.TabIndex = 3;
            this.banAll.Text = "全体禁言";
            this.banAll.UseVisualStyleBackColor = true;
            // 
            // kickout
            // 
            this.kickout.Location = new System.Drawing.Point(7, 451);
            this.kickout.Name = "kickout";
            this.kickout.Size = new System.Drawing.Size(75, 23);
            this.kickout.TabIndex = 2;
            this.kickout.Text = "踢出用户";
            this.kickout.UseVisualStyleBackColor = true;
            this.kickout.Click += new System.EventHandler(this.kickout_Click);
            // 
            // banUser
            // 
            this.banUser.Location = new System.Drawing.Point(109, 450);
            this.banUser.Name = "banUser";
            this.banUser.Size = new System.Drawing.Size(75, 23);
            this.banUser.TabIndex = 1;
            this.banUser.Text = "用户禁言";
            this.banUser.UseVisualStyleBackColor = true;
            // 
            // userList
            // 
            this.userList.FormattingEnabled = true;
            this.userList.ItemHeight = 12;
            this.userList.Location = new System.Drawing.Point(7, 21);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(274, 424);
            this.userList.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.exportRecord);
            this.groupBox3.Controls.Add(this.sendToAllBtn);
            this.groupBox3.Controls.Add(this.sendMessageBtn);
            this.groupBox3.Controls.Add(this.sendText);
            this.groupBox3.Controls.Add(this.chatRecordList);
            this.groupBox3.Location = new System.Drawing.Point(24, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 363);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "聊天记录";
            // 
            // exportRecord
            // 
            this.exportRecord.Location = new System.Drawing.Point(221, 327);
            this.exportRecord.Name = "exportRecord";
            this.exportRecord.Size = new System.Drawing.Size(91, 22);
            this.exportRecord.TabIndex = 4;
            this.exportRecord.Text = "导出聊天记录";
            this.exportRecord.UseVisualStyleBackColor = true;
            // 
            // sendToAllBtn
            // 
            this.sendToAllBtn.Location = new System.Drawing.Point(103, 327);
            this.sendToAllBtn.Name = "sendToAllBtn";
            this.sendToAllBtn.Size = new System.Drawing.Size(95, 23);
            this.sendToAllBtn.TabIndex = 3;
            this.sendToAllBtn.Text = "发送全体消息";
            this.sendToAllBtn.UseVisualStyleBackColor = true;
            this.sendToAllBtn.Click += new System.EventHandler(this.sendToAllBtn_Click);
            // 
            // sendMessageBtn
            // 
            this.sendMessageBtn.Location = new System.Drawing.Point(7, 327);
            this.sendMessageBtn.Name = "sendMessageBtn";
            this.sendMessageBtn.Size = new System.Drawing.Size(75, 23);
            this.sendMessageBtn.TabIndex = 2;
            this.sendMessageBtn.Text = "发送消息";
            this.sendMessageBtn.UseVisualStyleBackColor = true;
            this.sendMessageBtn.Click += new System.EventHandler(this.sendMessageBtn_Click);
            // 
            // sendText
            // 
            this.sendText.Location = new System.Drawing.Point(6, 298);
            this.sendText.Name = "sendText";
            this.sendText.Size = new System.Drawing.Size(341, 21);
            this.sendText.TabIndex = 1;
            // 
            // chatRecordList
            // 
            this.chatRecordList.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.chatRecordList.FormattingEnabled = true;
            this.chatRecordList.HorizontalScrollbar = true;
            this.chatRecordList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chatRecordList.ItemHeight = 12;
            this.chatRecordList.Location = new System.Drawing.Point(7, 21);
            this.chatRecordList.Name = "chatRecordList";
            this.chatRecordList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.chatRecordList.Size = new System.Drawing.Size(341, 268);
            this.chatRecordList.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 512);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ChatRoomServer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton isAnonymous;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox servPort;
        private System.Windows.Forms.TextBox servAddress;
        private System.Windows.Forms.Button servStartListener;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button kickout;
        private System.Windows.Forms.Button banUser;
        private System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.Button servStopListener;
        private System.Windows.Forms.Button banAll;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button exportRecord;
        private System.Windows.Forms.Button sendToAllBtn;
        private System.Windows.Forms.Button sendMessageBtn;
        private System.Windows.Forms.TextBox sendText;
        private System.Windows.Forms.ListBox chatRecordList;
    }
}

