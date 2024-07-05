using System;

namespace dasboard_template
{
    partial class Form1
    {

        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonpanel = new System.Windows.Forms.Panel();
            this.btnpage_1 = new System.Windows.Forms.Button();
            this.btnpage_2 = new System.Windows.Forms.Button();
            this.btnpage_3 = new System.Windows.Forms.Button();
            this.btnpagesettings = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.username = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.topbar = new System.Windows.Forms.Panel();
            this.closebutton = new System.Windows.Forms.Button();
            this.windowstatemaxbutton = new System.Windows.Forms.Button();
            this.windowstatusminbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.page_panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.topbar.SuspendLayout();
            this.page_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonpanel
            // 
            this.buttonpanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonpanel.Controls.Add(this.btnpagesettings);
            this.buttonpanel.Controls.Add(this.btnpage_3);
            this.buttonpanel.Controls.Add(this.btnpage_2);
            this.buttonpanel.Controls.Add(this.btnpage_1);
            this.buttonpanel.Controls.Add(this.panel1);
            this.buttonpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonpanel.Location = new System.Drawing.Point(0, 26);
            this.buttonpanel.Name = "buttonpanel";
            this.buttonpanel.Size = new System.Drawing.Size(155, 585);
            this.buttonpanel.TabIndex = 1;
            // 
            // btnpage_1
            // 
            this.btnpage_1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnpage_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnpage_1.FlatAppearance.BorderSize = 0;
            this.btnpage_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpage_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpage_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnpage_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpage_1.Location = new System.Drawing.Point(0, 118);
            this.btnpage_1.Name = "btnpage_1";
            this.btnpage_1.Size = new System.Drawing.Size(155, 33);
            this.btnpage_1.TabIndex = 1;
            this.btnpage_1.Text = "PAGE 1";
            this.btnpage_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpage_1.UseVisualStyleBackColor = false;
            this.btnpage_1.Click += new System.EventHandler(this.btnpage_1_Click);
            // 
            // btnpage_2
            // 
            this.btnpage_2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnpage_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnpage_2.FlatAppearance.BorderSize = 0;
            this.btnpage_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpage_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpage_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnpage_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpage_2.Location = new System.Drawing.Point(0, 151);
            this.btnpage_2.Name = "btnpage_2";
            this.btnpage_2.Size = new System.Drawing.Size(155, 33);
            this.btnpage_2.TabIndex = 2;
            this.btnpage_2.Text = "PAGE 2";
            this.btnpage_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpage_2.UseVisualStyleBackColor = false;
            this.btnpage_2.Click += new System.EventHandler(this.btnpage_2_Click);
            // 
            // btnpage_3
            // 
            this.btnpage_3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnpage_3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnpage_3.FlatAppearance.BorderSize = 0;
            this.btnpage_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpage_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpage_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnpage_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpage_3.Location = new System.Drawing.Point(0, 184);
            this.btnpage_3.Name = "btnpage_3";
            this.btnpage_3.Size = new System.Drawing.Size(155, 33);
            this.btnpage_3.TabIndex = 3;
            this.btnpage_3.Text = "PAGE 3";
            this.btnpage_3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpage_3.UseVisualStyleBackColor = false;
            this.btnpage_3.Click += new System.EventHandler(this.btnpage_3_Click);
            // 
            // btnpagesettings
            // 
            this.btnpagesettings.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnpagesettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnpagesettings.FlatAppearance.BorderSize = 0;
            this.btnpagesettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpagesettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpagesettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnpagesettings.Image = ((System.Drawing.Image)(resources.GetObject("btnpagesettings.Image")));
            this.btnpagesettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpagesettings.Location = new System.Drawing.Point(0, 552);
            this.btnpagesettings.Name = "btnpagesettings";
            this.btnpagesettings.Size = new System.Drawing.Size(155, 33);
            this.btnpagesettings.TabIndex = 4;
            this.btnpagesettings.Text = "SETTİNGS";
            this.btnpagesettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpagesettings.UseVisualStyleBackColor = false;
            this.btnpagesettings.Click += new System.EventHandler(this.btnsettingspage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.username.Location = new System.Drawing.Point(28, 85);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(97, 20);
            this.username.TabIndex = 1;
            this.username.Text = "user name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 118);
            this.panel1.TabIndex = 0;
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.Color.DimGray;
            this.topbar.Controls.Add(this.windowstatusminbutton);
            this.topbar.Controls.Add(this.windowstatemaxbutton);
            this.topbar.Controls.Add(this.closebutton);
            this.topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar.Location = new System.Drawing.Point(0, 0);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(1165, 26);
            this.topbar.TabIndex = 3;
            this.topbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topbar_MouseDown);
            this.topbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topbar_MouseMove);
            this.topbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topbar_MouseUp);
            // 
            // closebutton
            // 
            this.closebutton.BackColor = System.Drawing.Color.DimGray;
            this.closebutton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closebutton.FlatAppearance.BorderSize = 0;
            this.closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.closebutton.Location = new System.Drawing.Point(1134, 0);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(31, 26);
            this.closebutton.TabIndex = 0;
            this.closebutton.Text = "X";
            this.closebutton.UseVisualStyleBackColor = false;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // windowstatemaxbutton
            // 
            this.windowstatemaxbutton.BackColor = System.Drawing.Color.DimGray;
            this.windowstatemaxbutton.Dock = System.Windows.Forms.DockStyle.Right;
            this.windowstatemaxbutton.FlatAppearance.BorderSize = 0;
            this.windowstatemaxbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windowstatemaxbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.windowstatemaxbutton.Image = ((System.Drawing.Image)(resources.GetObject("windowstatemaxbutton.Image")));
            this.windowstatemaxbutton.Location = new System.Drawing.Point(1103, 0);
            this.windowstatemaxbutton.Name = "windowstatemaxbutton";
            this.windowstatemaxbutton.Size = new System.Drawing.Size(31, 26);
            this.windowstatemaxbutton.TabIndex = 1;
            this.windowstatemaxbutton.UseVisualStyleBackColor = false;
            this.windowstatemaxbutton.Click += new System.EventHandler(this.windowstatemaxbutton_Click);
            // 
            // windowstatusminbutton
            // 
            this.windowstatusminbutton.BackColor = System.Drawing.Color.DimGray;
            this.windowstatusminbutton.Dock = System.Windows.Forms.DockStyle.Right;
            this.windowstatusminbutton.FlatAppearance.BorderSize = 0;
            this.windowstatusminbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windowstatusminbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.windowstatusminbutton.Location = new System.Drawing.Point(1072, 0);
            this.windowstatusminbutton.Name = "windowstatusminbutton";
            this.windowstatusminbutton.Size = new System.Drawing.Size(31, 26);
            this.windowstatusminbutton.TabIndex = 2;
            this.windowstatusminbutton.Text = "-";
            this.windowstatusminbutton.UseVisualStyleBackColor = false;
            this.windowstatusminbutton.Click += new System.EventHandler(this.windowstatusminbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(381, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(8, 8);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // page_panel
            // 
            this.page_panel.AutoScroll = true;
            this.page_panel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.page_panel.Controls.Add(this.groupBox1);
            this.page_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_panel.ForeColor = System.Drawing.Color.Black;
            this.page_panel.Location = new System.Drawing.Point(155, 26);
            this.page_panel.Name = "page_panel";
            this.page_panel.Size = new System.Drawing.Size(1010, 585);
            this.page_panel.TabIndex = 2;
            this.page_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.page_panel_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(155, 608);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 3);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1162, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 582);
            this.panel3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 611);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.page_panel);
            this.Controls.Add(this.buttonpanel);
            this.Controls.Add(this.topbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.buttonpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.topbar.ResumeLayout(false);
            this.page_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttonpanel;
        private System.Windows.Forms.Button btnpagesettings;
        private System.Windows.Forms.Button btnpage_3;
        private System.Windows.Forms.Button btnpage_2;
        private System.Windows.Forms.Button btnpage_1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Button windowstatusminbutton;
        private System.Windows.Forms.Button windowstatemaxbutton;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel page_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

