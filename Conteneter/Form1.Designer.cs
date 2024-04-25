namespace Conteneter
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstvData = new ListView();
            BtnOpen = new Button();
            TxtArtist = new TextBox();
            BtnArtist = new Button();
            DateSearchBtn = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lstvData
            // 
            lstvData.Location = new Point(10, 83);
            lstvData.Margin = new Padding(3, 2, 3, 2);
            lstvData.Name = "lstvData";
            lstvData.Size = new Size(1059, 508);
            lstvData.TabIndex = 0;
            lstvData.UseCompatibleStateImageBehavior = false;
            lstvData.View = View.Details;
            // 
            // BtnOpen
            // 
            BtnOpen.Location = new Point(10, 17);
            BtnOpen.Margin = new Padding(3, 2, 3, 2);
            BtnOpen.Name = "BtnOpen";
            BtnOpen.Size = new Size(130, 52);
            BtnOpen.TabIndex = 1;
            BtnOpen.Text = "Open";
            BtnOpen.UseVisualStyleBackColor = true;
            BtnOpen.Click += BtnOpen_Click;
            // 
            // TxtArtist
            // 
            TxtArtist.Location = new Point(180, 34);
            TxtArtist.Margin = new Padding(3, 2, 3, 2);
            TxtArtist.Name = "TxtArtist";
            TxtArtist.Size = new Size(110, 23);
            TxtArtist.TabIndex = 2;
            // 
            // BtnArtist
            // 
            BtnArtist.Location = new Point(296, 25);
            BtnArtist.Margin = new Padding(3, 2, 3, 2);
            BtnArtist.Name = "BtnArtist";
            BtnArtist.Size = new Size(113, 36);
            BtnArtist.TabIndex = 3;
            BtnArtist.Text = "Artist";
            BtnArtist.UseVisualStyleBackColor = true;
            BtnArtist.Click += BtnArtist_Click;
            // 
            // DateSearchBtn
            // 
            DateSearchBtn.Location = new Point(510, 25);
            DateSearchBtn.Margin = new Padding(3, 2, 3, 2);
            DateSearchBtn.Name = "DateSearchBtn";
            DateSearchBtn.Size = new Size(113, 36);
            DateSearchBtn.TabIndex = 4;
            DateSearchBtn.Text = "Search for date";
            DateSearchBtn.UseVisualStyleBackColor = true;
            DateSearchBtn.Click += DateSearchBtn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(755, 6);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(80, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(755, 46);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(80, 23);
            dateTimePicker2.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Location = new Point(651, 12);
            label1.Name = "label1";
            label1.Size = new Size(72, 17);
            label1.TabIndex = 7;
            label1.Text = "earliest date";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.Location = new Point(651, 52);
            label2.Name = "label2";
            label2.Size = new Size(72, 17);
            label2.TabIndex = 8;
            label2.Text = "last date";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 602);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(DateSearchBtn);
            Controls.Add(BtnArtist);
            Controls.Add(TxtArtist);
            Controls.Add(BtnOpen);
            Controls.Add(lstvData);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstvData;
        private Button BtnOpen;
        private TextBox TxtArtist;
        private Button BtnArtist;
        private Button DateSearchBtn;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
    }
}
