using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BPEC.Models;
using BPEC.DAL;

namespace BPEC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public static string GetHeader()
        {
            PageContentContext db = new PageContentContext();
            var query = from p in db.PagesContent
                        where p.PageCode == "Header Announcement"
                        select new
                        {
                            Content = p.PageContentHTML,
                            Title = p.PageDisplayName
                        };
            var pagescontent = query.ToList();
            if (pagescontent.Count == 0)
            {
                return "";
            }
            return pagescontent[0].Content;
        }

        public ActionResult AboutPage(string section = "Mission, Vision and Fact")
        {
            PageContentContext db = new PageContentContext();
            var query = from p in db.PagesContent
                              where p.PageCode == section
                              select new {
                                  Content=p.PageContentHTML ,
                                  Title = p.PageDisplayName
                              };
            var pagescontent = query.ToList();
            if (pagescontent.Count == 0)
            {
                return HttpNotFound();
            }
            ViewBag.TitleStr = pagescontent[0].Title;
            ViewBag.Title = "BPEC - " + pagescontent[0].Title;
            return View((object)pagescontent[0].Content);
            //return View();
        }

        public ActionResult Page(string section = "")
        {
            PageContentContext db = new PageContentContext();
            var query = from p in db.PagesContent
                        where p.PageCode == section
                        select new
                        {
                            Content = p.PageContentHTML,
                            Title = p.PageDisplayName
                        };
            var pagescontent = query.ToList();
            if (pagescontent.Count == 0)
            {
                return HttpNotFound();
            }
            ViewBag.TitleStr = pagescontent[0].Title;
            ViewBag.Title = "BPEC - " + pagescontent[0].Title;
            return View((object)pagescontent[0].Content);
            //return View();
        }

        public ActionResult ProgramsPage(string section = "Mission, Vision and Fact")
        {
            PageContentContext db = new PageContentContext();
            var query = from p in db.PagesContent
                        where p.PageCode == section
                        select new
                        {
                            Content = p.PageContentHTML,
                            Title = p.PageDisplayName
                        };
            var pagescontent = query.ToList();
            if (pagescontent.Count == 0)
            {
                return HttpNotFound();
            }
            ViewBag.TitleStr = pagescontent[0].Title;
            ViewBag.Title = "BPEC - " + pagescontent[0].Title;
            return View((object)pagescontent[0].Content);
            //return View();
        }

        public class CertificateName
        {
            public string CertificateNameStr;
        }
        public static List<CertificateName> GetCertificates()
        {
            PageContentContext db = new PageContentContext();
            var query = from p in db.Certificates
                        select new CertificateName
                        {
                            CertificateNameStr = p.CertificateName
                        };
            List<CertificateName> pagescontent = query.ToList();
            if (pagescontent.Count == 0)
            {
                return null;
            }
            return pagescontent;
        }
        
        public class CertificateView
        {
            public string CertificateName;
            public string CertificateAbout;
            public string CertificateWhy;
            public string CertificateWhyBPEC;
            public string CertificateWho;
        }//CertificateView
                
        public ActionResult CertificatesPage(string cert = "CPA")
        {
            PageContentContext db = new PageContentContext();
            var query = from p in db.Certificates
                        where p.CertificateName == cert
                        select new CertificateView
                        {
                            CertificateName = p.CertificateName,
                            CertificateAbout = p.CertificateAbout,
                            CertificateWhy = p.CertificateWhy,
                            CertificateWhyBPEC = p.CertificateWhyBPEC,
                            CertificateWho = p.CertificateWho
                        };
            List<CertificateView> pagescontent = query.ToList();
            if (pagescontent.Count == 0)
            {
                return HttpNotFound();
            }
            ViewBag.TitleStr = pagescontent[0].CertificateName;
            ViewBag.Title = "BPEC - " + pagescontent[0].CertificateName;
            return View(pagescontent[0]);
            //return View();
        }

        public class ClientName
        {
            public string ClientNameStr;
        }
        public static List<ClientName> GetClientNames()
        {
            PageContentContext db = new PageContentContext();
            var query = from p in db.Clients
                        select new ClientName
                        {
                            ClientNameStr = p.ClientName
                        };
            List<ClientName> pagescontent = query.ToList();
            if (pagescontent.Count == 0)
            {
                return null;
            }
            return pagescontent;
        }
        
        public class ClientView
        {
            public string ClientName;
            public string ClientAbout;
            public bool HasLogo;
        }//CertificateView

        public ActionResult ClientPage(string client = "")
        {
            PageContentContext db = new PageContentContext();
            var query = from p in db.Clients
                        where p.ClientName == client
                        select new ClientView
                        {
                            ClientName = p.ClientName,
                            ClientAbout = p.ClientAbout,
                            HasLogo = p.HasLogo
                        };
            if (client == "")
            {
                query = from p in db.Clients
                        select new ClientView
                        {
                            ClientName = p.ClientName,
                            ClientAbout = p.ClientAbout,
                            HasLogo = p.HasLogo
                        };
            }//if
            List<ClientView> pagescontent = query.ToList();
            if (pagescontent.Count == 0)
            {
                return HttpNotFound();
            }
            ViewBag.TitleStr = pagescontent[0].ClientName;
            ViewBag.Title = "BPEC - " + pagescontent[0].ClientName;
            return View(pagescontent[0]);
            //return View();
        }
    }
}
