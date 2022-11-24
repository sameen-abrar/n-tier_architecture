using AutoMapper;
using BLL.DTO;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BLL.services
{
    public class groupService
    {
        public static List<groupDTO> Get()
        {
           var data = DataAccessFactory.GroupDataAccess().Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<group, groupDTO>();
            });
            var mapper  = new Mapper(config);
            var conv = mapper.Map<List<groupDTO>>(data);
            return conv;

        }
        public static groupDTO Get(int id)
        {
            var data = DataAccessFactory.GroupDataAccess().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<group, groupDTO>();
            });
            var mapper = new Mapper(config);
            var conv = mapper.Map<groupDTO>(data);
            return conv;

        }
        public static groupDTO Add(groupDTO obj)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<groupDTO, group>();
                cfg.CreateMap<group, groupDTO>();
            });
            var mapper = new Mapper(config);
            var conv = mapper.Map<group>(obj);
            var rs = DataAccessFactory.GroupDataAccess().Add(conv);

            return mapper.Map<groupDTO>(rs);

        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.GroupDataAccess().Delete(id);

        }

        public static bool Update(groupDTO obj)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<groupDTO, group>();
            });
            var mapper = new Mapper(config);
            var conv = mapper.Map<group>(obj);
            var rs = DataAccessFactory.GroupDataAccess().update(conv);

            return rs;

        }
    }
}
