using Microsoft.Extensions.Options;
using SampleApi.Implimentations;

public class XctFisClient : FisClientBase
{
    public XctFisClient(IOptions<XctFisEndpoints> fisEndpoint) : base(fisEndpoint)
    {
    }
    public override string PaymentInstrument => "xct";
}