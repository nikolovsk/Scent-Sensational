namespace Scent_Sensation
{
    partial class Male_Perfumes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPerfumesList = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Машки парфеми";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(470, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Погледнете ја листата со популарни машки парфеми!";
            // 
            // lbPerfumesList
            // 
            this.lbPerfumesList.AutoSize = true;
            this.lbPerfumesList.Location = new System.Drawing.Point(312, 177);
            this.lbPerfumesList.Name = "lbPerfumesList";
            this.lbPerfumesList.Size = new System.Drawing.Size(10, 16);
            this.lbPerfumesList.TabIndex = 2;
            this.lbPerfumesList.Text = " ";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(653, 495);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(200, 23);
            this.btnAddToCart.TabIndex = 5;
            this.btnAddToCart.Text = "Додади во кошничка";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // Male_Perfumes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 551);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lbPerfumesList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Male_Perfumes";
            this.Text = "Male_Perfumes";
            this.Load += new System.EventHandler(this.Male_Perfumes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPerfumesList;
        private System.Windows.Forms.Button btnAddToCart;
    }
}