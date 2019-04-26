namespace 解决端口占用
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Button();
            this.fankui = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(74, 26);
            this.port.Margin = new System.Windows.Forms.Padding(4);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(127, 26);
            this.port.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "端口:";
            // 
            // check
            // 
            this.check.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check.Location = new System.Drawing.Point(226, 24);
            this.check.Margin = new System.Windows.Forms.Padding(4);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(116, 28);
            this.check.TabIndex = 2;
            this.check.Text = "查询端口占用";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // fankui
            // 
            this.fankui.AutoSize = true;
            this.fankui.Location = new System.Drawing.Point(262, 70);
            this.fankui.Name = "fankui";
            this.fankui.Size = new System.Drawing.Size(80, 16);
            this.fankui.TabIndex = 3;
            this.fankui.TabStop = true;
            this.fankui.Text = "反馈@小木";
            this.fankui.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.fankui_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(367, 101);
            this.Controls.Add(this.fankui);
            this.Controls.Add(this.check);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.port);
            this.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "解决端口占用";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.LinkLabel fankui;
    }
}

