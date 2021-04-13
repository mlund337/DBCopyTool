
namespace DBCopyTool
{
    partial class FormSQL
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
            this.textBoxSQL = new System.Windows.Forms.TextBox();
            this.radioDBUser = new System.Windows.Forms.RadioButton();
            this.radioClearScript = new System.Windows.Forms.RadioButton();
            this.radioGetSys = new System.Windows.Forms.RadioButton();
            this.textDBUser = new System.Windows.Forms.TextBox();
            this.radioSetSys = new System.Windows.Forms.RadioButton();
            this.labelSQLQuery = new System.Windows.Forms.Label();
            this.radioCheckDS = new System.Windows.Forms.RadioButton();
            this.labelClipSuccess = new System.Windows.Forms.Label();
            this.radioGetDS = new System.Windows.Forms.RadioButton();
            this.buttonClipboard = new System.Windows.Forms.Button();
            this.radioSetDS = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxPin = new System.Windows.Forms.TextBox();
            this.buttonUpdatePins = new System.Windows.Forms.Button();
            this.textBoxAppPin = new System.Windows.Forms.TextBox();
            this.textBoxOldConfig = new System.Windows.Forms.TextBox();
            this.textBoxNewConfig = new System.Windows.Forms.TextBox();
            this.textBoxDefaultDS = new System.Windows.Forms.TextBox();
            this.buttonDefaultDS = new System.Windows.Forms.Button();
            this.buttonReplaceDS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSQL
            // 
            this.textBoxSQL.Location = new System.Drawing.Point(276, 73);
            this.textBoxSQL.Multiline = true;
            this.textBoxSQL.Name = "textBoxSQL";
            this.textBoxSQL.Size = new System.Drawing.Size(499, 256);
            this.textBoxSQL.TabIndex = 17;
            this.textBoxSQL.WordWrap = false;
            // 
            // radioDBUser
            // 
            this.radioDBUser.AutoSize = true;
            this.radioDBUser.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDBUser.Location = new System.Drawing.Point(51, 54);
            this.radioDBUser.Name = "radioDBUser";
            this.radioDBUser.Size = new System.Drawing.Size(111, 20);
            this.radioDBUser.TabIndex = 18;
            this.radioDBUser.TabStop = true;
            this.radioDBUser.Text = "DB User Update";
            this.radioDBUser.UseVisualStyleBackColor = true;
            this.radioDBUser.CheckedChanged += new System.EventHandler(this.radioDBUser_CheckedChanged);
            // 
            // radioClearScript
            // 
            this.radioClearScript.AutoSize = true;
            this.radioClearScript.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioClearScript.Location = new System.Drawing.Point(51, 146);
            this.radioClearScript.Name = "radioClearScript";
            this.radioClearScript.Size = new System.Drawing.Size(88, 20);
            this.radioClearScript.TabIndex = 19;
            this.radioClearScript.TabStop = true;
            this.radioClearScript.Text = "Clear Script";
            this.radioClearScript.UseVisualStyleBackColor = true;
            this.radioClearScript.CheckedChanged += new System.EventHandler(this.radioClearScript_CheckedChanged);
            // 
            // radioGetSys
            // 
            this.radioGetSys.AutoSize = true;
            this.radioGetSys.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGetSys.Location = new System.Drawing.Point(51, 200);
            this.radioGetSys.Name = "radioGetSys";
            this.radioGetSys.Size = new System.Drawing.Size(165, 20);
            this.radioGetSys.TabIndex = 20;
            this.radioGetSys.TabStop = true;
            this.radioGetSys.Text = "Get Pin and Approval Pin";
            this.radioGetSys.UseVisualStyleBackColor = true;
            this.radioGetSys.CheckedChanged += new System.EventHandler(this.radioGetSys_CheckedChanged);
            // 
            // textDBUser
            // 
            this.textDBUser.Location = new System.Drawing.Point(32, 80);
            this.textDBUser.Name = "textDBUser";
            this.textDBUser.Size = new System.Drawing.Size(79, 20);
            this.textDBUser.TabIndex = 30;
            this.textDBUser.Text = "username";
            // 
            // radioSetSys
            // 
            this.radioSetSys.AutoSize = true;
            this.radioSetSys.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSetSys.Location = new System.Drawing.Point(51, 223);
            this.radioSetSys.Name = "radioSetSys";
            this.radioSetSys.Size = new System.Drawing.Size(43, 20);
            this.radioSetSys.TabIndex = 21;
            this.radioSetSys.TabStop = true;
            this.radioSetSys.Text = "Set";
            this.radioSetSys.UseVisualStyleBackColor = true;
            this.radioSetSys.CheckedChanged += new System.EventHandler(this.radioSetSys_CheckedChanged);
            // 
            // labelSQLQuery
            // 
            this.labelSQLQuery.AutoSize = true;
            this.labelSQLQuery.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSQLQuery.Location = new System.Drawing.Point(276, 54);
            this.labelSQLQuery.Name = "labelSQLQuery";
            this.labelSQLQuery.Size = new System.Drawing.Size(76, 16);
            this.labelSQLQuery.TabIndex = 29;
            this.labelSQLQuery.Text = "SQL Query";
            // 
            // radioCheckDS
            // 
            this.radioCheckDS.AutoSize = true;
            this.radioCheckDS.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCheckDS.Location = new System.Drawing.Point(47, 361);
            this.radioCheckDS.Name = "radioCheckDS";
            this.radioCheckDS.Size = new System.Drawing.Size(64, 20);
            this.radioCheckDS.TabIndex = 22;
            this.radioCheckDS.TabStop = true;
            this.radioCheckDS.Text = "Check ";
            this.radioCheckDS.UseVisualStyleBackColor = true;
            this.radioCheckDS.CheckedChanged += new System.EventHandler(this.radioCheckDS_CheckedChanged);
            // 
            // labelClipSuccess
            // 
            this.labelClipSuccess.AutoSize = true;
            this.labelClipSuccess.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClipSuccess.Location = new System.Drawing.Point(346, 340);
            this.labelClipSuccess.Name = "labelClipSuccess";
            this.labelClipSuccess.Size = new System.Drawing.Size(0, 16);
            this.labelClipSuccess.TabIndex = 28;
            // 
            // radioGetDS
            // 
            this.radioGetDS.AutoSize = true;
            this.radioGetDS.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGetDS.Location = new System.Drawing.Point(47, 384);
            this.radioGetDS.Name = "radioGetDS";
            this.radioGetDS.Size = new System.Drawing.Size(124, 20);
            this.radioGetDS.TabIndex = 23;
            this.radioGetDS.TabStop = true;
            this.radioGetDS.Text = "Get Old and New";
            this.radioGetDS.UseVisualStyleBackColor = true;
            this.radioGetDS.CheckedChanged += new System.EventHandler(this.radioGetDS_CheckedChanged);
            // 
            // buttonClipboard
            // 
            this.buttonClipboard.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClipboard.Location = new System.Drawing.Point(276, 335);
            this.buttonClipboard.Name = "buttonClipboard";
            this.buttonClipboard.Size = new System.Drawing.Size(59, 23);
            this.buttonClipboard.TabIndex = 27;
            this.buttonClipboard.Text = "Copy";
            this.buttonClipboard.UseVisualStyleBackColor = true;
            this.buttonClipboard.Click += new System.EventHandler(this.buttonClipboard_Click);
            // 
            // radioSetDS
            // 
            this.radioSetDS.AutoSize = true;
            this.radioSetDS.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSetDS.Location = new System.Drawing.Point(47, 471);
            this.radioSetDS.Name = "radioSetDS";
            this.radioSetDS.Size = new System.Drawing.Size(120, 20);
            this.radioSetDS.TabIndex = 24;
            this.radioSetDS.TabStop = true;
            this.radioSetDS.Text = "Set Old and New";
            this.radioSetDS.UseVisualStyleBackColor = true;
            this.radioSetDS.CheckedChanged += new System.EventHandler(this.radioSetDS_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Sysadmin Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "External Data Structures";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(32, 106);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(59, 23);
            this.buttonUpdate.TabIndex = 31;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxPin
            // 
            this.textBoxPin.Location = new System.Drawing.Point(32, 247);
            this.textBoxPin.Name = "textBoxPin";
            this.textBoxPin.Size = new System.Drawing.Size(221, 20);
            this.textBoxPin.TabIndex = 32;
            this.textBoxPin.Text = "ABCDEFG123456789";
            // 
            // buttonUpdatePins
            // 
            this.buttonUpdatePins.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdatePins.Location = new System.Drawing.Point(32, 300);
            this.buttonUpdatePins.Name = "buttonUpdatePins";
            this.buttonUpdatePins.Size = new System.Drawing.Size(59, 23);
            this.buttonUpdatePins.TabIndex = 33;
            this.buttonUpdatePins.Text = "Update";
            this.buttonUpdatePins.UseVisualStyleBackColor = true;
            this.buttonUpdatePins.Click += new System.EventHandler(this.buttonUpdatePins_Click);
            // 
            // textBoxAppPin
            // 
            this.textBoxAppPin.Location = new System.Drawing.Point(32, 274);
            this.textBoxAppPin.Name = "textBoxAppPin";
            this.textBoxAppPin.Size = new System.Drawing.Size(221, 20);
            this.textBoxAppPin.TabIndex = 34;
            this.textBoxAppPin.Text = "ABCDEFG12345678";
            // 
            // textBoxOldConfig
            // 
            this.textBoxOldConfig.Location = new System.Drawing.Point(32, 499);
            this.textBoxOldConfig.Name = "textBoxOldConfig";
            this.textBoxOldConfig.Size = new System.Drawing.Size(743, 20);
            this.textBoxOldConfig.TabIndex = 35;
            this.textBoxOldConfig.Text = "{\"OLD SOURCECONFIG\"}";
            // 
            // textBoxNewConfig
            // 
            this.textBoxNewConfig.Location = new System.Drawing.Point(32, 526);
            this.textBoxNewConfig.Name = "textBoxNewConfig";
            this.textBoxNewConfig.Size = new System.Drawing.Size(743, 20);
            this.textBoxNewConfig.TabIndex = 36;
            this.textBoxNewConfig.Text = "{\"NEW SOURCECONFIG\"}";
            // 
            // textBoxDefaultDS
            // 
            this.textBoxDefaultDS.Location = new System.Drawing.Point(32, 411);
            this.textBoxDefaultDS.Name = "textBoxDefaultDS";
            this.textBoxDefaultDS.Size = new System.Drawing.Size(221, 20);
            this.textBoxDefaultDS.TabIndex = 37;
            this.textBoxDefaultDS.Text = "DataStructureName";
            // 
            // buttonDefaultDS
            // 
            this.buttonDefaultDS.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDefaultDS.Location = new System.Drawing.Point(32, 438);
            this.buttonDefaultDS.Name = "buttonDefaultDS";
            this.buttonDefaultDS.Size = new System.Drawing.Size(59, 23);
            this.buttonDefaultDS.TabIndex = 38;
            this.buttonDefaultDS.Text = "Update";
            this.buttonDefaultDS.UseVisualStyleBackColor = true;
            this.buttonDefaultDS.Click += new System.EventHandler(this.buttonDefaultDS_Click);
            // 
            // buttonReplaceDS
            // 
            this.buttonReplaceDS.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReplaceDS.Location = new System.Drawing.Point(32, 553);
            this.buttonReplaceDS.Name = "buttonReplaceDS";
            this.buttonReplaceDS.Size = new System.Drawing.Size(59, 23);
            this.buttonReplaceDS.TabIndex = 40;
            this.buttonReplaceDS.Text = "Update";
            this.buttonReplaceDS.UseVisualStyleBackColor = true;
            this.buttonReplaceDS.Click += new System.EventHandler(this.buttonReplaceDS_Click);
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.buttonReplaceDS);
            this.Controls.Add(this.buttonDefaultDS);
            this.Controls.Add(this.textBoxDefaultDS);
            this.Controls.Add(this.textBoxNewConfig);
            this.Controls.Add(this.textBoxOldConfig);
            this.Controls.Add(this.textBoxAppPin);
            this.Controls.Add(this.buttonUpdatePins);
            this.Controls.Add(this.textBoxPin);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxSQL);
            this.Controls.Add(this.radioDBUser);
            this.Controls.Add(this.radioClearScript);
            this.Controls.Add(this.radioGetSys);
            this.Controls.Add(this.textDBUser);
            this.Controls.Add(this.radioSetSys);
            this.Controls.Add(this.labelSQLQuery);
            this.Controls.Add(this.radioCheckDS);
            this.Controls.Add(this.labelClipSuccess);
            this.Controls.Add(this.radioGetDS);
            this.Controls.Add(this.buttonClipboard);
            this.Controls.Add(this.radioSetDS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSQL";
            this.Text = "SQL Queries";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSQL;
        private System.Windows.Forms.RadioButton radioDBUser;
        private System.Windows.Forms.RadioButton radioClearScript;
        private System.Windows.Forms.RadioButton radioGetSys;
        private System.Windows.Forms.TextBox textDBUser;
        private System.Windows.Forms.RadioButton radioSetSys;
        private System.Windows.Forms.Label labelSQLQuery;
        private System.Windows.Forms.RadioButton radioCheckDS;
        private System.Windows.Forms.Label labelClipSuccess;
        private System.Windows.Forms.RadioButton radioGetDS;
        private System.Windows.Forms.Button buttonClipboard;
        private System.Windows.Forms.RadioButton radioSetDS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxPin;
        private System.Windows.Forms.Button buttonUpdatePins;
        private System.Windows.Forms.TextBox textBoxAppPin;
        private System.Windows.Forms.TextBox textBoxOldConfig;
        private System.Windows.Forms.TextBox textBoxNewConfig;
        private System.Windows.Forms.TextBox textBoxDefaultDS;
        private System.Windows.Forms.Button buttonDefaultDS;
        private System.Windows.Forms.Button buttonReplaceDS;
    }
}