﻿namespace CafmConnect.Samples
{
    partial class MainDLG
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._buttonCreateManufacturerData = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._buttonConsume = new System.Windows.Forms.Button();
            this._buttonViewer = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._dataGridViewManuProducts = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewManuProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._buttonCreateManufacturerData);
            this.groupBox1.Controls.Add(this._buttonViewer);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 406);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manufacturer";
            // 
            // _buttonCreateManufacturerData
            // 
            this._buttonCreateManufacturerData.Dock = System.Windows.Forms.DockStyle.Top;
            this._buttonCreateManufacturerData.Location = new System.Drawing.Point(3, 39);
            this._buttonCreateManufacturerData.Name = "_buttonCreateManufacturerData";
            this._buttonCreateManufacturerData.Size = new System.Drawing.Size(312, 23);
            this._buttonCreateManufacturerData.TabIndex = 0;
            this._buttonCreateManufacturerData.Text = "Create Manufacturer Data";
            this._buttonCreateManufacturerData.UseVisualStyleBackColor = true;
            this._buttonCreateManufacturerData.Click += new System.EventHandler(this._buttonCreateManufacturerData_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._dataGridViewManuProducts);
            this.groupBox2.Controls.Add(this._buttonConsume);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 406);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer";
            // 
            // _buttonConsume
            // 
            this._buttonConsume.Dock = System.Windows.Forms.DockStyle.Top;
            this._buttonConsume.Location = new System.Drawing.Point(3, 16);
            this._buttonConsume.Name = "_buttonConsume";
            this._buttonConsume.Size = new System.Drawing.Size(321, 23);
            this._buttonConsume.TabIndex = 0;
            this._buttonConsume.Text = "Consume Manufacturer Data";
            this._buttonConsume.UseVisualStyleBackColor = true;
            this._buttonConsume.Click += new System.EventHandler(this._buttonConsume_Click);
            // 
            // _buttonViewer
            // 
            this._buttonViewer.Dock = System.Windows.Forms.DockStyle.Top;
            this._buttonViewer.Location = new System.Drawing.Point(3, 16);
            this._buttonViewer.Name = "_buttonViewer";
            this._buttonViewer.Size = new System.Drawing.Size(312, 23);
            this._buttonViewer.TabIndex = 1;
            this._buttonViewer.Text = "StartViewer";
            this._buttonViewer.UseVisualStyleBackColor = true;
            this._buttonViewer.Click += new System.EventHandler(this._buttonViewer_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(649, 406);
            this.splitContainer1.SplitterDistance = 318;
            this.splitContainer1.TabIndex = 2;
            // 
            // _dataGridViewManuProducts
            // 
            this._dataGridViewManuProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this._dataGridViewManuProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewManuProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridViewManuProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this._dataGridViewManuProducts.Location = new System.Drawing.Point(3, 39);
            this._dataGridViewManuProducts.MultiSelect = false;
            this._dataGridViewManuProducts.Name = "_dataGridViewManuProducts";
            this._dataGridViewManuProducts.ReadOnly = true;
            this._dataGridViewManuProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dataGridViewManuProducts.Size = new System.Drawing.Size(321, 364);
            this._dataGridViewManuProducts.TabIndex = 1;
            // 
            // MainDLG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 406);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainDLG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CafmConnect Samples";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewManuProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button _buttonCreateManufacturerData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button _buttonConsume;
        private System.Windows.Forms.Button _buttonViewer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView _dataGridViewManuProducts;
    }
}