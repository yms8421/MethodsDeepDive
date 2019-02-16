namespace BilgeAdam.Exceptionhandling
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
            this.btntry = new System.Windows.Forms.Button();
            this.btnNullRef = new System.Windows.Forms.Button();
            this.btnInvalidCast = new System.Windows.Forms.Button();
            this.btnFormat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btntry
            // 
            this.btntry.Location = new System.Drawing.Point(35, 33);
            this.btntry.Name = "btntry";
            this.btntry.Size = new System.Drawing.Size(75, 23);
            this.btntry.TabIndex = 0;
            this.btntry.Text = "Dene";
            this.btntry.UseVisualStyleBackColor = true;
            this.btntry.Click += new System.EventHandler(this.btntry_Click);
            // 
            // btnNullRef
            // 
            this.btnNullRef.Location = new System.Drawing.Point(248, 32);
            this.btnNullRef.Name = "btnNullRef";
            this.btnNullRef.Size = new System.Drawing.Size(146, 23);
            this.btnNullRef.TabIndex = 1;
            this.btnNullRef.Text = "Null Reference";
            this.btnNullRef.UseVisualStyleBackColor = true;
            this.btnNullRef.Click += new System.EventHandler(this.btnNullRef_Click);
            // 
            // btnInvalidCast
            // 
            this.btnInvalidCast.Location = new System.Drawing.Point(248, 62);
            this.btnInvalidCast.Name = "btnInvalidCast";
            this.btnInvalidCast.Size = new System.Drawing.Size(146, 23);
            this.btnInvalidCast.TabIndex = 2;
            this.btnInvalidCast.Text = "Invalid Cast";
            this.btnInvalidCast.UseVisualStyleBackColor = true;
            this.btnInvalidCast.Click += new System.EventHandler(this.btnInvalidCast_Click);
            // 
            // btnFormat
            // 
            this.btnFormat.Location = new System.Drawing.Point(248, 92);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(146, 23);
            this.btnFormat.TabIndex = 3;
            this.btnFormat.Text = "Format Exception";
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 433);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.btnInvalidCast);
            this.Controls.Add(this.btnNullRef);
            this.Controls.Add(this.btntry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btntry;
        private System.Windows.Forms.Button btnNullRef;
        private System.Windows.Forms.Button btnInvalidCast;
        private System.Windows.Forms.Button btnFormat;
    }
}

