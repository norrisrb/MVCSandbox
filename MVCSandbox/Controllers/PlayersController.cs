using System.Linq;
using System.Web.Mvc;
using MVCSandbox.OpenAccess;

namespace MVCSandbox.Controllers
{
    public class PlayersController : Controller
    {
        private EntitiesModel dbContext;

        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            base.Initialize(requestContext);
            this.dbContext = ContextFactory.GetContextPerRequest();
        }

        // GET: Player
        public ActionResult Index()
        {
            return View(this.dbContext.Players.ToList());
        }

        public JsonResult GetPlayers()
        {
            return Json(dbContext.Players, JsonRequestBehavior.AllowGet);
        }

        // GET: Player/Details/5
        public ActionResult Details(int id)
        {
            return View(this.dbContext.Players.FirstOrDefault(player => player.PlayerId == id));
        }

        // GET: Player/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Player/Create
        [HttpPost]
        public ActionResult Create(Player newPlayer)
        {
            try
            {
                this.dbContext.Add(newPlayer);
                this.dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Player/Edit/5
        public ActionResult Edit(int id)
        {
            return View(this.dbContext.Players.FirstOrDefault(player => player.PlayerId == id));
        }

        // POST: Player/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Player playerToUpdate)
        {
            try
            {
                Player originalPlayer = this.dbContext.Players.FirstOrDefault(player => player.PlayerId == id);
                originalPlayer.FirstName = playerToUpdate.FirstName;
                originalPlayer.MiddleName = playerToUpdate.MiddleName;
                originalPlayer.LastName = playerToUpdate.LastName;
                originalPlayer.Email = playerToUpdate.Email;
                originalPlayer.Address1 = playerToUpdate.Address1;
                originalPlayer.Address2 = playerToUpdate.Address2;
                originalPlayer.City = playerToUpdate.City;
                originalPlayer.State = playerToUpdate.State;
                originalPlayer.Zip = playerToUpdate.Zip;
                originalPlayer.HomePhone = playerToUpdate.HomePhone;
                originalPlayer.MobilePhone = playerToUpdate.MobilePhone;
                originalPlayer.SignificantOther = playerToUpdate.SignificantOther;
                originalPlayer.Handicap = playerToUpdate.Handicap;
                originalPlayer.Index = playerToUpdate.Index;
                originalPlayer.Active = playerToUpdate.Active;

                this.dbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Player/Delete/5
        public ActionResult Delete(int id)
        {
            return View(this.dbContext.Players.FirstOrDefault(player => player.PlayerId == id));
        }

        // POST: Player/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Player playerToDelete =
                    this.dbContext.Players.FirstOrDefault(player => player.PlayerId == id);

                this.dbContext.Delete( playerToDelete );

                this.dbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
