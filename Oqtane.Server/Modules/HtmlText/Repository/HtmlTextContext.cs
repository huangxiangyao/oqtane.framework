using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Oqtane.Documentation;
using Oqtane.Infrastructure;
using Oqtane.Repository;
using Oqtane.Repository.Databases.Interfaces;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace Oqtane.Modules.HtmlText.Repository
{
    [PrivateApi("Mark HtmlText classes as private, since it's not very useful in the public docs")]
    public class HtmlTextContext : DBContextBase, IService, IMultiDatabase
    {
        public HtmlTextContext(ITenantManager tenantManager, IHttpContextAccessor httpContextAccessor) : base(tenantManager, httpContextAccessor) { }

        public virtual DbSet<Models.HtmlText> HtmlText { get; set; }
    }
}
