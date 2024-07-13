
using BoletoBus.Mesa.Application.Base;
using BoletoBus.Mesa.Application.Dtos;
using BoletoBus.Mesa.Application.Interfaces;
using BoletoBus.Mesa.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using BoletoBus.Mesa.Domain.Entities;

namespace BoletoBus.Mesa.Application.Services
{
    public class MesaService : IMesaService
    {
        private readonly IMesaRepository mesaRepository;
        private readonly ILogger<MesaService> logger;

        public MesaService(IMesaRepository mesaRepository, ILogger<MesaService> logger)
        {
            this.mesaRepository = mesaRepository;
            this.logger = logger;
        }
        public ServiceResult GetMesa()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = mesaRepository.GetAll();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "No se puedo obtener las mesas";
                
            }
            return result;
        }
        public ServiceResult ActualizarMesa(MesaUpdateModel UpdateMesa)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                if (UpdateMesa is null)
                {
                    result.Success = false;
                    result.Message = "";
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "No se puedo actualizar los usuarios";
            }
            return result;
        }

        public ServiceResult GetMesas(int id)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = this.mesaRepository.GetEntityBy(id);
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "No se puedo obtener los usuarios";
            }
            return result;
        }

        public ServiceResult SaveMesa(MesaSaveModel? SaveMesa)
        {
            ServiceResult result = new ServiceResult();

            try
            {
               

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "No se puedo guardar la mesa";
            }
            return result;
        }
        public ServiceResult DeleteMesa(MesaDeleteModel DeleteMesa)
        {
            ServiceResult result = new ServiceResult();

            try
            {

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "No se puedo eliminar las mesas";
            }
            return result;
        }
    }
}

