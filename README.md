
# Coding Demo: Contacts Management

## Requirements


Create a user interface that allows users to:

- **Create** new contacts with a form. The form must include:
	- First Name (required)
	- Last Name (required)
	- Email (required)
	- Phone (required)
	- Alternate Phone (optional)

- **Read** and display the list of contacts in a table or grid.

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

## Notes

- All fields are required except for Alternate Phone.
- The table or grid should support editing and deleting contacts.
- The CSV export should follow the example format above.


## Technologies

- [ASP.NET Classic Implementation](./asp.net%20classic/)  
	See the [ASP.NET Classic README](./asp.net%20classic/README.md) for details on the technology-specific implementation.

_README created and updated by Copilot._