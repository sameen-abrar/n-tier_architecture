using AutoMapper;
using BLL.DTO;
using DAL.EF;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.services
{
     public class userService
    {
        public static List<userDTO> Get()
        {
            var data = DataAccessFactory.UserDataAccess().Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<user, userDTO>();
            });
            var mapper = new Mapper(config);
            var conv = mapper.Map<List<userDTO>>(data);
            return conv;

        }
        public static userDTO Get(int id)
        {
            var data = DataAccessFactory.UserDataAccess().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<user, userDTO>();
            });
            var mapper = new Mapper(config);
            var conv = mapper.Map<userDTO>(data);
            return conv;

        }
        public static userDTO Add(userDTO obj)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<userDTO, user>();
                cfg.CreateMap<user, userDTO>();
            });
            var mapper = new Mapper(config);
            var conv = mapper.Map<user>(obj);
            var rs = DataAccessFactory.UserDataAccess().Add(conv);

            return mapper.Map<userDTO>(rs);

        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.UserDataAccess().Delete(id);

        }

        public static bool Update(userDTO obj)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<userDTO, user>();
            });
            var mapper = new Mapper(config);
            var conv = mapper.Map<user>(obj);
            var rs = DataAccessFactory.UserDataAccess().update(conv);

            return rs;

        }
        

    }
}
