namespace RoadWork
{
    partial class Form1
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

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtWidth = new TextBox();
            txtLength = new TextBox();
            txtMass = new TextBox();
            txtMonth = new TextBox();
            btnAddBase = new Button();
            btnAddExtended = new Button();
            listBoxBaseWorks = new ListBox();
            listBoxExtendedWorks = new ListBox();
            btnRemoveSelectedBase = new Button();
            btnRemoveSelectedExtended = new Button();
            btnCalculateQBase = new Button();
            btnCalculateQExtended = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Ширина дороги:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 47);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 1;
            label2.Text = "Длина дороги:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 77);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(153, 15);
            label3.TabIndex = 2;
            label3.Text = "Масса покрытия (кг/кв.м):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 107);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 3;
            label4.Text = "Номер месяца (1-12):";
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(187, 14);
            txtWidth.Margin = new Padding(4, 3, 4, 3);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(116, 23);
            txtWidth.TabIndex = 4;
            // 
            // txtLength
            // 
            txtLength.Location = new Point(187, 44);
            txtLength.Margin = new Padding(4, 3, 4, 3);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(116, 23);
            txtLength.TabIndex = 5;
            // 
            // txtMass
            // 
            txtMass.Location = new Point(187, 74);
            txtMass.Margin = new Padding(4, 3, 4, 3);
            txtMass.Name = "txtMass";
            txtMass.Size = new Size(116, 23);
            txtMass.TabIndex = 6;
            // 
            // txtMonth
            // 
            txtMonth.Location = new Point(187, 104);
            txtMonth.Margin = new Padding(4, 3, 4, 3);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new Size(116, 23);
            txtMonth.TabIndex = 7;
            // 
            // btnAddBase
            // 
            btnAddBase.Location = new Point(18, 138);
            btnAddBase.Margin = new Padding(4, 3, 4, 3);
            btnAddBase.Name = "btnAddBase";
            btnAddBase.Size = new Size(140, 35);
            btnAddBase.TabIndex = 8;
            btnAddBase.Text = "Добавить базовый";
            btnAddBase.UseVisualStyleBackColor = true;
            btnAddBase.Click += btnAddBase_Click;
            // 
            // btnAddExtended
            // 
            btnAddExtended.Location = new Point(163, 138);
            btnAddExtended.Margin = new Padding(4, 3, 4, 3);
            btnAddExtended.Name = "btnAddExtended";
            btnAddExtended.Size = new Size(140, 35);
            btnAddExtended.TabIndex = 9;
            btnAddExtended.Text = "Добавить потомок";
            btnAddExtended.UseVisualStyleBackColor = true;
            btnAddExtended.Click += btnAddExtended_Click;
            // 
            // listBoxBaseWorks
            // 
            listBoxBaseWorks.FormattingEnabled = true;
            listBoxBaseWorks.ItemHeight = 15;
            listBoxBaseWorks.Location = new Point(328, 35);
            listBoxBaseWorks.Margin = new Padding(4, 3, 4, 3);
            listBoxBaseWorks.Name = "listBoxBaseWorks";
            listBoxBaseWorks.Size = new Size(583, 109);
            listBoxBaseWorks.TabIndex = 10;
            // 
            // listBoxExtendedWorks
            // 
            listBoxExtendedWorks.FormattingEnabled = true;
            listBoxExtendedWorks.ItemHeight = 15;
            listBoxExtendedWorks.Location = new Point(328, 184);
            listBoxExtendedWorks.Margin = new Padding(4, 3, 4, 3);
            listBoxExtendedWorks.Name = "listBoxExtendedWorks";
            listBoxExtendedWorks.Size = new Size(583, 109);
            listBoxExtendedWorks.TabIndex = 11;
            // 
            // btnRemoveSelectedBase
            // 
            btnRemoveSelectedBase.Location = new Point(18, 197);
            btnRemoveSelectedBase.Margin = new Padding(4, 3, 4, 3);
            btnRemoveSelectedBase.Name = "btnRemoveSelectedBase";
            btnRemoveSelectedBase.Size = new Size(140, 35);
            btnRemoveSelectedBase.TabIndex = 12;
            btnRemoveSelectedBase.Text = "Удалить базовый";
            btnRemoveSelectedBase.UseVisualStyleBackColor = true;
            btnRemoveSelectedBase.Click += btnRemoveSelectedBase_Click;
            // 
            // btnRemoveSelectedExtended
            // 
            btnRemoveSelectedExtended.Location = new Point(18, 258);
            btnRemoveSelectedExtended.Margin = new Padding(4, 3, 4, 3);
            btnRemoveSelectedExtended.Name = "btnRemoveSelectedExtended";
            btnRemoveSelectedExtended.Size = new Size(140, 35);
            btnRemoveSelectedExtended.TabIndex = 13;
            btnRemoveSelectedExtended.Text = "Удалить потомок";
            btnRemoveSelectedExtended.UseVisualStyleBackColor = true;
            btnRemoveSelectedExtended.Click += btnRemoveSelectedExtended_Click;
            // 
            // btnCalculateQBase
            // 
            btnCalculateQBase.Location = new Point(163, 197);
            btnCalculateQBase.Margin = new Padding(4, 3, 4, 3);
            btnCalculateQBase.Name = "btnCalculateQBase";
            btnCalculateQBase.Size = new Size(140, 35);
            btnCalculateQBase.TabIndex = 14;
            btnCalculateQBase.Text = "Рассчитать Q (база)";
            btnCalculateQBase.UseVisualStyleBackColor = true;
            btnCalculateQBase.Click += btnCalculateQBase_Click;
            // 
            // btnCalculateQExtended
            // 
            btnCalculateQExtended.Location = new Point(163, 258);
            btnCalculateQExtended.Margin = new Padding(4, 3, 4, 3);
            btnCalculateQExtended.Name = "btnCalculateQExtended";
            btnCalculateQExtended.Size = new Size(140, 35);
            btnCalculateQExtended.TabIndex = 15;
            btnCalculateQExtended.Text = "Рассчитать Qp";
            btnCalculateQExtended.UseVisualStyleBackColor = true;
            btnCalculateQExtended.Click += btnCalculateQExtended_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(328, 17);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 16;
            label5.Text = "Базовые объекты:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(328, 158);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(115, 15);
            label6.TabIndex = 17;
            label6.Text = "Дочерние объекты:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 312);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnCalculateQExtended);
            Controls.Add(btnCalculateQBase);
            Controls.Add(btnRemoveSelectedExtended);
            Controls.Add(btnRemoveSelectedBase);
            Controls.Add(listBoxExtendedWorks);
            Controls.Add(listBoxBaseWorks);
            Controls.Add(btnAddExtended);
            Controls.Add(btnAddBase);
            Controls.Add(txtMonth);
            Controls.Add(txtMass);
            Controls.Add(txtLength);
            Controls.Add(txtWidth);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Учет дорожных работ";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtMass;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Button btnAddBase;
        private System.Windows.Forms.Button btnAddExtended;
        private System.Windows.Forms.ListBox listBoxBaseWorks;
        private System.Windows.Forms.ListBox listBoxExtendedWorks;
        private System.Windows.Forms.Button btnRemoveSelectedBase;
        private System.Windows.Forms.Button btnRemoveSelectedExtended;
        private System.Windows.Forms.Button btnCalculateQBase;
        private System.Windows.Forms.Button btnCalculateQExtended;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}