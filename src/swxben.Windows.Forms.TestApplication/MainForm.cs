using System;
using System.Globalization;
using System.Windows.Forms;
using swxben.Windows.Forms.Controls;
using swxben.Windows.Forms.Dialogs;

namespace swxben.Windows.Forms.TestApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            WatermarkedTextBox.SetWatermark("Watermarked text box");
        }

        private void DateTimePromptButton_Click(object sender, EventArgs e)
        {
            IDateTimePrompt prompt = new DateTimePromptDialog();
            prompt.SetValues("Select a date", "Date selection", new DateTime(2013, 01, 01));
            MessageBox.Show(prompt.ShowDialog() != DialogResult.OK ? "Cancelled" : string.Format("Selected {0}", prompt.Value));
        }

        class Vampire
        {
            public string Name;
            public int Age;
        }
        private void GenericListSearchButton_Click(object sender, EventArgs e)
        {
            IGenericListSearch<Vampire> search = new GenericListSearchDialog<Vampire>();
            var vampires = new[]
                {
                    new Vampire {Name = "Bill", Age = 172},
                    new Vampire {Name = "Jessica", Age = 17},
                    new Vampire {Name = "Erik", Age = 1204}
                };
            search.SetValues("Select your favourite vampire", vampires, vampire => vampire.Name);
            MessageBox.Show(search.ShowDialog() != DialogResult.OK ? "Cancelled" : string.Format("Selected {0}", search.SelectedItem.Name));
        }

        private void StringListSearchButton_Click(object sender, EventArgs e)
        {
            IStringListSearch search = new StringListSearchDialog("Select a language", new[] { "C#", "C++", "Ruby", "Scala", "Javascript", "Java" });
            MessageBox.Show(search.ShowDialog() != DialogResult.OK ? "Cancelled" : string.Format("Selected {0}", search.SelectedItem));
        }

        private void TextPromptButton_Click(object sender, EventArgs e)
        {
            ITextPrompt prompt = new TextPromptDialog("What is the driver's name:", "Driver name", "Jane");
            MessageBox.Show(prompt.ShowDialog() != DialogResult.OK ? "Cancelled" : string.Format("Name is {0}", prompt.Value));
        }

        private void GenericDetailedListSearchButton_Click(object sender, EventArgs e)
        {
            IGenericDetailedListSearch<Vampire> search = new GenericDetailedListSearchDialog<Vampire>();
            var vampires = new[]
                {
                    new Vampire {Name = "Bill", Age = 172},
                    new Vampire {Name = "Jessica", Age = 17},
                    new Vampire {Name = "Erik", Age = 1204}
                };
            search.SetValues(
                "Select your favourite vampire",
                vampires,
                new[] { "Name", "Age" },
                vampire => new[] { vampire.Name, vampire.Age.ToString(CultureInfo.InvariantCulture) });
            search.FixWidth();
            MessageBox.Show(search.ShowDialog() != DialogResult.OK ? "Cancelled" : string.Format("Selected {0}", search.SelectedItem.Name));
        }

        class ItemRate
        {
            public string Category;
            public string Code;
            public string Description;
        }
        private void GenericDetailedListSearchFixWidthButton_Click(object sender, EventArgs e)
        {
            IGenericDetailedListSearch<ItemRate> search = new GenericDetailedListSearchDialog<ItemRate>();
            var items = new[]
                {
                    new ItemRate {Category="Whitegoods", Code = "WG_KITCHEN_REFRIDGERATOR", Description = "Refridgerator" },
                    new ItemRate {Category="Smallgoods", Code = "DELI_SALAMI", Description = "Salami" },
                    new ItemRate {Category="Smallclothes", Code = "CLOTHING_UNDERWEAR_BOXERS", Description = "Nooo, briefs." }
                };
            search.SetValues(
                "Select an item",
                items,
                new[] { "Category", "Code", "Description" },
                i => new[] { i.Category, i.Code, i.Description });
            search.FixWidth();
            search.FixWidth();
            search.FixWidth();
            MessageBox.Show(search.ShowDialog() != DialogResult.OK ? "Cancelled" : string.Format("Selected {0}", search.SelectedItem.Code));
        }
    }
}
