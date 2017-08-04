namespace BikeMaps2
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.previousSearch = new System.Windows.Forms.ComboBox();
            this.c_Button = new System.Windows.Forms.Button();
            this.s_Button = new System.Windows.Forms.Button();
            this.zipLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.zipText = new System.Windows.Forms.TextBox();
            this.stateText = new System.Windows.Forms.TextBox();
            this.cityText = new System.Windows.Forms.TextBox();
            this.streetText = new System.Windows.Forms.TextBox();
            this.mapsBrowser = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.previousSearch);
            this.splitContainer1.Panel1.Controls.Add(this.c_Button);
            this.splitContainer1.Panel1.Controls.Add(this.s_Button);
            this.splitContainer1.Panel1.Controls.Add(this.zipLabel);
            this.splitContainer1.Panel1.Controls.Add(this.stateLabel);
            this.splitContainer1.Panel1.Controls.Add(this.cityLabel);
            this.splitContainer1.Panel1.Controls.Add(this.streetLabel);
            this.splitContainer1.Panel1.Controls.Add(this.zipText);
            this.splitContainer1.Panel1.Controls.Add(this.stateText);
            this.splitContainer1.Panel1.Controls.Add(this.cityText);
            this.splitContainer1.Panel1.Controls.Add(this.streetText);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mapsBrowser);
            this.splitContainer1.Size = new System.Drawing.Size(939, 562);
            this.splitContainer1.SplitterDistance = 228;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Previous";
            // 
            // previousSearch
            // 
            this.previousSearch.FormattingEnabled = true;
            this.previousSearch.Location = new System.Drawing.Point(55, 287);
            this.previousSearch.Name = "previousSearch";
            this.previousSearch.Size = new System.Drawing.Size(135, 21);
            this.previousSearch.TabIndex = 10;
            this.previousSearch.SelectedIndexChanged += new System.EventHandler(this.previousSearch_SelectedIndexChanged);
            // 
            // c_Button
            // 
            this.c_Button.Location = new System.Drawing.Point(55, 229);
            this.c_Button.Name = "c_Button";
            this.c_Button.Size = new System.Drawing.Size(75, 23);
            this.c_Button.TabIndex = 9;
            this.c_Button.Text = "Clear";
            this.c_Button.UseVisualStyleBackColor = true;
            // 
            // s_Button
            // 
            this.s_Button.Location = new System.Drawing.Point(55, 200);
            this.s_Button.Name = "s_Button";
            this.s_Button.Size = new System.Drawing.Size(75, 23);
            this.s_Button.TabIndex = 8;
            this.s_Button.Text = "Search";
            this.s_Button.UseVisualStyleBackColor = true;
            this.s_Button.Click += new System.EventHandler(this.s_Button_Click);
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(18, 157);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(22, 13);
            this.zipLabel.TabIndex = 7;
            this.zipLabel.Text = "Zip";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(8, 131);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(32, 13);
            this.stateLabel.TabIndex = 6;
            this.stateLabel.Text = "State";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(16, 105);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(24, 13);
            this.cityLabel.TabIndex = 5;
            this.cityLabel.Text = "City";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(5, 79);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(35, 13);
            this.streetLabel.TabIndex = 4;
            this.streetLabel.Text = "Street";
            // 
            // zipText
            // 
            this.zipText.Location = new System.Drawing.Point(55, 154);
            this.zipText.Name = "zipText";
            this.zipText.Size = new System.Drawing.Size(135, 20);
            this.zipText.TabIndex = 3;
            // 
            // stateText
            // 
            this.stateText.Location = new System.Drawing.Point(55, 128);
            this.stateText.Name = "stateText";
            this.stateText.Size = new System.Drawing.Size(135, 20);
            this.stateText.TabIndex = 2;
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(55, 102);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(135, 20);
            this.cityText.TabIndex = 1;
            // 
            // streetText
            // 
            this.streetText.Location = new System.Drawing.Point(55, 76);
            this.streetText.Name = "streetText";
            this.streetText.Size = new System.Drawing.Size(135, 20);
            this.streetText.TabIndex = 0;
            // 
            // mapsBrowser
            // 
            this.mapsBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapsBrowser.Location = new System.Drawing.Point(0, 0);
            this.mapsBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.mapsBrowser.Name = "mapsBrowser";
            this.mapsBrowser.ScriptErrorsSuppressed = true;
            this.mapsBrowser.Size = new System.Drawing.Size(707, 562);
            this.mapsBrowser.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 562);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button c_Button;
        private System.Windows.Forms.Button s_Button;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.TextBox zipText;
        private System.Windows.Forms.TextBox stateText;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.TextBox streetText;
        private System.Windows.Forms.WebBrowser mapsBrowser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox previousSearch;
    }
}

