using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mystiko
{
    public class MystikoForm : Form
    {
        public static void Main(string[] args)
        {
            var form = new MystikoForm();
            Application.Run(form);
        }

        readonly TextBox textbox;
        readonly MenuStrip menu;

        string key = "";

        public MystikoForm()
        {
            this.Name = "Mystiko";
            this.Text = "Mystiko";
            this.SuspendLayout();

            textbox = new TextBox();
            textbox.Dock = DockStyle.Fill;
            textbox.Multiline = true;
            textbox.Name = "textbox";
            textbox.Size = new Size(308, 25);
            textbox.TabIndex = 1;

            menu = new MenuStrip();
            menu.SuspendLayout();
            menu.Name = "menu";
            menu.Size = new Size(this.ClientSize.Width, 24);
            menu.Text = "menu";
            menu.Location = new Point(0, 0);

            var file = new ToolStripMenuItem();
            file.Name = "file";
            file.Text = "&File";

            var open = new ToolStripMenuItem();
            open.Name = "open";
            open.Text = "&Open...";
            open.ShortcutKeys = (Keys.Control | Keys.O);
            open.Click += Open_Click;

            var save = new ToolStripMenuItem();
            save.Name = "save";
            save.Text = "&Save";
            save.ShortcutKeys = (Keys.Control | Keys.S);
            save.Click += Save_Click;

            var setKey = new ToolStripMenuItem();
            setKey.Name = "setKey";
            setKey.Text = "Set &Key...";
            setKey.ShortcutKeys = (Keys.Control | Keys.K);
            setKey.Click += SetKey_Click;

            var exit = new ToolStripMenuItem();
            exit.Name = "exit";
            exit.Text = "Exit";
            exit.Click += Exit_Click;

            file.DropDownItems.Add(open);
            file.DropDownItems.Add(save);
            file.DropDownItems.Add(setKey);
            file.DropDownItems.Add(exit);
            menu.Items.Add(file);

            this.Controls.Add(textbox);
            this.Controls.Add(menu);
            this.MainMenuStrip = menu;
            menu.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        void Open_Click(object sender, EventArgs e)
        {

        }

        void Save_Click(object sender, EventArgs e)
        {

        }

        void SetKey_Click(object sender, EventArgs e)
        {
            var setKeyForm = new SetKeyForm(key);
            if (setKeyForm.ShowDialog(this) == DialogResult.OK)
            {
                key = setKeyForm.Value;
            }
        }

        void Exit_Click(object sender, EventArgs e)
        {

        }
    }
}
