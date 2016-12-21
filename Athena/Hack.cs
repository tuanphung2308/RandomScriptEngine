using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Athena
{
    public class Hack
    {
        public Hack(string _name, string _script, int _counter, CheckBox _checkBox)
        {
            this.name = _name;
            this.script = _script;
            this.counter = _counter;
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

        private CheckBox checkBox;
        private string name;
        private string script;
        private int counter;
    }
}
