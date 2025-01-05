using Microsoft.Extensions.Options;

namespace SampleApi.Implimentations
{
    public abstract class FisClientBase(IOptions<IFisEndpointConfig> fisEndpoint) : IFisClient
    {
        public virtual string PaymentInstrument { get; }

        private IFisEndpointConfig _fisEndpoint { get; } = fisEndpoint.Value;

        public string SubmitToFis(string messageType)
        {
            return $@"{_fisEndpoint.BaseUrl}/{_fisEndpoint.EndPoints.FirstOrDefault(p=> p.MessageType == messageType)?.EndPoint}";
        }
    }
}