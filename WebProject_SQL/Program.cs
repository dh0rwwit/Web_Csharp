using Microsoft.AspNetCore.Builder;
using WebProject;

#region ������ ���α׷� �������� Startup.cs�� ����

// Razor Page�� ������ �� �ֵ��� Ma
Host.CreateDefaultBuilder(args)
	.ConfigureWebHostDefaults(webBuilder =>
	{
		webBuilder.UseStartup<Startup>();
	}).Build().Run();



#endregion



#region �� ó�� ���α׷� ������
/*
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts(); // ���ߴܰ迡�� HTTPS�� 
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection(); // HTTPS�� Redirect


app.MapGet("/", () => "Hello HTTPS!"); // /�ڿ� �ƹ��͵� ������ Program.cs �� ������ �����Ѵ�.

app.Run();
// appsettings.json ���� ȣ��Ʈ�ѹ� �˻簡���ϴ�.
*/
#endregion

