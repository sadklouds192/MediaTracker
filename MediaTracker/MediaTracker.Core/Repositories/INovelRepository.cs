using MediaTracker.Core.DataModels;

namespace MediaTracker.Core.Repositries;

public interface INovelRepository
{
    Task<IEnumerable<NovelModel>> GetNovelsAsync();
    Task<NovelModel> GetNovelIdAsync(int id);
    Task AddNovelAsync(NovelModel novel);
    Task UpdateNovelAsync(NovelModel novel);
    Task DeleteNovelAsync(int id);
}