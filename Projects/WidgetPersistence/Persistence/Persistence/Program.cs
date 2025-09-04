// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PersistenceDAL.DAL;

Console.WriteLine("Hello, World!");

string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Dropbox\\Neumont\\Courses\\CSC160 - App Dev\\Code\\Persistence\\PersistenceDAL\\TestDB.mdf\";Integrated Security=True";

var builder = new DbContextOptionsBuilder<WidgetContext>();
builder.UseSqlServer(connectionString);

WidgetContext context = new WidgetContext(builder.Options);

context.Database.EnsureCreated();