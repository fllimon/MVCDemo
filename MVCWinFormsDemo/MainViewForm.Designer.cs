namespace MVCWinFormsDemo
{
    partial class MainViewForm
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
            this.components = new System.ComponentModel.Container();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generatorSopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geberatorStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrNewData = new System.Windows.Forms.Timer(this.components);
            this.txtNewData = new System.Windows.Forms.TextBox();
            this.lblNewElement = new System.Windows.Forms.Label();
            this.chbxActiveModel = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(116, 32);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(496, 20);
            this.txtData.TabIndex = 0;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(23, 35);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(87, 13);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data from model:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(537, 58);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.ShowDataCommand);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 27);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.generatorSopToolStripMenuItem,
            this.geberatorStartToolStripMenuItem,
            this.generatorToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(50, 23);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.ShowDataCommand);
            // 
            // generatorSopToolStripMenuItem
            // 
            this.generatorSopToolStripMenuItem.Name = "generatorSopToolStripMenuItem";
            this.generatorSopToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.generatorSopToolStripMenuItem.Text = "Generator Stop";
            this.generatorSopToolStripMenuItem.Click += new System.EventHandler(this.StopGenerateDataCommand);
            // 
            // geberatorStartToolStripMenuItem
            // 
            this.geberatorStartToolStripMenuItem.Name = "geberatorStartToolStripMenuItem";
            this.geberatorStartToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.geberatorStartToolStripMenuItem.Text = "Generator Start";
            this.geberatorStartToolStripMenuItem.Click += new System.EventHandler(this.StartGenerateDataCommand);
            // 
            // generatorToolStripMenuItem
            // 
            this.generatorToolStripMenuItem.Name = "generatorToolStripMenuItem";
            this.generatorToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.generatorToolStripMenuItem.Text = "Generator";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tmrNewData
            // 
            this.tmrNewData.Interval = 1000;
            this.tmrNewData.Tick += new System.EventHandler(this.NewDataCommand);
            // 
            // txtNewData
            // 
            this.txtNewData.Location = new System.Drawing.Point(116, 77);
            this.txtNewData.Name = "txtNewData";
            this.txtNewData.Size = new System.Drawing.Size(100, 20);
            this.txtNewData.TabIndex = 4;
            this.txtNewData.Text = "0";
            // 
            // lblNewElement
            // 
            this.lblNewElement.AutoSize = true;
            this.lblNewElement.Location = new System.Drawing.Point(23, 84);
            this.lblNewElement.Name = "lblNewElement";
            this.lblNewElement.Size = new System.Drawing.Size(69, 13);
            this.lblNewElement.TabIndex = 5;
            this.lblNewElement.Text = "New element";
            // 
            // chbxActiveModel
            // 
            this.chbxActiveModel.AutoSize = true;
            this.chbxActiveModel.Location = new System.Drawing.Point(26, 143);
            this.chbxActiveModel.Name = "chbxActiveModel";
            this.chbxActiveModel.Size = new System.Drawing.Size(87, 17);
            this.chbxActiveModel.TabIndex = 6;
            this.chbxActiveModel.Text = "Active model";
            this.chbxActiveModel.UseVisualStyleBackColor = true;
            this.chbxActiveModel.CheckedChanged += new System.EventHandler(this.chbxActiveModel_CheckedChanged);
            // 
            // MainViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 379);
            this.Controls.Add(this.chbxActiveModel);
            this.Controls.Add(this.lblNewElement);
            this.Controls.Add(this.txtNewData);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainViewForm";
            this.Text = "MVC demo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Timer tmrNewData;
        private System.Windows.Forms.TextBox txtNewData;
        private System.Windows.Forms.Label lblNewElement;
        private System.Windows.Forms.ToolStripMenuItem geberatorStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generatorSopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generatorToolStripMenuItem;
        private System.Windows.Forms.CheckBox chbxActiveModel;
    }
}

