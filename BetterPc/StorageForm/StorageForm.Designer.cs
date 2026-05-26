namespace BetterPc
{
    partial class StorageForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tempFoldersButton = new System.Windows.Forms.Button();
            this.diskCleanupButton = new System.Windows.Forms.Button();
            this.disableHibernateButton = new System.Windows.Forms.Button();
            this.StorageButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.StorageButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.disableHibernateButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.diskCleanupButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tempFoldersButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(439, 471);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tempFoldersButton
            // 
            this.tempFoldersButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tempFoldersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempFoldersButton.Location = new System.Drawing.Point(3, 3);
            this.tempFoldersButton.Name = "tempFoldersButton";
            this.tempFoldersButton.Size = new System.Drawing.Size(433, 111);
            this.tempFoldersButton.TabIndex = 1;
            this.tempFoldersButton.Text = "Delete Temp/Cach Folders";
            this.tempFoldersButton.UseVisualStyleBackColor = true;
            this.tempFoldersButton.Click += new System.EventHandler(this.tempFoldersButton_Click);
            // 
            // diskCleanupButton
            // 
            this.diskCleanupButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diskCleanupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diskCleanupButton.Location = new System.Drawing.Point(3, 120);
            this.diskCleanupButton.Name = "diskCleanupButton";
            this.diskCleanupButton.Size = new System.Drawing.Size(433, 111);
            this.diskCleanupButton.TabIndex = 2;
            this.diskCleanupButton.Text = "Disk Cleanup";
            this.diskCleanupButton.UseVisualStyleBackColor = true;
            this.diskCleanupButton.Click += new System.EventHandler(this.diskCleanupButton_Click);
            // 
            // disableHibernateButton
            // 
            this.disableHibernateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disableHibernateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableHibernateButton.Location = new System.Drawing.Point(3, 237);
            this.disableHibernateButton.Name = "disableHibernateButton";
            this.disableHibernateButton.Size = new System.Drawing.Size(433, 111);
            this.disableHibernateButton.TabIndex = 3;
            this.disableHibernateButton.Text = "Disable Hibernate";
            this.disableHibernateButton.UseVisualStyleBackColor = true;
            this.disableHibernateButton.Click += new System.EventHandler(this.disableHibernateButton_Click);
            // 
            // StorageButton
            // 
            this.StorageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StorageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StorageButton.Location = new System.Drawing.Point(3, 354);
            this.StorageButton.Name = "StorageButton";
            this.StorageButton.Size = new System.Drawing.Size(433, 114);
            this.StorageButton.TabIndex = 4;
            this.StorageButton.Text = "Storage";
            this.StorageButton.UseVisualStyleBackColor = true;
            this.StorageButton.Click += new System.EventHandler(this.StorageButton_Click);
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 471);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StorageForm";
            this.Text = "StorageForm";
            this.Load += new System.EventHandler(this.StorageForm_Load_1);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button diskCleanupButton;
        private System.Windows.Forms.Button tempFoldersButton;
        private System.Windows.Forms.Button StorageButton;
        private System.Windows.Forms.Button disableHibernateButton;
    }
}