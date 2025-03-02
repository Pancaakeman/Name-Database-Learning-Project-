namespace Name_Database
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Refresh = new Button();
            List_of_People = new ListBox();
            DBName = new TextBox();
            SuspendLayout();
            // 
            // Refresh
            // 
            Refresh.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Refresh.Location = new Point(41, 79);
            Refresh.MinimumSize = new Size(100, 100);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(302, 244);
            Refresh.TabIndex = 1;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += button2_Click;
            // 
            // List_of_People
            // 
            List_of_People.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            List_of_People.Font = new Font("Tahoma", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            List_of_People.FormattingEnabled = true;
            List_of_People.Items.AddRange(new object[] { });
            List_of_People.Location = new Point(407, 34);
            List_of_People.Name = "List_of_People";
            List_of_People.Size = new Size(449, 289);
            List_of_People.TabIndex = 2;
            List_of_People.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // DBName
            // 
            DBName.Location = new Point(41, 34);
            DBName.MaxLength = 32;
            DBName.Name = "DBName";
            DBName.PlaceholderText = "Input Entry Here";
            DBName.Size = new Size(302, 23);
            DBName.TabIndex = 3;
            DBName.TextAlign = HorizontalAlignment.Center;
            DBName.KeyDown += textbox1_KeyDown;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 450);
            Controls.Add(DBName);
            Controls.Add(List_of_People);
            Controls.Add(Refresh);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Name Database";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Refresh;
        private ListBox List_of_People;
        private TextBox DBName;
    }
}
