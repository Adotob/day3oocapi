##Office of the Clerk - Azure Days##
Day 3 Demo 1 -  day3oocapi
#Description#
<p>
Using OOC Schema to create a API for management via Azure API Management Portal. This may be 2 projects in 1 solution. One using Azure Mobile Service, the other standard Web API ASP Template
<p>
#Azure Mobile Services Solution#
##Pre-Reqs##
<ul>
	<li>
		Azure Subscription with Azure Mobile Services and Azure API Management Configured
	</li>
	<li>
		Visual Studio (at least community edition)
	</li>
</ul>
##Steps Taken##
<ol>
	<li>
		From Visual Studio, Create a Cloud/Azure Mobile Services Solution
	</li>
		<li>
		Add your Custom Class representing the entity you are creating an API for
	</li>	
	<li>
		Seed sample data as necessary - this is used to ensure that when you do a GET request from your API you will get results coming back.
	</li>
		<li>
		Add a Controller to do the CRUD operation against your Entity
	</li>
		<li>
		Test your API Locally (prefereably in a Chrome Browser) -- Remember, all a WAMS solution is.. is a Web API without the Views and it offers helper utilities to test the schema and you can make calls to the API locally before publishing to WAMS
	</li>
		<li>
		If all goes well and you are able to perform all the Methods in your Controller, go ahead and Publish to WAMS
	</li>
</ol>

#Asp.NET Solution#

<p> Work in Progress</p>


#Disclaimer#
This is for demo puroposes fitting a specfic Use Case for the client. Use at your own risk. To contact me regarding any item related to this repo, please use the Issues options in GitHub. 