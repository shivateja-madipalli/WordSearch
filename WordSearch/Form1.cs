using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;

namespace WordSearch
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            FindandSortDictionary();
        }

        ArrayList AArray, BArray, CArray, DArray, EArray, FArray, GArray, HArray, IArray, JArray, KArray, LArray, MArray, NArray, OArray, PArray, QArray, RArray, SArray, TArray, UArray, VArray, WArray, XArray, YArray, ZArray;
        ArrayList finalWordArray = new ArrayList();
        //ArrayList DynamicTextBoxesNames = new ArrayList();
        String checksum = "";
        int checkval = 0;
        int CountforDynamicTextBoxes = 0;
        int LocationForDynamicTextBoxesX = 15;
        int LocationForDynamicTextBoxesY = 70;
        //Char[] Characters;

        List<TextBox> DynamicTextBoxes = new List<TextBox>();
        private void addCommonWords()
        {
            var CommonWords = new List<String> { "the", "are", "can", "let", "she", "his" };
        }

        private void FindandSortDictionary()
        {
            String str = File.ReadAllText(@"E:\Visual Studio Projects\WordSearch\convertcsv1.json");
            var udemy = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(str);
            for (int i = 0; i < udemy.Count; i++)
            {
                var temp = udemy[i];
                if (temp["FIELD1"] == (i + 1).ToString())
                {
                    SortingWords(temp["FIELD2"]);
                }
            }
        }

        private void SortingWords(string inputWord)
        {
            checksum = checksum + "#" + inputWord;
            checkval++;
            var DividedWord = inputWord.ToArray();
            ArrayList array = findWhichArrayList(DividedWord[0]);
            if (inputWord == "only")
            {
                int i = 0;
            }
            array.Add(inputWord);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt1.Text != "" && txt2.Text != "" && txt3.Text != "" && txt4.Text != "")
                {
                    Char[] Characters;
                    Characters = new Char[4 + DynamicTextBoxes.Count];
                    Characters[0] = txt1.ToString()[36];
                    Characters[1] = txt2.ToString()[36];
                    Characters[2] = txt3.ToString()[36];
                    Characters[3] = txt4.ToString()[36];
                    if (DynamicTextBoxes.Count != 0)
                    {
                        for (int i = 0; i < DynamicTextBoxes.Count; i++)
                        {
                            TextBox txt = DynamicTextBoxes[i];
                            //str = str + txt.Text;
                            Characters[i + 4] = txt.ToString()[36];
                        }
                    }
                    FindWords(Characters);
                }
            }
            catch (Exception ex)
            {

            }
        }

       private void FindWords(Char[] Characters)
        {
            for (int i = 0; i < Characters.Count(); i++)
            {
                ArrayList array = findWhichArrayList(Characters[i]);
                if (array != null)
                {
                    for (int j = 0; j < array.Count; j++)
                    {
                        if (array[j].ToString().ToCharArray().Count() >= Characters.Count())
                        {
                            if (CheckForWord(array[j].ToString(), Characters))
                            {
                                if (!finalWordArray.Contains(array[j].ToString()))
                                    finalWordArray.Add(array[j].ToString());
                            }
                        }
                    }
                }
            }
        }

        private bool CheckForWord(String word, Char[] Characters)
        {
            try
            {
                StringBuilder myword = new StringBuilder(word);
                for (int k = 0; k < Characters.Count(); k++)
                {
                    if (!word.Contains(Characters[k]))
                    {
                        return false;
                    }
                    else
                    {

                        myword[word.IndexOf(Characters[k])] = '1';
                        word = myword.ToString();
                        //word.Replace( word.IndexOf(Characters[k]);
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        private ArrayList findWhichArrayList(Char cha)
        {
            //if (!Char.IsNumber(cha))
            //{
            if (cha == 'A' || cha == 'a')
            {
                if (AArray == null)
                {
                    AArray = new ArrayList();
                }
                return AArray;
            }
            else if (cha == 'B' || cha == 'b')
            {
                if (BArray == null)
                {
                    BArray = new ArrayList();
                }
                return BArray;
            }
            else if (cha == 'C' || cha == 'c')
            {
                if (CArray == null)
                {
                    CArray = new ArrayList();
                }
                return CArray;
            }
            else if (cha == 'D' || cha == 'd')
            {
                if (DArray == null)
                {
                    DArray = new ArrayList();
                }
                return DArray;
            }
            else if (cha == 'E' || cha == 'e')
            {
                if (EArray == null)
                {
                    EArray = new ArrayList();
                }
                return EArray;
            }
            else if (cha == 'F' || cha == 'f')
            {
                if (FArray == null)
                {
                    FArray = new ArrayList();
                }
                return FArray;
            }
            else if (cha == 'G' || cha == 'g')
            {
                if (GArray == null)
                {
                    GArray = new ArrayList();
                }
                return GArray;
            }
            else if (cha == 'H' || cha == 'h')
            {
                if (HArray == null)
                {
                    HArray = new ArrayList();
                }
                return HArray;
            }
            else if (cha == 'I' || cha == 'i')
            {
                if (IArray == null)
                {
                    IArray = new ArrayList();
                }
                return IArray;
            }
            else if (cha == 'J' || cha == 'j')
            {
                if (JArray == null)
                {
                    JArray = new ArrayList();
                }
                return JArray;
            }
            else if (cha == 'K' || cha == 'k')
            {
                if (KArray == null)
                {
                    KArray = new ArrayList();
                }
                return KArray;
            }
            else if (cha == 'L' || cha == 'l')
            {
                if (LArray == null)
                {
                    LArray = new ArrayList();
                }
                return LArray;
            }
            else if (cha == 'M' || cha == 'm')
            {
                if (MArray == null)
                {
                    MArray = new ArrayList();
                }
                return MArray;
            }
            else if (cha == 'N' || cha == 'n')
            {
                if (NArray == null)
                {
                    NArray = new ArrayList();
                }
                return NArray;
            }
            else if (cha == 'O' || cha == 'o')
            {
                if (OArray == null)
                {
                    OArray = new ArrayList();
                }
                return OArray;
            }
            else if (cha == 'P' || cha == 'p')
            {
                if (PArray == null)
                {
                    PArray = new ArrayList();
                }
                return PArray;
            }
            else if (cha == 'Q' || cha == 'q')
            {
                if (QArray == null)
                {
                    QArray = new ArrayList();
                }
                return QArray;
            }
            else if (cha == 'R' || cha == 'r')
            {
                if (RArray == null)
                {
                    RArray = new ArrayList();
                }
                return RArray;
            }
            else if (cha == 'S' || cha == 's')
            {
                if (SArray == null)
                {
                    SArray = new ArrayList();
                }
                return SArray;
            }
            else if (cha == 'T' || cha == 't')
            {
                if (TArray == null)
                {
                    TArray = new ArrayList();
                }
                return TArray;
            }
            else if (cha == 'U' || cha == 'u')
            {
                if (UArray == null)
                {
                    UArray = new ArrayList();
                }
                return UArray;
            }
            else if (cha == 'V' || cha == 'v')
            {
                if (VArray == null)
                {
                    VArray = new ArrayList();
                }
                return VArray;
            }
            else if (cha == 'W' || cha == 'w')
            {
                if (WArray == null)
                {
                    WArray = new ArrayList();
                }
                return WArray;
            }
            else if (cha == 'X' || cha == 'x')
            {
                if (XArray == null)
                {
                    XArray = new ArrayList();
                }
                return XArray;
            }
            else if (cha == 'Y' || cha == 'y')
            {
                if (YArray == null)
                {
                    YArray = new ArrayList();
                }
                return YArray;
            }
            else if (cha == 'Z' || cha == 'z')
            {
                if (ZArray == null)
                {
                    ZArray = new ArrayList();
                }
                return ZArray;
            }
            //}
            return null;
        }

        private void btnAddtextbox_Click(object sender, EventArgs e)
        {
            try
            {
                CountforDynamicTextBoxes++;
                TextBox txt = new TextBox();
                txt.Name = "TxtDynamic" + CountforDynamicTextBoxes.ToString();
                txt.Visible = true;
                txt.Size = new System.Drawing.Size(25, 26);
                //txt.Margin = new Thickness(10, 15, 950, 0);
                txt.Location = new Point(LocationForDynamicTextBoxesX, LocationForDynamicTextBoxesY);
                LocationForDynamicTextBoxesX = LocationForDynamicTextBoxesX + 52;
                txt.TextChanged += txt_TextChanged;
                this.Controls.Add(txt);
                DynamicTextBoxes.Add(txt);
            }
            catch (Exception ex)
            {

            }
        }

        //private bool CheckWhetherAreTheyLetters(Char[] Characters)
        //{
        //    string s = new string(Characters);
        //    return (Regex.IsMatch(s, @"^[a-zA-Z]+$"));
        //}

        void txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            CheckForEveryEntry(txt);
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            CheckForEveryEntry(txt);
        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            CheckForEveryEntry(txt);
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            CheckForEveryEntry(txt);
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            CheckForEveryEntry(txt);
        }

        private void CheckForEveryEntry(TextBox txt)
        {
            //TextBox txt = (TextBox)sender;
            if (Regex.IsMatch(txt.Text, @"^[a-zA-Z]+$"))
            {
                if (txt.Text.Count() > 1)
                {
                    txt.Text = txt.Text[0].ToString();
                }
            }
            else
            {
                txt.Text = "";
            }
        }
    }
}