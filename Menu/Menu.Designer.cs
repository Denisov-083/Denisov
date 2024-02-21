namespace Electronic_training_manual
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonTheory = new System.Windows.Forms.Button();
            this.buttonTesting = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTheory
            // 
            this.buttonTheory.BackColor = System.Drawing.SystemColors.Window;
            this.buttonTheory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTheory.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTheory.Location = new System.Drawing.Point(140, 116);
            this.buttonTheory.Name = "buttonTheory";
            this.buttonTheory.Size = new System.Drawing.Size(300, 100);
            this.buttonTheory.TabIndex = 3;
            this.buttonTheory.TabStop = false;
            this.buttonTheory.Text = "Теоретический материал";
            this.buttonTheory.UseVisualStyleBackColor = false;
            this.buttonTheory.Click += new System.EventHandler(this.buttonTheory_Click);
            // 
            // buttonTesting
            // 
            this.buttonTesting.AutoSize = true;
            this.buttonTesting.BackColor = System.Drawing.SystemColors.Window;
            this.buttonTesting.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTesting.Location = new System.Drawing.Point(140, 222);
            this.buttonTesting.Name = "buttonTesting";
            this.buttonTesting.Size = new System.Drawing.Size(300, 100);
            this.buttonTesting.TabIndex = 5;
            this.buttonTesting.TabStop = false;
            this.buttonTesting.Text = "Тест";
            this.buttonTesting.UseVisualStyleBackColor = false;
            this.buttonTesting.Click += new System.EventHandler(this.buttonTesting_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpProvider1.SetHelpKeyword(this.pictureBox1, "Введение.htm");
            this.helpProvider1.SetHelpNavigator(this.pictureBox1, System.Windows.Forms.HelpNavigator.Topic);
            this.pictureBox1.Location = new System.Drawing.Point(542, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.helpProvider1.SetShowHelp(this.pictureBox1, true);
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "denisov083.chm";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonTesting);
            this.Controls.Add(this.buttonTheory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Учебное пособие";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonTheory;
        private System.Windows.Forms.Button buttonTesting;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

