using Microsoft.AspNetCore.Identity;

namespace UNeedTickets.Models
{
    public class ShowUserAccountsViewModel
    {
        public List<IdentityUser> Users { get; set; }
        //public List<YourCustomModel> CustomDataList { get; set; }
    }
}
