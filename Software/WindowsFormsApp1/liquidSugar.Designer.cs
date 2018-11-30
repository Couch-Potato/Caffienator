namespace WindowsFormsApp1
{
    partial class liquidSugar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(liquidSugar));
            this.s_n = new Bunifu.Framework.UI.BunifuFlatButton();
            this.s_o = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // s_n
            // 
            this.s_n.Activecolor = System.Drawing.Color.SteelBlue;
            this.s_n.BackColor = System.Drawing.Color.SteelBlue;
            this.s_n.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.s_n.BorderRadius = 5;
            this.s_n.ButtonText = "None";
            this.s_n.Cursor = System.Windows.Forms.Cursors.Hand;
            this.s_n.DisabledColor = System.Drawing.Color.Gray;
            this.s_n.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_n.Iconcolor = System.Drawing.Color.Transparent;
            this.s_n.Iconimage = ((System.Drawing.Image)(resources.GetObject("s_n.Iconimage")));
            this.s_n.Iconimage_right = null;
            this.s_n.Iconimage_right_Selected = null;
            this.s_n.Iconimage_Selected = null;
            this.s_n.IconMarginLeft = 0;
            this.s_n.IconMarginRight = 0;
            this.s_n.IconRightVisible = false;
            this.s_n.IconRightZoom = 0D;
            this.s_n.IconVisible = false;
            this.s_n.IconZoom = 90D;
            this.s_n.IsTab = true;
            this.s_n.Location = new System.Drawing.Point(14, 67);
            this.s_n.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.s_n.Name = "s_n";
            this.s_n.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.s_n.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.s_n.OnHoverTextColor = System.Drawing.Color.White;
            this.s_n.selected = true;
            this.s_n.Size = new System.Drawing.Size(174, 43);
            this.s_n.TabIndex = 24;
            this.s_n.Text = "None";
            this.s_n.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.s_n.Textcolor = System.Drawing.Color.Black;
            this.s_n.TextFont = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // s_o
            // 
            this.s_o.Activecolor = System.Drawing.Color.SteelBlue;
            this.s_o.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.s_o.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.s_o.BorderRadius = 5;
            this.s_o.ButtonText = "1oz";
            this.s_o.Cursor = System.Windows.Forms.Cursors.Hand;
            this.s_o.DisabledColor = System.Drawing.Color.Gray;
            this.s_o.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_o.Iconcolor = System.Drawing.Color.Transparent;
            this.s_o.Iconimage = ((System.Drawing.Image)(resources.GetObject("s_o.Iconimage")));
            this.s_o.Iconimage_right = null;
            this.s_o.Iconimage_right_Selected = null;
            this.s_o.Iconimage_Selected = null;
            this.s_o.IconMarginLeft = 0;
            this.s_o.IconMarginRight = 0;
            this.s_o.IconRightVisible = false;
            this.s_o.IconRightZoom = 0D;
            this.s_o.IconVisible = false;
            this.s_o.IconZoom = 90D;
            this.s_o.IsTab = true;
            this.s_o.Location = new System.Drawing.Point(14, 8);
            this.s_o.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.s_o.Name = "s_o";
            this.s_o.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.s_o.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.s_o.OnHoverTextColor = System.Drawing.Color.White;
            this.s_o.selected = false;
            this.s_o.Size = new System.Drawing.Size(174, 43);
            this.s_o.TabIndex = 21;
            this.s_o.Text = "1oz";
            this.s_o.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.s_o.Textcolor = System.Drawing.Color.Black;
            this.s_o.TextFont = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // liquidSugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.s_n);
            this.Controls.Add(this.s_o);
            this.Name = "liquidSugar";
            this.Size = new System.Drawing.Size(201, 239);
            this.Load += new System.EventHandler(this.liquidSugar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuFlatButton s_n;
        public Bunifu.Framework.UI.BunifuFlatButton s_o;
    }
}
