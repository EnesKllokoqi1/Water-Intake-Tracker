using Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.WebUI;
using Windows.UI.Xaml.Controls;
using static System.Net.Mime.MediaTypeNames;

namespace ClassLibrary2
{
    public class DayMethods :IProperyUpdaters,INotifyPropertyChanged
    {
        private ListView _main_List_View;
        private  ListView _the_Days_List_View;
        public DayMethods() { }
        public DayMethods(ListView listView,ListView listView1)
        {
            _main_List_View = listView;
            _the_Days_List_View = listView1;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private string _dayName;
        public string Day_Name
        {
            get => _dayName;

            set
            {
                if (_dayName == value)
                {
                    return;
                }
                _dayName = value;
                OnPropertyChanged(nameof(Day_Name));

            }
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private bool flag = false;

     

        public bool TextBoxProperty { get => flag;

            set {
                
                if (flag == value)
                {
                    return;
                }
                flag = value;
                OnPropertyChanged(nameof(TextBoxProperty));
            }
        }
   

        public async Task MethodForMonday()
        {
            TextBoxProperty = true;
            DayIdentifier dayIdentifier0 = new DayIdentifier
            {
                DayName = "Monday"
            };
            using (AppDbContext dbContext = new AppDbContext())
            {
                if (!dbContext.DayIdentifiers.Any(e => e.DayName == dayIdentifier0.DayName))
                {
                    dbContext.Add(dayIdentifier0);
                    await dbContext.SaveChangesAsync();
                    await AddListItem_To_SecondListView($"The selected day: {dayIdentifier0.DayName} is added in the database! \n You can now write the milliliters for this day in the textbox below!");
                }
                else
                {
                    await AddListItem_To_SecondListView("Monday is already in the database! \n You can add the milliliters for Monday below!");
                    return;
                }
            }
        }
        public async Task MethodForTuesday()
        {

            TextBoxProperty = true;
            DayIdentifier dayIdentifier1 = new DayIdentifier
            {
                DayName = "Tuesday"
            };
            using (AppDbContext dbContext = new AppDbContext())
            {
                if (!dbContext.DayIdentifiers.Any(e => e.DayName == dayIdentifier1.DayName))
                {
                    dbContext.DayIdentifiers.Add(dayIdentifier1);
                    await dbContext.SaveChangesAsync();
                    await AddListItem_To_SecondListView($"The selected day: {dayIdentifier1.DayName} is added in the database\n  You can now write the milliliters for this day in the textbox below!");
                }
                else
                {
                    await AddListItem_To_SecondListView("Tuesday is already in the database! \n You can add the milliliters for Tuesday below!");
                }
            }
        }
        public async Task MethodForWednesday()
        {
            TextBoxProperty = true;
            DayIdentifier dayIdentifier2 = new DayIdentifier
            {
                DayName = "Wednesday"
            };
            using (AppDbContext dbContext = new AppDbContext())
            {
                if (!dbContext.DayIdentifiers.Any(e => e.DayName == dayIdentifier2.DayName))
                {
                    dbContext.DayIdentifiers.Add(dayIdentifier2);
                    await dbContext.SaveChangesAsync();
                    await AddListItem_To_SecondListView($"The selected day: {dayIdentifier2.DayName} is added in the database \n  You can now write the milliliters for this day in the textbox below!");

                }
                else
                {
                    await AddListItem_To_SecondListView("Wednesday is already in the database! \n You can add the milliliters for Wednesday below!"); ;
                }
            }
        }
        public async Task MethodForThursday()
        {
            TextBoxProperty = true;
            DayIdentifier dayIdentifier3 = new DayIdentifier
            {
                DayName = "Thursday"
            };
            using (AppDbContext dbContext = new AppDbContext())
            {
                if (!dbContext.DayIdentifiers.Any(e => e.DayName == dayIdentifier3.DayName))
                {
                    dbContext.DayIdentifiers.Add(dayIdentifier3);
                    await dbContext.SaveChangesAsync();
                    await AddListItem_To_SecondListView($"The selected day: {dayIdentifier3.DayName} is added in the database \n  You can now write the milliliters for this day in the textbox below!");
                }
                else
                {
                    await AddListItem_To_SecondListView("Thursday is already in the database! \n You can add the milliliters for Thursday below!"); ;

                }
            }
        }
        public async Task MethodForFriday()
        {
            TextBoxProperty = true;
            DayIdentifier dayIdentifier4 = new DayIdentifier
            {
                DayName = "Friday"
            };
            using (AppDbContext dbContext = new AppDbContext())
            {
                if (!dbContext.DayIdentifiers.Any(e => e.DayName == dayIdentifier4.DayName))
                {
                    dbContext.DayIdentifiers.Add(dayIdentifier4);
                    await dbContext.SaveChangesAsync();
                    await AddListItem_To_SecondListView($"The selected day: {dayIdentifier4.DayName} is added in the database \n  You can now write the milliliters for this day in the textbox below!");

                }
                else
                {
                    await AddListItem_To_SecondListView("Friday is already in the database! \n You can add the milliliters for Friday below!"); ;

                }
            }
        }
        public async Task MethodForSaturday()
        {
            TextBoxProperty = true;
            DayIdentifier dayIdentifier5 = new DayIdentifier
            {
                DayName = "Saturday"
            };

            using (AppDbContext dbContext = new AppDbContext())
            {
                if (!dbContext.DayIdentifiers.Any(e => e.DayName == dayIdentifier5.DayName))
                {
                    dbContext.DayIdentifiers.Add(dayIdentifier5);
                    await dbContext.SaveChangesAsync();
                    await AddListItem_To_SecondListView($"The selected day: {dayIdentifier5.DayName} is added in the database \n  You can now write the milliliters for this day in the textbox below!");

                }
                else
                {
                    await AddListItem_To_SecondListView("Saturday is already in the database.\n You can add the milliliters for Saturday below!");

                }
            }

        }
        public async Task MethodForSunday()
        {
            TextBoxProperty = true;
            DayIdentifier dayIdentifier6 = new DayIdentifier
            {
                DayName = "Sunday"
            };
            using (AppDbContext dbContext = new AppDbContext())
            {
                if (!dbContext.DayIdentifiers.Any(e => e.DayName == dayIdentifier6.DayName))
                {
                    dbContext.DayIdentifiers.Add(dayIdentifier6);
                    await dbContext.SaveChangesAsync();
                    await AddListItem_To_SecondListView($"The selected day: {dayIdentifier6.DayName} is added in the database \n  You can now write the milliliters for this day \n in the textbox below!");

                }
                else
                {
                    await AddListItem_To_SecondListView("Sunday is already in the database! \n You can add the milliliters for Sunday below!"); ;
                }
            }


        }
       
       

        public async Task Addlistitem_To_Main_Listview(string text)
        {
            TextBlock textBlock = new TextBlock();
            textBlock.Text = text;

            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Content = text;
            textBlock.IsTapEnabled = false;
            listViewItem.IsTapEnabled = false;
            listViewItem.IsHitTestVisible = false;
            _main_List_View.Items.Add(listViewItem);
            await Task.Delay(4700);
            _main_List_View.Items.Remove(listViewItem);
        }
       public  void Add_FinalResults_To_MainView(string result)
        {
            TextBlock textBlock = new TextBlock();
            textBlock.Text = result;
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Content = result;
            textBlock.IsTapEnabled = false;
            listViewItem.IsTapEnabled = false;
            listViewItem.IsHitTestVisible = false;
            _main_List_View.Items.Add(listViewItem);
           

        }
        public async Task AddListItem_To_SecondListView(string text)
        {

            TextBlock textBlock = new TextBlock();
            textBlock.Text = text;
            textBlock.IsTapEnabled = false;

            ListViewItem listViewItem = new ListViewItem();

            listViewItem.Content = textBlock;

            listViewItem.IsTapEnabled = false;
            listViewItem.IsHitTestVisible = false;

            _the_Days_List_View.Items.Add(listViewItem);

            await Task.Delay(4700);
            _the_Days_List_View.Items.Remove(listViewItem);


        }
    }
}
