# Medical API

This is a .NET Core API for managing medical data. It uses Clean Architecture , Docker and Dapper for data access.

## Prerequisites

- Docker Desktop installed on your machine.

## Setup and Running the Project

1. Clone the repository to your local machine.
2. Navigate to the root directory of the project in your terminal.
3. Run the following command to build and start the Docker containers:

    ```bash
    docker-compose up --build
    ```

    This command will build the Docker images for the API and the database, and then start the containers. The API will be available at `http://localhost:8088`.

## Populating the Database

The database is automatically populated with initial data when the Docker containers are started. This is done using a SQL script that is executed when the database container is started.

## Using the API

The API has endpoints for managing patients. Here are some examples:
- Example: http://localhost:8088/api/Patient/ListPatients
  
- `GET /ListPatients`: Get a list of all patients.

Add more endpoint descriptions as needed...

## Stopping the Project

To stop the Docker containers, press `Ctrl+C` in your terminal, or use the Docker Desktop interface.

## Troubleshooting

If you encounter any issues while setting up or running the project, please check the Docker Desktop logs for any error messages. If you're still having trouble, feel free to open an issue on this repository.