namespace SearchingSentence
{
    partial class Form1
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
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.txBFileName = new System.Windows.Forms.TextBox();
            this.txBFoundString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindWord = new System.Windows.Forms.Button();
            this.txBSearchingWord = new System.Windows.Forms.TextBox();
            this.oFDFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnLoadFile.FlatAppearance.BorderSize = 2;
            this.btnLoadFile.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btnLoadFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
            this.btnLoadFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoadFile.Location = new System.Drawing.Point(334, 33);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(94, 32);
            this.btnLoadFile.TabIndex = 0;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // txBFileName
            // 
            this.txBFileName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txBFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txBFileName.Location = new System.Drawing.Point(62, 39);
            this.txBFileName.Name = "txBFileName";
            this.txBFileName.Size = new System.Drawing.Size(255, 23);
            this.txBFileName.TabIndex = 1;
            // 
            // txBFoundString
            // 
            this.txBFoundString.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txBFoundString.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txBFoundString.Location = new System.Drawing.Point(32, 156);
            this.txBFoundString.Multiline = true;
            this.txBFoundString.Name = "txBFoundString";
            this.txBFoundString.Size = new System.Drawing.Size(447, 135);
            this.txBFoundString.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Word for searching:";
            // 
            // btnFindWord
            // 
            this.btnFindWord.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnFindWord.FlatAppearance.BorderSize = 2;
            this.btnFindWord.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btnFindWord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
            this.btnFindWord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnFindWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFindWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFindWord.Location = new System.Drawing.Point(385, 94);
            this.btnFindWord.Name = "btnFindWord";
            this.btnFindWord.Size = new System.Drawing.Size(94, 32);
            this.btnFindWord.TabIndex = 0;
            this.btnFindWord.Text = "Find";
            this.btnFindWord.UseVisualStyleBackColor = true;
            this.btnFindWord.Click += new System.EventHandler(this.btnFindWord_Click);
            // 
            // txBSearchingWord
            // 
            this.txBSearchingWord.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txBSearchingWord.Location = new System.Drawing.Point(243, 102);
            this.txBSearchingWord.Name = "txBSearchingWord";
            this.txBSearchingWord.Size = new System.Drawing.Size(123, 20);
            this.txBSearchingWord.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(540, 338);
            this.Controls.Add(this.txBSearchingWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txBFoundString);
            this.Controls.Add(this.txBFileName);
            this.Controls.Add(this.btnFindWord);
            this.Controls.Add(this.btnLoadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.TextBox txBFileName;
        private System.Windows.Forms.TextBox txBFoundString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindWord;
        private System.Windows.Forms.TextBox txBSearchingWord;
        private System.Windows.Forms.OpenFileDialog oFDFile;
    }
}

