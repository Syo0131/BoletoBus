
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
            var mesas = mesaRepository.GetAll();
            var mesasDtos = mesas.Select(r => new MesaDtoAdd
            {
                Capacidad = r.Capacidad,
                Estado = r.Estado,
            }).ToList();

            return new ServiceResult
            {
                Success = true,
                Message = "Mesa obtenida correctamente",
                Result = mesasDtos
            };
        }


        public ServiceResult GetMesas(int id)
        {
            var mesas = mesaRepository.GetEntityBy(id);
            if (mesas == null)
            {
                return new ServiceResult
                {
                    Success = false,
                    Message = "Menu no encontrado"
                };
            }

            var MesaDto = new MesaDtoAdd
            {
                Capacidad = mesas.Capacidad,
                Estado = mesas.Estado,

            };

            return new ServiceResult
            {
                Success = true,
                Message = "Mesa obtenida correctamente",
                Result = MesaDto
            };
        }

        public ServiceResult SaveMesa(MesaSaveModel SaveMesa)
        {
            Domain.Entities.Mesa mesa = new Domain.Entities.Mesa
            {
                Id = SaveMesa.IdMesa,
                Capacidad = SaveMesa.Capacidad,
                Estado = SaveMesa.Estado,
            };

            this.mesaRepository.Save(mesa);
            return new ServiceResult
            {
                Success = true,
                Message = "Se añadio la mesa correctamente.",
            };
        }
        public ServiceResult ActualizarMesa(MesaUpdateModel UpdateMesa)
        {
            var Umesa = mesaRepository.GetEntityBy(UpdateMesa.IdMesa);
            if (Umesa == null)
            {
                return new ServiceResult
                {
                    Success = false,
                    Message = "Mesa no encontrada"
                };
            }



            Umesa.Capacidad = UpdateMesa.Capacidad;
            Umesa.Estado = UpdateMesa.Estado ?? Umesa.Estado;


            this.mesaRepository.Update(Umesa);
            return new ServiceResult
            {
                Success = true,
                Message = "Mesa actualizada con exito"
            };
        }
        public ServiceResult DeleteMesa(MesaDeleteModel DeleteMesa)
        {
            var Dmesa = mesaRepository.GetEntityBy(DeleteMesa.IdMesa);
            if (Dmesa == null)
            {
                return new ServiceResult
                {
                    Success = false,
                    Message = "Mesa no encontrada"
                };
            }
            mesaRepository.Delete(Dmesa);
            return new ServiceResult
            {
                Success = true,
                Message = "Mesa Elmininada con exito"
            };
        }
    }
}

