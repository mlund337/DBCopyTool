
namespace DBCopyTool
{
    partial class FormStart
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSendToSlack = new System.Windows.Forms.Button();
            this.textBoxIncNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxWebEx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOpenRemote = new System.Windows.Forms.Button();
            this.textBoxCloudText = new System.Windows.Forms.TextBox();
            this.buttonUpdateCloudText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(47, 99);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Start Incident Timer";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(328, 99);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(151, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Start WebEx Recording";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(47, 360);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(173, 20);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Message in #cloudops";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // textBoxServer
            // 
            this.textBoxServer.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxServer.Location = new System.Drawing.Point(39, 163);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(225, 21);
            this.textBoxServer.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter server:";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(47, 190);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(86, 20);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Production";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(130, 190);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(47, 20);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.Text = "Test";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(183, 190);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(102, 20);
            this.checkBox6.TabIndex = 7;
            this.checkBox6.Text = "Development";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCompany.Location = new System.Drawing.Point(39, 292);
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.Size = new System.Drawing.Size(225, 21);
            this.textBoxCompany.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter Company:";
            // 
            // buttonSendToSlack
            // 
            this.buttonSendToSlack.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendToSlack.Location = new System.Drawing.Point(167, 452);
            this.buttonSendToSlack.Name = "buttonSendToSlack";
            this.buttonSendToSlack.Size = new System.Drawing.Size(97, 23);
            this.buttonSendToSlack.TabIndex = 10;
            this.buttonSendToSlack.Text = "Send to Slack";
            this.buttonSendToSlack.UseVisualStyleBackColor = true;
            // 
            // textBoxIncNum
            // 
            this.textBoxIncNum.Location = new System.Drawing.Point(39, 73);
            this.textBoxIncNum.Name = "textBoxIncNum";
            this.textBoxIncNum.Size = new System.Drawing.Size(225, 20);
            this.textBoxIncNum.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Incident Number";
            // 
            // textBoxWebEx
            // 
            this.textBoxWebEx.Location = new System.Drawing.Point(320, 73);
            this.textBoxWebEx.Name = "textBoxWebEx";
            this.textBoxWebEx.Size = new System.Drawing.Size(225, 20);
            this.textBoxWebEx.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "WebEx User";
            // 
            // buttonOpenRemote
            // 
            this.buttonOpenRemote.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenRemote.Location = new System.Drawing.Point(39, 216);
            this.buttonOpenRemote.Name = "buttonOpenRemote";
            this.buttonOpenRemote.Size = new System.Drawing.Size(97, 23);
            this.buttonOpenRemote.TabIndex = 15;
            this.buttonOpenRemote.Text = "Open Remote";
            this.buttonOpenRemote.UseVisualStyleBackColor = true;
            // 
            // textBoxCloudText
            // 
            this.textBoxCloudText.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCloudText.Location = new System.Drawing.Point(35, 386);
            this.textBoxCloudText.Multiline = true;
            this.textBoxCloudText.Name = "textBoxCloudText";
            this.textBoxCloudText.Size = new System.Drawing.Size(229, 60);
            this.textBoxCloudText.TabIndex = 16;
            this.textBoxCloudText.Text = "Working on <SERVERNAME> <Prod, Dev, Test>  for <COMPANYNAME>, <INCIDENTNUMBER>";
            // 
            // buttonUpdateCloudText
            // 
            this.buttonUpdateCloudText.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateCloudText.Location = new System.Drawing.Point(35, 452);
            this.buttonUpdateCloudText.Name = "buttonUpdateCloudText";
            this.buttonUpdateCloudText.Size = new System.Drawing.Size(97, 23);
            this.buttonUpdateCloudText.TabIndex = 17;
            this.buttonUpdateCloudText.Text = "Update";
            this.buttonUpdateCloudText.UseVisualStyleBackColor = true;
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 638);
            this.Controls.Add(this.buttonUpdateCloudText);
            this.Controls.Add(this.textBoxCloudText);
            this.Controls.Add(this.buttonOpenRemote);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxWebEx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxIncNum);
            this.Controls.Add(this.buttonSendToSlack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCompany);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxServer);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "FormStart";
            this.Text = "1 - Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSendToSlack;
        private System.Windows.Forms.TextBox textBoxIncNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxWebEx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonOpenRemote;
        private System.Windows.Forms.TextBox textBoxCloudText;
        private System.Windows.Forms.Button buttonUpdateCloudText;
    }
}