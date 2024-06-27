using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Netflix.Solution.Controllers.Areas.Netflix.Models.Common;
using Netflix.Solution.Controllers.Areas.Netflix.Models.Content;
using Netflix.Solution.Controllers.Areas.Netflix.Services.Content;

namespace Netflix.Solution.Controllers.Areas.Netflix.Controllers.Content
{
    [Area("netflix")]
    [Route("netflix/api/[controller]")]
    [Authorize]
    public class ContentController(IContentService _contentService) : Controller
    {
        [HttpGet("items")]
        public CommonResponse<IEnumerable<ContentItem>> GetContents()
        {
            return _contentService.GetContentItems();
        }
    }
}
