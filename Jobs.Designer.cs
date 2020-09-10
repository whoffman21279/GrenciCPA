﻿namespace GrenciCPA
{
    partial class Jobs
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.cbxToInvoice = new System.Windows.Forms.CheckBox();
            this.cbxUnassigned = new System.Windows.Forms.CheckBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.cbxProgress = new System.Windows.Forms.CheckBox();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParentClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catagory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Invoice = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(893, 462);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(132, 57);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(438, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 37);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(12, 16);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 22);
            this.tbxSearch.TabIndex = 12;
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AllowUserToOrderColumns = true;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.Company,
            this.ParentClient,
            this.Catagory,
            this.Service,
            this.Staff,
            this.View,
            this.Invoice});
            this.dgvClients.Location = new System.Drawing.Point(12, 59);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersWidth = 51;
            this.dgvClients.RowTemplate.Height = 24;
            this.dgvClients.Size = new System.Drawing.Size(1013, 372);
            this.dgvClients.TabIndex = 11;
            // 
            // cbxToInvoice
            // 
            this.cbxToInvoice.AutoSize = true;
            this.cbxToInvoice.Checked = true;
            this.cbxToInvoice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxToInvoice.Location = new System.Drawing.Point(229, 18);
            this.cbxToInvoice.Name = "cbxToInvoice";
            this.cbxToInvoice.Size = new System.Drawing.Size(95, 21);
            this.cbxToInvoice.TabIndex = 16;
            this.cbxToInvoice.Text = "To Invoice";
            this.cbxToInvoice.UseVisualStyleBackColor = true;
            // 
            // cbxUnassigned
            // 
            this.cbxUnassigned.AutoSize = true;
            this.cbxUnassigned.Checked = true;
            this.cbxUnassigned.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxUnassigned.Location = new System.Drawing.Point(118, 17);
            this.cbxUnassigned.Name = "cbxUnassigned";
            this.cbxUnassigned.Size = new System.Drawing.Size(105, 21);
            this.cbxUnassigned.TabIndex = 17;
            this.cbxUnassigned.Text = "Unassigned";
            this.cbxUnassigned.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(766, 462);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(121, 57);
            this.btnSelect.TabIndex = 18;
            this.btnSelect.Text = "Take To Job Screen";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // cbxProgress
            // 
            this.cbxProgress.AutoSize = true;
            this.cbxProgress.Checked = true;
            this.cbxProgress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxProgress.Location = new System.Drawing.Point(330, 18);
            this.cbxProgress.Name = "cbxProgress";
            this.cbxProgress.Size = new System.Drawing.Size(102, 21);
            this.cbxProgress.TabIndex = 19;
            this.cbxProgress.Text = "In Progress";
            this.cbxProgress.UseVisualStyleBackColor = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 125;
            // 
            // Company
            // 
            this.Company.HeaderText = "Company";
            this.Company.MinimumWidth = 6;
            this.Company.Name = "Company";
            this.Company.ReadOnly = true;
            this.Company.Width = 125;
            // 
            // ParentClient
            // 
            this.ParentClient.HeaderText = "Parent Client";
            this.ParentClient.MinimumWidth = 6;
            this.ParentClient.Name = "ParentClient";
            this.ParentClient.ReadOnly = true;
            this.ParentClient.Width = 125;
            // 
            // Catagory
            // 
            this.Catagory.HeaderText = "Catagory";
            this.Catagory.MinimumWidth = 6;
            this.Catagory.Name = "Catagory";
            this.Catagory.ReadOnly = true;
            this.Catagory.Width = 80;
            // 
            // Service
            // 
            this.Service.HeaderText = "Service";
            this.Service.MinimumWidth = 6;
            this.Service.Name = "Service";
            this.Service.ReadOnly = true;
            this.Service.Width = 80;
            // 
            // Staff
            // 
            this.Staff.HeaderText = "Staff";
            this.Staff.MinimumWidth = 6;
            this.Staff.Name = "Staff";
            this.Staff.ReadOnly = true;
            this.Staff.Width = 90;
            // 
            // View
            // 
            this.View.HeaderText = "View Job";
            this.View.MinimumWidth = 6;
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.View.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.View.Width = 70;
            // 
            // Invoice
            // 
            this.Invoice.HeaderText = "Invoice";
            this.Invoice.MinimumWidth = 6;
            this.Invoice.Name = "Invoice";
            this.Invoice.ReadOnly = true;
            this.Invoice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Invoice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Invoice.Width = 70;
            // 
            // Jobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 530);
            this.Controls.Add(this.cbxProgress);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cbxUnassigned);
            this.Controls.Add(this.cbxToInvoice);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.dgvClients);
            this.Name = "Jobs";
            this.Text = "Jobs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.CheckBox cbxToInvoice;
        private System.Windows.Forms.CheckBox cbxUnassigned;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.CheckBox cbxProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParentClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catagory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff;
        private System.Windows.Forms.DataGridViewButtonColumn View;
        private System.Windows.Forms.DataGridViewButtonColumn Invoice;
    }
}