# NASA Rover API Project

## Projects
Solution is broken into multiple projects:

- **Tests** - these are the unit tests for testing the service wrapper
- **Utilities** - contains some helper classes
- **NasaAPIService** - this contains the wrapper that handles calling the Nasa Rover API, Test version of the API, date types for serializing JSON to
- **NasaMarsAPIImageViewer** - small WPF application for exercising the API

## Configuration

the NasaAPIService contains an appsettings.json with a few configuration settings that include:

- the Nasa Rover API Endpoint
- boolean switch to toggle for testing so you can run tests without exceeding the request limit on the API.  **To run against the service, IsTest needs to be set to false.**
- locations for the dates.txt file for reading in the dates to be tested


## Running the Application

Set the startup project to NasaMarsAPIImageViewer, run the project, select a date from the dropdown combobox, then click the "Get Image" button