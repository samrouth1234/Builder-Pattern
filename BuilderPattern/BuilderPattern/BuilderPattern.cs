namespace BuilderPattern_01
{
    public partial class BuilderPattern : Form
    {
        public BuilderPattern()
        {
            InitializeComponent();
        }



        private void buildButton_Click_Click(object sender, EventArgs e)
        {
            IComputerBuilder builder = new GamingComputerBuilder();

            if (gamingRadioButton.Checked) 
            {
                builder = new GamingComputerBuilder();
            }
            else if (officeRadioButton.Checked)
            {
                builder = new OfficeComputerBuilder();
            }
            else
            {
                builder = new GamingComputerBuilder(); // Or throw an exception, show a message, etc.
            }

            // Get user input from TextBoxes
            builder.AddCPU(cpuTextBox.Text);
            builder.AddRAM(ramTextBox.Text);
            builder.AddHDD(hddTextBox.Text);
            builder.AddGPU(gpuTextBox.Text);
            builder.AddOS(osTextBox.Text);

            // claer the data
            cpuTextBox.Clear();
            ramTextBox.Clear();
            hddTextBox.Clear();
            gpuTextBox.Clear();
            osTextBox.Clear();

            Computer computer = builder.GetComputer();

            MessageBox.Show(computer.ToString());
        }
    }
}
