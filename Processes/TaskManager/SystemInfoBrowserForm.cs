using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public class SystemInfoBrowserForm : Form
    {
        private ListBox listBox1;
        private TextBox textBox1;

        public SystemInfoBrowserForm()
        {
            SuspendLayout();
            InitForm();

            Type t = typeof(SystemInformation);
            PropertyInfo[] pi = t.GetProperties();
            for (int i = 0; i < pi.Length; i++)
                listBox1.Items.Add(pi[i].Name);
            textBox1.Text = "This system has " + pi.Length.ToString() + " properties.\r\n";

            listBox1.SelectedIndexChanged += new EventHandler(listBox1_SelectedIndexChanged);
            ResumeLayout(false);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            string propname = listBox1.Text;
            if (propname == "PowerStatus")
            {
                textBox1.Text += "\r\nPowerStatus property is:";
                Type t = typeof(PowerStatus);
                PropertyInfo[] pi = t.GetProperties();
                for (int i = 0; i < pi.Length; i++)
                {
                    object propval = pi[i].GetValue(SystemInformation.PowerStatus, null);
                    textBox1.Text += "\r\n    PowerStatus." + pi[i].Name + " is: " + propval.ToString();
                }
            }
            else
            {
                Type t = typeof(SystemInformation);
                PropertyInfo[] pi = t.GetProperties();
                PropertyInfo prop = null;
                for (int i = 0; i < pi.Length; i++)
                    if (pi[i].Name == propname)
                    {
                        prop = pi[i];
                        break;
                    }
                object propval = prop.GetValue(null, null);
                textBox1.Text += "\r\n" + propname + " is: " + propval.ToString();
            }
        }

        private void InitForm()
        {
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.Location = new System.Drawing.Point(8, 16);
            listBox1.Size = new System.Drawing.Size(172, 496);
            listBox1.TabIndex = 0;

            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBox1.Location = new System.Drawing.Point(188, 16);
            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new System.Drawing.Size(420, 496);
            textBox1.TabIndex = 1;
            ClientSize = new System.Drawing.Size(616, 525);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Text = "Select a SystemInformation property to get the value of";
        }
    }
}
