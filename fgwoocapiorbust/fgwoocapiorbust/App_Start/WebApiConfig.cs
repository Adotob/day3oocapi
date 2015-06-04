using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Web.Http;
using fgwoocapiorbust.DataObjects;
using fgwoocapiorbust.Models;
using Microsoft.WindowsAzure.Mobile.Service;

namespace fgwoocapiorbust
{
    public static class WebApiConfig
    {
        public static void Register()
        {
            // Use this class to set configuration options for your mobile service
            ConfigOptions options = new ConfigOptions();

            // Use this class to set WebAPI configuration options
            HttpConfiguration config = ServiceConfig.Initialize(new ConfigBuilder(options));

            // To display errors in the browser during development, uncomment the following
            // line. Comment it out again when you deploy your service for production use.
            // config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;

            Database.SetInitializer(new MobileServiceInitializer());
        }
    }

    public class MobileServiceInitializer : DropCreateDatabaseIfModelChanges<MobileServiceContext>
    {
        protected override void Seed(MobileServiceContext context)
        {

            List<FDFilingItem> fdFilingItems = new List<FDFilingItem>
            {
                new FDFilingItem
                {
                    Id = Guid.NewGuid().ToString(),
                    filingID = 12345,
                    docID = "ABCDE",
                    profileID = 6789,
                    filerID = 1,
                    prefix = "LOL",
                    firstName = "Fabian",
                    middleName = "G",
                    lastName = "Williams",
                    suffix = "Jr.",
                    agencyCode = "HR",
                    officeCode = "MD",
                    filingYear = 2014,
                    filingType = "O",
                    filerReq = "P",
                    filerType = "Q",
                    filingDate = null,
                    docXMLData = "",
                    addTimeStamp = null,
                    terminationDate = null,
                    electionYear = null,
                    fecID = "123-asd-32",
                    bioguideID = "er4-2234-12344",
                    staffID = 9
                },

                new FDFilingItem
                {
                    Id = Guid.NewGuid().ToString(),
                    filingID = 98765,
                    docID = "FGHIJ",
                    profileID = 9876,
                    filerID = 5,
                    prefix = "FYI",
                    firstName = "Patrick",
                    middleName = "A",
                    lastName = "Curran",
                    suffix = "III",
                    agencyCode = "SH",
                    officeCode = "VA",
                    filingYear = 2014,
                    filingType = "A",
                    filerReq = "P",
                    filerType = "Q",
                    filingDate = null,
                    docXMLData = "",
                    addTimeStamp = null,
                    terminationDate = null,
                    electionYear = null,
                    fecID = "123-wuq-34",
                    bioguideID = "rew-7252-82953",
                    staffID = 9
                },
            };

            foreach (FDFilingItem fitem in fdFilingItems)
            {
                context.Set<FDFilingItem>().Add(fitem);
            }
            
            
            List<TodoItem> todoItems = new List<TodoItem>
            {
                new TodoItem { 
                    Id = Guid.NewGuid().ToString(),
                    Text = "First item", Complete = false 
                },
                new TodoItem { Id = Guid.NewGuid().ToString(), Text = "Second item", Complete = false },
            };

            foreach (TodoItem todoItem in todoItems)
            {
                context.Set<TodoItem>().Add(todoItem);
            }

            base.Seed(context);
        }
    }
}

