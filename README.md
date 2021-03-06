# Fish-website-prototype

---

# About
 * App architecture description - .net core mvc web app  
 * Primary Languages 
	* Backend - C#
	* Frontend - Razor
 * UI CSS mainly consist of - bootstrap v3.3.7 along with some custom css. 
	
# Framworks and external Ref
* https://github.com/bchavez/Bogus
* Icons made by <a href="https://www.flaticon.com/authors/those-icons" title="Those Icons">Those Icons</a> 
* Logo's created by <a href="https://logohub.io/" title="LogoHub">Logo Hub</a>
* Navbar built with <a href="https://work.smarchal.com/twbscolor/" title="twbscolor">twbscolor</a> 

# Tracking Tasks, Bugs, and Hacks
- Use [TODO Method](https://blogs.msdn.microsoft.com/zainnab/2013/08/15/visual-studio-2013-todo-comments-and-custom-tokens-in-the-task-list/) to keep tabs on tasks
- view todo notes through the 'task list'...
	- To configure in VS2017 go to View > Task List

# Other
 * Sql data model and architecture diagrams will be done through [draw.io](https://www.draw.io)
 
 # To Use Draw.IO
 1. Log into site with Git
 2. Open existing project
 3. select Fish-website-prototpe
 4. Pick a file with the draw extentsion

# Service Request Notes 

- HTML Helpers --> Implementing Dropdownlist in [Razor Example](https://www.tutorialsteacher.com/mvc/htmlhelper-dropdownlist-dropdownlistfor)
	- TextArea and Radio button list within the same section 
## Optional UI Refs
- Review [Bootstrap Css Options](https://getbootstrap.com/docs/3.3/css/#buttons-options) for button colors
- Panel to capture service request type details https://getbootstrap.com/docs/3.3/components/#panels-heading
- Add [Glyphicons](https://getbootstrap.com/docs/3.3/components/#glyphicons) to inputs like Email
- Add a [Jumbotron](https://getbootstrap.com/docs/3.3/components/#jumbotron) to the page

## Model binding 
- [View example here](https://www.tutorialspoint.com/asp.net_mvc/asp.net_mvc_model_binding.htm)
- Create a post method for the form[View example here](https://www.tutorialsteacher.com/mvc/model-binding-in-asp.net-mvc)

## Api's on Api's
* GCP
	* [Photo's api](https://developers.google.com/photos/)
	* [Calendar api](https://developers.google.com/calendar/)
* Azure
	* Temporarily using [Azure AD Graph Api](https://docs.microsoft.com/en-us/previous-versions/azure/ad/graph/howto/azure-ad-graph-api-operations-overview) for b2c support
		* Watch for major updates to Microsoft Graph Api [status updates](https://developer.microsoft.com/en-us/office/blogs/microsoft-graph-or-azure-ad-graph/) to upgrade app
	* Blob [REST api](https://docs.microsoft.com/en-us/rest/api/storageservices/blob-service-rest-api)
	* Going serverless with [Functions](https://docs.microsoft.com/en-us/azure/azure-functions/functions-create-first-azure-function)
	 	* For operational needs such as a nightly scanner aka cost management service
- Sendgrid
	- Email [api service](https://sendgrid.com/docs/API_Reference/index.html)

## Future Needs
- High level solutions architecture documentation
- High level topologies for Cloud Infrastructure, Security, Network, and micro services

