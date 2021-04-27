namespace CefSharp.MinimalExample.WinForms
{
    partial class FormMain
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.containerSearchWordResult = new System.Windows.Forms.ToolStripContainer();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.panelWriter = new System.Windows.Forms.Panel();
            this.containerSearchContextResult = new System.Windows.Forms.ToolStripContainer();
            this.btnCheckGrammarly = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.containerSearchWordResult.SuspendLayout();
            this.panelWriter.SuspendLayout();
            this.containerSearchContextResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(1350, 761);
            this.splitContainer1.SplitterDistance = 960;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.containerSearchWordResult);
            this.panel1.Location = new System.Drawing.Point(950, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 760);
            this.panel1.TabIndex = 1;
            // 
            // containerSearchWordResult
            // 
            this.containerSearchWordResult.BottomToolStripPanelVisible = false;
            // 
            // containerSearchWordResult.ContentPanel
            // 
            this.containerSearchWordResult.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.containerSearchWordResult.ContentPanel.Size = new System.Drawing.Size(397, 760);
            this.containerSearchWordResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerSearchWordResult.LeftToolStripPanelVisible = false;
            this.containerSearchWordResult.Location = new System.Drawing.Point(0, 0);
            this.containerSearchWordResult.Name = "containerSearchWordResult";
            this.containerSearchWordResult.RightToolStripPanelVisible = false;
            this.containerSearchWordResult.Size = new System.Drawing.Size(397, 760);
            this.containerSearchWordResult.TabIndex = 0;
            this.containerSearchWordResult.Text = "toolStripContainer2";
            this.containerSearchWordResult.TopToolStripPanelVisible = false;
            // 
            // txtEditor
            // 
            this.txtEditor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditor.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditor.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEditor.Location = new System.Drawing.Point(66, 83);
            this.txtEditor.Multiline = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(359, 648);
            this.txtEditor.TabIndex = 0;
            this.txtEditor.Text = "what is this?\r\nok, but I need to go home now, I will try to figure it out later t" +
    "oday\r\n\r\nI found an issue about sessionStorage not stored between tabs\r\nno, just " +
    "on is open";
            // 
            // panelWriter
            // 
            this.panelWriter.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelWriter.Controls.Add(this.containerSearchContextResult);
            this.panelWriter.Controls.Add(this.btnCheckGrammarly);
            this.panelWriter.Controls.Add(this.txtEditor);
            this.panelWriter.Location = new System.Drawing.Point(0, 0);
            this.panelWriter.Name = "panelWriter";
            this.panelWriter.Size = new System.Drawing.Size(957, 760);
            this.panelWriter.TabIndex = 2;
            // 
            // containerSearchContextResult
            // 
            this.containerSearchContextResult.BottomToolStripPanelVisible = false;
            // 
            // containerSearchContextResult.ContentPanel
            // 
            this.containerSearchContextResult.ContentPanel.Size = new System.Drawing.Size(523, 761);
            this.containerSearchContextResult.LeftToolStripPanelVisible = false;
            this.containerSearchContextResult.Location = new System.Drawing.Point(431, 0);
            this.containerSearchContextResult.Name = "containerSearchContextResult";
            this.containerSearchContextResult.RightToolStripPanelVisible = false;
            this.containerSearchContextResult.Size = new System.Drawing.Size(523, 761);
            this.containerSearchContextResult.TabIndex = 4;
            this.containerSearchContextResult.Text = "toolStripContainer1";
            this.containerSearchContextResult.TopToolStripPanelVisible = false;
            // 
            // btnCheckGrammarly
            // 
            this.btnCheckGrammarly.Location = new System.Drawing.Point(12, 12);
            this.btnCheckGrammarly.Name = "btnCheckGrammarly";
            this.btnCheckGrammarly.Size = new System.Drawing.Size(130, 23);
            this.btnCheckGrammarly.TabIndex = 1;
            this.btnCheckGrammarly.Text = "Check Grammarly";
            this.btnCheckGrammarly.UseVisualStyleBackColor = true;
            this.btnCheckGrammarly.Click += new System.EventHandler(this.btnCheckGrammarly_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 761);
            this.Controls.Add(this.panelWriter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.containerSearchWordResult.ResumeLayout(false);
            this.containerSearchWordResult.PerformLayout();
            this.panelWriter.ResumeLayout(false);
            this.panelWriter.PerformLayout();
            this.containerSearchContextResult.ResumeLayout(false);
            this.containerSearchContextResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEditor;
        private System.Windows.Forms.Panel panelWriter;
        private System.Windows.Forms.Button btnCheckGrammarly;
        private System.Windows.Forms.ToolStripContainer containerSearchWordResult;
        private System.Windows.Forms.ToolStripContainer containerSearchContextResult;
    }
}