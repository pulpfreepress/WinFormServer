namespace WinFormServer
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._statusTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._connectedClientsLabel = new System.Windows.Forms.Label();
            this._connectedClientsTextBox = new System.Windows.Forms.TextBox();
            this._sendCommandButton = new System.Windows.Forms.Button();
            this._clientCommandTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this._stopServerButton = new System.Windows.Forms.Button();
            this._startServerButton = new System.Windows.Forms.Button();
            this._portLabel = new System.Windows.Forms.Label();
            this._portTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanel1.Controls.Add(this._statusTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _statusTextBox
            // 
            this._statusTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._statusTextBox.Location = new System.Drawing.Point(3, 3);
            this._statusTextBox.Multiline = true;
            this._statusTextBox.Name = "_statusTextBox";
            this._statusTextBox.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this._statusTextBox, 2);
            this._statusTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._statusTextBox.Size = new System.Drawing.Size(490, 444);
            this._statusTextBox.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this._connectedClientsLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this._connectedClientsTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this._sendCommandButton, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this._clientCommandTextBox, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(499, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(298, 219);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // _connectedClientsLabel
            // 
            this._connectedClientsLabel.AutoSize = true;
            this._connectedClientsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._connectedClientsLabel.Location = new System.Drawing.Point(3, 0);
            this._connectedClientsLabel.Name = "_connectedClientsLabel";
            this._connectedClientsLabel.Size = new System.Drawing.Size(143, 22);
            this._connectedClientsLabel.TabIndex = 0;
            this._connectedClientsLabel.Text = "Connected Clients:";
            this._connectedClientsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _connectedClientsTextBox
            // 
            this._connectedClientsTextBox.CausesValidation = false;
            this._connectedClientsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._connectedClientsTextBox.Location = new System.Drawing.Point(152, 3);
            this._connectedClientsTextBox.Name = "_connectedClientsTextBox";
            this._connectedClientsTextBox.ReadOnly = true;
            this._connectedClientsTextBox.Size = new System.Drawing.Size(143, 20);
            this._connectedClientsTextBox.TabIndex = 1;
            this._connectedClientsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _sendCommandButton
            // 
            this._sendCommandButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sendCommandButton.Location = new System.Drawing.Point(152, 179);
            this._sendCommandButton.Name = "_sendCommandButton";
            this._sendCommandButton.Size = new System.Drawing.Size(143, 37);
            this._sendCommandButton.TabIndex = 2;
            this._sendCommandButton.Text = "Send Command";
            this._sendCommandButton.UseVisualStyleBackColor = true;
            this._sendCommandButton.Click += new System.EventHandler(this.SendCommandButtonHandler);
            // 
            // _clientCommandTextBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this._clientCommandTextBox, 2);
            this._clientCommandTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._clientCommandTextBox.Location = new System.Drawing.Point(3, 113);
            this._clientCommandTextBox.Multiline = true;
            this._clientCommandTextBox.Name = "_clientCommandTextBox";
            this._clientCommandTextBox.Size = new System.Drawing.Size(292, 60);
            this._clientCommandTextBox.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this._stopServerButton, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this._startServerButton, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this._portLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this._portTextBox, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(499, 228);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.51685F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.48315F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(298, 219);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // _stopServerButton
            // 
            this._stopServerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._stopServerButton.Location = new System.Drawing.Point(3, 181);
            this._stopServerButton.Name = "_stopServerButton";
            this._stopServerButton.Size = new System.Drawing.Size(143, 35);
            this._stopServerButton.TabIndex = 1;
            this._stopServerButton.Text = "Stop Server";
            this._stopServerButton.UseVisualStyleBackColor = true;
            this._stopServerButton.Click += new System.EventHandler(this.StopServerButtonHandler);
            // 
            // _startServerButton
            // 
            this._startServerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._startServerButton.Location = new System.Drawing.Point(152, 181);
            this._startServerButton.Name = "_startServerButton";
            this._startServerButton.Size = new System.Drawing.Size(143, 35);
            this._startServerButton.TabIndex = 0;
            this._startServerButton.Text = "Start Server";
            this._startServerButton.UseVisualStyleBackColor = true;
            this._startServerButton.Click += new System.EventHandler(this.StartServerButtonHandler);
            // 
            // _portLabel
            // 
            this._portLabel.AutoSize = true;
            this._portLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._portLabel.Location = new System.Drawing.Point(3, 154);
            this._portLabel.Name = "_portLabel";
            this._portLabel.Size = new System.Drawing.Size(143, 24);
            this._portLabel.TabIndex = 2;
            this._portLabel.Text = "Listen on Port:";
            this._portLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _portTextBox
            // 
            this._portTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._portTextBox.CausesValidation = false;
            this._portTextBox.Location = new System.Drawing.Point(152, 157);
            this._portTextBox.Name = "_portTextBox";
            this._portTextBox.Size = new System.Drawing.Size(143, 20);
            this._portTextBox.TabIndex = 3;
            this._portTextBox.Text = "5000";
            this._portTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "WinForm Server";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox _statusTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label _connectedClientsLabel;
        private System.Windows.Forms.TextBox _connectedClientsTextBox;
        private System.Windows.Forms.Button _sendCommandButton;
        private System.Windows.Forms.TextBox _clientCommandTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button _startServerButton;
        private System.Windows.Forms.Button _stopServerButton;
        private System.Windows.Forms.Label _portLabel;
        private System.Windows.Forms.TextBox _portTextBox;
    }
}

