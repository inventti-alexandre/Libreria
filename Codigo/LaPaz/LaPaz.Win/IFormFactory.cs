using System;
using System.Windows.Forms;
using LaPaz.Entidades;
using LaPaz.Win.Enums;

namespace LaPaz.Win
{
    public interface IFormFactory
    {
        T Create<T>() where T : Form;
        T Create<T>(int id) where T : Form;
        T Create<T>(Guid id) where T : Form;
        T Create<T>(Guid id,ActionFormMode mode) where T : Form;
        T Create<T>(int id, ActionFormMode mode) where T : Form;

        T Create<T>(TipoProveedor tipoProveedor) where T : Form;
    }
}
