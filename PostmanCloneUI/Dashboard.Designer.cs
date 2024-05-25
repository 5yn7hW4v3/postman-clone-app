namespace PostmanCloneUI
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHeader = new Label();
            lblAPI = new Label();
            txtAPI = new TextBox();
            btnAPI = new Button();
            txtResults = new TextBox();
            statusStrip1 = new StatusStrip();
            lblSystemStatus = new ToolStripStatusLabel();
            lblResults = new Label();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.Anchor = AnchorStyles.Top;
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(164, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(317, 60);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Postman Clone";
            // 
            // lblAPI
            // 
            lblAPI.AutoSize = true;
            lblAPI.Location = new Point(12, 107);
            lblAPI.Name = "lblAPI";
            lblAPI.Size = new Size(69, 41);
            lblAPI.TabIndex = 1;
            lblAPI.Text = "API:";
            // 
            // txtAPI
            // 
            txtAPI.BorderStyle = BorderStyle.FixedSingle;
            txtAPI.Location = new Point(87, 107);
            txtAPI.Name = "txtAPI";
            txtAPI.Size = new Size(463, 47);
            txtAPI.TabIndex = 2;
            // 
            // btnAPI
            // 
            btnAPI.Location = new Point(556, 107);
            btnAPI.Name = "btnAPI";
            btnAPI.Size = new Size(73, 47);
            btnAPI.TabIndex = 3;
            btnAPI.Text = "Go";
            btnAPI.UseVisualStyleBackColor = true;
            btnAPI.Click += btnAPI_Click;
            // 
            // txtResults
            // 
            txtResults.BackColor = Color.White;
            txtResults.BorderStyle = BorderStyle.FixedSingle;
            txtResults.Location = new Point(12, 211);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.ReadOnly = true;
            txtResults.ScrollBars = ScrollBars.Both;
            txtResults.Size = new Size(617, 375);
            txtResults.TabIndex = 4;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblSystemStatus });
            statusStrip1.Location = new Point(0, 589);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(641, 29);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblSystemStatus
            // 
            lblSystemStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSystemStatus.Name = "lblSystemStatus";
            lblSystemStatus.Size = new Size(56, 23);
            lblSystemStatus.Text = "Ready";
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(12, 167);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(118, 41);
            lblResults.TabIndex = 6;
            lblResults.Text = "Results:";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(641, 618);
            Controls.Add(lblResults);
            Controls.Add(statusStrip1);
            Controls.Add(txtResults);
            Controls.Add(btnAPI);
            Controls.Add(txtAPI);
            Controls.Add(lblAPI);
            Controls.Add(lblHeader);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            MaximumSize = new Size(659, 665);
            MinimumSize = new Size(659, 665);
            Name = "Dashboard";
            Text = "Postman Clone";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblAPI;
        private TextBox txtAPI;
        private Button btnAPI;
        private TextBox txtResults;
        private StatusStrip statusStrip1;
        private Label lblResults;
        private ToolStripStatusLabel lblSystemStatus;
    }
}
