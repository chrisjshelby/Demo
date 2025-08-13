# Coding Demo: WebForms Contacts Page


## Features Implemented

- **WebForms UI**: A GridView displays contacts with columns for First Name, Last Name, Email, Phone, and Alternate Phone.
- **CRUD Operations**: The GridView supports creating, reading, updating, and deleting contacts. All event handlers are fully implemented in `Default.aspx.cs` and `Add.aspx.cs`.
- **Add Contact**: The 'Add Contact' button and form are fully implemented, supporting both new contact creation and editing existing contacts.
- **CSV Export**: The 'Export to CSV' button is fully implemented. The export merges Phone and Alternate Phone into a single column and repeats rows for alternate numbers as shown in the example.

## Requirements (from spec)

- **Create** new contacts with a form. The form must include:
    - First Name (required)
    - Last Name (required)
    - Email (required)
    - Phone (required)
    - Alternate Phone (optional)
- **Read** and display the list of contacts in a GridView.
- **Update** the details of an existing contact.
- **Delete** a contact.
- **Export** the data to a CSV file. When exporting:
    - Merge the Phone and Alternate Phone into a single column.
    - Only repeat the contact row for contacts who provided an Alternate Phone number.
    - Example CSV output:

      ```
      1 Adams, John 111-222-3333
      2 Bryant, Lucy 111-222-3334
      2 Bryant, Lucy 111-222-3335
      3 Cooper, David 111-222-3336
      ```


## Implementation Notes

- All fields are required except for Alternate Phone.
- The GridView supports editing and deleting contacts.
- The Add Contact form supports both adding and editing contacts.
- The CSV export button exports the data in the required format, merging phone numbers as specified.
- Data access and business logic are implemented using Entity Framework in `DemoContext` and related files.

---

_Updated by Co-pilot._