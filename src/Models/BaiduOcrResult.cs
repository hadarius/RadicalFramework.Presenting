namespace Radical.Presenting.Components;

public class BaiduOcrResult<TEntity>
{
    public int ErrorCode { get; set; }

    public string? ErrorMessage { get; set; }

    public TEntity? Entity { get; set; }
}
