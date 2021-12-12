using Api.Entities.Entity;
using Api.Entities.Results;

namespace Api.Controllers.Posts
{
    public class Posts
    {
        public Posts()
        {

        }

        public Result<List<int>> GetPosts()
        {
            var result = new Result<List<int>>();

            try {
                var posts = new List<int>() { 1, 2, 3, 4 };
                result.Data = posts;
                result.Success = true;
                result.Status = System.Net.HttpStatusCode.OK;
            } catch (Exception ex) {
                result.Success = false;
                result.Status = System.Net.HttpStatusCode.BadRequest;
                result.Message = ex.Message;
            }

            return result;
        }

    }
}
