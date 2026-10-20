using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ArriveChange(object sender, SelectionChangedEventArgs e)
        {
            if (MyComboBox.SelectedItem is ComboBoxItem SelectedItem)
            {
                string selectedText = SelectedItem.Content.ToString();
                if (selectedText == "לירן רויאל")
                {
                    int sum = 0;

                    if (ArriveCalendar.SelectedDate is DateTime Arrive && ReturnCalendar.SelectedDate is DateTime Return && Return > Arrive)
                    {
                        NightAmount.Text = (Return - Arrive).Days.ToString();
                        for (DateTime i = Arrive; i < Return; i = i.AddDays(1))
                        {
                            if (i.DayOfWeek == DayOfWeek.Saturday)
                                sum += 1200;
                            else
                                sum += 500;
                        }
                        Price.Text = sum.ToString();
                    }
                }
                else if (selectedText == "לירנובה")
                {
                    int sum = 0;

                    if (ArriveCalendar.SelectedDate is DateTime Arrive && ReturnCalendar.SelectedDate is DateTime Return && Return > Arrive)
                    {
                        NightAmount.Text = (Return - Arrive).Days.ToString();
                        for (DateTime i = Arrive; i < Return; i = i.AddDays(1))
                        {
                            if (i.DayOfWeek == DayOfWeek.Saturday)
                                sum += 1000;
                            else
                                sum += 400;
                        }
                        Price.Text = sum.ToString();
                    }
                }
                else if (selectedText == "לירן ויסטה")
                {
                    int sum = 0;

                    if (ArriveCalendar.SelectedDate is DateTime Arrive && ReturnCalendar.SelectedDate is DateTime Return && Return > Arrive)
                    {
                        NightAmount.Text = (Return - Arrive).Days.ToString();
                        for (DateTime i = Arrive; i < Return; i = i.AddDays(1))
                        {
                            if (i.DayOfWeek == DayOfWeek.Saturday)
                                sum += 1400;
                            else
                                sum += 600;
                        }
                        Price.Text = sum.ToString();
                    }
                }
            }
        }
        
        private void ReturnChange(object sender, SelectionChangedEventArgs e)
        {
            if (MyComboBox.SelectedItem is ComboBoxItem SelectedItem) {
                string selectedText = SelectedItem.Content.ToString();
                if (selectedText == "לירן רויאל") { 
                    int sum = 0;

                    if (ArriveCalendar.SelectedDate is DateTime Arrive && ReturnCalendar.SelectedDate is DateTime Return && Return > Arrive)
                    {
                        NightAmount.Text = (Return - Arrive).Days.ToString();
                        for (DateTime i = Arrive; i < Return; i = i.AddDays(1))
                        {
                            if (i.DayOfWeek == DayOfWeek.Saturday)
                                sum += 1200;
                            else
                                sum += 500;
                        }
                        Price.Text = sum.ToString();
                    }
                }
                else if (selectedText == "לירנובה")
                {
                    int sum = 0;

                    if (ArriveCalendar.SelectedDate is DateTime Arrive && ReturnCalendar.SelectedDate is DateTime Return && Return > Arrive)
                    {
                        NightAmount.Text = (Return - Arrive).Days.ToString();
                        for (DateTime i = Arrive; i < Return; i = i.AddDays(1))
                        {
                            if (i.DayOfWeek == DayOfWeek.Saturday)
                                sum += 1000;
                            else
                                sum += 400;
                        }
                        Price.Text = sum.ToString();
                    }
                }
                else if (selectedText == "לירן ויסטה")
                {
                    int sum = 0;

                    if (ArriveCalendar.SelectedDate is DateTime Arrive && ReturnCalendar.SelectedDate is DateTime Return && Return > Arrive)
                    {
                        NightAmount.Text = (Return - Arrive).Days.ToString();
                        for (DateTime i = Arrive; i < Return; i = i.AddDays(1))
                        {
                            if (i.DayOfWeek == DayOfWeek.Saturday)
                                sum += 1400;
                            else
                                sum += 600;
                        }
                        Price.Text = sum.ToString();
                    }
                }
            }
        }
        

        private void MyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MyComboBox.SelectedItem is ComboBoxItem SelectedItem)
            {
                string selectedText = SelectedItem.Content.ToString();
                if (selectedText == "לירן רויאל")
                {
                    int sum = 0;
                    if (ArriveCalendar.SelectedDate is DateTime Arrive && ReturnCalendar.SelectedDate is DateTime Return && Return > Arrive)
                    {
                        NightAmount.Text = (Return - Arrive).Days.ToString();
                        for (DateTime i = Arrive; i < Return; i = i.AddDays(1))
                        {
                            if (i.DayOfWeek == DayOfWeek.Saturday)
                                sum += 1200;
                            else
                                sum += 500;
                        }
                        Price.Text = sum.ToString();
                    }
                }
                else if (selectedText == "לירנובה")
                {
                    int sum = 0;
                    if (ArriveCalendar.SelectedDate is DateTime Arrive && ReturnCalendar.SelectedDate is DateTime Return && Return > Arrive)
                    {
                        NightAmount.Text = (Return - Arrive).Days.ToString();
                        for (DateTime i = Arrive; i < Return; i = i.AddDays(1))
                        {
                            if (i.DayOfWeek == DayOfWeek.Saturday)
                                sum += 1000;
                            else
                                sum += 400;
                        }
                        Price.Text = sum.ToString();
                    }
                }
                else if (selectedText == "לירן ויסטה")
                {
                    int sum = 0;
                    if (ArriveCalendar.SelectedDate is DateTime Arrive && ReturnCalendar.SelectedDate is DateTime Return && Return > Arrive)
                    {
                        NightAmount.Text = (Return - Arrive).Days.ToString();
                        for (DateTime i = Arrive; i < Return; i = i.AddDays(1))
                        {
                            if (i.DayOfWeek == DayOfWeek.Saturday)
                                sum += 1400;
                            else
                                sum += 600;
                        }
                        Price.Text = sum.ToString();
                    }
                }
            }
        }

        private void SinlgeChoose(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("שתי בקבוקי מים, שתי שוקולדים קטנים, מגבות מסודרות בצורה יפה, מוצרי רחצה בסיסיים");
        }

        private void DoubleChoose(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("כל הפינוקים של חדר יחיד, צלחת פירות קטנה, עוגיות איכותיות, קפה ותה משודרגים");
        }

        private void TripleChoose(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("כל הפינוקים של חדר זוגי, מגש פירות עשיר, פרלינים איכותיים, חלוקים ונעלי בית, משקה חגיגי ללא אלכוהול");
        }

        private void QuadChoose(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("כל הפינוקים של חדר לשלושה, תותים מצופים בשוקולד, קינוח אישי של השף, מארז מתנה יוקרתי, ברכה אישית לאורחים, הפתעה מיוחדת בהתאם לאירוע");
        }
    }
}
