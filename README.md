# Medical API
Developer: Luis Reales. 

This is a .NET Core API for managing medical data. It uses Clean Architecture , Docker and Dapper for data access.

## Prerequisites

- Docker Desktop installed on your machine.

## Setup and Running the Project

1. Clone the repository to your local machine.
2. Navigate to the root directory of the project in your terminal.
3. Run the following command to build and start the Docker containers:

    ```bash
    docker-compose up --build -d
    ```

    This command will build the Docker images for the API and the database, and then start the containers. The API will be available at `http://localhost:8088`.

## Populating the Database

The database is automatically populated with initial data when the Docker containers are started. This is done using a SQL script that is executed when the database container is started.

## Using the API

The API has endpoints for managing patients. Here are some examples:
- Example: http://localhost:8088/api/Patient/ListPatients
  
- `GET /ListPatients`: Get a list of all patients.

<img width="1042" alt="image" src="https://github.com/luisreales/medicalAPI/assets/48936231/560cde24-41a0-4fb2-b125-0099b89409e3">

## Stopping the Project

To stop the Docker containers, press `Ctrl+C` in your terminal, or use the Docker Desktop interface.

## Troubleshooting

If you encounter any issues while setting up or running the project, please check the Docker Desktop logs for any error messages. If you're still having trouble, feel free to open an issue on this repository.

## Project Overview

This project involves the creation of a REST API for managing medical data. There are four entities involved:

1. **Facilities**: A medical facility has a name and city.
2. **Patients**: A patient has a first name, last name, and age.
3. **Payers**: A payer (insurance company) has a name and city.
4. **Encounters**: A medical encounter is a patient's visit to a facility. To receive treatment, a patient must show an insurance card where the insurance company is specified.

## Business Requirements

The current business requirement is to implement a REST API endpoint that returns a list of patients. Each patient should have the following fields:

- Name in the "last name, first name" format (e.g., "Sinatra, Frank").
- A comma-separated list of cities where the patient has visited a facility (e.g., "Philadelphia, New York, Boston").
- A category: "A" if the patient's age is less than 16, "B" otherwise.

The list should only include patients who have had at least two encounters insured by companies from different cities, and patients with the smallest number of encounters should be shown first.

## Exception Handling

Implement global exception handling to return appropriate HTTP response codes and messages.

## Deliverables

- Dockerfile and docker-compose.yml to spin up a Postgres database and API service.
- SQL scripts to create tables and fill them with test data. There should be just enough test data to prove that the API fulfills all the patient list criteria.
- ASP.NET Web API project with necessary controllers, services, and models. Use Dapper as an ORM.
- A read-me file detailing how to set up and run the project, including how to populate the database initially. Ideally, it should be a one-click launch on Docker Desktop.

## Review Criteria

- Code organization and clarity.
- Complete fulfillment of business requirements.
- Adherence to REST principles and ASP.NET best practices.
- Convenience of launching the solution.

## Submission Guidelines

- Provide a Git repository link with your complete solution. Use any public Git service or https://git.epam.com.
- Be ready to discuss your design decisions and the reasoning behind them during the interview.
