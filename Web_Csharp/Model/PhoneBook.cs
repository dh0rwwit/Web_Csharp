using System.ComponentModel.DataAnnotations;


namespace WebProject.Model
{
	// sql 연결시 필요한 것
	public class PhoneBook
	{
		[Required(ErrorMessage = "이름을 입력해주세요.")] // 아래 Name은 반드시 입력이 필요한 요소임을 나타낸 것
		public string? Name { get; set; }
		public string? PhoneNumber { get; set; }
	}
}
