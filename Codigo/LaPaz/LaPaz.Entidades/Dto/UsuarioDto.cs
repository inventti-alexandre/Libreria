using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Comun.Mapping;

namespace LaPaz.Entidades.Dto
{
    public class UsuarioDto : IHaveCustomMappings
    {
        public Guid Id { get; set; }
        public string Denominacion { get; set; }
        public string Usuario { get; set; }
        public string Cuit { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string HoraDesdeT { get; set; }
        public string HoraHastaT { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }

        public void CreateMappings(AutoMapper.IConfiguration configuration)
        {
            configuration.CreateMap<Operador, UsuarioDto>()
                .ForMember(m => m.Denominacion, opt =>
                                        opt.MapFrom(u => u.Personal.Nombre))
                .ForMember(m => m.Cuit, opt =>
                                        opt.MapFrom(u => u.Personal.Cuit))
                .ForMember(m => m.Domicilio, opt =>
                                             opt.MapFrom(u => u.Personal.Domicilio))
                .ForMember(m => m.Telefono, opt =>
                                            opt.MapFrom(u => u.Personal.Telefono))
                .ForMember(m => m.Celular, opt =>
                                           opt.MapFrom(u => u.Personal.Celular))
                .ForMember(m => m.HoraDesdeT, opt =>
                                              opt.MapFrom(u => u.Personal.HoraDesdeT))
                .ForMember(m => m.HoraHastaT, opt =>
                                              opt.MapFrom(u => u.Personal.HoraHastaT))
                .ForMember(m => m.Localidad, opt =>
                                              opt.MapFrom(u => u.Personal.Localidad.Nombre))
                .ForMember(m => m.Provincia, opt =>
                                              opt.MapFrom(u => u.Personal.Provincia.Nombre));
        }
    }
}
