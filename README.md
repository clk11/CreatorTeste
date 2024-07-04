# CreatorTeste

**Overview:**
CreatorTeste is a C# application designed to facilitate test creation and management. It features multiple forms for different functionalities such as user registration, test setup, and profile management. Due to its dependency on a large database, users must contact the project owner to obtain the necessary database files.

**Key Functionalities:**

1. **Form Management:**
   - **FormBunVenit:** The welcome form that serves as the entry point for the application.
   - **FormaAdaugareDomeniiNoi:** Allows administrators to add new domains or subjects for the tests.
   - **FormaAfisareProfil:** Displays the user profile with options to view and edit personal information.
   - **FormaEditareIntreabare:** Provides an interface for editing questions in the test database.
   - **FormaInregistrareAdministrator:** Handles the registration of new administrators, including input validation and profile picture upload.
   - **FormaIntrebare:** Manages the creation and modification of individual questions within a test.
   - **FormaLogareAdministrator:** The login form for administrators, ensuring secure access to administrative functionalities.
   - **FormaSetupTest:** Facilitates the setup of new tests, including specifying the number of questions and time limits.
   - **FormaVizualizareRezultate:** Displays the results of tests, allowing administrators to review and analyze performance.

2. **Database Interaction:**
   - Utilizes Entity Framework for database operations.
   - Contains models such as `t_Intrebari` (questions) and `t_Conturi` (accounts) for structured data storage.

3. **UI Components:**
   - Employs various Windows Forms controls such as `TabControl`, `Label`, `Button`, and `PictureBox`.
   - Custom components like `LollipopButton` and `LollipopTextBox` for enhanced UI/UX.

4. **Administrative Tools:**
   - Provides tools for administrators to manage tests, questions, and user accounts.
   - Includes features for adding, editing, and deleting records in the database.

**Setup Instructions:**
To run the application, download the source code from the [GitHub Repository](https://github.com/clk11/CreatorTeste) and contact me at trasca.robert2003@gmail.com to obtain the database.

**Languages:**
- C#

