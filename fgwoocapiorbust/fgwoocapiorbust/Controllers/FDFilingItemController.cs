using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.WindowsAzure.Mobile.Service;
using fgwoocapiorbust.DataObjects;
using fgwoocapiorbust.Models;

namespace fgwoocapiorbust.Controllers
{
    public class FDFilingItemController : TableController<FDFilingItem>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<FDFilingItem>(context, Request, Services);
        }

        // GET tables/FDFilingItem
        public IQueryable<FDFilingItem> GetAllFDFilingItem()
        {
            return Query(); 
        }

        // GET tables/FDFilingItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<FDFilingItem> GetFDFilingItem(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/FDFilingItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<FDFilingItem> PatchFDFilingItem(string id, Delta<FDFilingItem> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/FDFilingItem
        public async Task<IHttpActionResult> PostFDFilingItem(FDFilingItem item)
        {
            FDFilingItem current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/FDFilingItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteFDFilingItem(string id)
        {
             return DeleteAsync(id);
        }

    }
}