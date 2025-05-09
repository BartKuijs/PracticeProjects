
// Welcome message
// Gathering information: first / last name, age, message to host
// calculating average age
// print information for each person and the average age of the guests.


using SelfGuestBookProject;
using UserInformationHandler;



UserMessages.WelcomeMessage();


List<UserData>guests = GetUserInformation.GetUserInfo();


UserMessages.EndMessage(guests);

