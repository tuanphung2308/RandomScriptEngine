﻿namespace Athena
{
	// Token: 0x0200001F RID: 31
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000088 RID: 136 RVA: 0x0000376C File Offset: 0x0000196C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000037A4 File Offset: 0x000019A4
		private void InitializeComponent()
		{
            this.ProcessSelect = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.scrPanel = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rejectRadio = new System.Windows.Forms.RadioButton();
            this.acceptRadio = new System.Windows.Forms.RadioButton();
            this.offFilterBtn = new System.Windows.Forms.Button();
            this.enFilterBtn = new System.Windows.Forms.Button();
            this.itemListTbx = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcessSelect
            // 
            this.ProcessSelect.FormattingEnabled = true;
            this.ProcessSelect.Location = new System.Drawing.Point(12, 589);
            this.ProcessSelect.Name = "ProcessSelect";
            this.ProcessSelect.Size = new System.Drawing.Size(375, 21);
            this.ProcessSelect.TabIndex = 15;
            this.ProcessSelect.Text = "Please Select A Process";
            this.ProcessSelect.DropDown += new System.EventHandler(this.ProcessSelect_DropDown);
            this.ProcessSelect.SelectedIndexChanged += new System.EventHandler(this.ProcessSelect_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(403, 582);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.scrPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(395, 556);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Scripts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // scrPanel
            // 
            this.scrPanel.Location = new System.Drawing.Point(1, 0);
            this.scrPanel.Name = "scrPanel";
            this.scrPanel.Size = new System.Drawing.Size(394, 556);
            this.scrPanel.TabIndex = 15;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rejectRadio);
            this.tabPage2.Controls.Add(this.acceptRadio);
            this.tabPage2.Controls.Add(this.offFilterBtn);
            this.tabPage2.Controls.Add(this.enFilterBtn);
            this.tabPage2.Controls.Add(this.itemListTbx);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(395, 556);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Item filter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rejectRadio
            // 
            this.rejectRadio.AutoSize = true;
            this.rejectRadio.Location = new System.Drawing.Point(201, 22);
            this.rejectRadio.Name = "rejectRadio";
            this.rejectRadio.Size = new System.Drawing.Size(56, 17);
            this.rejectRadio.TabIndex = 6;
            this.rejectRadio.TabStop = true;
            this.rejectRadio.Text = "Reject";
            this.rejectRadio.UseVisualStyleBackColor = true;
            this.rejectRadio.Click += new System.EventHandler(this.rejectRadio_CheckedChanged);
            // 
            // acceptRadio
            // 
            this.acceptRadio.AutoSize = true;
            this.acceptRadio.Location = new System.Drawing.Point(110, 22);
            this.acceptRadio.Name = "acceptRadio";
            this.acceptRadio.Size = new System.Drawing.Size(59, 17);
            this.acceptRadio.TabIndex = 5;
            this.acceptRadio.TabStop = true;
            this.acceptRadio.Text = "Accept";
            this.acceptRadio.UseVisualStyleBackColor = true;
            this.acceptRadio.Click += new System.EventHandler(this.acceptRadio_CheckedChanged);
            // 
            // offFilterBtn
            // 
            this.offFilterBtn.Location = new System.Drawing.Point(201, 530);
            this.offFilterBtn.Name = "offFilterBtn";
            this.offFilterBtn.Size = new System.Drawing.Size(188, 23);
            this.offFilterBtn.TabIndex = 2;
            this.offFilterBtn.Text = "Deactivate";
            this.offFilterBtn.UseVisualStyleBackColor = true;
            this.offFilterBtn.Click += new System.EventHandler(this.offFilterBtn_Click);
            // 
            // enFilterBtn
            // 
            this.enFilterBtn.Location = new System.Drawing.Point(9, 530);
            this.enFilterBtn.Name = "enFilterBtn";
            this.enFilterBtn.Size = new System.Drawing.Size(188, 23);
            this.enFilterBtn.TabIndex = 1;
            this.enFilterBtn.Text = "Activate";
            this.enFilterBtn.UseVisualStyleBackColor = true;
            this.enFilterBtn.Click += new System.EventHandler(this.enFilterBtn_Click);
            // 
            // itemListTbx
            // 
            this.itemListTbx.Location = new System.Drawing.Point(9, 45);
            this.itemListTbx.Multiline = true;
            this.itemListTbx.Name = "itemListTbx";
            this.itemListTbx.Size = new System.Drawing.Size(380, 479);
            this.itemListTbx.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(399, 622);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ProcessSelect);
            this.MaximumSize = new System.Drawing.Size(415, 661);
            this.MinimumSize = new System.Drawing.Size(415, 661);
            this.Name = "Form1";
            this.Text = "Athena Trainer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

		}

		// Token: 0x0400006E RID: 110
		private global::System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox ProcessSelect;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel scrPanel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button offFilterBtn;
        private System.Windows.Forms.Button enFilterBtn;
        private System.Windows.Forms.TextBox itemListTbx;
        private System.Windows.Forms.RadioButton acceptRadio;
        private System.Windows.Forms.RadioButton rejectRadio;
    }
}