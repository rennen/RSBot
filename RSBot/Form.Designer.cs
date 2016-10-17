using System.Windows.Forms;

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
            this.btnOptimizeImages = new System.Windows.Forms.Button();
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
            this.txtCloudinaryKey = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCloudinarySecret = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCloudinaryAppName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pg10 = new System.Windows.Forms.ProgressBar();
            this.pg9 = new System.Windows.Forms.ProgressBar();
            this.pg8 = new System.Windows.Forms.ProgressBar();
            this.pg7 = new System.Windows.Forms.ProgressBar();
            this.pg12 = new System.Windows.Forms.ProgressBar();
            this.pg11 = new System.Windows.Forms.ProgressBar();
            this.pg6 = new System.Windows.Forms.ProgressBar();
            this.pg5 = new System.Windows.Forms.ProgressBar();
            this.pg4 = new System.Windows.Forms.ProgressBar();
            this.pg3 = new System.Windows.Forms.ProgressBar();
            this.pg2 = new System.Windows.Forms.ProgressBar();
            this.pg1 = new System.Windows.Forms.ProgressBar();
            this.chk12 = new System.Windows.Forms.CheckBox();
            this.chk11 = new System.Windows.Forms.CheckBox();
            this.chk10 = new System.Windows.Forms.CheckBox();
            this.chk9 = new System.Windows.Forms.CheckBox();
            this.chk8 = new System.Windows.Forms.CheckBox();
            this.chk7 = new System.Windows.Forms.CheckBox();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.chk6 = new System.Windows.Forms.CheckBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk5 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.panel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnShowSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(23, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(377, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Listing from Asins";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(23, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(377, 30);
            this.button2.TabIndex = 0;
            this.button2.Text = "Prepare Download ebay Listings";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnPrepare_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button3.Location = new System.Drawing.Point(23, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(377, 30);
            this.button3.TabIndex = 1;
            this.button3.Text = "Local Optimization Title";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnOptimizeImages
            // 
            this.btnOptimizeImages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptimizeImages.BackColor = System.Drawing.Color.Orange;
            this.btnOptimizeImages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOptimizeImages.FlatAppearance.BorderSize = 0;
            this.btnOptimizeImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptimizeImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOptimizeImages.Location = new System.Drawing.Point(23, 348);
            this.btnOptimizeImages.Name = "btnOptimizeImages";
            this.btnOptimizeImages.Size = new System.Drawing.Size(377, 30);
            this.btnOptimizeImages.TabIndex = 1;
            this.btnOptimizeImages.Text = "Local Optimization Images";
            this.btnOptimizeImages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptimizeImages.UseVisualStyleBackColor = false;
            this.btnOptimizeImages.Click += new System.EventHandler(this.btnOptimizeImages_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpload.Location = new System.Drawing.Point(23, 385);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(377, 30);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Upload optimized to ebay";
            this.btnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtUsername.Location = new System.Drawing.Point(184, 15);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(666, 26);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "info@theoriginalsinstore.com";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtPassword.Location = new System.Drawing.Point(184, 47);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(666, 26);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "rz7356sh$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ebay Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ebay Password";
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button6.Location = new System.Drawing.Point(23, 89);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(377, 30);
            this.button6.TabIndex = 4;
            this.button6.Text = "Download ebay Listings";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(3, 82);
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
            this.txtDownloadRefId.Location = new System.Drawing.Point(184, 79);
            this.txtDownloadRefId.Name = "txtDownloadRefId";
            this.txtDownloadRefId.Size = new System.Drawing.Size(666, 26);
            this.txtDownloadRefId.TabIndex = 5;
            // 
            // btnToDb
            // 
            this.btnToDb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToDb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToDb.FlatAppearance.BorderSize = 0;
            this.btnToDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnToDb.Location = new System.Drawing.Point(23, 126);
            this.btnToDb.Name = "btnToDb";
            this.btnToDb.Size = new System.Drawing.Size(377, 30);
            this.btnToDb.TabIndex = 4;
            this.btnToDb.Text = "Import listings to DB";
            this.btnToDb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToDb.UseVisualStyleBackColor = true;
            this.btnToDb.Click += new System.EventHandler(this.btnToDb_Click);
            // 
            // txtDbConnectionString
            // 
            this.txtDbConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDbConnectionString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtDbConnectionString.Location = new System.Drawing.Point(184, 190);
            this.txtDbConnectionString.Multiline = true;
            this.txtDbConnectionString.Name = "txtDbConnectionString";
            this.txtDbConnectionString.Size = new System.Drawing.Size(666, 55);
            this.txtDbConnectionString.TabIndex = 5;
            this.txtDbConnectionString.Text = "SERVER=rsbot.chsskanxfjmo.us-west-2.rds.amazonaws.com;DATABASE=rsbot;UID=root;PAS" +
    "SWORD=Zaq1Zaq1;";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(3, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "DB";
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button7.Location = new System.Drawing.Point(23, 274);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(377, 30);
            this.button7.TabIndex = 4;
            this.button7.Text = "Download Images";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btnDownloadImages_Click);
            // 
            // btnVerifyUpload
            // 
            this.btnVerifyUpload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerifyUpload.BackColor = System.Drawing.SystemColors.Control;
            this.btnVerifyUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerifyUpload.FlatAppearance.BorderSize = 0;
            this.btnVerifyUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnVerifyUpload.Location = new System.Drawing.Point(23, 422);
            this.btnVerifyUpload.Name = "btnVerifyUpload";
            this.btnVerifyUpload.Size = new System.Drawing.Size(377, 30);
            this.btnVerifyUpload.TabIndex = 1;
            this.btnVerifyUpload.Text = "Verify file uploaded";
            this.btnVerifyUpload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerifyUpload.UseVisualStyleBackColor = false;
            this.btnVerifyUpload.Click += new System.EventHandler(this.btnVerifyUpload_Click);
            // 
            // txtUploadRefId
            // 
            this.txtUploadRefId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUploadRefId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtUploadRefId.Location = new System.Drawing.Point(184, 157);
            this.txtUploadRefId.Name = "txtUploadRefId";
            this.txtUploadRefId.Size = new System.Drawing.Size(666, 26);
            this.txtUploadRefId.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(3, 160);
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
            this.tnVerifyNoErrors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tnVerifyNoErrors.FlatAppearance.BorderSize = 0;
            this.tnVerifyNoErrors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tnVerifyNoErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tnVerifyNoErrors.Location = new System.Drawing.Point(23, 459);
            this.tnVerifyNoErrors.Name = "tnVerifyNoErrors";
            this.tnVerifyNoErrors.Size = new System.Drawing.Size(377, 30);
            this.tnVerifyNoErrors.TabIndex = 1;
            this.tnVerifyNoErrors.Text = "Verify no errors during upload";
            this.tnVerifyNoErrors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tnVerifyNoErrors.UseVisualStyleBackColor = false;
            this.tnVerifyNoErrors.Click += new System.EventHandler(this.btnVerifyUploadNoErrors_Click);
            // 
            // txtUploadResult
            // 
            this.txtUploadResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUploadResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtUploadResult.Location = new System.Drawing.Point(184, 251);
            this.txtUploadResult.Name = "txtUploadResult";
            this.txtUploadResult.ReadOnly = true;
            this.txtUploadResult.Size = new System.Drawing.Size(666, 26);
            this.txtUploadResult.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(3, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Upload Result";
            // 
            // btnUpcCodes
            // 
            this.btnUpcCodes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpcCodes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpcCodes.FlatAppearance.BorderSize = 0;
            this.btnUpcCodes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpcCodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpcCodes.Location = new System.Drawing.Point(23, 237);
            this.btnUpcCodes.Name = "btnUpcCodes";
            this.btnUpcCodes.Size = new System.Drawing.Size(377, 30);
            this.btnUpcCodes.TabIndex = 9;
            this.btnUpcCodes.Text = "Import UPC to DB";
            this.btnUpcCodes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpcCodes.UseVisualStyleBackColor = true;
            this.btnUpcCodes.Click += new System.EventHandler(this.btnImportUpcCodes_Click);
            // 
            // btnDownloadUpc
            // 
            this.btnDownloadUpc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownloadUpc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownloadUpc.FlatAppearance.BorderSize = 0;
            this.btnDownloadUpc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadUpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDownloadUpc.Location = new System.Drawing.Point(23, 200);
            this.btnDownloadUpc.Name = "btnDownloadUpc";
            this.btnDownloadUpc.Size = new System.Drawing.Size(377, 30);
            this.btnDownloadUpc.TabIndex = 8;
            this.btnDownloadUpc.Text = "Download UPC (ebay)";
            this.btnDownloadUpc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownloadUpc.UseVisualStyleBackColor = true;
            this.btnDownloadUpc.Click += new System.EventHandler(this.btnDownloadUpc_Click);
            // 
            // btnPrepareDownloadUpc
            // 
            this.btnPrepareDownloadUpc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrepareDownloadUpc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrepareDownloadUpc.FlatAppearance.BorderSize = 0;
            this.btnPrepareDownloadUpc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrepareDownloadUpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnPrepareDownloadUpc.Location = new System.Drawing.Point(23, 163);
            this.btnPrepareDownloadUpc.Name = "btnPrepareDownloadUpc";
            this.btnPrepareDownloadUpc.Size = new System.Drawing.Size(377, 30);
            this.btnPrepareDownloadUpc.TabIndex = 7;
            this.btnPrepareDownloadUpc.Text = "Prepare Download ebay UPC";
            this.btnPrepareDownloadUpc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrepareDownloadUpc.UseVisualStyleBackColor = true;
            this.btnPrepareDownloadUpc.Click += new System.EventHandler(this.btnPrepareDownloadUpc_Click);
            // 
            // txtDownloadUPCRefId
            // 
            this.txtDownloadUPCRefId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDownloadUPCRefId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtDownloadUPCRefId.Location = new System.Drawing.Point(184, 111);
            this.txtDownloadUPCRefId.Name = "txtDownloadUPCRefId";
            this.txtDownloadUPCRefId.Size = new System.Drawing.Size(666, 26);
            this.txtDownloadUPCRefId.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(3, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "D/L UPC Ref ID";
            // 
            // txtCloudinaryKey
            // 
            this.txtCloudinaryKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCloudinaryKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtCloudinaryKey.Location = new System.Drawing.Point(184, 314);
            this.txtCloudinaryKey.Name = "txtCloudinaryKey";
            this.txtCloudinaryKey.ReadOnly = true;
            this.txtCloudinaryKey.Size = new System.Drawing.Size(666, 26);
            this.txtCloudinaryKey.TabIndex = 5;
            this.txtCloudinaryKey.Text = "757673843368737";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(3, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cloudinary Key";
            // 
            // txtCloudinarySecret
            // 
            this.txtCloudinarySecret.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCloudinarySecret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtCloudinarySecret.Location = new System.Drawing.Point(170, 343);
            this.txtCloudinarySecret.Name = "txtCloudinarySecret";
            this.txtCloudinarySecret.ReadOnly = true;
            this.txtCloudinarySecret.Size = new System.Drawing.Size(379, 26);
            this.txtCloudinarySecret.TabIndex = 5;
            this.txtCloudinarySecret.Text = "58C8IyRHHQkAJm7Tk9lfNHDn9E8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(3, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Cloudinary Secret";
            // 
            // txtCloudinaryAppName
            // 
            this.txtCloudinaryAppName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCloudinaryAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtCloudinaryAppName.Location = new System.Drawing.Point(184, 283);
            this.txtCloudinaryAppName.Name = "txtCloudinaryAppName";
            this.txtCloudinaryAppName.ReadOnly = true;
            this.txtCloudinaryAppName.Size = new System.Drawing.Size(666, 26);
            this.txtCloudinaryAppName.TabIndex = 5;
            this.txtCloudinaryAppName.Text = "dotpi3eua";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(3, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Cloudinary App Name";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 67);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer.Panel1.Controls.Add(this.label1);
            this.splitContainer.Panel1.Controls.Add(this.txtUsername);
            this.splitContainer.Panel1.Controls.Add(this.txtPassword);
            this.splitContainer.Panel1.Controls.Add(this.label2);
            this.splitContainer.Panel1.Controls.Add(this.txtDownloadRefId);
            this.splitContainer.Panel1.Controls.Add(this.txtDownloadUPCRefId);
            this.splitContainer.Panel1.Controls.Add(this.label4);
            this.splitContainer.Panel1.Controls.Add(this.txtUploadRefId);
            this.splitContainer.Panel1.Controls.Add(this.label9);
            this.splitContainer.Panel1.Controls.Add(this.txtUploadResult);
            this.splitContainer.Panel1.Controls.Add(this.label10);
            this.splitContainer.Panel1.Controls.Add(this.txtCloudinaryKey);
            this.splitContainer.Panel1.Controls.Add(this.label8);
            this.splitContainer.Panel1.Controls.Add(this.txtCloudinaryAppName);
            this.splitContainer.Panel1.Controls.Add(this.label6);
            this.splitContainer.Panel1.Controls.Add(this.txtCloudinarySecret);
            this.splitContainer.Panel1.Controls.Add(this.label5);
            this.splitContainer.Panel1.Controls.Add(this.txtDbConnectionString);
            this.splitContainer.Panel1.Controls.Add(this.label7);
            this.splitContainer.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.pg10);
            this.splitContainer.Panel2.Controls.Add(this.pg9);
            this.splitContainer.Panel2.Controls.Add(this.pg8);
            this.splitContainer.Panel2.Controls.Add(this.pg7);
            this.splitContainer.Panel2.Controls.Add(this.pg12);
            this.splitContainer.Panel2.Controls.Add(this.pg11);
            this.splitContainer.Panel2.Controls.Add(this.pg6);
            this.splitContainer.Panel2.Controls.Add(this.pg5);
            this.splitContainer.Panel2.Controls.Add(this.pg4);
            this.splitContainer.Panel2.Controls.Add(this.pg3);
            this.splitContainer.Panel2.Controls.Add(this.pg2);
            this.splitContainer.Panel2.Controls.Add(this.pg1);
            this.splitContainer.Panel2.Controls.Add(this.chk12);
            this.splitContainer.Panel2.Controls.Add(this.chk11);
            this.splitContainer.Panel2.Controls.Add(this.chk10);
            this.splitContainer.Panel2.Controls.Add(this.chk9);
            this.splitContainer.Panel2.Controls.Add(this.chk8);
            this.splitContainer.Panel2.Controls.Add(this.chk7);
            this.splitContainer.Panel2.Controls.Add(this.chk4);
            this.splitContainer.Panel2.Controls.Add(this.chk6);
            this.splitContainer.Panel2.Controls.Add(this.chk3);
            this.splitContainer.Panel2.Controls.Add(this.chk5);
            this.splitContainer.Panel2.Controls.Add(this.chk2);
            this.splitContainer.Panel2.Controls.Add(this.chk1);
            this.splitContainer.Panel2.Controls.Add(this.button1);
            this.splitContainer.Panel2.Controls.Add(this.btnUpcCodes);
            this.splitContainer.Panel2.Controls.Add(this.button2);
            this.splitContainer.Panel2.Controls.Add(this.btnDownloadUpc);
            this.splitContainer.Panel2.Controls.Add(this.button3);
            this.splitContainer.Panel2.Controls.Add(this.btnPrepareDownloadUpc);
            this.splitContainer.Panel2.Controls.Add(this.btnOptimizeImages);
            this.splitContainer.Panel2.Controls.Add(this.button7);
            this.splitContainer.Panel2.Controls.Add(this.btnVerifyUpload);
            this.splitContainer.Panel2.Controls.Add(this.btnToDb);
            this.splitContainer.Panel2.Controls.Add(this.tnVerifyNoErrors);
            this.splitContainer.Panel2.Controls.Add(this.button6);
            this.splitContainer.Panel2.Controls.Add(this.btnUpload);
            this.splitContainer.Size = new System.Drawing.Size(862, 806);
            this.splitContainer.SplitterDistance = 343;
            this.splitContainer.TabIndex = 12;
            // 
            // pg10
            // 
            this.pg10.Location = new System.Drawing.Point(734, 352);
            this.pg10.Name = "pg10";
            this.pg10.Size = new System.Drawing.Size(116, 27);
            this.pg10.TabIndex = 24;
            // 
            // pg9
            // 
            this.pg9.Location = new System.Drawing.Point(734, 315);
            this.pg9.Name = "pg9";
            this.pg9.Size = new System.Drawing.Size(116, 27);
            this.pg9.TabIndex = 23;
            // 
            // pg8
            // 
            this.pg8.Location = new System.Drawing.Point(734, 278);
            this.pg8.Name = "pg8";
            this.pg8.Size = new System.Drawing.Size(116, 27);
            this.pg8.TabIndex = 24;
            // 
            // pg7
            // 
            this.pg7.Location = new System.Drawing.Point(734, 241);
            this.pg7.Name = "pg7";
            this.pg7.Size = new System.Drawing.Size(116, 27);
            this.pg7.TabIndex = 23;
            // 
            // pg12
            // 
            this.pg12.Location = new System.Drawing.Point(734, 426);
            this.pg12.Name = "pg12";
            this.pg12.Size = new System.Drawing.Size(116, 27);
            this.pg12.TabIndex = 22;
            // 
            // pg11
            // 
            this.pg11.Location = new System.Drawing.Point(734, 389);
            this.pg11.Name = "pg11";
            this.pg11.Size = new System.Drawing.Size(116, 27);
            this.pg11.TabIndex = 21;
            // 
            // pg6
            // 
            this.pg6.Location = new System.Drawing.Point(734, 204);
            this.pg6.Name = "pg6";
            this.pg6.Size = new System.Drawing.Size(116, 27);
            this.pg6.TabIndex = 20;
            // 
            // pg5
            // 
            this.pg5.Location = new System.Drawing.Point(734, 167);
            this.pg5.Name = "pg5";
            this.pg5.Size = new System.Drawing.Size(116, 27);
            this.pg5.TabIndex = 19;
            // 
            // pg4
            // 
            this.pg4.Location = new System.Drawing.Point(734, 130);
            this.pg4.Name = "pg4";
            this.pg4.Size = new System.Drawing.Size(116, 27);
            this.pg4.TabIndex = 18;
            // 
            // pg3
            // 
            this.pg3.Location = new System.Drawing.Point(734, 93);
            this.pg3.Name = "pg3";
            this.pg3.Size = new System.Drawing.Size(116, 27);
            this.pg3.TabIndex = 17;
            // 
            // pg2
            // 
            this.pg2.Location = new System.Drawing.Point(734, 56);
            this.pg2.Name = "pg2";
            this.pg2.Size = new System.Drawing.Size(116, 27);
            this.pg2.TabIndex = 16;
            // 
            // pg1
            // 
            this.pg1.Location = new System.Drawing.Point(734, 19);
            this.pg1.Name = "pg1";
            this.pg1.Size = new System.Drawing.Size(116, 27);
            this.pg1.TabIndex = 15;
            // 
            // chk12
            // 
            this.chk12.AutoSize = true;
            this.chk12.Checked = true;
            this.chk12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chk12.Location = new System.Drawing.Point(441, 426);
            this.chk12.Name = "chk12";
            this.chk12.Size = new System.Drawing.Size(251, 24);
            this.chk12.TabIndex = 11;
            this.chk12.Text = "Verify upload finished successly";
            this.chk12.UseVisualStyleBackColor = true;
            // 
            // chk11
            // 
            this.chk11.AutoSize = true;
            this.chk11.Checked = true;
            this.chk11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chk11.Location = new System.Drawing.Point(441, 389);
            this.chk11.Name = "chk11";
            this.chk11.Size = new System.Drawing.Size(189, 24);
            this.chk11.TabIndex = 12;
            this.chk11.Text = "Upload revised to ebay";
            this.chk11.UseVisualStyleBackColor = true;
            // 
            // chk10
            // 
            this.chk10.AutoSize = true;
            this.chk10.Checked = true;
            this.chk10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chk10.Location = new System.Drawing.Point(441, 352);
            this.chk10.Name = "chk10";
            this.chk10.Size = new System.Drawing.Size(293, 24);
            this.chk10.TabIndex = 13;
            this.chk10.Text = "Optimize Images (watermark, collage)";
            this.chk10.UseVisualStyleBackColor = true;
            // 
            // chk9
            // 
            this.chk9.AutoSize = true;
            this.chk9.Enabled = false;
            this.chk9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chk9.Location = new System.Drawing.Point(441, 315);
            this.chk9.Name = "chk9";
            this.chk9.Size = new System.Drawing.Size(123, 24);
            this.chk9.TabIndex = 14;
            this.chk9.Text = "Optimize Title";
            this.chk9.UseVisualStyleBackColor = true;
            // 
            // chk8
            // 
            this.chk8.AutoSize = true;
            this.chk8.Checked = true;
            this.chk8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chk8.Location = new System.Drawing.Point(441, 278);
            this.chk8.Name = "chk8";
            this.chk8.Size = new System.Drawing.Size(156, 24);
            this.chk8.TabIndex = 10;
            this.chk8.Text = "Download Images";
            this.chk8.UseVisualStyleBackColor = true;
            // 
            // chk7
            // 
            this.chk7.AutoSize = true;
            this.chk7.Checked = true;
            this.chk7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chk7.Location = new System.Drawing.Point(441, 241);
            this.chk7.Name = "chk7";
            this.chk7.Size = new System.Drawing.Size(164, 24);
            this.chk7.TabIndex = 10;
            this.chk7.Text = "Import UPCs to DB";
            this.chk7.UseVisualStyleBackColor = true;
            // 
            // chk4
            // 
            this.chk4.AutoSize = true;
            this.chk4.Checked = true;
            this.chk4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chk4.Location = new System.Drawing.Point(441, 130);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(171, 24);
            this.chk4.TabIndex = 10;
            this.chk4.Text = "Import listings to DB";
            this.chk4.UseVisualStyleBackColor = true;
            // 
            // chk6
            // 
            this.chk6.AutoSize = true;
            this.chk6.Checked = true;
            this.chk6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chk6.Location = new System.Drawing.Point(441, 204);
            this.chk6.Name = "chk6";
            this.chk6.Size = new System.Drawing.Size(192, 24);
            this.chk6.TabIndex = 10;
            this.chk6.Text = "Download UPCs (ebay)";
            this.chk6.UseVisualStyleBackColor = true;
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Checked = true;
            this.chk3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chk3.Location = new System.Drawing.Point(441, 93);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(199, 24);
            this.chk3.TabIndex = 10;
            this.chk3.Text = "Download listings (ebay)";
            this.chk3.UseVisualStyleBackColor = true;
            // 
            // chk5
            // 
            this.chk5.AutoSize = true;
            this.chk5.Checked = true;
            this.chk5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chk5.Location = new System.Drawing.Point(441, 167);
            this.chk5.Name = "chk5";
            this.chk5.Size = new System.Drawing.Size(196, 24);
            this.chk5.TabIndex = 10;
            this.chk5.Text = "Prepare Download UPC";
            this.chk5.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Checked = true;
            this.chk2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chk2.Location = new System.Drawing.Point(441, 56);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(238, 24);
            this.chk2.TabIndex = 10;
            this.chk2.Text = "Prepare download ebay listing";
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Enabled = false;
            this.chk1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chk1.Location = new System.Drawing.Point(443, 19);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(212, 24);
            this.chk1.TabIndex = 10;
            this.chk1.Text = "Create Listing from ASINs";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel.Controls.Add(this.label11);
            this.panel.Controls.Add(this.btnStart);
            this.panel.Controls.Add(this.btnShowSettings);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(862, 67);
            this.panel.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.ForeColor = System.Drawing.Color.Indigo;
            this.label11.Location = new System.Drawing.Point(23, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 42);
            this.label11.TabIndex = 1;
            this.label11.Text = "RSBot";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Indigo;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(708, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(142, 41);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnShowSettings
            // 
            this.btnShowSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnShowSettings.ForeColor = System.Drawing.Color.Indigo;
            this.btnShowSettings.Location = new System.Drawing.Point(560, 13);
            this.btnShowSettings.Name = "btnShowSettings";
            this.btnShowSettings.Size = new System.Drawing.Size(142, 41);
            this.btnShowSettings.TabIndex = 0;
            this.btnShowSettings.Text = "Show Settings";
            this.btnShowSettings.UseVisualStyleBackColor = true;
            this.btnShowSettings.Click += new System.EventHandler(this.btnShowSettings_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 873);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.panel);
            this.Name = "Form";
            this.Text = "RSBot";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnOptimizeImages;
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
        private System.Windows.Forms.TextBox txtCloudinaryKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCloudinarySecret;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCloudinaryAppName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private Button btnShowSettings;
        private Label label11;
        private Button btnStart;
        private CheckBox chk12;
        private CheckBox chk11;
        private CheckBox chk10;
        private CheckBox chk9;
        private CheckBox chk8;
        private CheckBox chk7;
        private CheckBox chk4;
        private CheckBox chk6;
        private CheckBox chk3;
        private CheckBox chk5;
        private CheckBox chk2;
        private CheckBox chk1;
        private ProgressBar pg10;
        private ProgressBar pg9;
        private ProgressBar pg8;
        private ProgressBar pg7;
        private ProgressBar pg12;
        private ProgressBar pg11;
        private ProgressBar pg6;
        private ProgressBar pg5;
        private ProgressBar pg4;
        private ProgressBar pg3;
        private ProgressBar pg2;
        private ProgressBar pg1;
    }
}

