

# C# Address Book

#### Web apps with Nancy / Object-Oriented C# Independent Project.

_**By Vichitra Pool (Note) on September 11th, 2016_

## Description

##### _Using Nancy, make an address book where you can store contact information for people you know. Use Razor to display information on each page._


## Behavior Driven Development
|Behavior | input | output|
|--- | :---: | :---: |
|user can view all contacts on homepage page | click view all contacts click here link | view_all_contacts page will open and display the list of all saved contacts.
|user can add new contact to the address book from homepage | click add new contact link | add_new_contact form page will open.
|Allow user to input name in uppercase letters, the output will be uppercase | ADAM | ADAM
|Allow user to input name in lowercase letters, the output will be uppercase| adam | ADAM
|Allow user to input number >=0 for phone number | 1 | 1
|user can save the contact to the list| click save button |contact_created page will open and show "You created a contact!", the new-added contact; name, phone number and address are displayed on this page.
|On the all_contacts_deleted page, user can go back to the homepage | click Homepage link | homepage page will be opened.
|On the all_contacts_deleted page, user can also add new contact | click add new contact link | add_new_contact form page will open
|If there isn't any contact in the address book, yet | address list = 0 | "There is no contact in the address book, please add new contact (link)."
|user can choose to view all contacts from contact_created page | click view all contacts link | view_all_contacts page will open and display the list of all saved contacts.
|user can delete the existing contact | click clear all button | all contacts will be deleted and all_contacts_deleted page will open with message "You have DELETED ALL CONTACTS in your Address book!"

## Setup/Installation Requirements
1. Open PowerShell
2. >git clone https://github.com/TalayRuk/Addressbook.git
3. >cd Addressbook
4. >dnx kestrel
1. open [http://localhost:5004](http://localhost:5004) on Chrome web browser


## Known Bugs
_none_

## Support and contact details
_Contact me at vjde28@gmail.com_

## Technologies Used

1. HTML
2. NANCY
3. RAZOR
4. OBJECT-ORIENTED C#


## License

_*MIT Creative Commons*_

_Copyright (c) 2016 Vichitra Pool at Epicodus_
