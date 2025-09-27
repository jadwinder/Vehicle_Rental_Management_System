# Vehicle Rental Management System (VRMS)

A **Vehicle Rental Management System (VRMS)** is a desktop application built using **VB.Net** with an **MS Access database** backend. This project automates vehicle rental operations, including vehicle management, customer booking, billing, and rental history tracking. It provides a user-friendly interface for administrators, staff, and customers, ensuring smooth and efficient rental operations.

---

## **Features**

The system includes the following key functionalities:

### **Admin Features**
- Login and secure authentication.
- Add, update, or delete vehicle details (registration number, fuel type, AC/non-AC, category, seats, rent, etc.).
- View and manage all bookings.
- Check upcoming and past bookings.
- Generate reports for vehicles and rentals.

### **Customer Booking Features**
- Book vehicles based on availability.
- Input customer details for bookings.
- Automatic rent calculation based on duration and vehicle type.
- View booking history and upcoming reservations.

### **System Features**
- Validation of all input fields using **Regex** to prevent incorrect data entry.
- Database connectivity with **MS Access**.
- Easy-to-use **dashboard** for navigation.
- Secure password management and reset functionality.

---

## **Technologies Used**

- **Frontend & Backend:** VB.Net  
- **Database:** Microsoft Access  
- **Development Environment:** Visual Studio  
- **Other Tools:** Regex validation for form inputs  

---

## **Database Setup**

Before running the Vehicle Rental Management System, it is important to configure the database connection properly.  

The project uses an **MS Access database** located in your system. You need to update the path of the database file in the connection string to match the location where you have saved the database on your computer.  

In the project, the connection string is defined in `connectionStr.vb`:

```vb
Public Class connectionStr
    Public Shared Function con_str()
        ' Update this path to the location of your vehicle_database.mdb file
        Dim conn_str As String = "E:\jadwinder\Tech\Project\Vehicle_Rental\Final\WindowsApplication1\vehicle_database.mdb"
        Return conn_str
    End Function
End Class
```

## Steps to update the path:
- Locate the vehicle_database.mdb file on your system.
- Open `connectionStr.vb` .
- Replace the existing path with the full path to your database file.
- Save the file and rebuild the project.

---

## **Testing**

Testing ensures the system works reliably, securely, and efficiently:

1. **Functional Testing**:  
   Ensures all features like adding vehicles, booking, billing, and updating records work correctly.

2. **Performance Testing**:  
   Checks system responsiveness under heavy usage (multiple bookings at the same time).

3. **Security Testing**:  
   Protects customer and vehicle data using authentication, access control, and validation checks.

4. **User Acceptance Testing (UAT)**:  
   End-users test the system to ensure usability, accuracy, and overall satisfaction.

**Importance of Testing:**  
- Ensures accurate operations, prevents errors in bookings or billing.  
- Protects sensitive customer and vehicle data.  
- Improves system efficiency and user satisfaction.  

---

## **How to Run**

1. Clone the repository:  
   ```bash
   git clone https://github.com/jadwinder/Vehicle_Rental_Management_System.git


## **Screenshots**
<img width="845" height="511" alt="update" src="https://github.com/user-attachments/assets/a1194f1f-27e2-48be-9183-00539ee8776f" />
<img width="782" height="495" alt="upcoming" src="https://github.com/user-attachments/assets/a743ae07-7f23-4ace-a502-b2a2ed409144" />
<img width="848" height="516" alt="signup" src="https://github.com/user-attachments/assets/0184b8d9-8e3c-43ce-b022-5eab6b8f1b61" />
<img width="846" height="514" alt="search" src="https://github.com/user-attachments/assets/a3299285-efaf-41e8-8466-d0df4e4795c8" />
<img width="846" height="516" alt="logout" src="https://github.com/user-attachments/assets/8b1c2872-e2be-4250-9954-9775101fbb45" />
<img width="849" height="517" alt="login" src="https://github.com/user-attachments/assets/5bc423c7-7494-408e-a039-69c6bd50e8ac" />
<img width="842" height="510" alt="loader" src="https://github.com/user-attachments/assets/30843e3e-88c2-40b8-ad19-04b9353c8a49" />
<img width="780" height="496" alt="history" src="https://github.com/user-attachments/assets/fc666b89-bb4e-47c7-877f-d2b6f291abfc" />
<img width="845" height="517" alt="delete" src="https://github.com/user-attachments/assets/e64ef08b-8b2e-49ed-98a1-ec955929aa5f" />
<img width="843" height="516" alt="confirmpass" src="https://github.com/user-attachments/assets/d7d404c7-5497-46de-a274-0a24538baf4a" />
<img width="845" height="516" alt="changepas" src="https://github.com/user-attachments/assets/41d15c7c-eb26-4c3b-8bb9-b6da5614c1c1" />
<img width="845" height="515" alt="booking" src="https://github.com/user-attachments/assets/04b39508-f1e7-49f3-baf5-abde7c0a43dc" />
<img width="850" height="519" alt="add" src="https://github.com/user-attachments/assets/963666ec-5e3c-4370-ac49-173b56faa8b2" />
<img width="844" height="511" alt="about" src="https://github.com/user-attachments/assets/619d2b49-638a-45f5-8b04-d080c6fdad6d" />

---

## **Validations**

<img width="841" height="515" alt="rc" src="https://github.com/user-attachments/assets/7905a868-405c-4a7c-abdd-4bf81a4be0b0" />
<img width="848" height="517" alt="pass" src="https://github.com/user-attachments/assets/81a80661-8b10-4e8f-85b5-f9689e1e7c9c" />
<img width="848" height="516" alt="login_1" src="https://github.com/user-attachments/assets/07ba4831-682a-46e8-8e1b-93a7ac96fca3" />
<img width="843" height="513" alt="changepass" src="https://github.com/user-attachments/assets/c6a72c19-acf3-4830-82d7-cc45b14eea53" />
<img width="847" height="512" alt="booking" src="https://github.com/user-attachments/assets/de2c235d-3cf7-473b-a279-9ecd61b18b21" />






