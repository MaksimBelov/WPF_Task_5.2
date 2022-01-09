using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WPF_Task_5._2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            statusBarItemName1.Text = "Draw";
            statusBarItemName2.Text = "Black";
            statusBarItemName3.Text = "Thinnest";
        }

        private void ButtonDraw_Click(object sender, RoutedEventArgs e) // Выбор режима Ink
        {
            inkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            statusBarItemName1.Text = "Draw";
        }

        private void ButtonErase_Click(object sender, RoutedEventArgs e) // Выбор режима EraseByPoint
        {
            inkCanvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
            statusBarItemName1.Text = "Erase by point";
        }

        private void ButtonErase1_Click(object sender, RoutedEventArgs e) // Выбор режима EraseByStroke
        {
            inkCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
            statusBarItemName1.Text = "Erase by stroke";
        }

        private void ButtonClearPen_Click(object sender, RoutedEventArgs e) // Удаление всех линий
        {
            inkCanvas.Strokes.Clear();
        }

        private void ButtonClearBackground_Click(object sender, RoutedEventArgs e) // Удаление заливки фона
        {
            inkCanvas.Background = Brushes.White;
        }

        private void ButtonClearImageBackground_Click(object sender, RoutedEventArgs e) // Удаление фонового изображения 
        {
            img.Source = null;
        }

        private void ButtonBackgroundBlack_Click(object sender, RoutedEventArgs e) // Установка черной заливки фона
        {
            inkCanvas.Background = Brushes.Black;
        }

        private void ButtonBackgroundRed_Click(object sender, RoutedEventArgs e) // Установка красной заливки фона
        {
            inkCanvas.Background = Brushes.Red;
        }

        private void ButtonBackgroundGreen_Click(object sender, RoutedEventArgs e) // Установка зеленой заливки фона
        {
            inkCanvas.Background = Brushes.Green;
        }

        private void ButtonBackgroundBlue_Click(object sender, RoutedEventArgs e) // Установка синей заливки фона
        {
            inkCanvas.Background = Brushes.Blue;
        }

        private void ButtonBackgroundAqua_Click(object sender, RoutedEventArgs e) // Установка голубой заливки фона
        {
            inkCanvas.Background = Brushes.Aqua;
        }

        private void ButtonBackgroundOrange_Click(object sender, RoutedEventArgs e) // Установка оранжевой заливки фона
        {
            inkCanvas.Background = Brushes.Orange;
        }

        private void ButtonBackgroundYellow_Click(object sender, RoutedEventArgs e) // Установка желтой заливки фона
        {
            inkCanvas.Background = Brushes.Yellow;
        }

        private void ButtonBackgroundPurple_Click(object sender, RoutedEventArgs e) // Установка фиолетовой заливки фона
        {
            inkCanvas.Background = Brushes.Purple;
        }

        private void ButtonDefaultPen_Click(object sender, RoutedEventArgs e) // Установка черного цвета пера
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Black;
            statusBarItemName2.Text = "Black";
        }

        private void ButtonPenWhite_Click(object sender, RoutedEventArgs e) // Установка белого цвета пера
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.White;
            statusBarItemName2.Text = "White";
        }

        private void ButtonPenRed_Click(object sender, RoutedEventArgs e) // Установка красного цвета пера
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Red;
            statusBarItemName2.Text = "Red";
        }

        private void ButtonPenGreen_Click(object sender, RoutedEventArgs e) // Установка зеленого цвета пера
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Green;
            statusBarItemName2.Text = "Green";
        }

        private void ButtonPenBlue_Click(object sender, RoutedEventArgs e) // Установка синего цвета пера
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Blue;
            statusBarItemName2.Text = "Blue";
        }

        private void ButtonPenAqua_Click(object sender, RoutedEventArgs e) // Установка голубого цвета пера
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Aqua;
            statusBarItemName2.Text = "Aqua";
        }

        private void ButtonPenOrange_Click(object sender, RoutedEventArgs e) // Установка оранжевого цвета пера
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Orange;
            statusBarItemName2.Text = "Orange";
        }

        private void ButtonPenYellow_Click(object sender, RoutedEventArgs e) // Установка желтого цвета пера
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Yellow;
            statusBarItemName2.Text = "Yellow";
        }

        private void ButtonPenPurple_Click(object sender, RoutedEventArgs e) // Установка фиолетового цвета пера
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Purple;
            statusBarItemName2.Text = "Purple";
        }

        private void PenThicness_SelectionChanged(object sender, SelectionChangedEventArgs e) // Выбор толщины линии в ComboBox
        {
            if (inkCanvas != null)
            {
                switch (PenThicness.SelectedIndex)
                {
                    case 0:
                        {
                            inkCanvas.DefaultDrawingAttributes.Width = 1;
                            inkCanvas.DefaultDrawingAttributes.Height = 1;
                            statusBarItemName3.Text = "Thinnest";
                            break;
                        }
                    case 1:
                        {
                            inkCanvas.DefaultDrawingAttributes.Width = 5;
                            inkCanvas.DefaultDrawingAttributes.Height = 5;
                            statusBarItemName3.Text = "Thin";
                            break;
                        }
                    case 2:
                        {
                            inkCanvas.DefaultDrawingAttributes.Width = 10;
                            inkCanvas.DefaultDrawingAttributes.Height = 10;
                            statusBarItemName3.Text = "Thick";
                            break;
                        }
                    case 3:
                        {
                            inkCanvas.DefaultDrawingAttributes.Width = 15;
                            inkCanvas.DefaultDrawingAttributes.Height = 15;
                            statusBarItemName3.Text = "Thickest";
                            break;
                        }
                }
            }
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e) // Выбор толщины линии Thinnest  в меню
        {
            inkCanvas.DefaultDrawingAttributes.Width = 2;
            inkCanvas.DefaultDrawingAttributes.Height = 2;
            statusBarItemName3.Text = "Thinnest";

        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e) // Выбор толщины линии Thin в меню
        {
            inkCanvas.DefaultDrawingAttributes.Width = 5;
            inkCanvas.DefaultDrawingAttributes.Height = 5;
            statusBarItemName3.Text = "Thin";

        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e) // Выбор толщины линии Thick  в меню
        {
            inkCanvas.DefaultDrawingAttributes.Width = 10;
            inkCanvas.DefaultDrawingAttributes.Height = 10;
            statusBarItemName3.Text = "Thick";

        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e) // Выбор толщины линии Thickest в меню
        {
            inkCanvas.DefaultDrawingAttributes.Width = 15;
            inkCanvas.DefaultDrawingAttributes.Height = 15;
            statusBarItemName3.Text = "Thickest";

        }

        private void ButtonCopy_Click(object sender, RoutedEventArgs e) // Копирование выбранных strokes в буфер
        {
            inkCanvas.CopySelection();
        }

        private void ButtonCut_Click(object sender, RoutedEventArgs e) // Вырезать выбранные strokes
        {
            inkCanvas.CutSelection();
        }

        private void ButtonPaste_Click(object sender, RoutedEventArgs e) // Вставка strokes из буфера
        {
            inkCanvas.EditingMode = InkCanvasEditingMode.Select;
            inkCanvas.Paste();
        }

        private void ButtonSelect_Click(object sender, RoutedEventArgs e) // Выбор stroke
        {
            inkCanvas.EditingMode = InkCanvasEditingMode.Select;
        }

        private void ButtonSelectAll_Click(object sender, RoutedEventArgs e) // Выбрать все strokes
        {
            inkCanvas.Select(inkCanvas.Strokes);
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e) // Пункт меню Create new
        {
            if (inkCanvas.Strokes.Count != 0 || img.Source != null || inkCanvas.Background != Brushes.White)
            {
                MessageBoxResult result = MessageBox.Show("Сохранить изменения?", "Выход", MessageBoxButton.YesNoCancel);
                if (result == MessageBoxResult.Yes)
                {
                    SaveToFile();
                    inkCanvas.Strokes.Clear();
                    inkCanvas.Background = Brushes.White;
                    img.Source = null;
                }
                else if (result == MessageBoxResult.No)
                {
                    inkCanvas.Strokes.Clear();
                    inkCanvas.Background = Brushes.White;
                    img.Source = null;
                }
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e) // Пункт меню Open
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All supported graphics|*.bmp;*.jpg;*.jpeg;*.png|" + "BMP (*.bmp)|*.bmp|" + "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" + "PNG (*.png)|*.png|" + "All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                img.Source = new BitmapImage(fileUri);
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e) // Пункт меню Save
        {
            SaveToFile();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e) // Пункт меню Close
        {
            Application.Current.MainWindow.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e) //Закрытие MainWindow
        {
            if (inkCanvas.Strokes.Count != 0 || img.Source != null || inkCanvas.Background != Brushes.White)
            {
                MessageBoxResult result = MessageBox.Show("Сохранить изменения?", "Выход", MessageBoxButton.YesNoCancel);
                if (result == MessageBoxResult.Yes)
                {
                    SaveToFile();
                    e.Cancel = false;
                }
                else if (result == MessageBoxResult.No)
                {
                    e.Cancel = false;
                }
                else if (result == MessageBoxResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void SaveToFile() // Метод для сохранения в файл
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "BMP (*.bmp)|*.bmp|JPEG (*.jpg; *.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png";
            saveFileDialog.FileName = "My Image";
            saveFileDialog.DefaultExt = ".bmp";

            if (saveFileDialog.ShowDialog() == true)
            {
                string filename = saveFileDialog.FileName;
                int width = (int)inkCanvas.ActualWidth;
                int height = (int)inkCanvas.ActualHeight;

                var pSource = PresentationSource.FromVisual(Application.Current.MainWindow);
                Matrix m = pSource.CompositionTarget.TransformToDevice;
                double dpiX = m.M11 * 96;
                double dpiY = m.M22 * 96;

                var elementBitmap = new RenderTargetBitmap(width, height, dpiX, dpiY, PixelFormats.Default);

                var drawingVisual = new DrawingVisual();
                using (DrawingContext drawingContext = drawingVisual.RenderOpen())
                {
                    var visualBrush = new VisualBrush(inkCanvas);
                    drawingContext.DrawRectangle(
                        visualBrush,
                        null,
                        new Rect(new Point(0, 0), new Size(width / m.M11, height / m.M22)));
                }

                elementBitmap.Render(drawingVisual);

                try
                {
                    var encoder = new PngBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(elementBitmap));

                    using (var imageFile = new FileStream(filename, FileMode.Create, FileAccess.Write))
                    {
                        encoder.Save(imageFile);
                        imageFile.Flush();
                        imageFile.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " Задайте другое имя файла");
                    SaveToFile();
                }
            }

            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "BMP (*.bmp)|*.bmp|JPEG (*.jpg; *.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png";
            //saveFileDialog.FileName = "My Image";
            //saveFileDialog.DefaultExt = ".bmp";

            //if (saveFileDialog.ShowDialog() == true)
            //{
            //    string filename = saveFileDialog.FileName;
            //    int width = (int)inkCanvas.ActualWidth;
            //    int height = (int)inkCanvas.ActualHeight;

            //    RenderTargetBitmap rtb = new RenderTargetBitmap(width, height, 96d, 96d, PixelFormats.Default);

            //    inkCanvas.Measure(new Size(width, height));
            //    inkCanvas.Arrange(new Rect(new Size(width, height))); // При использовании этого кода может пропадать Toolbar. Если, например, в inkCanvas отсутствуют Strokes

            //    rtb.Render(inkCanvas);

            //    try
            //    {
            //        FileStream fs = new FileStream(filename, FileMode.Create);
            //        BmpBitmapEncoder encoder = new BmpBitmapEncoder();
            //        encoder.Frames.Add(BitmapFrame.Create(rtb));
            //        encoder.Save(fs);
            //        fs.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message + " Задайте другое имя файла");
            //    }
            //}
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e) // Пункт меню Help
        {
            MessageBox.Show("Graphic Editor. Version 1.01");
        }

        private void inkCanvas_MouseMove(object sender, MouseEventArgs e) // Отслеживает координаты пера для Statusbar
        {
            statusBarItemName4.Text = "X = " + e.GetPosition(null).X + " Y = " + (e.GetPosition(null).Y - 135);
        }
    }
}
