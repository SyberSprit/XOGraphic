namespace XOGraphic
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
            this.xO_Template1 = new XOGraphic.XO_Template();
            this.submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtO = new System.Windows.Forms.TextBox();
            this.TxtX = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // xO_Template1
            // 
            this.xO_Template1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xO_Template1.Location = new System.Drawing.Point(0, 0);
            this.xO_Template1.Name = "xO_Template1";
            this.xO_Template1.Size = new System.Drawing.Size(597, 632);
            this.xO_Template1.TabIndex = 0;
            this.xO_Template1.Visible = false;
            this.xO_Template1.Load += new System.EventHandler(this.xO_Template1_Load);
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(133, 561);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(396, 71);
            this.submit.TabIndex = 1;
            this.submit.Text = "Play !";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name of player X :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name of player O :";
            // 
            // TxtO
            // 
            this.TxtO.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtO.Location = new System.Drawing.Point(338, 194);
            this.TxtO.Name = "TxtO";
            this.TxtO.Size = new System.Drawing.Size(225, 45);
            this.TxtO.TabIndex = 4;
            // 
            // TxtX
            // 
            this.TxtX.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtX.Location = new System.Drawing.Point(341, 419);
            this.TxtX.Name = "TxtX";
            this.TxtX.Size = new System.Drawing.Size(225, 45);
            this.TxtX.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 632);
            this.Controls.Add(this.TxtX);
            this.Controls.Add(this.TxtO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.xO_Template1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XO_Template xO_Template1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtO;
        private System.Windows.Forms.TextBox TxtX;
    }
}

