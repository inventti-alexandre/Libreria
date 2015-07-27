namespace Framework.WinForm.Comun.Notification
{
    public class MensajeGenerico
    {
        public string Titulo { get; set; }
        public string Mensaje { get; set; }
        public TipoMensajeGenerico Tipo { get; set; }
    }

    public enum TipoMensajeGenerico
    {
        Error,
        Advertencia,
        Exito,
        Info
    }
}
