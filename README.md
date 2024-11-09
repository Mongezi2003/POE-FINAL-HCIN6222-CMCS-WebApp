# POE-FINAL-HCIN6222-CMCS-WebApp
An ASP.NET Core web application for automating the Contract Monthly Claim System (CMCS), designed to streamline claim submissions, verification, and payment processes for lecturers and HR.
# Contract Monthly Claim System (CMCS)

## Overview
The Contract Monthly Claim System (CMCS) is an ASP.NET Core web application developed to automate and streamline the process of submitting, verifying, and processing claims for lecturers. The system includes three main views: **Lecturer**, **Programme Coordinator/Academic Manager**, and **HR**, each equipped with specific features to facilitate efficient claim management.

## Features
### Lecturer View
- **Submit Claims**: Lecturers can submit their work hours and hourly rate to calculate claim amounts automatically.
- **Supporting Documents**: Upload files related to claims for verification.
  
### Programme Coordinator/Academic Manager View
- **Claim Verification**: Automated checks against hours worked and hourly rates to verify claims.
- **Approval Workflow**: Streamlined approval processes for easy claim management.

### HR View
- **Claim Processing**: Generate summaries of approved claims for payment.
- **Lecturer Data Management**: Update lecturer details as needed.

## Technologies Used
- **ASP.NET Core MVC**: Backend framework for web application structure.
- **PostgreSQL**: Database management for claim and lecturer data.
- **Entity Framework Core**: Object-relational mapping for database operations.
- **ASP.NET Identity**: Authentication and authorization.
- **jQuery**: Client-side scripting for validation and interactivity.

## Setup Instructions

### Prerequisites
1. **.NET Core SDK** - Version 5.0 or higher.
2. **PostgreSQL** - Set up PostgreSQL on your machine and create a database named `cmcs_db`.
3. **pgAdmin** - Optional, for easier PostgreSQL database management.

### Installation

1. **Clone the Repository**:

   ```bash
   git clone https://github.com/yourusername/Contract-Monthly-Claim-System.git
   cd Contract-Monthly-Claim-System/src
