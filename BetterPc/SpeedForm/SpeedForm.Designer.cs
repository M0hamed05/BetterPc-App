namespace BetterPc
{
    partial class SpeedForm
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
            this.disableStartupApplicationsButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.disableUncessaryVisualsButton = new System.Windows.Forms.Button();
            this.disableunnecessaryServicesButton = new System.Windows.Forms.Button();
            this.disableBackgorundAppsButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // disableStartupApplicationsButton
            // 
            this.disableStartupApplicationsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disableStartupApplicationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableStartupApplicationsButton.Location = new System.Drawing.Point(3, 3);
            this.disableStartupApplicationsButton.Name = "disableStartupApplicationsButton";
            this.disableStartupApplicationsButton.Size = new System.Drawing.Size(387, 112);
            this.disableStartupApplicationsButton.TabIndex = 1;
            this.disableStartupApplicationsButton.Text = "Disable Startup Applications";
            this.disableStartupApplicationsButton.UseVisualStyleBackColor = true;
            this.disableStartupApplicationsButton.Click += new System.EventHandler(this.disableStartupApplicationsButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.disableUncessaryVisualsButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.disableunnecessaryServicesButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.disableBackgorundAppsButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.disableStartupApplicationsButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(393, 475);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // disableUncessaryVisualsButton
            // 
            this.disableUncessaryVisualsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disableUncessaryVisualsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableUncessaryVisualsButton.Location = new System.Drawing.Point(3, 357);
            this.disableUncessaryVisualsButton.Name = "disableUncessaryVisualsButton";
            this.disableUncessaryVisualsButton.Size = new System.Drawing.Size(387, 115);
            this.disableUncessaryVisualsButton.TabIndex = 4;
            this.disableUncessaryVisualsButton.Text = "Disable unnecessary visuals";
            this.disableUncessaryVisualsButton.UseVisualStyleBackColor = true;
            this.disableUncessaryVisualsButton.Click += new System.EventHandler(this.disableUncessaryVisualsButton_Click);
            // 
            // disableunnecessaryServicesButton
            // 
            this.disableunnecessaryServicesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disableunnecessaryServicesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableunnecessaryServicesButton.Location = new System.Drawing.Point(3, 239);
            this.disableunnecessaryServicesButton.Name = "disableunnecessaryServicesButton";
            this.disableunnecessaryServicesButton.Size = new System.Drawing.Size(387, 112);
            this.disableunnecessaryServicesButton.TabIndex = 3;
            this.disableunnecessaryServicesButton.Text = "Disable unnecessary services";
            this.disableunnecessaryServicesButton.UseVisualStyleBackColor = true;
            this.disableunnecessaryServicesButton.Click += new System.EventHandler(this.disableunnecessaryServicesButton_Click);
            // 
            // disableBackgorundAppsButton
            // 
            this.disableBackgorundAppsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disableBackgorundAppsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableBackgorundAppsButton.Location = new System.Drawing.Point(3, 121);
            this.disableBackgorundAppsButton.Name = "disableBackgorundAppsButton";
            this.disableBackgorundAppsButton.Size = new System.Drawing.Size(387, 112);
            this.disableBackgorundAppsButton.TabIndex = 2;
            this.disableBackgorundAppsButton.Text = "Disable Background Apps";
            this.disableBackgorundAppsButton.UseVisualStyleBackColor = true;
            this.disableBackgorundAppsButton.Click += new System.EventHandler(this.disableBackgorundAppsButton_Click);
            // 
            // SpeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 475);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SpeedForm";
            this.Text = "SpeedForm";
            this.Load += new System.EventHandler(this.SpeedForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button disableStartupApplicationsButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button disableUncessaryVisualsButton;
        private System.Windows.Forms.Button disableunnecessaryServicesButton;
        private System.Windows.Forms.Button disableBackgorundAppsButton;
    }
}