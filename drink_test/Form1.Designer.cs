namespace Drinks
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelAlcohol = new Label();
            labelLiqour = new Label();
            labelFruitGreen = new Label();
            buttonGetDrinks = new Button();
            labelExtras = new Label();
            labelJuice = new Label();
            labelSoftdrink = new Label();
            labelSyrup = new Label();
            buttonReset = new Button();
            Alcohol = new CheckedListBox();
            Liqour = new CheckedListBox();
            Syrup = new CheckedListBox();
            Soft_Drink = new CheckedListBox();
            Juice = new CheckedListBox();
            Fruit_Green = new CheckedListBox();
            Extras = new CheckedListBox();
            label1 = new Label();
            IceCubes = new CheckedListBox();
            SuspendLayout();
            // 
            // labelAlcohol
            // 
            labelAlcohol.AutoSize = true;
            labelAlcohol.Font = new Font("Copperplate Gothic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelAlcohol.Location = new Point(12, 14);
            labelAlcohol.Name = "labelAlcohol";
            labelAlcohol.Size = new Size(122, 25);
            labelAlcohol.TabIndex = 1;
            labelAlcohol.Text = "Alcohol";
            // 
            // labelLiqour
            // 
            labelLiqour.AutoSize = true;
            labelLiqour.Font = new Font("Copperplate Gothic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelLiqour.Location = new Point(178, 14);
            labelLiqour.Name = "labelLiqour";
            labelLiqour.Size = new Size(100, 25);
            labelLiqour.TabIndex = 14;
            labelLiqour.Text = "Liqour";
            // 
            // labelFruitGreen
            // 
            labelFruitGreen.AutoSize = true;
            labelFruitGreen.Font = new Font("Copperplate Gothic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelFruitGreen.Location = new Point(908, 14);
            labelFruitGreen.Name = "labelFruitGreen";
            labelFruitGreen.Size = new Size(181, 25);
            labelFruitGreen.TabIndex = 66;
            labelFruitGreen.Text = "Fruit/Green";
            // 
            // buttonGetDrinks
            // 
            buttonGetDrinks.AutoSize = true;
            buttonGetDrinks.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGetDrinks.Location = new Point(568, 466);
            buttonGetDrinks.Name = "buttonGetDrinks";
            buttonGetDrinks.Size = new Size(154, 50);
            buttonGetDrinks.TabIndex = 96;
            buttonGetDrinks.Text = "Get Drinks";
            buttonGetDrinks.UseVisualStyleBackColor = true;
            // 
            // labelExtras
            // 
            labelExtras.AutoSize = true;
            labelExtras.Font = new Font("Copperplate Gothic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelExtras.Location = new Point(1108, 14);
            labelExtras.Name = "labelExtras";
            labelExtras.Size = new Size(103, 25);
            labelExtras.TabIndex = 97;
            labelExtras.Text = "Extras";
            // 
            // labelJuice
            // 
            labelJuice.AutoSize = true;
            labelJuice.Font = new Font("Copperplate Gothic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelJuice.Location = new Point(730, 14);
            labelJuice.Name = "labelJuice";
            labelJuice.Size = new Size(80, 25);
            labelJuice.TabIndex = 100;
            labelJuice.Text = "Juice";
            // 
            // labelSoftdrink
            // 
            labelSoftdrink.AutoSize = true;
            labelSoftdrink.Font = new Font("Copperplate Gothic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelSoftdrink.Location = new Point(530, 14);
            labelSoftdrink.Name = "labelSoftdrink";
            labelSoftdrink.Size = new Size(144, 25);
            labelSoftdrink.TabIndex = 101;
            labelSoftdrink.Text = "Softdrink";
            // 
            // labelSyrup
            // 
            labelSyrup.AutoSize = true;
            labelSyrup.Font = new Font("Copperplate Gothic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelSyrup.Location = new Point(357, 14);
            labelSyrup.Name = "labelSyrup";
            labelSyrup.Size = new Size(90, 25);
            labelSyrup.TabIndex = 107;
            labelSyrup.Text = "Syrup";
            // 
            // buttonReset
            // 
            buttonReset.AutoSize = true;
            buttonReset.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReset.Location = new Point(12, 466);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(154, 50);
            buttonReset.TabIndex = 113;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // Alcohol
            // 
            Alcohol.FormattingEnabled = true;
            Alcohol.Items.AddRange(new object[] { "White Rome", "Dark Rome", "Vodka", "Whiskey", "Tequila", "Jägermeister", "Gin", "Bailey's", "Malibu", "Råstof" });
            Alcohol.Location = new Point(12, 51);
            Alcohol.Name = "Alcohol";
            Alcohol.Size = new Size(138, 334);
            Alcohol.TabIndex = 114;
            // 
            // Liqour
            // 
            Liqour.FormattingEnabled = true;
            Liqour.Items.AddRange(new object[] { "Yellow_Banana", "Pisang_Ambon", "Blue_Curacao", "Peppermint", "Coffee", "Vanilla", "Cocoa", "Peach", "Triple_Sec", "Egg" });
            Liqour.Location = new Point(178, 51);
            Liqour.Name = "Liqour";
            Liqour.Size = new Size(136, 334);
            Liqour.TabIndex = 115;
            // 
            // Syrup
            // 
            Syrup.FormattingEnabled = true;
            Syrup.Items.AddRange(new object[] { "Mango", "Sugar cane", "Passion", "Grenadine", "Lime" });
            Syrup.Location = new Point(357, 51);
            Syrup.Name = "Syrup";
            Syrup.Size = new Size(125, 334);
            Syrup.TabIndex = 116;
            // 
            // Soft_Drink
            // 
            Soft_Drink.FormattingEnabled = true;
            Soft_Drink.Items.AddRange(new object[] { "Cola", "Sprite", "Lemon_Soda", "Ginger_Beer", "Tonic_Water", "Red_Soda", "Fanta", "Schweppes_Lemon", "Sparkling_Water", "Monster", "Booster", "Redbull" });
            Soft_Drink.Location = new Point(530, 51);
            Soft_Drink.Name = "Soft_Drink";
            Soft_Drink.Size = new Size(162, 334);
            Soft_Drink.TabIndex = 117;
            // 
            // Juice
            // 
            Juice.FormattingEnabled = true;
            Juice.Items.AddRange(new object[] { "Pineapple", "Orange", "Apple", "Passionfruit", "Multijuice", "Ice_Tea", "Lemonade", "Lime", "Lemon", "Grapefruit" });
            Juice.Location = new Point(730, 51);
            Juice.Name = "Juice";
            Juice.Size = new Size(149, 334);
            Juice.TabIndex = 118;
            // 
            // Fruit_Green
            // 
            Fruit_Green.FormattingEnabled = true;
            Fruit_Green.Items.AddRange(new object[] { "apple", "Banana", "orange", "lemon", "lime", "clementine", "passion fruit", "Pineapple", "pear", "strawberry", "blueberry", "peach", "Mango", "Mint Leaf" });
            Fruit_Green.Location = new Point(908, 51);
            Fruit_Green.Name = "Fruit_Green";
            Fruit_Green.Size = new Size(160, 334);
            Fruit_Green.TabIndex = 119;
            // 
            // Extras
            // 
            Extras.FormattingEnabled = true;
            Extras.Items.AddRange(new object[] { "Slush ice", "Bitter", "Cane sugar", "Coconut cream", "Coffee", "Cream" });
            Extras.Location = new Point(1108, 51);
            Extras.Name = "Extras";
            Extras.Size = new Size(136, 158);
            Extras.TabIndex = 120;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1108, 244);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 121;
            label1.Text = "IceCubes";
            // 
            // IceCubes
            // 
            IceCubes.FormattingEnabled = true;
            IceCubes.Items.AddRange(new object[] { "IceCubes", "Crushed IceCubes" });
            IceCubes.Location = new Point(1108, 293);
            IceCubes.Name = "IceCubes";
            IceCubes.Size = new Size(158, 92);
            IceCubes.TabIndex = 122;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 528);
            Controls.Add(IceCubes);
            Controls.Add(label1);
            Controls.Add(Extras);
            Controls.Add(Fruit_Green);
            Controls.Add(Juice);
            Controls.Add(Soft_Drink);
            Controls.Add(Syrup);
            Controls.Add(Liqour);
            Controls.Add(Alcohol);
            Controls.Add(buttonReset);
            Controls.Add(labelSyrup);
            Controls.Add(labelSoftdrink);
            Controls.Add(labelJuice);
            Controls.Add(labelExtras);
            Controls.Add(buttonGetDrinks);
            Controls.Add(labelFruitGreen);
            Controls.Add(labelLiqour);
            Controls.Add(labelAlcohol);
            Name = "Form1";
            Text = "Drinks";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelAlcohol;
        private Label labelLiqour;
        private Label labelFruitGreen;
        private Label labelSyrup;
        private Button buttonGetDrinks;
        private Label labelExtras;
        private Label labelJuice;
        private Label labelSoftdrink;
        private Button buttonReset;
        private CheckedListBox Alcohol;
        private CheckedListBox Liqour;
        private CheckedListBox Syrup;
        private CheckedListBox Soft_Drink;
        private CheckedListBox Juice;
        private CheckedListBox Fruit_Green;
        private CheckedListBox Extras;
        private Label label1;
        private CheckedListBox IceCubes;
    }
}