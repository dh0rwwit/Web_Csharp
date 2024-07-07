using Microsoft.AspNetCore.Builder;



namespace WebProject
{

    public class Startup
    {

        public void ConfigureServices(IServiceCollection services) // ConfigureService라고 하면 안되고 ConfigureServices라고 이름을 지어줘야한다....
        {
            services.AddRazorPages(); 
            // 변경
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (!env.IsDevelopment())
            {
                app.UseHsts();
            }
            app.UseRouting();
            app.UseHttpsRedirection();
            
            // 정적요소 서비스를 위해 아래 메서드를 호출한다.
            
            app.UseDefaultFiles();
            app.UseStaticFiles();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapGet("/IdxRoot", () => "Print");
                endpoints.MapGet("/Pages/Index", () => "Hello StartUp");
            });

        }
    }
}
