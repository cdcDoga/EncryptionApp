using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace sifreleme_yontemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {   
            if(cbAlgorithm.SelectedIndex == 0)
            {
                if (cbCaesarKey.Text != "")
                {
                    int key = Convert.ToInt32(cbCaesarKey.SelectedItem.ToString());
                    byte[] asciiBytes = Encoding.ASCII.GetBytes(rtbPlain.Text);
                    int[] ascii = new int[rtbPlain.Text.Length];

                    for (int i = 0; i < asciiBytes.Length; i++)
                    {
                        if (Convert.ToInt32(asciiBytes[i]) <= 64 || (91 <= Convert.ToInt32(asciiBytes[i]) && Convert.ToInt32(asciiBytes[i]) <= 96) || Convert.ToInt32(asciiBytes[i]) >= 123)
                        {
                            ascii[i] = Convert.ToInt32(asciiBytes[i]);
                        }
                        else if (Convert.ToInt32(asciiBytes[i]) + key > 122)
                        {
                            int count = key - (122 - Convert.ToInt32(asciiBytes[i]));
                            ascii[i] = 96 + count;
                        }
                        else if (Convert.ToInt32(asciiBytes[i]) <= 90 && Convert.ToInt32(asciiBytes[i]) + key > 90)
                        {
                            int count = key - (90 - Convert.ToInt32(asciiBytes[i]));
                            ascii[i] = 64 + count;
                        }
                        else
                        {
                            ascii[i] = Convert.ToInt32(asciiBytes[i]) + key;
                        }
                    }

                    string message = "";
                    foreach (int i in ascii)
                    {
                        char character = (char)i;
                        message += character;
                    }

                    rtbCipher.Text = message;
                }
                else
                {
                    MessageBox.Show("please select a Caesar Key", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }   
            }
            else if(cbAlgorithm.SelectedIndex == 1)
            {
                if (tbSubstitutionKey.Text.Length == 26)
                {
                    string temp = rtbPlain.Text;
                    string[] messageArray = new string[temp.Length];
                    for(int i = 0; i < rtbPlain.Text.Length; i++)
                    {
                        messageArray[i] = temp.Substring(0,1);
                        temp = temp.Substring(1);
                    }

                    string temp2 = tbSubstitutionKey.Text;
                    string[] keyAL = new string[temp2.Length];
                    for(int i = 0; i < tbSubstitutionKey.Text.Length; i++)
                    {
                        keyAL[i] = temp2.Substring(0, 1);
                        temp2 = temp2.Substring(1);
                    }
                    
                    for(int i = 0; i < rtbPlain.Text.Length; i++)
                    {
                        switch (messageArray[i])
                        {
                            case "A":
                            case "a":
                                messageArray[i] = keyAL[0];
                                break;
                            case "B":
                            case "b":
                                messageArray[i] = keyAL[1];
                                break;
                            case "C":
                            case "c":
                                messageArray[i] = keyAL[2];
                                break;
                            case "D":
                            case "d":
                                messageArray[i] = keyAL[3];
                                break;
                            case "E":
                            case "e":
                                messageArray[i] = keyAL[4];
                                break;
                            case "F":
                            case "f":
                                messageArray[i] = keyAL[5];
                                break;
                            case "G":
                            case "g":
                                messageArray[i] = keyAL[6];
                                break;
                            case "H":
                            case "h":
                                messageArray[i] = keyAL[7];
                                break;
                            case "I":
                            case "i":
                                messageArray[i] = keyAL[8];
                                break;
                            case "J":
                            case "j":
                                messageArray[i] = keyAL[9];
                                break;
                            case "K":
                            case "k":
                                messageArray[i] = keyAL[10];
                                break;
                            case "L":
                            case "l":
                                messageArray[i] = keyAL[11];
                                break;
                            case "M":
                            case "m":
                                messageArray[i] = keyAL[12];
                                break;
                            case "N":
                            case "n":
                                messageArray[i] = keyAL[13];
                                break;
                            case "O":
                            case "o":
                                messageArray[i] = keyAL[14];
                                break;
                            case "P":
                            case "p":
                                messageArray[i] = keyAL[15];
                                break;
                            case "Q":
                            case "q":
                                messageArray[i] = keyAL[16];
                                break;
                            case "R":
                            case "r":
                                messageArray[i] = keyAL[17];
                                break;
                            case "S":
                            case "s":
                                messageArray[i] = keyAL[18];
                                break;
                            case "T":
                            case "t":
                                messageArray[i] = keyAL[19];
                                break;
                            case "U":
                            case "u":
                                messageArray[i] = keyAL[20];
                                break;
                            case "V":
                            case "v":
                                messageArray[i] = keyAL[21];
                                break;
                            case "W":
                            case "w":
                                messageArray[i] = keyAL[22];
                                break;
                            case "X":
                            case "x":
                                messageArray[i] = keyAL[23];
                                break;
                            case "Y":
                            case "y":
                                messageArray[i] = keyAL[24];
                                break;
                            case "Z":
                            case "z":
                                messageArray[i] = keyAL[25];
                                break;
                            default:
                                break;
                        }
                    }
                    rtbCipher.Text = string.Join("", messageArray);
                }
                else
                {
                    MessageBox.Show("please write 26 character in Substitution Key", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if(cbAlgorithm.SelectedIndex == 2)
            {
                if(tbAffineA.Text != "" && tbAffineB.Text != "" && num_Control(tbAffineA.Text) == true && num_Control(tbAffineB.Text) == true)
                {
                    int a = Convert.ToInt32(tbAffineA.Text);
                    int b = Convert.ToInt32(tbAffineB.Text);
                    byte[] asciiBytes = Encoding.ASCII.GetBytes(rtbPlain.Text);
                    int[] ascii = new int[rtbPlain.Text.Length];

                    for (int i = 0; i < asciiBytes.Length; i++)
                    {
                        if (97 <= Convert.ToInt32(asciiBytes[i]) && Convert.ToInt32(asciiBytes[i]) <= 122)
                        {
                            int x = Convert.ToInt32(asciiBytes[i]) - 96;
                            int repetition = (a * x + b) / 26;
                            ascii[i] = 96 + (a * x + b) - (repetition * 26);
                        }
                        else if (65 <= Convert.ToInt32(asciiBytes[i]) && Convert.ToInt32(asciiBytes[i]) <= 90)
                        {
                            int x = Convert.ToInt32(asciiBytes[i]) - 64;
                            int repetition = (a * x + b) / 26;
                            ascii[i] = 64 + (a * x + b) - (repetition * 26);
                        }
                        else
                        {
                            ascii[i] = Convert.ToInt32(asciiBytes[i]);
                        }
                    }

                    string message = "";
                    foreach (int i in ascii)
                    {
                        char character = (char)i;
                        message += character;
                    }

                    rtbCipher.Text = message;
                }
                else
                {
                    MessageBox.Show("please write numbers in Affine Key", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (cbAlgorithm.SelectedIndex == 3)
            {
                if (tbVigenereKey.Text != "" && word_Control(tbVigenereKey.Text) == true)
                {
                    string newText = rtbPlain.Text.Replace(" ", "");
                    byte[] keyBytes = Encoding.ASCII.GetBytes(tbVigenereKey.Text);

                    byte[] asciiBytes = Encoding.ASCII.GetBytes(newText);
                    int[] ascii = new int[newText.Length];

                    ArrayList keyAL = new ArrayList();
                    int repetition = newText.Length / tbVigenereKey.Text.Length;
                    int difference = newText.Length - repetition * tbVigenereKey.Text.Length;
                    for(int i = 0; i < repetition; i++)
                    {
                        keyAL = new ArrayList(keyBytes);
                    }
                    for(int i = 0; i < difference; i++)
                    {
                        keyAL.Add(keyBytes[i]);
                    }
                    
                    int[] key = new int[newText.Length];
                    int index = 0;
                    int count = 0;
                    foreach(object item in newText)
                    {
                        string tempKey = keyAL[index].ToString();
                        int permanentKey = Convert.ToInt32(tempKey);
                        key[count] = permanentKey;
                        index++;
                        count++;
                        if(index >= keyAL.Count)
                        {
                            index = index - keyAL.Count;
                        }
                    }

                    for (int i = 0; i < asciiBytes.Length; i++)
                    {
                        if (97 <= Convert.ToInt32(asciiBytes[i]) && Convert.ToInt32(asciiBytes[i]) <= 122)
                        {
                            int x = Convert.ToInt32(asciiBytes[i]) - 96;
                            int y = Convert.ToInt32(key[i]) - 96;
                            ascii[i] = x + y;
                            if(ascii[i] > 26)
                            {
                                ascii[i] = ascii[i] - 26;
                            }
                            ascii[i] = ascii[i] + 96;
                        }
                        else if (65 <= Convert.ToInt32(asciiBytes[i]) && Convert.ToInt32(asciiBytes[i]) <= 90)
                        {
                            int x = Convert.ToInt32(asciiBytes[i]) - 64;
                            int y = Convert.ToInt32(key[i]) - 96;
                            ascii[i] = x + y;
                            if (ascii[i] > 26)
                            {
                                ascii[i] = ascii[i] - 26;
                            }
                            ascii[i] = ascii[i] + 64;
                        }
                        else
                        {
                            ascii[i] = Convert.ToInt32(asciiBytes[i]);
                        }
                    }

                    string message = "";
                    foreach (int i in ascii)
                    {
                        char character = (char)i;
                        message += character;
                    }

                    rtbCipher.Text = message;
                }
                else
                {
                    MessageBox.Show("please write just a word in Virgenere Key", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("please select an Encryption Algorithm", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool num_Control(string x)
        {
            bool b = x.All(char.IsDigit);
            return b;
        }

        private bool word_Control(string x)
        {
            bool b = true;

            byte[] asciiBytes = Encoding.ASCII.GetBytes(x);
            for(int i = 0; i < x.Length; i++)
            {
                if(asciiBytes[i] < 65 || (90 < asciiBytes[i] && asciiBytes[i] < 97) || asciiBytes[i] > 122)
                {
                    b = false;
                    break;
                }
            }

            return b;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCaesarKey.Enabled = false;
            cbCaesarKey.Enabled = false;
            lblSubstitutionKey.Enabled = false;
            tbSubstitutionKey.Enabled = false;
            lblAffineKey.Enabled = false;
            lblA.Enabled = false;
            tbAffineA.Enabled = false;
            lblX.Enabled = false;
            lblPlus.Enabled = false;
            lblB.Enabled = false;
            tbAffineB.Enabled = false;
            lblVigenereKey.Enabled = false;
            tbVigenereKey.Enabled = false;
        }

        private void cbAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbAlgorithm.SelectedIndex == 0)
            {
                lblCaesarKey.Enabled = true;
                cbCaesarKey.Enabled = true;

                lblSubstitutionKey.Enabled = false;
                tbSubstitutionKey.Enabled = false;
                lblAffineKey.Enabled = false;
                lblA.Enabled = false;
                tbAffineA.Enabled = false;
                lblX.Enabled = false;
                lblPlus.Enabled = false;
                lblB.Enabled = false;
                tbAffineB.Enabled = false;
                lblVigenereKey.Enabled = false;
                tbVigenereKey.Enabled = false;
            }
            if (cbAlgorithm.SelectedIndex == 1)
            {
                lblSubstitutionKey.Enabled = true;
                tbSubstitutionKey.Enabled = true;

                lblCaesarKey.Enabled = false;
                cbCaesarKey.Enabled = false;
                lblAffineKey.Enabled = false;
                lblA.Enabled = false;
                tbAffineA.Enabled = false;
                lblX.Enabled = false;
                lblPlus.Enabled = false;
                lblB.Enabled = false;
                tbAffineB.Enabled = false;
                lblVigenereKey.Enabled = false;
                tbVigenereKey.Enabled = false;
            }
            if (cbAlgorithm.SelectedIndex == 2)
            {
                lblAffineKey.Enabled = true;
                lblA.Enabled = true;
                tbAffineA.Enabled = true;
                lblX.Enabled = true;
                lblPlus.Enabled = true;
                lblB.Enabled = true;
                tbAffineB.Enabled = true;

                lblCaesarKey.Enabled = false;
                cbCaesarKey.Enabled = false;
                lblSubstitutionKey.Enabled = false;
                tbSubstitutionKey.Enabled = false;
                lblVigenereKey.Enabled = false;
                tbVigenereKey.Enabled = false;
            }
            if (cbAlgorithm.SelectedIndex == 3)
            {
                lblVigenereKey.Enabled = true;
                tbVigenereKey.Enabled = true;

                lblCaesarKey.Enabled = false;
                cbCaesarKey.Enabled = false;
                lblSubstitutionKey.Enabled = false;
                tbSubstitutionKey.Enabled = false;
                lblAffineKey.Enabled = false;
                lblA.Enabled = false;
                tbAffineA.Enabled = false;
                lblX.Enabled = false;
                lblPlus.Enabled = false;
                lblB.Enabled = false;
                tbAffineB.Enabled = false;
            }
        }
    }
}
