using Microsoft.AspNetCore.Builder;
using WebProject;

#region 기존의 프로그램 진입점을 Startup.cs로 지정

// Razor Page가 응답할 수 있도록 Ma
Host.CreateDefaultBuilder(args)
	.ConfigureWebHostDefaults(webBuilder =>
	{
		webBuilder.UseStartup<Startup>();
	}).Build().Run();



#endregion



#region 맨 처음 프로그램 진입점
/*
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts(); // 개발단계에서 HTTPS로 
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection(); // HTTPS로 Redirect


app.MapGet("/", () => "Hello HTTPS!"); // /뒤에 아무것도 없으면 Program.cs 본 파일을 실행한다.

app.Run();
// appsettings.json 에서 호스트넘버 검사가능하다.
*/
#endregion

