namespace AuctionSystem
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
            this.priceLbl = new System.Windows.Forms.Label();
            this.bitBtn1 = new System.Windows.Forms.Button();
            this.lostUpdatesSimBtn = new System.Windows.Forms.Button();
            this.bitBtnBoth = new System.Windows.Forms.Button();
            this.resetbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.Location = new System.Drawing.Point(501, 157);
            this.priceLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(124, 26);
            this.priceLbl.TabIndex = 0;
            this.priceLbl.Text = "placeholder";
            // 
            // bitBtn1
            // 
            this.bitBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitBtn1.Location = new System.Drawing.Point(87, 86);
            this.bitBtn1.Margin = new System.Windows.Forms.Padding(2);
            this.bitBtn1.Name = "bitBtn1";
            this.bitBtn1.Size = new System.Drawing.Size(185, 31);
            this.bitBtn1.TabIndex = 1;
            this.bitBtn1.Text = "Manuel Bud";
            this.bitBtn1.UseVisualStyleBackColor = true;
            this.bitBtn1.Click += new System.EventHandler(this.bitBtn1_Click);
            // 
            // lostUpdatesSimBtn
            // 
            this.lostUpdatesSimBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lostUpdatesSimBtn.Location = new System.Drawing.Point(87, 137);
            this.lostUpdatesSimBtn.Margin = new System.Windows.Forms.Padding(2);
            this.lostUpdatesSimBtn.Name = "lostUpdatesSimBtn";
            this.lostUpdatesSimBtn.Size = new System.Drawing.Size(185, 31);
            this.lostUpdatesSimBtn.TabIndex = 2;
            this.lostUpdatesSimBtn.Text = "Lost updates sim";
            this.lostUpdatesSimBtn.UseVisualStyleBackColor = true;
            this.lostUpdatesSimBtn.Click += new System.EventHandler(this.lostUpdatesSimBtn_Click);
            // 
            // bitBtnBoth
            // 
            this.bitBtnBoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitBtnBoth.Location = new System.Drawing.Point(87, 187);
            this.bitBtnBoth.Margin = new System.Windows.Forms.Padding(2);
            this.bitBtnBoth.Name = "bitBtnBoth";
            this.bitBtnBoth.Size = new System.Drawing.Size(185, 31);
            this.bitBtnBoth.TabIndex = 3;
            this.bitBtnBoth.Text = "Simulation";
            this.bitBtnBoth.UseVisualStyleBackColor = true;
            this.bitBtnBoth.Click += new System.EventHandler(this.bitBtnBoth_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbtn.Location = new System.Drawing.Point(87, 238);
            this.resetbtn.Margin = new System.Windows.Forms.Padding(2);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(185, 31);
            this.resetbtn.TabIndex = 4;
            this.resetbtn.Text = "Reset";
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 340);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.bitBtnBoth);
            this.Controls.Add(this.lostUpdatesSimBtn);
            this.Controls.Add(this.bitBtn1);
            this.Controls.Add(this.priceLbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Button bitBtn1;
        private System.Windows.Forms.Button lostUpdatesSimBtn;
        private System.Windows.Forms.Button bitBtnBoth;
        private System.Windows.Forms.Button resetbtn;
    }
}

