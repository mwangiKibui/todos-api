### Todos API

- Install the dependencies:

    ```bash
    dotnet restore
    ```

- Run the migrations:

     ```bash
     dotnet ef migrations add initialCreate
     ```

- Apply the migrations:

    ```bash
    dotnet ef database update
    ```

- Run the application:

    ```bash
    dotnet run
    ```