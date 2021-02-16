
namespace OKP1_Stationeers_Editor
{
    partial class SettingsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.panelDialogButtons = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.lIngotSizeNote = new System.Windows.Forms.Label();
            this.numericToppingUp = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericDefaultAddQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDialogButtons.SuspendLayout();
            this.panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericToppingUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDefaultAddQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDialogButtons
            // 
            this.panelDialogButtons.Controls.Add(this.buttonCancel);
            this.panelDialogButtons.Controls.Add(this.buttonOK);
            this.panelDialogButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDialogButtons.Location = new System.Drawing.Point(0, 279);
            this.panelDialogButtons.Name = "panelDialogButtons";
            this.panelDialogButtons.Padding = new System.Windows.Forms.Padding(5);
            this.panelDialogButtons.Size = new System.Drawing.Size(585, 45);
            this.panelDialogButtons.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCancel.Location = new System.Drawing.Point(414, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(83, 35);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonOK.Location = new System.Drawing.Point(497, 5);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(83, 35);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // panelSettings
            // 
            this.panelSettings.AutoScroll = true;
            this.panelSettings.Controls.Add(this.lIngotSizeNote);
            this.panelSettings.Controls.Add(this.numericToppingUp);
            this.panelSettings.Controls.Add(this.label2);
            this.panelSettings.Controls.Add(this.numericDefaultAddQuantity);
            this.panelSettings.Controls.Add(this.label1);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettings.Location = new System.Drawing.Point(0, 0);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(585, 279);
            this.panelSettings.TabIndex = 3;
            // 
            // lIngotSizeNote
            // 
            this.lIngotSizeNote.ForeColor = System.Drawing.Color.Red;
            this.lIngotSizeNote.Location = new System.Drawing.Point(358, 14);
            this.lIngotSizeNote.Name = "lIngotSizeNote";
            this.lIngotSizeNote.Size = new System.Drawing.Size(215, 82);
            this.lIngotSizeNote.TabIndex = 4;
            this.lIngotSizeNote.Text = "Note: Max ingot size is 500. Machines can hold more, but if you unload the machin" +
    "e you will get multiple ingots per reagent type.\r\n\r\n(and a huge mess to clean up" +
    " :)\r\n";
            this.lIngotSizeNote.Visible = false;
            // 
            // numericToppingUp
            // 
            this.numericToppingUp.Location = new System.Drawing.Point(254, 41);
            this.numericToppingUp.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericToppingUp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericToppingUp.Name = "numericToppingUp";
            this.numericToppingUp.Size = new System.Drawing.Size(87, 22);
            this.numericToppingUp.TabIndex = 3;
            this.numericToppingUp.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericToppingUp.ValueChanged += new System.EventHandler(this.Reagents_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity when topping up reagents:";
            // 
            // numericDefaultAddQuantity
            // 
            this.numericDefaultAddQuantity.Location = new System.Drawing.Point(254, 13);
            this.numericDefaultAddQuantity.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericDefaultAddQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericDefaultAddQuantity.Name = "numericDefaultAddQuantity";
            this.numericDefaultAddQuantity.Size = new System.Drawing.Size(87, 22);
            this.numericDefaultAddQuantity.TabIndex = 1;
            this.numericDefaultAddQuantity.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericDefaultAddQuantity.ValueChanged += new System.EventHandler(this.Reagents_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Default quantity when adding reagents:";
            // 
            // SettingsWindow
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(585, 324);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.panelDialogButtons);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OKP1 Stationeers Editor - Settings";
            this.panelDialogButtons.ResumeLayout(false);
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericToppingUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDefaultAddQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDialogButtons;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.NumericUpDown numericToppingUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericDefaultAddQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lIngotSizeNote;
    }
}