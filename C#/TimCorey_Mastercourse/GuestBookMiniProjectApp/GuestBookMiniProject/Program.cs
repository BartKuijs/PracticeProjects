

using GuestBookMiniProject;


GuestBookMethods.WelcomeToGuestBook();

var (guests, totalguests) = GuestBookMethods.GetAllGuests();

GuestBookMethods.EndOfPartyResult(guests, totalguests);

