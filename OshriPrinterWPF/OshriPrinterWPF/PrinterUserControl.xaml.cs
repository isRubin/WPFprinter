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

namespace OshriPrinterWPF
{
    /// <summary>
    /// Interaction logic for PrinterUserControl.xaml
    /// </summary>
    public partial class PrinterUserControl : UserControl
    {
        string printerName; //  שם המדפסת
        int inkCount;   //   כמות הדיו 
        int pageCount;    //    כמות הדפים

        static int printeNum = 1;
        const int MAX_INK = 100;                     //  כמות הדיו המקסימאלית
        const int MIN_ADD_INK = MAX_INK / 10;  //  כמות הדיו המינימאלית להוספה
        const int MAX_PRINT_INK = MAX_INK;         //    כמות הדיו המקסימאלית להדפסה
        const int MAX_PAGES = 400;                //   כמות הדפים המקסימאלית  
        const int MIN_ADD_PAGES = MAX_PAGES / 10;//     כמות הדפים המינימאלית להוספה
        const int MAX_PRINT_PAGES = MAX_PAGES;  //     כמות הדפים המקסימאלית להוספה

        event EventHandler<PrinterEventArgs> PageMissing;
        event EventHandler<PrinterEventArgs> InkEmpty;

        PrinterUserControl(string name) //ctor .פונקציה בונה שמאתחלת את שם המדפסת |+ מספר רץ 
        {
            printerName = name + (printeNum++);
        }
        public bool print()
        {
            Random r = new Random();
            if (PageCount > 0 && InkCount > 0)
            {
                PageCount -= r.Next(1, 1 + PageCount);
                InkCount -= r.Next(1, 1 + InkCount);
                this.pageCountSlider.Value = PageCount;
                this.inkCountProgressBar.Value = InkCount;
                return true;
            }
            return false;
        }
        public bool addPages()
        {
            Random r = new Random();
            if (PageCount < 400)
            {
                PageCount += r.Next(1, 1 + (MAX_PRINT_PAGES - PageCount));
                this.pageCountSlider.Value = PageCount;
                return true;
            }
            return false;
        }
        public bool addInk()
        {
            Random r = new Random();
            if (InkCount < MAX_INK)
            {
                InkCount += r.Next(1, 1 + (MAX_INK - InkCount));
                this.inkCountProgressBar.Value = InkCount;
                return true;
            }
            return false;
        }
        public string PrinterName
        {
            get => printerName; set => printerName = value;
        }
        public int InkCount     //property for InkCount ברגע שאנחנו משנים את המאפיין כך גם תשתנה בהתאם התצוגה ברכיב הגראפי 
        {
            get => inkCount;
            set
            {
                inkCount = value;
                this.inkCountProgressBar.Value = value;
            }
        }
        public int PageCount
        {
            get => pageCount; set => pageCount = value;
        }
        public PrinterUserControl()
        {
            InitializeComponent();
        }
        private void FontIncrease(object sender, MouseEventArgs e) // הגדלת הפונט כשמצביע העכבר
        {
            this.printerNameLabel.FontSize *= 1.5;
        }
        private void FontDecrease(object sender, MouseEventArgs e) // הקטנת הפונט
        {
            this.printerNameLabel.FontSize /= 1.5;
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            print();
        }
    }

}
