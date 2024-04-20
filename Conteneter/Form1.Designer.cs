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
            lstvData.Location = new Point(25, 111);
            lstvData.Name = "lstvData";
            lstvData.Size = new Size(894, 475);
            lstvData.TabIndex = 0;
            lstvData.UseCompatibleStateImageBehavior = false;
            lstvData.View = View.Details;
            // 
            // BtnOpen
            // 
            BtnOpen.Location = new Point(12, 23);
            BtnOpen.Name = "BtnOpen";
            BtnOpen.Size = new Size(148, 70);
            BtnOpen.TabIndex = 1;
            BtnOpen.Text = "Open";
            BtnOpen.UseVisualStyleBackColor = true;
            BtnOpen.Click += BtnOpen_Click;
            // 
            // TxtArtist
            // 
            TxtArtist.Location = new Point(259, 45);
            TxtArtist.Name = "TxtArtist";
            TxtArtist.Size = new Size(125, 27);
            TxtArtist.TabIndex = 2;
            // 
            // BtnArtist
            // 
            BtnArtist.Location = new Point(429, 34);
            BtnArtist.Name = "BtnArtist";
            BtnArtist.Size = new Size(129, 48);
            BtnArtist.TabIndex = 3;
            BtnArtist.Text = "Artist";
            BtnArtist.UseVisualStyleBackColor = true;
            BtnArtist.Click += BtnArtist_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 614);
            Controls.Add(BtnArtist);
            Controls.Add(TxtArtist);
            Controls.Add(BtnOpen);
            Controls.Add(lstvData);
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
