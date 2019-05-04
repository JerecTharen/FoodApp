using System;
using System.Collections.Generic;

namespace foodApp.DataModels
{
    public partial class Users
    {
        public long Uid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ProfilePicutre { get; set; }
        public string AddedRecipesTable { get; set; }
        public string SavedRecipesTable { get; set; }
        public string FriendsTable { get; set; }
    }
}
