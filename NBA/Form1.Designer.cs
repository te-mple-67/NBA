namespace NBA
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
            this.btnLoadTeams = new System.Windows.Forms.Button();
            this.listBoxTeams = new System.Windows.Forms.ListBox();
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.labelTeams = new System.Windows.Forms.Label();
            this.labelPlayers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoadTeams
            // 
            this.btnLoadTeams.Location = new System.Drawing.Point(92, 318);
            this.btnLoadTeams.Name = "btnLoadTeams";
            this.btnLoadTeams.Size = new System.Drawing.Size(131, 35);
            this.btnLoadTeams.TabIndex = 0;
            this.btnLoadTeams.Text = "Загрузить команды";
            this.btnLoadTeams.UseVisualStyleBackColor = true;
            this.btnLoadTeams.Click += new System.EventHandler(this.btnLoadTeams_Click);
            // 
            // listBoxTeams
            // 
            this.listBoxTeams.FormattingEnabled = true;
            this.listBoxTeams.Location = new System.Drawing.Point(75, 87);
            this.listBoxTeams.Name = "listBoxTeams";
            this.listBoxTeams.Size = new System.Drawing.Size(165, 212);
            this.listBoxTeams.TabIndex = 2;
            this.listBoxTeams.SelectedIndexChanged += new System.EventHandler(this.listBoxTeams_SelectedIndexChanged);
            // 
            // listBoxPlayers
            // 
            this.listBoxPlayers.FormattingEnabled = true;
            this.listBoxPlayers.Location = new System.Drawing.Point(302, 87);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.Size = new System.Drawing.Size(283, 212);
            this.listBoxPlayers.TabIndex = 3;
            // 
            // labelTeams
            // 
            this.labelTeams.AutoSize = true;
            this.labelTeams.Location = new System.Drawing.Point(126, 41);
            this.labelTeams.Name = "labelTeams";
            this.labelTeams.Size = new System.Drawing.Size(57, 13);
            this.labelTeams.TabIndex = 4;
            this.labelTeams.Text = "Команды:";
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.Location = new System.Drawing.Point(421, 41);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(47, 13);
            this.labelPlayers.TabIndex = 5;
            this.labelPlayers.Text = "Игроки:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPlayers);
            this.Controls.Add(this.labelTeams);
            this.Controls.Add(this.listBoxPlayers);
            this.Controls.Add(this.listBoxTeams);
            this.Controls.Add(this.btnLoadTeams);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadTeams;
        private System.Windows.Forms.ListBox listBoxTeams;
        private System.Windows.Forms.ListBox listBoxPlayers;
        private System.Windows.Forms.Label labelTeams;
        private System.Windows.Forms.Label labelPlayers;
    }
}

