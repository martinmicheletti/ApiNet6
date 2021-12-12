using Api.Controllers.Posts;
using Api.Entities.Entity;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//var Result<List<Post>> GetPosts(){
//}

var posts = new Posts();

app.UseSwaggerUI();

app.UseSwagger(x => x.SerializeAsV2 = true);

app.MapGet("/v1/Post/GetAll", posts.GetPosts);

app.Run();
