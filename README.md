========================================================================
       ASP.NET MVC APPLICATION : RepositoryPull Project Overview
========================================================================

///////////////////////////////////////////
Use:
	The project search for repositories in github by query and creating a bookmarks in asp.net mvc application.

	The detailed functionality include useage of github search api and bookmarking on session.

	The application use ActionResult class to display the index view, webapi for client useage.

/////////////////////////////////////////////////
Demo:
  
	*open the project

	*open index page on the brwoser 

	*enter in the search input your repository name and click search

	*on the galary result you can click "add to bookmark" button 

	*to view bookmarks click on the "bookmarks" button

/////////////////////////////////////////////////////////////////////////////
Code Logical:

	Step1. Create a Visual Studio 2017 ASP.NET MVC Web Api Application project

	Step2. Clear unnecessary parts in the project, including: scripts for jquery, 
		   controller and view for account management...

	Step3: Add a custom controllers for search and bookmark handaling.
        
	Step4: Creating models for our useage.

	step5: Creating an api handaling classes.


Key components:

	* web.config file: contains all the necessary configuration information of 
	  this web application

	* global.asax: contains all the URL routing rules

	* HomeController class: contains the main application 
		navigation logic(such as default page and about page).

	*SearchController class: contains all search and bookmark functioality.

	*Model folder: contains all the models in this project, main model - "RepositoryItem".

	*Api folder: contains the logic handaling classes.
