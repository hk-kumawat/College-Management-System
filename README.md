<a id="readme-top"></a>

# College-Management-System
![best-erp-cms-main-banner-final](https://github.com/user-attachments/assets/481b5261-9ede-4ee9-8359-4da201a963bb)


## Overview:

The College Management System is a robust Windows desktop application designed to modernize academic administration. Built with **C# .NET** and **Windows Forms**, it features role-based access control, real-time database operations with **SQL Server**, and secure authentication via **Firebase**. Administrators can manage student admissions, faculty records, fee payments, and students' academic progress. Ideal for institutions seeking to digitize their operations with a secure, scalable solution.

<br>

### Learning Journey 🗺️

Building the College Management System was a multifaceted learning experience that expanded my skills across various domains:

- **Desktop Application Development:**
  - **Windows Forms & C#:** I gained in-depth knowledge of building a robust desktop application using Windows Forms. The project taught me the importance of a modular design where each form (e.g., Dashboard, New Admission, Register) handles specific functionalities.
  
- **Database Integration & Management:**
  - **SQL Server:** Setting up the college database and writing efficient SQL queries deepened my understanding of relational database management. I learned to manage CRUD operations and ensure data integrity.
  
- **Cloud Integration:**
  - **Firebase:** Integrating Firebase for user registration and login broadened my perspective on combining local and cloud-based systems, ensuring secure data handling and real-time updates.
  
- **User Interface Design & Experience:**
  - **Form Navigation & Validation:** Designing intuitive forms with clear error messages and input validation improved my UI/UX skills, making the system both user-friendly and robust.
  
- **Challenges & Growth:**
  - **Error Handling:** Encountering and resolving issues—like connection string configurations and data validation errors—helped me refine my troubleshooting skills.
  - **Balancing Complexity & Usability:** I learned to strike a balance between offering rich functionality and maintaining a clean, accessible interface.
  - **Collaborative Development:** Managing a multi-module project enhanced my ability to organize code effectively, paving the way for future collaborative and scalable projects.

This project is not just an application—it’s a testament to continuous learning and the power of integrating various technologies to solve real-world problems in educational administration.


<br>

## Table of Contents

1. [Overview](#overview)
2. [Features](#features)
3. [Installation](#installation)
4. [Usage](#usage)
5. [Technologies Used](#technologies-used)
6. [Database Schema](#database-schema)
7. [Directory Structure](#directory-structure)
8. [Future Enhancements](#Future-Enhancements)
9. [Contributing](#contributing)
10. [License](#license)
11. [Contact](#contact)

<br>


## Features🌟

### Authentication 🔐
- Secure login with Firebase integration
- Password-protected user registration

### Student Management 👨‍🎓
- New student admission processing
- Individual profile management
- Semester upgrade system
- Student search and removal capabilities

### Financial Management 💰
- Fee collection and tracking
- Payment history management
- Real-time status updates

### Teacher Management 👨‍🏫
- Teacher registration and profile management
- Subject specialization tracking
- Performance monitoring

### Administration 📊
- Interactive dashboard
- Comprehensive reporting system
- Data backup and security measures
- Real-time database synchronization

  <br>

  
### Installation🛠

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/hk-kumawat/College-Management-System.git
   cd hk-kumawat-college-management-system
   ```
   
2. **Open the Solution:**
   - Open `CollageManagementSystem.sln` in **Visual Studio**.

3. **Restore NuGet Packages:**
   - Visual Studio should auto-restore packages. If not, open the **Package Manager Console** and run:
     ```powershell
     Update-Package -reinstall
     ```
     
4. **Configure the Database:**
   - Ensure your **SQL Server** instance is running.
   - The connection string in your code (e.g., in `Form1.cs`, `New_Admission.cs`, etc.) is set to:
     ```
     data source=HARSHAL\SQLEXPRESS; database=college; integrated security=True
     ```
   - Create the `college` database in your SQL Server or update the connection strings in the code files to match your environment.
   - Run any necessary SQL scripts to set up tables for admissions, fees, teacher data, etc.

5. **Configure Firebase Integration:**
   - Update the `FBConfig.cs` file with your Firebase URL.
   - Ensure your Firebase project is set up and the necessary keys are available.

6. **Build and Run:**
   - Set `CollageManagementSystem` as the startup project.
   - Press **F5** or click **Start** to compile and launch the application.

7. **Optional – Use Dev Container:**
   - If you wish to use the pre-configured containerized environment, open the project in your compatible IDE using the `.devcontainer/devcontainer.json` configuration.

<br>


### Usage🚀

**Launching the Application:**
   On startup, a **SplashScreen** appears briefly, followed by the **Login** form (`Form1.cs`).
    <br>
    
![Screenshot 2023-08-05 170657](https://github.com/user-attachments/assets/d47e1510-46fe-4a2d-ac83-3fd81a771af7)


##

**User Registration & Login:**

<br>

**Register:**  New users can sign up using the **Register** form, where their data is saved to Firebase.
 
![Screenshot 2023-08-05 170855](https://github.com/user-attachments/assets/a7c527e1-290f-491c-b86e-05d8a6309090)

  <br>

**Login:** Existing users enter their credentials on the Login form. Successful authentication navigates to the Dashboard.
    <br>
    
![Screenshot 2023-08-05 173941](https://github.com/user-attachments/assets/8d949fa6-82a5-47ee-a717-1de1fbb30d85)
##

**Dashboard Navigation:**
  - Serves as the main landing page for users upon successful login to the College Management System.
    
  - The **Dashboard** serves as a central hub, offering access to various modules:
    <br>

![Screenshot 2023-08-05 174151](https://github.com/user-attachments/assets/8d4b26c6-1826-4c7b-be4b-d4733efa3773)
##
1). **New Admission:** Add new student records.
<br>

![Screenshot 2023-08-05 174320](https://github.com/user-attachments/assets/1db17796-c58e-40e7-b59c-daeda8ed4fb6)
##
2). **Upgrade Semester:** Update a student’s semester.
<br>

![Screenshot 2023-08-05 174458](https://github.com/user-attachments/assets/d4a268dc-f613-46fa-aa94-e96dd13bf402)
##
3). **Fees:** Allows to manages the collection and tracking of fees from students.
<br>

![Screenshot 2023-08-05 174537](https://github.com/user-attachments/assets/41787269-ec2e-43fc-857c-b3f15a04ab26)
##
4). **Search Student:** Allows users to search for specific student using student Registration ID.
<br>

![Screenshot 2023-08-05 174713](https://github.com/user-attachments/assets/13172614-81eb-4191-abaf-49d1273d7f68)
##
5). **Student Individual Details:** Displays comprehensive information about an individual student.
<br>

![Screenshot 2023-08-05 174758](https://github.com/user-attachments/assets/a8c7a8d1-d141-47ae-8f1f-ef9482d96b54)
##
6). **Add Teacher:**
Allows users to add a new teacher along with their personal information and assigned subjects.
<br>

![Screenshot 2023-08-05 174857](https://github.com/user-attachments/assets/8e504818-3093-412a-8783-465d8835560d)
##
7). **Search Teacher:**
Provides a search feature to find specific teacher based on Registration ID.
<br>

![Screenshot 2023-08-05 174943](https://github.com/user-attachments/assets/89ad1d78-f480-4859-8779-60d3a1b2cc50)
##
8). **Remove Student:**
Handles the process of removing a student from the college records.
<br>

![Screenshot 2023-08-05 175019](https://github.com/user-attachments/assets/68a2e84a-e9c9-4804-a60d-59958dfecbcb)
##
9). **About Us:**
Presents essential information about the college or institution.
<br>

![Screenshot 2025-02-15 182017](https://github.com/user-attachments/assets/b7021a56-b88a-4a51-96f4-f2a91c626902)

    

- **Data Management:**
  - Each module (e.g., `New_Admission.cs`, `Fees.cs`, `Search_Student.cs`) is designed to perform CRUD operations:
    - **Input Validation:** Forms include error-checking (e.g., non-empty fields, strong password criteria).
    - **Database Operations:** Data is inserted, updated, or retrieved using SQL queries and Firebase integration.
    - **Navigation:** User actions (e.g., registering, upgrading semester, fee submission) trigger appropriate forms and notifications.

<br>


## Technologies Used💻

- **Programming Language:**  
  - C#
  
- **Framework:**  
  - .NET Framework (Windows Forms)
  
- **Database:**  
  - SQL Server
  
- **Cloud Integration:**  
  - Firebase (for user registration and authentication)
  
- **Development Environment:**  
  - Visual Studio  
  - .devcontainer for a containerized development environment (optional)

<br>

## Database Schema📊

### Key Tables
1. **New_Admission**  
   - NAID (PK), fname, mname, gender, dob, mobile, email, semester, prog, duration

2. **Fees**  
   - FeeID (PK), NAID (FK), amount, payment_date

3. **Teacher**  
   - tID (PK), fname, gender, dob, mobile, email, prog, yer
  
<br>


## Directory Structure 📁

```plaintext
hk-kumawat-college-management-system/
├── README.md                   # Project documentation
├── CollageManagementSystem.sln  # Visual Studio solution file
└── CollageManagementSystem/     # Main project folder
    ├── About_Us.*              # About Us module files
    ├── Add_Teacher.*           # Teacher addition module files
    ├── App.config              # Application configuration
    ├── Dashboard.*             # Dashboard module files
    ├── Fees.*                  # Fees management module files
    ├── Form1.*                 # Login form files
    ├── New_Admission.*         # New Admission module files
    ├── Register.*              # User registration module files
    ├── Remove_Student.*        # Remove Student module files
    ├── Search_Student.*        # Search Student module files
    ├── Search_Teacher.*        # Search Teacher module files
    ├── Student_Individual_Detail.*  # Individual student detail files
    ├── Upgrade_Semester.*      # Semester upgrade module files
    ├── packages.config         # Package configuration
    ├── Properties/             # Project properties and resources
    └── Resources/              # Additional resource files
```

<br>


## Future Enhancements🚀

- **Modular Reporting:**  
  Integrate advanced reporting features for detailed analytics on admissions and fee collections.
- **Cloud-Based Database Integration:**  
  Migrate to a cloud database for improved scalability and remote access.
- **Role-Based Access Control:**  
  Implement user roles and permissions to enhance security and data management.
- **Automated Notifications:**  
  Add SMS or email notifications for important events like registration or fee submission.
- **Mobile App Integration:**  
  Develop a mobile version of the application for on-the-go management.
- **Data Visualization Dashboards:**  
  Incorporate interactive dashboards for real-time analytics on college performance.

<br>


## Contributing🤝
Contributions make the open source community such an amazing place to learn, inspire, and create. 🙌 Any contributions you make are greatly appreciated! 😊

Have an idea to improve this project? Go ahead and fork the repo to create a pull request, or open an issue with the tag **"enhancement"**. Don't forget to give the project a star! ⭐ Thanks again! 🙏

<br>

1. **Fork** the repository.

2. **Create** a new branch:
   ```bash
   git checkout -b feature/YourFeatureName
   ```

3. **Commit** your changes with a descriptive message.

4. **Push** to your branch:
   ```bash
   git push origin feature/YourFeatureName
   ```

5. **Open** a Pull Request detailing your enhancements or bug fixes.

<br> 


## License📝

This project is licensed under the **MIT License** — see the [LICENSE](./LICENSE) file for details.

<br>


## Contact

### 📬 Get in Touch!
Feel free to reach out for collaborations or questions:

- [![GitHub](https://img.shields.io/badge/GitHub-hk--kumawat-blue?logo=github)](https://github.com/hk-kumawat) 💻 — Explore my projects and contributions.
- [![LinkedIn](https://img.shields.io/badge/LinkedIn-Harshal%20Kumawat-blue?logo=linkedin)](https://www.linkedin.com/in/harshal-kumawat/) 🌐 — Let's connect professionally.
- [![Email](https://img.shields.io/badge/Email-harshalkumawat100@gmail.com-blue?logo=gmail)](mailto:harshalkumawat100@gmail.com) 📧 — Send me an email for discussions and queries.

<br>

## Thanks for exploring—happy managing! 🏫

> "A well-managed system builds a well-managed future" – Harshal Kumawat

<p align="right">
  (<a href="#readme-top">back to top</a>)
</p>





