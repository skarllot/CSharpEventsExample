namespace EventsExample
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pbFolder = new System.Windows.Forms.ProgressBar();
            this.pbPainter = new System.Windows.Forms.ProgressBar();
            this.pbWelder = new System.Windows.Forms.ProgressBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 333);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.pbFolder, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pbPainter, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pbWelder, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.checkBox2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.checkBox3, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(444, 160);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pbFolder
            // 
            this.pbFolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbFolder.Location = new System.Drawing.Point(24, 52);
            this.pbFolder.Name = "pbFolder";
            this.pbFolder.Size = new System.Drawing.Size(100, 23);
            this.pbFolder.TabIndex = 0;
            // 
            // pbPainter
            // 
            this.pbPainter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbPainter.Location = new System.Drawing.Point(172, 52);
            this.pbPainter.Name = "pbPainter";
            this.pbPainter.Size = new System.Drawing.Size(100, 23);
            this.pbPainter.TabIndex = 1;
            // 
            // pbWelder
            // 
            this.pbWelder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbWelder.Location = new System.Drawing.Point(320, 52);
            this.pbWelder.Name = "pbWelder";
            this.pbWelder.Size = new System.Drawing.Size(100, 23);
            this.pbWelder.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(57, 133);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(34, 21);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = " ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(205, 133);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(34, 21);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = " ";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(353, 133);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(34, 21);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = " ";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnShutdown, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnStart, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 169);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(444, 161);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btnShutdown
            // 
            this.btnShutdown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShutdown.Location = new System.Drawing.Point(278, 60);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(110, 41);
            this.btnShutdown.TabIndex = 0;
            this.btnShutdown.Text = "Shutdown";
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.Location = new System.Drawing.Point(63, 64);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(95, 32);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Initialize";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 333);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ProgressBar pbFolder;
        private System.Windows.Forms.ProgressBar pbPainter;
        private System.Windows.Forms.ProgressBar pbWelder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

