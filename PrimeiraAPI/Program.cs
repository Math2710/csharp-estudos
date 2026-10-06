namespace PrimeiraAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(); // Adicionado

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();   // Adicionado
                app.UseSwaggerUI(); // Adicionado
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
