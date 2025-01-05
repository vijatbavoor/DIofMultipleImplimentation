using Microsoft.Extensions.Options;
using SampleApi.Implimentations;

public class SctFisClient : FisClientBase
{
    public SctFisClient(IOptions<SctFisEndpoints> fisEndpoint) : base(fisEndpoint)
    {
    }

    public override string PaymentInstrument => "sct";
}