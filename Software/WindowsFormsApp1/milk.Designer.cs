namespace WindowsFormsApp1
{
    partial class milk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(milk));
            this.m_n = new Bunifu.Framework.UI.BunifuFlatButton();
            this.m_t = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // m_n
            // 
            this.m_n.Activecolor = System.Drawing.Color.SteelBlue;
            this.m_n.BackColor = System.Drawing.Color.SteelBlue;
            this.m_n.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.m_n.BorderRadius = 5;
            this.m_n.ButtonText = "None";
            this.m_n.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_n.DisabledColor = System.Drawing.Color.Gray;
            this.m_n.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_n.Iconcolor = System.Drawing.Color.Transparent;
            this.m_n.Iconimage = ((System.Drawing.Image)(resources.GetObject("m_n.Iconimage")));
            this.m_n.Iconimage_right = null;
            this.m_n.Iconimage_right_Selected = null;
            this.m_n.Iconimage_Selected = null;
            this.m_n.IconMarginLeft = 0;
            this.m_n.IconMarginRight = 0;
            this.m_n.IconRightVisible = false;
            this.m_n.IconRightZoom = 0D;
            this.m_n.IconVisible = false;
            this.m_n.IconZoom = 90D;
            this.m_n.IsTab = true;
            this.m_n.Location = new System.Drawing.Point(14, 67);
            this.m_n.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.m_n.Name = "m_n";
            this.m_n.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m_n.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.m_n.OnHoverTextColor = System.Drawing.Color.White;
            this.m_n.selected = true;
            this.m_n.Size = new System.Drawing.Size(174, 43);
            this.m_n.TabIndex = 20;
            this.m_n.Text = "None";
            this.m_n.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_n.Textcolor = System.Drawing.Color.Black;
            this.m_n.TextFont = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // m_t
            // 
            this.m_t.Activecolor = System.Drawing.Color.SteelBlue;
            this.m_t.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m_t.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.m_t.BorderRadius = 5;
            this.m_t.ButtonText = "1oz";
            this.m_t.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_t.DisabledColor = System.Drawing.Color.Gray;
            this.m_t.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_t.Iconcolor = System.Drawing.Color.Transparent;
            this.m_t.Iconimage = ((System.Drawing.Image)(resources.GetObject("m_t.Iconimage")));
            this.m_t.Iconimage_right = null;
            this.m_t.Iconimage_right_Selected = null;
            this.m_t.Iconimage_Selected = null;
            this.m_t.IconMarginLeft = 0;
            this.m_t.IconMarginRight = 0;
            this.m_t.IconRightVisible = false;
            this.m_t.IconRightZoom = 0D;
            this.m_t.IconVisible = false;
            this.m_t.IconZoom = 90D;
            this.m_t.IsTab = true;
            this.m_t.Location = new System.Drawing.Point(14, 8);
            this.m_t.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.m_t.Name = "m_t";
            this.m_t.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m_t.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.m_t.OnHoverTextColor = System.Drawing.Color.White;
            this.m_t.selected = false;
            this.m_t.Size = new System.Drawing.Size(174, 43);
            this.m_t.TabIndex = 17;
            this.m_t.Text = "1oz";
            this.m_t.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_t.Textcolor = System.Drawing.Color.Black;
            this.m_t.TextFont = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // milk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_n);
            this.Controls.Add(this.m_t);
            this.Name = "milk";
            this.Size = new System.Drawing.Size(203, 242);
            this.Load += new System.EventHandler(this.milk_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuFlatButton m_n;
        public Bunifu.Framework.UI.BunifuFlatButton m_t;
    }
}
