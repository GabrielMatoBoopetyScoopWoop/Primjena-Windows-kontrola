namespace Primjena_Windows_kontrola
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
            this.ProgramiComboBox = new System.Windows.Forms.ComboBox();
            this.RunAProgramButton = new System.Windows.Forms.Button();
            this.VisibilitiyCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProgramNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProgramDescriptionTxt = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.FileButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TextButton = new System.Windows.Forms.Button();
            this.FontButton = new System.Windows.Forms.Button();
            this.OptionsButton = new System.Windows.Forms.Button();
            this.MessageButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgramiComboBox
            // 
            this.ProgramiComboBox.FormattingEnabled = true;
            this.ProgramiComboBox.Items.AddRange(new object[] {
            "Notepad",
            "MS Paint"});
            this.ProgramiComboBox.Location = new System.Drawing.Point(6, 44);
            this.ProgramiComboBox.Name = "ProgramiComboBox";
            this.ProgramiComboBox.Size = new System.Drawing.Size(160, 21);
            this.ProgramiComboBox.TabIndex = 1;
            // 
            // RunAProgramButton
            // 
            this.RunAProgramButton.Location = new System.Drawing.Point(172, 44);
            this.RunAProgramButton.Name = "RunAProgramButton";
            this.RunAProgramButton.Size = new System.Drawing.Size(107, 23);
            this.RunAProgramButton.TabIndex = 2;
            this.RunAProgramButton.Text = "Run a program";
            this.RunAProgramButton.UseVisualStyleBackColor = true;
            this.RunAProgramButton.Click += new System.EventHandler(this.RunAProgramButton_Click);
            // 
            // VisibilitiyCheckBox
            // 
            this.VisibilitiyCheckBox.AutoSize = true;
            this.VisibilitiyCheckBox.Location = new System.Drawing.Point(85, 330);
            this.VisibilitiyCheckBox.Name = "VisibilitiyCheckBox";
            this.VisibilitiyCheckBox.Size = new System.Drawing.Size(126, 17);
            this.VisibilitiyCheckBox.TabIndex = 5;
            this.VisibilitiyCheckBox.Text = "Show program action";
            this.VisibilitiyCheckBox.UseVisualStyleBackColor = true;
            this.VisibilitiyCheckBox.CheckedChanged += new System.EventHandler(this.VisibilitiyCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProgramiComboBox);
            this.groupBox1.Controls.Add(this.RunAProgramButton);
            this.groupBox1.Location = new System.Drawing.Point(85, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 106);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Run a program";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClearButton);
            this.groupBox2.Controls.Add(this.ProgramDescriptionTxt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ProgramNameTxt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(85, 353);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 234);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Program control";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Program name:";
            // 
            // ProgramNameTxt
            // 
            this.ProgramNameTxt.Location = new System.Drawing.Point(9, 63);
            this.ProgramNameTxt.Name = "ProgramNameTxt";
            this.ProgramNameTxt.Size = new System.Drawing.Size(174, 20);
            this.ProgramNameTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Program description";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // ProgramDescriptionTxt
            // 
            this.ProgramDescriptionTxt.Location = new System.Drawing.Point(9, 102);
            this.ProgramDescriptionTxt.Multiline = true;
            this.ProgramDescriptionTxt.Name = "ProgramDescriptionTxt";
            this.ProgramDescriptionTxt.Size = new System.Drawing.Size(174, 85);
            this.ProgramDescriptionTxt.TabIndex = 3;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(189, 61);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(90, 23);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // FileButton
            // 
            this.FileButton.Location = new System.Drawing.Point(12, 12);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(75, 23);
            this.FileButton.TabIndex = 8;
            this.FileButton.Text = "File";
            this.FileButton.UseVisualStyleBackColor = true;
            this.FileButton.Click += new System.EventHandler(this.File_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(93, 12);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 9;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(174, 12);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(75, 23);
            this.ViewButton.TabIndex = 10;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(255, 12);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(75, 23);
            this.HelpButton.TabIndex = 11;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(12, 41);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 12;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Visible = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 70);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 99);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Visible = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TextButton
            // 
            this.TextButton.Location = new System.Drawing.Point(94, 41);
            this.TextButton.Name = "TextButton";
            this.TextButton.Size = new System.Drawing.Size(75, 23);
            this.TextButton.TabIndex = 15;
            this.TextButton.Text = "Text";
            this.TextButton.UseVisualStyleBackColor = true;
            this.TextButton.Visible = false;
            // 
            // FontButton
            // 
            this.FontButton.Location = new System.Drawing.Point(94, 70);
            this.FontButton.Name = "FontButton";
            this.FontButton.Size = new System.Drawing.Size(75, 23);
            this.FontButton.TabIndex = 16;
            this.FontButton.Text = "Font";
            this.FontButton.UseVisualStyleBackColor = true;
            this.FontButton.Visible = false;
            // 
            // OptionsButton
            // 
            this.OptionsButton.Location = new System.Drawing.Point(94, 99);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(75, 23);
            this.OptionsButton.TabIndex = 17;
            this.OptionsButton.Text = "Options";
            this.OptionsButton.UseVisualStyleBackColor = true;
            this.OptionsButton.Visible = false;
            // 
            // MessageButton
            // 
            this.MessageButton.Location = new System.Drawing.Point(174, 41);
            this.MessageButton.Name = "MessageButton";
            this.MessageButton.Size = new System.Drawing.Size(75, 23);
            this.MessageButton.TabIndex = 18;
            this.MessageButton.Text = "Message";
            this.MessageButton.UseVisualStyleBackColor = true;
            this.MessageButton.Visible = false;
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(255, 41);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(75, 23);
            this.AboutButton.TabIndex = 19;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 680);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.MessageButton);
            this.Controls.Add(this.OptionsButton);
            this.Controls.Add(this.FontButton);
            this.Controls.Add(this.TextButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.FileButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.VisibilitiyCheckBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ProgramiComboBox;
        private System.Windows.Forms.Button RunAProgramButton;
        private System.Windows.Forms.CheckBox VisibilitiyCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ProgramDescriptionTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProgramNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button FileButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button TextButton;
        private System.Windows.Forms.Button FontButton;
        private System.Windows.Forms.Button OptionsButton;
        private System.Windows.Forms.Button MessageButton;
        private System.Windows.Forms.Button AboutButton;
    }
}

