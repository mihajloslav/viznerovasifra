using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viznerovasifra
{
    public partial class Form1 : Form
    {
        private const string DefaultAlphabet = "abcdefghijklmnopqrstuvwxyz"; // defaultni alfabet 
        //private const string Utf8Alphabet2 = "abcdefghijklmnopqrstuvwxyzćčšđž"; // alfabet sa UTF-8 slovima
        private const string Utf8Alphabet = "abcčćdđefghijklmnopqrsštuvzž"; // alfabet sa UTF-8 slovima
        private const string CyrillicAlphabet = "абвгдђежзијклљмнњопрстћуфхцчшџ"; // ćirilični alfabet 
        bool language = true; //true cirilica, false latinica
        public Form1()
        {
            InitializeComponent();
        }
        private string VigenereEncrypt(string text, string key, string alphabet)
        {
            StringBuilder encryptedText = new StringBuilder();
            int alphabetLength = alphabet.Length;
            int keyIndex = 0;
            foreach (char c in text)
            {
                int alphabetIndex = alphabet.IndexOf(Char.ToLower(c));
                if (alphabetIndex != -1)
                {
                    char keyChar = Char.ToLower(key[keyIndex % key.Length]);
                    int keyIndexInAlphabet = alphabet.IndexOf(keyChar);
                    int encryptedIndex = (alphabetIndex + keyIndexInAlphabet) % alphabetLength;
                    char encryptedChar = alphabet[encryptedIndex];
                    encryptedText.Append(Char.IsUpper(c) ? Char.ToUpper(encryptedChar) : encryptedChar);
                    keyIndex++;
                }
                else encryptedText.Append(c);
            }

            return encryptedText.ToString();
        }
        private string VigenereDecrypt(string encryptedText, string key, string alphabet)
        {
            StringBuilder decryptedText = new StringBuilder();
            int alphabetLength = alphabet.Length;
            int keyIndex = 0;
            foreach (char c in encryptedText)
            {
                int alphabetIndex = alphabet.IndexOf(Char.ToLower(c));
                if (alphabetIndex != -1)
                {
                    char keyChar = Char.ToLower(key[keyIndex % key.Length]);
                    int keyIndexInAlphabet = alphabet.IndexOf(keyChar);
                    int decryptedIndex = (alphabetIndex - keyIndexInAlphabet + alphabetLength) % alphabetLength;
                    char decryptedChar = alphabet[decryptedIndex];
                    decryptedText.Append(Char.IsUpper(c) ? Char.ToUpper(decryptedChar) : decryptedChar);
                    keyIndex++;
                }
                else decryptedText.Append(c);
            }

            return decryptedText.ToString();
        }
        private string GetSelectedAlphabet()
        {
            if (EnglishAlphabet.Checked) return DefaultAlphabet;
            else if (SerbianLatin.Checked) return Utf8Alphabet;
            else return CyrillicAlphabet;
        }
        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            if (PlainText.Text != "" && KeyText.Text != "")
            {
                string text = PlainText.Text;
                string key = KeyText.Text;
                string alphabet = GetSelectedAlphabet();
                string encryptedText = VigenereEncrypt(text, key, alphabet);
                CipherText.Text = encryptedText;
            }
        }
        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            if (CipherText.Text != "" && KeyText.Text != "")
            {
                string text = CipherText.Text;
                string key = KeyText.Text;
                string alphabet = GetSelectedAlphabet();
                string decryptedText = VigenereDecrypt(text, key, alphabet);
                PlainText2.Text = decryptedText;
            }
        }

        private void CipherText_TextChanged(object sender, EventArgs e)
        {
            if (autocrypt.Checked)
                BtnDecrypt_Click(sender, e);
        }

        private void PlainText_TextChanged(object sender, EventArgs e)
        {
            if (autocrypt.Checked)
                BtnEncrypt_Click(sender, e);
        }
        private void Alphabet_CheckedChanged(object sender, EventArgs e)
        {
            PlainText.Text = "";
            CipherText.Text = "";
            PlainText2.Text = "";
            KeyText.Text = "";
            /*if (autocrypt.Checked)
            {
                BtnEncrypt_Click(sender, e);
                BtnDecrypt_Click(sender, e);
            }*/
        }

        private void KeyText_TextChanged(object sender, EventArgs e)
        {
            if (autocrypt.Checked)
            {
                BtnEncrypt_Click(sender, e);
                BtnDecrypt_Click(sender, e);
            }
        }

        private void Latin_Click(object sender, EventArgs e)
        {
            Latin.Enabled = false;
            language = false;
            Cyrillic.Enabled = !Latin.Enabled;
            Text = "Vižnerova šifra";
            PlainTextLabel.Text = "Unesite tekst:";
            KeyTextLabel.Text = "Unesite ključ:";
            BtnEncrypt.Text = "Šifruj";
            BtnDecrypt.Text = "Dešifruj";
            EnglishAlphabet.Text = "Engleski Alfabet";
            SerbianLatin.Text = "Srpska Latinica";
            SerbianCyrillic.Text = "Srpska Ćirilica";
            autocrypt.Text = "Automatski šifruj i dešifruj";
            About.Text = "O Aplikaciji";
            Contact.Text = "Kontakt";
        }

        private void Cyrillic_Click(object sender, EventArgs e)
        {
            Cyrillic.Enabled = false;
            language = true;
            Latin.Enabled = !Cyrillic.Enabled;
            Text = "Вижнерова Шифра";
            PlainTextLabel.Text = "Унесите текст:";
            KeyTextLabel.Text = "Унесите кључ:";
            BtnEncrypt.Text = "Шифруј";
            BtnDecrypt.Text = "Дешифруј";
            EnglishAlphabet.Text = "Енглески алфабет";
            SerbianLatin.Text = "Српска Латиница";
            SerbianCyrillic.Text = "Српска Ћирилица";
            autocrypt.Text = "Аутоматски шифруј и дешифруј";
            About.Text = "О Апликацији";
            Contact.Text = "Контакт";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cyrillic_Click(sender, e);
        }

        private void autocrypt_CheckedChanged(object sender, EventArgs e)
        {
            BtnEncrypt_Click(sender, e);
            BtnDecrypt_Click(sender, e);
        }

        private void About_Click(object sender, EventArgs e)
        {
            if(language) MessageBox.Show("Ово је апликација која демонстрира рад Вижнерове шифре.\n");
            else MessageBox.Show("Ovo je aplikacija koja demonstrira rad Vižnerove šifre.\n");

        }

        private void Contact_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            if (language)
            {
                dialogResult = MessageBox.Show("Верзија 0.0.1\n***Апликацију су направили:\nМихајло Ранђеловић и Александар Недељковић\n***Контакт: onlymihajlo@gmail.com\nТехничка школа Смедерево 4-1\n***Најновију верзију и изворни код можете скинути на:\nhttps://github.com/mikikupus/viznerovasifra", "Контакт", MessageBoxButtons.OK);
            }
            else
            {
                dialogResult = MessageBox.Show("Verzija 0.0.1\n***Aplikaciju su napravili:\nMihajlo Ranđelović i Aleksandar Nedeljković\n***Kontakt: onlymihajlo@gmail.com\nTehnička škola Smederevo 4-1\n***Najnoviju verziju i izvorni kod možete skinuti na:\nhttps://github.com/mikikupus/viznerovasifra", "Kontakt", MessageBoxButtons.OKCancel);
            }
        }

        private void github_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mikikupus/viznerovasifra");
        }
    }
}
