namespace wage_calculator
{
    public partial class WageCalcMainWindow : Form
    {
        public WageCalcMainWindow()
        {
            InitializeComponent();
        }

        private void WageCalcMainWindow_Load(object sender, EventArgs e)
        {
            AnnualWageRadioBtn.Select();
        }
    }
}
