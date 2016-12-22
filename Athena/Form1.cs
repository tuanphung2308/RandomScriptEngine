using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CheatEngine;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Athena
{
    public partial class Form1 : Form
    {
        private CheatEngineLibrary lib;

        private List<Hack> HackList = new List<Hack>();
        private List<CheckBox> allCheckBoxes = new List<CheckBox>();

        //counter for script
        private int counter = 0;
        private int hackCounter = 0;

        private int itemScriptCounter = 0;
        private string itemFilterScript;
        private int xValue = 10;
        private int yValue = 10;

        public string loadCheatFromTXT(string fileName)
        {
            string text;
            var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                text = streamReader.ReadToEnd();
            }
            //MessageBox.Show(text);
            return text;
        }

        // Token: 0x0600005D RID: 93 RVA: 0x00002480 File Offset: 0x00000680
        public Form1()
        {
            this.lib = new CheatEngineLibrary();
            this.lib.loadEngine();
            this.InitializeComponent();
            initHack();
        }

        // Token: 0x0600005E RID: 94 RVA: 0x00002630 File Offset: 0x00000830
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void initHack()
        {
            string[] scripts = Directory.GetFiles("scr");
            for (int i = 0; i < scripts.Length; i++)
            {
                string fileName = scripts[i].Substring(4, scripts[i].Length - 8);
                //MessageBox.Show(text3);
                //this.GuardMode = new Athena.Hack("GuardMode", "GuardMode", counter++);

                CheckBox checkBox = new CheckBox();
                checkBox.Top = this.yValue;
                //MessageBox.Show(Convert.ToString(checkBox.Top));


                checkBox.Left = this.xValue + this.Width * (counter % 2) / 2;
                checkBox.Name = fileName;
                checkBox.Text = fileName;
                checkBox.AutoSize = true;

                //add Event
                checkBox.Click += new EventHandler(this.tickHack);
                //checkBox.Click += new EventHandler(this.tickHack);

                //push to list
                allCheckBoxes.Add(checkBox);

                //finally display it by adding to control
                this.scrPanel.Controls.Add(checkBox);

                //push to HackList
                string script = loadCheatFromTXT("scr\\" + fileName + ".txt");

                //declare new hack
                Hack aHack = new Hack(fileName, script, checkBox);
                int NoParameters = (new Regex("Parameter")).Matches(script).Count;

                //script has parameter(s)
                List<TextBox> additionalControl = new List<TextBox>();
                if (NoParameters > 0)
                {
                    for (int j = 0; j < NoParameters; j++)
                    {
                        TextBox textbox = new TextBox();
                        textbox.Top = this.yValue - 3;
                        textbox.Left = checkBox.Left + checkBox.Width + j * 80;
                        textbox.Width = 70;
                        textbox.Name = "parameter" + j;
                        textbox.AutoSize = true;
                        additionalControl.Add(textbox);
                        this.scrPanel.Controls.Add(textbox);
                    }
                    aHack.setAdditionalTbx(additionalControl); //Set additional control                      
                }

                //Move down
                if (counter % 2 == 1) yValue += 20;
                counter++;

                this.HackList.Add(aHack);
            }
        }

        private void tickHack(object sender, EventArgs e)
        {
            if (!this.Text.Equals("Athena Trainer"))
            {
                foreach (Hack current in this.HackList)
                {
                    if (current.getAdditionalTbx() == null)
                    {
                        if (current.getCheckBox() != null && current.getCheckBox().GetHashCode() == sender.GetHashCode())
                        {
                            this.lib.iActivateRecord(current.getCounter(), current.getCheckBox().Checked);
                            break;
                        }
                    }
                    else
                    {
                        if (current.getCheckBox() != null && current.getCheckBox().GetHashCode() == sender.GetHashCode())
                        {
                            if (current.getCheckBox().Checked == true)
                            {
                                int tbxCounter = 1;
                                string executeScript = current.getScript();
                                foreach (TextBox para in current.getAdditionalTbx())
                                {
                                    if (para.Text.Equals(""))
                                    {
                                        MessageBox.Show("Dont leave any field empty ;)");
                                        current.getCheckBox().Checked = false;
                                        break;
                                    }
                                    else
                                    {
                                        executeScript = executeScript.Replace("Parameter" + tbxCounter, para.Text);
                                        tbxCounter++;
                                    }
                                }

                                this.lib.iAddScript(current.getName(), executeScript);
                                current.setCounter(hackCounter);
                                hackCounter++;
                                this.lib.iActivateRecord(current.getCounter(), true);
                                break;
                            }
                            else
                            {
                                MessageBox.Show("toggling off");
                                this.lib.iActivateRecord(current.getCounter(), false);
                            }
                        }
                    }
                }
            }
            else
            {
                CheckBox current = (CheckBox)(sender);
                current.Checked = false;
                MessageBox.Show("Please select a process for god's sake");
            }
        }

        private void activateHackByName(string name)
        {
            foreach (Hack current in this.HackList)
            {
                if (current.getName().Equals(name))
                {
                    this.lib.iActivateRecord(current.getCounter(), true);
                    current.getCheckBox().Checked = true;
                    break;
                }
            }
        }

        private void activateHackByName(string[] parameters, string name)
        {
            foreach (Hack current in this.HackList)
            {
                if (current.getName().Equals(name))
                {
                    if (current.getCheckBox().Checked == false)
                    {
                        int tbxCounter = 1;
                        string executeScript = current.getScript();
                        foreach (TextBox para in current.getAdditionalTbx())
                        {
                            para.Text = parameters[tbxCounter - 1].ToString();
                            executeScript = executeScript.Replace("Parameter" + tbxCounter, para.Text);
                            tbxCounter++;
                        }

                        this.lib.iAddScript(current.getName(), executeScript);
                        current.setCounter(hackCounter);
                        hackCounter++;
                        current.getCheckBox().Checked = true;
                        this.lib.iActivateRecord(current.getCounter(), true);
                        break;
                    }
                }
            }
        }

        private void ProcessSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = this.ProcessSelect.SelectedItem.ToString();
            text = text.Substring(0, text.IndexOf('-', 0));
            if (!text.Equals(""))
            {
                this.lib.iOpenProcess(text);
                this.Text = this.ProcessSelect.Text + " - Athena Trainer";
                //add to CElibscript
                foreach (Hack current in HackList)
                {
                    if (current.getAdditionalTbx() == null)
                    {
                        this.lib.iAddScript(current.getName(), current.getScript());
                        current.setCounter(hackCounter);
                        hackCounter++;
                    }
                    else
                    {
                        //Ok fine
                        //MessageBox.Show(current.getName());
                    }
                }
            }
        }

        private void LoadPreSavedHack()
        {
            int lineCounter = 0;
            string line;

            // Read the file and display it line by line.
            StreamReader file = new StreamReader("AutoActivate.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (!line.Contains(":"))
                {
                    activateHackByName(line);
                }
                else
                {
                    string hackName = line.Substring(0, line.IndexOf(":"));
                    string substr = line.Substring(line.IndexOf(":") + 2, line.Length - line.IndexOf(":") - 2);
                    string[] parameters = substr.Split(' ');
                    activateHackByName(parameters, hackName);
                }
                lineCounter++;
            }
            file.Close();
            //MessageBox.Show(text);

            this.itemFilterScript = loadCheatFromTXT("itemFilter\\itemFilter.txt");

            counter = 0;
            string itemList = "";

            // Read the file and display it line by line.
            itemList = loadCheatFromTXT("itemFilter\\List.txt");
            itemListTbx.Text = itemList;
        }

        private void ProcessSelect_DropDown(object sender, EventArgs e)
        {
            this.ProcessSelect.Items.Clear();
            string input;
            this.lib.iGetProcessList(out input);
            string[] array = Regex.Split(input, "\r\n");
            for (int i = 0; i < array.Length; i++)
            {
                string text = array[i];
                if (text.ToLower().Contains("maplestory.exe"))
                {
                    this.ProcessSelect.Items.Add(text);
                }
            }
        }

        private void acceptRadio_CheckedChanged(object sender, EventArgs e)
        {
            acceptRadio.Checked = true;
            rejectRadio.Checked = false;
        }

        private void rejectRadio_CheckedChanged(object sender, EventArgs e)
        {
            acceptRadio.Checked = false;
            rejectRadio.Checked = true;
        }

        private void enFilterBtn_Click(object sender, EventArgs e)
        {
            if (acceptRadio.Checked || rejectRadio.Checked)
            {
                if (acceptRadio.Checked == false)
                {
                    this.itemFilterScript = this.itemFilterScript.Replace("[Replace Mode]", "dd #1");
                }
                else
                {
                    this.itemFilterScript = this.itemFilterScript.Replace("[Replace Mode]", "dd #0");
                }

                /*************************************************************************
                 * PARSE ITEM LIST TEXT BOX***********************************************
                 ************************************************************************/

                string itemList = "";
                using (StringReader reader = new StringReader(itemListTbx.Text))
                {
                    string line = string.Empty;
                    do
                    {
                        line = reader.ReadLine();
                        if (line != null)
                        {
                            itemList += "dd #" + line + Environment.NewLine;
                        }

                    } while (line != null);
                }

                this.itemFilterScript = this.itemFilterScript.Replace("[Replace Item]", itemList);

                this.lib.iAddScript("IF", itemFilterScript);

                if (this.itemScriptCounter == 0)
                {
                    this.itemScriptCounter = counter;
                    counter++;
                }
                enFilterBtn.BackColor = Color.Green;
                enFilterBtn.Text = "Enabled";
                enFilterBtn.Enabled = false;
                this.lib.iActivateRecord(this.itemScriptCounter, true);
            }
            else
            {
                MessageBox.Show("Please Select Accept/Reject");
            }
        }

        private void offFilterBtn_Click(object sender, EventArgs e)
        {
            if (enFilterBtn.BackColor.Equals(Color.Green))
            {
                this.lib.iActivateRecord(this.itemScriptCounter, false);
                enFilterBtn.BackColor = Color.Red;
                enFilterBtn.Text = "Enable";
                enFilterBtn.Enabled = true;
            }
            else
            {
                MessageBox.Show("wtf dude?");
            }
        }

        private void loadSave_Click(object sender, EventArgs e)
        {
            LoadPreSavedHack();
        }
    }
}
