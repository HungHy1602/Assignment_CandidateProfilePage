using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Candidate_Services;
using Candidate_BuisinessObjects;

namespace CandidateManagementWebsite.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IHRAccountService _service;

        // Thuộc tính lưu trữ trạng thái đăng nhập
        public bool IsLoggedIn => HttpContext.Session.TryGetValue("RoleID", out _);
        public string Username { get; private set; }

        public LoginModel(IHRAccountService service)
        {
            _service = service;
        }

        public void OnPost()
        {
            string email = Request.Form["Username"];
            string password = Request.Form["Password"];

            Hraccount account = _service.GetHraccountByEmail(email);
            if (account != null && account.Password.Equals(password))
            {
                // Lưu RoleID trong session
                string RoleID = account.MemberRole.ToString();
                HttpContext.Session.SetString("RoleID", RoleID);
                Username = email; // Lưu tên người dùng để hiển thị
                Response.Redirect("/CandidateProfilePage");
            }
            else
            {
                Response.Redirect("/Error");
            }
        }

        public IActionResult OnPostLogout()
        {
            // Xóa thông tin đăng nhập khỏi session
            HttpContext.Session.Remove("RoleID");
            return RedirectToPage("/Login");
        }
    }
}
