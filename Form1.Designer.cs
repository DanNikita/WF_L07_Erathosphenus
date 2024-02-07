namespace L07_Erathosphenus
{
    partial class Form1
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
            MaxValue = new TextBox();
            label1 = new Label();
            txtbxResult = new RichTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // MaxValue
            // 
            MaxValue.Location = new Point(12, 28);
            MaxValue.Name = "MaxValue";
            MaxValue.Size = new Size(100, 23);
            MaxValue.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter number";
            // 
            // txtbxResult
            // 
            txtbxResult.Location = new Point(137, 12);
            txtbxResult.Name = "txtbxResult";
            txtbxResult.Size = new Size(203, 261);
            txtbxResult.TabIndex = 2;
            txtbxResult.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(16, 57);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Calculate!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 294);
            Controls.Add(button1);
            Controls.Add(txtbxResult);
            Controls.Add(label1);
            Controls.Add(MaxValue);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MaxValue;
        private Label label1;
        private RichTextBox txtbxResult;
        private Button button1;
    }
}
