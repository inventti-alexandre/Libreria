﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPaz.Entidades
{
    [MetadataType(typeof(CompraMetadata))]
    public partial class Compra
    {
    }
    class CompraMetadata
    {
        //[Required(ErrorMessage = "Debe ingresar una denominación")]
        //public string Denominacion { get; set; }

        //[Required(ErrorMessage = "Debe ingresar una domicilio")]
        //public string Domicilio { get; set; }

        //[Required(ErrorMessage = "Debe ingresar un CUIT/DNI")]
        //[MaxLength(11, ErrorMessage = "El número de cuit/DNI no es válido")]
        //[RegularExpression("^[0-9]{8,11}?$", ErrorMessage = "El número de cuit/DNI no es válido")]
        //public string Cuit { get; set; }

        //[DataType(DataType.EmailAddress)]
        //[EmailAddress(ErrorMessage = "El email no es válido")]
        //public string Mail { get; set; }

        //[Required(ErrorMessage = "Debe seleccionar una opción")]
        //[Range(1, 150, ErrorMessage = "Debe seleccionar una opción")]
        //public int? CondicionVentaId { get; set; }

        //[MaxLength(15, ErrorMessage = "Debe tener como máximo 15 elementos")]
        //public string Celular { get; set; }
    }
}
