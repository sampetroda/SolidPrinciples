using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * No Client should be forced to depend on methods it does  
 * One fat interface need to be split to  many smaller and relevant interfaces 
   so that clients can know about the interfaces that are relevant to them
 * The ISP was first used and formulated by Rober C.Martin wle consulting Xerox.
 * 
 * 
 *  * Xerox had created a new printer system that could perform a variety of tasks 
  such as stapling and faxing along with the regular printing task.
 * the software for this system was created from the ground up
 * modification and deployment to the system became more complex.
 * One large Job class is segregated to multiple interfaces depending on the requirement.
 */



namespace Interview
{
    public class HPScan : IPrintScanContent
    {
        public bool ColorPrintContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool PrintContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool PrintScan(string content)
        {
            throw new NotImplementedException();
        }
    }
    public class CanonPrinter : IPrintScanContent,IColorPrint
    {
        public bool ColorPrint(string content)
        {
            throw new NotImplementedException();
        }

        public bool PrintContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool PrintScan(string content)
        {
            throw new NotImplementedException();
        }
    }
    interface IPrintScanContent
    {
        bool PrintContent(string content);
        bool PrintScan(string content);

    }

    interface IColorPrint
        {
        bool ColorPrint(string content);
    }
}
