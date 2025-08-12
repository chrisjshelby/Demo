# Coding Demo: WebForms Contacts Page

## Features Implemented

- **WebForms UI**: A GridView displays contacts with columns for First Name, Last Name, Email, Phone, and Alternate Phone.
- **CRUD Operations**: The GridView supports editing and deleting contacts. Event handlers for editing, updating, deleting, and canceling edits are scaffolded in `Default.aspx.cs`.
- **Add Contact**: An 'Add Contact' button is present (implementation pending).
- **CSV Export**: An 'Export to CSV' button is present (implementation pending). The export should merge Phone and Alternate Phone into a single column and repeat rows for alternate numbers as shown in the example.

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
- The GridView supports editing and deleting contacts (event handlers are scaffolded).
- The CSV export button is present; implementation should follow the format above.
- Data access and business logic are not yet implemented; event handlers in `Default.aspx.cs` are placeholders.

---

_Updated by Co-pilot._