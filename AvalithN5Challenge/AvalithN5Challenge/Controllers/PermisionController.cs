using AvalithN5Challenge.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace AvalithN5Challenge.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class PermisionController : ControllerBase
    {
    }


    [HttpPost(Name = "PermissionType")]
    public async Task<ActionResult<PermissionType>>  PostPermissiontType(PermissionType permissionType)
    {
        ApplicationDbContext db = new ApplicationDbContext();
        db.PermissionType.Add(permissionType);
        await db.SaveChangesAsync();

        return CreatedAtAction("GetPermissionType", new { id = permissionType.Id }, permissionType);

    }

    [HttpGet("{id}")]
    public async Task<ActionResult<PermissionType>?> GetPermissionType(int id)
    {
        var permissionType = await.db.PermissionType.FindAsync(id);
        if(permissionType == null)
        {
            return null;

        }
        return permissionType;
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<PermissionType>?> DeletePermissionType(int id)
    {
        var permissionType = await.Db.PermissionType.FindAsync(id);
        if(permissionType == null) { return null; }
        db.PermissionType.Remove(permissionType);
        await.db.SaveChangesAsync();

        return permissionType;

    }



}
