namespace Coursework1
{
    partial class frmMain
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
            this.lstIntValues = new System.Windows.Forms.ListBox();
            this.grpSortChoice = new System.Windows.Forms.GroupBox();
            this.optSorted = new System.Windows.Forms.RadioButton();
            this.optUnsorted = new System.Windows.Forms.RadioButton();
            this.grpSearchChoice = new System.Windows.Forms.GroupBox();
            this.optBinary = new System.Windows.Forms.RadioButton();
            this.optLinear = new System.Windows.Forms.RadioButton();
            this.btnInitList = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.txtNewNumber = new System.Windows.Forms.TextBox();
            this.btnAddNumber = new System.Windows.Forms.Button();
            this.btnDeleteNumber = new System.Windows.Forms.Button();
            this.txtSearchItem = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpStats = new System.Windows.Forms.GroupBox();
            this.lblMaxValue = new System.Windows.Forms.Label();
            this.lblMinValue = new System.Windows.Forms.Label();
            this.lblMaxValueTitle = new System.Windows.Forms.Label();
            this.lblMinValueTitle = new System.Windows.Forms.Label();
            this.lblLastItem = new System.Windows.Forms.Label();
            this.lblLastItemTitle = new System.Windows.Forms.Label();
            this.lblFirstItem = new System.Windows.Forms.Label();
            this.lblFirstItemTitle = new System.Windows.Forms.Label();
            this.lblNumEntries = new System.Windows.Forms.Label();
            this.lblNumEntriesTitle = new System.Windows.Forms.Label();
            this.grpSortChoice.SuspendLayout();
            this.grpSearchChoice.SuspendLayout();
            this.grpStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstIntValues
            // 
            this.lstIntValues.FormattingEnabled = true;
            this.lstIntValues.Location = new System.Drawing.Point(12, 12);
            this.lstIntValues.Name = "lstIntValues";
            this.lstIntValues.ScrollAlwaysVisible = true;
            this.lstIntValues.Size = new System.Drawing.Size(120, 251);
            this.lstIntValues.TabIndex = 0;
            // 
            // grpSortChoice
            // 
            this.grpSortChoice.Controls.Add(this.optSorted);
            this.grpSortChoice.Controls.Add(this.optUnsorted);
            this.grpSortChoice.Location = new System.Drawing.Point(293, 12);
            this.grpSortChoice.Name = "grpSortChoice";
            this.grpSortChoice.Size = new System.Drawing.Size(120, 75);
            this.grpSortChoice.TabIndex = 1;
            this.grpSortChoice.TabStop = false;
            this.grpSortChoice.Text = "Sort the numbers?";
            // 
            // optSorted
            // 
            this.optSorted.AutoSize = true;
            this.optSorted.Location = new System.Drawing.Point(7, 44);
            this.optSorted.Name = "optSorted";
            this.optSorted.Size = new System.Drawing.Size(56, 17);
            this.optSorted.TabIndex = 1;
            this.optSorted.TabStop = true;
            this.optSorted.Text = "Sorted";
            this.optSorted.UseVisualStyleBackColor = true;
            // 
            // optUnsorted
            // 
            this.optUnsorted.AutoSize = true;
            this.optUnsorted.Checked = true;
            this.optUnsorted.Location = new System.Drawing.Point(7, 20);
            this.optUnsorted.Name = "optUnsorted";
            this.optUnsorted.Size = new System.Drawing.Size(68, 17);
            this.optUnsorted.TabIndex = 0;
            this.optUnsorted.TabStop = true;
            this.optUnsorted.Text = "Unsorted";
            this.optUnsorted.UseVisualStyleBackColor = true;
            this.optUnsorted.CheckedChanged += new System.EventHandler(this.optUnsorted_CheckedChanged);
            // 
            // grpSearchChoice
            // 
            this.grpSearchChoice.Controls.Add(this.optBinary);
            this.grpSearchChoice.Controls.Add(this.optLinear);
            this.grpSearchChoice.Location = new System.Drawing.Point(293, 93);
            this.grpSearchChoice.Name = "grpSearchChoice";
            this.grpSearchChoice.Size = new System.Drawing.Size(120, 76);
            this.grpSearchChoice.TabIndex = 2;
            this.grpSearchChoice.TabStop = false;
            this.grpSearchChoice.Text = "Searching Algorithm";
            // 
            // optBinary
            // 
            this.optBinary.AutoSize = true;
            this.optBinary.Enabled = false;
            this.optBinary.Location = new System.Drawing.Point(7, 44);
            this.optBinary.Name = "optBinary";
            this.optBinary.Size = new System.Drawing.Size(91, 17);
            this.optBinary.TabIndex = 1;
            this.optBinary.TabStop = true;
            this.optBinary.Text = "Binary Search";
            this.optBinary.UseVisualStyleBackColor = true;
            // 
            // optLinear
            // 
            this.optLinear.AutoSize = true;
            this.optLinear.Checked = true;
            this.optLinear.Location = new System.Drawing.Point(7, 20);
            this.optLinear.Name = "optLinear";
            this.optLinear.Size = new System.Drawing.Size(91, 17);
            this.optLinear.TabIndex = 0;
            this.optLinear.TabStop = true;
            this.optLinear.Text = "Linear Search";
            this.optLinear.UseVisualStyleBackColor = true;
            // 
            // btnInitList
            // 
            this.btnInitList.Location = new System.Drawing.Point(139, 12);
            this.btnInitList.Name = "btnInitList";
            this.btnInitList.Size = new System.Drawing.Size(120, 23);
            this.btnInitList.TabIndex = 3;
            this.btnInitList.Text = "Initialise List";
            this.btnInitList.UseVisualStyleBackColor = true;
            this.btnInitList.Click += new System.EventHandler(this.btnInitList_Click);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(139, 42);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Enabled = false;
            this.btnShuffle.Location = new System.Drawing.Point(139, 72);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(120, 23);
            this.btnShuffle.TabIndex = 5;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // txtNewNumber
            // 
            this.txtNewNumber.Location = new System.Drawing.Point(139, 159);
            this.txtNewNumber.Name = "txtNewNumber";
            this.txtNewNumber.Size = new System.Drawing.Size(90, 20);
            this.txtNewNumber.TabIndex = 7;
            // 
            // btnAddNumber
            // 
            this.btnAddNumber.Location = new System.Drawing.Point(235, 157);
            this.btnAddNumber.Name = "btnAddNumber";
            this.btnAddNumber.Size = new System.Drawing.Size(42, 23);
            this.btnAddNumber.TabIndex = 8;
            this.btnAddNumber.Text = "Add";
            this.btnAddNumber.UseVisualStyleBackColor = true;
            this.btnAddNumber.Click += new System.EventHandler(this.btnAddNumber_Click);
            // 
            // btnDeleteNumber
            // 
            this.btnDeleteNumber.Enabled = false;
            this.btnDeleteNumber.Location = new System.Drawing.Point(139, 101);
            this.btnDeleteNumber.Name = "btnDeleteNumber";
            this.btnDeleteNumber.Size = new System.Drawing.Size(120, 23);
            this.btnDeleteNumber.TabIndex = 9;
            this.btnDeleteNumber.Text = "Delete";
            this.btnDeleteNumber.UseVisualStyleBackColor = true;
            this.btnDeleteNumber.Click += new System.EventHandler(this.btnDeleteNumber_Click);
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.Location = new System.Drawing.Point(139, 188);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.Size = new System.Drawing.Size(90, 20);
            this.txtSearchItem.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(235, 186);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(42, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Find";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(139, 240);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpStats
            // 
            this.grpStats.Controls.Add(this.lblMaxValue);
            this.grpStats.Controls.Add(this.lblMinValue);
            this.grpStats.Controls.Add(this.lblMaxValueTitle);
            this.grpStats.Controls.Add(this.lblMinValueTitle);
            this.grpStats.Controls.Add(this.lblLastItem);
            this.grpStats.Controls.Add(this.lblLastItemTitle);
            this.grpStats.Controls.Add(this.lblFirstItem);
            this.grpStats.Controls.Add(this.lblFirstItemTitle);
            this.grpStats.Controls.Add(this.lblNumEntries);
            this.grpStats.Controls.Add(this.lblNumEntriesTitle);
            this.grpStats.Location = new System.Drawing.Point(13, 270);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(200, 118);
            this.grpStats.TabIndex = 13;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "Statistics";
            // 
            // lblMaxValue
            // 
            this.lblMaxValue.AutoSize = true;
            this.lblMaxValue.Location = new System.Drawing.Point(74, 88);
            this.lblMaxValue.Name = "lblMaxValue";
            this.lblMaxValue.Size = new System.Drawing.Size(37, 13);
            this.lblMaxValue.TabIndex = 9;
            this.lblMaxValue.Text = "(none)";
            // 
            // lblMinValue
            // 
            this.lblMinValue.AutoSize = true;
            this.lblMinValue.Location = new System.Drawing.Point(70, 71);
            this.lblMinValue.Name = "lblMinValue";
            this.lblMinValue.Size = new System.Drawing.Size(37, 13);
            this.lblMinValue.TabIndex = 8;
            this.lblMinValue.Text = "(none)";
            // 
            // lblMaxValueTitle
            // 
            this.lblMaxValueTitle.AutoSize = true;
            this.lblMaxValueTitle.Enabled = false;
            this.lblMaxValueTitle.Location = new System.Drawing.Point(7, 88);
            this.lblMaxValueTitle.Name = "lblMaxValueTitle";
            this.lblMaxValueTitle.Size = new System.Drawing.Size(60, 13);
            this.lblMaxValueTitle.TabIndex = 7;
            this.lblMaxValueTitle.Text = "Max Value:";
            // 
            // lblMinValueTitle
            // 
            this.lblMinValueTitle.AutoSize = true;
            this.lblMinValueTitle.Enabled = false;
            this.lblMinValueTitle.Location = new System.Drawing.Point(7, 71);
            this.lblMinValueTitle.Name = "lblMinValueTitle";
            this.lblMinValueTitle.Size = new System.Drawing.Size(57, 13);
            this.lblMinValueTitle.TabIndex = 6;
            this.lblMinValueTitle.Text = "Min Value:";
            // 
            // lblLastItem
            // 
            this.lblLastItem.AutoSize = true;
            this.lblLastItem.Location = new System.Drawing.Point(64, 54);
            this.lblLastItem.Name = "lblLastItem";
            this.lblLastItem.Size = new System.Drawing.Size(37, 13);
            this.lblLastItem.TabIndex = 5;
            this.lblLastItem.Text = "(none)";
            // 
            // lblLastItemTitle
            // 
            this.lblLastItemTitle.AutoSize = true;
            this.lblLastItemTitle.Enabled = false;
            this.lblLastItemTitle.Location = new System.Drawing.Point(7, 54);
            this.lblLastItemTitle.Name = "lblLastItemTitle";
            this.lblLastItemTitle.Size = new System.Drawing.Size(52, 13);
            this.lblLastItemTitle.TabIndex = 4;
            this.lblLastItemTitle.Text = "Last item:";
            // 
            // lblFirstItem
            // 
            this.lblFirstItem.AutoSize = true;
            this.lblFirstItem.Location = new System.Drawing.Point(64, 37);
            this.lblFirstItem.Name = "lblFirstItem";
            this.lblFirstItem.Size = new System.Drawing.Size(37, 13);
            this.lblFirstItem.TabIndex = 3;
            this.lblFirstItem.Text = "(none)";
            // 
            // lblFirstItemTitle
            // 
            this.lblFirstItemTitle.AutoSize = true;
            this.lblFirstItemTitle.Enabled = false;
            this.lblFirstItemTitle.Location = new System.Drawing.Point(7, 37);
            this.lblFirstItemTitle.Name = "lblFirstItemTitle";
            this.lblFirstItemTitle.Size = new System.Drawing.Size(51, 13);
            this.lblFirstItemTitle.TabIndex = 2;
            this.lblFirstItemTitle.Text = "First item:";
            // 
            // lblNumEntries
            // 
            this.lblNumEntries.AutoSize = true;
            this.lblNumEntries.Location = new System.Drawing.Point(43, 20);
            this.lblNumEntries.Name = "lblNumEntries";
            this.lblNumEntries.Size = new System.Drawing.Size(36, 13);
            this.lblNumEntries.TabIndex = 1;
            this.lblNumEntries.Text = "0 / 30";
            // 
            // lblNumEntriesTitle
            // 
            this.lblNumEntriesTitle.AutoSize = true;
            this.lblNumEntriesTitle.Location = new System.Drawing.Point(7, 20);
            this.lblNumEntriesTitle.Name = "lblNumEntriesTitle";
            this.lblNumEntriesTitle.Size = new System.Drawing.Size(30, 13);
            this.lblNumEntriesTitle.TabIndex = 0;
            this.lblNumEntriesTitle.Text = "Size:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 400);
            this.Controls.Add(this.grpStats);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchItem);
            this.Controls.Add(this.btnDeleteNumber);
            this.Controls.Add(this.btnAddNumber);
            this.Controls.Add(this.txtNewNumber);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInitList);
            this.Controls.Add(this.grpSearchChoice);
            this.Controls.Add(this.grpSortChoice);
            this.Controls.Add(this.lstIntValues);
            this.Name = "frmMain";
            this.Text = "Integer Number Manager";
            this.grpSortChoice.ResumeLayout(false);
            this.grpSortChoice.PerformLayout();
            this.grpSearchChoice.ResumeLayout(false);
            this.grpSearchChoice.PerformLayout();
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstIntValues;
        private System.Windows.Forms.GroupBox grpSortChoice;
        private System.Windows.Forms.RadioButton optSorted;
        private System.Windows.Forms.RadioButton optUnsorted;
        private System.Windows.Forms.GroupBox grpSearchChoice;
        private System.Windows.Forms.RadioButton optBinary;
        private System.Windows.Forms.RadioButton optLinear;
        private System.Windows.Forms.Button btnInitList;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.TextBox txtNewNumber;
        private System.Windows.Forms.Button btnAddNumber;
        private System.Windows.Forms.Button btnDeleteNumber;
        private System.Windows.Forms.TextBox txtSearchItem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.Label lblNumEntries;
        private System.Windows.Forms.Label lblNumEntriesTitle;
        private System.Windows.Forms.Label lblLastItem;
        private System.Windows.Forms.Label lblLastItemTitle;
        private System.Windows.Forms.Label lblFirstItem;
        private System.Windows.Forms.Label lblFirstItemTitle;
        private System.Windows.Forms.Label lblMinValueTitle;
        private System.Windows.Forms.Label lblMaxValueTitle;
        private System.Windows.Forms.Label lblMaxValue;
        private System.Windows.Forms.Label lblMinValue;
    }
}

