using MediaTracker.Core.DataModels;

namespace MediaTracker.Core.Repositries;

public interface INovelRepositry
{
    Task<IEnumerable<NovelModel>> GetAllAsync();
    Task<NovelModel> GetNovelIdAsync(int id);
    Task AddNovelAsync(NovelModel novel);
    Task UpdateNovelAsync(NovelModel novel);
    Task DeleteNovelAsync(int id);
}