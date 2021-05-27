# GamerHQ
Thank you for reading! I will try to keep this from being ridiculously long. This project was the final project for the red badge portion of 1150 Academy Software Dev course. 

To start, I made a WebMVC application in VS Studio 2019 and set up all the layers on an n-tier application. My plans for this app were a little more than I was able to get accomplished and some features of the app are stretch goals that will get completed after I finish with 1150.  

The main goal of this app was to create a place where gamers could go and find other people who share similar interests as them. A feature of this app is the ability to select from the list of games which ones you enjoy playing so when people are looking for a squadmate they can see if you play the same games as them. This feature works when creating a user but I still need to get the partial view to work on the details of a user, so its only half complete for now. One stretch goal I plan to add in is the ability to have chat rooms and voice channels but that was too much for the scope of the project and time given.

I will give a quick breakdown of the features of the crud methods. 
The User Index view shows a list of users who have made an account on the site as well as a search bar that lets you search users by Age or by Platform. Additional search criteria will be implemented for Genre later on.


UserCreate- When creating a new user you are prompted with some fields that ask for your Name(optional), GamerTag, Email, Age, what Gaming Platform you play on, and the Preferred Game Genre you like to play as well as a checkbox of games to pick from (again this is in progress for the edit and details portion)

User Edit - As of now you can edit anyones information on their account so that is to be limited with "UserRoles" and "AdminRoles" later. The purpose of User Edit though is so people can change their own information if need be.

User Details - This is used to see the details of other Users in the event that you want to reach out and add someone to play together. Once the games they have selected appear on the details view it will add more information but for now it just shows their basic information. 

User Delete - Does what it says. As of now a user can delete anyone, this is also going to be limited with "UserRoles" and "AdminRoles"

We also have the ability to add games to the database for people to chose from. The list is not large at the moment but its just for testings sake. Currently users have the ability to access the back end part of the games but that is going to be changed as well with the admin and user roles. 
The games portion is mainly for the admin to take care of, Users should be focused on finding friends to play with not adding or editing games.

Game Create - allows the admin to enter the name of a game and its genre. The games table has a CreatedUtc property but the main function of this was going to be so once the database is filled out and new games come out and we add them on site people could filter the games by "Newest" and add any new games to their account(assuming they play it) 
Game Edit - Its here but doubtful its used since the Game name and the Genre rarely change. 
Game Details - Shows the name, Genre, and createdUtc. 
Game Delete- Deletes games out of the database.

There is also a JoiningTable class that exists to join together user and game so users can select what games they actively play. 

There also is an Enum class that has the Enum for Platforms and the enum for Genre. This class was mainly so it was easier to find and update these properties, it does not have a virtual property that navigates it to any other classes though. 

All in all the app runs but it still needs some TLC to get it where I originally invisioned it being. Thank you for reading, I look forward to updating this in the future when more progress is accomplished!
