namespace Editeur_Objets
{
    partial class frmGroundEditor
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
            this.picPic = new System.Windows.Forms.PictureBox();
            this.scrlPic = new System.Windows.Forms.HScrollBar();
            this.chkBlocking = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPic)).BeginInit();
            this.SuspendLayout();
            // 
            // picPic
            // 
            this.picPic.BackColor = System.Drawing.Color.Black;
            this.picPic.Location = new System.Drawing.Point(9, 56);
            this.picPic.Name = "picPic";
            this.picPic.Size = new System.Drawing.Size(32, 32);
            this.picPic.TabIndex = 0;
            this.picPic.TabStop = false;
            // 
            // scrlPic
            // 
            this.scrlPic.LargeChange = 1;
            this.scrlPic.Location = new System.Drawing.Point(9, 100);
            this.scrlPic.Name = "scrlPic";
            this.scrlPic.Size = new System.Drawing.Size(306, 17);
            this.scrlPic.TabIndex = 1;
            this.scrlPic.ValueChanged += new System.EventHandler(this.scrlPic_ValueChanged);
            // 
            // chkBlocking
            // 
            this.chkBlocking.AutoSize = true;
            this.chkBlocking.Location = new System.Drawing.Point(12, 139);
            this.chkBlocking.Name = "chkBlocking";
            this.chkBlocking.Size = new System.Drawing.Size(68, 17);
            this.chkBlocking.TabIndex = 2;
            this.chkBlocking.Text = "Bloquant";
            this.chkBlocking.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sauvegarder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(50, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(262, 20);
            this.txtName.TabIndex = 5;
            // 
            // frmGroundEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 218);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkBlocking);
            this.Controls.Add(this.scrlPic);
            this.Controls.Add(this.picPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGroundEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editeur de sol";
            this.Load += new System.EventHandler(this.frmGroundEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPic;
        private System.Windows.Forms.HScrollBar scrlPic;
        private System.Windows.Forms.CheckBox chkBlocking;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
    }
}