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
            components = new System.ComponentModel.Container();
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
            deleteBtn = new Button();
            spendingTotal = new Label();
            label3 = new Label();
            spendingList = new ListView();
            spendID = new ColumnHeader();
            spendName = new ColumnHeader();
            spendAmount = new ColumnHeader();
            dateChooser = new DateTimePicker();
            profileTab = new TabPage();
            startupTabContainer = new GroupBox();
            startupOptions = new ComboBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            saveLimitBtn = new Button();
            label5 = new Label();
            fundLimitInput = new NumericUpDown();
            label4 = new Label();
            groupBox1 = new GroupBox();
            changePasswordBtn = new Button();
            profileNameLabel = new Label();
            changeProfileNameBtn = new Button();
            noticeLabel = new Label();
            overLimitTooltip = new ToolTip(components);
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            appTabs.SuspendLayout();
            addFundTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fundSpentInput).BeginInit();
            historyTab.SuspendLayout();
            profileTab.SuspendLayout();
            startupTabContainer.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fundLimitInput).BeginInit();
            groupBox1.SuspendLayout();
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
            historyTab.Controls.Add(deleteBtn);
            historyTab.Controls.Add(spendingTotal);
            historyTab.Controls.Add(label3);
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
            deleteBtn.Click += deleteBtn_Click;
            // 
            // spendingTotal
            // 
            resources.ApplyResources(spendingTotal, "spendingTotal");
            spendingTotal.Name = "spendingTotal";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // spendingList
            // 
            spendingList.Columns.AddRange(new ColumnHeader[] { spendID, spendName, spendAmount });
            spendingList.Cursor = Cursors.Hand;
            spendingList.FullRowSelect = true;
            spendingList.GridLines = true;
            resources.ApplyResources(spendingList, "spendingList");
            spendingList.MultiSelect = false;
            spendingList.Name = "spendingList";
            spendingList.ShowItemToolTips = true;
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
            profileTab.Controls.Add(startupTabContainer);
            profileTab.Controls.Add(groupBox2);
            profileTab.Controls.Add(groupBox1);
            resources.ApplyResources(profileTab, "profileTab");
            profileTab.Name = "profileTab";
            profileTab.UseVisualStyleBackColor = true;
            // 
            // startupTabContainer
            // 
            startupTabContainer.Controls.Add(startupOptions);
            startupTabContainer.Controls.Add(label6);
            resources.ApplyResources(startupTabContainer, "startupTabContainer");
            startupTabContainer.Name = "startupTabContainer";
            startupTabContainer.TabStop = false;
            // 
            // startupOptions
            // 
            startupOptions.DropDownStyle = ComboBoxStyle.DropDownList;
            startupOptions.FormattingEnabled = true;
            startupOptions.Items.AddRange(new object[] { resources.GetString("startupOptions.Items"), resources.GetString("startupOptions.Items1") });
            resources.ApplyResources(startupOptions, "startupOptions");
            startupOptions.Name = "startupOptions";
            startupOptions.SelectedIndexChanged += startupOptions_SelectedIndexChanged;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(saveLimitBtn);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(fundLimitInput);
            groupBox2.Controls.Add(label4);
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // saveLimitBtn
            // 
            resources.ApplyResources(saveLimitBtn, "saveLimitBtn");
            saveLimitBtn.Name = "saveLimitBtn";
            saveLimitBtn.UseVisualStyleBackColor = true;
            saveLimitBtn.Click += saveLimitBtn_Click;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // fundLimitInput
            // 
            fundLimitInput.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            resources.ApplyResources(fundLimitInput, "fundLimitInput");
            fundLimitInput.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            fundLimitInput.Name = "fundLimitInput";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(changePasswordBtn);
            groupBox1.Controls.Add(profileNameLabel);
            groupBox1.Controls.Add(changeProfileNameBtn);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // changePasswordBtn
            // 
            resources.ApplyResources(changePasswordBtn, "changePasswordBtn");
            changePasswordBtn.Name = "changePasswordBtn";
            changePasswordBtn.UseVisualStyleBackColor = true;
            changePasswordBtn.Click += changePasswordBtn_Click;
            // 
            // profileNameLabel
            // 
            resources.ApplyResources(profileNameLabel, "profileNameLabel");
            profileNameLabel.Name = "profileNameLabel";
            // 
            // changeProfileNameBtn
            // 
            resources.ApplyResources(changeProfileNameBtn, "changeProfileNameBtn");
            changeProfileNameBtn.Name = "changeProfileNameBtn";
            changeProfileNameBtn.UseVisualStyleBackColor = true;
            changeProfileNameBtn.Click += changeProfileNameBtn_Click;
            // 
            // noticeLabel
            // 
            resources.ApplyResources(noticeLabel, "noticeLabel");
            noticeLabel.Name = "noticeLabel";
            // 
            // overLimitTooltip
            // 
            overLimitTooltip.IsBalloon = true;
            overLimitTooltip.ToolTipIcon = ToolTipIcon.Warning;
            overLimitTooltip.ToolTipTitle = "Lưu ý!";
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
            historyTab.PerformLayout();
            profileTab.ResumeLayout(false);
            startupTabContainer.ResumeLayout(false);
            startupTabContainer.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fundLimitInput).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Label spendingTotal;
        private Label label3;
        private Button deleteBtn;
        private GroupBox groupBox2;
        private Label label4;
        private GroupBox groupBox1;
        private Label label5;
        private NumericUpDown fundLimitInput;
        private GroupBox startupTabContainer;
        private Label label6;
        private Button saveLimitBtn;
        private ToolTip overLimitTooltip;
        private ComboBox startupOptions;
    }
}