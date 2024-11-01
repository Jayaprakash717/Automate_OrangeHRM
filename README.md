# OrangeHRM Automation Project

This project is a C# automation framework designed to test various pages and functionalities of the OrangeHRM application through POM model. The framework automates core workflows within the application, including the Admin, Login, My Info, and PIM modules. It uses a `UnitTest1` runner class to execute test cases, generate reports, and capture screenshots of test results.

## Features

- **Admin Page**: Automates actions on the Admin page, including user management and configuration options.
- **Admin Search**: Provides automated search functionalities on the Admin page to locate specific user profiles or settings.
- **Login Page**: Automates login scenarios to verify authentication processes.
- **My Info**: Tests functionality under the employee self-service section to ensure accurate personal data access and modifications.
- **PIM (Personnel Information Management)**: Automates PIM workflows, verifying that employee data is handled and displayed correctly.
- **Reports**: Generates detailed reports of the test executions and saves them for reference.
- **Screenshot Capture**: Captures screenshots upon test failures and saves them for debugging.

## Project Structure

- **Pages**: Contains page objects representing different sections of the OrangeHRM application.
- **JSON Configuration**: Uses a JSON file to store test data and configuration settings, enabling easier maintenance and flexibility.
- **Base Page**: A parent page that includes common methods and actions, reducing redundancy across page objects.
- **Runner Class**: `UnitTest1` serves as the main test runner, executing all test cases and coordinating interactions with the OrangeHRM pages.

## Usage

- **Running Tests**: Use Visual Studio’s Test Explorer or the command line to run tests via `UnitTest1`.
- **Viewing Reports**: Access the generated reports after test execution to review results and insights.
- **Screenshots**: Review screenshots in the specified directory to troubleshoot and debug test failures.
