
namespace Streamable_Account_Checker
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
            this.button_LoadCombo = new System.Windows.Forms.Button();
            this.button_LoadProxy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Socks5 = new System.Windows.Forms.RadioButton();
            this.radioButton_Socks4 = new System.Windows.Forms.RadioButton();
            this.radioButton_HTTP = new System.Windows.Forms.RadioButton();
            this.textBox_Results = new System.Windows.Forms.TextBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_TotalCombo = new System.Windows.Forms.Label();
            this.label_TotalProxy = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Success = new System.Windows.Forms.Label();
            this.label_Fail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_ProxyError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_LoadCombo
            // 
            this.button_LoadCombo.Location = new System.Drawing.Point(12, 35);
            this.button_LoadCombo.Name = "button_LoadCombo";
            this.button_LoadCombo.Size = new System.Drawing.Size(152, 58);
            this.button_LoadCombo.TabIndex = 0;
            this.button_LoadCombo.Text = "Load Combo";
            this.button_LoadCombo.UseVisualStyleBackColor = true;
            this.button_LoadCombo.Click += new System.EventHandler(this.button_LoadCombo_Click);
            // 
            // button_LoadProxy
            // 
            this.button_LoadProxy.Location = new System.Drawing.Point(12, 117);
            this.button_LoadProxy.Name = "button_LoadProxy";
            this.button_LoadProxy.Size = new System.Drawing.Size(152, 58);
            this.button_LoadProxy.TabIndex = 1;
            this.button_LoadProxy.Text = "Load Proxy";
            this.button_LoadProxy.UseVisualStyleBackColor = true;
            this.button_LoadProxy.Click += new System.EventHandler(this.button_LoadProxy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Socks5);
            this.groupBox1.Controls.Add(this.radioButton_Socks4);
            this.groupBox1.Controls.Add(this.radioButton_HTTP);
            this.groupBox1.Location = new System.Drawing.Point(12, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 152);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proxy Type";
            // 
            // radioButton_Socks5
            // 
            this.radioButton_Socks5.AutoSize = true;
            this.radioButton_Socks5.Location = new System.Drawing.Point(12, 101);
            this.radioButton_Socks5.Name = "radioButton_Socks5";
            this.radioButton_Socks5.Size = new System.Drawing.Size(79, 21);
            this.radioButton_Socks5.TabIndex = 2;
            this.radioButton_Socks5.TabStop = true;
            this.radioButton_Socks5.Text = "Socks 5";
            this.radioButton_Socks5.UseVisualStyleBackColor = true;
            // 
            // radioButton_Socks4
            // 
            this.radioButton_Socks4.AutoSize = true;
            this.radioButton_Socks4.Location = new System.Drawing.Point(12, 69);
            this.radioButton_Socks4.Name = "radioButton_Socks4";
            this.radioButton_Socks4.Size = new System.Drawing.Size(79, 21);
            this.radioButton_Socks4.TabIndex = 1;
            this.radioButton_Socks4.TabStop = true;
            this.radioButton_Socks4.Text = "Socks 4";
            this.radioButton_Socks4.UseVisualStyleBackColor = true;
            // 
            // radioButton_HTTP
            // 
            this.radioButton_HTTP.AutoSize = true;
            this.radioButton_HTTP.Location = new System.Drawing.Point(12, 37);
            this.radioButton_HTTP.Name = "radioButton_HTTP";
            this.radioButton_HTTP.Size = new System.Drawing.Size(79, 21);
            this.radioButton_HTTP.TabIndex = 0;
            this.radioButton_HTTP.TabStop = true;
            this.radioButton_HTTP.Text = "HTTP/S";
            this.radioButton_HTTP.UseVisualStyleBackColor = true;
            // 
            // textBox_Results
            // 
            this.textBox_Results.Location = new System.Drawing.Point(220, 35);
            this.textBox_Results.Multiline = true;
            this.textBox_Results.Name = "textBox_Results";
            this.textBox_Results.Size = new System.Drawing.Size(520, 311);
            this.textBox_Results.TabIndex = 3;
            this.textBox_Results.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(18, 393);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(146, 66);
            this.button_Start.TabIndex = 4;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Combo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Proxy";
            // 
            // label_TotalCombo
            // 
            this.label_TotalCombo.AutoSize = true;
            this.label_TotalCombo.Location = new System.Drawing.Point(329, 393);
            this.label_TotalCombo.Name = "label_TotalCombo";
            this.label_TotalCombo.Size = new System.Drawing.Size(16, 17);
            this.label_TotalCombo.TabIndex = 7;
            this.label_TotalCombo.Text = "0";
            // 
            // label_TotalProxy
            // 
            this.label_TotalProxy.AutoSize = true;
            this.label_TotalProxy.Location = new System.Drawing.Point(329, 442);
            this.label_TotalProxy.Name = "label_TotalProxy";
            this.label_TotalProxy.Size = new System.Drawing.Size(16, 17);
            this.label_TotalProxy.TabIndex = 8;
            this.label_TotalProxy.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Success";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fail";
            // 
            // label_Success
            // 
            this.label_Success.AutoSize = true;
            this.label_Success.Location = new System.Drawing.Point(484, 393);
            this.label_Success.Name = "label_Success";
            this.label_Success.Size = new System.Drawing.Size(16, 17);
            this.label_Success.TabIndex = 11;
            this.label_Success.Text = "0";
            // 
            // label_Fail
            // 
            this.label_Fail.AutoSize = true;
            this.label_Fail.Location = new System.Drawing.Point(484, 442);
            this.label_Fail.Name = "label_Fail";
            this.label_Fail.Size = new System.Drawing.Size(16, 17);
            this.label_Fail.TabIndex = 12;
            this.label_Fail.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(555, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Proxy Error";
            // 
            // label_ProxyError
            // 
            this.label_ProxyError.AutoSize = true;
            this.label_ProxyError.Location = new System.Drawing.Point(653, 442);
            this.label_ProxyError.Name = "label_ProxyError";
            this.label_ProxyError.Size = new System.Drawing.Size(16, 17);
            this.label_ProxyError.TabIndex = 14;
            this.label_ProxyError.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 484);
            this.Controls.Add(this.label_ProxyError);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_Fail);
            this.Controls.Add(this.label_Success);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_TotalProxy);
            this.Controls.Add(this.label_TotalCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.textBox_Results);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_LoadProxy);
            this.Controls.Add(this.button_LoadCombo);
            this.Name = "Form1";
            this.Text = "Streamable Account Checker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_LoadCombo;
        private System.Windows.Forms.Button button_LoadProxy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Socks5;
        private System.Windows.Forms.RadioButton radioButton_Socks4;
        private System.Windows.Forms.RadioButton radioButton_HTTP;
        private System.Windows.Forms.TextBox textBox_Results;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_TotalCombo;
        private System.Windows.Forms.Label label_TotalProxy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Success;
        private System.Windows.Forms.Label label_Fail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_ProxyError;
    }
}

