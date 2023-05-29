namespace QuanLiTaiChinh
{
    partial class MainWindow
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
            Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            Label label1;
            tabControl1 = new TabControl();
            addFundTab = new TabPage();
            fundSpentInput = new NumericUpDown();
            addSpendingBtn = new Button();
            fundingNameInput = new TextBox();
            dateSelector = new MonthCalendar();
            historyTab = new TabPage();
            deleteBtn = new Button();
            spendingList = new ListBox();
            dateChooser = new DateTimePicker();
            noticeLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            tabControl1.SuspendLayout();
            addFundTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fundSpentInput).BeginInit();
            historyTab.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(addFundTab);
            tabControl1.Controls.Add(historyTab);
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            // 
            // addFundTab
            // 
            addFundTab.Controls.Add(fundSpentInput);
            addFundTab.Controls.Add(addSpendingBtn);
            addFundTab.Controls.Add(label2);
            addFundTab.Controls.Add(fundingNameInput);
            addFundTab.Controls.Add(label1);
            addFundTab.Controls.Add(dateSelector);
            resources.ApplyResources(addFundTab, "addFundTab");
            addFundTab.Name = "addFundTab";
            addFundTab.UseVisualStyleBackColor = true;
            // 
            // fundSpentInput
            // 
            fundSpentInput.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            resources.ApplyResources(fundSpentInput, "fundSpentInput");
            fundSpentInput.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            fundSpentInput.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            fundSpentInput.Name = "fundSpentInput";
            fundSpentInput.Value = new decimal(new int[] { 100000, 0, 0, 0 });
            // 
            // addSpendingBtn
            // 
            resources.ApplyResources(addSpendingBtn, "addSpendingBtn");
            addSpendingBtn.Name = "addSpendingBtn";
            addSpendingBtn.UseVisualStyleBackColor = true;
            addSpendingBtn.Click += addSpendingBtn_Click;
            // 
            // fundingNameInput
            // 
            resources.ApplyResources(fundingNameInput, "fundingNameInput");
            fundingNameInput.Name = "fundingNameInput";
            // 
            // dateSelector
            // 
            resources.ApplyResources(dateSelector, "dateSelector");
            dateSelector.Name = "dateSelector";
            dateSelector.DateChanged += dateSelector_DateChanged;
            // 
            // historyTab
            // 
            historyTab.Controls.Add(deleteBtn);
            historyTab.Controls.Add(spendingList);
            historyTab.Controls.Add(dateChooser);
            resources.ApplyResources(historyTab, "historyTab");
            historyTab.Name = "historyTab";
            historyTab.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            resources.ApplyResources(deleteBtn, "deleteBtn");
            deleteBtn.Name = "deleteBtn";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // spendingList
            // 
            spendingList.FormattingEnabled = true;
            resources.ApplyResources(spendingList, "spendingList");
            spendingList.Name = "spendingList";
            // 
            // dateChooser
            // 
            resources.ApplyResources(dateChooser, "dateChooser");
            dateChooser.Name = "dateChooser";
            // 
            // noticeLabel
            // 
            resources.ApplyResources(noticeLabel, "noticeLabel");
            noticeLabel.Name = "noticeLabel";
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            Controls.Add(noticeLabel);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainWindow";
            ShowIcon = false;
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            addFundTab.ResumeLayout(false);
            addFundTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fundSpentInput).EndInit();
            historyTab.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl tabControl1;
        private TabPage addFundTab;
        private TabPage historyTab;
        private MonthCalendar dateSelector;
        private TextBox fundingNameInput;
        private Label label1;
        private Label label2;
        private Button addSpendingBtn;
        private Button deleteBtn;
        private ListBox spendingList;
        private DateTimePicker dateChooser;
        private NumericUpDown fundSpentInput;
        private Label noticeLabel;
    }
}