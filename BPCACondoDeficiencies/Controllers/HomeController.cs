using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BPCACondoDeficiencies.Models;
using Newtonsoft.Json;
using System.Net.Mail;
using System.IO;
using OfficeOpenXml;

namespace BPCACondoDeficiencies.Controllers
{
    public class HomeController : Controller
    {
        #region IActionResult/ActionResult Methods

        public IActionResult Home()
        {
            return View("Home");
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
        public IActionResult AddEditInvoice()
        {
            return View();
        }

        public IActionResult AddEditAgency()
        {
            return View();
        }

        public IActionResult AddEditUnit()
        {
            return View();
        }

        public IActionResult SearchUnitOwner()
        {
            return View();
        }

        public IActionResult UserManagement()
        {
            return View();
        }

        public IActionResult UserPasswordManagement()
        {
            return View("UserPasswordManagement");
        }
        public IActionResult AddEditSuspendedDefaults()
        {
            return View();
        }
        public IActionResult WorksheetHistory()
        {
            return View();
        }
        public IActionResult UnitInquiry()
        {
            return View();
        }
        public IActionResult Login()
        {
            ViewData["Message"] = "Login.";
            DataAccess.DataAccess.Initialize();
            return View();
        }
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("Login?sta=unf");
        }
        [HttpPost, HttpGet]
        public ActionResult DoLogin(string userName, string pwd, string agencyCode)
        {
            DataTable dt = DataAccess.DataAccess.ExecuteDataTable("UserLogin", "@username", userName, "@pwd", pwd, "@agencycode", agencyCode);
            if (dt.Rows.Count == 0)
            {
                return Redirect("Login?sta=unf");
            }
            else
            {
                SetLoginSessionVariables(dt);

                if (int.Parse(dt.Rows[0]["pwdDays"].ToString()) > 60)
                {
                    return RedirectToAction("UserPasswordManagement");
                }
                
                return RedirectToAction("Home");
            }
        }
        [HttpGet]
        public int CheckSession()
        {
            if(string.IsNullOrEmpty(GetSessionVariable("UserAgencyCode")))
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        [HttpGet]
        public string CheckAdmin()
        {
            return GetSessionVariable("UserAgencyCode");
        }
        private void SetLoginSessionVariables(DataTable dt)
        {
            string str = dt.Rows[0]["DisplayName"].ToString();
            HttpContext.Session.Set("UserDisplayName", Encoding.ASCII.GetBytes(str));

            str = dt.Rows[0]["userGuid"].ToString();
            HttpContext.Session.Set("UserGuid", Encoding.ASCII.GetBytes(str));

            str = dt.Rows[0]["agencyCode"].ToString();
            HttpContext.Session.Set("UserAgencyCode", Encoding.ASCII.GetBytes(str));

            str = dt.Rows[0]["agencyGuid"].ToString();
            HttpContext.Session.Set("UserAgencyGuid", Encoding.ASCII.GetBytes(str));
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Reports()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost, HttpGet]
        public ActionResult BuildingListing()
        {
            ViewData["AgencyList"] = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(GetAgencyList(), "AgencyGuid", "AgencyName");
            return View();
        }

        #endregion

        #region Utility Methods
        [HttpGet]
        //public ActionResult Logout()
        //{
        //    HttpContext.Session.Clear();
        //    return RedirectToAction("Home", "Login");
        //}

        public string GetSessionVariable(string variableName)
        {
            if (string.IsNullOrEmpty(variableName)) { return string.Empty; }
            byte[] retVal;

            if (HttpContext.Session.TryGetValue(variableName, out retVal))
            {
                return Encoding.ASCII.GetString(retVal).Trim();
            }
            return string.Empty;
        }

        public Guid GetUserGuid()
        {
            return new Guid(GetSessionVariable("UserGuid"));
        }

        public string GetUserAgencyCode()
        {
            return GetSessionVariable("UserAgencyCode");
        }
        [HttpPost]
        public void EmailError()
        {
            MailMessage mail = new MailMessage("error@condodeficiencies.com", "wreyes1028@gmail.com");
            //SmtpClient client = new SmtpClient();
            //client.Credentials = new System.Net.NetworkCredential("error@condodeficiencies.com", "s!9Q39D");
            //client.Port = 25;
            //client.DeliveryMethod = SmtpDeliveryMethod.Network;
            //client.UseDefaultCredentials = false;
            //client.Host = "mail.condofeficiencies.com";
            //mail.Subject = "this is a test email.";
            //mail.Body = "this is my test email body";
            //client.Send(mail);
        }
        #endregion

        #region Agency Methods
        private List<AgencyListItem> GetAgencyList()
        {

            DataTable dt = DataAccess.DataAccess.ExecuteDataTable("GetAgencyList");
            List<AgencyListItem> l = new List<AgencyListItem>();
            foreach (DataRow dr in dt.Rows)
            {
                AgencyListItem ali = new AgencyListItem
                    (
                    new Guid(dr["agencyGuid"].ToString()),
                    dr["agencyName"].ToString()
                    );

                l.Add(ali);
            }

            return l;
        }

        [HttpGet]
        public JsonResult GetAgencies()
        {
            return AgencyModel.GetAgencies();
        }

        [HttpPost]
        public void UpdateAgency(Guid agencyGuid, string agencyCode, string agencyName, string address1,
           string address2, string city, string state, string zip, string contact, string phone, string fax)
        {
            AgencyModel.UpdateAgency(agencyGuid, agencyCode, agencyName, address1, address2, city, state, zip, contact, phone, fax);
        }

        [HttpPost]
        public void InsertAgency(string agencyCode, string agencyName, string address1,
           string address2, string city, string state, string zip, string contact, string phone, string fax)
        {
            AgencyModel.InsertAgency(agencyCode, agencyName, address1, address2, city, state, zip, contact, phone, fax);
        }

        [HttpPost]
        public void DeleteAgency(Guid agencyGuid)
        {
            AgencyModel.DeleteAgency(agencyGuid);
        }
        #endregion

        #region BPCA Message Methods
        [HttpGet, ActionName("GetBPCAMessages")]
        public JsonResult GetBPCAMessages()
        {
            return BPCAMessageModel.GetMessages();
        }

        [HttpPost, ActionName("SaveBPCAMessage")]
        public ActionResult SaveBPCAMessage(int messageId, DateTime messageDate, string messageText, DateTime messageExpiration)
        {
            DataAccess.DataAccess.ExecuteNonQuery("SaveBPCAMessage",
                "@messageId", messageId,
                "@messageText", messageText,
                "@messageDate", messageDate,
                "@messageExpiration", messageExpiration,
                "@userGuid", GetSessionVariable("UserGuid").ToString());

            return Json("");
        }
        #endregion

        #region Building Methods
        [HttpPost, HttpGet]
        public ActionResult EditBuilding(Guid buildingGuid, string name, string address1, string address2, string city,
            string state, string zipCode, int pilotPeriod, decimal commonCharges, Guid agencyGuid, string siteId,
            DateTime managedSince, bool retail, string agencyName)
        {
            BuildingModel b = new BuildingModel(buildingGuid, name, address1, address2, city, state,
                zipCode, pilotPeriod, agencyGuid, commonCharges, siteId, retail, managedSince, agencyName);

            ViewData["AgencyList"] = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(GetAgencyList(), "AgencyGuid", "AgencyName", agencyGuid);

            return View(b);
        }

        [HttpPost]
        public ActionResult SaveEditBuilding(Guid buildingGuid, string name, string address1, string address2, string city,
            string state, string zipCode, int pilotPeriod, decimal commonCharges, Guid agencyGuid, string siteId,
            DateTime managedSince, bool retail)
        {
            SaveBuilding(buildingGuid, name, address1, address2, city, state, zipCode, pilotPeriod, commonCharges, agencyGuid, siteId, managedSince, retail);

            return View("Home");
        }

        private void SaveBuilding(Guid buildingGuid, string name, string address1, string address2, string city,
            string state, string zipCode, int pilotPeriod, decimal commonCharges, Guid agencyGuid, string siteId,
            DateTime managedSince, bool retail)
        {
            DataAccess.DataAccess.ExecuteNonQuery("SaveBuilding",
                "@buildingGuid", buildingGuid,
                "@buildingName", name,
                "@address1", address1,
                "@address2", address2,
                "@city", city,
                "@state", state,
                "@zipCode", zipCode,
                "@pilotPeriod", pilotPeriod,
                "@commonCharges", commonCharges,
                "@agencyGuid", agencyGuid,
                "@siteId", siteId,
                "@managedSince", managedSince,
                "@retail", retail);
        }

        [HttpPost, HttpGet]
        public JsonResult GetBuildingList()
        {
            var agencyGuid = GetSessionVariable("UserAgencyGuid");
            try
            {
                if (agencyGuid == null) { agencyGuid = Guid.Empty.ToString(); }
                return BuildingModel.GetBuildingList(new Guid(agencyGuid));
            }
            catch
            {
                return null;
            }
        }

        [HttpPost, HttpGet]
        public JsonResult GetBuildingListforSummaryVersion()
        {
            var agencyGuid = "00000000-0000-0000-0000-000000000000";
            try
            {
                if (agencyGuid == null) { agencyGuid = Guid.Empty.ToString(); }
                return BuildingModel.GetBuildingListforSummaryVersion(new Guid(agencyGuid));
            }
            catch
            {
                return null;
            }
        }
      
        [HttpPost, HttpGet]
        public JsonResult GetBuildingHeaderData(Guid buildingGuid)
        {
            return BuildingModel.GetBuildingHeaderData(buildingGuid);
        }

        [HttpPost, HttpGet]
        public JsonResult GetOwnerGuid(Guid UnitGuid)
        {
            return BuildingModel.GetOwnerGuid(UnitGuid);
        }
        #endregion

        #region Unit Methods
        [HttpPost, HttpGet]
        public JsonResult GetAddEditUnit(Guid buildingGuid)
        {
            return BuildingModel.GetAddEditUnit(buildingGuid);
        }
        [HttpGet]
        public JsonResult GetAddEditSuspenedDefaultList(Guid unitGuid)
        {
            return BuildingModel.GetAddEditSuspendedDefaultList(unitGuid);
        }
        [HttpPost]
        public void SaveSuspendedTransactionState(int trxId, bool suspendedValue)
        {
            DataAccess.DataAccess.ExecuteNonQuery("SaveSuspendedDefaultSetting",
                "@trxId", trxId,
                "@suspended", suspendedValue,
                "@userGuid", new Guid(GetSessionVariable("UserGuid"))
            );
        }
        [HttpPost]
        public void SaveUnit(Guid unitGuid, Guid buildingGuid, string unitCode, decimal commonInterest)
        {
            try
            {
                if(unitGuid == Guid.Empty)
                {
                    DataAccess.DataAccess.ExecuteNonQuery("SaveBuildingUnit",
                        "@unitGuid", null,
                        "@buildingGuid", buildingGuid,
                        "@unitCode", unitCode,
                        "@pctci", commonInterest);
                }
                else
                {
                    DataAccess.DataAccess.ExecuteNonQuery("SaveBuildingUnit",
                    "@unitGuid", unitGuid,
                    "@buildingGuid", buildingGuid,
                    "@unitCode", unitCode,
                    "@pctci", commonInterest);
                }
                
            }
            catch
            {
                throw;
            }
        }
        [HttpPost]
        public void DeletePayment(int trxId, DateTime worksheetDate, decimal paidAmt)
        {
            Guid userGuid = new Guid(GetSessionVariable("UserGuid").ToString());
            BuildingModel.DeletePayment(trxId, userGuid, worksheetDate, paidAmt);
        }
        public void ReinstatePayment(int trxId)
        {
            Guid userGuid = new Guid(GetSessionVariable("UserGuid").ToString());
            BuildingModel.ReinstatePayment(trxId, userGuid);
        }
        #endregion

        #region Unit Owner Methods
        //public ActionResult AddEditUnitOwner()
        //{
        //    return View(new UnitOwnerModel(Guid.Empty));
        //}
        public ActionResult AddEditUnitOwner(Guid og)
        {
            return View(new UnitOwnerModel(og));
        }

        [HttpGet]
        public JsonResult GetSubOwners(Guid ownerGuid)
        {
            return UnitOwnerModel.GetSubOwners(ownerGuid);
        }
        [HttpGet]
        public JsonResult GetUnitOwner(Guid unitGuid)
        {
            return UnitOwnerModel.GetUnitOwner(unitGuid);
        }
        [HttpGet]
        public int GetNumberOfMonthsInDefault(Guid unitGuid, Guid ownerGuid)
        {
            return UnitOwnerModel.GetNumberOfMonthsInDefault(unitGuid, ownerGuid);
        }
        [HttpGet]
        public JsonResult SaveUnitOwner(Guid ownerGuid, string titleName, Guid buildingGuid, Guid unitGuid)
        {
            Guid agencyGuid = new Guid(GetSessionVariable("UserAgencyGuid").ToString());
            return UnitOwnerModel.SaveUnitOwner(ownerGuid, agencyGuid, titleName, buildingGuid, unitGuid);
        }
        [HttpPost]
        public void SaveUnitSubOwner(Guid subOwnerGuid, Guid ownerGuid, string firstName, string lastName, string address1, string address2, string city, string state,
            string zipCode, string zipPlus, string phone1, string phone2, string fax, string emailAddress)
        {
            UnitOwnerModel.SaveUnitSubOwner(subOwnerGuid, ownerGuid, firstName, lastName, address1, address2, city, state, zipCode, zipPlus, phone1, phone2, fax, emailAddress);
        }
        [HttpGet]
        public JsonResult FindUnitOwner(string searchType, string searchFor)
        {
            if (searchFor == null || searchType == null) {
                searchType = string.Empty;
                searchFor = string.Empty;
            }

            Guid agencyGuid = new Guid(GetSessionVariable("UserAgencyGuid").ToString());
            return UnitOwnerModel.FindUnitOwner(searchType, searchFor, agencyGuid);
        }
        #endregion

        #region User Methods
        [HttpPost, HttpGet]
        public JsonResult GetUserManagement()
        {
            return UserModel.GetUserManagement();
        }
        [HttpPost]
        public void SaveUser(Guid userGuid, Guid agencyGuid, string userName, string password, string firstName, string lastName, string emailAddress, bool isActive)
        {
            UserModel.SaveUser(userGuid, agencyGuid, userName, password, firstName, lastName, emailAddress, isActive);
        }
        [HttpPost]
        public void DeleteUser(Guid userGuid)
        {
            UserModel.DeleteUser(userGuid);
        }

        [HttpPost]
        public void UpdatePassword(string userName, string oldPassword, string password)
        {
            UserModel.UpdatePassword(userName, oldPassword, password);
        }
        #endregion

        #region Worksheets Methods
        [HttpGet]
        public JsonResult GetOpenWorksheets()
        {
            return WorksheetModel.GetOpenWorksheets(GetUserGuid());
        }
        public ActionResult AddEditWorksheet(Guid inv)
        {
            return View(new WorksheetModel(inv, GetUserGuid()));
        }
        [HttpGet]
        public JsonResult GetWorksheetInvoice(Guid invoiceGuid)
        {
            return WorksheetModel.GetWorksheetInvoice(invoiceGuid);
        }
        [HttpGet]
        public JsonResult GetWorksheetDetails(int worksheetId)
        {
            return WorksheetModel.GetWorksheetDetails(worksheetId);
        }
        [HttpGet]
        public JsonResult GetUnitList(Guid buildingGuid)
        {
            return BuildingModel.GetUnitList(buildingGuid);
        }
        [HttpGet]
        public JsonResult GetUnitInquiry(Guid unitGuid)
        {
            return BuildingModel.GetUnitInquiry(unitGuid);
        }
        [HttpPost]
        public void InsertDefault(Guid unitGuid, Guid ownerGuid, int worksheetId)
        {
            WorksheetModel.InsertDefault(unitGuid, ownerGuid, worksheetId);
        }
        [HttpPost]
        public void InsertPayments(Guid unitGuid, Guid ownerGuid, int worksheetId, int numPayments)
        {
            WorksheetModel.InsertPayments(unitGuid, ownerGuid, worksheetId, numPayments);
        }
        [HttpPost]
        public void DeleteWorksheetTransaction(int trxId)
        {
            WorksheetModel.DeleteWorksheetTransaction(trxId);
        }
        [HttpGet]
        public JsonResult GetWorksheetHistory(Guid buildingGuid)
        {
            return WorksheetModel.GetWorksheetHistory(buildingGuid);
        }
        public ActionResult RejectWorksheet(int worksheetId)
        {
            WorksheetModel.RejectWorksheet(worksheetId);
            return View("Home");
        }
        [HttpGet]
        public JsonResult GetSubmittedWorksheets()
        {
            return WorksheetModel.GetSubmittedWorksheets();
        }
        [HttpPost]
        public void SubmitWorksheet(int worksheetId)
        {
            WorksheetModel.SubmitWorksheet(worksheetId,  GetUserGuid());
        }
        public ActionResult ApproveWorksheet(int worksheetId)
        {
            WorksheetModel.ApproveWorksheet(worksheetId, GetUserGuid());
            return View("Home");
        }

        public bool ApproveAllWorksheet(int[] worksheetId)
        {
            foreach (int workId in worksheetId)
            {
                WorksheetModel.ApproveWorksheet(workId, GetUserGuid());
            }
            return true;
        }
        
        public bool RejectAllWorksheet(int[] worksheetId)
        {
            foreach (int workId in worksheetId)
            {
                WorksheetModel.RejectWorksheet(workId);
            }
            return true;
        }
        #endregion

        #region Report Methods
        public void DeficiencyReportView()
        {
        }

        //public JavaScript PrintInvoice(Guid invoiceGuid)
        //{
        //    return new System.Web.Mvc.JavaScript("window.open('http://google.com')");
        //}
        #endregion

        #region Invoice Methods
        [HttpGet]
        public JsonResult GetInvoiceCredits(Guid invoiceGuid)
        {
            return InvoiceModel.GetInvoiceCredits(invoiceGuid);
        }
        [HttpGet]
        public JsonResult GetInvoiceRollbacks(Guid invoiceGuid)
        {
            return InvoiceModel.GetInvoiceRollbacks(invoiceGuid);
        }
        [HttpGet]
        public JsonResult GetInvoiceApproved(Guid invoiceGuid)
        {
            return InvoiceModel.GetInvoiceApproved(invoiceGuid);
        }
        [HttpGet]
        public JsonResult GetInvoiceCreditTypes()
        {
            return InvoiceModel.GetInvoiceCreditTypes();
        }
        [HttpGet]
        public JsonResult GetInvoiceComponentsList()
        {
            return InvoiceModel.GetInvoiceComponentsList();
        }
        [HttpPost]
        public void DeleteInvoiceCredit(int rowId)
        {
            InvoiceModel.DeleteInvoiceCredit(rowId);
        }
        [HttpPost]
        public void DeleteRollback(int rollbackId)
        {
            InvoiceModel.DeleteRollback(rollbackId);
        }
        [HttpGet]
        public JsonResult InvoiceExists(Guid buildingGuid, DateTime invoiceDate)
        {
            return Json(new { invoiceGuid = InvoiceModel.InvoiceExists(buildingGuid, invoiceDate) });
        }
        [HttpGet]
        public JsonResult GetInvoiceHeader(Guid invoiceGuid)
        {
            return InvoiceModel.GetInvoiceHeader(invoiceGuid);
        }
        [HttpGet]
        public JsonResult SaveInvoice(Guid invoiceGuid, DateTime invoiceDate, decimal baseRent, decimal civic, decimal suppl, decimal pilot, Guid buildingGuid)
        {
            return InvoiceModel.SaveInvoice(invoiceGuid, invoiceDate, baseRent, civic, suppl, pilot, buildingGuid, GetUserGuid());
        }
        [HttpPost]
        public void ClearInvoiceCredits(Guid invoiceGuid)
        {
            InvoiceModel.ClearInvoiceCredits(invoiceGuid);
        }
        [HttpPost]
        public void SaveInvoiceCredit(Guid invoiceGuid, int creditId, decimal creditAmount, decimal BaseRent, decimal CivicFacility, decimal Supplemental, decimal pilot, string userDesc, DateTime? dateFrom, DateTime? dateTo)
        {
            InvoiceModel.SaveInvoiceCredit(invoiceGuid, creditId, creditAmount,BaseRent,CivicFacility,Supplemental,pilot, userDesc, dateFrom, dateTo);
        }
        [HttpPost]
        public void ClearInvoiceRollbacks(Guid invoiceGuid)
        {
            InvoiceModel.ClearInvoiceRollbacks(invoiceGuid);
        }
        [HttpPost]
        public void SaveInvoiceRollbacks(Guid invoiceGuid, Guid buildingGuid, int invoiceComponentId, DateTime dateFrom, DateTime dateTo, decimal amount, DateTime invoiceDate)
        {
            try
            {
                InvoiceModel.SaveInvoiceRollbacks(invoiceGuid, buildingGuid, invoiceComponentId, dateFrom, dateTo, amount, invoiceDate, GetUserGuid());
            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(ex.Message);
                if (invoiceGuid != null)
                {
                    sb.AppendLine("InvoiceGuid: ");
                    sb.Append(invoiceGuid.ToString());
                }
                if (buildingGuid != null)
                {
                    sb.AppendLine("BuildingGuid: ");
                    sb.Append(buildingGuid.ToString());
                }
                sb.AppendLine("InvoiceComponentId: ");
                sb.Append(invoiceComponentId.ToString());
                sb.AppendLine("DateFrom: ");
                sb.Append(dateFrom.ToShortDateString());
                sb.AppendLine("DateTo: ");
                sb.Append(dateTo.ToShortDateString());
                sb.AppendLine("Amount: ");
                sb.Append(amount.ToString());
                sb.AppendLine("InvoiceDate: ");
                sb.Append(invoiceDate.ToShortDateString());

                LogWriter.LogError(sb.ToString());
            }
        }
        [HttpGet]
        public decimal CalculateAdjustmentDifference(string adjustType, DateTime dateFrom, DateTime dateTo, 
            DateTime currentDate, Guid buildingGuid, decimal amount)
        {
            return InvoiceModel.CalculateAdjustmentDifference(adjustType, dateFrom, dateTo, currentDate, buildingGuid, amount);
        }
        #endregion


        [HttpGet]
        public DataSet GetBuildingSummaryReportXl(Guid buildingGuid, object asOf, object showSuspended)
        {
            return BuildingModel.GetBuildingSummaryReportXl((object)buildingGuid, asOf, showSuspended);
        }

        [HttpPost]
        public ActionResult ExportToExcelReport(
          Guid buildingGuid,
          DateTime invoiceDate,
          bool shsu,
          string buildingGuidname)
        {
            DataSet buildingSummaryReportXl = this.GetBuildingSummaryReportXl(buildingGuid, (object)invoiceDate, (object)shsu);
            MemoryStream memoryStream = new MemoryStream();
            string str1 = buildingGuidname + "_Building Summary Report.xlsx";
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets.Add("Building Summary Report");
                    ((ExcelRangeBase)excelWorksheet.Cells[1, 1]).Value = (object)"Unit ID";
                    ((ExcelRangeBase)excelWorksheet.Cells[1, 1]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[1, 2]).Value = (object)"Month";
                    ((ExcelRangeBase)excelWorksheet.Cells[1, 2]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[1, 3]).Value = (object)"Unit Owner";
                    ((ExcelRangeBase)excelWorksheet.Cells[1, 3]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[1, 4]).Value = (object)"Base Rent";
                    ((ExcelRangeBase)excelWorksheet.Cells[1, 4]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[1, 5]).Value = (object)"Civic facility";
                    ((ExcelRangeBase)excelWorksheet.Cells[1, 5]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[1, 6]).Value = (object)"Supplemental";
                    ((ExcelRangeBase)excelWorksheet.Cells[1, 6]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[1, 7]).Value = (object)"Pilot";
                    ((ExcelRangeBase)excelWorksheet.Cells[1, 7]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[1, 8]).Value = (object)"Total";
                    ((ExcelRangeBase)excelWorksheet.Cells[1, 8]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[1, 9]).Value = (object)"Adjusted Pilot";
                    ((ExcelRangeBase)excelWorksheet.Cells[1, 9]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[1, 10]).Value = (object)"Revised Total Due";
                    ((ExcelRangeBase)excelWorksheet.Cells[1, 10]).Style.Font.Bold = true;
                    int num1 = 2;
                    Decimal num2 = 0M;
                    Decimal num3 = 0M;
                    Decimal num4 = 0M;
                    Decimal num5 = 0M;
                    Decimal num6 = 0M;
                    Decimal num7 = 0M;
                    Decimal num8 = 0M;
                    Decimal num9 = 0M;
                    Decimal num10 = 0M;
                    Decimal num11 = 0M;
                    Decimal num12 = 0M;
                    Decimal num13 = 0M;
                    Decimal num14 = 0M;
                    Decimal num15 = 0M;
                    List<string> stringList = new List<string>();
                    foreach (DataRow row in (InternalDataCollectionBase)buildingSummaryReportXl.Tables[1].Rows)
                    {
                        if (!stringList.Contains(row["unitcode"].ToString()))
                        {
                            if (stringList.Count == 1)
                            {
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 2]).Value = (object)"Total";
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 2]).Style.Font.Bold = true;
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 4]).Value = (object)("$" + (object)num2);
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 4]).Style.Font.Bold = true;
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 5]).Value = (object)("$" + (object)num3);
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 5]).Style.Font.Bold = true;
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 6]).Value = (object)("$" + (object)num4);
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 6]).Style.Font.Bold = true;
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 7]).Value = (object)("$" + (object)num5);
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 7]).Style.Font.Bold = true;
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 8]).Value = (object)("$" + (object)num6);
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 8]).Style.Font.Bold = true;
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 9]).Value = (object)("$" + (object)num7);
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 9]).Style.Font.Bold = true;
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 10]).Value = (object)("$" + (object)num8);
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 10]).Style.Font.Bold = true;
                                num9 += num2;
                                num10 += num3;
                                num11 += num4;
                                num12 += num5;
                                num13 += num6;
                                num14 += num7;
                                num15 += num8;
                                num2 = 0M;
                                num3 = 0M;
                                num4 = 0M;
                                num5 = 0M;
                                num6 = 0M;
                                num7 = 0M;
                                num8 = 0M;
                                stringList.Add(row["unitcode"].ToString());
                                ++num1;
                            }
                            else if (stringList.Count > 1)
                            {
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 2]).Value = (object)"Total";
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 2]).Style.Font.Bold = true;
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 4]).Value = (object)("$" + (object)num2);
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 4]).Style.Font.Bold = true;
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 5]).Value = (object)("$" + (object)num3);
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 5]).Style.Font.Bold = true;
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 6]).Value = (object)("$" + (object)num4);
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 6]).Style.Font.Bold = true;
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 7]).Value = (object)("$" + (object)num5);
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 7]).Style.Font.Bold = true;
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 8]).Value = (object)("$" + (object)num6);
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 8]).Style.Font.Bold = true;
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 9]).Value = (object)("$" + (object)num7);
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 9]).Style.Font.Bold = true;
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 10]).Value = (object)("$" + (object)num8);
                                ((ExcelRangeBase)excelWorksheet.Cells[num1, 10]).Style.Font.Bold = true;
                                num9 += num2;
                                num10 += num3;
                                num11 += num4;
                                num12 += num5;
                                num13 += num6;
                                num14 += num7;
                                num15 += num8;
                                num2 = 0M;
                                num3 = 0M;
                                num4 = 0M;
                                num5 = 0M;
                                num6 = 0M;
                                num7 = 0M;
                                num8 = 0M;
                                stringList.Add(row["unitcode"].ToString());
                                ++num1;
                            }
                            else
                                stringList.Add(row["unitcode"].ToString());
                        }
                      ((ExcelRangeBase)excelWorksheet.Cells[num1, 1]).Value = row["unitcode"];
                        ExcelRange cell = excelWorksheet.Cells[num1, 2];
                        DateTime dateTime = Convert.ToDateTime(row["trxdate"]);
                        string str2 = dateTime.ToString("MMM");
                        dateTime = Convert.ToDateTime(row["trxdate"]);
                        // ISSUE: variable of a boxed type
                       // __Boxed<int> year = (ValueType)dateTime.Year;
                        string str3 = $"{str2}-{(int)dateTime.Year}";
                        ((ExcelRangeBase)cell).Value = (object)str3;
                        ((ExcelRangeBase)excelWorksheet.Cells[num1, 3]).Value = row["titlename"];
                        ((ExcelRangeBase)excelWorksheet.Cells[num1, 4]).Value = (object)("$" + row["baserent"]);
                        ((ExcelRangeBase)excelWorksheet.Cells[num1, 5]).Value = (object)("$" + row["civic"]);
                        ((ExcelRangeBase)excelWorksheet.Cells[num1, 6]).Value = (object)("$" + row["supplemental"]);
                        ((ExcelRangeBase)excelWorksheet.Cells[num1, 7]).Value = (object)("$" + row["pilot"]);
                        ((ExcelRangeBase)excelWorksheet.Cells[num1, 8]).Value = (object)("$" + row["total"]);
                        ((ExcelRangeBase)excelWorksheet.Cells[num1, 9]).Value = (object)("$" + row["pilotadj"]);
                        ((ExcelRangeBase)excelWorksheet.Cells[num1, 10]).Value = (object)("$" + row["adjtotal"]);
                        num2 += Convert.ToDecimal(row["baserent"]);
                        num3 += Convert.ToDecimal(row["civic"]);
                        num4 += Convert.ToDecimal(row["supplemental"]);
                        num5 += Convert.ToDecimal(row["pilot"]);
                        num6 += Convert.ToDecimal(row["total"]);
                        num7 += Convert.ToDecimal(row["pilotadj"]);
                        num8 += Convert.ToDecimal(row["adjtotal"]);
                        ++num1;
                    }
                    if (stringList.Count > 0)
                    {
                        ((ExcelRangeBase)excelWorksheet.Cells[num1, 2]).Value = (object)"Total";
                        ((ExcelRangeBase)excelWorksheet.Cells[num1, 2]).Style.Font.Bold = true;
                        ((ExcelRangeBase)excelWorksheet.Cells[num1, 4]).Value = (object)("$" + (object)num2);
                        ((ExcelRangeBase)excelWorksheet.Cells[num1, 4]).Style.Font.Bold = true;
                        ((ExcelRangeBase)excelWorksheet.Cells[num1, 5]).Value = (object)("$" + (object)num3);
                        ((ExcelRangeBase)excelWorksheet.Cells[num1, 5]).Style.Font.Bold = true;
                        ((ExcelRangeBase)excelWorksheet.Cells[num1, 6]).Value = (object)("$" + (object)num4);
                        ((ExcelRangeBase)excelWorksheet.Cells[num1, 6]).Style.Font.Bold = true;
                        ((ExcelRangeBase)excelWorksheet.Cells[num1, 7]).Value = (object)("$" + (object)num5);
                        ((ExcelRangeBase)excelWorksheet.Cells[num1, 7]).Style.Font.Bold = true;
                        ((ExcelRangeBase)excelWorksheet.Cells[num1, 8]).Value = (object)("$" + (object)num6);
                        ((ExcelRangeBase)excelWorksheet.Cells[num1, 8]).Style.Font.Bold = true;
                        ((ExcelRangeBase)excelWorksheet.Cells[num1, 9]).Value = (object)("$" + (object)num7);
                        ((ExcelRangeBase)excelWorksheet.Cells[num1, 9]).Style.Font.Bold = true;
                        ((ExcelRangeBase)excelWorksheet.Cells[num1, 10]).Value = (object)("$" + (object)num8);
                        ((ExcelRangeBase)excelWorksheet.Cells[num1, 10]).Style.Font.Bold = true;
                        num9 += num2;
                        num10 += num3;
                        num11 += num4;
                        num12 += num5;
                        num13 += num6;
                        num14 += num7;
                        num15 += num8;
                        num1 = num1 + 1 + 1;
                    }
                  ((ExcelRangeBase)excelWorksheet.Cells[num1, 2]).Value = (object)"Grand Total";
                    ((ExcelRangeBase)excelWorksheet.Cells[num1, 2]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[num1, 4]).Value = (object)("$" + (object)num9);
                    ((ExcelRangeBase)excelWorksheet.Cells[num1, 4]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[num1, 5]).Value = (object)("$" + (object)num10);
                    ((ExcelRangeBase)excelWorksheet.Cells[num1, 5]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[num1, 6]).Value = (object)("$" + (object)num11);
                    ((ExcelRangeBase)excelWorksheet.Cells[num1, 6]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[num1, 7]).Value = (object)("$" + (object)num12);
                    ((ExcelRangeBase)excelWorksheet.Cells[num1, 7]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[num1, 8]).Value = (object)("$" + (object)num13);
                    ((ExcelRangeBase)excelWorksheet.Cells[num1, 8]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[num1, 9]).Value = (object)("$" + (object)num14);
                    ((ExcelRangeBase)excelWorksheet.Cells[num1, 9]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[num1, 10]).Value = (object)("$" + (object)num15);
                    ((ExcelRangeBase)excelWorksheet.Cells[num1, 10]).Style.Font.Bold = true;
                    int num16 = num1 + 1 + 1 + 1;
                    ((ExcelRangeBase)excelWorksheet.Cells[num16, 1]).Value = (object)"Summary";
                    ((ExcelRangeBase)excelWorksheet.Cells[num16, 1]).Style.Font.Bold = true;
                    int num17 = num16 + 1;
                    ((ExcelRangeBase)excelWorksheet.Cells[num17, 1]).Value = (object)"Month";
                    ((ExcelRangeBase)excelWorksheet.Cells[num17, 1]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[num17, 2]).Value = (object)"Base Rent";
                    ((ExcelRangeBase)excelWorksheet.Cells[num17, 2]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[num17, 3]).Value = (object)"Civic facility";
                    ((ExcelRangeBase)excelWorksheet.Cells[num17, 3]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[num17, 4]).Value = (object)"Supplemental";
                    ((ExcelRangeBase)excelWorksheet.Cells[num17, 4]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[num17, 5]).Value = (object)"Pilot";
                    ((ExcelRangeBase)excelWorksheet.Cells[num17, 5]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[num17, 6]).Value = (object)"Total";
                    ((ExcelRangeBase)excelWorksheet.Cells[num17, 6]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[num17, 7]).Value = (object)"Adjusted Pilot";
                    ((ExcelRangeBase)excelWorksheet.Cells[num17, 7]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[num17, 8]).Value = (object)"Revised Total Due";
                    ((ExcelRangeBase)excelWorksheet.Cells[num17, 8]).Style.Font.Bold = true;
                    Decimal num18 = 0M;
                    Decimal num19 = 0M;
                    Decimal num20 = 0M;
                    Decimal num21 = 0M;
                    Decimal num22 = 0M;
                    Decimal num23 = 0M;
                    Decimal num24 = 0M;
                    int num25 = num17 + 1;
                    foreach (DataRow row in (InternalDataCollectionBase)buildingSummaryReportXl.Tables[2].Rows)
                    {
                        ((ExcelRangeBase)excelWorksheet.Cells[num25, 1]).Value = (object)$"{Convert.ToDateTime(row["trxdate"]).ToString("MMM")}-{(object)Convert.ToDateTime(row["trxdate"]).Year}";
                        ((ExcelRangeBase)excelWorksheet.Cells[num25, 2]).Value = (object)("$" + row["baserent"]);
                        ((ExcelRangeBase)excelWorksheet.Cells[num25, 3]).Value = (object)("$" + row["civic"]);
                        ((ExcelRangeBase)excelWorksheet.Cells[num25, 4]).Value = (object)("$" + row["supplemental"]);
                        ((ExcelRangeBase)excelWorksheet.Cells[num25, 5]).Value = (object)("$" + row["pilot"]);
                        ((ExcelRangeBase)excelWorksheet.Cells[num25, 6]).Value = (object)("$" + row["total"]);
                        ((ExcelRangeBase)excelWorksheet.Cells[num25, 7]).Value = (object)("$" + row["pilotadj"]);
                        ((ExcelRangeBase)excelWorksheet.Cells[num25, 8]).Value = (object)("$" + row["adjtotal"]);
                        num18 += Convert.ToDecimal(row["baserent"]);
                        num19 += Convert.ToDecimal(row["civic"]);
                        num20 += Convert.ToDecimal(row["supplemental"]);
                        num21 += Convert.ToDecimal(row["pilot"]);
                        num22 += Convert.ToDecimal(row["total"]);
                        num23 += Convert.ToDecimal(row["pilotadj"]);
                        num24 += Convert.ToDecimal(row["adjtotal"]);
                        ++num25;
                    }
                  ((ExcelRangeBase)excelWorksheet.Cells[num25, 1]).Value = (object)"Grand Total";
                    ((ExcelRangeBase)excelWorksheet.Cells[num25, 1]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[num25, 2]).Value = (object)("$" + (object)num18);
                    ((ExcelRangeBase)excelWorksheet.Cells[num25, 2]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[num25, 3]).Value = (object)("$" + (object)num19);
                    ((ExcelRangeBase)excelWorksheet.Cells[num25, 3]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[num25, 4]).Value = (object)("$" + (object)num20);
                    ((ExcelRangeBase)excelWorksheet.Cells[num25, 4]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[num25, 5]).Value = (object)("$" + (object)num21);
                    ((ExcelRangeBase)excelWorksheet.Cells[num25, 5]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[num25, 6]).Value = (object)("$" + (object)num22);
                    ((ExcelRangeBase)excelWorksheet.Cells[num25, 6]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[num25, 7]).Value = (object)("$" + (object)num23);
                    ((ExcelRangeBase)excelWorksheet.Cells[num25, 7]).Style.Font.Bold = true;
                    ((ExcelRangeBase)excelWorksheet.Cells[num25, 8]).Value = (object)("$" + (object)num24);
                    ((ExcelRangeBase)excelWorksheet.Cells[num25, 8]).Style.Font.Bold = true;
                    excelPackage.SaveAs((Stream)memoryStream);
                    return (ActionResult)((ControllerBase)this).File(memoryStream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", str1);
                }
            }
            catch (Exception ex)
            {
                return (ActionResult)((ControllerBase)this).Content("An error occurred while generating the Excel file. Please try again later.");
            }
        }

    }
}
