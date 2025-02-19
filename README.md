# Stock Management Application


This application is designed to streamline the management of stock, suppliers, and operations within a business. The main components include three key classes: Supplier, Operation, and Good, which allow users to perform the following actions:

- **CRUD operations** (Create, Read, Update, Delete) for each entity (Supplier, Operation, Good).
- **Data validation** through ErrorProvider controls, validation events, and custom exceptions to ensure data integrity and avoid errors.
- **Serialization and deserialization** of at least one class to save and load data, ensuring persistence across sessions.
- **Export reports** as .txt files to document stock-related data.


### Features:

- **Menu Controls**: The interface includes the use of various menu controls such as MenuStrip, ToolStrip, StatusStrip, and ContextMenuStrip to ensure easy navigation and a clean user experience.

- **Custom Chart Creation**: A custom chart, drawn using the System.Drawing.Graphics class, represents meaningful stock statistics, offering users a visual understanding of their stock and operations without relying on built-in chart controls.

- **Database Integration**: The application uses a relational database to persist data for at least two entities, supporting full CRUD operations (Insert, Read, Update, Delete) on the data, ensuring accurate and persistent information.

- **UserControl**: A reusable UserControl, implemented in a separate project, provides useful functionality for the application and can be distributed and used in other projects.

- **Data Binding**: Individual fields within the app are data-bound, ensuring smooth and synchronized interaction between the UI and underlying data.

- **Print Preview**: The application offers the ability to preview and print documents related to stock management, providing users with the option to generate physical copies of reports.
