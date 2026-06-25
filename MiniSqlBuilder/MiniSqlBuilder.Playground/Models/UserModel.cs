using MiniSqlBuilder.Lib.Attributes;

namespace MiniSqlBuilder.Playground.Models;

[MsbTable("USUARIO_SITE")]
public class UserModel
{
    [MsbColumn("id")]
    public int Id { get; set; }

    [MsbColumn("name")]
    public string? Name { get; set; }

    [MsbColumn("email")]
    public string? Email { get; set; }

    [MsbColumn("created_at")]
    public DateTime? CreatedAt { get; set; }

    [MsbColumn("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [MsbColumn("deleted_at")]
    public DateTime? DeletedAt { get; set; }
}