using MediaTracker.Core.DataModels;
using MediaTracker.Core.Interface;
using MediaTracker.Core.Repositries;

namespace MediaTracker.Core.Services;

public class NovelService : INovelService
{
    private readonly INovelRepository _novelRepository;
    public NovelService(INovelRepository novelRepository)
    {
        _novelRepository = novelRepository;
    }
    public async Task<IEnumerable<NovelModel>> GetNovelsAsync()
    {
        return await _novelRepository.GetNovelsAsync();
    }

    public async Task<NovelModel> GetNovelAsync(int id)
    {
        return await _novelRepository.GetNovelIdAsync(id);
    }

    public async Task AddNovelAsync(NovelModel model)
    {
        await _novelRepository.AddNovelAsync(model);
    }

    public async Task UpdateNovelAsync(NovelModel model)
    {
        await _novelRepository.UpdateNovelAsync(model);
    }

    public async Task DeleteNovelAsync(int id)
    {
        await _novelRepository.DeleteNovelAsync(id);
    }
}