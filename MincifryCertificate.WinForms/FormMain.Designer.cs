namespace MincifryCertificate.WinForms
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            TB_CheckMachine = new TextBox();
            label2 = new Label();
            B_InstallMachine = new Button();
            B_RemoveMachine = new Button();
            label3 = new Label();
            TB_CheckUser = new TextBox();
            B_InstallUser = new Button();
            B_RemoveUser = new Button();
            label1 = new Label();
            label4 = new Label();
            menuStrip1 = new MenuStrip();
            MI_About = new ToolStripMenuItem();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(TB_CheckMachine, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(B_InstallMachine, 2, 1);
            tableLayoutPanel1.Controls.Add(B_RemoveMachine, 3, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(TB_CheckUser, 1, 2);
            tableLayoutPanel1.Controls.Add(B_InstallUser, 2, 2);
            tableLayoutPanel1.Controls.Add(B_RemoveUser, 3, 2);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Margin = new Padding(10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(414, 75);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // TB_CheckMachine
            // 
            TB_CheckMachine.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TB_CheckMachine.Location = new Point(90, 17);
            TB_CheckMachine.Name = "TB_CheckMachine";
            TB_CheckMachine.ReadOnly = true;
            TB_CheckMachine.Size = new Size(137, 22);
            TB_CheckMachine.TabIndex = 0;
            TB_CheckMachine.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(33, 22);
            label2.Name = "label2";
            label2.Size = new Size(51, 13);
            label2.TabIndex = 1;
            label2.Text = "Система";
            // 
            // B_InstallMachine
            // 
            B_InstallMachine.Anchor = AnchorStyles.None;
            B_InstallMachine.AutoSize = true;
            B_InstallMachine.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            B_InstallMachine.Image = WinForms.icons8.Add16;
            B_InstallMachine.Location = new Point(233, 16);
            B_InstallMachine.Name = "B_InstallMachine";
            B_InstallMachine.Padding = new Padding(1);
            B_InstallMachine.Size = new Size(95, 25);
            B_InstallMachine.TabIndex = 1;
            B_InstallMachine.Text = "Установить";
            B_InstallMachine.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_InstallMachine.UseVisualStyleBackColor = true;
            B_InstallMachine.Click += B_InstallMachine_Click;
            // 
            // B_RemoveMachine
            // 
            B_RemoveMachine.Anchor = AnchorStyles.None;
            B_RemoveMachine.AutoSize = true;
            B_RemoveMachine.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            B_RemoveMachine.Image = WinForms.icons8.Minus16;
            B_RemoveMachine.Location = new Point(334, 16);
            B_RemoveMachine.Name = "B_RemoveMachine";
            B_RemoveMachine.Padding = new Padding(1);
            B_RemoveMachine.Size = new Size(77, 25);
            B_RemoveMachine.TabIndex = 1;
            B_RemoveMachine.Text = "Удалить";
            B_RemoveMachine.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_RemoveMachine.UseVisualStyleBackColor = true;
            B_RemoveMachine.Click += B_RemoveMachine_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 53);
            label3.Name = "label3";
            label3.Size = new Size(81, 13);
            label3.TabIndex = 1;
            label3.Text = "Пользователь";
            // 
            // TB_CheckUser
            // 
            TB_CheckUser.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TB_CheckUser.Location = new Point(90, 48);
            TB_CheckUser.Name = "TB_CheckUser";
            TB_CheckUser.ReadOnly = true;
            TB_CheckUser.Size = new Size(137, 22);
            TB_CheckUser.TabIndex = 0;
            TB_CheckUser.TabStop = false;
            // 
            // B_InstallUser
            // 
            B_InstallUser.Anchor = AnchorStyles.None;
            B_InstallUser.AutoSize = true;
            B_InstallUser.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            B_InstallUser.Image = WinForms.icons8.Add16;
            B_InstallUser.Location = new Point(233, 47);
            B_InstallUser.Name = "B_InstallUser";
            B_InstallUser.Padding = new Padding(1);
            B_InstallUser.Size = new Size(95, 25);
            B_InstallUser.TabIndex = 1;
            B_InstallUser.Text = "Установить";
            B_InstallUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_InstallUser.UseVisualStyleBackColor = true;
            B_InstallUser.Click += B_InstallUser_Click;
            // 
            // B_RemoveUser
            // 
            B_RemoveUser.Anchor = AnchorStyles.None;
            B_RemoveUser.AutoSize = true;
            B_RemoveUser.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            B_RemoveUser.Image = WinForms.icons8.Minus16;
            B_RemoveUser.Location = new Point(334, 47);
            B_RemoveUser.Name = "B_RemoveUser";
            B_RemoveUser.Padding = new Padding(1);
            B_RemoveUser.Size = new Size(77, 25);
            B_RemoveUser.TabIndex = 1;
            B_RemoveUser.Text = "Удалить";
            B_RemoveUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_RemoveUser.UseVisualStyleBackColor = true;
            B_RemoveUser.Click += B_RemoveUser_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(90, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 13);
            label1.TabIndex = 1;
            label1.Text = "Состояние сертификата";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label4, 2);
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(285, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 13);
            label4.TabIndex = 1;
            label4.Text = "Управление";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MI_About });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(434, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // MI_About
            // 
            MI_About.Alignment = ToolStripItemAlignment.Right;
            MI_About.Image = WinForms.icons8.Info16;
            MI_About.Name = "MI_About";
            MI_About.Size = new Size(118, 20);
            MI_About.Text = "О приложении";
            MI_About.Click += MI_About_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 24);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(434, 137);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(434, 161);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(450, 200);
            Name = "FormMain";
            Text = "Минцифры - Сертификат";
            Load += FormMain_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Button B_InstallMachine;
        private Button B_RemoveMachine;
        private Label label3;
        private TextBox TB_CheckMachine;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MI_About;
        private TextBox TB_CheckUser;
        private Button B_InstallUser;
        private Button B_RemoveUser;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label4;
    }
}