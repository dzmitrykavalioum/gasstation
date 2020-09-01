using BestOil.Entities;
using BestOil.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;


namespace BestOil
{
    public partial class MainForm : Form
    {
        private CafeItem cafeItemHotDog;
        private CafeItem cafeItemHamburger;
        private CafeItem cafeItemCheeseburger;
        private CafeItem cafeItemCocaCola;
        private SubjectRepository _subjectsRepository;
        private double summ_cafe;
        private double temp_HotDog;
        private double temp_Hum;
        private double temp_Cheese;
        private double temp_Cola;
        private double summ_total;
        public MainForm()
        {
            InitializeComponent();
            _subjectsRepository = new SubjectRepository();
            InitializeVars();
            cafeItemHotDog = new CafeItem("Хот дог", 5);
            cafeItemHamburger = new CafeItem("Гамбургер", 6);
            cafeItemCheeseburger = new CafeItem("Чизбургер", 5.5);
            cafeItemCocaCola = new CafeItem("Кока кола", 3);
            List<CafeItem> listItems = new List<CafeItem> { cafeItemHotDog, cafeItemHamburger,
                                                            cafeItemCheeseburger, cafeItemCocaCola };

            InitializeTbItems(listItems);




        }

        private void InitializeVars()
        {
            summ_cafe = 0;
            summ_total = 0;
            temp_HotDog = 0;
            temp_Cheese = 0;
            temp_Hum = 0;
            temp_Cola = 0;
        }

        private void InitializeTbItems(List<CafeItem> list)
        {
            chkHot.Text = list[0].NameP;
            tbPriceHotDog.Text = list[0].PriceP.ToString();
            chkHum.Text = list[1].NameP;
            tbPriceHum.Text = list[1].PriceP.ToString();
            chkCheese.Text = list[2].NameP;
            tbPriceCheese.Text = list[2].PriceP.ToString();
            chkCola.Text = list[3].NameP;
            tbPriceCola.Text = list[3].PriceP.ToString();

        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double y;
            try
            {
                y = Convert.ToDouble(tbqtyoil.Text);
                tbSum1.Text = (y * Convert.ToDouble(tbPriceOil.Text)).ToString();
            }
            catch (System.FormatException)
            {
                //MessageBox.Show("sorry", "sorry guy");
                return;
                throw;
            }



        }
        private void tbqtyoil_keypress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (!double.TryParse(tb.Text + e.KeyChar.ToString(), out double a) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

            if (!double.TryParse(tb.Text + e.KeyChar.ToString(), out double b) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void cbOil_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = cbOil.SelectedItem as SubjectInfo;
            if (selectedItem != null)
            {
                if (radQtyOil.Checked == true)
                {
                    tbPriceOil.Text = selectedItem.Price.ToString("N2");
                    tbSum1.Text = (selectedItem.Price * (Convert.ToDouble(tbqtyoil.Text))).ToString();
                }
                else
                {
                    tbPriceOil.Text = selectedItem.Price.ToString("N2");
                    tbSum1.Text = ((1 / selectedItem.Price) * (Convert.ToDouble(tbSumOil.Text))).ToString();
                }
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbOil.DisplayMember = "Name";
            cbOil.DataSource = _subjectsRepository.Get();
        }

        private void chkHot_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                tbQtyHotDog.ReadOnly = false;
                cafeItemHotDog.InOrderP = true;
                summ_cafe += temp_HotDog;
                tbSum2.Text = summ_cafe.ToString("N2");

            }
            else
            {
                tbQtyHotDog.ReadOnly = true;
                cafeItemHotDog.InOrderP = false;
                summ_cafe -= temp_HotDog;
                tbSum2.Text = summ_cafe.ToString("N2");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radQtyOil.Checked == true)
            {
                grpPreTotalLeft.Text = "К оплате";
            }
            else
            {
                grpPreTotalLeft.Text = "К выдаче";
            }
            tbqtyoil.ReadOnly = !radQtyOil.Checked;
        }

