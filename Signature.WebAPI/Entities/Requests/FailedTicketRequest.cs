namespace Signature.WebAPI.Entities.Requests
{
    public class FailedTicketRequest
    {
        /// <summary>
        /// CodigoEmpresa
        /// </summary>
        public string Empresa { get; set; }
        /// <summary>
        /// FechaIni
        /// </summary>
        public string FechaIni { get; set; }
        /// <summary>
        /// FechaFin
        /// </summary>
        public string FechaFin { get; set; }
    }
}
