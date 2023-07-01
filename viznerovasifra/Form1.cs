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
using static System.Net.Mime.MediaTypeNames;

namespace viznerovasifra
{
    public partial class Form1 : Form
    {
        private string[] engAlphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        private string[] srpskaLatinicaAlphabet = { "a", "b", "c", "č", "ć", "d", "dž", "đ", "e", "f", "g", "h", "i", "j", "k", "l", "lj", "m", "n", "nj", "o", "p", "r", "s", "š", "t", "u", "v", "z", "ž" };
        private string[] srpskaCirilicaAlphabet = { "а", "б", "в", "г", "д", "ђ", "е", "ж", "з", "и", "ј", "к", "л", "љ", "м", "н", "њ", "о", "п", "р", "с", "т", "ћ", "у", "ф", "х", "ц", "ч", "џ", "ш" };
        bool language = true; //true cirilica, false latinica
        bool radi = false;

        public Form1()
        {
            InitializeComponent();
        }
        private string VigenereEncrypt(string text, string key, string[] alphabet)
        {
            radi = true;
            foreach (char c in text)
            {
                if (!Char.IsWhiteSpace(c))
                {
                    string s = c.ToString().ToLower();
                    if (!alphabet.Contains(s))
                    {
                        radi = false;
                        PlainText.Text = "";
                        PlainText2.Text = "";
                        if(language){ MessageBox.Show("Користите погрешан алфабет за Отворени текст!"); return ""; }
                        else{ MessageBox.Show("Koristite pogrešan alfabet za Otvoreni tekst!"); return ""; }
                    }
                }
                
            }
            foreach (char c in key)
            {
                if (!Char.IsWhiteSpace(c))
                {
                    string s = c.ToString().ToLower();
                    if (!alphabet.Contains(s))
                    {
                        radi = false;
                        KeyText.Text = "";
                        PlainText2.Text = "";
                        if (language){ MessageBox.Show("Користите погрешан алфабет за КЉУЧ!"); return ""; }
                        else{ MessageBox.Show("Koristite pogrešan alfabet za KLJUČ!"); return ""; }
                    }
                }    
            }
            string encryptedText = "";
            if (radi)
            {
                int alphabetLength = alphabet.Length;
                int keyIndex = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    char plainChar = text[i];
                    if (!Char.IsLetter(plainChar))
                    {
                        encryptedText += plainChar;
                        continue;
                    }

                    char keyChar = key[keyIndex];

                    int plainCharIndex = Array.IndexOf(alphabet, plainChar.ToString());
                    int keyCharIndex = Array.IndexOf(alphabet, keyChar.ToString());
                    int encryptedCharIndex = (plainCharIndex + keyCharIndex) % alphabetLength;
                    encryptedText += alphabet[encryptedCharIndex];
                    keyIndex = (keyIndex + 1) % key.Length;
                }
            }
            return encryptedText;
        }
        private string VigenereDecrypt(string encryptedText, string key, string[] alphabet)
        {
            string plainText = "";
            if (radi)
            {
                int alphabetLength = alphabet.Length;

                int keyIndex = 0;
                for (int i = 0; i < encryptedText.Length; i++)
                {
                    char encryptedChar = encryptedText[i];
                    if (!Char.IsLetter(encryptedChar))
                    {
                        plainText += encryptedChar;
                        continue;
                    }

                    char keyChar = key[keyIndex];
                    int encryptedCharIndex = Array.IndexOf(alphabet, encryptedChar.ToString());
                    int keyCharIndex = Array.IndexOf(alphabet, keyChar.ToString());
                    int plainCharIndex = (encryptedCharIndex - keyCharIndex + alphabetLength) % alphabetLength;
                    plainText += alphabet[plainCharIndex];
                    keyIndex = (keyIndex + 1) % key.Length;
                }
            }
            return plainText.ToString();
        }
        private string[] GetSelectedAlphabet()
        {
            if (EnglishAlphabet.Checked) return engAlphabet;
            else if (SerbianLatin.Checked) return srpskaLatinicaAlphabet;
            else return srpskaCirilicaAlphabet;
        }
        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            if (PlainText.Text != "" && KeyText.Text != "")
            {
                string text = PlainText.Text.ToLower();
                string key = KeyText.Text.ToLower();
                string[] alphabet = GetSelectedAlphabet();
                string encryptedText = VigenereEncrypt(text, key, alphabet);
                CipherText.Text = encryptedText;
            }
        }
        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            if (CipherText.Text != "" && KeyText.Text != "")
            {
                string text = CipherText.Text.ToLower();
                string key = KeyText.Text.ToLower();
                string[] alphabet = GetSelectedAlphabet();
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
                dialogResult = MessageBox.Show("Верзија 0.0.2\n***Апликацију су направили:\nМихајло Ранђеловић и Александар Недељковић\n***Контакт: onlymihajlo@gmail.com\nТехничка школа Смедерево 4-1\n***Најновију верзију и изворни код можете скинути на:\nhttps://github.com/mikikupus/viznerovasifra", "Контакт", MessageBoxButtons.OK);
            }
            else
            {
                dialogResult = MessageBox.Show("Verzija 0.0.2\n***Aplikaciju su napravili:\nMihajlo Ranđelović i Aleksandar Nedeljković\n***Kontakt: onlymihajlo@gmail.com\nTehnička škola Smederevo 4-1\n***Najnoviju verziju i izvorni kod možete skinuti na:\nhttps://github.com/mikikupus/viznerovasifra", "Kontakt", MessageBoxButtons.OKCancel);
            }
        }

        private void github_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mikikupus/viznerovasifra");
        }
    }
}
