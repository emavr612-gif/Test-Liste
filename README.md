 1.	Zadatak: Forma za Prijavu
•	Kreirajte formu za prijavu koja zahtijeva korisničko ime i lozinku. Kada se klikne na dugme "Prijava", neka se provjeri jesu li korisničko ime i lozinka ispravni (možete koristiti unaprijed definirane vrijednosti) i neka se prikaže odgovarajuća poruka.
2.	Zadatak: Kalkulator
•	Izrada jednostavnog kalkulatora. Forma treba sadržavati tekstualna polja za unos dva broja i dugmad za osnovne matematičke operacije (zbrajanje, oduzimanje, množenje, dijeljenje). Klikom na dugme, rezultat operacije treba biti prikazan na formi unutar label komponente.

Primjer sa sata:
Prethodno je potrebno dodati reference unutar projekta na System.Windows.Forms i na System.Drawing

using System;
using System.Windows.Forms;
using System.Drawing;

namespace ConsoleApp1
{

    public class MainForm : Form
    {
	// Deklaracija botuna i textboxa
         Button helloButton = new Button();
         TextBox inputBox = new TextBox();

        // Konstruktor MainForm klase
        public MainForm()
        {
            this.Text = "Moja Prva Forma"; // Postavljanje naslova forme
            this.Size = new System.Drawing.Size(640, 480); // Postavljanje veličine forme
     		// Kreiranje i postavljanje svojstava dugmeta
            helloButton.Text = "Klikni Me";
            helloButton.Location = new System.Drawing.Point(100, 100);

            // Kreiranje i postavljanje svojstava tekstualnog polja
            inputBox.Location = new System.Drawing.Point(20, 20);
            inputBox.Size = new System.Drawing.Size(300, 20);

            // Dodavanje kontrola na formu
            this.Controls.Add(helloButton);
            this.Controls.Add(inputBox);
            // Povezivanje događaja klik na dugme s funkcijom HelloButton_Click
            helloButton.Click += HelloButton_Click;
            // Dogovaranje Događaja:
            //Ova linija koda povezuje događaj Click s metodom HelloButton_Click.
            //helloButton je instanca klase Button, a Click je događaj koji se aktivira kada korisnik klikne na dugme.
            //Operator += se koristi za dodavanje metode HelloButton_Click na listu metoda koje će biti pozvane kada se dogodi događaj Click.Ovo se naziva "dodavanje događaja" ili "registracija događaja".
            //Dakle, kada korisnik klikne na helloButton, metoda HelloButton_Click će biti automatski pozvana.
        }




        //[STAThread] je atribut koji se primjenjuje na glavnu (Main) metodu aplikacije.
        //"STA" označava "Single-Threaded Apartment", što je model threadinga koji se koristi u Windows aplikacijama, posebno onima koje koriste COM(Component Object Model) komponente.
        //        Ovaj atribut osigurava da se glavna nit aplikacije pokreće kao STA, što je zahtjev za mnoge Windows funkcije, uključujući drag-and-drop funkcionalnosti i standardne dijaloge.
        //U Windows Forms aplikacijama, ovaj atribut je ključan jer mnoge kontrole i komponente GUI-a zahtijevaju da se pokreću u STA modu.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); // Omogućava vizualne stilove za formu
            /*Ova metoda omogućuje vizualne stilove za vašu aplikaciju. Vizualni stilovi su ono što aplikaciji daje moderniji izgled, u skladu s trenutnim temama Windowsa.
Kada se pozove, ova metoda omogućuje aplikaciji da koristi vizualne stilove za crtanje kontrole i drugih GUI elemenata. To uključuje stilove kao što su boje, fontovi i drugi elementi dizajna koji su konzistentni s trenutnim korisničkim sučeljem Windowsa.
Ako se ova metoda ne pozove, aplikacija će koristiti klasični Windows stil, koji je vizualno manje privlačan i može izgledati zastarjelo.
            */
            Application.Run(new MainForm()); // Pokreće formu
        }

        //        HelloButton_Click je metoda koja se poziva kada se dogodi događaj Click na helloButton.
        //object sender je parametar koji predstavlja objekt koji je poslao događaj, u ovom slučaju to je helloButton.
        //EventArgs e je parametar koji sadrži dodatne informacije o događaju.Za standardni Click događaj, EventArgs ne nosi puno specifičnih informacija, ali je bitan za konzistentnost potpisa događajnih metoda.
        //U tijelu ove metode, možete definirati šta se događa kada se dugme klikne.Na primjer, može se prikazati poruka, otvoriti nova forma ili izvršiti neka druga akcija.
        private void HelloButton_Click(object sender, EventArgs e)
        {
            // Prikazuje MessageBox kada se klikne na dugme
//MessageBox je public static klasa unutar C# frameworka i možemo ga pozvati iz bilo kojeg dijela aplikacije
            MessageBox.Show("Pozdrav iz C# Windows Forms!", "Poruka");
        }}}

