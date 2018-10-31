using System;
using System.Drawing;
using System.Windows.Forms;
namespace WindowsFormsLab
{
    partial class FormTeplohod
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
            this.pictureBoxTeplohod = new System.Windows.Forms.PictureBox();
            this.plusLokomativ = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pictureBoxTake = new System.Windows.Forms.PictureBox();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plusTep = new System.Windows.Forms.Button();
            this.Take = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeplohod)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTeplohod
            // 
            this.pictureBoxTeplohod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxTeplohod.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTeplohod.Name = "pictureBoxTeplohod";
            this.pictureBoxTeplohod.Size = new System.Drawing.Size(750, 461);
            this.pictureBoxTeplohod.TabIndex = 0;
            this.pictureBoxTeplohod.TabStop = false;
            // 
            // plusLokomativ
            // 
            this.plusLokomativ.Location = new System.Drawing.Point(757, 84);
            this.plusLokomativ.Name = "plusLokomativ";
            this.plusLokomativ.Size = new System.Drawing.Size(115, 65);
            this.plusLokomativ.TabIndex = 2;
            this.plusLokomativ.Text = "Припарковать Локоматив";
            this.plusLokomativ.UseVisualStyleBackColor = true;
            this.plusLokomativ.Click += new System.EventHandler(this.plusLokomativ_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.Take);
            this.groupBox.Controls.Add(this.pictureBoxTake);
            this.groupBox.Location = new System.Drawing.Point(752, 281);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(133, 180);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            // 
            // pictureBoxTake
            // 
            this.pictureBoxTake.Location = new System.Drawing.Point(1, 105);
            this.pictureBoxTake.Name = "pictureBoxTake";
            this.pictureBoxTake.Size = new System.Drawing.Size(130, 75);
            this.pictureBoxTake.TabIndex = 0;
            this.pictureBoxTake.TabStop = false;
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(825, 329);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(30, 20);
            this.maskedTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(774, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Забрать теплоход";
            // 
            // plusTep
            // 
            this.plusTep.Location = new System.Drawing.Point(757, 12);
            this.plusTep.Name = "plusTep";
            this.plusTep.Size = new System.Drawing.Size(115, 65);
            this.plusTep.TabIndex = 8;
            this.plusTep.Text = "Припарковать Теплоход";
            this.plusTep.UseVisualStyleBackColor = true;
            this.plusTep.Click += new System.EventHandler(this.plusTep_Click);
            // 
            // Take
            // 
            this.Take.Location = new System.Drawing.Point(25, 76);
            this.Take.Name = "Take";
            this.Take.Size = new System.Drawing.Size(75, 23);
            this.Take.TabIndex = 1;
            this.Take.Text = "Забрать";
            this.Take.UseVisualStyleBackColor = true;
            this.Take.Click += new System.EventHandler(this.Take_Click_1);
            // 
            // FormTeplohod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.plusTep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.plusLokomativ);
            this.Controls.Add(this.pictureBoxTeplohod);
            this.Name = "FormTeplohod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Депо";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeplohod)).EndInit();
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTeplohod;
        private Button plusLokomativ;
        private GroupBox groupBox;
        private MaskedTextBox maskedTextBox;
        private Label label1;
        private PictureBox pictureBoxTake;
        private Button plusTep;
        private Button Take;
    }
}

