using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]

    public class SocialMediaController : ControllerBase
    {
        [HttpGet("youtube")]
        public async Task<IActionResult> GetYoutubeDetails()
        {
            await Task.Delay(1000);
            return Ok(new
            {
                Followers = 12458
            });
        }
        [HttpGet("twitter")]
        public async Task<IActionResult> GetTwitterDetails()
        {
            await Task.Delay(1000); 
            return Ok(new
            {
                Followers = 12490
            });
        }
        [HttpGet("github")]
        public async Task<IActionResult> GetGithubDetails()
        {
            await Task.Delay(1000);
            return Ok(new
            {
                Followers = 4500
            });
        }
    }
}