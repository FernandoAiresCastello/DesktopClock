namespace DesktopClock
{
    partial class MainWindow
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
            this.MainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toggleWindowFrameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.togglSecondsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.selectForegroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectBackgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectBorderColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.PnlDate = new System.Windows.Forms.Panel();
            this.LbDate = new System.Windows.Forms.Label();
            this.PnlTime = new System.Windows.Forms.Panel();
            this.LbTime = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            this.PnlMain.SuspendLayout();
            this.PnlDate.SuspendLayout();
            this.PnlTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleWindowFrameToolStripMenuItem,
            this.togglSecondsToolStripMenuItem,
            this.toolStripSeparator2,
            this.selectForegroundColorToolStripMenuItem,
            this.selectBackgroundColorToolStripMenuItem,
            this.selectBorderColorToolStripMenuItem,
            this.toolStripSeparator1,
            this.MiExit});
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(203, 148);
            // 
            // toggleWindowFrameToolStripMenuItem
            // 
            this.toggleWindowFrameToolStripMenuItem.Checked = true;
            this.toggleWindowFrameToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleWindowFrameToolStripMenuItem.Name = "toggleWindowFrameToolStripMenuItem";
            this.toggleWindowFrameToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.toggleWindowFrameToolStripMenuItem.Text = "Show window frame";
            this.toggleWindowFrameToolStripMenuItem.Click += new System.EventHandler(this.toggleWindowFrameToolStripMenuItem_Click);
            // 
            // togglSecondsToolStripMenuItem
            // 
            this.togglSecondsToolStripMenuItem.Checked = true;
            this.togglSecondsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.togglSecondsToolStripMenuItem.Name = "togglSecondsToolStripMenuItem";
            this.togglSecondsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.togglSecondsToolStripMenuItem.Text = "Show seconds";
            this.togglSecondsToolStripMenuItem.Click += new System.EventHandler(this.togglSecondsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(199, 6);
            // 
            // selectForegroundColorToolStripMenuItem
            // 
            this.selectForegroundColorToolStripMenuItem.Name = "selectForegroundColorToolStripMenuItem";
            this.selectForegroundColorToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.selectForegroundColorToolStripMenuItem.Text = "Select foreground color";
            this.selectForegroundColorToolStripMenuItem.Click += new System.EventHandler(this.selectForegroundColorToolStripMenuItem_Click);
            // 
            // selectBackgroundColorToolStripMenuItem
            // 
            this.selectBackgroundColorToolStripMenuItem.Name = "selectBackgroundColorToolStripMenuItem";
            this.selectBackgroundColorToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.selectBackgroundColorToolStripMenuItem.Text = "Select background color";
            this.selectBackgroundColorToolStripMenuItem.Click += new System.EventHandler(this.selectBackgroundColorToolStripMenuItem_Click);
            // 
            // selectBorderColorToolStripMenuItem
            // 
            this.selectBorderColorToolStripMenuItem.Name = "selectBorderColorToolStripMenuItem";
            this.selectBorderColorToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.selectBorderColorToolStripMenuItem.Text = "Select border color";
            this.selectBorderColorToolStripMenuItem.Click += new System.EventHandler(this.selectBorderColorToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // MiExit
            // 
            this.MiExit.Name = "MiExit";
            this.MiExit.Size = new System.Drawing.Size(202, 22);
            this.MiExit.Text = "Exit";
            this.MiExit.Click += new System.EventHandler(this.MiExit_Click);
            // 
            // PnlMain
            // 
            this.PnlMain.BackColor = System.Drawing.Color.Transparent;
            this.PnlMain.ColumnCount = 1;
            this.PnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlMain.Controls.Add(this.PnlDate, 0, 1);
            this.PnlMain.Controls.Add(this.PnlTime, 0, 0);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 0);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.RowCount = 2;
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.PnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.PnlMain.Size = new System.Drawing.Size(1103, 459);
            this.PnlMain.TabIndex = 1;
            // 
            // PnlDate
            // 
            this.PnlDate.BackColor = System.Drawing.Color.Transparent;
            this.PnlDate.Controls.Add(this.LbDate);
            this.PnlDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDate.Location = new System.Drawing.Point(30, 321);
            this.PnlDate.Margin = new System.Windows.Forms.Padding(30, 0, 30, 30);
            this.PnlDate.Name = "PnlDate";
            this.PnlDate.Size = new System.Drawing.Size(1043, 108);
            this.PnlDate.TabIndex = 1;
            // 
            // LbDate
            // 
            this.LbDate.BackColor = System.Drawing.Color.Transparent;
            this.LbDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDate.ForeColor = System.Drawing.Color.White;
            this.LbDate.Location = new System.Drawing.Point(0, 0);
            this.LbDate.Name = "LbDate";
            this.LbDate.Size = new System.Drawing.Size(1043, 108);
            this.LbDate.TabIndex = 1;
            this.LbDate.Text = "Segunda-feira, 15 de fevereiro de 2022";
            this.LbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlTime
            // 
            this.PnlTime.BackColor = System.Drawing.Color.Transparent;
            this.PnlTime.Controls.Add(this.LbTime);
            this.PnlTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTime.Location = new System.Drawing.Point(30, 30);
            this.PnlTime.Margin = new System.Windows.Forms.Padding(30);
            this.PnlTime.Name = "PnlTime";
            this.PnlTime.Size = new System.Drawing.Size(1043, 261);
            this.PnlTime.TabIndex = 0;
            // 
            // LbTime
            // 
            this.LbTime.BackColor = System.Drawing.Color.Transparent;
            this.LbTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 147.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTime.ForeColor = System.Drawing.Color.White;
            this.LbTime.Location = new System.Drawing.Point(0, 0);
            this.LbTime.Name = "LbTime";
            this.LbTime.Size = new System.Drawing.Size(1043, 261);
            this.LbTime.TabIndex = 0;
            this.LbTime.Text = "12:34:56";
            this.LbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1103, 459);
            this.ContextMenuStrip = this.MainMenu;
            this.Controls.Add(this.PnlMain);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desktop Clock";
            this.MainMenu.ResumeLayout(false);
            this.PnlMain.ResumeLayout(false);
            this.PnlDate.ResumeLayout(false);
            this.PnlTime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem selectForegroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectBackgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MiExit;
        private System.Windows.Forms.TableLayoutPanel PnlMain;
        private System.Windows.Forms.Panel PnlDate;
        private System.Windows.Forms.Panel PnlTime;
        private System.Windows.Forms.Label LbTime;
        private System.Windows.Forms.Label LbDate;
        private System.Windows.Forms.ToolStripMenuItem selectBorderColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleWindowFrameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem togglSecondsToolStripMenuItem;
    }
}

