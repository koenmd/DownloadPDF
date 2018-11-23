
using DownloadPDF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DownloadPDF.Controllers
{
    /// <summary>
    /// Class to generate pdf
    /// </summary>
    public class HomeController : Controller
    {
        //
        // GET: /Download/

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Action Method using viewAsPdf class to create view as pdf
        /// </summary>
        /// <returns></returns>
        public ActionResult DownloadPDF()
        {
            try
            {
                var model = new GeneratePDFModel();

                //get the information to display in pdf from database
                //for the time
                //Hard coding values are here, these are the content to display in pdf 
                var content = "<h2>WOW Rotativa<h2>" +
                 "<p>Ohh This is very easy to generate pdf using Rotativa <p>";
                var logoFile = @"/Images/logo.png";

                model.PDFContent = content;
                model.PDFLogo = Server.MapPath(logoFile);

                //Use ViewAsPdf Class to generate pdf using GeneratePDF.cshtml view
                return new Rotativa.ViewAsPdf("GeneratePDF", model) { FileName = "firstPdf.pdf" };
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        /// <summaroy>
        /// This method is using ActionAsPdf class to generate pdf
        /// </summary>
        /// <returns></returns>
        public ActionResult DownloadActionAsPDF()
        {
            try
            {
                //will take ActionMethod and generate the pdf
                return new Rotativa.ActionAsPdf("GeneratePDF") { FileName = "TestPDF.pdf", PageOrientation = Rotativa.Options.Orientation.Landscape, PageSize = Rotativa.Options.Size.A4, IsJavaScriptDisabled=true, CustomSwitches= "--enable-smart-shrinking" } ;
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        /// <summaroy>
        /// This method is using ActionAsPdf class to generate pdf
        /// </summary>
        /// <returns></returns>
        public ActionResult DownloadActionAsPDFMonth()
        {
            try
            {
                //will take ActionMethod and generate the pdf
                return new Rotativa.ActionAsPdf("GeneratePDFOneMonth") { FileName = "TestPDF.pdf", PageOrientation = Rotativa.Options.Orientation.Landscape, PageSize = Rotativa.Options.Size.A4, IsJavaScriptDisabled = true, CustomSwitches = "--enable-smart-shrinking" };
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        /// <summary>
        /// Action method to return view as pdf
        /// </summary>
        /// <returns></returns>
        public ActionResult GeneratePDF()
        {
            try
            {
                var model = new GeneratePDFModel();
                //Your data from db

                //hard coded value for test purpose
                var content = "<h2>PDF Created<h2>" +
                "<p>Ohh This is very easy to generate pdf using Rotativa<p>";
                var logoFile = @"/Images/logo.png";

                content = PDFTestData.OneWeek;

                model.PDFContent = content;
                model.PDFLogo = Server.MapPath(logoFile);

                return View(model);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Action method to return view as pdf
        /// </summary>
        /// <returns></returns>
        public ActionResult GeneratePDFOneMonth()
        {
            try
            {
                var model = new GeneratePDFModel();
                //Your data from db

                //hard coded value for test purpose
                var content = "<h2>PDF Created<h2>" +
                "<p>Ohh This is very easy to generate pdf using Rotativa<p>";
                var logoFile = @"/Images/logo.png";

                content = PDFTestData.OneMonth;

                model.PDFContent = content;
                model.PDFLogo = Server.MapPath(logoFile);

                return View(model);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// using partial view for pdf generation
        /// </summary>
        /// <returns></returns>
        public ActionResult DownloadPartialViewPDF()
        {
            var model = new GeneratePDFModel();

            //hard coded value for test purpose
            var content = "<h2>PDF Created<h2>" +
            "<p>Ohh This is very easy to generate pdf using Rotativa<p>";
            var logoFile = @"/Images/logo.png";

            model.PDFContent = content;
            model.PDFLogo = Server.MapPath(logoFile);

            return new Rotativa.PartialViewAsPdf("_PartialViewTest", model){FileName ="partialViewAsPdf.pdf"};
        }

        /// <summary>
        /// The method will geneate ulr content in pdf doc
        /// </summary>
        /// <returns></returns>
        public ActionResult UrlAsPDF()
        {

            //this will generate google home page to in a pdf doc
            return new Rotativa.UrlAsPdf("http://www.Google.com")
            {
                FileName = "urltest.pdf",
            };
        }
    }
}
