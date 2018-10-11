using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClassesLaboratory
{
    using Classes.NS_Game;
    public partial class MainForm : Form
    {
        private SortedDictionary<int, Classes.Good> goodDictionary = new SortedDictionary<int, Classes.Good>();
        private SortedDictionary<int, Classes.Good> orderDictionary = new SortedDictionary<int, Classes.Good>();
        private ListViewItem previousListViewItem = null;

        public MainForm()
        {
            InitializeComponent();

            List<Classes.Good> list = new List<Classes.Good>();

            // Dairy products

            list.Add((new Classes.DairyProductBuilder()
                .SetNutrients(new Classes.Nutrients(42, 3, 5, 1))
                .SetBsInfo(new Classes.BaseInfoAboutGood(1000, new Classes.SizeGood(10, 12, 3)))
                .SetName("Milk \"Cheerful milkman\"")
                .SetPrice(2.19)
                .SetManufacturerName("Wimm-Bill-Damm") as Classes.DairyProductBuilder)
                .Build()
                );

            list.Add((new Classes.DairyProductBuilder()
                .SetNutrients(new Classes.Nutrients(402, 25, 1, 33))
                .SetBsInfo(new Classes.BaseInfoAboutGood(100, new Classes.SizeGood(5, 8, 5)))
                .SetName("Cheese \"Camembert\"")
                .SetPrice(5.99)
                .SetManufacturerName("Lactalis") as Classes.DairyProductBuilder)
                .Build()
                );

            list.Add((new Classes.DairyProductBuilder()
                .SetNutrients(new Classes.Nutrients(301, 31, 4, 15))
                .SetBsInfo(new Classes.BaseInfoAboutGood(100, new Classes.SizeGood(10, 10, 2)))
                .SetName("Curd \"Latter\"")
                .SetPrice(3.59)
                .SetManufacturerName("Lactalis") as Classes.DairyProductBuilder)
                .Build()
                );

            list.Add((new Classes.DairyProductBuilder()
                .SetNutrients(new Classes.Nutrients(250, 20, 3, 18))
                .SetBsInfo(new Classes.BaseInfoAboutGood(100, new Classes.SizeGood(7, 5, 3)))
                .SetName("Curd \"President\"")
                .SetPrice(2.99)
                .SetManufacturerName("Webbe") as Classes.DairyProductBuilder)
                .Build()
                );

            // ---

            list.Add( (new ConstructorBuilder()
                .SetDurationOfBuildInHour(1)
                .SetCountOfDetails(450)
                .SetMaterial(EnMaterialConstructor.Plastic)
                .SetBsInfo(new Classes.BaseInfoAboutGood(500, new Classes.SizeGood(16, 12, 8)))
                .SetAgeLimit(8)
                .SetName("LEGO Batman Movie")
                .SetPrice(35.99)
                .SetManufacturerName("LEGO") as ConstructorBuilder)
                .Build()
                );

            list.Add( (new ConstructorBuilder()
                .SetDurationOfBuildInHour(1)
                .SetCountOfDetails(170)
                .SetMaterial(EnMaterialConstructor.Metal)
                .SetBsInfo(new Classes.BaseInfoAboutGood(580, new Classes.SizeGood(17, 8, 29)))
                .SetAgeLimit(8)
                .SetName("Metal constructor Eitech")
                .SetPrice(24.99)
                .SetManufacturerName("Eitech") as ConstructorBuilder)
                .Build()
                );

            list.Add( (new ConstructorBuilder()
                .SetDurationOfBuildInHour(0)
                .SetCountOfDetails(80)
                .SetMaterial(EnMaterialConstructor.Plastic)
                .SetBsInfo(new Classes.BaseInfoAboutGood(200, new Classes.SizeGood(30, 17, 35)))
                .SetAgeLimit(1)
                .SetName("Constructor First Builders MEGA BLOKS")
                .SetPrice(21.99)
                .SetManufacturerName("Mattel") as ConstructorBuilder)
                .Build()
                );

            list.Add( (new ConstructorBuilder()
                .SetDurationOfBuildInHour(0)
                .SetCountOfDetails(100)
                .SetMaterial(EnMaterialConstructor.Wood)
                .SetBsInfo(new Classes.BaseInfoAboutGood(1700, new Classes.SizeGood(35, 23, 10)))
                .SetAgeLimit(3)
                .SetName("Wood constructor")
                .SetPrice(22.99)
                .SetManufacturerName("Melissa & Doug") as ConstructorBuilder)
                .Build()
                );

            // ---------------------------------------------------------------------------------

            list.Add( (new SoftToyBuilder()
                .SetMaterial(EnMaterialSoftToy.FauxFur)
                .SetFiller(EnFillerSoftToy.Polyester)
                .SetBsInfo(new Classes.BaseInfoAboutGood(600, new Classes.SizeGood(27, 18, 36)))
                .SetAgeLimit(3)
                .SetName("Toy \"Lion\"")
                .SetPrice(28.99)
                .SetManufacturerName("Hansa") as SoftToyBuilder)
                .Build()
                );

            list.Add( (new SoftToyBuilder()
                .SetMaterial(EnMaterialSoftToy.Cloth)
                .SetFiller(EnFillerSoftToy.Polyester)
                .SetBsInfo(new Classes.BaseInfoAboutGood(400, new Classes.SizeGood(23, 14, 32)))
                .SetAgeLimit(3)
                .SetName("Toy \"Bear\"")
                .SetPrice(18.99)
                .SetManufacturerName("Orange") as SoftToyBuilder)
                .Build()
                );

            list.Add( (new SoftToyBuilder()
                .SetMaterial(EnMaterialSoftToy.FauxFur)
                .SetFiller(EnFillerSoftToy.Polyester)
                .SetBsInfo(new Classes.BaseInfoAboutGood(450, new Classes.SizeGood(25, 17, 34)))
                .SetAgeLimit(3)
                .SetName("Toy \"Crocodile\"")
                .SetPrice(23.99)
                .SetManufacturerName("Trudi") as SoftToyBuilder)
                .Build()
                );

            // ---------------------------------------------------------------------------------

            list.Add( (new VideoGameBuilder()
                .SetPlatform(EnGamePlatform.PC)
                .SetMode(EnGameMode.Multiplayer)
                .SetGenre(EnGenreVideoGame.Action)
                .SetStyle(EnStylistic.Modern)
                .SetAgeLimit(18)
                .SetName("Counter-Strike: Global Offensive")
                .SetPrice(9.99)
                .SetManufacturerName("Valve") as VideoGameBuilder)
                .Build()
                );

            list.Add( (new VideoGameBuilder()
                .SetPlatform(EnGamePlatform.XBOX)
                .SetMode(EnGameMode.Singleplayer)
                .SetGenre(EnGenreVideoGame.RPG)
                .SetStyle(EnStylistic.Fantasy)
                .SetAgeLimit(18)
                .SetName("Witcher 3: Wild Hunt")
                .SetPrice(18.99)
                .SetManufacturerName("CD PROJEKT RED") as VideoGameBuilder)
                .Build()
                );

            list.Add( (new VideoGameBuilder()
                .SetPlatform(EnGamePlatform.PlayStation)
                .SetMode(EnGameMode.Singleplayer)
                .SetGenre(EnGenreVideoGame.Adventure)
                .SetStyle(EnStylistic.Cyberpunk)
                .SetAgeLimit(18)
                .SetName("Deus Ex: Human Revolution")
                .SetPrice(15.99)
                .SetManufacturerName("Eidos Montreal") as VideoGameBuilder)
                .Build()
                );

            list.Add( (new VideoGameBuilder()
                .SetPlatform(EnGamePlatform.PC)
                .SetMode(EnGameMode.Both)
                .SetGenre(EnGenreVideoGame.Strategy)
                .SetStyle(EnStylistic.Modern)
                .SetAgeLimit(16)
                .SetName("Sid Meyer's Civilization VI")
                .SetPrice(19.99)
                .SetManufacturerName("Firaxis Games") as VideoGameBuilder)
                .Build()
                );

            // ---------------------------------------------------------------------------------

            // Спрятать убожество выше куда-нибудь от посторонних глаз и подумать над оптимизацией

            for (int i = 0, k = 0; i < GoodListView.Groups.Count; i++)
            {
                for (int j = 0; j < GoodListView.Groups[i].Items.Count; j++, k++)
                {
                    GoodListView.Groups[i].Items[j].Tag = GoodListView.Groups[i].Items[j].GetHashCode();
                    goodDictionary.Add(Convert.ToInt32(GoodListView.Groups[i].Items[j].Tag), list[k]);
                }
            }


        }

        private void ListView_ItemActivate(object sender, EventArgs e)
        {
            ListView currentListView = sender as ListView;
            if (currentListView.SelectedItems.Count != 1) return;
            ListViewItem selectedListViewItem = currentListView.SelectedItems[0];

            if (currentListView.Equals(GoodListView))
            {
                Classes.Good findGood;
                if (goodDictionary.TryGetValue(Convert.ToInt32(selectedListViewItem.Tag), out findGood)) {
                    Classes.Good newGood = findGood.Clone() as Classes.Good;

                    ListViewItem copyListItem = selectedListViewItem.Clone() as ListViewItem;
                    OrderListView.Items.Add(copyListItem).Group = OrderListView.Groups[0];
                    copyListItem.Tag = copyListItem.GetHashCode();
                    orderDictionary.Add(Convert.ToInt32(copyListItem.Tag), newGood);

                    CountOfGood.Text = (Convert.ToInt32(CountOfGood.Text) + 1).ToString();
                    MainLabel.Text = "You can pay for your order clicking to button \"Pay for the purchase\"";
                }
            }

            if (currentListView.Equals(OrderListView))
            {
                orderDictionary.Remove(Convert.ToInt32(selectedListViewItem.Tag));
                currentListView.Items.Remove(selectedListViewItem);

                CountOfGood.Text = (Convert.ToInt32(CountOfGood.Text) - 1).ToString();
                if (CountOfGood.Text == "0") MainLabel.Text = "Select products";
            }
        }

        private string GetGoodInfo(Classes.Good targetGood)
        {
            if (targetGood is Classes.Game)
            {
                if (targetGood as VideoGame != null) return (targetGood as VideoGame).GetInfo();
                if (targetGood as ConstructorGame != null) return (targetGood as ConstructorGame).GetInfo();
                if (targetGood as SoftToy != null) return (targetGood as SoftToy).GetInfo();
            }
            
            if(targetGood is Classes.Product)
            {
                if (targetGood as Classes.DairyProduct != null) return (targetGood as Classes.DairyProduct).GetInfo();
            }
            return null;
        }

        private void OrderListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // ***
            // Дописать таким образом, чтобы между ListView сбрасывалось состояние выделенных эл-тов и корректно обновлялся InfoGoodTextBox
            // ***
            ListView currentListView = sender as ListView;
            if (!e.IsSelected) { InfoGoodTextBox.Clear(); return; }
            // if (currentListView.SelectedItems == -1) return;
            // if (currentListView.SelectedItems.Count != 1) return;
            ListViewItem selectedListViewItem = e.Item;
            // MessageBox.Show(e.IsSelected.ToString());

            if (previousListViewItem == null)
            {
                if(e.IsSelected == true)
                    previousListViewItem = selectedListViewItem;
            }
            else
            {
                if (!currentListView.Equals(previousListViewItem.ListView))
                {
                    previousListViewItem.Selected = false;
                }
            }

            Classes.Good findGood;
            if (goodDictionary.TryGetValue(Convert.ToInt32(selectedListViewItem.Tag), out findGood) ||
                orderDictionary.TryGetValue(Convert.ToInt32(selectedListViewItem.Tag), out findGood))
            {
                if (InfoGoodTextBox.Text != String.Empty) InfoGoodTextBox.Clear();
                string infoGood = GetGoodInfo(findGood);
                if (infoGood != null) InfoGoodTextBox.AppendText(infoGood);
            }
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            if (orderDictionary.Values.Count == 0) return;
            string checkStr = String.Empty;

            double totalPurchase = 0;
            foreach(Classes.Good item in orderDictionary.Values)
            {
                checkStr += item.GetName() + ": " + item.GetPrice() + "$" + Environment.NewLine;
                totalPurchase += item.GetPrice();
            }

            checkStr += Environment.NewLine + "Total purchase: " + totalPurchase + "$";
            MessageBox.Show(checkStr);
            Application.Exit();
        }
    }
}
