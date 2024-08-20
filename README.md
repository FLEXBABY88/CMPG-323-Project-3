# cmpg-323-Project-3
# Table of Content
1. [Introduction](#Introduction)
2. [Link to Project](#Link)
3. [Key Objectives](#Objectives) 
4. [Project Structure](#Architecture)
5. [User Account Creation](#Activation)
6. [Application Use](#Usage)
7. [References](#references)


# Introduction
This project involves upgrading an existing ASP.NET Core MVC web application by improving its architecture, implementing solid coding principles, and integrating design patterns tailored to the specific needs of the project. The objective is to create a more scalable, maintainable, and high-quality application.

![image](https://github.com/FLEXBABY88/CMPG-323-Project-3/blob/master/Screenshot%202024-08-19%20201549.png)

# Link
Access at: [TelemetryPortal_MVC](https://42019222api20240812160846.azurewebsites.net)

The application provides CRUD (Create, Read, Update, Delete) capabilities for project and client data, offering a comprehensive and scalable solution for handling business activities.

## Objectives
- Understand the existing architecture: Get a thorough understanding of the current codebase, including its structure, data flow, and technologies used.
- Enhance the application: Add new features or improve existing functionality to increase the application's capabilities.
- Apply best practices: Implement coding principles that promote maintainability, scalability, and security throughout the project.
- Incorporate design patterns: Utilize appropriate design patterns to enhance the application's architecture, ensuring it meets the required standards for software development.

## Here is a table outlining the goals of the project:
| Goal      | Description|
|-----------|------------ | 
|Enhance the Existing Web Application| Improve and expand the functionality of the web application, focusing on CRUD operations.|
|Understand and Apply Architectural Patterns| Gain a deep understanding of the architecture and apply patterns for scalability and maintainability.|
|Implement Best Coding Practices| Apply clean code principles and SOLID design to improve the quality of the code.|
|Incorporate Design Patterns| Use design patterns like Repository, Dependency Injection, etc., for system robustness.|
|Improve Application Security| Ensure proper authentication and authorization mechanisms, potentially using JWT. |
|Optimize for Performance and Scalability| Enhance performance and scalability to handle growing data and user loads efficiently.|
|Leverage Cloud Technologies (Azure) | Utilize Azure services for deployment, management, and scalability of the application.|
|Provide a Seamless User Experience | Ensure the application is user-friendly, responsive, and provides a smooth experience.|

## Architecture
- Mvc architecture: The application follows the Model-View-Controller pattern, separating concerns and improving maintainability.
- CRUD operations: The application provides functionality to efficiently manage project and client data.
- Authentication and security: Secure authentication mechanisms are implemented to protect sensitive information.
  
## Project Requirements
- Functional requirements: The system must perform CRUD operations on project and client data, ensuring that these operations are secure and reliable.
- Non-functional requirements: The application should adhere to best practices concerning performance, scalability, and security. The code should be organized to facilitate easy maintenance and updates in the future.

## Activation
+ When the application is launched, users are greeted with a welcome screen or directed to the home page. This page presents various options for exploration, as well as the ability to log in or register a new account.
+ ### To register a new account, follow these steps:
1. Navigate to the home page of the application.
2. Locate and click the "Register" option.
3. Enter the required registration information, such as your email address and password.
4. Verify that all information is accurately entered.
5. Click the "Register" button to complete the account creation process.
- Upon successful registration you can log in to the application using your newly created credentials.
  - In the login process, you may notice a "Remember Me" checkbox. By selecting this option, you instruct the application to remember your username or email address and password for future sessions, alleviating the need to re-enter this information every time you visit the website. However, it is recommended to exercise caution when using this feature, especially when accessing the application from shared or public devices.
       
## Usage 
### 1.Project management: 
- Users can create, read, update, and delete project data, including details such as names, descriptions, statuses, start/end dates, and assigned clients.
### 2.Client management:
- Users can manage client information, including names, contact details, and associated projects. They can add new clients, update information, or remove clients when needed.
### 3.Tracking and reporting:
- The application allows users to track active projects and clients, generate reports or visualizations to aid in decision-making related to resource allocation, deadlines, and project performance.
### 4.User authentication and authorization:
- Secure login mechanisms are implemented, possibly using JWT authentication.
### 5.Scalable Deployment:
- The application will be deployed on Azure, making it easily accessible from anywhere and ensuring that it can handle an increasing number of users or data entries as the organization grows.
### 6.Integration with Azure Cloud Services:
- The project can integrate with Azure databases, storage, and other services, allowing users to manage their data securely and at scale. This cloud integration offers flexibility in data handling and application management.
### 7.Enhanced User Experience:
- A seamless, user-friendly interface will help users efficiently manage projects and clients with minimal training or prior experience with the system.

# Reference list
