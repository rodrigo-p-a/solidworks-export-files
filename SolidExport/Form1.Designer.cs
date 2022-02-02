namespace SolidExport
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtPasta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutDir = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(659, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPasta
            // 
            this.txtPasta.Location = new System.Drawing.Point(13, 43);
            this.txtPasta.Name = "txtPasta";
            this.txtPasta.Size = new System.Drawing.Size(303, 20);
            this.txtPasta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pasta de documentos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pasta de saída ( onde os arquivos serão salvos):";
            // 
            // txtOutDir
            // 
            this.txtOutDir.Location = new System.Drawing.Point(13, 90);
            this.txtOutDir.Name = "txtOutDir";
            this.txtOutDir.Size = new System.Drawing.Size(303, 20);
            this.txtOutDir.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(323, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(323, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(16, 130);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(772, 308);
            this.txtLog.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOutDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPasta);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "SolidWorks Export - PDF / DWG / STEP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutDir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtLog;
    }
}

