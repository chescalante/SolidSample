using System;
using System.IO;

namespace SolidSample._1_S
{
    public class BillingProcessorRight
    {
        private readonly ILogger _logger;

        public BillingProcessorRight(ILogger logger)
        {
            this._logger = logger;
        }

        public void CreateInvoice()
        {
            try
            {
                // steps to create the invoice
                _logger.LogInfo("The invoice is created successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex);
            }
        }
    }

    public interface ILogger
    {
        void LogInfo(string content);
        void LogError(Exception content);
    }
}
