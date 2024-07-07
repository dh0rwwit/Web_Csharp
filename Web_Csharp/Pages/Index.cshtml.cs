using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebProject.Data;
using WebProject.Model;
using System;
using System.Collections.Generic;

namespace WebProject.Pages
{
	public class IndexModel : PageModel
	{
		[BindProperty]
		public PhoneBook? phoneBook { get; set; }
		public DateTime NowDay { get; set; }
		public List<PhoneBook>? Names { get; set; }

		public void OnGet()
		{
			ViewData["Title"] = "메인페이지 입니다.";
			NowDay = DateTime.Now;
			Names = DataPhoneBook.Names;

			if (Names.Count == 0)
			{
				Names.Add(new PhoneBook { Name = "dhkim0", PhoneNumber = "010-1234" });
				Names.Add(new PhoneBook { Name = "khk", PhoneNumber = "010-4567" });
			}
		}

		public IActionResult OnPost()
		{
			if (ModelState.IsValid && phoneBook != null && ModelState.IsValid)
			{
				DataPhoneBook.Names.Add(phoneBook);
				return RedirectToPage("/Index");
			}
			else
			{
				Names = DataPhoneBook.Names;
				return Page();
			}
		}
	}
}


/*using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebProject.Data;
using WebProject.Model;
using System;
using System.Collections.Generic;


namespace WebProject.Pages
{
    public class IndexModel : PageModel
    {
		[BindProperty]
		public PhoneBook? phoneBook { get; set; }

		public DateTime NowDay { get; set; }

        public List<PhoneBook>? Names { get; set; }

        public void OnGet()
        {
            ViewData["Title"] = "메인페이지 입니다.";
            NowDay = DateTime.Now;
			Names = new() 
            { 
                new() { Name = "dhkim0", PhoneNumber = "010-1234" }
                ,new() { Name = "khk", PhoneNumber = "010-4567" } 
            };
		}
		public IActionResult OnPost()
        {
			if (DataPhoneBook.Names != null && phoneBook != null && ModelState.IsValid)
			{
				DataPhoneBook.Names.Add(phoneBook);
				return RedirectToPage("/Index");
			}
			else
				return Page();
		}
    }
    public class PhoneBook : DataPhoneBook
	{
		public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
*/