
# MVCAssignment - Job Listing Application

## Overview
This is a job listing application built using ASP.NET Core MVC. The application allows users to:
- View a list of job listings.
- View detailed information about a specific job listing.
- Edit existing job listings, including the title, company, location, job type, and posted date.

## Features
- **View Job Listings**: Display a list of job listings with title, company, and job type.
- **Job Details**: Click on a job to view more details about it.
- **Edit Job Listings**: Modify job listing details and save changes.
- **Job Type Dropdown**: Select the job type from a dropdown (Full-time, Part-time, Remote, Contract).
- **Client-side Form Validation**: Use JavaScript for validating the job listing form before submission.

## Requirements
To run this application, you need:
- **.NET Core SDK 5.0** or later.
- **Visual Studio** or **Visual Studio Code** (optional, but recommended for development).

## Installation

### Step 1: Clone the repository
To get started, clone the repository to your local machine:
```bash
git clone https://github.com/your-username/MVCAssignment.git
cd MVCAssignment
```

### Step 2: Restore Dependencies
Run the following command to restore the necessary NuGet packages:
```bash
dotnet restore
```

### Step 3: Build the Project
To build the project, execute:
```bash
dotnet build
```

### Step 4: Run the Application
To run the application locally, use the following command:
```bash
dotnet run
```

Once the application is running, open a browser and visit `http://localhost:5000` to view the app.

## Project Structure

- **Controllers/JobController.cs**: The controller that handles the logic for displaying job listings, viewing details, and editing jobs.
- **Models/JobListing.cs**: The model representing a job listing with properties like `Title`, `Company`, `Location`, `Type`, and `PostedDate`.
- **Views/Job/Index.cshtml**: Displays a list of job listings in a table format.
- **Views/Job/Details.cshtml**: Displays detailed information about a selected job listing.
- **Views/Job/Edit.cshtml**: Contains a form to edit the details of a job listing.
- **wwwroot/css/styles.css**: Contains custom CSS for styling the application.
- **wwwroot/js/validation.js**: JavaScript file for performing client-side form validation.

## Form Validation

The form on the **Edit Job Listing** page includes client-side validation using JavaScript. The following fields are validated:

- **Title**: The title of the job is required.
- **Company**: The company name is required.
- **Location**: The job location is required.
- **Job Type**: The job type must be selected from the dropdown.
- **Posted Date**: The posted date must follow the `yyyy-MM-dd` format.

### JavaScript Validation
A script located in `wwwroot/js/validation.js` ensures the form fields are filled out correctly before submission. The user is prompted with error messages if any field is left empty or invalid.

## Notes
- This application uses **ASP.NET Core MVC**, which follows the MVC (Model-View-Controller) design pattern.
- The **JobType** enum allows users to select one of the following options: Full-time, Part-time, Remote, or Contract.
- Job listings are hardcoded into the application and are not persisted to a database.
- Changes made to job listings are not saved permanently (no database integration).

## License
This project is licensed under the **MIT License**. See the [LICENSE](LICENSE) file for more details.

## Acknowledgments
- **ASP.NET Core MVC**: Framework used to build this application.
- **JavaScript**: Used for client-side form validation.


### Key Sections:
1. **Overview**: Describes the purpose and functionality of the application.
2. **Features**: Lists the key features of the app.
3. **Requirements**: Specifies the necessary software and tools.
4. **Installation**: Provides detailed steps for cloning the repo, restoring dependencies, building, and running the project.
5. **Project Structure**: Describes the main files and folders in the project.
6. **Form Validation**: Explains the client-side validation process for the form.
7. **License**: Includes information about licensing (you can add the actual license file if it's open-source).
8. **Acknowledgments**: Recognizes the tools and frameworks used to build the project.
