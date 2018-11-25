using System;
namespace OshriPrinterWPF
{
    class PrinterEventArgs
    {
        string printerName; //        .שם המדפסת
        DateTime curTime; //     תאריך-זמן שמציין את תאריך וזמן של השגיאה \ האזהרה
        string errorMessage; //    . מחרוזת שמתאר הודעת שגיאה \ אזהרה מהמדפסת
        bool isCritical = false; //  .בוליאני שמציין האם השגיאה \ אזהרה היא קריטית
        PrinterEventArgs  (string name, string message, bool flag)    //ctor 
        {
            printerName = name;
            curTime = DateTime.Now;
            errorMessage = message;
            isCritical = flag;
        }
        
        public DateTime CurTime {get => curTime;}
        public string ErrorMasage { get => errorMessage;}
        public string Preintername { get => printerName;}
    }

}
