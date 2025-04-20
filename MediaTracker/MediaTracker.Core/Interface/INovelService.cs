using MediaTracker.Core.DataModels;

namespace MediaTracker.Core.Interface;

public interface INovelService
{
    Task<IEnumerable<NovelModel>> GetNovelsAsync();
    Task<NovelModel> GetNovelAsync(int id);
    Task AddNovelAsync(NovelModel model);
    Task UpdateNovelAsync(NovelModel model);
    Task DeleteNovelAsync(int id);
}