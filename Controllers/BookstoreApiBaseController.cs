using Microsoft.AspNetCore.Mvc;

namespace BookstoreApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public abstract class BookstoreApiBaseController : ControllerBase
{
}
