namespace RSBot
{
    partial class Form
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDownloadRefId = new System.Windows.Forms.TextBox();
            this.btnToDb = new System.Windows.Forms.Button();
            this.txtDbConnectionString = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.btnVerifyUpload = new System.Windows.Forms.Button();
            this.txtUploadRefId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tnVerifyNoErrors = new System.Windows.Forms.Button();
            this.txtUploadResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpcCodes = new System.Windows.Forms.Button();
            this.btnDownloadUpc = new System.Windows.Forms.Button();
            this.btnPrepareDownloadUpc = new System.Windows.Forms.Button();
            this.txtDownloadUPCRefId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(12, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(740, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Listing from Asins";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(12, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(740, 30);
            this.button2.TabIndex = 0;
            this.button2.Text = "Prepare Download ebay Listings";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnPrepare_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button3.Location = new System.Drawing.Point(12, 575);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(740, 30);
            this.button3.TabIndex = 1;
            this.button3.Text = "Local Optimization Title";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Orange;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button4.Location = new System.Drawing.Point(12, 612);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(740, 30);
            this.button4.TabIndex = 1;
            this.button4.Text = "Local Optimization Images";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpload.Location = new System.Drawing.Point(12, 649);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(740, 30);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Upload optimized to ebay";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtUsername.Location = new System.Drawing.Point(156, 11);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(596, 26);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "info@theoriginalsinstore.com";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtPassword.Location = new System.Drawing.Point(156, 43);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(596, 26);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "rz7356sh$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ebay Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ebay Password";
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button6.Location = new System.Drawing.Point(12, 353);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(740, 30);
            this.button6.TabIndex = 4;
            this.button6.Text = "Download ebay Listings";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(13, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Download Ref ID";
            // 
            // txtDownloadRefId
            // 
            this.txtDownloadRefId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDownloadRefId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtDownloadRefId.Location = new System.Drawing.Point(156, 75);
            this.txtDownloadRefId.Name = "txtDownloadRefId";
            this.txtDownloadRefId.Size = new System.Drawing.Size(596, 26);
            this.txtDownloadRefId.TabIndex = 5;
            // 
            // btnToDb
            // 
            this.btnToDb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnToDb.Location = new System.Drawing.Point(12, 390);
            this.btnToDb.Name = "btnToDb";
            this.btnToDb.Size = new System.Drawing.Size(740, 30);
            this.btnToDb.TabIndex = 4;
            this.btnToDb.Text = "Import listings to DB";
            this.btnToDb.UseVisualStyleBackColor = true;
            this.btnToDb.Click += new System.EventHandler(this.btnToDb_Click);
            // 
            // txtDbConnectionString
            // 
            this.txtDbConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDbConnectionString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtDbConnectionString.Location = new System.Drawing.Point(156, 186);
            this.txtDbConnectionString.Multiline = true;
            this.txtDbConnectionString.Name = "txtDbConnectionString";
            this.txtDbConnectionString.Size = new System.Drawing.Size(596, 55);
            this.txtDbConnectionString.TabIndex = 5;
            this.txtDbConnectionString.Text = "SERVER=rsbot.chsskanxfjmo.us-west-2.rds.amazonaws.com;DATABASE=rsbot;UID=root;PAS" +
    "SWORD=Zaq1Zaq1;";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(13, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "DB";
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button7.Location = new System.Drawing.Point(12, 538);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(740, 30);
            this.button7.TabIndex = 4;
            this.button7.Text = "Download Images";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btnDownloadImages_Click);
            // 
            // btnVerifyUpload
            // 
            this.btnVerifyUpload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerifyUpload.BackColor = System.Drawing.SystemColors.Control;
            this.btnVerifyUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnVerifyUpload.Location = new System.Drawing.Point(12, 686);
            this.btnVerifyUpload.Name = "btnVerifyUpload";
            this.btnVerifyUpload.Size = new System.Drawing.Size(740, 30);
            this.btnVerifyUpload.TabIndex = 1;
            this.btnVerifyUpload.Text = "Verify file uploaded";
            this.btnVerifyUpload.UseVisualStyleBackColor = false;
            this.btnVerifyUpload.Click += new System.EventHandler(this.btnVerifyUpload_Click);
            // 
            // txtUploadRefId
            // 
            this.txtUploadRefId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUploadRefId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtUploadRefId.Location = new System.Drawing.Point(156, 153);
            this.txtUploadRefId.Name = "txtUploadRefId";
            this.txtUploadRefId.Size = new System.Drawing.Size(596, 26);
            this.txtUploadRefId.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(13, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Upload Ref ID";
            // 
            // tnVerifyNoErrors
            // 
            this.tnVerifyNoErrors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tnVerifyNoErrors.BackColor = System.Drawing.SystemColors.Control;
            this.tnVerifyNoErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tnVerifyNoErrors.Location = new System.Drawing.Point(12, 723);
            this.tnVerifyNoErrors.Name = "tnVerifyNoErrors";
            this.tnVerifyNoErrors.Size = new System.Drawing.Size(740, 30);
            this.tnVerifyNoErrors.TabIndex = 1;
            this.tnVerifyNoErrors.Text = "Verify no errors during upload";
            this.tnVerifyNoErrors.UseVisualStyleBackColor = false;
            this.tnVerifyNoErrors.Click += new System.EventHandler(this.btnVerifyUploadNoErrors_Click);
            // 
            // txtUploadResult
            // 
            this.txtUploadResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUploadResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtUploadResult.Location = new System.Drawing.Point(156, 247);
            this.txtUploadResult.Name = "txtUploadResult";
            this.txtUploadResult.ReadOnly = true;
            this.txtUploadResult.Size = new System.Drawing.Size(596, 26);
            this.txtUploadResult.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(13, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Upload Result";
            // 
            // btnUpcCodes
            // 
            this.btnUpcCodes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpcCodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpcCodes.Location = new System.Drawing.Point(12, 501);
            this.btnUpcCodes.Name = "btnUpcCodes";
            this.btnUpcCodes.Size = new System.Drawing.Size(740, 30);
            this.btnUpcCodes.TabIndex = 9;
            this.btnUpcCodes.Text = "Import UPC to DB";
            this.btnUpcCodes.UseVisualStyleBackColor = true;
            this.btnUpcCodes.Click += new System.EventHandler(this.btnImportUpcCodes_Click);
            // 
            // btnDownloadUpc
            // 
            this.btnDownloadUpc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownloadUpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDownloadUpc.Location = new System.Drawing.Point(12, 464);
            this.btnDownloadUpc.Name = "btnDownloadUpc";
            this.btnDownloadUpc.Size = new System.Drawing.Size(740, 30);
            this.btnDownloadUpc.TabIndex = 8;
            this.btnDownloadUpc.Text = "Download UPC (ebay)";
            this.btnDownloadUpc.UseVisualStyleBackColor = true;
            this.btnDownloadUpc.Click += new System.EventHandler(this.btnDownloadUpc_Click);
            // 
            // btnPrepareDownloadUpc
            // 
            this.btnPrepareDownloadUpc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrepareDownloadUpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnPrepareDownloadUpc.Location = new System.Drawing.Point(12, 427);
            this.btnPrepareDownloadUpc.Name = "btnPrepareDownloadUpc";
            this.btnPrepareDownloadUpc.Size = new System.Drawing.Size(740, 30);
            this.btnPrepareDownloadUpc.TabIndex = 7;
            this.btnPrepareDownloadUpc.Text = "Prepare Download ebay UPC";
            this.btnPrepareDownloadUpc.UseVisualStyleBackColor = true;
            this.btnPrepareDownloadUpc.Click += new System.EventHandler(this.btnPrepareDownloadUpc_Click);
            // 
            // txtDownloadUPCRefId
            // 
            this.txtDownloadUPCRefId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDownloadUPCRefId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtDownloadUPCRefId.Location = new System.Drawing.Point(156, 107);
            this.txtDownloadUPCRefId.Name = "txtDownloadUPCRefId";
            this.txtDownloadUPCRefId.Size = new System.Drawing.Size(596, 26);
            this.txtDownloadUPCRefId.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(13, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "D/L UPC Ref ID";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 765);
            this.Controls.Add(this.btnUpcCodes);
            this.Controls.Add(this.btnDownloadUpc);
            this.Controls.Add(this.btnPrepareDownloadUpc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDbConnectionString);
            this.Controls.Add(this.txtUploadResult);
            this.Controls.Add(this.txtUploadRefId);
            this.Controls.Add(this.txtDownloadUPCRefId);
            this.Controls.Add(this.txtDownloadRefId);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnToDb);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.tnVerifyNoErrors);
            this.Controls.Add(this.btnVerifyUpload);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDownloadRefId;
        private System.Windows.Forms.Button btnToDb;
        private System.Windows.Forms.TextBox txtDbConnectionString;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnVerifyUpload;
        private System.Windows.Forms.TextBox txtUploadRefId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button tnVerifyNoErrors;
        private System.Windows.Forms.TextBox txtUploadResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpcCodes;
        private System.Windows.Forms.Button btnDownloadUpc;
        private System.Windows.Forms.Button btnPrepareDownloadUpc;
        private System.Windows.Forms.TextBox txtDownloadUPCRefId;
        private System.Windows.Forms.Label label7;
    }
}

