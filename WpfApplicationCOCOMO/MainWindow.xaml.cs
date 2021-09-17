using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApplicationCOCOMO
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void GetResult(object sender, RoutedEventArgs e)
        {
            double[] _typeOfCalculate;
            double _resultLabor, _resultTime, _resultChel;

            switch (CmBoxText.Text)
            {
                case "Розповсюджений":
                    _typeOfCalculate = new double[] { 2.4, 1.05, 2.5, 0.38 };
                    UserStatusNotification();

                    //Трудоємність
                    _resultLabor = Calculate.GetLabor(_typeOfCalculate, Double.Parse(CodeSize.Text));
                    Labor.Text = _resultLabor.ToString();

                    //Тривалість
                    _resultTime = Calculate.GetTime(_typeOfCalculate, Double.Parse(CodeSize.Text));
                    Time.Text = _resultTime.ToString();

                    //Розробники
                    _resultChel = Calculate.GetChel(_typeOfCalculate, Double.Parse(CodeSize.Text));
                    Chel.Text = _resultChel.ToString();
                    GoodStickerThird.Visibility = Visibility;
                    break;

                case "Напівнезалежний":
                    _typeOfCalculate = new double[] { 3.0, 1.12, 2.5, 0.35 };
                    UserStatusNotification();

                    //Трудоємність
                    _resultLabor = Calculate.GetLabor(_typeOfCalculate, Double.Parse(CodeSize.Text));
                    Labor.Text = _resultLabor.ToString();

                    //Тривалість
                    _resultTime = Calculate.GetTime(_typeOfCalculate, Double.Parse(CodeSize.Text));
                    Time.Text = _resultTime.ToString();

                    //Розробники
                    _resultChel = Calculate.GetChel(_typeOfCalculate, Double.Parse(CodeSize.Text));
                    Chel.Text = _resultChel.ToString();
                    GoodStickerSecond.Visibility = Visibility;
                    break;

                case "Вбудований":
                    _typeOfCalculate = new double[] { 3.6, 1.20, 2.5, 0.32 };
                    UserStatusNotification();

                    //Трудоємність
                    _resultLabor = Calculate.GetLabor(_typeOfCalculate, Double.Parse(CodeSize.Text));
                    Labor.Text = _resultLabor.ToString();

                    //Тривалість
                    _resultTime = Calculate.GetTime(_typeOfCalculate, Double.Parse(CodeSize.Text));
                    Time.Text = _resultTime.ToString();

                    //Розробники
                    _resultChel = Calculate.GetChel(_typeOfCalculate, Double.Parse(CodeSize.Text));
                    Chel.Text = _resultChel.ToString();
                    GoodSticker.Visibility = Visibility;
                    break;

                default:
                    ErrorSticker.Visibility = Visibility;
                    ErrorMessage.Visibility = Visibility;
                    break;
            }
        }

        //Повідомлення користувача про помилку або вдале виконання
        public void UserStatusNotification()
        {
            GoodSticker.Visibility = Visibility.Hidden;
            GoodStickerSecond.Visibility = Visibility.Hidden;
            GoodStickerThird.Visibility = Visibility.Hidden;
            ErrorSticker.Visibility = Visibility.Hidden;
            ErrorMessage.Visibility = Visibility.Hidden;
        }
    }
}
