using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Athena
{
    public class Hack
    {
        public Hack(string _name, string _script, CheckBox _checkBox)
        {
            this.name = _name;
            this.script = _script;
            this.checkBox = _checkBox;
        }

        public string getName()
        {
            return this.name;
        }

        public CheckBox getCheckBox()
        {
            return this.checkBox;
        }

        public string getScript()
        {
            return this.script;
        }

        public int getCounter()
        {
            return this.counter;
        }

        public List<TextBox> getAdditionalTbx()
        {
            return this.addtionalTbx;
        }

        public void setAdditionalTbx(List<TextBox> _additionalTbx)
        {
            this.addtionalTbx = _additionalTbx;
        }

        public void setCounter(int _counter)
        {
            this.counter = _counter;
        }

        private CheckBox checkBox;
        private List<TextBox> addtionalTbx = null;
        private string name;
        private string script;
        private int counter = 0;
    }
}
