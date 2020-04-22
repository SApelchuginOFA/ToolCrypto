namespace Tool.Crypto
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
            this.button_Encode = new System.Windows.Forms.Button();
            this.panel_Exec = new System.Windows.Forms.Panel();
            this.label_DecodedString = new System.Windows.Forms.Label();
            this.textBox_Decoded = new System.Windows.Forms.TextBox();
            this.label_EncodedString = new System.Windows.Forms.Label();
            this.textBox_Encoded = new System.Windows.Forms.TextBox();
            this.label_OriginalString = new System.Windows.Forms.Label();
            this.textBox_OriginalString = new System.Windows.Forms.TextBox();
            this.textBox_SecretKey = new System.Windows.Forms.TextBox();
            this.label_SecretKey = new System.Windows.Forms.Label();
            this.button_CopyXMLToClipboard = new System.Windows.Forms.Button();
            this.button_CopyEncodedToClipboard = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.groupBox_Console = new System.Windows.Forms.GroupBox();
            this.textBox_XML = new System.Windows.Forms.TextBox();
            this.panel_Buttons = new System.Windows.Forms.Panel();
            this.panel_Exec.SuspendLayout();
            this.groupBox_Console.SuspendLayout();
            this.panel_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Encode
            // 
            this.button_Encode.Location = new System.Drawing.Point(35, 21);
            this.button_Encode.Name = "button_Encode";
            this.button_Encode.Size = new System.Drawing.Size(130, 48);
            this.button_Encode.TabIndex = 0;
            this.button_Encode.Text = "Encode";
            this.button_Encode.UseVisualStyleBackColor = true;
            this.button_Encode.Click += new System.EventHandler(this.button_Encode_Click);
            // 
            // panel_Exec
            // 
            this.panel_Exec.Controls.Add(this.label_DecodedString);
            this.panel_Exec.Controls.Add(this.textBox_Decoded);
            this.panel_Exec.Controls.Add(this.label_EncodedString);
            this.panel_Exec.Controls.Add(this.textBox_Encoded);
            this.panel_Exec.Controls.Add(this.label_OriginalString);
            this.panel_Exec.Controls.Add(this.textBox_OriginalString);
            this.panel_Exec.Controls.Add(this.textBox_SecretKey);
            this.panel_Exec.Controls.Add(this.label_SecretKey);
            this.panel_Exec.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Exec.Location = new System.Drawing.Point(0, 0);
            this.panel_Exec.Name = "panel_Exec";
            this.panel_Exec.Size = new System.Drawing.Size(990, 183);
            this.panel_Exec.TabIndex = 3;
            // 
            // label_DecodedString
            // 
            this.label_DecodedString.AutoSize = true;
            this.label_DecodedString.Location = new System.Drawing.Point(28, 133);
            this.label_DecodedString.Name = "label_DecodedString";
            this.label_DecodedString.Size = new System.Drawing.Size(149, 17);
            this.label_DecodedString.TabIndex = 13;
            this.label_DecodedString.Text = "Decoded Check String";
            // 
            // textBox_Decoded
            // 
            this.textBox_Decoded.Location = new System.Drawing.Point(194, 128);
            this.textBox_Decoded.Name = "textBox_Decoded";
            this.textBox_Decoded.Size = new System.Drawing.Size(769, 22);
            this.textBox_Decoded.TabIndex = 12;
            // 
            // label_EncodedString
            // 
            this.label_EncodedString.AutoSize = true;
            this.label_EncodedString.Location = new System.Drawing.Point(72, 101);
            this.label_EncodedString.Name = "label_EncodedString";
            this.label_EncodedString.Size = new System.Drawing.Size(105, 17);
            this.label_EncodedString.TabIndex = 11;
            this.label_EncodedString.Text = "Encoded String";
            // 
            // textBox_Encoded
            // 
            this.textBox_Encoded.Location = new System.Drawing.Point(194, 96);
            this.textBox_Encoded.Name = "textBox_Encoded";
            this.textBox_Encoded.Size = new System.Drawing.Size(769, 22);
            this.textBox_Encoded.TabIndex = 10;
            // 
            // label_OriginalString
            // 
            this.label_OriginalString.AutoSize = true;
            this.label_OriginalString.Location = new System.Drawing.Point(79, 67);
            this.label_OriginalString.Name = "label_OriginalString";
            this.label_OriginalString.Size = new System.Drawing.Size(98, 17);
            this.label_OriginalString.TabIndex = 9;
            this.label_OriginalString.Text = "Original String";
            // 
            // textBox_OriginalString
            // 
            this.textBox_OriginalString.Location = new System.Drawing.Point(194, 62);
            this.textBox_OriginalString.Name = "textBox_OriginalString";
            this.textBox_OriginalString.Size = new System.Drawing.Size(769, 22);
            this.textBox_OriginalString.TabIndex = 8;
            // 
            // textBox_SecretKey
            // 
            this.textBox_SecretKey.Location = new System.Drawing.Point(193, 29);
            this.textBox_SecretKey.Name = "textBox_SecretKey";
            this.textBox_SecretKey.Size = new System.Drawing.Size(141, 22);
            this.textBox_SecretKey.TabIndex = 6;
            // 
            // label_SecretKey
            // 
            this.label_SecretKey.AutoSize = true;
            this.label_SecretKey.Location = new System.Drawing.Point(100, 34);
            this.label_SecretKey.Name = "label_SecretKey";
            this.label_SecretKey.Size = new System.Drawing.Size(77, 17);
            this.label_SecretKey.TabIndex = 5;
            this.label_SecretKey.Text = "Secret Key";
            // 
            // button_CopyXMLToClipboard
            // 
            this.button_CopyXMLToClipboard.Location = new System.Drawing.Point(525, 21);
            this.button_CopyXMLToClipboard.Name = "button_CopyXMLToClipboard";
            this.button_CopyXMLToClipboard.Size = new System.Drawing.Size(259, 48);
            this.button_CopyXMLToClipboard.TabIndex = 18;
            this.button_CopyXMLToClipboard.Text = "Copy XML to clipboard";
            this.button_CopyXMLToClipboard.UseVisualStyleBackColor = true;
            this.button_CopyXMLToClipboard.Click += new System.EventHandler(this.button_CopyXMLToClipboard_Click);
            // 
            // button_CopyEncodedToClipboard
            // 
            this.button_CopyEncodedToClipboard.Location = new System.Drawing.Point(210, 21);
            this.button_CopyEncodedToClipboard.Name = "button_CopyEncodedToClipboard";
            this.button_CopyEncodedToClipboard.Size = new System.Drawing.Size(259, 48);
            this.button_CopyEncodedToClipboard.TabIndex = 17;
            this.button_CopyEncodedToClipboard.Text = "Copy Encoded string to clipboard";
            this.button_CopyEncodedToClipboard.UseVisualStyleBackColor = true;
            this.button_CopyEncodedToClipboard.Click += new System.EventHandler(this.button_CopyEncodedToClipboard_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(831, 21);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(132, 48);
            this.button_Exit.TabIndex = 1;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // groupBox_Console
            // 
            this.groupBox_Console.Controls.Add(this.textBox_XML);
            this.groupBox_Console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Console.Location = new System.Drawing.Point(0, 183);
            this.groupBox_Console.Name = "groupBox_Console";
            this.groupBox_Console.Size = new System.Drawing.Size(990, 253);
            this.groupBox_Console.TabIndex = 5;
            this.groupBox_Console.TabStop = false;
            this.groupBox_Console.Text = "XML";
            // 
            // textBox_XML
            // 
            this.textBox_XML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_XML.Location = new System.Drawing.Point(3, 18);
            this.textBox_XML.Multiline = true;
            this.textBox_XML.Name = "textBox_XML";
            this.textBox_XML.Size = new System.Drawing.Size(984, 232);
            this.textBox_XML.TabIndex = 7;
            // 
            // panel_Buttons
            // 
            this.panel_Buttons.Controls.Add(this.button_CopyXMLToClipboard);
            this.panel_Buttons.Controls.Add(this.button_Encode);
            this.panel_Buttons.Controls.Add(this.button_CopyEncodedToClipboard);
            this.panel_Buttons.Controls.Add(this.button_Exit);
            this.panel_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Buttons.Location = new System.Drawing.Point(0, 348);
            this.panel_Buttons.Name = "panel_Buttons";
            this.panel_Buttons.Size = new System.Drawing.Size(990, 88);
            this.panel_Buttons.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 436);
            this.Controls.Add(this.panel_Buttons);
            this.Controls.Add(this.groupBox_Console);
            this.Controls.Add(this.panel_Exec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tool Crypto [Ver.2020.04.22]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.panel_Exec.ResumeLayout(false);
            this.panel_Exec.PerformLayout();
            this.groupBox_Console.ResumeLayout(false);
            this.groupBox_Console.PerformLayout();
            this.panel_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Encode;
        private System.Windows.Forms.Panel panel_Exec;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.TextBox textBox_SecretKey;
        private System.Windows.Forms.Label label_SecretKey;
        private System.Windows.Forms.Label label_OriginalString;
        private System.Windows.Forms.TextBox textBox_OriginalString;
        private System.Windows.Forms.Label label_DecodedString;
        private System.Windows.Forms.TextBox textBox_Decoded;
        private System.Windows.Forms.Label label_EncodedString;
        private System.Windows.Forms.TextBox textBox_Encoded;
        private System.Windows.Forms.Button button_CopyEncodedToClipboard;
        private System.Windows.Forms.GroupBox groupBox_Console;
        private System.Windows.Forms.Button button_CopyXMLToClipboard;
        private System.Windows.Forms.TextBox textBox_XML;
        private System.Windows.Forms.Panel panel_Buttons;
    }
}

