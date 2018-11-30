namespace WindowsFormsApp1
{
    partial class chooser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chooser));
            this.finishButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.liquidSugar1 = new WindowsFormsApp1.liquidSugar();
            this.milk1 = new WindowsFormsApp1.milk();
            this.flavor1 = new WindowsFormsApp1.flavor();
            this.SuspendLayout();
            // 
            // finishButton
            // 
            this.finishButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.finishButton.BackColor = System.Drawing.Color.SteelBlue;
            this.finishButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.finishButton.BorderRadius = 5;
            this.finishButton.ButtonText = "Finish";
            this.finishButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finishButton.DisabledColor = System.Drawing.Color.Gray;
            this.finishButton.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishButton.Iconcolor = System.Drawing.Color.Transparent;
            this.finishButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("finishButton.Iconimage")));
            this.finishButton.Iconimage_right = null;
            this.finishButton.Iconimage_right_Selected = null;
            this.finishButton.Iconimage_Selected = null;
            this.finishButton.IconMarginLeft = 0;
            this.finishButton.IconMarginRight = 0;
            this.finishButton.IconRightVisible = false;
            this.finishButton.IconRightZoom = 0D;
            this.finishButton.IconVisible = false;
            this.finishButton.IconZoom = 90D;
            this.finishButton.IsTab = false;
            this.finishButton.Location = new System.Drawing.Point(777, 639);
            this.finishButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.finishButton.Name = "finishButton";
            this.finishButton.Normalcolor = System.Drawing.Color.SteelBlue;
            this.finishButton.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.finishButton.OnHoverTextColor = System.Drawing.Color.White;
            this.finishButton.selected = false;
            this.finishButton.Size = new System.Drawing.Size(269, 51);
            this.finishButton.TabIndex = 5;
            this.finishButton.Text = "Finish";
            this.finishButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.finishButton.Textcolor = System.Drawing.Color.White;
            this.finishButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(205, 11);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(317, 86);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "Coffee Bar";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(25, 11);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(187, 86);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "DATA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Flavor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(467, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "Milk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(655, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "Liquid Sugar";
            // 
            // liquidSugar1
            // 
            this.liquidSugar1.Location = new System.Drawing.Point(641, 271);
            this.liquidSugar1.Name = "liquidSugar1";
            this.liquidSugar1.Size = new System.Drawing.Size(201, 239);
            this.liquidSugar1.TabIndex = 23;
            // 
            // milk1
            // 
            this.milk1.Location = new System.Drawing.Point(406, 271);
            this.milk1.Name = "milk1";
            this.milk1.Size = new System.Drawing.Size(203, 242);
            this.milk1.TabIndex = 22;
            // 
            // flavor1
            // 
            this.flavor1.Location = new System.Drawing.Point(147, 248);
            this.flavor1.Name = "flavor1";
            this.flavor1.Size = new System.Drawing.Size(244, 282);
            this.flavor1.TabIndex = 21;
            // 
            // chooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.liquidSugar1);
            this.Controls.Add(this.milk1);
            this.Controls.Add(this.flavor1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Name = "chooser";
            this.Size = new System.Drawing.Size(1080, 720);
            this.Load += new System.EventHandler(this.chooser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public Bunifu.Framework.UI.BunifuFlatButton finishButton;
        private flavor flavor1;
        private milk milk1;
        private liquidSugar liquidSugar1;
    }
}
