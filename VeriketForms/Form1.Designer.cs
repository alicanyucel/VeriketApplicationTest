namespace VeriketForms
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
            dtgList = new DataGridView();
            btnTıkla = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgList).BeginInit();
            SuspendLayout();
            // 
            // dtgList
            // 
            dtgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgList.Location = new Point(59, 123);
            dtgList.Name = "dtgList";
            dtgList.Size = new Size(520, 150);
            dtgList.TabIndex = 0;
            // 
            // btnTıkla
            // 
            btnTıkla.Location = new Point(612, 194);
            btnTıkla.Name = "btnTıkla";
            btnTıkla.Size = new Size(75, 23);
            btnTıkla.TabIndex = 1;
            btnTıkla.Text = "Tıkla";
            btnTıkla.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTıkla);
            Controls.Add(dtgList);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgList;
        private Button btnTıkla;
    }
}
