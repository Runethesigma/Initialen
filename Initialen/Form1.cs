namespace Initialen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*==========Analyse==========

1. Invoer:Welke invoer mag ik verwachten in de eerste situatie? Geef zowel een naam/beschrijving als een datatype.
        Een Voornaam - string
        Een Naam - string

2. Bewerking:Welke stappen moet je doorlopen om in de eerste situatie de initialen te bepalen? Welke ingebouwde functie ga je hiervoor gebruiken?
        De naam en voornaam een string maken
        de eerste 2 letters van de naam er uit halen
        de eerste letter van de voornaam er uit halen
        Allebij in uppercase zetten
        de 2 letters samen met de 1 letter displayen 

----------------------------------------------
3. Invoer:Welke invoer mag je verwachten in de tweede situatie? Geef zowel een naam/beschrijving als een datatype.
        Een voornaam + een naam - string

4. Bewerking:Welke stappen moet je doorlopen om in de tweede situatie de initialen te bepalen? Welke ingebouwde functies ga je hiervoor gebruiken?
        van de naam en voornaam een string maken
        de lengte van het woord op vragen
        de plaats waar de spatie zit opvragen
        met die twee gegevens gaan kijken op welke plaats de voornaam en de naam zit en ze apart zetten:
        de eerste 2 letters van de naam er uit halen
        de eerste letter van de voornaam er uit halen
        Allebij in uppercase zetten
        de 2 letters samen met de 1 letter displayen

5.Testdata: Verzin en noteer testgegevens, en bereken zelf de juiste oplossing. Zo weet je of je oefening klopt.

========== Analyse========== */
        private void ApartButton_Click(object sender, EventArgs e)
        {
            string Voornaam = Convert.ToString(VoornaamTextBox.Text);
            string Naam = Convert.ToString(NaamTextBox.Text);
            string InitialenNaam = Naam.Substring(0, 2);
            string InitialenVoornaam = Voornaam.Substring(0, 1);
            string UpperCaseNaam = InitialenNaam.ToUpper();
            string UpperCaseVoornaam = InitialenVoornaam.ToUpper();
            InitialenApartLabel.Text = UpperCaseNaam + UpperCaseVoornaam;

        }

        private void SamenButton_Click(object sender, EventArgs e)
        {
            string VoornaamNaam = Convert.ToString(VoornaamNaamTextBox.Text);
            int lengte = VoornaamNaam.Length;
            int spatiePlaats = VoornaamNaam.IndexOf(" ");
            string Voornaam = VoornaamNaam.Substring(0, spatiePlaats);
            string Naam = VoornaamNaam.Substring(spatiePlaats, (lengte - spatiePlaats));
            string InitialenNaam = Naam.Substring(1, 2);
            string InitialenVoornaam = Voornaam.Substring(0, 1);
            string UpperCaseNaam = InitialenNaam.ToUpper();
            string UpperCaseVoornaam = InitialenVoornaam.ToUpper();
            InitialenSamenLabel.Text = UpperCaseNaam + UpperCaseVoornaam;
        }
    }
}
