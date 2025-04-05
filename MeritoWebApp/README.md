# MeritoWebApp

MeritoWebApp is a web application built using ASP.NET Core. This application serves as a template for creating web applications with a structured approach, utilizing the MVC (Model-View-Controller) design pattern.

## Project Structure

- **Controllers**: Contains the controllers that handle user requests and return responses.
  - `HomeController.cs`: Manages the home page and related actions.

- **Models**: Contains the data models used in the application.
  - `ExampleModel.cs`: Defines the properties used in the application.

- **Views**: Contains the Razor views that render the user interface.
  - **Home**: Contains views related to the home page.
    - `Index.cshtml`: The main view for the home page.
  - **Shared**: Contains shared views used across the application.
    - `_Layout.cshtml`: The layout view that defines the common structure for the pages.

- **wwwroot**: Contains static files such as CSS, JavaScript, and third-party libraries.
  - **css**: Contains stylesheets for the application.
    - `site.css`: The main stylesheet for the application.
  - **js**: Contains JavaScript files for client-side functionality.
    - `site.js`: The main JavaScript file for the application.
  - **lib**: Intended for third-party libraries and dependencies.

- **Configuration Files**:
  - `appsettings.json`: Contains configuration settings for the application.
  - `Program.cs`: The entry point of the application.
  - `Startup.cs`: Configures services and the application's request pipeline.

## Getting Started

To run the application, ensure you have the .NET SDK installed. Clone the repository and navigate to the project directory. Use the following command to run the application:

```
dotnet run
```

Visit `http://localhost:5000` in your web browser to view the application.

## Contributing

Contributions are welcome! Please feel free to submit a pull request or open an issue for any enhancements or bug fixes.

## License

This project is licensed under the MIT License. See the LICENSE file for more details.