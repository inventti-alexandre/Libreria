using System;
using System.Windows.Forms;
using LaPaz.Win.Enums;

namespace LaPaz.Win
{
    public interface IUserControlFactory
    {
        T Create<T>() where T : UserControl;
    }
}
