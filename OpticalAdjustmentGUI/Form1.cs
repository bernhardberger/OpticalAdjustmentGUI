using System.Diagnostics;
using System.Globalization;
using System.Security.Policy;

namespace OpticalAdjustmentGUI
{
    public partial class Form1 : Form
    {
        protected string filePath = "value.cfg";
        protected Decimal value = new Decimal(0);
        protected bool enabled = false;

        public Form1()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ".";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.disableControls();

            if (this.checkBox1.Checked)
            {
                this.btnApply.Enabled = false;
            }

            if (this.checkBox2.Checked)
            {
                this.btnSave.Enabled = false;
            }

            if (File.Exists(this.filePath))
            {
                string content = File.ReadAllText(filePath);
                this.value = Decimal.Parse(content);
                numericUpDown1.Text = content;
            }
            else
            {

            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            this.apply(this.value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.value = numericUpDown1.Value;
            if (checkBox1.Checked)
            {
                apply(this.value);
            }
        }

        protected void apply(Decimal value)
        {
            string toolPath = "OpticalAdjustment.exe"; // Replace with the actual path to the command-line tool if it's located elsewhere
            string arguments = $"--value={value}";

            ProcessStartInfo processStartInfo = new ProcessStartInfo(toolPath, arguments);
            processStartInfo.CreateNoWindow = true;       // Hide the process window
            processStartInfo.UseShellExecute = false;     // Do not use the system shell to execute the process
            Process.Start(processStartInfo);

            if (this.checkBox2.Checked)
            {
                this.save(this.value);
            }
        }

        protected void deactivate()
        {
            string toolPath = "OpticalAdjustment.exe"; // Replace with the actual path to the command-line tool if it's located elsewhere
            string arguments = $"--value=-1.0";

            ProcessStartInfo processStartInfo = new ProcessStartInfo(toolPath);
            processStartInfo.CreateNoWindow = true;       // Hide the process window
            processStartInfo.UseShellExecute = false;     // Do not use the system shell to execute the process
            Process.Start(processStartInfo);
        }

        protected void save(Decimal value)
        {
            File.WriteAllText(this.filePath, value.ToString());
        }

        private void disableControls()
        {
            this.btnApply.Enabled = false;
            this.checkBox1.Enabled = false;
            this.numericUpDown1.Enabled = false;
            this.btnSave.Enabled = false;
            this.checkBox2.Enabled = false;

            if (this.checkBox1.Checked)
            {
                this.btnApply.Enabled = false;
            }

            if (this.checkBox2.Checked)
            {
                this.btnSave.Enabled = false;
            }
        }

        private void enableControls()
        {
            this.btnApply.Enabled = true;
            this.checkBox1.Enabled = true;
            this.numericUpDown1.Enabled = true;
            this.btnSave.Enabled = true;
            this.checkBox2.Enabled = true;

            if (this.checkBox1.Checked)
            {
                this.btnApply.Enabled = false;
            }

            if (this.checkBox2.Checked)
            {
                this.btnSave.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.btnApply.Enabled = false;
            }
            else
            {
                this.btnApply.Enabled = true;
            }
        }

        private void btnEnableToggle_Click(object sender, EventArgs e)
        {
            if (this.enabled)
            {

                this.enabled = false;
                btnEnableToggle.Text = "Activate";

                this.disableControls();


                this.apply(new Decimal(-1.0f));
            }
            else
            {
                this.enabled = true;
                btnEnableToggle.Text = "Deactivate";

                this.enableControls();

                this.apply(this.value);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                this.btnSave.Enabled = false;
            }
            else
            {
                this.btnSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.save(this.value);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string surveyUrl = "https://survey-eu1.hsforms.com/1WFHW3LFKRCe-_LaO0_m_cAfa586";
            try
            {
                Process.Start(new ProcessStartInfo() { FileName = surveyUrl, UseShellExecute = true });
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }
    }
}