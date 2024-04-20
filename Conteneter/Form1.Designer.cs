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
            SuspendLayout();
            // 
            // lstvData
            // 
            lstvData.Location = new Point(10, 83);
            lstvData.Margin = new Padding(3, 2, 3, 2);
            lstvData.Name = "lstvData";
            lstvData.Size = new Size(963, 508);
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
            TxtArtist.Location = new Point(227, 34);
            TxtArtist.Margin = new Padding(3, 2, 3, 2);
            TxtArtist.Name = "TxtArtist";
            TxtArtist.Size = new Size(110, 23);
            TxtArtist.TabIndex = 2;
            // 
            // BtnArtist
            // 
            BtnArtist.Location = new Point(375, 26);
            BtnArtist.Margin = new Padding(3, 2, 3, 2);
            BtnArtist.Name = "BtnArtist";
            BtnArtist.Size = new Size(113, 36);
            BtnArtist.TabIndex = 3;
            BtnArtist.Text = "Artist";
            BtnArtist.UseVisualStyleBackColor = true;
            BtnArtist.Click += BtnArtist_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 602);
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
    }
}
