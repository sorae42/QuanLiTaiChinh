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
            Label label7;
            appTabs = new TabControl();
            addFundTab = new TabPage();
            fundSpentInput = new NumericUpDown();
            addSpendingBtn = new Button();
            fundingNameInput = new TextBox();
            dateSelector = new MonthCalendar();
            historyTab = new TabPage();
            spendingList = new ListView();
            spendID = new ColumnHeader();
            spendName = new ColumnHeader();
            spendAmount = new ColumnHeader();
            dateChooser = new DateTimePicker();
            profileTab = new TabPage();
            changePasswordBtn = new Button();
            changeProfileNameBtn = new Button();
            profileNameLabel = new Label();
            noticeLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            appTabs.SuspendLayout();
            addFundTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fundSpentInput).BeginInit();
            historyTab.SuspendLayout();
            profileTab.SuspendLayout();
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
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // appTabs
            // 
            appTabs.Controls.Add(addFundTab);
            appTabs.Controls.Add(historyTab);
            appTabs.Controls.Add(profileTab);
            resources.ApplyResources(appTabs, "appTabs");
            appTabs.Multiline = true;
            appTabs.Name = "appTabs";
            appTabs.SelectedIndex = 0;
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
            dateSelector.MaxSelectionCount = 1;
            dateSelector.Name = "dateSelector";
            // 
            // historyTab
            // 
            historyTab.Controls.Add(spendingList);
            historyTab.Controls.Add(dateChooser);
            resources.ApplyResources(historyTab, "historyTab");
            historyTab.Name = "historyTab";
            historyTab.UseVisualStyleBackColor = true;
            // 
            // spendingList
            // 
            spendingList.Columns.AddRange(new ColumnHeader[] { spendID, spendName, spendAmount });
            spendingList.FullRowSelect = true;
            resources.ApplyResources(spendingList, "spendingList");
            spendingList.MultiSelect = false;
            spendingList.Name = "spendingList";
            spendingList.UseCompatibleStateImageBehavior = false;
            spendingList.View = View.Details;
            // 
            // spendID
            // 
            resources.ApplyResources(spendID, "spendID");
            // 
            // spendName
            // 
            resources.ApplyResources(spendName, "spendName");
            // 
            // spendAmount
            // 
            resources.ApplyResources(spendAmount, "spendAmount");
            // 
            // dateChooser
            // 
            resources.ApplyResources(dateChooser, "dateChooser");
            dateChooser.Name = "dateChooser";
            dateChooser.ValueChanged += dateChooser_ValueChanged;
            // 
            // profileTab
            // 
            profileTab.Controls.Add(changePasswordBtn);
            profileTab.Controls.Add(changeProfileNameBtn);
            profileTab.Controls.Add(profileNameLabel);
            profileTab.Controls.Add(label7);
            resources.ApplyResources(profileTab, "profileTab");
            profileTab.Name = "profileTab";
            profileTab.UseVisualStyleBackColor = true;
            // 
            // changePasswordBtn
            // 
            resources.ApplyResources(changePasswordBtn, "changePasswordBtn");
            changePasswordBtn.Name = "changePasswordBtn";
            changePasswordBtn.UseVisualStyleBackColor = true;
            changePasswordBtn.Click += changePasswordBtn_Click;
            // 
            // changeProfileNameBtn
            // 
            resources.ApplyResources(changeProfileNameBtn, "changeProfileNameBtn");
            changeProfileNameBtn.Name = "changeProfileNameBtn";
            changeProfileNameBtn.UseVisualStyleBackColor = true;
            changeProfileNameBtn.Click += changeProfileNameBtn_Click;
            // 
            // profileNameLabel
            // 
            resources.ApplyResources(profileNameLabel, "profileNameLabel");
            profileNameLabel.Name = "profileNameLabel";
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
            Controls.Add(appTabs);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainWindow";
            ShowIcon = false;
            FormClosing += MainWindow_FormClosing;
            Load += MainWindow_Load;
            appTabs.ResumeLayout(false);
            addFundTab.ResumeLayout(false);
            addFundTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fundSpentInput).EndInit();
            historyTab.ResumeLayout(false);
            profileTab.ResumeLayout(false);
            profileTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl appTabs;
        private TabPage addFundTab;
        private TabPage historyTab;
        private MonthCalendar dateSelector;
        private TextBox fundingNameInput;
        private Button addSpendingBtn;
        private DateTimePicker dateChooser;
        private NumericUpDown fundSpentInput;
        private Label noticeLabel;
        private TabPage profileTab;
        private Label profileNameLabel;
        private Label label7;
        private ListView spendingList;
        private ColumnHeader spendID;
        private ColumnHeader spendName;
        private ColumnHeader spendAmount;
        private Button changeProfileNameBtn;
        private Button changePasswordBtn;
    }
}