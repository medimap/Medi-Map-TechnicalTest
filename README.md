# Medi-Map-TechnicalTest
Technical test for c# developers candidates
=======
# Welcome to Medi Map Technical Test!

Please duplicate the project to a private GitHub repository, and invite the reviewer to the repository when you have completed the assessment. We want to see good commit hygiene.

# Overview

Build a small web api to manage patients' data.

# Set up

1. Please create Ms Sql database on your local computer.
2. Find the sql script in the folder "sql" and execute it.
3. Find patient json data in the folder "data".
4. Use Postman or any other convenient tool for functional testing on your localhost. 

# Task

Extend and complete web api template with the code that will manage the patient data. 
Extend the sql code in the existing stored procedures and use them to interact with database (we do not expect candidates to use Entity Framework).
Using DI and following SOLID principals is highly beneficial.

The data from json should be processed based on the following business rules:

1. If a patient exists in db: 
   calculate BMI and create a medication administration record in the MedicationAdministration table.

  Formula for BMI = kg/m2 where kg is a person's weight in kilograms and m2 is their height in metres squared. 

2. If patient does not exist in db:
   create a patient record in the patient table, calculate bmi and create a medication administration record in the MedicationAdministration table.
   
3. If there are any errors a record with appropriate message should be logged in the ErrorLog table.

4. Support your business logic with unit testing. 

5. Export your final sql data from all the tables into a file and add to your solution

# Bonus Points

Extend the solution to manage allergies. Ivan Winter has severe allergy to Ativan. 
Extend your logic to prevent Ivan Winter being administered with Ativan. Extend sql design if required. 

# Stack
1.	Asp.Net Core Web api.
2.	Database: Ms Sql.