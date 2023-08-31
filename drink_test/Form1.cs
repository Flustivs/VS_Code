namespace Drinks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region GUI
        private static void buttonGetDrinks_Click(object sender, EventArgs e)
        {

        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            foreach (var control in this.Controls)
            {
                if (control is CheckedListBox)
                {
                    if (((CheckBox)control).Checked)
                    {
                        ((CheckBox)control).Checked = false;
                    }
                }
            }
            /*
            checkBoxApple.Checked = false;
            checkBoxAppleJuice.Checked = false;
            checkBoxBaileys.Checked = false;
            checkBoxBanana.Checked = false;
            checkBoxBitter.Checked = false;
            checkBoxBlueberry.Checked = false;
            checkBoxBlueCuracao.Checked = false;
            checkBoxBooster.Checked = false;
            checkBoxClementine.Checked = false;
            checkBoxCocoa.Checked = false;
            checkBoxCoconutCream.Checked = false;
            checkBoxCoffee.Checked = false;
            checkBoxCoffeeLiqour.Checked = false;
            checkBoxCola.Checked = false;
            checkBoxCrushedIce.Checked = false;
            checkBoxDarkRum.Checked = false;
            checkBoxEgg.Checked = false;
            checkBoxFanta.Checked = false;
            checkBoxFreshMint.Checked = false;
            checkBoxGin.Checked = false;
            checkBoxGingerBeer.Checked = false;
            checkBoxGrapefruitJuice.Checked = false;
            checkBoxGrenadine.Checked = false;
            checkBoxHeavyCream.Checked = false;
            checkBoxIceCubes.Checked = false;
            checkBoxIcetea.Checked = false;
            checkBoxJägermeister.Checked = false;
            checkBoxLemon.Checked = false;
            checkBoxLemonade.Checked = false;
            checkBoxLemonJuice.Checked = false;
            checkBoxLemonSoda.Checked = false;
            checkBoxLime.Checked = false;
            checkBoxLimeJuice.Checked = false;
            checkBoxLimeSyrup.Checked = false;
            checkBoxMalibu.Checked = false;
            checkBoxMango.Checked = false;
            checkBoxMangoSyrup.Checked = false;
            checkBoxMint.Checked = false;
            checkBoxMonster.Checked = false;
            checkBoxMultiJuice.Checked = false;
            checkBoxOrange.Checked = false;
            checkBoxOrangeJuice.Checked = false;
            checkBoxPassionfruit.Checked = false;
            checkBoxPassionfruitJuice.Checked = false;
            checkBoxPassionfruitSyrup.Checked = false;
            checkBoxPeach.Checked = false;
            checkBoxPeachLiqour.Checked = false;
            checkBoxPear.Checked = false;
            checkBoxPineapple.Checked = false;
            checkBoxPineappleJuice.Checked = false;
            checkBoxPisangAmbon.Checked = false;
            checkBoxRaspberrySoda.Checked = false;
            checkBoxRedBull.Checked = false;
            checkBoxRåstof.Checked = false;
            checkBoxSlushIce.Checked = false;
            checkBoxSparklingWater.Checked = false;
            checkBoxSprite.Checked = false;
            checkBoxStrawberry.Checked = false;
            checkBoxSugar.Checked = false;
            checkBoxSugarCane.Checked = false;
            checkBoxTequila.Checked = false;
            checkBoxTonic.Checked = false;
            checkBoxVanilla.Checked = false;
            checkBoxVodka.Checked = false;
            checkBoxWhisky.Checked = false;
            checkBoxWhiteRum.Checked = false;
            checkBoxYellowBanana.Checked = false;
            */
        }
        #endregion GUI

        #region Logic
        private void Logic()
        {
            foreach (var control in this.Controls)
            {
                if (control is CheckedListBox)
                {
                    if (((CheckBox)control).Checked)
                    {
                        MessageBox.Show("Hej");
                    }
                }
            }
        }
        #endregion Logic

        #region DAL
        private static void DAL()
        {

        }
        #endregion DAL


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}