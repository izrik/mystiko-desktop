using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mystiko
{
    public class SetKeyForm : Form
    {
        readonly TextBox textbox;
        readonly Button okButton;
        readonly Button cancelButton;

        public SetKeyForm(string value=null)
        {
            value = value ?? "";
            
            this.Name = "SetKeyForm";
            this.Text = "Set Key";
            this.SuspendLayout();

            int padding = 10;

            cancelButton = new Button();
            cancelButton.Name = "cancel";
            cancelButton.Text = "Cancel";
            var size = this.ClientSize;
            cancelButton.Location = new Point(size.Width - padding - cancelButton.Width,
                                              size.Height - padding - cancelButton.Height);
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.Click += CancelButton_Click;

            okButton = new Button();
            okButton.Name = "ok";
            okButton.Text = "OK";
            okButton.Location = new Point(cancelButton.Location.X - padding - okButton.Width,
                                          cancelButton.Location.Y);
            okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okButton.Click += OkButton_Click;

            textbox = new TextBox();
            textbox.Dock = DockStyle.Fill;
            textbox.Multiline = true;
            textbox.Name = "textbox";
            textbox.Location = new Point(padding, padding);
            textbox.Size = new Size(size.Width - padding - textbox.Location.X,
                                    okButton.Location.Y - padding - textbox.Location.Y);
            textbox.TabIndex = 1;
            textbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right |
                AnchorStyles.Left | AnchorStyles.Top;
            textbox.Text = value;

            this.Controls.Add(textbox);
            this.Controls.Add(okButton);
            this.Controls.Add(cancelButton);
            this.AcceptButton = okButton;
            this.CancelButton = cancelButton;
            this.ResumeLayout(false);
        }

        public string Value
        {
            get { return textbox.Text; }
        }

        void OkButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
