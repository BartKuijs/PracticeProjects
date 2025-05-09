
using BetterGuestBookProject;
using GuestBookLibrary.Models;

// Capture the information about each guest. (assumption is at least one guest and unknown maximum.)
// Info to capture: First name, Last name, message to the host
// Once done, loop through each guest and print the info.




List<GuestModel> guests = GuestInformation.GetGuestInformation();

GuestInformation.PrintGuestInformation(guests);


