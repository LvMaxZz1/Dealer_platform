namespace Dearlelatform.Web.Extensions;

public static class WebApplicationAppExtensions
{
    public static void IntiEnter(this IApplicationBuilder app)
    {
        app.UseCors("any");

        app.UseAuthentication();

        app.UseSwagger();

        app.UseSwaggerUI();

        app.UseHttpsRedirection();

        app.UseAuthorization();
    }
    public static void IntiMap(this IEndpointRouteBuilder app)
    {
        app.MapControllers();
    }
}
