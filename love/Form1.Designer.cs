namespace love
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playerButtonNo = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbTxt = new System.Windows.Forms.Label();
            this.lbAsk = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.playerButtonYes = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnNoClick = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.playerButtonNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerButtonYes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNoClick)).BeginInit();
            this.SuspendLayout();
            // 
            // playerButtonNo
            // 
            this.playerButtonNo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.playerButtonNo.Enabled = true;
            this.playerButtonNo.Location = new System.Drawing.Point(0, 417);
            this.playerButtonNo.Name = "playerButtonNo";
            this.playerButtonNo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("playerButtonNo.OcxState")));
            this.playerButtonNo.Size = new System.Drawing.Size(800, 33);
            this.playerButtonNo.TabIndex = 3;
            this.playerButtonNo.Visible = false;
            // 
            // lbTxt
            // 
            this.lbTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTxt.BackColor = System.Drawing.Color.Transparent;
            this.lbTxt.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTxt.Location = new System.Drawing.Point(12, 9);
            this.lbTxt.Name = "lbTxt";
            this.lbTxt.Size = new System.Drawing.Size(776, 76);
            this.lbTxt.TabIndex = 4;
            this.lbTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAsk
            // 
            this.lbAsk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAsk.BackColor = System.Drawing.Color.Transparent;
            this.lbAsk.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAsk.Location = new System.Drawing.Point(12, 101);
            this.lbAsk.Name = "lbAsk";
            this.lbAsk.Size = new System.Drawing.Size(776, 43);
            this.lbAsk.TabIndex = 0;
            this.lbAsk.Text = "Do you love me?❤️❤";
            this.lbAsk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYes
            // 
            this.btnYes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnYes.BackColor = System.Drawing.Color.Transparent;
            this.btnYes.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(238, 273);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(110, 51);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "Yes❤️";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNo
            // 
            this.btnNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNo.BackColor = System.Drawing.Color.Transparent;
            this.btnNo.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(459, 273);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(110, 51);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "No😭";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            this.btnNo.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            // 
            // playerButtonYes
            // 
            this.playerButtonYes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.playerButtonYes.Enabled = true;
            this.playerButtonYes.Location = new System.Drawing.Point(0, 384);
            this.playerButtonYes.Name = "playerButtonYes";
            this.playerButtonYes.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("playerButtonYes.OcxState")));
            this.playerButtonYes.Size = new System.Drawing.Size(800, 33);
            this.playerButtonYes.TabIndex = 5;
            this.playerButtonYes.Visible = false;
            // 
            // btnNoClick
            // 
            this.btnNoClick.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNoClick.Enabled = true;
            this.btnNoClick.Location = new System.Drawing.Point(0, 351);
            this.btnNoClick.Name = "btnNoClick";
            this.btnNoClick.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("btnNoClick.OcxState")));
            this.btnNoClick.Size = new System.Drawing.Size(800, 33);
            this.btnNoClick.TabIndex = 6;
            this.btnNoClick.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::love.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNoClick);
            this.Controls.Add(this.playerButtonYes);
            this.Controls.Add(this.lbTxt);
            this.Controls.Add(this.playerButtonNo);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lbAsk);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Gửi elm - công chúa nhỏ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerButtonNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerButtonYes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNoClick)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer playerButtonNo;
        private System.Windows.Forms.Label lbTxt;
        private System.Windows.Forms.Label lbAsk;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private AxWMPLib.AxWindowsMediaPlayer playerButtonYes;
        private AxWMPLib.AxWindowsMediaPlayer btnNoClick;
    }
}

