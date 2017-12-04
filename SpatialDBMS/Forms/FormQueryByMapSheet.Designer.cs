﻿namespace SpatialDBMS.Forms
{
    partial class FormQueryByMapSheet
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
            this.textBoxMapSheetId = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.checkLeftUpper = new System.Windows.Forms.CheckBox();
            this.checkRightUpper = new System.Windows.Forms.CheckBox();
            this.checkLeftDown = new System.Windows.Forms.CheckBox();
            this.checkRightDown = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMapSheetId
            // 
            this.textBoxMapSheetId.Location = new System.Drawing.Point(13, 25);
            this.textBoxMapSheetId.Name = "textBoxMapSheetId";
            this.textBoxMapSheetId.Size = new System.Drawing.Size(131, 21);
            this.textBoxMapSheetId.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(5, 83);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(322, 23);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            // 
            // checkLeftUpper
            // 
            this.checkLeftUpper.AutoSize = true;
            this.checkLeftUpper.Location = new System.Drawing.Point(29, 22);
            this.checkLeftUpper.Name = "checkLeftUpper";
            this.checkLeftUpper.Size = new System.Drawing.Size(48, 16);
            this.checkLeftUpper.TabIndex = 4;
            this.checkLeftUpper.Text = "左上";
            this.checkLeftUpper.UseVisualStyleBackColor = true;
            // 
            // checkRightUpper
            // 
            this.checkRightUpper.AutoSize = true;
            this.checkRightUpper.Location = new System.Drawing.Point(95, 22);
            this.checkRightUpper.Name = "checkRightUpper";
            this.checkRightUpper.Size = new System.Drawing.Size(48, 16);
            this.checkRightUpper.TabIndex = 4;
            this.checkRightUpper.Text = "右上";
            this.checkRightUpper.UseVisualStyleBackColor = true;
            // 
            // checkLeftDown
            // 
            this.checkLeftDown.AutoSize = true;
            this.checkLeftDown.Location = new System.Drawing.Point(29, 44);
            this.checkLeftDown.Name = "checkLeftDown";
            this.checkLeftDown.Size = new System.Drawing.Size(48, 16);
            this.checkLeftDown.TabIndex = 4;
            this.checkLeftDown.Text = "左下";
            this.checkLeftDown.UseVisualStyleBackColor = true;
            // 
            // checkRightDown
            // 
            this.checkRightDown.AutoSize = true;
            this.checkRightDown.Location = new System.Drawing.Point(95, 44);
            this.checkRightDown.Name = "checkRightDown";
            this.checkRightDown.Size = new System.Drawing.Size(48, 16);
            this.checkRightDown.TabIndex = 4;
            this.checkRightDown.Text = "右下";
            this.checkRightDown.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkRightDown);
            this.groupBox1.Controls.Add(this.checkLeftUpper);
            this.groupBox1.Controls.Add(this.checkLeftDown);
            this.groupBox1.Controls.Add(this.checkRightUpper);
            this.groupBox1.Location = new System.Drawing.Point(162, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 65);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "位置";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxMapSheetId);
            this.groupBox2.Location = new System.Drawing.Point(4, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 65);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图幅号";
            // 
            // FormQueryByMapSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 122);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnQuery);
            this.Name = "FormQueryByMapSheet";
            this.Text = "图幅查询";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxMapSheetId;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.CheckBox checkLeftUpper;
        private System.Windows.Forms.CheckBox checkRightUpper;
        private System.Windows.Forms.CheckBox checkLeftDown;
        private System.Windows.Forms.CheckBox checkRightDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}