namespace AdminTool.Data;

public class User
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public Platform Platform { get; set; }

    public int JoinMonth { get; set; }
}