        private void radSumm_CheckedChanged(object sender, EventArgs e)
        {
            tbSumOil.ReadOnly = !radSummOil.Checked;
        }

        private void tbSumOil_TextChanged(object sender, EventArgs e)
        {
            double y;
            try
            {
                y = Convert.ToDouble(tbSumOil.Text);
                tbSum1.Text = (y / Convert.ToDouble(tbPriceOil.Text)).ToString("N2");
            }
            catch (System.FormatException)
            {
                //MessageBox.Show("sorry", "sorry guy");
                return;
                throw;
            }
        }

        private string GenerateTextFromBlock(CheckBox checkBox,TextBox price, TextBox qty)
        {
            string result = "";
            if (checkBox.Checked == true)
            {
                result = checkBox.Text + "\t" + price.Text + "р.\t" + qty.Text + "\t" +
                    ((Convert.ToDouble(price.Text)) * (Convert.ToDouble(qty.Text))).ToString()+"\n";
            }
            return result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double total;
            string text_oil;

            string text;

            if (radQtyOil.Checked == true)
            {
                total = Convert.ToDouble(tbSum1.Text) + Convert.ToDouble(tbSum2.Text);
                summ_total += total;
                tbSumTotal.Text = total.ToString();
                text = total.ToString();
                text_oil = cbOil.Text + "\t" + tbPriceOil.Text + "р.\t" + tbqtyoil.Text + "л.\t" + tbSum1.Text;
            }
            else
            {
                total = Convert.ToDouble(tbSumOil.Text) + Convert.ToDouble(tbSum2.Text);
                summ_total += total;

                tbSumTotal.Text = total.ToString();
                text = total.ToString();
                text_oil = cbOil.Text + "\t" + tbPriceOil.Text + "р.\t" + tbSum1.Text + "л.\t" + tbSumOil.Text;
            }
            lbTotalDay.Text = summ_total.ToString("N2");
            PrintCheck(text_oil, text);

        }

        private void PrintCheck(string text_oil, string text)
        {
            Word.Application application = new Word.Application();
            application.Visible = true;
            Word.Document document = new Word.Document();
            object MyTemplate = Type.Missing;
            object NewTemplate = false;
            object DocumentType = Word.WdNewDocumentType.wdNewBlankDocument;
            object Visible = true;
            document = application.Documents.Add(ref MyTemplate, ref NewTemplate, ref DocumentType, ref Visible);
            object pargf = Type.Missing;
            Word.Paragraph wordparagraph = document.Content.Paragraphs.Add(ref pargf);

            wordparagraph.Range.Font.Bold = 1;
            wordparagraph.Range.Font.Size = 14;
            wordparagraph.Range.Text = "Чек";
            wordparagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            wordparagraph.Range.InsertParagraphAfter();

            wordparagraph.Range.Font.Size = 12;
            wordparagraph.Range.Text = text_oil;
            wordparagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            wordparagraph.Range.InsertParagraphAfter();

            wordparagraph.Range.Font.Size = 14;
            wordparagraph.Range.Text = "Кафе";
            wordparagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            wordparagraph.Range.InsertParagraphAfter();

            wordparagraph.Range.Font.Size = 12;
            wordparagraph.Range.Text = GenerateTextFromBlock(chkHot, tbPriceHotDog, tbQtyHotDog);
            wordparagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            wordparagraph.Range.InsertParagraphAfter();

            wordparagraph.Range.Font.Size = 12;
            wordparagraph.Range.Text = GenerateTextFromBlock(chkCheese, tbPriceCheese, tbQtyCheese);
            wordparagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            wordparagraph.Range.InsertParagraphAfter();
            wordparagraph.Range.Font.Size = 12;

            wordparagraph.Range.Text = GenerateTextFromBlock(chkHum, tbPriceHum, tbQtyHum);
            wordparagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            wordparagraph.Range.InsertParagraphAfter();
            wordparagraph.Range.Font.Size = 12;

            wordparagraph.Range.Text = GenerateTextFromBlock(chkCola, tbPriceCola, tbQtyCola);
            wordparagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            wordparagraph.Range.InsertParagraphAfter();

            wordparagraph.Range.Font.Size = 24;
            wordparagraph.Range.Text = "Итого: " + text;
            wordparagraph.Format.SpaceAfter = 14;
            DateTime dt = DateTime.Now;
            string nameFile = "check_" + dt.ToString("yyyy-mm-dd_HH_mm_ss");

            object pathToSaveObj = @"D:/" + nameFile + ".doc";
            document.SaveAs2(ref pathToSaveObj, Word.WdSaveFormat.wdFormatDocument);
        }

