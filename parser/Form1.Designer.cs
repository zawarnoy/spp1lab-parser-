namespace parser
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListTitles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumericStart = new System.Windows.Forms.NumericUpDown();
            this.NumericEnd = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LastUpdateLbl = new System.Windows.Forms.Label();
            this.SelectCiteBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PaginationPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEnd)).BeginInit();
            this.PaginationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListTitles
            // 
            this.ListTitles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListTitles.FormattingEnabled = true;
            this.ListTitles.Location = new System.Drawing.Point(12, 12);
            this.ListTitles.Name = "ListTitles";
            this.ListTitles.Size = new System.Drawing.Size(361, 264);
            this.ListTitles.TabIndex = 0;
            this.ListTitles.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Point";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "End Point";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NumericStart
            // 
            this.NumericStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericStart.Location = new System.Drawing.Point(17, 40);
            this.NumericStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericStart.Name = "NumericStart";
            this.NumericStart.Size = new System.Drawing.Size(75, 20);
            this.NumericStart.TabIndex = 3;
            this.NumericStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericStart.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // NumericEnd
            // 
            this.NumericEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericEnd.Location = new System.Drawing.Point(17, 79);
            this.NumericEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericEnd.Name = "NumericEnd";
            this.NumericEnd.Size = new System.Drawing.Size(75, 20);
            this.NumericEnd.TabIndex = 4;
            this.NumericEnd.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Location = new System.Drawing.Point(386, 168);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonAbort
            // 
            this.buttonAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbort.Location = new System.Drawing.Point(477, 168);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(75, 23);
            this.buttonAbort.TabIndex = 6;
            this.buttonAbort.Text = "Abort";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last update:";
            // 
            // LastUpdateLbl
            // 
            this.LastUpdateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LastUpdateLbl.AutoSize = true;
            this.LastUpdateLbl.Location = new System.Drawing.Point(451, 248);
            this.LastUpdateLbl.Name = "LastUpdateLbl";
            this.LastUpdateLbl.Size = new System.Drawing.Size(10, 13);
            this.LastUpdateLbl.TabIndex = 8;
            this.LastUpdateLbl.Text = "-";
            // 
            // SelectCiteBox
            // 
            this.SelectCiteBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectCiteBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectCiteBox.FormattingEnabled = true;
            this.SelectCiteBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.SelectCiteBox.Items.AddRange(new object[] {
            "Habrahabr(publications)",
            "Dota2.ru(news)"});
            this.SelectCiteBox.Location = new System.Drawing.Point(390, 28);
            this.SelectCiteBox.Name = "SelectCiteBox";
            this.SelectCiteBox.Size = new System.Drawing.Size(121, 21);
            this.SelectCiteBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Select a cite";
            // 
            // PaginationPanel
            // 
            this.PaginationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PaginationPanel.Controls.Add(this.label5);
            this.PaginationPanel.Controls.Add(this.NumericStart);
            this.PaginationPanel.Controls.Add(this.label1);
            this.PaginationPanel.Controls.Add(this.label2);
            this.PaginationPanel.Controls.Add(this.NumericEnd);
            this.PaginationPanel.Location = new System.Drawing.Point(390, 55);
            this.PaginationPanel.Name = "PaginationPanel";
            this.PaginationPanel.Size = new System.Drawing.Size(166, 100);
            this.PaginationPanel.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "For cites with pagination";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 287);
            this.Controls.Add(this.PaginationPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SelectCiteBox);
            this.Controls.Add(this.LastUpdateLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.ListTitles);
            this.MinimumSize = new System.Drawing.Size(350, 285);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEnd)).EndInit();
            this.PaginationPanel.ResumeLayout(false);
            this.PaginationPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListTitles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumericStart;
        private System.Windows.Forms.NumericUpDown NumericEnd;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LastUpdateLbl;
        private System.Windows.Forms.ComboBox SelectCiteBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PaginationPanel;
        private System.Windows.Forms.Label label5;
    }
}

