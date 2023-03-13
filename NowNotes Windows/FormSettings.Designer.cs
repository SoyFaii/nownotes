﻿namespace NowNotes_Windows
{
	partial class FormSettings
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
			tabControlSettingsTabs = new TabControl();
			tabPageSync = new TabPage();
			comboBoxOneDriveAccount = new ComboBox();
			labelOneDriveAccount = new Label();
			checkBoxEnableSync = new CheckBox();
			tabPageAdvanced = new TabPage();
			checkBoxStartup = new CheckBox();
			buttonDeleteAllNotes = new Button();
			buttonOK = new Button();
			buttonCancel = new Button();
			buttonApply = new Button();
			buttonAboutNowNotes = new Button();
			tabPageAppearance = new TabPage();
			comboBox1 = new ComboBox();
			label1 = new Label();
			tabControlSettingsTabs.SuspendLayout();
			tabPageSync.SuspendLayout();
			tabPageAdvanced.SuspendLayout();
			tabPageAppearance.SuspendLayout();
			SuspendLayout();
			// 
			// tabControlSettingsTabs
			// 
			tabControlSettingsTabs.Controls.Add(tabPageAppearance);
			tabControlSettingsTabs.Controls.Add(tabPageSync);
			tabControlSettingsTabs.Controls.Add(tabPageAdvanced);
			resources.ApplyResources(tabControlSettingsTabs, "tabControlSettingsTabs");
			tabControlSettingsTabs.Multiline = true;
			tabControlSettingsTabs.Name = "tabControlSettingsTabs";
			tabControlSettingsTabs.SelectedIndex = 0;
			// 
			// tabPageSync
			// 
			tabPageSync.Controls.Add(comboBoxOneDriveAccount);
			tabPageSync.Controls.Add(labelOneDriveAccount);
			tabPageSync.Controls.Add(checkBoxEnableSync);
			resources.ApplyResources(tabPageSync, "tabPageSync");
			tabPageSync.Name = "tabPageSync";
			tabPageSync.UseVisualStyleBackColor = true;
			// 
			// comboBoxOneDriveAccount
			// 
			comboBoxOneDriveAccount.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxOneDriveAccount.FormattingEnabled = true;
			resources.ApplyResources(comboBoxOneDriveAccount, "comboBoxOneDriveAccount");
			comboBoxOneDriveAccount.Name = "comboBoxOneDriveAccount";
			comboBoxOneDriveAccount.SelectedIndexChanged += comboBoxOneDriveAccount_SelectedIndexChanged;
			// 
			// labelOneDriveAccount
			// 
			resources.ApplyResources(labelOneDriveAccount, "labelOneDriveAccount");
			labelOneDriveAccount.Name = "labelOneDriveAccount";
			// 
			// checkBoxEnableSync
			// 
			resources.ApplyResources(checkBoxEnableSync, "checkBoxEnableSync");
			checkBoxEnableSync.Name = "checkBoxEnableSync";
			checkBoxEnableSync.UseVisualStyleBackColor = true;
			checkBoxEnableSync.CheckedChanged += checkBoxEnableSync_CheckedChanged;
			// 
			// tabPageAdvanced
			// 
			tabPageAdvanced.Controls.Add(checkBoxStartup);
			tabPageAdvanced.Controls.Add(buttonDeleteAllNotes);
			resources.ApplyResources(tabPageAdvanced, "tabPageAdvanced");
			tabPageAdvanced.Name = "tabPageAdvanced";
			tabPageAdvanced.UseVisualStyleBackColor = true;
			// 
			// checkBoxStartup
			// 
			resources.ApplyResources(checkBoxStartup, "checkBoxStartup");
			checkBoxStartup.Name = "checkBoxStartup";
			checkBoxStartup.UseVisualStyleBackColor = true;
			// 
			// buttonDeleteAllNotes
			// 
			resources.ApplyResources(buttonDeleteAllNotes, "buttonDeleteAllNotes");
			buttonDeleteAllNotes.Name = "buttonDeleteAllNotes";
			buttonDeleteAllNotes.UseVisualStyleBackColor = true;
			// 
			// buttonOK
			// 
			resources.ApplyResources(buttonOK, "buttonOK");
			buttonOK.Name = "buttonOK";
			buttonOK.UseVisualStyleBackColor = true;
			buttonOK.Click += buttonOK_Click;
			// 
			// buttonCancel
			// 
			resources.ApplyResources(buttonCancel, "buttonCancel");
			buttonCancel.Name = "buttonCancel";
			buttonCancel.UseVisualStyleBackColor = true;
			buttonCancel.Click += buttonCancel_Click;
			// 
			// buttonApply
			// 
			resources.ApplyResources(buttonApply, "buttonApply");
			buttonApply.Name = "buttonApply";
			buttonApply.UseVisualStyleBackColor = true;
			buttonApply.Click += buttonApply_Click;
			// 
			// buttonAboutNowNotes
			// 
			resources.ApplyResources(buttonAboutNowNotes, "buttonAboutNowNotes");
			buttonAboutNowNotes.Name = "buttonAboutNowNotes";
			buttonAboutNowNotes.UseVisualStyleBackColor = true;
			buttonAboutNowNotes.Click += buttonAboutNowNotes_Click;
			// 
			// tabPageAppearance
			// 
			tabPageAppearance.Controls.Add(label1);
			tabPageAppearance.Controls.Add(comboBox1);
			resources.ApplyResources(tabPageAppearance, "tabPageAppearance");
			tabPageAppearance.Name = "tabPageAppearance";
			tabPageAppearance.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { resources.GetString("comboBox1.Items"), resources.GetString("comboBox1.Items1"), resources.GetString("comboBox1.Items2") });
			resources.ApplyResources(comboBox1, "comboBox1");
			comboBox1.Name = "comboBox1";
			// 
			// label1
			// 
			resources.ApplyResources(label1, "label1");
			label1.Name = "label1";
			// 
			// FormSettings
			// 
			resources.ApplyResources(this, "$this");
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(buttonAboutNowNotes);
			Controls.Add(buttonApply);
			Controls.Add(buttonCancel);
			Controls.Add(buttonOK);
			Controls.Add(tabControlSettingsTabs);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "FormSettings";
			TopMost = true;
			Load += FormSettings_Load;
			tabControlSettingsTabs.ResumeLayout(false);
			tabPageSync.ResumeLayout(false);
			tabPageSync.PerformLayout();
			tabPageAdvanced.ResumeLayout(false);
			tabPageAdvanced.PerformLayout();
			tabPageAppearance.ResumeLayout(false);
			tabPageAppearance.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControlSettingsTabs;
		private TabPage tabPageSync;
		private TabPage tabPageAdvanced;
		private Button buttonOK;
		private Button buttonCancel;
		private Button buttonApply;
		private ComboBox comboBoxOneDriveAccount;
		private Label labelOneDriveAccount;
		private CheckBox checkBoxEnableSync;
		private Button buttonDeleteAllNotes;
		private CheckBox checkBoxStartup;
		private Button buttonAboutNowNotes;
		private TabPage tabPageAppearance;
		private Label label1;
		private ComboBox comboBox1;
	}
}