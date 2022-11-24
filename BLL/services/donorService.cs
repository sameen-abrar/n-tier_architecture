using AutoMapper;
using BLL.DTO;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.services
{
    public class donorService
    {
        public static List<donorDTO> Get()
        {
            var data = DataAccessFactory.DonorDataAccess().Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<donor, donorDTO>();
            });
            var mapper = new Mapper(config);
            var conv = mapper.Map<List<donorDTO>>(data);
            return conv;

        }
        public static donorDTO Get(int id)
        {
            var data = DataAccessFactory.DonorDataAccess().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<donor, donorDTO>();
            });
            var mapper = new Mapper(config);
            var conv = mapper.Map<donorDTO>(data);
            return conv;

        }
        public static donorDTO Add(donorDTO obj)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<donorDTO, donor>();
                cfg.CreateMap<donor, donorDTO>();
            });
            var mapper = new Mapper(config);
            var conv = mapper.Map<donor>(obj);
            var rs = DataAccessFactory.DonorDataAccess().Add(conv);

            return mapper.Map<donorDTO>(rs);

        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.DonorDataAccess().Delete(id);

        }

        public static bool Update(donorDTO obj)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<donorDTO, donor>();
            });
            var mapper = new Mapper(config);
            var conv = mapper.Map<donor>(obj);
            var rs = DataAccessFactory.DonorDataAccess().update(conv);

            return rs;

        }
    }
}
