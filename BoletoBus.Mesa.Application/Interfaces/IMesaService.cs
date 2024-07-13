using BoletoBus.Mesa.Application.Base;
using BoletoBus.Mesa.Application.Dtos;


namespace BoletoBus.Mesa.Application.Interfaces
{
    public interface IMesaService
    {
        ServiceResult GetMesa();
        ServiceResult GetMesas(int id);
        ServiceResult SaveMesa(MesaSaveModel SaveMesa);
        ServiceResult ActualizarMesa (MesaUpdateModel UpdateMesa);
        ServiceResult DeleteMesa (MesaDeleteModel DeleteMesa);
    }
}
