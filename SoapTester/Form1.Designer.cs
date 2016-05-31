namespace SoapTester
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
            this.SoapActionLable = new System.Windows.Forms.Label();
            this.soapAction = new System.Windows.Forms.TextBox();
            this.SoapLable = new System.Windows.Forms.Label();
            this.soap = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SoapActionLable
            // 
            this.SoapActionLable.AutoSize = true;
            this.SoapActionLable.Location = new System.Drawing.Point(13, 51);
            this.SoapActionLable.Name = "SoapActionLable";
            this.SoapActionLable.Size = new System.Drawing.Size(65, 12);
            this.SoapActionLable.TabIndex = 0;
            this.SoapActionLable.Text = "SoapAction";
            // 
            // soapAction
            // 
            this.soapAction.Location = new System.Drawing.Point(84, 48);
            this.soapAction.Name = "soapAction";
            this.soapAction.Size = new System.Drawing.Size(423, 21);
            this.soapAction.TabIndex = 2;
            // 
            // SoapLable
            // 
            this.SoapLable.AutoSize = true;
            this.SoapLable.Location = new System.Drawing.Point(15, 84);
            this.SoapLable.Name = "SoapLable";
            this.SoapLable.Size = new System.Drawing.Size(29, 12);
            this.SoapLable.TabIndex = 2;
            this.SoapLable.Text = "Soap";
            // 
            // soap
            // 
            this.soap.AcceptsReturn = true;
            this.soap.Location = new System.Drawing.Point(84, 84);
            this.soap.Multiline = true;
            this.soap.Name = "soap";
            this.soap.Size = new System.Drawing.Size(423, 177);
            this.soap.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Url";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(83, 12);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(423, 21);
            this.address.TabIndex = 1;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(85, 317);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(422, 160);
            this.resultTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 504);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.soap);
            this.Controls.Add(this.SoapLable);
            this.Controls.Add(this.soapAction);
            this.Controls.Add(this.SoapActionLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SoapTester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SoapActionLable;
        private System.Windows.Forms.TextBox soapAction;
        private System.Windows.Forms.Label SoapLable;
        private System.Windows.Forms.TextBox soap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label2;
    }
}

