using System;
using System.Collections.Generic;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Bold_Click(object sender, RoutedEventArgs e)
        {
            if(start.Text !="" || end.Text != "" && int.Parse(start.Text) < int.Parse(end.Text))
            {
                TextPointer p1 = parag.ContentStart.GetPositionAtOffset(int.Parse(start.Text));
                TextPointer p2 = parag.ContentEnd.GetPositionAtOffset(int.Parse(end.Text) - textRun.Text.Length - 1);
                text.Selection.Select(p1, p2);
                text.Selection.ApplyPropertyValue(RichTextBox.FontWeightProperty, "Bold");
            }
            //SetBold(text);
        }

        //public static void SetFontSize(RichTextBox target, double value)
        //{
        //    if (target == null)
        //        return;
        //    if (target.Selection != null)
        //    {
        //        if (target.Selection.IsEmpty)
        //        {
        //            if (target.Selection.Start.Paragraph == null)
        //            {
        //                Paragraph p = new Paragraph();
        //                p.FontSize = value;
        //                target.Document.Blocks.Add(p);
        //            }
        //            else
        //            {
        //                TextPointer curCaret = target.CaretPosition;
        //                Block curBlock = target.Document.Blocks.Where
        //                    (x => x.ContentStart.CompareTo(curCaret) == -1 && x.ContentEnd.CompareTo(curCaret) == 1).FirstOrDefault();
        //                if (curBlock != null)
        //                {
        //                    Paragraph curParagraph = curBlock as Paragraph;
        //                    Run newRun = new Run();
        //                    newRun.FontSize = value;
        //                    curParagraph.Inlines.Add(newRun);
        //                    target.CaretPosition = newRun.ElementStart;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            TextRange selectionTextRange = new TextRange(target.Selection.Start, target.Selection.End);
        //            selectionTextRange.ApplyPropertyValue(TextElement.FontSizeProperty, value);
        //        }
        //    }
        //    target.Focus();
        //}

        //public static void SetBold(RichTextBox target)
        //{
        //    if (target == null)
        //        return;
        //    if (target.Selection != null)
        //    {
        //        if (target.Selection.IsEmpty)
        //        {
        //            if (target.Selection.Start.Paragraph == null)
        //            {
        //                Paragraph p = new Paragraph();
        //                p.FontWeight = FontWeights.Bold;
        //                target.Document.Blocks.Add(p);
        //            }
        //            else
        //            {
        //                TextPointer curCaret = target.CaretPosition;
        //                Block curBlock = target.Document.Blocks.Where
        //                    (x => x.ContentStart.CompareTo(curCaret) == -1 && x.ContentEnd.CompareTo(curCaret) == 1).FirstOrDefault();
        //                if (curBlock != null)
        //                {
        //                    Paragraph curParagraph = curBlock as Paragraph;
        //                    Run newRun = new Run();
        //                    newRun.FontWeight = FontWeights.Bold;
        //                    curParagraph.Inlines.Add(newRun);
        //                    target.CaretPosition = newRun.ElementStart;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            TextRange selectionTextRange = new TextRange(target.Selection.Start, target.Selection.End);
        //            selectionTextRange.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);

        //        }
        //    }
        //    target.Focus();
        //}

        //public static void SetItalic(RichTextBox target)
        //{
        //    if (target == null)
        //        return;
        //    if (target.Selection != null)
        //    {
        //        if (target.Selection.IsEmpty)
        //        {
        //            if (target.Selection.Start.Paragraph == null)
        //            {
        //                Paragraph p = new Paragraph();
        //                p.FontStyle = FontStyles.Italic;
        //                target.Document.Blocks.Add(p);
        //            }
        //            else
        //            {
        //                TextPointer curCaret = target.CaretPosition;
        //                Block curBlock = target.Document.Blocks.Where
        //                    (x => x.ContentStart.CompareTo(curCaret) == -1 && x.ContentEnd.CompareTo(curCaret) == 1).FirstOrDefault();
        //                if (curBlock != null)
        //                {
        //                    Paragraph curParagraph = curBlock as Paragraph;
        //                    Run newRun = new Run();
        //                    newRun.FontStyle = FontStyles.Italic;
        //                    curParagraph.Inlines.Add(newRun);
        //                    target.CaretPosition = newRun.ElementStart;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            TextRange selectionTextRange = new TextRange(target.Selection.Start, target.Selection.End);
        //            selectionTextRange.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Italic);
        //        }
        //    }
        //    target.Focus();
        //}

        //public static void SetColor(RichTextBox target, Brush cl)
        //{
        //    if (target == null)
        //        return;
        //    if (target.Selection != null)
        //    {
        //        if (target.Selection.IsEmpty)
        //        {
        //            if (target.Selection.Start.Paragraph == null)
        //            {
        //                Paragraph p = new Paragraph();
        //                p.Background = cl;
        //                target.Document.Blocks.Add(p);
        //            }
        //            else
        //            {
        //                TextPointer curCaret = target.CaretPosition;
        //                Block curBlock = target.Document.Blocks.Where
        //                    (x => x.ContentStart.CompareTo(curCaret) == -1 && x.ContentEnd.CompareTo(curCaret) == 1).FirstOrDefault();
        //                if (curBlock != null)
        //                {
        //                    Paragraph curParagraph = curBlock as Paragraph;
        //                    Run newRun = new Run();
        //                    newRun.Background = cl;
        //                    curParagraph.Inlines.Add(newRun);
        //                    target.CaretPosition = newRun.ElementStart;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            TextRange selectionTextRange = new TextRange(target.Selection.Start, target.Selection.End);
        //            selectionTextRange.ApplyPropertyValue(TextElement.BackgroundProperty, cl);
        //        }
        //    }
        //    target.Focus();
        //}
        //public static void SetUnderline(RichTextBox target)
        //{
        //    if (target == null)
        //        return;
        //    if (target.Selection != null)
        //    {
        //        if (target.Selection.IsEmpty)
        //        {
        //            if (target.Selection.Start.Paragraph == null)
        //            {
        //                Paragraph p = new Paragraph();
        //                p.TextDecorations = TextDecorations.Underline;
        //                target.Document.Blocks.Add(p);
        //            }
        //            else
        //            {
        //                TextPointer curCaret = target.CaretPosition;
        //                Block curBlock = target.Document.Blocks.Where
        //                    (x => x.ContentStart.CompareTo(curCaret) == -1 && x.ContentEnd.CompareTo(curCaret) == 1).FirstOrDefault();
        //                if (curBlock != null)
        //                {
        //                    Paragraph curParagraph = curBlock as Paragraph;
        //                    Run newRun = new Run();
        //                    newRun.TextDecorations = TextDecorations.Underline;
        //                    curParagraph.Inlines.Add(newRun);
        //                    target.CaretPosition = newRun.ElementStart;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            TextRange selectionTextRange = new TextRange(target.Selection.Start, target.Selection.End);
        //            selectionTextRange.ApplyPropertyValue(TextElement.TextEffectsProperty, TextDecorations.Underline);
        //        }
        //    }
        //    target.Focus();
        //}

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //SetFontSize(text, double.Parse(selectedItem.Content.ToString()));
            if (start.Text != "" || end.Text != "" && int.Parse(start.Text) < int.Parse(end.Text))
            {
                ComboBox comboBox = (ComboBox)sender;
                ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
                TextPointer p1 = parag.ContentStart.GetPositionAtOffset(int.Parse(start.Text));
                TextPointer p2 = parag.ContentEnd.GetPositionAtOffset(int.Parse(end.Text) - textRun.Text.Length - 1);
                text.Selection.Select(p1, p2);
                text.Selection.ApplyPropertyValue(Run.FontSizeProperty, double.Parse(selectedItem.Content.ToString()));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //SetItalic(text);
            if (start.Text != "" || end.Text != "" && int.Parse(start.Text) < int.Parse(end.Text))
            {
                TextPointer p1 = parag.ContentStart.GetPositionAtOffset(int.Parse(start.Text));
                TextPointer p2 = parag.ContentEnd.GetPositionAtOffset(int.Parse(end.Text) - textRun.Text.Length - 1);
                text.Selection.Select(p1, p2);
                text.Selection.ApplyPropertyValue(RichTextBox.FontStyleProperty, "Italic");
            }
        }

        private void Combo_box_color_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Brush br = Brushes.Black;
            //ComboBox comboBox = (ComboBox)sender;
            //ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            //SetColor(text, selectedItem.Background);

            //if (start.Text != "" || end.Text != "" && int.Parse(start.Text) < int.Parse(end.Text))
            //{
            //    ComboBox comboBox = (ComboBox)sender;
            //    ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            //    TextPointer p1 = parag.ContentStart.GetPositionAtOffset(int.Parse(start.Text));
            //    TextPointer p2 = parag.ContentEnd.GetPositionAtOffset(int.Parse(end.Text) - textRun.Text.Length - 1);
            //    text.Selection.Select(p1, p2);
            //    text.Selection.ApplyPropertyValue(RichTextBox.FontFamilyProperty, double.Parse(selectedItem.Content.ToString()));
            //}
        }

        private void under_line_Click(object sender, RoutedEventArgs e)
        {
            if (start.Text != "" || end.Text != "" && int.Parse(start.Text) < int.Parse(end.Text))
            {
                TextPointer p1 = parag.ContentStart.GetPositionAtOffset(int.Parse(start.Text));
                TextPointer p2 = parag.ContentEnd.GetPositionAtOffset(int.Parse(end.Text) - textRun.Text.Length - 1);
                text.Selection.Select(p1, p2);
                text.Selection.ApplyPropertyValue(Run.TextDecorationsProperty, "Underline");
            }
        }
    }
}
