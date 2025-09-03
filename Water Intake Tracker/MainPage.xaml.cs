using Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using ClassLibrary2;
using System.ServiceModel.Channels;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Water_Intake_Tracker
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed   partial class MainPage : Page
    {

        DayMethods day_Methods;
        public MainPage()
        {
            this.InitializeComponent();
            day_Methods = new DayMethods(TheMain_ListView, Thedays_ListView);

            this.DataContext = day_Methods;
        }      
        private   async void DropDownButton_Click(object sender, RoutedEventArgs e)
        {
          day_Methods.TextBoxProperty = true;
           
            MenuFlyoutItem theItem = (MenuFlyoutItem)sender;
            day_Methods.Day_Name = theItem.Tag.ToString();
            switch (theItem.Tag.ToString())
            {

                case "monday":
                    await day_Methods.MethodForMonday();         
                    break;
                case "tuesday":
                   await day_Methods.MethodForTuesday();
                    break;
                case "wednesday":
                   await day_Methods.MethodForWednesday(); 
                    break;
                case "thursday":
                    await day_Methods.MethodForThursday();
                    break;
                case "friday":
                    await day_Methods.MethodForFriday();
                    break;
                case "saturday":
                  await day_Methods.MethodForSaturday();
                    break;
                case "sunday":
                   await  day_Methods.MethodForSunday();
                    break;
            }
            ;
        }
       

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try {
                using (AppDbContext dbContext = new AppDbContext())
                {
                    if (string.IsNullOrWhiteSpace(textbox1.Text) || !double.TryParse(textbox1.Text, out _))
                    {
                        await day_Methods.AddListItem_To_SecondListView($"The text box must have a numeric value \n  before clicking the button!");
                        return;
                    }
                    if (double.TryParse(textbox1.Text, out double s))
                    {
                        switch (day_Methods.Day_Name)
                        {
                            case "monday":
                                var monday = dbContext.DayIdentifiers.First(m => m.DayName == "Monday");
                                Water_Specifics water_Specifics = new Water_Specifics()
                                {
                                    DateTime = DateTime.Now,
                                    DayIdentifier = monday,
                                    Milliliters = s
                                };
                                await dbContext.Water_Specifics.AddAsync(water_Specifics);
                                await dbContext.SaveChangesAsync();
                                await day_Methods.Addlistitem_To_Main_Listview($"Added : {s}ml to : {monday.DayName} ! ");
                                break;
                            case "tuesday":
                                var tuesday = dbContext.DayIdentifiers.First(m => m.DayName == "Tuesday");
                                Water_Specifics water_Specifics1 = new Water_Specifics()
                                {
                                    DateTime = DateTime.Now,
                                    DayIdentifier = tuesday,
                                    Milliliters = s
                                };
                                await dbContext.Water_Specifics.AddAsync(water_Specifics1);
                                await dbContext.SaveChangesAsync();
                                await day_Methods.Addlistitem_To_Main_Listview($"Added : {s}ml to : {tuesday.DayName} ! ");
                                break;
                               
                            case "wednesday":
                                var wednesday = dbContext.DayIdentifiers.First(m => m.DayName == "Wednesday");
                                Water_Specifics water_Specifics2 = new Water_Specifics()
                                {
                                    DateTime = DateTime.Now,
                                    DayIdentifier = wednesday,
                                    Milliliters = s
                                };
                                await dbContext.Water_Specifics.AddAsync(water_Specifics2);
                                await dbContext.SaveChangesAsync();
                                await day_Methods.Addlistitem_To_Main_Listview($"Added : {s}ml to : {wednesday.DayName} ! ");
                                break;
                            case "thursday":
                                var thursday = dbContext.DayIdentifiers.First(m => m.DayName == "Thursday");
                                Water_Specifics water_Specifics3= new Water_Specifics()
                                {
                                    DateTime = DateTime.Now,
                                    DayIdentifier = thursday,
                                    Milliliters = s
                                };
                                await dbContext.Water_Specifics.AddAsync(water_Specifics3);
                                await dbContext.SaveChangesAsync();
                                await day_Methods.Addlistitem_To_Main_Listview($"Added : {s}ml to : {thursday.DayName} ! ");
                                break;
                            case "friday":
                                var friday = dbContext.DayIdentifiers.First(m => m.DayName == "Friday");
                                Water_Specifics water_Specifics4 = new Water_Specifics()
                                {
                                    DateTime = DateTime.Now,
                                    DayIdentifier = friday,
                                    Milliliters = s
                                };
                                await dbContext.Water_Specifics.AddAsync(water_Specifics4);
                                await dbContext.SaveChangesAsync();
                                await day_Methods.Addlistitem_To_Main_Listview($"Added : {s}ml to : {friday.DayName} ! ");
                                break;
                            case "saturday":
                                var saturday = dbContext.DayIdentifiers.First(m => m.DayName == "Saturday");
                                Water_Specifics water_Specifics5 = new Water_Specifics()
                                {
                                    DateTime = DateTime.Now,
                                    DayIdentifier = saturday,
                                    Milliliters = s
                                };
                                await dbContext.Water_Specifics.AddAsync(water_Specifics5);
                                await dbContext.SaveChangesAsync();
                                await day_Methods.Addlistitem_To_Main_Listview($"Added : {s}ml to : {saturday.DayName} ! ");
                                break;
                            case "sunday":
                                var sunday = dbContext.DayIdentifiers.First(m => m.DayName == "Sunday");
                                Water_Specifics water_Specifics6 = new Water_Specifics()
                                {
                                    DateTime = DateTime.Now,
                                    DayIdentifier = sunday,
                                    Milliliters = s
                                };
                                await dbContext.Water_Specifics.AddAsync(water_Specifics6);
                                await day_Methods.Addlistitem_To_Main_Listview($"Added : {s}ml to : {sunday.DayName} ! ");
                                await dbContext.SaveChangesAsync();
                               
                                break;

                        }
                    ;
                    }
                }

            }
            catch(Exception ex )
            {
                await day_Methods.AddListItem_To_SecondListView($"{ex.Message}");
            }
                
        }

        private  async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
           
            using (AppDbContext dbContext = new AppDbContext()) {
            
               
                    var Results = dbContext.Water_Specifics.Include(Z => Z.DayIdentifier).Where(c => c.DayIdentifier != null).AsEnumerable().GroupBy(a => a.DayIdentifier.DayName).Select(n => new
                    {
                        Day = n.Key,
                        
                        Data = n.Select(x => new
                        {
                            Milliliters = x.Milliliters,
                            DateTime = x.DateTime
                        })
                    });
                if (Results.Count() == 0)
                {
                    await day_Methods.Addlistitem_To_Main_Listview("There isnt a day with assosiciated data yet.....");
                    return;
                }
            
                
                foreach (var group in Results)
                {
                    day_Methods.Add_FinalResults_To_MainView($"Day : {group.Day}\n");
                  
                    foreach(var val in group.Data)
                    {
                        day_Methods.Add_FinalResults_To_MainView($"DateTime  : {val.DateTime} \n Milliliters : {val.Milliliters}ml \n");
                    }
                }
                Visible_Button.Visibility = Visibility.Visible;
               
              
            }
        }

        private void Visible_Button_Click(object sender, RoutedEventArgs e)
        {
            TheMain_ListView.Items.Clear();
            Visible_Button.Visibility = Visibility.Collapsed;
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {

            using (AppDbContext dbContext = new AppDbContext())
            {
                if (dbContext.DayIdentifiers.Count()==0)
                {
                    await day_Methods.Addlistitem_To_Main_Listview("No data for the weekend currently...");
                    return;
                }
                else
                {
                  
                   foreach(var item in dbContext.DayIdentifiers)
                    {
                      
                        dbContext.DayIdentifiers.Remove(item);
                        await day_Methods.Addlistitem_To_Main_Listview($"{item.DayName} and all its associated data have been successfully deleted");
                    }
                   
                }
               await dbContext.SaveChangesAsync();
            }
        }
    }
}
