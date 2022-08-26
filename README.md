# Dating-App
Dating App buiilt with Blazor Server Application, C# and SQL.
Project was built with NicklasElBeik @ https://github.com/NicklasElBeik

The project was a part of a school project where we had to build a blazor app with requirements.

1. Create/delete an account/account. (requirement: use stored procedure).
2. Log in and log out. (Requirement: sql injection must not be possible).
3. Create/delete profile: describe yourself: age, height, weight and gender (deletion: just one field it is set to 1).
4. carry out searches using e.g. boxes/radio buttons etc.
5. See results of searches.
6. Be able to 'like' a person, write to a person, and see who has 'liked' them themselves. Note: you can only write to a person if you have 'liked' each other
i.e. there must be a match before you can write to another person. 
It is perfectly fine if the correspondence takes place asynchronously, i.e. write (insert row on table) read (read row on table).
7. There must be an event on either: by like, by match or by message.
