using BoletoBus.Menu.Application.Base;
namespace BoletoBus.Web.Services.Core
{
    public interface IBaseServices<TResult, TDetail, TAddModel, TUpdateModel>
    {
        Task<TResult> Get();
        Task<TDetail> GetById(int Id);
        Task<TAddModel> Save(TAddModel model);
        Task<TUpdateModel> Update(TUpdateModel model);
    }
}