        private void chkHum_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                tbQtyHum.ReadOnly = false;
                cafeItemHamburger.InOrderP = true;
                summ_cafe += temp_Hum;
                tbSum2.Text = summ_cafe.ToString("N2");

            }
            else
            {
                tbQtyHum.ReadOnly = true;
                cafeItemHamburger.InOrderP = false;
                summ_cafe -= temp_Hum;
                tbSum2.Text = summ_cafe.ToString("N2");

            }
        }

        private void chkCheese_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                tbQtyCheese.ReadOnly = false;
                cafeItemCheeseburger.InOrderP = true;
                summ_cafe += temp_Cheese;
                tbSum2.Text = summ_cafe.ToString("N2");

            }
            else
            {
                tbQtyCheese.ReadOnly = true;
                cafeItemCheeseburger.InOrderP = false;
                summ_cafe -= temp_Cheese;
                tbSum2.Text = summ_cafe.ToString("N2");
            }
        }

        private void chkCola_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                tbQtyCola.ReadOnly = false;
                cafeItemCocaCola.InOrderP = true;
                summ_cafe += temp_Cola;
                tbSum2.Text = summ_cafe.ToString("N2");
            }
            else
            {
                tbQtyCola.ReadOnly = true;
                cafeItemCocaCola.InOrderP = false;
                summ_cafe -= temp_Cola;
                tbSum2.Text = summ_cafe.ToString("N2");
            }

        }

        private void tbQtyHotDog_TextChanged(object sender, EventArgs e)
        {
            summ_cafe -= temp_HotDog;
            temp_HotDog = Calculate(tbQtyHotDog, tbPriceHotDog);
            summ_cafe += temp_HotDog;
            tbSum2.Text = summ_cafe.ToString("N2");
        }

        private double Calculate(TextBox tbPrice, TextBox tbQty)
        {
            double y = 0;
            try
            {
                y = Convert.ToDouble(tbQty.Text);
                y *= (Convert.ToDouble(tbPrice.Text));

            }
            catch (System.FormatException)
            {

                return 0;
                throw;
            }
            return y;
        }

        private void tbQtyHum_TextChanged(object sender, EventArgs e)
        {
            summ_cafe -= temp_Hum;
            temp_Hum = Calculate(tbQtyHum, tbPriceHum);
            summ_cafe += temp_Hum;
            tbSum2.Text = summ_cafe.ToString("N2");
        }

        private void tbQtyCheese_TextChanged(object sender, EventArgs e)
        {
            summ_cafe -= temp_Cheese;
            temp_Cheese = Calculate(tbQtyCheese, tbPriceCheese);
            summ_cafe += temp_Cheese;
            tbSum2.Text = summ_cafe.ToString("N2");
        }

        private void tbQtyCola_TextChanged(object sender, EventArgs e)
        {
            summ_cafe -= temp_Cola;
            temp_Cola = Calculate(tbQtyCola, tbPriceCola);
            summ_cafe += temp_Cola;
            tbSum2.Text = summ_cafe.ToString("N2");
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Выручка за день составила " + summ_total.ToString("N2"), "Выручка за день", MessageBoxButtons.OK);
        }
    }
}
