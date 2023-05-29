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
            appTabs = new TabControl();
            addFundTab = new TabPage();
            fundSpentInput = new NumericUpDown();
            addSpendingBtn = new Button();
            fundingNameInput = new TextBox();
            dateSelector = new MonthCalendar();
            historyTab = new TabPage();
            deleteBtn = new Button();
            spendingList = new ListBox();
            dateChooser = new DateTimePicker();
            preferencesTab = new TabPage();
            groupBox3 = new GroupBox();
            label3 = new Label();
            defaultSpendingNameInput = new TextBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            spendingLimitInput = new NumericUpDown();
            groupBox1 = new GroupBox();
            autoLaunchTab = new RadioButton();
            label6 = new Label();
            radioButton2 = new RadioButton();
            button1 = new Button();
            noticeLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            appTabs.SuspendLayout();
            addFundTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fundSpentInput).BeginInit();
            historyTab.SuspendLayout();
            preferencesTab.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spendingLimitInput).BeginInit();
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
            // appTabs
            // 
            appTabs.Controls.Add(addFundTab);
            appTabs.Controls.Add(historyTab);
            appTabs.Controls.Add(preferencesTab);
            resources.ApplyResources(appTabs, "appTabs");
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
            // preferencesTab
            // 
            preferencesTab.Controls.Add(groupBox3);
            preferencesTab.Controls.Add(groupBox2);
            preferencesTab.Controls.Add(groupBox1);
            preferencesTab.Controls.Add(button1);
            resources.ApplyResources(preferencesTab, "preferencesTab");
            preferencesTab.Name = "preferencesTab";
            preferencesTab.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(defaultSpendingNameInput);
            groupBox3.Controls.Add(label4);
            resources.ApplyResources(groupBox3, "groupBox3");
            groupBox3.Name = "groupBox3";
            groupBox3.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // defaultSpendingNameInput
            // 
            resources.ApplyResources(defaultSpendingNameInput, "defaultSpendingNameInput");
            defaultSpendingNameInput.Name = "defaultSpendingNameInput";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(spendingLimitInput);
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // spendingLimitInput
            // 
            spendingLimitInput.Increment = new decimal(new int[] { 50000, 0, 0, 0 });
            resources.ApplyResources(spendingLimitInput, "spendingLimitInput");
            spendingLimitInput.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            spendingLimitInput.Name = "spendingLimitInput";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(autoLaunchTab);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(radioButton2);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // autoLaunchTab
            // 
            resources.ApplyResources(autoLaunchTab, "autoLaunchTab");
            autoLaunchTab.Name = "autoLaunchTab";
            autoLaunchTab.TabStop = true;
            autoLaunchTab.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // radioButton2
            // 
            resources.ApplyResources(radioButton2, "radioButton2");
            radioButton2.Name = "radioButton2";
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
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
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainWindow";
            ShowIcon = false;
            Load += Form1_Load;
            appTabs.ResumeLayout(false);
            addFundTab.ResumeLayout(false);
            addFundTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fundSpentInput).EndInit();
            historyTab.ResumeLayout(false);
            preferencesTab.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spendingLimitInput).EndInit();
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
        private Label label1;
        private Label label2;
        private Button addSpendingBtn;
        private Button deleteBtn;
        private ListBox spendingList;
        private DateTimePicker dateChooser;
        private NumericUpDown fundSpentInput;
        private Label noticeLabel;
        private TabPage preferencesTab;
        private Label label3;
        private Label label4;
        private TextBox defaultSpendingNameInput;
        private NumericUpDown spendingLimitInput;
        private Label label5;
        private RadioButton radioButton2;
        private RadioButton autoLaunchTab;
        private Label label6;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
    }
}