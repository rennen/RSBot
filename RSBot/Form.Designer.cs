﻿using System.Windows.Forms;

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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.settingsGrid = new System.Windows.Forms.PropertyGrid();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.stepCreateListings = new RSBot.StepControl();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.stepPrepareListingDownload = new RSBot.StepControl();
            this.label1 = new System.Windows.Forms.Label();
            this.stepWaitForListingDownload = new RSBot.StepControl();
            this.stepPrepareUpcDownload = new RSBot.StepControl();
            this.stepWaitUpcFile = new RSBot.StepControl();
            this.stepImportListings = new RSBot.StepControl();
            this.stepDownloadUpc = new RSBot.StepControl();
            this.stepDownloadListing = new RSBot.StepControl();
            this.stepImportUpcs = new RSBot.StepControl();
            this.stepUploadVerify = new RSBot.StepControl();
            this.stepOptimizeImages = new RSBot.StepControl();
            this.stepDownloadVerificationForUpload = new RSBot.StepControl();
            this.stepOptimizeTitles = new RSBot.StepControl();
            this.stepWaitForUpload = new RSBot.StepControl();
            this.stepPrepareRevisedFile = new RSBot.StepControl();
            this.stepUploadRevised = new RSBot.StepControl();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.labelElapsed = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnShowSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 67);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.AutoScroll = true;
            this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer.Panel1.Controls.Add(this.settingsGrid);
            this.splitContainer.Panel1Collapsed = true;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.AutoScroll = true;
            this.splitContainer.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer.Size = new System.Drawing.Size(911, 806);
            this.splitContainer.SplitterDistance = 267;
            this.splitContainer.TabIndex = 12;
            // 
            // settingsGrid
            // 
            this.settingsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.settingsGrid.HelpVisible = false;
            this.settingsGrid.Location = new System.Drawing.Point(0, 0);
            this.settingsGrid.Name = "settingsGrid";
            this.settingsGrid.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.settingsGrid.Size = new System.Drawing.Size(150, 267);
            this.settingsGrid.TabIndex = 7;
            this.settingsGrid.ToolbarVisible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.stepCreateListings);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabel2);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.stepPrepareListingDownload);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.stepWaitForListingDownload);
            this.splitContainer1.Panel1.Controls.Add(this.stepPrepareUpcDownload);
            this.splitContainer1.Panel1.Controls.Add(this.stepWaitUpcFile);
            this.splitContainer1.Panel1.Controls.Add(this.stepImportListings);
            this.splitContainer1.Panel1.Controls.Add(this.stepDownloadUpc);
            this.splitContainer1.Panel1.Controls.Add(this.stepDownloadListing);
            this.splitContainer1.Panel1.Controls.Add(this.stepImportUpcs);
            this.splitContainer1.Panel1.Controls.Add(this.stepUploadVerify);
            this.splitContainer1.Panel1.Controls.Add(this.stepOptimizeImages);
            this.splitContainer1.Panel1.Controls.Add(this.stepDownloadVerificationForUpload);
            this.splitContainer1.Panel1.Controls.Add(this.stepOptimizeTitles);
            this.splitContainer1.Panel1.Controls.Add(this.stepWaitForUpload);
            this.splitContainer1.Panel1.Controls.Add(this.stepPrepareRevisedFile);
            this.splitContainer1.Panel1.Controls.Add(this.stepUploadRevised);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtLog);
            this.splitContainer1.Size = new System.Drawing.Size(911, 806);
            this.splitContainer1.SplitterDistance = 654;
            this.splitContainer1.TabIndex = 29;
            // 
            // stepCreateListings
            // 
            this.stepCreateListings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepCreateListings.Checked = false;
            this.stepCreateListings.Description = "Create Listings from ASINs";
            this.stepCreateListings.Enabled = false;
            this.stepCreateListings.Location = new System.Drawing.Point(3, 49);
            this.stepCreateListings.Name = "stepCreateListings";
            this.stepCreateListings.ProgressBarValue = 0;
            this.stepCreateListings.Size = new System.Drawing.Size(898, 20);
            this.stepCreateListings.TabIndex = 27;
            this.stepCreateListings.OnError += new RSBot.StepControl.dlgReport(this.OnError);
            this.stepCreateListings.OnWarning += new RSBot.StepControl.dlgReport(this.OnWarning);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(3, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Upload Revised";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.linkLabel1.Location = new System.Drawing.Point(716, 15);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(75, 20);
            this.linkLabel1.TabIndex = 25;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Select All";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.selectAll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(-1, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Download Optimize";
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.linkLabel2.Location = new System.Drawing.Point(797, 15);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(96, 20);
            this.linkLabel2.TabIndex = 26;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Select None";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.selectNone_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(-1, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Download UPCs";
            // 
            // stepPrepareListingDownload
            // 
            this.stepPrepareListingDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepPrepareListingDownload.Checked = true;
            this.stepPrepareListingDownload.Description = "Prepare listings file for download";
            this.stepPrepareListingDownload.Location = new System.Drawing.Point(3, 111);
            this.stepPrepareListingDownload.Name = "stepPrepareListingDownload";
            this.stepPrepareListingDownload.ProgressBarValue = 0;
            this.stepPrepareListingDownload.Size = new System.Drawing.Size(898, 20);
            this.stepPrepareListingDownload.TabIndex = 27;
            this.stepPrepareListingDownload.OnError += new RSBot.StepControl.dlgReport(this.OnError);
            this.stepPrepareListingDownload.OnWarning += new RSBot.StepControl.dlgReport(this.OnWarning);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(-1, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Download Listings";
            // 
            // stepWaitForListingDownload
            // 
            this.stepWaitForListingDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepWaitForListingDownload.Checked = true;
            this.stepWaitForListingDownload.Description = "Wait for listing file to be ready";
            this.stepWaitForListingDownload.Location = new System.Drawing.Point(3, 137);
            this.stepWaitForListingDownload.Name = "stepWaitForListingDownload";
            this.stepWaitForListingDownload.ProgressBarValue = 0;
            this.stepWaitForListingDownload.Size = new System.Drawing.Size(898, 20);
            this.stepWaitForListingDownload.TabIndex = 27;
            this.stepWaitForListingDownload.OnError += new RSBot.StepControl.dlgReport(this.OnError);
            this.stepWaitForListingDownload.OnWarning += new RSBot.StepControl.dlgReport(this.OnWarning);
            // 
            // stepPrepareUpcDownload
            // 
            this.stepPrepareUpcDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepPrepareUpcDownload.Checked = true;
            this.stepPrepareUpcDownload.Description = "Prepare UPCs file";
            this.stepPrepareUpcDownload.Location = new System.Drawing.Point(3, 250);
            this.stepPrepareUpcDownload.Name = "stepPrepareUpcDownload";
            this.stepPrepareUpcDownload.ProgressBarValue = 0;
            this.stepPrepareUpcDownload.Size = new System.Drawing.Size(898, 20);
            this.stepPrepareUpcDownload.TabIndex = 27;
            this.stepPrepareUpcDownload.OnError += new RSBot.StepControl.dlgReport(this.OnError);
            this.stepPrepareUpcDownload.OnWarning += new RSBot.StepControl.dlgReport(this.OnWarning);
            // 
            // stepWaitUpcFile
            // 
            this.stepWaitUpcFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepWaitUpcFile.Checked = true;
            this.stepWaitUpcFile.Description = "Wait for UPC file to be ready";
            this.stepWaitUpcFile.Location = new System.Drawing.Point(3, 276);
            this.stepWaitUpcFile.Name = "stepWaitUpcFile";
            this.stepWaitUpcFile.ProgressBarValue = 0;
            this.stepWaitUpcFile.Size = new System.Drawing.Size(898, 20);
            this.stepWaitUpcFile.TabIndex = 27;
            this.stepWaitUpcFile.OnError += new RSBot.StepControl.dlgReport(this.OnError);
            this.stepWaitUpcFile.OnWarning += new RSBot.StepControl.dlgReport(this.OnWarning);
            // 
            // stepImportListings
            // 
            this.stepImportListings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepImportListings.Checked = true;
            this.stepImportListings.Description = "Import listings to DB";
            this.stepImportListings.Location = new System.Drawing.Point(3, 189);
            this.stepImportListings.Name = "stepImportListings";
            this.stepImportListings.ProgressBarValue = 0;
            this.stepImportListings.Size = new System.Drawing.Size(898, 20);
            this.stepImportListings.TabIndex = 27;
            this.stepImportListings.OnError += new RSBot.StepControl.dlgReport(this.OnError);
            this.stepImportListings.OnWarning += new RSBot.StepControl.dlgReport(this.OnWarning);
            // 
            // stepDownloadUpc
            // 
            this.stepDownloadUpc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepDownloadUpc.Checked = true;
            this.stepDownloadUpc.Description = "Download UPC file";
            this.stepDownloadUpc.Location = new System.Drawing.Point(3, 302);
            this.stepDownloadUpc.Name = "stepDownloadUpc";
            this.stepDownloadUpc.ProgressBarValue = 0;
            this.stepDownloadUpc.Size = new System.Drawing.Size(898, 20);
            this.stepDownloadUpc.TabIndex = 27;
            this.stepDownloadUpc.OnError += new RSBot.StepControl.dlgReport(this.OnError);
            this.stepDownloadUpc.OnWarning += new RSBot.StepControl.dlgReport(this.OnWarning);
            // 
            // stepDownloadListing
            // 
            this.stepDownloadListing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepDownloadListing.Checked = true;
            this.stepDownloadListing.Description = "Download listings file";
            this.stepDownloadListing.Location = new System.Drawing.Point(3, 163);
            this.stepDownloadListing.Name = "stepDownloadListing";
            this.stepDownloadListing.ProgressBarValue = 0;
            this.stepDownloadListing.Size = new System.Drawing.Size(898, 20);
            this.stepDownloadListing.TabIndex = 27;
            this.stepDownloadListing.OnError += new RSBot.StepControl.dlgReport(this.OnError);
            this.stepDownloadListing.OnWarning += new RSBot.StepControl.dlgReport(this.OnWarning);
            // 
            // stepImportUpcs
            // 
            this.stepImportUpcs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepImportUpcs.Checked = true;
            this.stepImportUpcs.Description = "Import UPC file";
            this.stepImportUpcs.Location = new System.Drawing.Point(3, 328);
            this.stepImportUpcs.Name = "stepImportUpcs";
            this.stepImportUpcs.ProgressBarValue = 0;
            this.stepImportUpcs.Size = new System.Drawing.Size(898, 20);
            this.stepImportUpcs.TabIndex = 27;
            this.stepImportUpcs.OnError += new RSBot.StepControl.dlgReport(this.OnError);
            this.stepImportUpcs.OnWarning += new RSBot.StepControl.dlgReport(this.OnWarning);
            // 
            // stepUploadVerify
            // 
            this.stepUploadVerify.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepUploadVerify.Checked = true;
            this.stepUploadVerify.Description = "Verify upload processed without errors";
            this.stepUploadVerify.Location = new System.Drawing.Point(3, 586);
            this.stepUploadVerify.Name = "stepUploadVerify";
            this.stepUploadVerify.ProgressBarValue = 0;
            this.stepUploadVerify.Size = new System.Drawing.Size(898, 20);
            this.stepUploadVerify.TabIndex = 27;
            this.stepUploadVerify.OnError += new RSBot.StepControl.dlgReport(this.OnError);
            this.stepUploadVerify.OnWarning += new RSBot.StepControl.dlgReport(this.OnWarning);
            // 
            // stepOptimizeImages
            // 
            this.stepOptimizeImages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepOptimizeImages.Checked = true;
            this.stepOptimizeImages.Description = "Download images from Amazon and Optimize";
            this.stepOptimizeImages.Location = new System.Drawing.Point(3, 392);
            this.stepOptimizeImages.Name = "stepOptimizeImages";
            this.stepOptimizeImages.ProgressBarValue = 0;
            this.stepOptimizeImages.Size = new System.Drawing.Size(898, 20);
            this.stepOptimizeImages.TabIndex = 27;
            this.stepOptimizeImages.OnError += new RSBot.StepControl.dlgReport(this.OnError);
            this.stepOptimizeImages.OnWarning += new RSBot.StepControl.dlgReport(this.OnWarning);
            // 
            // stepDownloadVerificationForUpload
            // 
            this.stepDownloadVerificationForUpload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepDownloadVerificationForUpload.Checked = true;
            this.stepDownloadVerificationForUpload.Description = "Download verification for the upload";
            this.stepDownloadVerificationForUpload.Location = new System.Drawing.Point(3, 560);
            this.stepDownloadVerificationForUpload.Name = "stepDownloadVerificationForUpload";
            this.stepDownloadVerificationForUpload.ProgressBarValue = 0;
            this.stepDownloadVerificationForUpload.Size = new System.Drawing.Size(898, 20);
            this.stepDownloadVerificationForUpload.TabIndex = 27;
            this.stepDownloadVerificationForUpload.OnError += new RSBot.StepControl.dlgReport(this.OnError);
            this.stepDownloadVerificationForUpload.OnWarning += new RSBot.StepControl.dlgReport(this.OnWarning);
            // 
            // stepOptimizeTitles
            // 
            this.stepOptimizeTitles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepOptimizeTitles.Checked = false;
            this.stepOptimizeTitles.Description = "Optimize Titles";
            this.stepOptimizeTitles.Location = new System.Drawing.Point(3, 418);
            this.stepOptimizeTitles.Name = "stepOptimizeTitles";
            this.stepOptimizeTitles.ProgressBarValue = 0;
            this.stepOptimizeTitles.Size = new System.Drawing.Size(898, 20);
            this.stepOptimizeTitles.TabIndex = 27;
            this.stepOptimizeTitles.OnError += new RSBot.StepControl.dlgReport(this.OnError);
            this.stepOptimizeTitles.OnWarning += new RSBot.StepControl.dlgReport(this.OnWarning);
            // 
            // stepWaitForUpload
            // 
            this.stepWaitForUpload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepWaitForUpload.Checked = true;
            this.stepWaitForUpload.Description = "Wait For Upload";
            this.stepWaitForUpload.Location = new System.Drawing.Point(3, 534);
            this.stepWaitForUpload.Name = "stepWaitForUpload";
            this.stepWaitForUpload.ProgressBarValue = 0;
            this.stepWaitForUpload.Size = new System.Drawing.Size(898, 20);
            this.stepWaitForUpload.TabIndex = 27;
            this.stepWaitForUpload.OnError += new RSBot.StepControl.dlgReport(this.OnError);
            this.stepWaitForUpload.OnWarning += new RSBot.StepControl.dlgReport(this.OnWarning);
            // 
            // stepPrepareRevisedFile
            // 
            this.stepPrepareRevisedFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepPrepareRevisedFile.Checked = true;
            this.stepPrepareRevisedFile.Description = "Prepare Revised file";
            this.stepPrepareRevisedFile.Location = new System.Drawing.Point(3, 482);
            this.stepPrepareRevisedFile.Name = "stepPrepareRevisedFile";
            this.stepPrepareRevisedFile.ProgressBarValue = 0;
            this.stepPrepareRevisedFile.Size = new System.Drawing.Size(898, 20);
            this.stepPrepareRevisedFile.TabIndex = 27;
            this.stepPrepareRevisedFile.OnError += new RSBot.StepControl.dlgReport(this.OnError);
            this.stepPrepareRevisedFile.OnWarning += new RSBot.StepControl.dlgReport(this.OnWarning);
            // 
            // stepUploadRevised
            // 
            this.stepUploadRevised.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepUploadRevised.Checked = true;
            this.stepUploadRevised.Description = "Upload Revised file";
            this.stepUploadRevised.Location = new System.Drawing.Point(3, 508);
            this.stepUploadRevised.Name = "stepUploadRevised";
            this.stepUploadRevised.ProgressBarValue = 0;
            this.stepUploadRevised.Size = new System.Drawing.Size(898, 20);
            this.stepUploadRevised.TabIndex = 27;
            this.stepUploadRevised.OnError += new RSBot.StepControl.dlgReport(this.OnError);
            this.stepUploadRevised.OnWarning += new RSBot.StepControl.dlgReport(this.OnWarning);
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(911, 148);
            this.txtLog.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.labelElapsed);
            this.panel.Controls.Add(this.label11);
            this.panel.Controls.Add(this.btnStart);
            this.panel.Controls.Add(this.btnShowSettings);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(911, 67);
            this.panel.TabIndex = 8;
            // 
            // labelElapsed
            // 
            this.labelElapsed.AutoSize = true;
            this.labelElapsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelElapsed.Location = new System.Drawing.Point(388, 19);
            this.labelElapsed.Name = "labelElapsed";
            this.labelElapsed.Size = new System.Drawing.Size(0, 25);
            this.labelElapsed.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Indigo;
            this.label11.Location = new System.Drawing.Point(23, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 42);
            this.label11.TabIndex = 1;
            this.label11.Text = "RSBot";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.Indigo;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(757, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(142, 41);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Run";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnShowSettings
            // 
            this.btnShowSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnShowSettings.ForeColor = System.Drawing.Color.Indigo;
            this.btnShowSettings.Location = new System.Drawing.Point(609, 13);
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
            this.ClientSize = new System.Drawing.Size(911, 873);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.panel);
            this.Name = "Form";
            this.Text = "RSBot";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private Button btnShowSettings;
        private Label label11;
        private Button btnStart;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        public PropertyGrid settingsGrid;
        private StepControl stepPrepareListingDownload;
        private StepControl stepWaitForListingDownload;
        private StepControl stepDownloadListing;
        private StepControl stepImportListings;
        private StepControl stepPrepareUpcDownload;
        private StepControl stepDownloadUpc;
        private StepControl stepWaitUpcFile;
        private StepControl stepImportUpcs;
        private StepControl stepCreateListings;
        private StepControl stepOptimizeTitles;
        private StepControl stepOptimizeImages;
        private StepControl stepUploadRevised;
        private StepControl stepPrepareRevisedFile;
        private StepControl stepUploadVerify;
        private StepControl stepDownloadVerificationForUpload;
        private Label label3;
        private Label label2;
        private Label label1;
        private StepControl stepWaitForUpload;
        private Label labelElapsed;
        private Label label4;
        private SplitContainer splitContainer1;
        private TextBox txtLog;
    }
}

