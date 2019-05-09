# Example of windows docker configuration for sql server and dotnet mvc

Components:
- Database server, using sql server 2017 express
- Web server, using IIS and dotnet 4.5

The site shows how is the interaction of the web server with the sql server.

## Instructions ##

- Clone the repository
- Open the solution on visual studio 2017
- Right click on the project and select publish
- Publish to the already selected configuration (relative folder)
- Go to the docker folder, where is located the .yml file
- Run docker-compose up -d to run the site. It can take several minutes because it needs to download the composer dependencies
- Open the browser and navigate to http://localhost:8000

To stop the containers, run docker-compose down.

## Notes ##

The database component, has a folder containing a database instance that is attached when the container starts. 

If you want to run the site using visual studio, just run the docker composer and change the connection string on the web.config file. The local server can be accessed using localhost and port 3333. The connection is already created but it is commented.

I included a copy of the site deployed on site_bin folder. You can unzip it on the Docker/site folder in case you want to test it without Visual Studio.

