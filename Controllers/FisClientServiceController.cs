using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/FisClientService")]
public class FisClientServiceController(IEnumerable<IFisClient> fisClients) : ControllerBase
{
    private readonly IEnumerable<IFisClient> _fisClients = fisClients;

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [Route("/FisClientInfo")]
    public IActionResult GetFisClientInfo(string paymentInstrument, string messageType)
    {
        var fisClinet = _fisClients.FirstOrDefault(p=> p.PaymentInstrument == paymentInstrument);
        return Ok(fisClinet.SubmitToFis(messageType));
    }
}