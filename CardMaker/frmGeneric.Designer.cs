namespace CardMaker
{
    partial class frmGeneric
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
            this.components = new System.ComponentModel.Container();
            this.txtCardTitle = new System.Windows.Forms.TextBox();
            this.pbCardImage = new System.Windows.Forms.PictureBox();
            this.txtCardText = new System.Windows.Forms.TextBox();
            this.cmsRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shrinkBodyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.growBodyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shrinkTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.growTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.txtFortune = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardImage)).BeginInit();
            this.cmsRightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCardTitle
            // 
            this.txtCardTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardTitle.Location = new System.Drawing.Point(13, 13);
            this.txtCardTitle.Name = "txtCardTitle";
            this.txtCardTitle.Size = new System.Drawing.Size(168, 23);
            this.txtCardTitle.TabIndex = 0;
            this.txtCardTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCardTitle_KeyDown);
            // 
            // pbCardImage
            // 
            this.pbCardImage.Location = new System.Drawing.Point(13, 39);
            this.pbCardImage.Name = "pbCardImage";
            this.pbCardImage.Size = new System.Drawing.Size(190, 142);
            this.pbCardImage.TabIndex = 1;
            this.pbCardImage.TabStop = false;
            this.pbCardImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbCardImage_MouseClick);
            // 
            // txtCardText
            // 
            this.txtCardText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardText.Location = new System.Drawing.Point(180, 264);
            this.txtCardText.Multiline = true;
            this.txtCardText.Name = "txtCardText";
            this.txtCardText.Size = new System.Drawing.Size(23, 16);
            this.txtCardText.TabIndex = 20;
            // 
            // cmsRightClick
            // 
            this.cmsRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.borderToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.cmsRightClick.Name = "cmsRightClick";
            this.cmsRightClick.Size = new System.Drawing.Size(117, 92);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.imageToolStripMenuItem.Text = "Image...";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // borderToolStripMenuItem
            // 
            this.borderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackToolStripMenuItem,
            this.whiteToolStripMenuItem,
            this.greyToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.redToolStripMenuItem,
            this.yellowToolStripMenuItem,
            this.orangeToolStripMenuItem,
            this.purpleToolStripMenuItem,
            this.greenToolStripMenuItem});
            this.borderToolStripMenuItem.Name = "borderToolStripMenuItem";
            this.borderToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.borderToolStripMenuItem.Text = "Border";
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.blackToolStripMenuItem.Text = "Black";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.whiteToolStripMenuItem.Text = "White";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
            // 
            // greyToolStripMenuItem
            // 
            this.greyToolStripMenuItem.Name = "greyToolStripMenuItem";
            this.greyToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.greyToolStripMenuItem.Text = "Grey";
            this.greyToolStripMenuItem.Click += new System.EventHandler(this.greyToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.yellowToolStripMenuItem.Text = "Yellow";
            this.yellowToolStripMenuItem.Click += new System.EventHandler(this.yellowToolStripMenuItem_Click);
            // 
            // orangeToolStripMenuItem
            // 
            this.orangeToolStripMenuItem.Name = "orangeToolStripMenuItem";
            this.orangeToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.orangeToolStripMenuItem.Text = "Orange";
            this.orangeToolStripMenuItem.Click += new System.EventHandler(this.orangeToolStripMenuItem_Click);
            // 
            // purpleToolStripMenuItem
            // 
            this.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            this.purpleToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.purpleToolStripMenuItem.Text = "Purple";
            this.purpleToolStripMenuItem.Click += new System.EventHandler(this.purpleToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shrinkBodyToolStripMenuItem,
            this.growBodyToolStripMenuItem,
            this.shrinkTitleToolStripMenuItem,
            this.growTitleToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // shrinkBodyToolStripMenuItem
            // 
            this.shrinkBodyToolStripMenuItem.Name = "shrinkBodyToolStripMenuItem";
            this.shrinkBodyToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.shrinkBodyToolStripMenuItem.Text = "Shrink Body";
            this.shrinkBodyToolStripMenuItem.Click += new System.EventHandler(this.shrinkBodyToolStripMenuItem_Click);
            // 
            // growBodyToolStripMenuItem
            // 
            this.growBodyToolStripMenuItem.Name = "growBodyToolStripMenuItem";
            this.growBodyToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.growBodyToolStripMenuItem.Text = "Grow Body";
            this.growBodyToolStripMenuItem.Click += new System.EventHandler(this.growBodyToolStripMenuItem_Click);
            // 
            // shrinkTitleToolStripMenuItem
            // 
            this.shrinkTitleToolStripMenuItem.Name = "shrinkTitleToolStripMenuItem";
            this.shrinkTitleToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.shrinkTitleToolStripMenuItem.Text = "Shrink Title";
            this.shrinkTitleToolStripMenuItem.Click += new System.EventHandler(this.shrinkTitleToolStripMenuItem_Click);
            // 
            // growTitleToolStripMenuItem
            // 
            this.growTitleToolStripMenuItem.Name = "growTitleToolStripMenuItem";
            this.growTitleToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.growTitleToolStripMenuItem.Text = "Grow Title";
            this.growTitleToolStripMenuItem.Click += new System.EventHandler(this.growTitleToolStripMenuItem_Click);
            // 
            // ofdImage
            // 
            this.ofdImage.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdImage_FileOk);
            // 
            // txtFortune
            // 
            this.txtFortune.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFortune.Location = new System.Drawing.Point(187, 13);
            this.txtFortune.Name = "txtFortune";
            this.txtFortune.Size = new System.Drawing.Size(16, 23);
            this.txtFortune.TabIndex = 1;
            this.txtFortune.Text = "0";
            this.txtFortune.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(13, 187);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(20, 21);
            this.txtType.TabIndex = 22;
            this.txtType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmGeneric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 292);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtFortune);
            this.Controls.Add(this.txtCardText);
            this.Controls.Add(this.pbCardImage);
            this.Controls.Add(this.txtCardTitle);
            this.Name = "frmGeneric";
            this.Text = "Card Maker";
            this.Load += new System.EventHandler(this.frmCardMaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCardImage)).EndInit();
            this.cmsRightClick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCardTitle;
        private System.Windows.Forms.PictureBox pbCardImage;
        private System.Windows.Forms.TextBox txtCardText;
        private System.Windows.Forms.ContextMenuStrip cmsRightClick;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.ToolStripMenuItem borderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shrinkBodyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem growBodyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shrinkTitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem growTitleToolStripMenuItem;
        private System.Windows.Forms.TextBox txtFortune;
        private System.Windows.Forms.TextBox txtType;
    }
}

