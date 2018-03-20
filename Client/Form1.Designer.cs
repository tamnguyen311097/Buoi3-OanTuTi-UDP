namespace Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelection = new System.Windows.Forms.TextBox();
            this.btnKeo = new System.Windows.Forms.Button();
            this.btnBao = new System.Windows.Forms.Button();
            this.btnBua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Selection";
            // 
            // txtSelection
            // 
            this.txtSelection.Location = new System.Drawing.Point(153, 30);
            this.txtSelection.Name = "txtSelection";
            this.txtSelection.Size = new System.Drawing.Size(211, 22);
            this.txtSelection.TabIndex = 1;
            // 
            // btnKeo
            // 
            this.btnKeo.Location = new System.Drawing.Point(90, 90);
            this.btnKeo.Name = "btnKeo";
            this.btnKeo.Size = new System.Drawing.Size(90, 90);
            this.btnKeo.TabIndex = 2;
            this.btnKeo.Text = "Keo";
            this.btnKeo.UseVisualStyleBackColor = true;
            this.btnKeo.Click += new System.EventHandler(this.btnKeo_Click);
            // 
            // btnBao
            // 
            this.btnBao.Location = new System.Drawing.Point(220, 90);
            this.btnBao.Name = "btnBao";
            this.btnBao.Size = new System.Drawing.Size(90, 90);
            this.btnBao.TabIndex = 3;
            this.btnBao.Text = "Bao";
            this.btnBao.UseVisualStyleBackColor = true;
            this.btnBao.Click += new System.EventHandler(this.btnBao_Click);
            // 
            // btnBua
            // 
            this.btnBua.Location = new System.Drawing.Point(350, 90);
            this.btnBua.Name = "btnBua";
            this.btnBua.Size = new System.Drawing.Size(90, 90);
            this.btnBua.TabIndex = 4;
            this.btnBua.Text = "Bua";
            this.btnBua.UseVisualStyleBackColor = true;
            this.btnBua.Click += new System.EventHandler(this.btnBua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Your Result";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(153, 212);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(211, 22);
            this.txtResult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 295);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBua);
            this.Controls.Add(this.btnBao);
            this.Controls.Add(this.btnKeo);
            this.Controls.Add(this.txtSelection);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSelection;
        private System.Windows.Forms.Button btnKeo;
        private System.Windows.Forms.Button btnBao;
        private System.Windows.Forms.Button btnBua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResult;
    }
}

