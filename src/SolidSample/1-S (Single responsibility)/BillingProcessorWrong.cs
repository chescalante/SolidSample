using System;
using System.IO;

namespace SolidSample._1_S
{
    public class BillingProcessorWrong
    {
        public void CreateInvoice()
        {
            try
            {
                // steps to create the invoice
                File.AppendAllText($"_logInfo-{DateTime.Now.ToString("yyyy-MM-dd")}.txt", "The invoice is created successfully.");
            }
            catch (Exception ex)
            {
                File.AppendAllText($"_logError-{DateTime.Now.ToString("yyyy-MM-dd")}.txt", ex.Message);
            }
        }
    }
}
